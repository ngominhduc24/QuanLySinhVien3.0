using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_QuanLySinhVien3._0
{
    public partial class fUpdatePassword : Form
    {
        private int idAccount;
        public fUpdatePassword(int idAccount)
        {
            InitializeComponent();
            this.idAccount = idAccount;
        }

        private bool comparePasswordAndConfirmPassword()
        {
            if (txt_NewPassword.Text.Trim() != txt_ConfirmPassword.Text.Trim())
            {
                return false;
            }
            return true;
        }

        private bool CheckUpdateChangePassword(string newPassword, int idaccount, string oldPassword)
        {
            string query = "UPDATE Account SET password = @password WHERE id = @id AND password = @oldPassword ";
            object[] parameter = new object[] { newPassword, idaccount, oldPassword };
            if ( DataProvider.Instance.ExecuteNonQuery(query,parameter) > 0)
            {
                return true;
            }
            return false;
        }

        private void btn_Exit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bnt_updatePassword_Click(object sender, EventArgs e)
        {
            if ( comparePasswordAndConfirmPassword() == true )
            {
                if (CheckUpdateChangePassword( txt_NewPassword.Text, idAccount, txt_OldPassword.Text) == true)
                {
                    MessageBox.Show("Đổi mật khẩu thành công", "Thông báo");
                }
                else
                    MessageBox.Show("Đổi mật khẩu không thành công", "Thông báo");

            }
            else
            {
                MessageBox.Show("Mật khẩu xác nhận sai, mời bạn nhập lại", "Thông báo");
            }
        }

    }
}
