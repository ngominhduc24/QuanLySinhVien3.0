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
    }
}
