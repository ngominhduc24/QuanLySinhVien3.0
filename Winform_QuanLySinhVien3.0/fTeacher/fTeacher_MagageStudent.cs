using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_QuanLySinhVien3._0.DAL_data_access_layer_;

namespace Winform_QuanLySinhVien3._0
{
    public partial class fTeacher_MagageStudent : Form
    {

        private int idAccount;

        #region method
        private void LoadDataToDatagrid()
        {
            datagrid_StudentInfo.DataSource = Teacher_ManageDAO.Instance.LoadDataStudent(idAccount);
        }

        private void LoadDataToCombobox()
        {
            List<string> list = Teacher_ManageDAO.Instance.LoadDataCombobox(idAccount);
            foreach (string item in list)
            {
                cbb_FindSubject.Items.Add(item);
            }
        }
        #endregion
        public fTeacher_MagageStudent(int idAccount)
        {
            InitializeComponent();
            this.idAccount = idAccount;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fTeacher_MagageStudent_Load(object sender, EventArgs e)
        {
            LoadDataToDatagrid();
            LoadDataToCombobox();
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            datagrid_StudentInfo.DataSource = Teacher_ManageDAO.Instance.FindData(txt_FindID.Text.Trim(), txt_FindName.Text.Trim(), cbb_FindSubject.Text.Trim());
            // bug not fixed
        }
    }
}
