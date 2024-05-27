namespace Lab02_Nhom
{
    partial class QLLH
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
            this.label_NowUser = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVNhom2DataSet1 = new Lab02_Nhom.QLSVNhom2DataSet1();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mASVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOTENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYSINHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIACHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mALOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENDNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVNhom2DataSet2 = new Lab02_Nhom.QLSVNhom2DataSet2();
            this.button_Thoat = new System.Windows.Forms.Button();
            this.lOPTableAdapter = new Lab02_Nhom.QLSVNhom2DataSet1TableAdapters.LOPTableAdapter();
            this.sINHVIENTableAdapter = new Lab02_Nhom.QLSVNhom2DataSet2TableAdapters.SINHVIENTableAdapter();
            this.button_ThemLop = new System.Windows.Forms.Button();
            this.button_ThemSV = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVNhom2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVNhom2DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "LỚP:";
            // 
            // label_NowUser
            // 
            this.label_NowUser.AutoSize = true;
            this.label_NowUser.Location = new System.Drawing.Point(12, 9);
            this.label_NowUser.Name = "label_NowUser";
            this.label_NowUser.Size = new System.Drawing.Size(59, 13);
            this.label_NowUser.TabIndex = 1;
            this.label_NowUser.Text = "Nhân viên:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.lOPBindingSource;
            this.comboBox1.DisplayMember = "TEN";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(305, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(587, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "MALOP";
            this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.qLSVNhom2DataSet1;
            // 
            // qLSVNhom2DataSet1
            // 
            this.qLSVNhom2DataSet1.DataSetName = "QLSVNhom2DataSet1";
            this.qLSVNhom2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mASVDataGridViewTextBoxColumn,
            this.hOTENDataGridViewTextBoxColumn,
            this.nGAYSINHDataGridViewTextBoxColumn,
            this.dIACHIDataGridViewTextBoxColumn,
            this.mALOPDataGridViewTextBoxColumn,
            this.tENDNDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sINHVIENBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(131, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(881, 293);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            // 
            // mASVDataGridViewTextBoxColumn
            // 
            this.mASVDataGridViewTextBoxColumn.DataPropertyName = "MASV";
            this.mASVDataGridViewTextBoxColumn.HeaderText = "MASV";
            this.mASVDataGridViewTextBoxColumn.Name = "mASVDataGridViewTextBoxColumn";
            this.mASVDataGridViewTextBoxColumn.Width = 120;
            // 
            // hOTENDataGridViewTextBoxColumn
            // 
            this.hOTENDataGridViewTextBoxColumn.DataPropertyName = "HOTEN";
            this.hOTENDataGridViewTextBoxColumn.HeaderText = "HOTEN";
            this.hOTENDataGridViewTextBoxColumn.Name = "hOTENDataGridViewTextBoxColumn";
            this.hOTENDataGridViewTextBoxColumn.Width = 150;
            // 
            // nGAYSINHDataGridViewTextBoxColumn
            // 
            this.nGAYSINHDataGridViewTextBoxColumn.DataPropertyName = "NGAYSINH";
            this.nGAYSINHDataGridViewTextBoxColumn.HeaderText = "NGAYSINH";
            this.nGAYSINHDataGridViewTextBoxColumn.Name = "nGAYSINHDataGridViewTextBoxColumn";
            this.nGAYSINHDataGridViewTextBoxColumn.Width = 130;
            // 
            // dIACHIDataGridViewTextBoxColumn
            // 
            this.dIACHIDataGridViewTextBoxColumn.DataPropertyName = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.HeaderText = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.Name = "dIACHIDataGridViewTextBoxColumn";
            this.dIACHIDataGridViewTextBoxColumn.Width = 160;
            // 
            // mALOPDataGridViewTextBoxColumn
            // 
            this.mALOPDataGridViewTextBoxColumn.DataPropertyName = "MALOP";
            this.mALOPDataGridViewTextBoxColumn.HeaderText = "MALOP";
            this.mALOPDataGridViewTextBoxColumn.Name = "mALOPDataGridViewTextBoxColumn";
            this.mALOPDataGridViewTextBoxColumn.Width = 120;
            // 
            // tENDNDataGridViewTextBoxColumn
            // 
            this.tENDNDataGridViewTextBoxColumn.DataPropertyName = "TENDN";
            this.tENDNDataGridViewTextBoxColumn.HeaderText = "TENDN";
            this.tENDNDataGridViewTextBoxColumn.Name = "tENDNDataGridViewTextBoxColumn";
            this.tENDNDataGridViewTextBoxColumn.Width = 160;
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.qLSVNhom2DataSet2;
            // 
            // qLSVNhom2DataSet2
            // 
            this.qLSVNhom2DataSet2.DataSetName = "QLSVNhom2DataSet2";
            this.qLSVNhom2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button_Thoat
            // 
            this.button_Thoat.Location = new System.Drawing.Point(1022, 557);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(81, 32);
            this.button_Thoat.TabIndex = 4;
            this.button_Thoat.Text = "Thoát";
            this.button_Thoat.UseVisualStyleBackColor = true;
            this.button_Thoat.Click += new System.EventHandler(this.button_Thoat_Click);
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // button_ThemLop
            // 
            this.button_ThemLop.Location = new System.Drawing.Point(911, 103);
            this.button_ThemLop.Name = "button_ThemLop";
            this.button_ThemLop.Size = new System.Drawing.Size(71, 21);
            this.button_ThemLop.TabIndex = 5;
            this.button_ThemLop.Text = "Thêm lớp";
            this.button_ThemLop.UseVisualStyleBackColor = true;
            this.button_ThemLop.Click += new System.EventHandler(this.button_ThemLop_Click);
            // 
            // button_ThemSV
            // 
            this.button_ThemSV.Location = new System.Drawing.Point(1022, 262);
            this.button_ThemSV.Name = "button_ThemSV";
            this.button_ThemSV.Size = new System.Drawing.Size(81, 32);
            this.button_ThemSV.TabIndex = 6;
            this.button_ThemSV.Text = "Thêm SV";
            this.button_ThemSV.UseVisualStyleBackColor = true;
            this.button_ThemSV.Click += new System.EventHandler(this.button_ThemSV_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1022, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Image = global::Lab02_Nhom.Properties.Resources._56323701;
            this.button2.Location = new System.Drawing.Point(1041, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 45);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.Location = new System.Drawing.Point(1022, 393);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(81, 32);
            this.button_Xoa.TabIndex = 9;
            this.button_Xoa.Text = "Xoá";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(911, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 54);
            this.button3.TabIndex = 10;
            this.button3.Text = "BẢNG ĐIỂM";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // QLLH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 619);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_ThemSV);
            this.Controls.Add(this.button_ThemLop);
            this.Controls.Add(this.button_Thoat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_NowUser);
            this.Controls.Add(this.label1);
            this.Name = "QLLH";
            this.Text = "QLLH";
            this.Load += new System.EventHandler(this.QLLH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVNhom2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVNhom2DataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_NowUser;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Thoat;
        private QLSVNhom2DataSet1 qLSVNhom2DataSet1;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private QLSVNhom2DataSet1TableAdapters.LOPTableAdapter lOPTableAdapter;
        private QLSVNhom2DataSet2 qLSVNhom2DataSet2;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private QLSVNhom2DataSet2TableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.Button button_ThemLop;
        private System.Windows.Forms.Button button_ThemSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn mASVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hOTENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYSINHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIACHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mALOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENDNDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button3;
    }
}