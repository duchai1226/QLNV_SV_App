using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lab02_Nhom
{
    internal class RSA512
    {
        private static RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(512);
        private RSAParameters _privateKey;
        private RSAParameters _publicKey;
        public static byte[] iv = new byte[16];
        public RSA512()
        {
            _privateKey = rsa.ExportParameters(true);
            _publicKey = rsa.ExportParameters(false);
        }
        ~RSA512()
        {
            Dispose(false);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (rsa != null)
                {
                    rsa.Dispose();
                    rsa = null;
                }
            }
        }
        public string GetPrivateKey()
        {
            var sw = new StringWriter();
            var xs = new XmlSerializer(typeof(RSAParameters));
            xs.Serialize(sw, _privateKey);
            return sw.ToString();
        }
        public string GetPublicKey()
        {
            var sw = new StringWriter();
            var xs = new XmlSerializer(typeof(RSAParameters));
            xs.Serialize(sw, _publicKey);
            return sw.ToString();
        }
        public static bool CompareRSAParameters(RSAParameters key1, RSAParameters key2)
        {
            return ByteArrayCompare(key1.Modulus, key2.Modulus) &&
                   ByteArrayCompare(key1.Exponent, key2.Exponent) &&
                   ByteArrayCompare(key1.D, key2.D) &&
                   ByteArrayCompare(key1.P, key2.P) &&
                   ByteArrayCompare(key1.Q, key2.Q) &&
                   ByteArrayCompare(key1.DP, key2.DP) &&
                   ByteArrayCompare(key1.DQ, key2.DQ) &&
                   ByteArrayCompare(key1.InverseQ, key2.InverseQ);
        }
        private static bool ByteArrayCompare(byte[] array1, byte[] array2)
        {
            if (array1 == null && array2 == null)
                return true;
            if (array1 == null || array2 == null)
                return false;
            return array1.SequenceEqual(array2);
        }
        public static RSAParameters XmlToRSAPara(string xmlString)
        {
            var sr = new StringReader(xmlString);
            var xs = new XmlSerializer(typeof(RSAParameters));
            return (RSAParameters)xs.Deserialize(sr);
        }
        public static void WriteKeysToFile(string directoryPath, string fileName, string privateKeyXml, string publicKeyXml)
        {
            // Đảm bảo thư mục tồn tại, nếu không thì tạo mới
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            string filePath = Path.Combine(directoryPath, fileName);

            using (var writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Private Key:");
                writer.Write(privateKeyXml);
                writer.WriteLine("End Private Key");
                writer.WriteLine();
                writer.WriteLine("Public Key:");
                writer.WriteLine(publicKeyXml);
            }
        }
        public static void ReadKeysFromFile(string filePath,string key, out RSAParameters privateKey, out RSAParameters publicKey)
        {
            string privateKeyXml;
            string publicKeyXml;
            string fileContent = File.ReadAllText(filePath);
            var privateKeyMatch = Regex.Match(fileContent, @"Private Key:\s*(.*?)\s*End Private Key", RegexOptions.Singleline);
            var publicKeyMatch = Regex.Match(fileContent, @"Public Key:\s*(<\?xml.*?</RSAParameters>)", RegexOptions.Singleline);
            
            if (privateKeyMatch.Success)
            {
                privateKeyXml = privateKeyMatch.Groups[1].Value;
            }
            else
            {
                throw new Exception("Private key not found in the file.");
            }

            if (publicKeyMatch.Success)
            {
                publicKeyXml = publicKeyMatch.Groups[1].Value;
            }
            else
            {
                throw new Exception("Public key not found in the file.");
            }
            byte[] privateKey_byte = ConvertHexStringToByteArray(privateKeyXml);
            privateKeyXml = AES256Decrypt(privateKey_byte,key);
            publicKey = XmlToRSAPara(publicKeyXml);
            privateKey = XmlToRSAPara(privateKeyXml);
            string mk = File.ReadLines(filePath).FirstOrDefault().Substring(5).Trim();
        }
        static byte[] ConvertHexStringToByteArray(string hexString)
        {
            hexString = hexString.Replace("-", "");
            byte[] byteArray = new byte[hexString.Length / 2];
            for (int i = 0; i < hexString.Length; i += 2)
            {
                byteArray[i / 2] = Convert.ToByte(hexString.Substring(i, 2), 16);
            }
            return byteArray;
        }
        public byte[] RSAEncrypt(string plaintext, RSAParameters publicKey)
        {
            rsa = new RSACryptoServiceProvider(512);
            rsa.ImportParameters(publicKey);
            var data = Encoding.UTF8.GetBytes(plaintext);
            var cypher = rsa.Encrypt(data,false);
            return cypher;
        }
        public string Decrypt(byte[] cypherText,string ma)
        {
            RSAParameters publickey= new RSAParameters();
            RSAParameters privatekey= new RSAParameters();
            string filePath = @"../../Keys/" + ma;
            string fileName = ma + ".txt";
            string fullPath= filePath +"/"+ fileName;
            ReadKeysFromFile(fullPath,Global_Support.hashPass,out privatekey,out publickey);
            rsa.ImportParameters(privatekey);
            var plainText = rsa.Decrypt(cypherText, false);
            return Encoding.UTF8.GetString(plainText);
        }
        public static void GenerateIV(string key)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(key);
                byte[] hashBytes = sha256.ComputeHash(inputBytes);
                Array.Copy(hashBytes, iv, 16);
            }
        }
        public static byte[] FillKey(string key)
        {
            byte[] byteKey = Encoding.UTF8.GetBytes(key);
            List<byte> byteKeyList = new List<byte>(byteKey);
            if (byteKeyList.Count > 32)
                byteKeyList = byteKeyList.GetRange(0,32);
            while (byteKeyList.Count < 32)
                byteKeyList.Add(0);
            byteKey = byteKeyList.ToArray();
            return byteKey;
        }
        public byte[] AES256Encrypt(string plaintext, string key)
        {
            byte[] byteKey = FillKey(key);
            GenerateIV(key);
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = byteKey;
                aesAlg.IV = iv;
                aesAlg.Mode = CipherMode.CBC;
                aesAlg.Padding = PaddingMode.PKCS7;
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                byte[] encryptedBytes;
                using (var msEncrypt = new System.IO.MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        byte[] plainBytes = Encoding.UTF8.GetBytes(plaintext);
                        csEncrypt.Write(plainBytes, 0, plainBytes.Length);
                    }
                    encryptedBytes = msEncrypt.ToArray();
                }
                return encryptedBytes;
            }
        }
        public static string AES256Decrypt(byte[] ciphertext, string key)
        {
            byte[] byteKey = FillKey(key);
            GenerateIV(key);
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = byteKey;
                aesAlg.IV = iv;
                aesAlg.Mode = CipherMode.CBC;
                aesAlg.Padding = PaddingMode.PKCS7;
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                byte[] decryptedBytes;
                using (var msDecrypt = new System.IO.MemoryStream(ciphertext))
                {
                    using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (var msPlain = new System.IO.MemoryStream())
                        {
                            csDecrypt.CopyTo(msPlain);
                            decryptedBytes = msPlain.ToArray();
                        }
                    }
                }
                return Encoding.UTF8.GetString(decryptedBytes);
            }
        }

    }
}
