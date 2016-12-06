
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;


namespace BusinessLogic
{
    /// <summary>
    /// Class User. Represents the user in the system.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The user's identifier</value>
        public int ID { get; set; }
        /// <summary>
        /// Gets or sets the password of the user
        /// </summary>
        /// <value>The user's password.</value>
        public string Password { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        /// <param name="ID">The identifier of the user</param>
        /// <param name="password">The password or the user</param>
        public User(int ID, string password)
        {
            this.ID = ID;
            this.Password = password;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        public User() { }


        /// <summary>
        /// Logins this instance.
        /// </summary>
        /// <returns>true if the credentials ingressed are corrects, false if not</returns>
        public Boolean login()
        {
            DAOuser daouser = new DAOuser();
            return daouser.grantAccess(Password);
        }

        /// <summary>
        /// Changes the Password
        /// </summary>
        /// <param name="oldpsw">The old password.</param>
        /// <param name="newpsw">The new password.</param>
        /// <returns>true if the old password is correct, false if not.</returns>
        public Boolean ChangePsw(string oldpsw, string newpsw)
        {
            return new DAOuser().ChangePsw(oldpsw, newpsw);
        }
    }


}
