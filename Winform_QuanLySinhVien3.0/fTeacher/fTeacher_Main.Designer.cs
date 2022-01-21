namespace Winform_QuanLySinhVien3._0
{
    partial class fTeacher_Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_ShowMark = new System.Windows.Forms.Button();
            this.btn_info = new System.Windows.Forms.Button();
            this.btn_ManageStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Exit.Location = new System.Drawing.Point(439, 237);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(222, 118);
            this.btn_Exit.TabIndex = 8;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_ShowMark
            // 
            this.btn_ShowMark.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ShowMark.Location = new System.Drawing.Point(140, 224);
            this.btn_ShowMark.Name = "btn_ShowMark";
            this.btn_ShowMark.Size = new System.Drawing.Size(222, 118);
            this.btn_ShowMark.TabIndex = 6;
            this.btn_ShowMark.Text = "Quản lý điểm";
            this.btn_ShowMark.UseVisualStyleBackColor = false;
            this.btn_ShowMark.Click += new System.EventHandler(this.btn_ShowMark_Click);
            // 
            // btn_info
            // 
            this.btn_info.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_info.Location = new System.Drawing.Point(439, 57);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(222, 118);
            this.btn_info.TabIndex = 5;
            this.btn_info.Text = "Thông tin";
            this.btn_info.UseVisualStyleBackColor = false;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // btn_ManageStudent
            // 
            this.btn_ManageStudent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ManageStudent.Location = new System.Drawing.Point(140, 57);
            this.btn_ManageStudent.Name = "btn_ManageStudent";
            this.btn_ManageStudent.Size = new System.Drawing.Size(222, 118);
            this.btn_ManageStudent.TabIndex = 5;
            this.btn_ManageStudent.Text = "Quản lý học sinh";
            this.btn_ManageStudent.UseVisualStyleBackColor = false;
            this.btn_ManageStudent.Click += new System.EventHandler(this.btn_ManageStudent_Click);
            // 
            // fTeacher_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 428);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_ShowMark);
            this.Controls.Add(this.btn_ManageStudent);
            this.Controls.Add(this.btn_info);
            this.Name = "fTeacher_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý học sinh";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fTeacher_Main_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_ShowMark;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Button btn_ManageStudent;
    }
}