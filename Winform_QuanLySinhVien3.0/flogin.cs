using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_QuanLySinhVien3._0.DAO;

namespace Winform_QuanLySinhVien3._0
{
    public partial class flogin : Form
    {
        public flogin()
        {
            InitializeComponent();
        }

        private void flogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            int TypeAccount = LoginDAO.Instance.GetTypeAccount(txt_Username.Text, txt_Password.Text);
            CheckAccountAndLogin(TypeAccount);
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void flogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btn_Login.PerformClick();
            }
        }


        /// <summary>
        /// truyền vào loại account kiểm tra | -1 là nhập sai|1 là giáo viên;|2 là học sinh 
        /// </summary>
        /// <param name="TypeAccount"></param>
        private void CheckAccountAndLogin(int TypeAccount)
        {
            if ( LoginDAO.Instance.CheckAccount(txt_Username.Text, txt_Password.Text) == false )
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác, vui lòng thử lại", "Thông báo");
            }
            else
            {
                int idAccount = LoginDAO.Instance.GetIdAccount(txt_Username.Text, txt_Password.Text);

                if (TypeAccount == 1)
                {
                    fTeacher_Main f = new fTeacher_Main(idAccount);
                    this.Hide();
                    f.Show();
                }
                else if (TypeAccount == 2)
                {
                    fStudent_Main f = new fStudent_Main(idAccount);
                    this.Hide();
                    f.Show();
                }
            }
            
                

        }
    }

}
