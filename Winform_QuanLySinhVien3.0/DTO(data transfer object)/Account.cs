using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_QuanLySinhVien3._0.DTO_data_transfer_object_
{
    internal class Account
    {
        public Account(DataRow Data)
        {
            this.username = Data["Username"].ToString();
            this.password = Data["Password"].ToString();
            this.type = (int)Data["Type"];
            this.id = (int)Data["id"];
        }

        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private int type;

        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

    }
}
