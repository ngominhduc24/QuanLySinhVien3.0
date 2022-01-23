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

namespace Winform_QuanLySinhVien3._0
{
    public partial class fTeacher_Mark : Form
    {
        private int idAccount;
        public fTeacher_Mark(int idAccount)
        {
            InitializeComponent();
            this.idAccount = idAccount; 
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fTeacher_Mark_Load(object sender, EventArgs e)
        {
            datagrid_Mark.DataSource = Teacher_MarkDAO.Instance.LoadDataMark(idAccount);
        }
    }
}
