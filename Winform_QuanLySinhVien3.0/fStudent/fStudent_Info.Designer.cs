namespace Winform_QuanLySinhVien3._0
{
    partial class fStudent_Info
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.dtpk_DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txt_Specialized = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Sex = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_TypeAccount = new System.Windows.Forms.TextBox();
            this.btn_Exit2 = new System.Windows.Forms.Button();
            this.btn_UpdatePassword = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(521, 470);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage1.Controls.Add(this.btn_Exit);
            this.tabPage1.Controls.Add(this.dtpk_DateOfBirth);
            this.tabPage1.Controls.Add(this.txt_Specialized);
            this.tabPage1.Controls.Add(this.txt_ID);
            this.tabPage1.Controls.Add(this.txt_Sex);
            this.tabPage1.Controls.Add(this.txt_Name);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(513, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông tin cá nhân";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(345, 353);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(113, 53);
            this.btn_Exit.TabIndex = 34;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // dtpk_DateOfBirth
            // 
            this.dtpk_DateOfBirth.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpk_DateOfBirth.Enabled = false;
            this.dtpk_DateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpk_DateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpk_DateOfBirth.Location = new System.Drawing.Point(214, 233);
            this.dtpk_DateOfBirth.Name = "dtpk_DateOfBirth";
            this.dtpk_DateOfBirth.Size = new System.Drawing.Size(200, 24);
            this.dtpk_DateOfBirth.TabIndex = 33;
            // 
            // txt_Specialized
            // 
            this.txt_Specialized.Enabled = false;
            this.txt_Specialized.Location = new System.Drawing.Point(217, 301);
            this.txt_Specialized.Name = "txt_Specialized";
            this.txt_Specialized.Size = new System.Drawing.Size(197, 30);
            this.txt_Specialized.TabIndex = 32;
            // 
            // txt_ID
            // 
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(217, 101);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(197, 30);
            this.txt_ID.TabIndex = 31;
            // 
            // txt_Sex
            // 
            this.txt_Sex.Enabled = false;
            this.txt_Sex.Location = new System.Drawing.Point(217, 166);
            this.txt_Sex.Name = "txt_Sex";
            this.txt_Sex.Size = new System.Drawing.Size(197, 30);
            this.txt_Sex.TabIndex = 30;
            // 
            // txt_Name
            // 
            this.txt_Name.Enabled = false;
            this.txt_Name.Location = new System.Drawing.Point(217, 35);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(197, 30);
            this.txt_Name.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 22);
            this.label5.TabIndex = 28;
            this.label5.Text = "Chuyên ngành :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 22);
            this.label4.TabIndex = 27;
            this.label4.Text = "Ngày sinh :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 26;
            this.label3.Text = "Giới tính :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "Mã sinh viên :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 22);
            this.label1.TabIndex = 24;
            this.label1.Text = "Họ và tên :";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage2.Controls.Add(this.txt_Password);
            this.tabPage2.Controls.Add(this.txt_UserName);
            this.tabPage2.Controls.Add(this.txt_TypeAccount);
            this.tabPage2.Controls.Add(this.btn_Exit2);
            this.tabPage2.Controls.Add(this.btn_UpdatePassword);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(513, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thông tin tài khoản";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(206, 236);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '●';
            this.txt_Password.ReadOnly = true;
            this.txt_Password.Size = new System.Drawing.Size(197, 30);
            this.txt_Password.TabIndex = 41;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(206, 146);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.ReadOnly = true;
            this.txt_UserName.Size = new System.Drawing.Size(197, 30);
            this.txt_UserName.TabIndex = 40;
            // 
            // txt_TypeAccount
            // 
            this.txt_TypeAccount.Enabled = false;
            this.txt_TypeAccount.Location = new System.Drawing.Point(206, 62);
            this.txt_TypeAccount.Name = "txt_TypeAccount";
            this.txt_TypeAccount.ReadOnly = true;
            this.txt_TypeAccount.Size = new System.Drawing.Size(197, 30);
            this.txt_TypeAccount.TabIndex = 39;
            // 
            // btn_Exit2
            // 
            this.btn_Exit2.Location = new System.Drawing.Point(304, 325);
            this.btn_Exit2.Name = "btn_Exit2";
            this.btn_Exit2.Size = new System.Drawing.Size(117, 55);
            this.btn_Exit2.TabIndex = 37;
            this.btn_Exit2.Text = "thoát";
            this.btn_Exit2.UseVisualStyleBackColor = true;
            // 
            // btn_UpdatePassword
            // 
            this.btn_UpdatePassword.Location = new System.Drawing.Point(90, 325);
            this.btn_UpdatePassword.Name = "btn_UpdatePassword";
            this.btn_UpdatePassword.Size = new System.Drawing.Size(117, 55);
            this.btn_UpdatePassword.TabIndex = 36;
            this.btn_UpdatePassword.Text = "Đổi mật khẩu";
            this.btn_UpdatePassword.UseVisualStyleBackColor = true;
            this.btn_UpdatePassword.Click += new System.EventHandler(this.btn_UpdatePassword_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(52, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 22);
            this.label8.TabIndex = 27;
            this.label8.Text = "Mật khẩu :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 22);
            this.label7.TabIndex = 26;
            this.label7.Text = "Tên đăng nhập :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 22);
            this.label6.TabIndex = 25;
            this.label6.Text = "Loại tài khoản :";
            // 
            // fStudent_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(562, 488);
            this.Controls.Add(this.tabControl1);
            this.Name = "fStudent_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fStudent_Info";
            this.Load += new System.EventHandler(this.fStudent_Info_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.DateTimePicker dtpk_DateOfBirth;
        private System.Windows.Forms.TextBox txt_Specialized;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_Sex;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Exit2;
        private System.Windows.Forms.Button btn_UpdatePassword;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_TypeAccount;
    }
}