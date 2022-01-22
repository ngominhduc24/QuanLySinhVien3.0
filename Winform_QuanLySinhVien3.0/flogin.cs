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
            int TypeAccount = LoginDAO.Instance.GetTypeAccount(txt_UserName.Text, txt_Password.Text);
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

       

        private void btn_Login_Click(object sender, EventArgs e)
        /// <summary>
        /// truyền vào loại account kiểm tra | -1 là nhập sai|1 là giáo viên;|2 là học sinh 
        /// </summary>
        /// <param name="TypeAccount"></param>
        private void CheckAccountAndLogin(int TypeAccount)
        {
            int type = GetTypeAccount();
            if (type == 1)
            {
                fTeacher_Main f = new fTeacher_Main();
                this.Hide();
                f.Show();
            }
            else if (type == 2)
            {
                fStudent_Main f = new fStudent_Main();
                this.Hide();
                f.Show();
            }
            else if (type == -1)
                MessageBox.Show("mời bạn nhập lại");
            
        }

    
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region method

        private int GetTypeAccount() // cai nay la cua DAO
        {
             if (CheckAccount())
             {
                object[] parameter = new object[] { txt_UserName.Text, txt_Password.Text };
                DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Account WHERE Username = @Username  and Password = @Password ", parameter);
                DataRow dataRow = data.Rows[0];
                int type = (int)dataRow["Type"];
                return type;
             }
            return -1   ;
        }

        private bool CheckAccount()
        {
            object[] parameter = new object[] { txt_UserName.Text, txt_Password.Text }; 
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Account WHERE Username = @Username  and Password = @Password ",parameter);         
            int result = data.Rows.Count;
            if (result > 0)
                return true;
            return false;
        }

        #endregion
    }
}
