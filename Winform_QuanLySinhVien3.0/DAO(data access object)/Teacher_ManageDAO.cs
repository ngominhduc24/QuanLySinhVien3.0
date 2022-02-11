using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Winform_QuanLySinhVien3._0.DTO_data_transfer_object_;

namespace Winform_QuanLySinhVien3._0.DAL_data_access_layer_
{
    internal class Teacher_ManageDAO
    {
        Teacher_ManageDAO() { }

        private static Teacher_ManageDAO instance;
        public static Teacher_ManageDAO Instance
        {
            get
            {
                if (instance == null) instance = new Teacher_ManageDAO();
                return instance;
            }
        }
        public DataTable LoadDataStudent(int IdAccount)
        {
            return DataProvider.Instance.ExecuteQuery(" EXECUTE DataStudent ");
        }
        public List<string> LoadDataCombobox(int idAccount)
        {
            List<string> list = new List<string>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT specialized FROM student GROUP BY specialized ");
            foreach (DataRow row in data.Rows)
            {
                list.Add(row["specialized"].ToString());
            }
            return list;
        }
        public DataTable FindData(string idFind, string nameFind, string specializedFind)
        {
            DataTable data = new DataTable();
            if (idFind != "") { idFind = "WHERE id LIKE N'%" + idFind + "%' "; } else idFind = " WHERE 1 = 1 ";
            if (nameFind != "") { nameFind = "AND name LIKE N'%" + nameFind + "%' "; }
            if (specializedFind != "") { specializedFind = "AND specialized LIKE N'%" + specializedFind + "%'"; } else specializedFind = " ";
            try
            {
                data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Student " + idFind + " " + nameFind + " " + specializedFind + " ");
            }
            catch (Exception) { }
            return data;
        } // chưa sửa xong , không truyền được parameter(tạo procedure trong sql)
        public bool UpdateData(User user)
        {
            object[] parameter = new object[] { user.Name, user.Specialized, user.Sex, user.Dateofbirth, user.idStudent };
            string query = "UPDATE Student  SET Name = @Name , specialized = @specialized  ,Sex = @sex , Dateofbirth = @Dateofbirth WHERE ID = @IdStudent ; ";
            if (DataProvider.Instance.ExecuteNonQuery(query, parameter) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
