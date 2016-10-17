using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccess
{
    public class DAOuser
    {
        public int ID { get; set; }
        public string Password { get; set; }

        SqlConnection con = new SqlConnection(DataAccess.Properties.Settings.Default.StringConex);

        public DAOuser()
        {
        }

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
                MessageBox.Show("Sus credenciales son incorrectos");
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


    }
}
