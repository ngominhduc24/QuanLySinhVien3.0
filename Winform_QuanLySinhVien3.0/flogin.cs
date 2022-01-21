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
            fStudent_Main f = new fStudent_Main();
            this.Hide();
            f.Show();
        }

    
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
