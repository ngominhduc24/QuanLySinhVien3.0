using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_QuanLySinhVien3._0.DTO_data_transfer_object_
{
    internal class User
    {
        public User(DataRow Data)
        {
            this.idaccount = Data["idAccount"].ToString();
            this.name = Data["name"].ToString();
            this.specialized = Data["specialized"].ToString();
            this.sex = Data["sex"].ToString();
            this.dateofbirth = (DateTime)Data["Dateofbirth"];
            if (Data.Table.Columns.Count > 5)
            {
                this.idstudent = Data["id"].ToString();
            }
        }

        private string idaccount;
        public string idAccount 
        { 
            get { return idaccount; } 
            set { idaccount = value; } 
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string specialized;
        public string Specialized
        {
            get { return specialized; }
            set { specialized = value; }
        }

        private string sex;
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        private string idstudent;
        public string idStudent
        {
            get { return idstudent; }
            set { idstudent = value; }
        }

        private DateTime dateofbirth;
        public DateTime Dateofbirth
        { 
            get { return dateofbirth; } 
            set { dateofbirth = value; }
        }

    }
}
