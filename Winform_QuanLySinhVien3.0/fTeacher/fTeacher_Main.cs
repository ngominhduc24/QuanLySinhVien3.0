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
    public partial class fTeacher_Main : Form
    {
        private int idAccount;
        public fTeacher_Main(int idAccount)
        {
            InitializeComponent();
            this.idAccount = idAccount;
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            flogin f = new flogin();
            f.ShowDialog();
        }

        private void fTeacher_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_ShowMark_Click(object sender, EventArgs e)
        {
            fTeacher_Mark f = new fTeacher_Mark(idAccount);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            fTeacher_Info f = new fTeacher_Info();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btn_ManageStudent_Click(object sender, EventArgs e)
        {
            fTeacher_MagageStudent f = new fTeacher_MagageStudent(idAccount);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void fTeacher_Main_Load(object sender, EventArgs e)
        {
            label_Name.Text = DAOGetName(idAccount);
        }

        private string DAOGetName(int idAccount)
        {
            object[] parameter = new object[] { idAccount.ToString() };
            string data = (string)DataProvider.Instance.ExecuteScalar("SELECT name FROM Teacher WHERE idAccount = @idAccount ", parameter);
            return data;
        }

       
    }
}
