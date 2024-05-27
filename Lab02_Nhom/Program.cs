using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;

namespace Lab02_Nhom
{
    public static class Global_Support
    {
        public static string MaNV { get; set; }
        public static string Mk { get; set; }
        public static string strCon { get; set;}
    public static void OpenSQL(SqlConnection sqlCon)
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
        }
        public static byte[] SHA1_Hash(string plaintext)
        {
            byte[] hashByte;
            byte[] plaintext_byte = Encoding.UTF8.GetBytes(plaintext);
            SHA1 sha1 = SHA1.Create();
            hashByte = sha1.ComputeHash(plaintext_byte);
            return hashByte;
        }
    }
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
