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

                SqlCommand query = new SqlCommand("INSERT INTO Horario (CodHorario, HoraInicio, HoraFin, CantHorasOrdinarias, CantHorasExtras, CantTotalHoras) VALUES (@CodHorario, @HoraInicio, @HoraFin, @CantHorasOrdinarias, @CantHorasExtras, @CantTotalHoras)", conex);
                query.Parameters.AddWithValue("@CodHorario", newSchedule.Code);
                query.Parameters.AddWithValue("@HoraInicio", newSchedule.InitialHour);
                query.Parameters.AddWithValue("@HoraFin", newSchedule.finalHour);
                query.Parameters.AddWithValue("@CantHorasOrdinarias", newSchedule.OrdinaryHours);
                query.Parameters.AddWithValue("@CantHorasExtras", newSchedule.ExtraHours);
                query.Parameters.AddWithValue("@CantTotalHoras", newSchedule.TotalHours);
                
                query.ExecuteNonQuery();

                query = new SqlCommand("INSERT INTO Depart_Tiene_Horario (CodDepartamento, CodHorario) VALUES (@CodDepartamento, @CodHorario);", conex);

                query.Parameters.AddWithValue("@CodDepartamento", newSchedule.depart.Code);
                query.Parameters.AddWithValue("@CodHorario", newSchedule.Code);
                query.ExecuteNonQuery();


                query = new SqlCommand("INSERT INTO Horario_Posee_Descanso (CodDescanso, CodHorario) VALUES (@CodDescanso, @CodHorario);", conex);

                foreach (var item in newSchedule.RestList)
                {
                    query.Parameters.AddWithValue("@CodDescanso", item.Code);
                    query.Parameters.AddWithValue("@CodHorario", newSchedule.Code);
                    query.ExecuteNonQuery();
                }

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

                SqlCommand query = new SqlCommand("DELETE FROM Horario_Posee_Descanso WHERE CodHorario = @CodHorario;", conex);
                query.Parameters.AddWithValue("@CodHorario", scheduleCode);
                query.ExecuteNonQuery();

                query = new SqlCommand("DELETE FROM Horario WHERE CodHorario = @CodHorario", conex);
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

            SqlCommand query = new SqlCommand("UPDATE Horario SET HoraInicio = @HoraInicio, HoraFin = @HoraFin, CantHorasOrdinarias = @CantHorasOrdinarias, CantHorasExtra = @CantHorasExtra, CantTotalHoras = @CantTotalHoras WHERE CodHorario = @CodHorario;", conex);

            query.Parameters.AddWithValue("@CodHorario", schedule.Code);
            query.Parameters.AddWithValue("@HoraInicio", schedule.InitialHour);
            query.Parameters.AddWithValue("@HoraFin", schedule.finalHour);
            query.Parameters.AddWithValue("@CantHorasOrdinarias", schedule.OrdinaryHours);
            query.Parameters.AddWithValue("@CantHorasExtras", schedule.ExtraHours);
            query.Parameters.AddWithValue("@CantTotalHoras", schedule.TotalHours);

            query.ExecuteNonQuery();

            query = new SqlCommand("DELETE FROM Horario_Posee_Descanso WHERE CodHorario = @CodHorario;", conex);

            query.Parameters.AddWithValue("@CodHorario", schedule.Code);

            query.ExecuteNonQuery();

            query = new SqlCommand("INSERT INTO Horario_Posee_Descanso (CodHorario, CodDescanso) VALUES (@CodHorario, @CodDescanso);", conex);

            foreach (var item in schedule.RestList)
            {
                query.Parameters.AddWithValue("@CodHorario", schedule.Code);
                query.Parameters.AddWithValue("@CodDescanso", item.Code);
                query.ExecuteNonQuery();
            }

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

            TOSchedule foundSchedule = new TOSchedule();

            SqlCommand query = new SqlCommand("SELECT * FROM Horario h JOIN Horario_Posee_Descanso hd ON h.CodHorario = hd.CodHorario JOIN Descanso d ON hd.CodDescanso = d.CodDescanso WHERE h.CodHorario = @CodHorario;", conex);
            query.Parameters.AddWithValue("@CodHorario", scheduleCode);

            SqlDataReader reader = query.ExecuteReader();

            List<TORest> rests = new List<TORest>();

            if (reader.HasRows)
            {

                foundSchedule.Code = reader.GetString(0);

                String iniHour = reader.GetTimeSpan(1).ToString();

                String[] iniArray = iniHour.Split(':');
                int iniHourH = int.Parse(iniArray.GetValue(0).ToString());
                int iniHourM = int.Parse(iniArray.GetValue(1).ToString());

                foundSchedule.InitialHour = new DateTime(2016, 10, 18, iniHourH, iniHourM, 0);

                String finHour = reader.GetTimeSpan(2).ToString();

                String[] finArray = finHour.Split(':');
                int finHourH = int.Parse(iniArray.GetValue(0).ToString());
                int finHourM = int.Parse(iniArray.GetValue(1).ToString());

                foundSchedule.finalHour = new DateTime(2016, 10, 18, finHourH, finHourM, 0);

                foundSchedule.OrdinaryHours = reader.GetInt32(3);
                foundSchedule.ExtraHours = reader.GetInt32(4);
                foundSchedule.TotalHours = reader.GetInt32(5);

                while (reader.Read())
                {
                    TORest rest = new TORest();
                    rest.Code = reader.GetInt32(7);
                    rest.Minutes = reader.GetInt32(9);
                    rests.Add(rest);
                }

            }

            foundSchedule.RestList = rests;

            query = new SqlCommand("SELECT * FROM depart_tiene_horario dth JOIN departamento d ON dth.CodDepartamento = d.CodDepartamento WHERE dth.CodHorario = @CodHorario;", conex);
            query.Parameters.AddWithValue("@CodHorario", scheduleCode);

            reader = query.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int dCode = reader.GetInt32(0);
                    String dName = reader.GetString(2);
                    TODepartment td = new TODepartment();
                    td.Code = dCode;
                    td.Name = dName;
                    foundSchedule.depart = td;
                }
            }

            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }

            return foundSchedule;
        }

        public List<TOSchedule> GetAllSchedules()
        {
            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }

            List<TOSchedule> schedules = new List<TOSchedule>();
            SqlCommand query = new SqlCommand("SELECT * FROM Horario;", conex);

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
                    int finHourH = int.Parse(iniArray.GetValue(0).ToString());
                    int finHourM = int.Parse(iniArray.GetValue(1).ToString());

                    s.finalHour = new DateTime(2016, 10, 18, finHourH, finHourM, 0);

                    s.OrdinaryHours = reader.GetInt32(3);
                    s.ExtraHours = reader.GetInt32(4);
                    s.TotalHours = reader.GetInt32(5);

                    schedules.Add(s);
                }
                
            }

            foreach (var item in schedules)
            {
                SqlConnection conex2 = new SqlConnection(DataAccess.Properties.Settings.Default.StringConex);
                conex2.Open();

                String currentScheduleCode = item.Code;

                query = new SqlCommand("SELECT * FROM depart_tiene_horario dth JOIN departamento d ON dth.CodDepartamento = d.CodDepartamento WHERE dth.CodHorario = @CodHorario;", conex2);
                query.Parameters.AddWithValue("@CodHorario", currentScheduleCode);

                reader = query.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int dCode = reader.GetInt32(0);
                        String dName = reader.GetString(2);
                        TODepartment td = new TODepartment();
                        td.Code = dCode;
                        td.Name = dName;
                        item.depart = td;
                }
            }
                SqlConnection conex3 = new SqlConnection(DataAccess.Properties.Settings.Default.StringConex);
                conex3.Open();

                List<TORest> currentScheduleRests = new List<TORest>();

                SqlCommand query2 = new SqlCommand("SELECT d.* FROM Horario_Posee_Descanso hd JOIN Descanso d ON hd.CodDescanso = d.CodDescanso WHERE hd.CodHorario = @CodHorario;", conex3);
                query2.Parameters.AddWithValue("@CodHorario", currentScheduleCode);
                
                    SqlDataReader reader2 = query2.ExecuteReader();
                

                if (reader2.HasRows)
                {
                    while (reader2.Read())
                    {
                        TORest rest = new TORest();
                        rest.Code = reader2.GetInt32(0);
                        rest.Minutes = reader2.GetInt32(1);
                        item.RestList.Add(rest);
                    }

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
