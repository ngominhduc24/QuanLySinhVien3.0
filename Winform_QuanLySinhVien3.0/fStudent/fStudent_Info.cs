using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_QuanLySinhVien3._0.DAO_data_access_object_;
using Winform_QuanLySinhVien3._0.DTO_data_transfer_object_;

namespace Winform_QuanLySinhVien3._0
{
    public partial class fStudent_Info : Form
    {
        private int idAccount;
        private void FillDataUser()
        {
            User user = InfoDAO.Instance.GetDataStudent(idAccount);
            txt_Name.Text = user.Name;
            txt_Sex.Text = user.Sex;
            txt_Specialized.Text = user.Specialized;
            txt_ID.Text = user.idStudent;
            dtpk_DateOfBirth.Value = user.Dateofbirth;
        }

        private void FillDataAccount()
        {
            Account account = InfoDAO.Instance.GetDataAccount(idAccount);
            txt_UserName.Text = account.Username;
            txt_Password.Text = account.Password;

            if (account.Type == 1)
            { txt_TypeAccount.Text = "Giáo viên"; }
            else if (account.Type == 2)
            { txt_TypeAccount.Text = "Học sinh"; }
        }
        public fStudent_Info(int idAccount)
        {
            InitializeComponent();
            this.idAccount = idAccount;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Exit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_UpdatePassword_Click(object sender, EventArgs e)
        {
            fUpdatePassword f = new fUpdatePassword();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void fStudent_Info_Load(object sender, EventArgs e)
        {
            FillDataAccount();
            FillDataUser();
        }

        
    }
}
