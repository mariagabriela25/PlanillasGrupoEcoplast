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
    public class DAOWorkDay
    {
        SqlConnection conex = new SqlConnection(DataAccess.Properties.Settings.Default.StringConexAnviz);

        public Boolean AddWorkDayDetail(TOWorkDayDetail workday)
        {
            try
            {

                SqlCommand query = new SqlCommand("INSERT INTO DetalleDiaLaborado VALUES (@CodeEmpl, @OrdinaryHour, @TotalHours, @Date, @Note, @ID, @State, @WeekCode)", conex);
                query.Parameters.AddWithValue("@CodeEmpl", workday.CodeEmployee);
                query.Parameters.AddWithValue("@OrdinaryHour", workday.OrdinaryHours);
                query.Parameters.AddWithValue("@TotalHours", workday.TotalHours);
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

        public Boolean UpdateWorkDayDetail(TOWorkDayDetail workday, int dbCode)
        {
            try
            {
                SqlCommand query = new SqlCommand("UPDATE DetalleDiaLaborado SET TotalHorasOrdinarias = @OrdinaryHour, TotalHoras = @TotalHours, Nota = @Note WHERE CodDia = @DayCode;", conex);
                query.Parameters.AddWithValue("@OrdinaryHour", workday.OrdinaryHours);
                query.Parameters.AddWithValue("@TotalHours", workday.TotalHours);
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

    }
}
