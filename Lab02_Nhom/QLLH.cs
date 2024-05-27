using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_Nhom
{
    public partial class QLLH : Form
    {
        SqlConnection sqlCon = null;
        public string Lop;
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        public int row;
        public int col;
        public QLLH()
        {
            InitializeComponent();
        }


        private void QLLH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVNhom2DataSet2.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.qLSVNhom2DataSet2.SINHVIEN);
            // TODO: This line of code loads data into the 'qLSVNhom2DataSet1.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.qLSVNhom2DataSet1.LOP);
            label_NowUser.Text = "Nhân viên: " + Global_Support.MaNV;

        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            row = e.RowIndex;
            col = e.ColumnIndex;
            if (dataGridView1.Columns[col].DataPropertyName.ToString() == "MASV")
            {
                MessageBox.Show("Cột này không thể sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetList();
                LoadData();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null)
                return;
            Lop = comboBox1.SelectedValue.ToString();
            LoadData();
            Authentication();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            LoadDSLop();
        }

        private void button_ThemLop_Click(object sender, EventArgs e)
        {
            var formThemLop = new ThemLop();
            formThemLop.Closed += (s, args) => this.Close();
            formThemLop.Show();
        }

        private void button_ThemSV_Click(object sender, EventArgs e)
        {
            var formThemSV=new ThemSV();
            formThemSV.Closed += (s, args) => this.Close();
            formThemSV.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Authentication();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string manv = dataGridView1.Rows[row].Cells[0].Value.ToString();
            string col_name = dataGridView1.Columns[col].DataPropertyName.ToString();
            var value = dataGridView1.Rows[row].Cells[col].Value.ToString();
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.CommandType = CommandType.Text;
            sqlCom.Connection = sqlCon;
            sqlCom.CommandText = "UPDATE SINHVIEN SET " + col_name + " ='" + value + "' WHERE MASV='" + manv + "'";
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
            ResetList();
            LoadData();
            sqlCon.Close();
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetList();
            LoadData();
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            int col_masv = 0;
            string masv = dataGridView1.Rows[row].Cells[col_masv].Value.ToString();
            XoaSV(masv);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var formBangDiem=new BangDiem();
            formBangDiem.Closed += (s, args) => this.Close();
            formBangDiem.Show();
        }

        private void LoadDSLop()
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(Global_Support.strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT TEN,MALOP FROM LOP";
            cmd.Connection = sqlCon;
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            comboBox1.DataSource = ds.Tables[0];
        }

        public static void OpenSQL(SqlConnection sqlCon)
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(Global_Support.strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
        }

        private void Authentication()
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(Global_Support.strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.CommandType = CommandType.Text;

            sqlCom.Connection = sqlCon;
            sqlCom.CommandText = "SELECT MANV FROM LOP WHERE MALOP='" + Lop + "'";
            try
            {
                SqlDataReader reader = sqlCom.ExecuteReader();
                if (reader.Read() && reader["MANV"].ToString() == Global_Support.MaNV)
                {
                    dataGridView1.ReadOnly = false;
                }
                else { dataGridView1.ReadOnly = true; }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            sqlCon.Close();
        }

        private void LoadData()
        {
            if (Lop == null)
                return;
            if (sqlCon == null)
                sqlCon = new SqlConnection(Global_Support.strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_SEL_SINHVIEN";
            cmd.Connection = sqlCon;
            SqlParameter parMaLop = new SqlParameter("@MALOP", SqlDbType.NVarChar);
            parMaLop.Value = Lop;
            cmd.Parameters.Add(parMaLop);
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            sqlCon.Close();
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
            cmd.CommandText = "SELECT MASV,HOTEN,NGAYSINH,DIACHI,MALOP,TENDN FROM SINHVIEN";
            cmd.Connection = sqlCon;
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void XoaSV(string masv)
        {
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.CommandType = CommandType.Text;
            sqlCom.Connection = sqlCon;
            sqlCom.CommandText = "DELETE FROM SINHVIEN WHERE MASV='"+masv+"'";
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
            ResetList();
            LoadData();
            sqlCon.Close();
        }
    }
}
