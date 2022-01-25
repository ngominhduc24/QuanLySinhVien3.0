namespace Winform_QuanLySinhVien3._0
{
    partial class fStudent_Main
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
            this.btn_info = new System.Windows.Forms.Button();
            this.btn_ShowMark = new System.Windows.Forms.Button();
            this.btn_Report = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label_Name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_info
            // 
            this.btn_info.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_info.Location = new System.Drawing.Point(126, 79);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(222, 118);
            this.btn_info.TabIndex = 0;
            this.btn_info.Text = "Thông tin";
            this.btn_info.UseVisualStyleBackColor = false;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // btn_ShowMark
            // 
            this.btn_ShowMark.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ShowMark.Location = new System.Drawing.Point(126, 237);
            this.btn_ShowMark.Name = "btn_ShowMark";
            this.btn_ShowMark.Size = new System.Drawing.Size(222, 118);
            this.btn_ShowMark.TabIndex = 1;
            this.btn_ShowMark.Text = "Xem điểm";
            this.btn_ShowMark.UseVisualStyleBackColor = false;
            this.btn_ShowMark.Click += new System.EventHandler(this.btn_ShowMark_Click);
            // 
            // btn_Report
            // 
            this.btn_Report.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Report.Location = new System.Drawing.Point(439, 79);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(222, 118);
            this.btn_Report.TabIndex = 2;
            this.btn_Report.Text = "Báo cáo";
            this.btn_Report.UseVisualStyleBackColor = false;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Exit.Location = new System.Drawing.Point(439, 237);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(222, 118);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "Đăng xuất";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(12, 9);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(51, 19);
            this.label_Name.TabIndex = 4;
            this.label_Name.Text = "label1";
            // 
            // fStudent_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Report);
            this.Controls.Add(this.btn_ShowMark);
            this.Controls.Add(this.btn_info);
            this.Name = "fStudent_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý học sinh";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fStudent_Main_FormClosed);
            this.Load += new System.EventHandler(this.fStudent_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Button btn_ShowMark;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label_Name;
    }
}