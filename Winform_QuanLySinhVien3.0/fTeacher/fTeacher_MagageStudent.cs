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
using Winform_QuanLySinhVien3._0.DTO_data_transfer_object_;

namespace Winform_QuanLySinhVien3._0
{
    public partial class fTeacher_MagageStudent : Form
    {

        private int idAccount;
        private int index;

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
                cbb_FindSpecialized.Items.Add(item);
            }
        }

        private User GetDataUser()
        {
            DataGridViewRow Data = datagrid_StudentInfo.Rows[index];
            string idStudent = Data.Cells["id"].Value.ToString();
            string name = Data.Cells["name"].Value.ToString();
            string specialized = Data.Cells["specialized"].Value.ToString();
            string sex = Data.Cells["sex"].Value.ToString();
            DateTime dateofbirth = (DateTime)Data.Cells["dateofbirth"].Value;
            User user = new User(idStudent, name, specialized, sex, dateofbirth);
            return user;
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
            datagrid_StudentInfo.DataSource = Teacher_ManageDAO.Instance.FindData(txt_FindID.Text.Trim(), txt_FindName.Text.Trim(), cbb_FindSpecialized.Text.Trim());
            // bug not fixed
        }

        private void btn_UpdateInfo_Click(object sender, EventArgs e)
        {
            User user = GetDataUser();
            if (Teacher_ManageDAO.Instance.UpdateData(user) == true )
            {
                MessageBox.Show("Lưu thành công","Thông báo");
            }
            else
                MessageBox.Show("Lưu không thành công", "Thông báo");
        }

        private void datagrid_StudentInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }
    }
}
