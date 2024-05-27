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
    public partial class ThemSV : Form
    {
        SqlConnection sqlCon = null;
        public ThemSV()
        {
            InitializeComponent();
        }

        private void ThemSV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVNhom2DataSet4.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.qLSVNhom2DataSet4.LOP);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null)
                return;
            label_TenLop.Text="Tên lớp: "+comboBox1.SelectedValue.ToString();
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(Global_Support.strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlCommand sqlCom = new SqlCommand();
            Exec_SP_INS_SINHVIEN(sqlCom);
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
            sqlCon.Close();
        }
        public void Exec_SP_INS_SINHVIEN(SqlCommand sqlCom)
        {
            List<string> listPar = new List<string>();
            string ma, hoten, ngaysinh, diachi,malop, tendn, matkhau;
            listPar.Add(ma = textBox_MaSV.Text.Trim());
            listPar.Add(hoten = textBox_HoTen.Text.Trim());
            listPar.Add(ngaysinh = textBox_NgaySinh.Text.Trim());
            listPar.Add(diachi = textBox_DiaChi.Text.Trim());
            listPar.Add(malop=comboBox1.Text.Trim());
            listPar.Add(tendn = textBox_TenDN.Text.Trim());
            listPar.Add(matkhau = textBox_MK.Text.Trim());
            for (int i = 0; i < listPar.Count; i++)
            {
                if (listPar[i] == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return ;
                }
            }
            byte[] en_matkhau = Global_Support.SHA1_Hash(matkhau);
            if (sqlCon == null)
                sqlCon = new SqlConnection(Global_Support.strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            sqlCom.CommandType = CommandType.StoredProcedure;
            sqlCom.CommandText = "SP_INS_SINHVIEN";

            SqlParameter parMa = new SqlParameter("@MASV", SqlDbType.VarChar);
            SqlParameter parHoten = new SqlParameter("@HOTEN", SqlDbType.NVarChar);
            SqlParameter parNgaySinh = new SqlParameter("@NGAYSINH", SqlDbType.DateTime);
            SqlParameter parDiaChi = new SqlParameter("@DIACHI", SqlDbType.NVarChar);
            SqlParameter parTenDN = new SqlParameter("@TENDN", SqlDbType.NVarChar);
            SqlParameter parMatKhau = new SqlParameter("@MATKHAU", SqlDbType.VarBinary);
            SqlParameter parMaLop = new SqlParameter("@MALOP", SqlDbType.VarChar);


            parMa.Value = ma;
            parHoten.Value = hoten;
            parNgaySinh.Value = ngaysinh;
            parDiaChi.Value = diachi;
            parTenDN.Value = tendn;
            parMatKhau.Value = en_matkhau;
            parMaLop.Value = malop;
            sqlCom.Parameters.Add(parMa);
            sqlCom.Parameters.Add(parHoten);
            sqlCom.Parameters.Add(parNgaySinh);
            sqlCom.Parameters.Add(parDiaChi);
            sqlCom.Parameters.Add(parTenDN);
            sqlCom.Parameters.Add(parMatKhau);
            sqlCom.Parameters.Add(parMaLop);
            sqlCom.Connection = sqlCon;
        }
    }
}
