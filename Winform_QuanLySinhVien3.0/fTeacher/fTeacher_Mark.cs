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
        private int index;

        #region method
        private void LoadDataToDatagrid()
        {
            datagrid_Mark.DataSource = Teacher_MarkDAO.Instance.LoadDataMark();
        }

        private void LoadDataToCombobox()
        {
            List<string> list = Teacher_MarkDAO.Instance.LoadDataCombobox(idAccount);
            foreach (string item in list)
            {
                cbb_FindSubject.Items.Add(item);
            }
        }

        private void LoadDataAfterFind()
        {
            datagrid_Mark.DataSource = Teacher_MarkDAO.Instance.FindData(txt_FindID.Text.Trim(), txt_FindName.Text.Trim(), cbb_FindSubject.Text.Trim());
            // bug not fixed
        }
        private bool UpdateMarkStudent()
        {
            
            DataGridViewRow Data = datagrid_Mark.Rows[index];
            int test1 = int.Parse(Data.Cells["test1"].Value.ToString());
            int test2 = int.Parse(Data.Cells["test2"].Value.ToString());
            int final_exam = int.Parse(Data.Cells["final_exam"].Value.ToString());
            int id = int.Parse(Data.Cells["id"].Value.ToString());
            object[] parameter = new object[] { test1, test2, final_exam, id };
            if ( Teacher_MarkDAO.Instance.UpdateMark(parameter) == true)
                { return true; }
            else
                return false;
        }

        #endregion
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
            LoadDataToDatagrid();
            LoadDataToCombobox();
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            LoadDataAfterFind();
        }

        private void btn_UpdateMark_Click(object sender, EventArgs e)
        {
            
            if ( UpdateMarkStudent() == true)
            {
                MessageBox.Show("Lưu thành công", "Thông báo");
            }
            else
                MessageBox.Show("Lưu không thành công", "Thông báo");
        }

        private void datagrid_Mark_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }
    }
}
