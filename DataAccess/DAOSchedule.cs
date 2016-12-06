using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObjects;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DataAccess
{
    /// <summary>
    /// Class DAOSchedule. Manages information from Schedules, and connections with the database 
    /// </summary>
    public class DAOSchedule
    {
        /// <summary>
        /// The connection with the database
        /// </summary>
        SqlConnection conex = new SqlConnection(DataAccess.Properties.Settings.Default.StringConexAnviz);

        /// <summary>
        /// Adds a new schedule.
        /// </summary>
        /// <param name="newSchedule">The new schedule to be added</param>
        /// <returns>Boolean true if the schedule was successfully added, false if not</returns>
        public Boolean AddSchedule(TOSchedule newSchedule)
        {
            try
            {
                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }

                SqlCommand query = new SqlCommand("INSERT INTO Horario (CodHorario, HoraInicio, HoraFin, CantHorasOrdinarias) VALUES (@CodHorario, @HoraInicio, @HoraFin, @CantHorasOrdinarias)", conex);
                query.Parameters.AddWithValue("@CodHorario", newSchedule.Code);
                query.Parameters.AddWithValue("@HoraInicio", newSchedule.InitialHour);
                query.Parameters.AddWithValue("@HoraFin", newSchedule.finalHour);
                query.Parameters.AddWithValue("@CantHorasOrdinarias", (Decimal)newSchedule.OrdinaryHours);

                query.ExecuteNonQuery();

                query = new SqlCommand("INSERT INTO Depart_Tiene_Horario (CodDepartamento, CodHorario) VALUES (@CodDepartamento, @CodHorario);", conex);

                query.Parameters.AddWithValue("@CodDepartamento", newSchedule.depart.Code);
                query.Parameters.AddWithValue("@CodHorario", newSchedule.Code);
                query.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión");
                return false;
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
        /// Deletes one schedule.
        /// </summary>
        /// <param name="scheduleCode">The schedule's code</param>
        /// <returns>Boolean true if the schedule was removed, false if not</returns>
        public Boolean DeleteSchedule(String scheduleCode)
        {
            try
            {
                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }

                SqlCommand query = new SqlCommand("DELETE FROM Horario WHERE CodHorario = @CodHorario", conex);
                query.Parameters.AddWithValue("@CodHorario", scheduleCode);
                query.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión");
                return false;
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
        /// Modifies one schedule.
        /// </summary>
        /// <param name="schedule">The schedule to be modified</param>
        public void ModifySchedule(TOSchedule schedule)
        {
            try
            {

                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }

                SqlCommand query = new SqlCommand("UPDATE Horario SET HoraInicio = @HoraInicio, HoraFin = @HoraFin, CantHorasOrdinarias = @CantHorasOrdinarias WHERE CodHorario = @CodHorario;", conex);

                query.Parameters.AddWithValue("@CodHorario", schedule.Code);
                query.Parameters.AddWithValue("@HoraInicio", schedule.InitialHour);
                query.Parameters.AddWithValue("@HoraFin", schedule.finalHour);
                query.Parameters.AddWithValue("@CantHorasOrdinarias", (Decimal)schedule.OrdinaryHours);

                query.ExecuteNonQuery();

                query = new SqlCommand("DELETE FROM Depart_Tiene_Horario WHERE CodHorario = @CodHorario;", conex);
                query.Parameters.AddWithValue("@CodHorario", schedule.Code);
                query.ExecuteNonQuery();

                query = new SqlCommand("INSERT INTO Depart_Tiene_Horario (CodDepartamento, CodHorario) VALUES (@CodDepartamento, @CodHorario);", conex);
                query.Parameters.AddWithValue("@CodDepartamento", schedule.depart.Code);
                query.Parameters.AddWithValue("@CodHorario", schedule.Code);
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

        }

        /// <summary>
        /// Gets the schedule by its code
        /// </summary>
        /// <param name="scheduleCode">The schedule code</param>
        /// <returns>TOSchedule the schedule found by code</returns>
        public TOSchedule GetSchedule(String scheduleCode)
        {
            TOSchedule s = new TOSchedule();

            try
            {
                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }

                SqlCommand query = new SqlCommand("SELECT H.*, D.CodDepartamento, D.NombreDepartamento" +
                    " FROM Horario H JOIN Depart_Tiene_Horario HD ON H.CodHorario = HD.CodHorario JOIN Departamento D" +
                    " ON HD.CodDepartamento = D.CodDepartamento WHERE H.CodHorario = @CodHorario;", conex);

                query.Parameters.AddWithValue("@CodHorario", scheduleCode);

                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }

                SqlDataReader reader = query.ExecuteReader();



                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        s.Code = reader.GetString(0);

                        String iniHour = reader.GetTimeSpan(1).ToString();
                        String[] iniArray = iniHour.Split(':');
                        int iniHourH = int.Parse(iniArray.GetValue(0).ToString());
                        int iniHourM = int.Parse(iniArray.GetValue(1).ToString());
                        s.InitialHour = new DateTime(2016, 10, 18, iniHourH, iniHourM, 0);

                        String finHour = reader.GetTimeSpan(2).ToString();
                        String[] finArray = finHour.Split(':');
                        int finHourH = int.Parse(finArray.GetValue(0).ToString());
                        int finHourM = int.Parse(finArray.GetValue(1).ToString());
                        s.finalHour = new DateTime(2016, 10, 18, finHourH, finHourM, 0);

                        s.OrdinaryHours = (Double)reader.GetDecimal(3);

                        TODepartment td = new TODepartment();
                        td.Code = reader.GetInt32(4);
                        td.Name = reader.GetString(5);
                        s.depart = td;

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
            return s;
        }

        /// <summary>
        /// Gets all schedules.
        /// </summary>
        /// <returns>List<TOSchedule> a list for schedules</returns>
        public List<TOSchedule> GetAllSchedules()
        {
            List<TOSchedule> schedules = new List<TOSchedule>();

            try
            {

                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }


                SqlCommand query = new SqlCommand("SELECT H.*, D.CodDepartamento, D.NombreDepartamento" +
                    " FROM Horario H JOIN Depart_Tiene_Horario HD ON H.CodHorario = HD.CodHorario JOIN Departamento D" +
                    " ON HD.CodDepartamento = D.CodDepartamento ORDER BY D.NombreDepartamento;", conex);

                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }

                SqlDataReader reader = query.ExecuteReader();

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        TOSchedule s = new TOSchedule();
                        s.Code = reader.GetString(0);

                        String iniHour = reader.GetTimeSpan(1).ToString();
                        String[] iniArray = iniHour.Split(':');
                        int iniHourH = int.Parse(iniArray.GetValue(0).ToString());
                        int iniHourM = int.Parse(iniArray.GetValue(1).ToString());
                        s.InitialHour = new DateTime(2016, 10, 18, iniHourH, iniHourM, 0);

                        String finHour = reader.GetTimeSpan(2).ToString();
                        String[] finArray = finHour.Split(':');
                        int finHourH = int.Parse(finArray.GetValue(0).ToString());
                        int finHourM = int.Parse(finArray.GetValue(1).ToString());
                        s.finalHour = new DateTime(2016, 10, 18, finHourH, finHourM, 0);

                        s.OrdinaryHours = (Double)reader.GetDecimal(3);

                        TODepartment td = new TODepartment();
                        td.Code = reader.GetInt32(4);
                        td.Name = reader.GetString(5);
                        s.depart = td;
                        schedules.Add(s);

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

            return schedules;
        }

        /// <summary>
        /// Gets the schedule's department.
        /// </summary>
        /// <param name="depCode">The department code.</param>
        /// <returns>a list with schedules that belong to the selected department</returns>
        public List<TOSchedule> GetSchedulesDep(int depCode)
        {
            List<TOSchedule> schedules = new List<TOSchedule>();

            try
            {
                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }


                SqlCommand query = new SqlCommand("SELECT H.*, D.CodDepartamento, D.NombreDepartamento" +
                    " FROM Horario H JOIN Depart_Tiene_Horario HD ON H.CodHorario = HD.CodHorario" +
                    " JOIN Departamento D " +
                    "ON HD.CodDepartamento = D.CodDepartamento WHERE D.CodDepartamento = @departmentCode;", conex);

                query.Parameters.AddWithValue("@departmentCode", depCode);

                SqlDataReader reader = query.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        TOSchedule s = new TOSchedule();
                        s.Code = reader.GetString(0);

                        String iniHour = reader.GetTimeSpan(1).ToString();
                        String[] iniArray = iniHour.Split(':');
                        int iniHourH = int.Parse(iniArray.GetValue(0).ToString());
                        int iniHourM = int.Parse(iniArray.GetValue(1).ToString());
                        s.InitialHour = new DateTime(2016, 10, 18, iniHourH, iniHourM, 0);

                        String finHour = reader.GetTimeSpan(2).ToString();
                        String[] finArray = finHour.Split(':');
                        int finHourH = int.Parse(finArray.GetValue(0).ToString());
                        int finHourM = int.Parse(finArray.GetValue(1).ToString());
                        s.finalHour = new DateTime(2016, 10, 18, finHourH, finHourM, 0);

                        s.OrdinaryHours = (Double)reader.GetDecimal(3);

                        TODepartment td = new TODepartment();
                        td.Code = reader.GetInt32(4);
                        td.Name = reader.GetString(5);
                        s.depart = td;
                        schedules.Add(s);
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

            return schedules;
        }

    }
}
