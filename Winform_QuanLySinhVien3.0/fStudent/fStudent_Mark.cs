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
    public partial class fStudent_Mark : Form
    {
        private int idAccount;

        #region method
        private void LoadDataToDatagrid()
        {
            datagrid_Mark.DataSource = Student_MarkDAO.Instance.LoadDataMark(idAccount);
        }

        private void LoadDataToCombobox()
        {
            List<string> list = Student_MarkDAO.Instance.LoadDataCombobox(idAccount);
            foreach (string item in list)
            {
                cbb_FindSubject.Items.Add(item);
            }
        }

        private void LoadNameAndID()
        {
            User user = Student_MarkDAO.Instance.LoadDataUser(idAccount);
            textName.Text = user.Name;
            textID.Text = user.idStudent;
        }
        private void LoadDataAfterFind()
        {
            datagrid_Mark.DataSource = Student_MarkDAO.Instance.FindBySubject(idAccount,cbb_FindSubject.Text);
        }
        #endregion
        public fStudent_Mark(int idAccount)
        {
            InitializeComponent();
            this.idAccount = idAccount;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void fStudent_Mark_Load(object sender, EventArgs e)
        {
            LoadDataToDatagrid();
            LoadDataToCombobox();
            LoadNameAndID();
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            LoadDataAfterFind();
        }
    }
}
