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
        SqlConnection conex = new SqlConnection("Data Source=.;Initial Catalog=BaseEcoplast;Integrated Security=true");

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

                query = new SqlCommand("INSERT INTO Horario_Posee_Descanso (CodHorario, CodDescanso) VALUES (@CodHorario, @CodDescanso);", conex);

                foreach (var item in newSchedule.RestList)
                {
                    query.Parameters.AddWithValue("@CodHorario", newSchedule.Code);
                    query.Parameters.AddWithValue("@CodDescanso", item.Code);
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
                foundSchedule.InitialHour = reader.GetDateTime(1);
                foundSchedule.finalHour = reader.GetDateTime(2);
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

            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }

            return foundSchedule;
        }

        public List<TOSchedule> GetAllSchedules()
        {
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
                    s.InitialHour = reader.GetDateTime(1);
                    s.finalHour = reader.GetDateTime(2);
                    s.OrdinaryHours = reader.GetInt32(3);
                    s.ExtraHours = reader.GetInt32(4);
                    s.TotalHours = reader.GetInt32(5);

                    schedules.Add(s);
                }
            }

            foreach (var item in schedules)
            {
                String currentScheduleCode = item.Code;
                List<TORest> currentScheduleRests = new List<TORest>();

                query = new SqlCommand("SELECT * FROM Horario_Posee_Descanso hd JOIN Descanso d ON hd.CodDescanso = d.CodDescanso WHERE hd.CodHorario = @CodHorario;", conex);
                query.Parameters.AddWithValue("@CodHorario", currentScheduleCode);

                reader = query.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        TORest rest = new TORest();
                        rest.Code = reader.GetInt32(7);
                        rest.Minutes = reader.GetInt32(9);
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
