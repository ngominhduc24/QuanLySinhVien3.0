using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Winform_QuanLySinhVien3._0
{
    public class DataProvider
    {
        private string connectionString = @"Data Source=NAMLUNXANH\MYSQLSEVER;Initial Catalog=QuanLySinhVien_3.0;Integrated Security=True";
        DataProvider() {}

        private static DataProvider instance;

        public static DataProvider Instance 
        { 
            get
            {
                if (instance == null) instance = new DataProvider();
                return instance;
            }
        }
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using ( SqlConnection sqlConnection = new SqlConnection(connectionString) )
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(query, sqlConnection);
                // truyền parameter
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            string value = parameter[i].ToString();
                            command.Parameters.AddWithValue(item, value);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
            }
            
            return data;
        }
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int result = 0;
            using ( SqlConnection sqlConnection = new SqlConnection(connectionString) )
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(query, sqlConnection);
                // truyền parameter
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            string value = parameter[i].ToString();
                            command.Parameters.AddWithValue(item, value);
                            i++;
                        }
                    }
                }
                result = command.ExecuteNonQuery();
            }
            
            return result;

        }
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(query, sqlConnection);
                // truyền parameter
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            string value = parameter[i].ToString();
                            command.Parameters.AddWithValue(item, value);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
            }

                return data;
        }

    }
}