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
    public partial class fStudent_Main : Form
    {
        public fStudent_Main()
        {
            InitializeComponent();
            label1.Text = "Hello duc";
        }

        private void fStudent_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            flogin f = new flogin();
            this.Hide();
            f.ShowDialog();
           
        }

        private void btn_ShowMark_Click(object sender, EventArgs e)
        {
            fStudent_Mark f = new fStudent_Mark();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            fStuden_Report f = new fStuden_Report();
            f.Show();
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            fStudent_Info f = new fStudent_Info();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
