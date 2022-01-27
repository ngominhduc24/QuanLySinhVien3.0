using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Winform_QuanLySinhVien3._0.DAO_data_access_object_
{
    internal class Teacher_MarkDAO
    {
        Teacher_MarkDAO() { }

        private static Teacher_MarkDAO instance;

        public static Teacher_MarkDAO Instance
        {
            get
            {
                if (instance == null) instance = new Teacher_MarkDAO();
                return instance;
            }
        }

        public DataTable LoadDataMark(int idAccount)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT  student.name, student.specialized ,student.dateofbirth  ,mark.* FROM Mark , Student  WHERE Mark.idstudent = student.id");
        }

        public List<string> LoadDataCombobox(int idAccount)
        {
            List<string> list = new List<string>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT subject FROM Mark GROUP BY subject ");
            foreach (DataRow row in data.Rows)
            {
                list.Add(row["subject"].ToString());
            }
            return list;
        }

        public DataTable FindData(string idFind  , string nameFind , string subjectFind )
        {
            DataTable data = new DataTable();
            if ( idFind != "" ) { idFind = "AND idstudent LIKE N'%" + idFind +"%' "; } else  idFind = " "; 
            if (nameFind != "") { nameFind = "AND name LIKE N'%" + nameFind + "%' "; } else nameFind = " ";
            if (subjectFind != "" ) { subjectFind = "AND subject LIKE N%" + subjectFind + "%'"; } else subjectFind = " ";
            object[] parameter = new object[] { idFind, nameFind, subjectFind };
            try
            {
                 data = DataProvider.Instance.ExecuteQuery(" SELECT  student.name, student.specialized ,student.dateofbirth  ,mark.* FROM Mark , Student  WHERE Mark.idstudent = student.id "+idFind+ " " + nameFind + " " + subjectFind + " ");
            } 
            catch (Exception)
            {

               
            }
            
            return data;
        } // chưa sửa xong , không truyền được parameter(tạo procedure trong sql)
    }
}
