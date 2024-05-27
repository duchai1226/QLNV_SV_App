namespace Lab02_Nhom
{
    partial class ThemSV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label_MaSV = new System.Windows.Forms.Label();
            this.label_HoTen = new System.Windows.Forms.Label();
            this.label_NgaySinh = new System.Windows.Forms.Label();
            this.label_DiaChi = new System.Windows.Forms.Label();
            this.label_MaLop = new System.Windows.Forms.Label();
            this.label_TenDN = new System.Windows.Forms.Label();
            this.label_MK = new System.Windows.Forms.Label();
            this.textBox_MaSV = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox_HoTen = new System.Windows.Forms.TextBox();
            this.textBox_NgaySinh = new System.Windows.Forms.TextBox();
            this.textBox_DiaChi = new System.Windows.Forms.TextBox();
            this.textBox_TenDN = new System.Windows.Forms.TextBox();
            this.textBox_MK = new System.Windows.Forms.TextBox();
            this.qLSVNhom2DataSet4 = new Lab02_Nhom.QLSVNhom2DataSet4();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new Lab02_Nhom.QLSVNhom2DataSet4TableAdapters.LOPTableAdapter();
            this.label_TenLop = new System.Windows.Forms.Label();
            this.button_Them = new System.Windows.Forms.Button();
            this.button_thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVNhom2DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÊM SINH VIÊN";
            // 
            // label_MaSV
            // 
            this.label_MaSV.AutoSize = true;
            this.label_MaSV.Location = new System.Drawing.Point(63, 91);
            this.label_MaSV.Name = "label_MaSV";
            this.label_MaSV.Size = new System.Drawing.Size(42, 13);
            this.label_MaSV.TabIndex = 1;
            this.label_MaSV.Text = "Mã SV:";
            // 
            // label_HoTen
            // 
            this.label_HoTen.AutoSize = true;
            this.label_HoTen.Location = new System.Drawing.Point(63, 144);
            this.label_HoTen.Name = "label_HoTen";
            this.label_HoTen.Size = new System.Drawing.Size(42, 13);
            this.label_HoTen.TabIndex = 2;
            this.label_HoTen.Text = "Họ tên:";
            // 
            // label_NgaySinh
            // 
            this.label_NgaySinh.AutoSize = true;
            this.label_NgaySinh.Location = new System.Drawing.Point(63, 199);
            this.label_NgaySinh.Name = "label_NgaySinh";
            this.label_NgaySinh.Size = new System.Drawing.Size(57, 13);
            this.label_NgaySinh.TabIndex = 3;
            this.label_NgaySinh.Text = "Ngày sinh:";
            // 
            // label_DiaChi
            // 
            this.label_DiaChi.AutoSize = true;
            this.label_DiaChi.Location = new System.Drawing.Point(63, 265);
            this.label_DiaChi.Name = "label_DiaChi";
            this.label_DiaChi.Size = new System.Drawing.Size(43, 13);
            this.label_DiaChi.TabIndex = 4;
            this.label_DiaChi.Text = "Địa chỉ:";
            // 
            // label_MaLop
            // 
            this.label_MaLop.AutoSize = true;
            this.label_MaLop.Location = new System.Drawing.Point(63, 329);
            this.label_MaLop.Name = "label_MaLop";
            this.label_MaLop.Size = new System.Drawing.Size(42, 13);
            this.label_MaLop.TabIndex = 5;
            this.label_MaLop.Text = "Mã lớp:";
            // 
            // label_TenDN
            // 
            this.label_TenDN.AutoSize = true;
            this.label_TenDN.Location = new System.Drawing.Point(63, 386);
            this.label_TenDN.Name = "label_TenDN";
            this.label_TenDN.Size = new System.Drawing.Size(84, 13);
            this.label_TenDN.TabIndex = 6;
            this.label_TenDN.Text = "Tên đăng nhập:";
            // 
            // label_MK
            // 
            this.label_MK.AutoSize = true;
            this.label_MK.Location = new System.Drawing.Point(63, 445);
            this.label_MK.Name = "label_MK";
            this.label_MK.Size = new System.Drawing.Size(55, 13);
            this.label_MK.TabIndex = 7;
            this.label_MK.Text = "Mật khẩu:";
            // 
            // textBox_MaSV
            // 
            this.textBox_MaSV.Location = new System.Drawing.Point(176, 88);
            this.textBox_MaSV.Name = "textBox_MaSV";
            this.textBox_MaSV.Size = new System.Drawing.Size(209, 20);
            this.textBox_MaSV.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.lOPBindingSource;
            this.comboBox1.DisplayMember = "MALOP";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(176, 321);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(209, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "TEN";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox_HoTen
            // 
            this.textBox_HoTen.Location = new System.Drawing.Point(176, 137);
            this.textBox_HoTen.Name = "textBox_HoTen";
            this.textBox_HoTen.Size = new System.Drawing.Size(209, 20);
            this.textBox_HoTen.TabIndex = 2;
            // 
            // textBox_NgaySinh
            // 
            this.textBox_NgaySinh.Location = new System.Drawing.Point(176, 192);
            this.textBox_NgaySinh.Name = "textBox_NgaySinh";
            this.textBox_NgaySinh.Size = new System.Drawing.Size(209, 20);
            this.textBox_NgaySinh.TabIndex = 3;
            // 
            // textBox_DiaChi
            // 
            this.textBox_DiaChi.Location = new System.Drawing.Point(176, 258);
            this.textBox_DiaChi.Name = "textBox_DiaChi";
            this.textBox_DiaChi.Size = new System.Drawing.Size(209, 20);
            this.textBox_DiaChi.TabIndex = 4;
            // 
            // textBox_TenDN
            // 
            this.textBox_TenDN.Location = new System.Drawing.Point(176, 379);
            this.textBox_TenDN.Name = "textBox_TenDN";
            this.textBox_TenDN.Size = new System.Drawing.Size(209, 20);
            this.textBox_TenDN.TabIndex = 6;
            // 
            // textBox_MK
            // 
            this.textBox_MK.Location = new System.Drawing.Point(176, 438);
            this.textBox_MK.Name = "textBox_MK";
            this.textBox_MK.Size = new System.Drawing.Size(209, 20);
            this.textBox_MK.TabIndex = 7;
            // 
            // qLSVNhom2DataSet4
            // 
            this.qLSVNhom2DataSet4.DataSetName = "QLSVNhom2DataSet4";
            this.qLSVNhom2DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.qLSVNhom2DataSet4;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // label_TenLop
            // 
            this.label_TenLop.AutoSize = true;
            this.label_TenLop.Location = new System.Drawing.Point(173, 345);
            this.label_TenLop.Name = "label_TenLop";
            this.label_TenLop.Size = new System.Drawing.Size(46, 13);
            this.label_TenLop.TabIndex = 15;
            this.label_TenLop.Text = "Tên lớp:";
            // 
            // button_Them
            // 
            this.button_Them.Location = new System.Drawing.Point(206, 493);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(99, 32);
            this.button_Them.TabIndex = 16;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // button_thoat
            // 
            this.button_thoat.Location = new System.Drawing.Point(344, 493);
            this.button_thoat.Name = "button_thoat";
            this.button_thoat.Size = new System.Drawing.Size(99, 32);
            this.button_thoat.TabIndex = 17;
            this.button_thoat.Text = "Thoát";
            this.button_thoat.UseVisualStyleBackColor = true;
            this.button_thoat.Click += new System.EventHandler(this.button_thoat_Click);
            // 
            // ThemSV
            // 
            this.AcceptButton = this.button_Them;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_thoat;
            this.ClientSize = new System.Drawing.Size(475, 564);
            this.Controls.Add(this.button_thoat);
            this.Controls.Add(this.button_Them);
            this.Controls.Add(this.label_TenLop);
            this.Controls.Add(this.textBox_MK);
            this.Controls.Add(this.textBox_TenDN);
            this.Controls.Add(this.textBox_DiaChi);
            this.Controls.Add(this.textBox_NgaySinh);
            this.Controls.Add(this.textBox_HoTen);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox_MaSV);
            this.Controls.Add(this.label_MK);
            this.Controls.Add(this.label_TenDN);
            this.Controls.Add(this.label_MaLop);
            this.Controls.Add(this.label_DiaChi);
            this.Controls.Add(this.label_NgaySinh);
            this.Controls.Add(this.label_HoTen);
            this.Controls.Add(this.label_MaSV);
            this.Controls.Add(this.label1);
            this.Name = "ThemSV";
            this.Text = "ThemSV";
            this.Load += new System.EventHandler(this.ThemSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLSVNhom2DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_MaSV;
        private System.Windows.Forms.Label label_HoTen;
        private System.Windows.Forms.Label label_NgaySinh;
        private System.Windows.Forms.Label label_DiaChi;
        private System.Windows.Forms.Label label_MaLop;
        private System.Windows.Forms.Label label_TenDN;
        private System.Windows.Forms.Label label_MK;
        private System.Windows.Forms.TextBox textBox_MaSV;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox_HoTen;
        private System.Windows.Forms.TextBox textBox_NgaySinh;
        private System.Windows.Forms.TextBox textBox_DiaChi;
        private System.Windows.Forms.TextBox textBox_TenDN;
        private System.Windows.Forms.TextBox textBox_MK;
        private QLSVNhom2DataSet4 qLSVNhom2DataSet4;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private QLSVNhom2DataSet4TableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.Label label_TenLop;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Button button_thoat;
    }
}