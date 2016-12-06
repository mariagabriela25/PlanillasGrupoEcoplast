
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccess
{
    /// <summary>
    /// Class DAOuser. Manages information about users, and the connections to the database.
    /// </summary>
    public class DAOuser
    {
        /// <summary>
        /// Gets or sets the identifier of the user
        /// </summary>
        /// <value>The identifier.</value>
        public int ID { get; set; }
        /// <summary>
        /// Gets or sets the user's password.
        /// </summary>
        /// <value>The password.</value>
        public string Password { get; set; }

        /// <summary>
        /// The connection to the database
        /// </summary>
        SqlConnection con = new SqlConnection(DataAccess.Properties.Settings.Default.StringConexAnviz);

        /// <summary>
        /// Initializes a new instance of the <see cref="DAOuser"/> class.
        /// </summary>
        public DAOuser()
        {
        }

        /// <summary>
        /// Grants the access to the system
        /// </summary>
        /// <param name="password">The password of the user</param>
        /// <returns>Boolean if its correct, false if not</returns>
        public Boolean grantAccess(string password)
        {
            try
            {

                if (con.State != System.Data.ConnectionState.Open)
                {
                    con.Open();
                }

                SqlCommand command = new SqlCommand("SELECT Usuario.[password] From Usuario where Usuario.ID = @id", con);

                command.Parameters.AddWithValue("@id", 1);
                SqlDataReader reader = command.ExecuteReader();
                String pass = "";
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        pass = reader.GetString(0);
                    }
                }
                if (pass.Equals(password))
                {
                    return true;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sus credenciales son incorrectos u ocurrió un error en la conexión ¡Inténtelo de nuevo!");
            }
            finally
            {
                if (con.State != System.Data.ConnectionState.Closed)
                {
                    con.Close();
                }
            }

            return false;
        }

        /// <summary>
        /// Changes the user's password
        /// </summary>
        /// <param name="oldpsw">The old password.</param>
        /// <param name="newpsw">The new password.</param>
        /// <returns>Boolean true if the change was made, false if not</returns>
        public Boolean ChangePsw(String oldpsw, String newpsw)
        {

            try
            {
                if (grantAccess(oldpsw))
                {
                    if (con.State != System.Data.ConnectionState.Open)
                    {
                        con.Open();
                    }

                    SqlCommand command = new SqlCommand("UPDATE Usuario Set password = @Psw where Usuario.ID = @id", con);
                    command.Parameters.AddWithValue("@id", 1);
                    command.Parameters.AddWithValue("@Psw", newpsw);

                    command.ExecuteNonQuery();
                    return true;

                }
                else
                {
                    MessageBox.Show("Contraseña antigua incorrecta");
                    return false;
                }
            } catch (Exception ex)
            {

            } finally
            {
                if (con.State != System.Data.ConnectionState.Closed)
                {
                    con.Close();
                }
            }
            return false;
        }
    }
}
