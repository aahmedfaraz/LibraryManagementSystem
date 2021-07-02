using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Management_System
{
    class Admin
    {
        protected static Admin admin;
        public int id;
        public string name;
        public string email;
        public string password;
        public string designation;
        public string hiredate;
        public string retiredate;
        private Admin (int id, string name, string email, string password, string designation, string hiredate, string retiredate)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = password;
            this.designation = designation;
            this.hiredate = hiredate;
            this.retiredate = retiredate;
        }
        public static Admin GetAdmin(int id, string name, string email, string password, string designation, string hiredate, string retiredate) {
            if (admin == null) {
                admin = new Admin(id, name, email, password, designation, hiredate, retiredate);
            }
            return admin;
        }
    }
}
