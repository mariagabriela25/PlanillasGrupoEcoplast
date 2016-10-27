using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObjects;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class DAOSchedule
    {
        SqlConnection conex = new SqlConnection(DataAccess.Properties.Settings.Default.StringConex);

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
                query.Parameters.AddWithValue("@CantHorasOrdinarias", newSchedule.OrdinaryHours);
                
                query.ExecuteNonQuery();

                query = new SqlCommand("INSERT INTO Depart_Tiene_Horario (CodDepartamento, CodHorario) VALUES (@CodDepartamento, @CodHorario);", conex);

                query.Parameters.AddWithValue("@CodDepartamento", newSchedule.depart.Code);
                query.Parameters.AddWithValue("@CodHorario", newSchedule.Code);
                query.ExecuteNonQuery();

                if (conex.State != ConnectionState.Closed)
                {
                    conex.Close();
                }

                return true;
        }
            catch (Exception)
            {
                return false;
            }
        }

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

                if (conex.State != ConnectionState.Closed)
                {
                    conex.Close();
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void ModifySchedule(TOSchedule schedule)
        {
            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }

            SqlCommand query = new SqlCommand("UPDATE Horario SET HoraInicio = @HoraInicio, HoraFin = @HoraFin, CantHorasOrdinarias = @CantHorasOrdinarias WHERE CodHorario = @CodHorario;", conex);

            query.Parameters.AddWithValue("@CodHorario", schedule.Code);
            query.Parameters.AddWithValue("@HoraInicio", schedule.InitialHour);
            query.Parameters.AddWithValue("@HoraFin", schedule.finalHour);
            query.Parameters.AddWithValue("@CantHorasOrdinarias", schedule.OrdinaryHours);

            query.ExecuteNonQuery();

            query = new SqlCommand("DELETE FROM Depart_Tiene_Horario WHERE CodHorario = @CodHorario;", conex);
            query.Parameters.AddWithValue("@CodHorario", schedule.Code);
            query.ExecuteNonQuery();

            query = new SqlCommand("INSERT INTO Depart_Tiene_Horario (CodDepartamento, CodHorario) VALUES (@CodDepartamento, @CodHorario);", conex);
            query.Parameters.AddWithValue("@CodDepartamento", schedule.depart.Code);
            query.Parameters.AddWithValue("@CodHorario", schedule.Code);
            query.ExecuteNonQuery();

            if (conex.State != ConnectionState.Closed)
                {
                    conex.Close();
                }
            
        }

        public TOSchedule GetSchedule(String scheduleCode)
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

            TOSchedule s = new TOSchedule();

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

                    s.OrdinaryHours = reader.GetInt32(3);

                    TODepartment td = new TODepartment();
                    td.Code = reader.GetInt32(4);
                    td.Name = reader.GetString(5);
                    s.depart = td;

                }
            }                

               

            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }
            return s;
        }

        public List<TOSchedule> GetAllSchedules()
        {
      
            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }

            List<TOSchedule> schedules = new List<TOSchedule>();
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

                    s.OrdinaryHours = reader.GetInt32(3);

                    TODepartment td = new TODepartment();
                    td.Code = reader.GetInt32(4);
                    td.Name = reader.GetString(5);
                    s.depart = td;
                    schedules.Add(s);

                }
            }

            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }

            return schedules;
        }
        
        public List<TOSchedule> GetSchedulesDep(int depCode)
        {
            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }

            List<TOSchedule> schedules = new List<TOSchedule>();
            SqlCommand query = new SqlCommand("SELECT H.*, D.CodDepartamento, D.NombreDepartamento, DS.* " +
                " FROM Horario H JOIN Depart_Tiene_Horario HD ON H.CodHorario = HD.CodHorario JOIN Departamento D " +
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

                    s.OrdinaryHours = reader.GetInt32(3);

                    TODepartment td = new TODepartment();
                    td.Code = reader.GetInt32(4);
                    td.Name = reader.GetString(5);
                    s.depart = td;
                    schedules.Add(s);
                }

                }

            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }

            return schedules;
        }

    }
}
