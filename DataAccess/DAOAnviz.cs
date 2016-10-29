using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TransferObjects;
using System.Windows.Forms;

namespace DataAccess
{
    public class DAOAnviz
    {
        SqlConnection conex = new SqlConnection(DataAccess.Properties.Settings.Default.StringConexAnviz);

        public List<TOCheck> GetChecks(int id, DateTime inicio, DateTime fin)
        {
            try
            {
                List<TOCheck> list = new List<TOCheck>();
                TOCheck check;

                SqlCommand query = new SqlCommand("SELECT Userid, CheckTime, CheckType FROM Checkinout " +
                    "WHERE CheckTime Between @Inicio AND @Fin AND Userid = @ID AND CheckType != '2' ORDER BY CheckTime", conex);

                query.Parameters.AddWithValue("@Inicio", inicio);
                query.Parameters.AddWithValue("@Fin", fin);
                query.Parameters.AddWithValue("@ID", id);

                if (conex.State != System.Data.ConnectionState.Open)
                {
                    conex.Open();
                }
                SqlDataReader reader = query.ExecuteReader();

                if (reader.HasRows)
                {
                    
                    while(reader.Read()) {

                        check = new TOCheck();
                        check.ID = Int32.Parse(reader.GetString(0));
                        check.CheckTime = reader.GetDateTime(1);
                        check.CheckType = reader.GetString(2);
                        list.Add(check);

                    }
                } else
                {
                    return null;
                }

                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }

                return list;
            } catch(Exception e)
            {
                MessageBox.Show("Error de conexion");
                GetChecks(id, inicio, fin);
            }
            return null;
        }

    }
}
