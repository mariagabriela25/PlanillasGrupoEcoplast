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
    /// <summary>
    /// Class DAOAnviz. Manages information about Anviz-database, and connections with this database
    /// </summary>
    public class DAOAnviz
    {
        /// <summary>
        /// The conection with Anviz-database
        /// </summary>
        SqlConnection conex = new SqlConnection(DataAccess.Properties.Settings.Default.StringConexAnviz);

        /// <summary>
        /// Gets the checks from anviz-database
        /// </summary>
        /// <param name="id">The identifier from the employee</param>
        /// <param name="inicio">The start of the interval</param>
        /// <param name="fin">The end of the interval</param>
        /// <returns>a list with checks</returns>
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

                    while (reader.Read())
                    {

                        check = new TOCheck();
                        check.ID = Int32.Parse(reader.GetString(0));
                        check.CheckTime = reader.GetDateTime(1);
                        check.CheckType = reader.GetString(2);
                        list.Add(check);

                    }
                }
                else
                {
                    return null;
                }

                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }

                return list;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error de conexion");
                GetChecks(id, inicio, fin);
            }
            return null;
        }

        /// <summary>
        /// Gets the checks with rests.
        /// </summary>
        /// <param name="id">The identifier from the employee</param>
        /// <param name="inicio">The start of the interval.</param>
        /// <param name="fin">The end of the interval.</param>
        /// <returns>a list of checks with their rests</returns>
        public List<TOCheck> GetChecksWithRests(int id, DateTime inicio, DateTime fin)
        {
            try
            {
                List<TOCheck> list = new List<TOCheck>();
                TOCheck check;

                SqlCommand query = new SqlCommand("SELECT Userid, CheckTime, CheckType FROM Checkinout " +
                    "WHERE CheckTime Between @Inicio AND @Fin AND Userid = @ID ORDER BY CheckTime", conex);

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

                    while (reader.Read())
                    {

                        check = new TOCheck();
                        check.ID = Int32.Parse(reader.GetString(0));
                        check.CheckTime = reader.GetDateTime(1);
                        check.CheckType = reader.GetString(2);
                        list.Add(check);

                    }
                }
                else
                {
                    return null;
                }

                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }

                return list;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error de conexion");
                GetChecksWithRests(id, inicio, fin);
            }
            return null;
        }

        /// <summary>
        /// Adds the day's detail.
        /// </summary>
        /// <param name="daydetail">The day detail to be added.</param>
        /// <returns>true if was added, false if not</returns>
        public Boolean AddDayDetail(TOWorkDayDetail daydetail)
        {
            try
            {

                SqlCommand query = new SqlCommand("INSERT INTO DetalleDiaLaborado VALUES " +
                "(@CodEmpl, @TotalOrdinary, @Total, @Date, @Note, @ID, @State, @CodWeek)", conex);
                query.Parameters.AddWithValue("@CodEmpl", daydetail.CodeEmployee);
                query.Parameters.AddWithValue("@TotalOrdinary", daydetail.OrdinaryHours);
                query.Parameters.AddWithValue("@Total", daydetail.TotalHours);
                query.Parameters.AddWithValue("@Date", daydetail.Date);
                query.Parameters.AddWithValue("@Note", daydetail.Note == null ? System.Data.SqlTypes.SqlString.Null : daydetail.Note);
                query.Parameters.AddWithValue("@ID", daydetail.ID);
                query.Parameters.AddWithValue("@State", daydetail.State);
                query.Parameters.AddWithValue("@CodWeek", daydetail.WeekCode);



                if (conex.State != System.Data.ConnectionState.Open)
                {
                    conex.Open();
                }

                query.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión");
            }
            finally
            {
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
            }

            return true;
        }
        /// <summary>
        /// Gets the Checks by the date.
        /// </summary>
        /// <param name="date">The date in which to look</param>
        /// <param name="type">The type of checks</param>
        /// <returns>System.Decimal the total hours worked in that week</returns>
        public decimal checksbyDate(DateTime date, string type)
        {
            DateTime start = date + new TimeSpan(0, 0, 0);
            DateTime end = date + new TimeSpan(23, 59, 59);
            SqlCommand query = new SqlCommand();

            try
            {
                if (type == "I")
                {
                    query = new SqlCommand("  SELECT SUM(TOTALHORAS) FROM DetalleDiaLaborado WHERE  DetalleDiaLaborado.Fecha = @date", conex);

                }
                else
                {
                    query = new SqlCommand("select count(*)  from checkinout where  CheckTime between @start and @end and checktype = 'o'", conex);
                }
                query.Parameters.AddWithValue("@date", date);

                query.Parameters.AddWithValue("@start", start);
                query.Parameters.AddWithValue("@end", end);


                if (conex.State != System.Data.ConnectionState.Open)
                {
                    conex.Open();
                }
                SqlDataReader reader = query.ExecuteReader();
                decimal number = 0;
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {

                        number = reader.GetDecimal(0);

                    }
                }
                else
                {
                    return number;
                }

                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }

                return number;
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());

            }
            return 0;


        }

    }

}
