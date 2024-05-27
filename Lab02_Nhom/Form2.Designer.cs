namespace Lab02_Nhom
{
    partial class Form2
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
            this.button_QLNV = new System.Windows.Forms.Button();
            this.button_QLLopHoc = new System.Windows.Forms.Button();
            this.button_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_QLNV
            // 
            this.button_QLNV.Location = new System.Drawing.Point(245, 131);
            this.button_QLNV.Name = "button_QLNV";
            this.button_QLNV.Size = new System.Drawing.Size(310, 51);
            this.button_QLNV.TabIndex = 0;
            this.button_QLNV.Text = "QUẢN LÝ NHÂN VIÊN";
            this.button_QLNV.UseVisualStyleBackColor = true;
            this.button_QLNV.Click += new System.EventHandler(this.button_QLNV_Click);
            // 
            // button_QLLopHoc
            // 
            this.button_QLLopHoc.Location = new System.Drawing.Point(245, 224);
            this.button_QLLopHoc.Name = "button_QLLopHoc";
            this.button_QLLopHoc.Size = new System.Drawing.Size(310, 51);
            this.button_QLLopHoc.TabIndex = 1;
            this.button_QLLopHoc.Text = "QUẢN LÝ LỚP HỌC";
            this.button_QLLopHoc.UseVisualStyleBackColor = true;
            this.button_QLLopHoc.Click += new System.EventHandler(this.button_QLLopHoc_Click);
            // 
            // button_Thoat
            // 
            this.button_Thoat.Location = new System.Drawing.Point(638, 373);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(89, 29);
            this.button_Thoat.TabIndex = 2;
            this.button_Thoat.Text = "Thoát";
            this.button_Thoat.UseVisualStyleBackColor = true;
            this.button_Thoat.Click += new System.EventHandler(this.button_Thoat_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Thoat);
            this.Controls.Add(this.button_QLLopHoc);
            this.Controls.Add(this.button_QLNV);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_QLNV;
        private System.Windows.Forms.Button button_QLLopHoc;
        private System.Windows.Forms.Button button_Thoat;
    }
}