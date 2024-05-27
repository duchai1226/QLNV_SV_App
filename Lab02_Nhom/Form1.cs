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
using System.Security.Cryptography;

namespace Lab02_Nhom
{
    public partial class Form1 : Form
    {
        
        string strCon = @"Data Source=LAPTOP-UBQQQL22\PERDB_SQL;Initial Catalog=QLSVNhom2;Integrated Security=True";
        SqlConnection sqlCon = null;
        public Form1()
        {
            InitializeComponent();
            Global_Support.strCon = strCon;
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_DangNhap_Click(object sender, EventArgs e)
        {
            OpenSQL(strCon);
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.CommandType = CommandType.Text;
            string tendangnhap = textTenDN.Text.Trim();
            string password = textMatKhau.Text.Trim();

            string en_password = "0x" + BitConverter.ToString(Global_Support.SHA1_Hash(password)).Replace("-", "");
            Global_Support.Mk = en_password;
            sqlCom.Connection = sqlCon;
            sqlCom.CommandText = "SELECT * FROM NHANVIEN WHERE TENDN='" + tendangnhap + "' AND MATKHAU=" + en_password + "";
            try
            {
                SqlDataReader reader = sqlCom.ExecuteReader();
                if (reader.Read())
                {
                    Global_Support.MaNV = reader["MANV"].ToString();
                    this.Hide();
                    var form2 = new Form2();
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();
                }
                else
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            sqlCon.Close();
        }

        private void OpenSQL(string strCon)
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
        }
        
    }
}
