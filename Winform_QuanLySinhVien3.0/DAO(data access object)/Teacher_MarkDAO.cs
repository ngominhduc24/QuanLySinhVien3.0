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
    }
}
