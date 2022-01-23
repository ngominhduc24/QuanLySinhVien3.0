using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Winform_QuanLySinhVien3._0.DAO_data_access_object_
{
    internal class Student_MarkDAO
    {
        Student_MarkDAO() { }

        private static Student_MarkDAO instance;

        public static Student_MarkDAO Instance
        {
            get
            {
                if (instance == null) instance = new Student_MarkDAO();
                return instance;
            }
        }

        public DataTable LoadDataMark(int idAccount)
        {
            object[] parameter = new object[] { idAccount };
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM Mark WHERE idStudent = ( SELECT id FROM Student WHERE idAccount = @idAccount )",parameter);
        }
    }
}
