using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_Nhom
{
    public partial class BangDiem : Form
    {
        SqlConnection sqlCon = null;
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        RSA512 rsa512=new RSA512();
        int row ;
        int col;
        int add_change;
        public BangDiem()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_TenSV.Text = "Tên: "+comboBox1.SelectedValue.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_TenHP.Text ="Học phần: "+ comboBox1.SelectedValue.ToString();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string ma = Global_Support.MaNV;
            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "DIEMTHI")
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

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            row = e.RowIndex;
            col = e.ColumnIndex;
        }

        private void BangDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVNhom2DataSet7.HOCPHAN' table. You can move, or remove it, as needed.
            this.hOCPHANTableAdapter.Fill(this.qLSVNhom2DataSet7.HOCPHAN);
            LoadDsSinhVien();
            LoadBangDiem();
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            if (add_change == 0)
                ThemDiem();
            else
                SuaDiem();
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            int col_masv = 0;
            string masv = dataGridView1.Rows[row].Cells[col_masv].Value.ToString();
            XoaSV(masv);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                add_change = 0;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
                add_change = 1;
        }
        private void XoaSV(string masv)
        {
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.CommandType = CommandType.Text;
            sqlCom.Connection = sqlCon;
            sqlCom.CommandText = "DELETE FROM BANGDIEM WHERE MASV='" + masv + "'";
            if (sqlCon == null)
                sqlCon = new SqlConnection(Global_Support.strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            try
            {
                int rowsAffected = sqlCom.ExecuteNonQuery();
                if (rowsAffected > 0)
                    MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Xoá thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            LoadBangDiem();
            sqlCon.Close();
        }
        private void ThemDiem()
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(Global_Support.strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            string masv = comboBox1.Text.ToString();
            string mahp = comboBox2.Text.ToString();
            float diem;
            if (!float.TryParse(textBox1.Text.Trim(), out diem))
            {
                MessageBox.Show("Điểm thi là phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string strDiem = diem.ToString();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_INS_BANGDIEM";
            cmd.Connection = sqlCon;
            SqlParameter parMaSV = new SqlParameter("@MaSV", SqlDbType.NVarChar);
            SqlParameter parMaHP = new SqlParameter("@MaHP", SqlDbType.VarChar);
            SqlParameter parDiemThi = new SqlParameter("@DIEMTHI", SqlDbType.VarBinary);
            string filePath = @"../../Keys/" + Global_Support.MaNV;
            string fileName = Global_Support.MaNV + ".txt";
            string fullPath = filePath + "/" + fileName;
            RSAParameters publickey = new RSAParameters();
            RSAParameters privatekey = new RSAParameters();
            RSA512.ReadKeysFromFile(fullPath, out privatekey, out publickey);
            byte[] byteDiem = rsa512.RSAEncrypt(strDiem, publickey);

            parMaSV.Value = masv;
            parMaHP.Value = mahp;
            parDiemThi.Value = byteDiem;
            cmd.Parameters.Add(parMaSV);
            cmd.Parameters.Add(parMaHP);
            cmd.Parameters.Add(parDiemThi);
            try
            {
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Học phần đã có kết quả trước đó", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            LoadBangDiem();
            sqlCon.Close();
        }
        private void SuaDiem()
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(Global_Support.strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            string masv = comboBox1.Text.ToString();
            string mahp = comboBox2.Text.ToString();
            float diem;
            if (!float.TryParse(textBox1.Text.Trim(), out diem))
            {
                MessageBox.Show("Điểm thi là phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string strDiem = diem.ToString();
            string filePath = @"../../Keys/" + Global_Support.MaNV;
            string fileName = Global_Support.MaNV + ".txt";
            string fullPath = filePath + "/" + fileName;
            RSAParameters publickey = new RSAParameters();
            RSAParameters privatekey = new RSAParameters();
            RSA512.ReadKeysFromFile(fullPath, out privatekey, out publickey);
            byte[] byteDiem = rsa512.RSAEncrypt(strDiem, publickey);
            strDiem="0x"+BitConverter.ToString(byteDiem).Replace("-","");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE BANGDIEM SET DIEMTHI=" + strDiem + " WHERE MASV='" + masv + "' AND MAHP='"+mahp+"'"; ;
            cmd.Connection = sqlCon;
            try
            {
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Học phần đã có kết quả trước đó", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            LoadBangDiem();
            sqlCon.Close();
        }
        private void LoadDsSinhVien()
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(Global_Support.strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_SEL_LISTSINHVIEN";
            cmd.Connection = sqlCon;
            SqlParameter parMaNV = new SqlParameter("@MANV", SqlDbType.VarChar);
            parMaNV.Value = Global_Support.MaNV;
            cmd.Parameters.Add(parMaNV);
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            ds = new DataSet();
            adapter.Fill(ds);
            comboBox1.DataSource = ds.Tables[0];
            sqlCon.Close();
        }
        private void LoadBangDiem()
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(Global_Support.strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_SEL_BANGDIEM";
            cmd.Connection = sqlCon;
            SqlParameter parMaNV = new SqlParameter("@MANV", SqlDbType.VarChar);
            SqlParameter parMk = new SqlParameter("@MK", SqlDbType.NVarChar);
            parMaNV.Value = Global_Support.MaNV;
            parMk.Value = Global_Support.Mk;
            cmd.Parameters.Add(parMaNV);
            cmd.Parameters.Add(parMk);
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            sqlCon.Close();
        }
    }
}
