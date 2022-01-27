using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM Student ");
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
        public DataTable FindData(string idFind, string nameFind, string subjectFind)
        {
            DataTable data = new DataTable();
            if (idFind != "") { idFind = "WHERE id LIKE N'%" + idFind + "%' "; } else idFind = " WHERE 1 = 1 ";
            if (nameFind != "") { nameFind = "AND name LIKE N'%" + nameFind + "%' "; } else nameFind = " ";
            if (subjectFind != "") { subjectFind = "AND subject LIKE N%" + subjectFind + "%'"; } else subjectFind = " ";
            object[] parameter = new object[] { idFind, nameFind, subjectFind };
            try
            {
                data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Student " + idFind + " " + nameFind + " " + subjectFind + " ");
            }
            catch (Exception)
            {


            }

            return data;
        } // chưa sửa xong , không truyền được parameter(tạo procedure trong sql)
    }
}
