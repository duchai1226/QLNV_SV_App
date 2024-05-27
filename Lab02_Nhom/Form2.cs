using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_Nhom
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void button_QLNV_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formQLNV = new QLNV();
            formQLNV.Closed += (s, args) => this.Close();
            formQLNV.Show();
        }

        private void button_QLLopHoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formQLLH = new QLLH();
            formQLLH.Closed += (s, args) => this.Close();
            formQLLH.Show();
        }
    }
}
