using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winform_QuanLySinhVien3._0.DTO_data_transfer_object_;

namespace Winform_QuanLySinhVien3._0.DAO
{
    internal class LoginDAO
    {
        LoginDAO() { }

        private static LoginDAO instance;

        public static LoginDAO Instance
        {
            get
            {
                if (instance == null) instance = new LoginDAO();
                return instance;
            }
        }

        public int GetTypeAccount(string Username, string Password) 
        {
            if (CheckAccount(Username,Password))
            {
                object[] parameter = new object[] { Username, Password };
                DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Account WHERE Username = @Username  and Password = @Password ", parameter);
                Account account = new Account(data.Rows[0]);
                return account.Type;
            }
            return -1;
        }

        public bool CheckAccount(string Username, string Password)
        {
            object[] parameter = new object[] { Username, Password };
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Account WHERE Username = @Username  and Password = @Password ", parameter);
            int result = data.Rows.Count;
            if (result > 0)
                return true;
            return false;
        }

    }
}
