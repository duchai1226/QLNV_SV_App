namespace Lab02_Nhom
{
    partial class BangDiem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button_Them = new System.Windows.Forms.Button();
            this.label_TenHP = new System.Windows.Forms.Label();
            this.label_TenSV = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.hOCPHANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVNhom2DataSet7 = new Lab02_Nhom.QLSVNhom2DataSet7();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVNhom2DataSet5 = new Lab02_Nhom.QLSVNhom2DataSet5();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sPSELBANGDIEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVNhom2DataSet6 = new Lab02_Nhom.QLSVNhom2DataSet6();
            this.sINHVIENTableAdapter = new Lab02_Nhom.QLSVNhom2DataSet5TableAdapters.SINHVIENTableAdapter();
            this.sP_SEL_BANGDIEMTableAdapter = new Lab02_Nhom.QLSVNhom2DataSet6TableAdapters.SP_SEL_BANGDIEMTableAdapter();
            this.hOCPHANTableAdapter = new Lab02_Nhom.QLSVNhom2DataSet7TableAdapters.HOCPHANTableAdapter();
            this.button_Thoat = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.mASVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAHPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIEMTHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hOCPHANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVNhom2DataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVNhom2DataSet5)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPSELBANGDIEMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVNhom2DataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "BẢNG ĐIỂM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.button_Them);
            this.groupBox1.Controls.Add(this.label_TenHP);
            this.groupBox1.Controls.Add(this.label_TenSV);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(62, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 324);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập điểm";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(254, 33);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(44, 17);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Sửa";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(124, 33);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 17);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Thêm";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button_Them
            // 
            this.button_Them.Location = new System.Drawing.Point(221, 267);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(78, 33);
            this.button_Them.TabIndex = 8;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // label_TenHP
            // 
            this.label_TenHP.AutoSize = true;
            this.label_TenHP.Location = new System.Drawing.Point(201, 167);
            this.label_TenHP.Name = "label_TenHP";
            this.label_TenHP.Size = new System.Drawing.Size(57, 13);
            this.label_TenHP.TabIndex = 7;
            this.label_TenHP.Text = "Học phần:";
            // 
            // label_TenSV
            // 
            this.label_TenSV.AutoSize = true;
            this.label_TenSV.Location = new System.Drawing.Point(201, 104);
            this.label_TenSV.Name = "label_TenSV";
            this.label_TenSV.Size = new System.Drawing.Size(29, 13);
            this.label_TenSV.TabIndex = 6;
            this.label_TenSV.Text = "Tên:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(204, 211);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.hOCPHANBindingSource;
            this.comboBox2.DisplayMember = "MAHP";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(204, 143);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.ValueMember = "TENHP";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // hOCPHANBindingSource
            // 
            this.hOCPHANBindingSource.DataMember = "HOCPHAN";
            this.hOCPHANBindingSource.DataSource = this.qLSVNhom2DataSet7;
            // 
            // qLSVNhom2DataSet7
            // 
            this.qLSVNhom2DataSet7.DataSetName = "QLSVNhom2DataSet7";
            this.qLSVNhom2DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.sINHVIENBindingSource;
            this.comboBox1.DisplayMember = "MASV";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(204, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "HOTEN";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.qLSVNhom2DataSet5;
            // 
            // qLSVNhom2DataSet5
            // 
            this.qLSVNhom2DataSet5.DataSetName = "QLSVNhom2DataSet5";
            this.qLSVNhom2DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "ĐIỂM THI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "MÃ HP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "MASV:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(62, 424);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 192);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách bảng điểm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mASVDataGridViewTextBoxColumn,
            this.mAHPDataGridViewTextBoxColumn,
            this.dIEMTHIDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sPSELBANGDIEMBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(477, 173);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // sPSELBANGDIEMBindingSource
            // 
            this.sPSELBANGDIEMBindingSource.DataMember = "SP_SEL_BANGDIEM";
            this.sPSELBANGDIEMBindingSource.DataSource = this.qLSVNhom2DataSet6;
            // 
            // qLSVNhom2DataSet6
            // 
            this.qLSVNhom2DataSet6.DataSetName = "QLSVNhom2DataSet6";
            this.qLSVNhom2DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // sP_SEL_BANGDIEMTableAdapter
            // 
            this.sP_SEL_BANGDIEMTableAdapter.ClearBeforeFill = true;
            // 
            // hOCPHANTableAdapter
            // 
            this.hOCPHANTableAdapter.ClearBeforeFill = true;
            // 
            // button_Thoat
            // 
            this.button_Thoat.Location = new System.Drawing.Point(458, 665);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(84, 35);
            this.button_Thoat.TabIndex = 3;
            this.button_Thoat.Text = "Thoát";
            this.button_Thoat.UseVisualStyleBackColor = true;
            this.button_Thoat.Click += new System.EventHandler(this.button_Thoat_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.Location = new System.Drawing.Point(335, 665);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(78, 33);
            this.button_Xoa.TabIndex = 9;
            this.button_Xoa.Text = "Xoá";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // mASVDataGridViewTextBoxColumn
            // 
            this.mASVDataGridViewTextBoxColumn.DataPropertyName = "MASV";
            this.mASVDataGridViewTextBoxColumn.HeaderText = "MASV";
            this.mASVDataGridViewTextBoxColumn.Name = "mASVDataGridViewTextBoxColumn";
            this.mASVDataGridViewTextBoxColumn.Width = 144;
            // 
            // mAHPDataGridViewTextBoxColumn
            // 
            this.mAHPDataGridViewTextBoxColumn.DataPropertyName = "MAHP";
            this.mAHPDataGridViewTextBoxColumn.HeaderText = "MAHP";
            this.mAHPDataGridViewTextBoxColumn.Name = "mAHPDataGridViewTextBoxColumn";
            this.mAHPDataGridViewTextBoxColumn.Width = 145;
            // 
            // dIEMTHIDataGridViewTextBoxColumn
            // 
            this.dIEMTHIDataGridViewTextBoxColumn.DataPropertyName = "DIEMTHI";
            this.dIEMTHIDataGridViewTextBoxColumn.HeaderText = "DIEMTHI";
            this.dIEMTHIDataGridViewTextBoxColumn.Name = "dIEMTHIDataGridViewTextBoxColumn";
            this.dIEMTHIDataGridViewTextBoxColumn.ReadOnly = true;
            this.dIEMTHIDataGridViewTextBoxColumn.Width = 145;
            // 
            // BangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 730);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button_Thoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "BangDiem";
            this.Text = "BangDiem";
            this.Load += new System.EventHandler(this.BangDiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hOCPHANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVNhom2DataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVNhom2DataSet5)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPSELBANGDIEMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVNhom2DataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Label label_TenHP;
        private System.Windows.Forms.Label label_TenSV;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QLSVNhom2DataSet5 qLSVNhom2DataSet5;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private QLSVNhom2DataSet5TableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.BindingSource sPSELBANGDIEMBindingSource;
        private QLSVNhom2DataSet6 qLSVNhom2DataSet6;
        private QLSVNhom2DataSet6TableAdapters.SP_SEL_BANGDIEMTableAdapter sP_SEL_BANGDIEMTableAdapter;
        private QLSVNhom2DataSet7 qLSVNhom2DataSet7;
        private System.Windows.Forms.BindingSource hOCPHANBindingSource;
        private QLSVNhom2DataSet7TableAdapters.HOCPHANTableAdapter hOCPHANTableAdapter;
        private System.Windows.Forms.Button button_Thoat;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn mASVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAHPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIEMTHIDataGridViewTextBoxColumn;
    }
}