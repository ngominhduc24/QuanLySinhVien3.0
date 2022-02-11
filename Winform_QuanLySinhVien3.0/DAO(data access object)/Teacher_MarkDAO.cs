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

        public DataTable LoadDataMark()
        {
            return DataProvider.Instance.ExecuteQuery("EXECUTE DataMark");
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

        public DataTable FindData(string idFind, string nameFind, string subjectFind)
        {
            DataTable data = new DataTable();
            if (idFind != "") { idFind = "AND id LIKE N'%" + idFind + "%' "; } else idFind = " ";
            if (nameFind != "") { nameFind = "AND name LIKE N'%" + nameFind + "%' "; }
            if (subjectFind != "") { subjectFind = "AND subject LIKE N'%" + subjectFind + "%'"; } else subjectFind = " ";
            object[] parameter = new object[] { idFind, nameFind, subjectFind };
            try
            {
                data = DataProvider.Instance.ExecuteQuery("SELECT  M.idStudent, S.name,S.specialized , M.subject, M.test1, M.test2, M.final_exam FROM Mark AS M , Student  AS S   WHERE   M.idstudent =  S.id " + idFind + " " + nameFind + " " + subjectFind + " ");
            }
            catch (Exception) { }
            return data;
        } 

        public bool UpdateMark(object[] parameter)
        {
            string query = "UPDATE Mark  SET test1 = @test1 , test2 = @test2 , final_exam = @final_exam WHERE ID = @ID ; ";
            if (DataProvider.Instance.ExecuteNonQuery(query, parameter) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
