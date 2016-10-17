using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;


namespace BusinessLogic
{
    public class User
    {
        public int ID { get; set; }
        public string Password { get; set; }

        public User(int ID, string password)
        {
            this.ID = ID;
            this.Password = password;
        }


        public Boolean login()
        {
            DAOuser daouser = new DAOuser();
            return daouser.grantAccess(Password);
        }
    }


}
