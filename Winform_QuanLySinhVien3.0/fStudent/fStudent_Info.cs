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
    public partial class fStudent_Info : Form
    {
        public fStudent_Info()
        {
            InitializeComponent();
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
    }
}
