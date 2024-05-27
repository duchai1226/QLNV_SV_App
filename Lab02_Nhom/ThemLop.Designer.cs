namespace Lab02_Nhom
{
    partial class ThemLop
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
            this.label_MaLop = new System.Windows.Forms.Label();
            this.label_TenLop = new System.Windows.Forms.Label();
            this.label_MaNV = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_MaLop = new System.Windows.Forms.TextBox();
            this.textBox_TenLop = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.qLSVNhom2DataSet3 = new Lab02_Nhom.QLSVNhom2DataSet3();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENTableAdapter = new Lab02_Nhom.QLSVNhom2DataSet3TableAdapters.NHANVIENTableAdapter();
            this.label_TenNV = new System.Windows.Forms.Label();
            this.button_Them = new System.Windows.Forms.Button();
            this.button_Thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVNhom2DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label_MaLop
            // 
            this.label_MaLop.AutoSize = true;
            this.label_MaLop.Location = new System.Drawing.Point(103, 130);
            this.label_MaLop.Name = "label_MaLop";
            this.label_MaLop.Size = new System.Drawing.Size(42, 13);
            this.label_MaLop.TabIndex = 0;
            this.label_MaLop.Text = "Mã lớp:";
            // 
            // label_TenLop
            // 
            this.label_TenLop.AutoSize = true;
            this.label_TenLop.Location = new System.Drawing.Point(103, 202);
            this.label_TenLop.Name = "label_TenLop";
            this.label_TenLop.Size = new System.Drawing.Size(29, 13);
            this.label_TenLop.TabIndex = 1;
            this.label_TenLop.Text = "Tên:";
            // 
            // label_MaNV
            // 
            this.label_MaNV.AutoSize = true;
            this.label_MaNV.Location = new System.Drawing.Point(103, 275);
            this.label_MaNV.Name = "label_MaNV";
            this.label_MaNV.Size = new System.Drawing.Size(43, 13);
            this.label_MaNV.TabIndex = 2;
            this.label_MaNV.Text = "Mã NV:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(169, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "THÊM LỚP";
            // 
            // textBox_MaLop
            // 
            this.textBox_MaLop.Location = new System.Drawing.Point(188, 123);
            this.textBox_MaLop.Name = "textBox_MaLop";
            this.textBox_MaLop.Size = new System.Drawing.Size(196, 20);
            this.textBox_MaLop.TabIndex = 4;
            // 
            // textBox_TenLop
            // 
            this.textBox_TenLop.Location = new System.Drawing.Point(188, 195);
            this.textBox_TenLop.Name = "textBox_TenLop";
            this.textBox_TenLop.Size = new System.Drawing.Size(196, 20);
            this.textBox_TenLop.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.nHANVIENBindingSource;
            this.comboBox1.DisplayMember = "MANV";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(188, 267);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "HOTEN";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // qLSVNhom2DataSet3
            // 
            this.qLSVNhom2DataSet3.DataSetName = "QLSVNhom2DataSet3";
            this.qLSVNhom2DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.qLSVNhom2DataSet3;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // label_TenNV
            // 
            this.label_TenNV.AutoSize = true;
            this.label_TenNV.Location = new System.Drawing.Point(185, 302);
            this.label_TenNV.Name = "label_TenNV";
            this.label_TenNV.Size = new System.Drawing.Size(62, 13);
            this.label_TenNV.TabIndex = 7;
            this.label_TenNV.Text = "Nhân viên: ";
            // 
            // button_Them
            // 
            this.button_Them.Location = new System.Drawing.Point(309, 370);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(75, 23);
            this.button_Them.TabIndex = 8;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // button_Thoat
            // 
            this.button_Thoat.Location = new System.Drawing.Point(411, 370);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(75, 23);
            this.button_Thoat.TabIndex = 9;
            this.button_Thoat.Text = "Thoát";
            this.button_Thoat.UseVisualStyleBackColor = true;
            this.button_Thoat.Click += new System.EventHandler(this.button_Thoat_Click);
            // 
            // ThemLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 450);
            this.Controls.Add(this.button_Thoat);
            this.Controls.Add(this.button_Them);
            this.Controls.Add(this.label_TenNV);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox_TenLop);
            this.Controls.Add(this.textBox_MaLop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_MaNV);
            this.Controls.Add(this.label_TenLop);
            this.Controls.Add(this.label_MaLop);
            this.Name = "ThemLop";
            this.Text = "ThemLop";
            this.Load += new System.EventHandler(this.ThemLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLSVNhom2DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_MaLop;
        private System.Windows.Forms.Label label_TenLop;
        private System.Windows.Forms.Label label_MaNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_MaLop;
        private System.Windows.Forms.TextBox textBox_TenLop;
        private System.Windows.Forms.ComboBox comboBox1;
        private QLSVNhom2DataSet3 qLSVNhom2DataSet3;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private QLSVNhom2DataSet3TableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private System.Windows.Forms.Label label_TenNV;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Button button_Thoat;
    }
}