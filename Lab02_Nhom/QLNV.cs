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
            string manv= dataGridView1.Rows[row].Cells[0].Value.ToString();
            string col_name = dataGridView1.Columns[col].DataPropertyName.ToString();
            var value = dataGridView1.Rows[row].Cells[col].Value.ToString();
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.CommandType = CommandType.Text;
            sqlCom.Connection = sqlCon;
            sqlCom.CommandText = "UPDATE NHANVIEN SET " + col_name + " ='" + value + "' WHERE MANV='" + manv + "'";
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
        }

        private void QLNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVNhom2DataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.qLSVNhom2DataSet.NHANVIEN);

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string ma = null;
            int col_manv = 1;
            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "LUONG")
            {
                ma= dataGridView1.Rows[e.RowIndex].Cells[col_manv].Value.ToString();
                var value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (value != null && value.GetType() == typeof(byte[]))
                {
                    var byteValue = (byte[])value;
                    string stringValue = rsa512.Decrypt(byteValue, ma);
                    e.Value = stringValue;
                }
            }
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            row=e.RowIndex;
            col=e.ColumnIndex;
            if(dataGridView1.Columns[col].DataPropertyName.ToString()=="MANV" || dataGridView1.Columns[col].DataPropertyName.ToString() == "PUBKEY"|| dataGridView1.Columns[col].DataPropertyName.ToString() == "LUONG")
            {
                ResetList();
                MessageBox.Show("Cột này không thể sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                RSA512.WriteKeysToFile(filePath, fileName, privateKeyXml1, publicKeyXml1);
                RSA512.ReadKeysFromFile(fullPath, out privatekey, out publickey);
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
            cmd.CommandText = "SELECT MANV, HOTEN, EMAIL, LUONG, PUBKEY FROM NHANVIEN";
            cmd.Connection = sqlCon;
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

    }
}
