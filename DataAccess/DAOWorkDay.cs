
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObjects;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataAccess
{
    /// <summary>
    /// Class DAOWorkDay.
    /// </summary>
    public class DAOWorkDay
    {
        /// <summary>
        /// The conex
        /// </summary>
        SqlConnection conex = new SqlConnection(DataAccess.Properties.Settings.Default.StringConexAnviz);

        /// <summary>
        /// Adds the work day detail.
        /// </summary>
        /// <param name="workday">The workday.</param>
        /// <returns>Boolean.</returns>
        public Boolean AddWorkDayDetail(TOWorkDayDetail workday)
        {
            try
            {

                SqlCommand query = new SqlCommand("INSERT INTO DetalleDiaLaborado VALUES (@CodeEmpl, @OrdinaryHour, @TotalHours, @Date, @Note, @ID, @State, @WeekCode)", conex);
                query.Parameters.AddWithValue("@CodeEmpl", workday.CodeEmployee);
                query.Parameters.AddWithValue("@OrdinaryHour", (Decimal)workday.OrdinaryHours);
                query.Parameters.AddWithValue("@TotalHours", (Decimal)workday.TotalHours);
                query.Parameters.AddWithValue("@Date", workday.Date);
                query.Parameters.AddWithValue("@Note", workday.Note == null ? System.Data.SqlTypes.SqlString.Null : workday.Note);
                query.Parameters.AddWithValue("@ID", 1);
                query.Parameters.AddWithValue("@State", workday.State == true ? 1 : 0);
                query.Parameters.AddWithValue("@WeekCode", workday.WeekCode);

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
        /// Updates the work day detail.
        /// </summary>
        /// <param name="workday">The workday</param>
        /// <param name="dbCode">The database code</param>
        /// <returns>Boolean true if was updated, false if not</returns>
        public Boolean UpdateWorkDayDetail(TOWorkDayDetail workday, int dbCode)
        {
            try
            {
                SqlCommand query = new SqlCommand("UPDATE DetalleDiaLaborado SET TotalHorasOrdinarias = @OrdinaryHour, TotalHoras = @TotalHours, Nota = @Note WHERE CodDia = @DayCode;", conex);
                query.Parameters.AddWithValue("@OrdinaryHour", (Decimal)workday.OrdinaryHours);
                query.Parameters.AddWithValue("@TotalHours", (Decimal)workday.TotalHours);
                query.Parameters.AddWithValue("@Note", workday.Note == null ? System.Data.SqlTypes.SqlString.Null : workday.Note);
                query.Parameters.AddWithValue("@DayCode", dbCode);

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
        /// Gets the work day.
        /// </summary>
        /// <param name="tow">The transfer object </param>
        /// <returns>TOWorkDayDetail the object with new information</returns>
        public TOWorkDayDetail getWorkDay(TOWorkDayDetail tow)
        {
            TOWorkDayDetail workDay = new TOWorkDayDetail();

            try
            {
                SqlCommand query = new SqlCommand("select SUM(TotalHoras) from DetalleDiaLaborado where codEmpleado = @CodeEmployee and codSemana = @CodeWeek", conex);
                query.Parameters.AddWithValue("@CodeEmployee", tow.CodeEmployee);
                query.Parameters.AddWithValue("@CodeWeek", tow.WeekCode);

                if (conex.State != System.Data.ConnectionState.Open)
                {
                    conex.Open();
                }

                SqlDataReader reader = query.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    workDay.TotalHours = (Double)reader.GetDecimal(0);
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

            return workDay;
        }

        /// <summary>
        /// Gets the worked weeks.
        /// </summary>
        /// <param name="codEmpl">The cod of the employee</param>
        /// <param name="codWeek">The cod week.</param>
        /// <returns>a list with day details</returns>
        public List<TOWorkDayDetail> getWorkedWeeks(int codEmpl, int codWeek)
        {
            List<TOWorkDayDetail> list = new List<TOWorkDayDetail>();
            try
            {

                SqlCommand query = new SqlCommand("select d.CodDia, d.Fecha, d.TotalHoras, d.Nota from DetalleDiaLaborado as d where CodEmpleado = @CodeEmployee and CodSemana = @CodeWeek ORDER BY d.Fecha", conex);
                query.Parameters.AddWithValue("@CodeEmployee", codEmpl);
                query.Parameters.AddWithValue("@CodeWeek", codWeek);

                if (conex.State != System.Data.ConnectionState.Open)
                {
                    conex.Open();
                }

                SqlDataReader reader = query.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        TOWorkDayDetail e = new TOWorkDayDetail();

                        e.ID = reader.GetInt32(0);

                        DateTime datevalue = reader.GetDateTime(1);
                        int day = (Int32)datevalue.DayOfWeek;

                        e.Date = datevalue;
                        e.Day = day;
                        e.TotalHours = (Double)reader.GetDecimal(2);

                    try
                    {
                        e.Note = reader.GetString(3);
                    }
                    catch (Exception) {}
                       
                        list.Add(e);
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
        /// Gets the employees calculated week.
        /// </summary>
        /// <param name="week">The week.</param>
        /// <returns>a list with calcutaded weeks</returns>
        public List<int> getEmployeesCalculatedWeek(int week)
        {
            List<int> returnList = new List<int>();
            try
            {
                SqlCommand query = new SqlCommand("select CodEmpleado from detalledialaborado where CodSemana = @WeekCode group by CodEmpleado;", conex);
                query.Parameters.AddWithValue("@WeekCode", week);

                if (conex.State != System.Data.ConnectionState.Open)
                {
                    conex.Open();
                }

                SqlDataReader reader = query.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int e = reader.GetInt32(0);
                        returnList.Add(e);
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
            return returnList;
        }

        /// <summary>
        /// Calculateds the departments.
        /// </summary>
        /// <param name="week">The week.</param>
        /// <returns>the week of the calculated departments</returns>
        public int CalculatedDepartments(int week)
        {
            int result = 0;
            try
            {
                SqlCommand query = new SqlCommand("select e.CodDepartamento from Empleado as e Join DetalleDiaLaborado as d on e.CodEmpleado = d.CodEmpleado where CodSemana = @Week group by e.CodDepartamento;", conex);
                query.Parameters.AddWithValue("@Week", week);

                if (conex.State != System.Data.ConnectionState.Open)
                {
                    conex.Open();
                }

                SqlDataReader reader = query.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        result += 1;
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
            return result;
        }

        /// <summary>
        /// Determines whether [is department registered] [the specified d code].
        /// </summary>
        /// <param name="dCode">The department's code.</param>
        /// <param name="week">The current week</param>
        /// <returns>Boolean true if the department was registred, false if not</returns>
        public Boolean isDepartmentRegistered(int dCode, int week)
        {
            Boolean result = false;
            try
            {
                SqlCommand query = new SqlCommand("select e.CodDepartamento from Empleado as e Join DetalleDiaLaborado as d on e.CodEmpleado = d.CodEmpleado where CodSemana = @Week and e.CodDepartamento = @DepartCode;", conex);
                query.Parameters.AddWithValue("@Week", week);
                query.Parameters.AddWithValue("@DepartCode", dCode);

                if (conex.State != System.Data.ConnectionState.Open)
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
