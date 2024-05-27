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
    public partial class ThemLop : Form
    {
        SqlConnection sqlCon = null;
        public ThemLop()
        {
            InitializeComponent();
        }

        private void ThemLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVNhom2DataSet3.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.qLSVNhom2DataSet3.NHANVIEN);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_TenNV.Text = "Tên nhân viên: " + comboBox1.SelectedValue;
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            string manv = comboBox1.Text;
            string malop = textBox_MaLop.Text.Trim();
            string tenlop=textBox_TenLop.Text.Trim();
            if (sqlCon == null)
                sqlCon = new SqlConnection(Global_Support.strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.CommandType = CommandType.Text;
            sqlCom.Connection = sqlCon;
            sqlCom.CommandText = "INSERT INTO LOP VALUES('"+malop+"',N'"+tenlop+"','"+manv+"')";
            try
            {
                int rowsAffected = sqlCom.ExecuteNonQuery();
                if (rowsAffected > 0)
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            sqlCon.Close();
        }
        
    }
}
