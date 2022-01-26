namespace Winform_QuanLySinhVien3._0
{
    partial class fUpdatePassword
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
            this.txt_OldPassword = new System.Windows.Forms.TextBox();
            this.btn_Exit2 = new System.Windows.Forms.Button();
            this.bnt_updatePassword = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NewPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_OldPassword
            // 
            this.txt_OldPassword.Location = new System.Drawing.Point(241, 28);
            this.txt_OldPassword.Name = "txt_OldPassword";
            this.txt_OldPassword.PasswordChar = '●';
            this.txt_OldPassword.Size = new System.Drawing.Size(197, 22);
            this.txt_OldPassword.TabIndex = 0;
            // 
            // btn_Exit2
            // 
            this.btn_Exit2.Location = new System.Drawing.Point(293, 228);
            this.btn_Exit2.Name = "btn_Exit2";
            this.btn_Exit2.Size = new System.Drawing.Size(117, 55);
            this.btn_Exit2.TabIndex = 4;
            this.btn_Exit2.Text = "thoát";
            this.btn_Exit2.UseVisualStyleBackColor = true;
            this.btn_Exit2.Click += new System.EventHandler(this.btn_Exit2_Click);
            // 
            // bnt_updatePassword
            // 
            this.bnt_updatePassword.Location = new System.Drawing.Point(79, 228);
            this.bnt_updatePassword.Name = "bnt_updatePassword";
            this.bnt_updatePassword.Size = new System.Drawing.Size(117, 55);
            this.bnt_updatePassword.TabIndex = 3;
            this.bnt_updatePassword.Text = "Đổi mật khẩu";
            this.bnt_updatePassword.UseVisualStyleBackColor = true;
            this.bnt_updatePassword.Click += new System.EventHandler(this.bnt_updatePassword_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(61, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 22);
            this.label8.TabIndex = 42;
            this.label8.Text = "Mật khẩu cũ :";
            // 
            // txt_ConfirmPassword
            // 
            this.txt_ConfirmPassword.Location = new System.Drawing.Point(241, 154);
            this.txt_ConfirmPassword.Name = "txt_ConfirmPassword";
            this.txt_ConfirmPassword.PasswordChar = '●';
            this.txt_ConfirmPassword.Size = new System.Drawing.Size(197, 22);
            this.txt_ConfirmPassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 22);
            this.label1.TabIndex = 46;
            this.label1.Text = "Xác nhận mật khẩu :";
            // 
            // txt_NewPassword
            // 
            this.txt_NewPassword.Location = new System.Drawing.Point(241, 90);
            this.txt_NewPassword.Name = "txt_NewPassword";
            this.txt_NewPassword.PasswordChar = '●';
            this.txt_NewPassword.Size = new System.Drawing.Size(197, 22);
            this.txt_NewPassword.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 22);
            this.label2.TabIndex = 48;
            this.label2.Text = "Mật khẩu mới :";
            // 
            // fUpdatePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 328);
            this.Controls.Add(this.txt_NewPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ConfirmPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_OldPassword);
            this.Controls.Add(this.btn_Exit2);
            this.Controls.Add(this.bnt_updatePassword);
            this.Controls.Add(this.label8);
            this.Name = "fUpdatePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fResetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_OldPassword;
        private System.Windows.Forms.Button btn_Exit2;
        private System.Windows.Forms.Button bnt_updatePassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_ConfirmPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NewPassword;
        private System.Windows.Forms.Label label2;
    }
}