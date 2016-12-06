
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using TransferObjects;
using System.Windows.Forms;

namespace DataAccess
{
    /// <summary>
    /// Class DAOWeekDetail. manages information about week's details, and the connection to the database
    /// </summary>
    public class DAOWeekDetail
    {
        /// <summary>
        /// The connection to the database
        /// </summary>
        SqlConnection conex = new SqlConnection(DataAccess.Properties.Settings.Default.StringConexAnviz);

        /// <summary>
        /// Saves the week's detail.
        /// </summary>
        /// <param name="twd">The week detail transfer object.</param>
        /// <returns>Boolean.</returns>
        public Boolean SaveWeekDetail(TOWorkWeekDetail twd)
        {
            try
            {

                SqlCommand query = new SqlCommand("INSERT INTO DetalleSemanaLaborada VALUES (@Ordinary, @Total, @Extra, @Employee, @Week, @Year)", conex);

                query.Parameters.AddWithValue("@Ordinary", twd.CCSSHours);
                query.Parameters.AddWithValue("@Total", twd.TotalHours);
                query.Parameters.AddWithValue("@Extra", twd.ExtraHours);
                query.Parameters.AddWithValue("@Employee", twd.EmployeeCode);
                query.Parameters.AddWithValue("@Week", twd.WeekNumber);
                query.Parameters.AddWithValue("@Year", twd.Year);

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
        /// Updates the week detail.
        /// </summary>
        /// <param name="twd">The week detail transfer object.</param>
        /// <returns>Boolean.</returns>
        public Boolean UpdateWeekDetail(TOWorkWeekDetail twd)
        {
            try
            {
                SqlCommand query = new SqlCommand("UPDATE DetalleSemanaLaborada SET HorasCCSS = @Ordinary, HorasTotales = @Total, HorasExtras = @Extra WHERE CodSemana = @WeekCode", conex);

                query.Parameters.AddWithValue("@Ordinary", twd.CCSSHours);
                query.Parameters.AddWithValue("@Total", twd.TotalHours);
                query.Parameters.AddWithValue("@Extra", twd.ExtraHours);
                query.Parameters.AddWithValue("@WeekCode", twd.Code);

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
        /// Gets the week per number.
        /// </summary>
        /// <param name="weekNumber">The week number.</param>
        /// <returns>List&lt;TOWorkWeekDetail&gt;.</returns>
        public List<TOWorkWeekDetail> getWeekPerNumber(int weekNumber)
        {
            List<TOWorkWeekDetail> list = new List<TOWorkWeekDetail>();

            try
            {
                SqlCommand query = new SqlCommand("select e.CodEmpleado, e.Nombre, e.Apellido, s.HorasCCSS, s.HorasTotales, s.HorasExtras, s.CodSemana from DetalleSemanaLaborada as s inner join Empleado as e on s.CodEmpleado = e.CodEmpleado where NumSemana = @WeekNumber", conex);
                query.Parameters.AddWithValue("@WeekNumber", weekNumber);

                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }

                SqlDataReader reader = query.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        TOWorkWeekDetail week = new TOWorkWeekDetail();
                        week.EmployeeCode = reader.GetInt32(0);
                        week.Name = reader.GetString(1) + " " + reader.GetString(2);
                        week.CCSSHours = (Double)reader.GetDecimal(3);
                        week.TotalHours = (Double)reader.GetDecimal(4);
                        week.ExtraHours = (Double)reader.GetDecimal(5);
                        week.Code = (int)reader.GetInt32(6);

                        list.Add(week);
                    }
                }

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
            return list;
        }

        /// <summary>
        /// Gets the week numbers.
        /// </summary>
        /// <returns>a list of week's numbers</returns>
        public List<int> getWeekNumbers()
        {
            List<int> weeks = new List<int>();
            try
            {
                SqlCommand query = new SqlCommand("select distinct NumSemana from DetalleSemanaLaborada", conex);

                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }

                SqlDataReader reader = query.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int week = reader.GetInt32(0);

                        weeks.Add(week);
                    }
                }

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
            return weeks;
        }

        /// <summary>
        /// Gets the week numbers.
        /// </summary>
        /// <param name="CodEmployee">The cod employee.</param>
        /// <returns>a list of week's numbers by employee</returns>
        public List<int> getWeekNumbers(int CodEmployee)
        {
            List<int> weeks = new List<int>();
            try
            {
                SqlCommand query = new SqlCommand("select NumSemana from DetalleSemanaLaborada where codEmpleado = @codEmployee", conex);
                query.Parameters.AddWithValue("@codEmployee", CodEmployee);


                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }

                SqlDataReader reader = query.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    int week = reader.GetInt32(0);

                    weeks.Add(week);
                }

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
            return weeks;
        }

        /// <summary>
        /// Determines whether [is week saved] [the specified week].
        /// </summary>
        /// <param name="week">The week selected</param>
        /// <returns>Boolean true if was saved, false if not</returns>
        public Boolean isWeekSaved(int week)
        {
            Boolean result = false;
            try
            {
                SqlCommand query = new SqlCommand("select NumSemana from DetalleSemanaLaborada where NumSemana = @Week;", conex);
                query.Parameters.AddWithValue("@Week", week);


                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }

                SqlDataReader reader = query.ExecuteReader();

                if (reader.HasRows)
                {
                    result = true;
                }

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
            return result;
        }
    }
}
