using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_Nhom
{
    public partial class QLNV : Form
    {
        RSA512 rsa512 = new RSA512();
        SqlConnection sqlCon = null;
        public int row;
        public int col;
        public QLNV()
        {
            InitializeComponent();
        }
        private void button_Them_Click(object sender, EventArgs e)
        {
            textBox_MaNV.Enabled = true;
            textBox_MatKhau.Enabled = true;
            textBox_MaNV.Text = textBox_Email.Text=textBox_HoTen.Text=textBox_Luong.Text=textBox_TenDN.Text=textBox_MatKhau.Text=string.Empty;
            textBox_MaNV.Focus();
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void button_Ghi_Click(object sender, EventArgs e)
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(Global_Support.strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlCommand sqlCom = new SqlCommand();
            if (Exec_SP_INS_PUBLIC_ENCRYPT_NHANVIEN(sqlCom) == 0)
                return;
            try
            {
                int rowAffected = sqlCom.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //ResetList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ResetList();
            sqlCon.Close();
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            string manv= textBox_MaNV.Text;
            string col_name = dataGridView1.Columns[col].DataPropertyName.ToString();
            List<string> listPar = new List<string>();
            string hoten, email, luong, tendn;
            listPar.Add(hoten = textBox_HoTen.Text.Trim());
            listPar.Add(email = textBox_Email.Text.Trim());
            listPar.Add(luong = textBox_Luong.Text.Trim());
            listPar.Add(tendn = textBox_TenDN.Text.Trim());
            for (int i = 0; i < listPar.Count; i++)
            {
                if (listPar[i] == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            string filePath = @"../../Keys/" + manv;
            string fileName = manv + ".txt";
            string fullPath = filePath + "/" + fileName;
            RSAParameters publickey = new RSAParameters();
            RSAParameters privatekey = new RSAParameters();
            Global_Support.hashPass = LoadHassPass(manv);
            RSA512.ReadKeysFromFile(fullPath, Global_Support.hashPass, out privatekey, out publickey);
            byte[] en_luong = rsa512.RSAEncrypt(luong, publickey);
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.CommandType = CommandType.Text;
            sqlCom.Connection = sqlCon;
            sqlCom.CommandText = "UPDATE NHANVIEN SET HOTEN=@hoten, EMAIL=@email,LUONG= @en_luong,TENDN=@tendn WHERE MANV=@manv";
            sqlCom.Parameters.AddWithValue("@hoten", hoten);
            sqlCom.Parameters.AddWithValue("@email", email);
            sqlCom.Parameters.AddWithValue("@en_luong", en_luong);
            sqlCom.Parameters.AddWithValue("@tendn", tendn);
            sqlCom.Parameters.AddWithValue("@manv", manv);
            if (sqlCon == null)
                sqlCon = new SqlConnection(Global_Support.strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            try
            {
                int rowsAffected = sqlCom.ExecuteNonQuery();
                if (rowsAffected > 0)
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            sqlCon.Close();
            ResetList();
        }

        private void QLNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVNhom2DataSet8.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter1.Fill(this.qLSVNhom2DataSet8.NHANVIEN);
            // TODO: This line of code loads data into the 'qLSVNhom2DataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.qLSVNhom2DataSet.NHANVIEN);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            col = e.ColumnIndex;
            int col_manv = 0;
            int col_pubkey = 1;
            int col_hoten = 2;
            int col_email = 3;
            int col_tendn = 4;
            int col_luong = 5;
            string pubkey = dataGridView1.Rows[row].Cells[col_pubkey].Value.ToString();
            textBox_MaNV.Text = dataGridView1.Rows[row].Cells[col_manv].Value.ToString();
            textBox_HoTen.Text = dataGridView1.Rows[row].Cells[col_hoten].Value.ToString();
            textBox_Email.Text = dataGridView1.Rows[row].Cells[col_email].Value.ToString();
            textBox_TenDN.Text = dataGridView1.Rows[row].Cells[col_tendn].Value.ToString();
            Global_Support.hashPass = LoadHassPass(pubkey);
            var value = dataGridView1.Rows[row].Cells[col_luong].Value;
            if (value != null && value.GetType() == typeof(byte[]))
            {
                var byteValue = (byte[])value;
                string stringValue = rsa512.Decrypt(byteValue, textBox_MaNV.Text);
                textBox_Luong.Text = stringValue;
            }
            textBox_MaNV.Enabled = false;
            textBox_MatKhau.Enabled = false;
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string ma = null;
            string pubkey=null;
            int col_manv = 0;
            int col_pubkey = 1;
            pubkey = dataGridView1.Rows[e.RowIndex].Cells[col_pubkey].Value.ToString();
            Global_Support.hashPass=LoadHassPass(pubkey);
            ma = dataGridView1.Rows[e.RowIndex].Cells[col_manv].Value.ToString();
            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "LUONG")
            {
                var value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (value != null && value.GetType() == typeof(byte[]))
                {
                    var byteValue = (byte[])value;
                    string stringValue = rsa512.Decrypt(byteValue, ma);
                    e.Value = stringValue;
                }
            }
        }

        public int Exec_SP_INS_PUBLIC_ENCRYPT_NHANVIEN(SqlCommand sqlCom)
        {
            List<string> listPar = new List<string>();
            string ma, hoten, email, luong, tendn, matkhau;
            listPar.Add(ma = textBox_MaNV.Text.Trim());
            listPar.Add(hoten = textBox_HoTen.Text.Trim());
            listPar.Add(email = textBox_Email.Text.Trim());
            listPar.Add(luong = textBox_Luong.Text.Trim());
            listPar.Add(tendn = textBox_TenDN.Text.Trim());
            listPar.Add(matkhau = textBox_MatKhau.Text.Trim());
            for (int i = 0; i < listPar.Count; i++)
            {
                if (listPar[i] == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
            string filePath = @"../../Keys/" +ma;
            string fileName = ma+".txt";
            RSAParameters publickey=new RSAParameters();
            RSAParameters privatekey=new RSAParameters();
            byte[] en_matkhau = Global_Support.SHA1_Hash(matkhau);
            string str_en_matkhau = "0x" + BitConverter.ToString(en_matkhau).Replace("-", "");
            string fullPath = filePath +"/"+ fileName;
            if (File.Exists(fullPath))
            {
                    MessageBox.Show("Nhân viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
            }    
            else
            {
                string publicKeyXml1 = rsa512.GetPublicKey();
                string privateKeyXml1 = rsa512.GetPrivateKey();
                privateKeyXml1=BitConverter.ToString(rsa512.AES256Encrypt(privateKeyXml1,str_en_matkhau));
                RSA512.WriteKeysToFile(filePath, fileName, privateKeyXml1, publicKeyXml1);
                RSA512.ReadKeysFromFile(fullPath,str_en_matkhau, out privatekey, out publickey);
            }
            
            byte[] en_luong = rsa512.RSAEncrypt(luong,publickey);

            Global_Support.OpenSQL(sqlCon);
            sqlCom.CommandType = CommandType.StoredProcedure;
            sqlCom.CommandText = "SP_INS_PUBLIC_ENCRYPT_NHANVIEN";

            SqlParameter parMa = new SqlParameter("@MANV", SqlDbType.VarChar);
            SqlParameter parHoten = new SqlParameter("@HOTEN", SqlDbType.NVarChar);
            SqlParameter parEmail = new SqlParameter("@EMAIL", SqlDbType.VarChar);
            SqlParameter parLuong = new SqlParameter("@LUONG", SqlDbType.VarBinary);
            SqlParameter parTenDN = new SqlParameter("@TENDN", SqlDbType.NVarChar);
            SqlParameter parMatKhau = new SqlParameter("@MATKHAU", SqlDbType.VarBinary);
            SqlParameter parPub = new SqlParameter("@PUBKEY", SqlDbType.VarChar);


            parMa.Value = ma;
            parHoten.Value = hoten;
            parEmail.Value = email;
            parLuong.Value = en_luong;
            parTenDN.Value = tendn;
            parMatKhau.Value = en_matkhau;
            parPub.Value = ma;
            sqlCom.Parameters.Add(parMa);
            sqlCom.Parameters.Add(parHoten);
            sqlCom.Parameters.Add(parEmail);
            sqlCom.Parameters.Add(parLuong);
            sqlCom.Parameters.Add(parTenDN);
            sqlCom.Parameters.Add(parMatKhau);
            sqlCom.Parameters.Add(parPub);
            sqlCom.Connection = sqlCon;
            return 1;
        }

        public static void OpenSQL(SqlConnection sqlCon)
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(Global_Support.strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
        }

        private void ResetList()
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(Global_Support.strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT MANV, HOTEN, EMAIL, LUONG,TENDN, PUBKEY FROM NHANVIEN";
            cmd.Connection = sqlCon;
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        public string LoadHassPass(string pubkey)
        {
            string hashPass=null;
            if (sqlCon == null)
                sqlCon = new SqlConnection(Global_Support.strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.CommandType = CommandType.Text;
            sqlCom.Connection = sqlCon;
            sqlCom.CommandText = "SELECT MATKHAU FROM NHANVIEN WHERE PUBKEY='" + pubkey + "'";
            try
            {
                SqlDataReader reader = sqlCom.ExecuteReader();
                if (reader.Read())
                {
                    byte[] varbinaryData = (byte[])reader["MATKHAU"];
                    hashPass ="0x"+BitConverter.ToString(varbinaryData).Replace("-","");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            sqlCon.Close();
            return hashPass;
        }

    }
}
