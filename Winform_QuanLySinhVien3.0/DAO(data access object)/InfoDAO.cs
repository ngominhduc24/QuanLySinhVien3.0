using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winform_QuanLySinhVien3._0.DTO_data_transfer_object_;
using System.Data;

namespace Winform_QuanLySinhVien3._0.DAO_data_access_object_
{
    internal class InfoDAO
    {
        InfoDAO() { }

        private static InfoDAO instance;

        public static InfoDAO Instance
        {
            get
            {
                if (instance == null) instance = new InfoDAO();
                return instance;
            }
        }

       public User GetDataTeacher(int idAccount)
        {
            object[] parameter = new object[] { idAccount };
            DataTable Data = DataProvider.Instance.ExecuteQuery("SELECT * FROM TEACHER WHERE idAccount = @idAccount ",parameter);
            User user = new User(Data.Rows[0]);
            return user;
        }

        public Account GetDataAccount(int idAccount)
        {
            object[] parameter = new object[] { idAccount };
            DataTable Data = DataProvider.Instance.ExecuteQuery("SELECT * FROM ACCOUNT WHERE id = @idAccount ", parameter);
            Account account = new Account(Data.Rows[0]);
            return account;
        }

        public User GetDataStudent(int idAccount)
        {
            object[] parameter = new object[] { idAccount };
            DataTable Data = DataProvider.Instance.ExecuteQuery("SELECT * FROM STUDENT WHERE idAccount = @idAccount ", parameter);
            User user = new User(Data.Rows[0]);
            return user;
        }

        public bool UpdateInfo(int oldIdAccount, User user)
        {
            object[] parameter = new object[] { user.Name , user.Specialized , user.Sex ,user.Dateofbirth.ToString() , oldIdAccount.ToString() };
            string query = "UPDATE Teacher SET name = @name , specialized = @specialized , sex = @sex , dateofbirth = @dateofbirth where idaccount = @oldidaccouunt ";
            if ( DataProvider.Instance.ExecuteNonQuery(query, parameter) > 0 )
            {
                return true;
            }
            return false;
        }
    }
}
