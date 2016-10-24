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

                SqlCommand query = new SqlCommand("INSERT INTO Horario (CodHorario, HoraInicio, HoraFin, CantHorasOrdinarias, CantTotalHoras, CantHorasExtraDiurnas, CantHorasExtraNocturnas) VALUES (@CodHorario, @HoraInicio, @HoraFin, @CantHorasOrdinarias, @CantTotalHoras, @CantHorasExtraDiurnas, @CantHorasExtraNocturnas)", conex);
                query.Parameters.AddWithValue("@CodHorario", newSchedule.Code);
                query.Parameters.AddWithValue("@HoraInicio", newSchedule.InitialHour);
                query.Parameters.AddWithValue("@HoraFin", newSchedule.finalHour);
                query.Parameters.AddWithValue("@CantHorasOrdinarias", newSchedule.OrdinaryHours);
                query.Parameters.AddWithValue("@CantTotalHoras", newSchedule.TotalHours);
                query.Parameters.AddWithValue("@CantHorasExtraDiurnas", newSchedule.ExtraDayHours);
                query.Parameters.AddWithValue("@CantHorasExtraNocturnas", newSchedule.ExtraNightHours);
                
                query.ExecuteNonQuery();

                query = new SqlCommand("INSERT INTO Depart_Tiene_Horario (CodDepartamento, CodHorario) VALUES (@CodDepartamento, @CodHorario);", conex);

                query.Parameters.AddWithValue("@CodDepartamento", newSchedule.depart.Code);
                query.Parameters.AddWithValue("@CodHorario", newSchedule.Code);
                query.ExecuteNonQuery();

                foreach (var item in newSchedule.RestList)
                {
                    query = new SqlCommand("INSERT INTO Horario_Posee_Descanso (CodDescanso, CodHorario) VALUES (@CodDescanso, @CodHorario);", conex);
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

            SqlCommand query = new SqlCommand("UPDATE Horario SET HoraInicio = @HoraInicio, HoraFin = @HoraFin, CantHorasOrdinarias = @CantHorasOrdinarias, CantTotalHoras = @CantTotalHoras, CantHorasExtraDiurnas = @CantHorasExtraDiurnas, CantHorasExtraNocturnas = @CantHorasExtraNocturnas WHERE CodHorario = @CodHorario;", conex);

            query.Parameters.AddWithValue("@CodHorario", schedule.Code);
            query.Parameters.AddWithValue("@HoraInicio", schedule.InitialHour);
            query.Parameters.AddWithValue("@HoraFin", schedule.finalHour);
            query.Parameters.AddWithValue("@CantHorasOrdinarias", schedule.OrdinaryHours);
            query.Parameters.AddWithValue("@CantTotalHoras", schedule.TotalHours);
            query.Parameters.AddWithValue("@CantHorasExtraDiurnas", schedule.ExtraDayHours);
            query.Parameters.AddWithValue("@CantHorasExtraNocturnas", schedule.ExtraNightHours);

            query.ExecuteNonQuery();

            query = new SqlCommand("DELETE FROM Depart_Tiene_Horario WHERE CodHorario = @CodHorario;", conex);
            query.Parameters.AddWithValue("@CodHorario", schedule.Code);
            query.ExecuteNonQuery();

            query = new SqlCommand("INSERT INTO Depart_Tiene_Horario (CodDepartamento, CodHorario) VALUES (@CodDepartamento, @CodHorario);", conex);
            query.Parameters.AddWithValue("@CodDepartamento", schedule.depart.Code);
            query.Parameters.AddWithValue("@CodHorario", schedule.Code);
            query.ExecuteNonQuery();

            query = new SqlCommand("DELETE FROM Horario_Posee_Descanso WHERE CodHorario = @CodHorario;", conex);
            query.Parameters.AddWithValue("@CodHorario", schedule.Code);
            query.ExecuteNonQuery();
            
            foreach (var item in schedule.RestList)
            {
                query = new SqlCommand("INSERT INTO Horario_Posee_Descanso (CodDescanso, CodHorario) VALUES (@CodDescanso, @CodHorario);", conex);
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
            int c = 0;
            TOSchedule sDone = new TOSchedule();

            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }
            
            SqlCommand query = new SqlCommand("SELECT H.*, D.CodDepartamento, D.NombreDepartamento, DS.*" +
                " FROM Horario H JOIN Depart_Tiene_Horario HD ON H.CodHorario = HD.CodHorario JOIN Departamento D" +
                " ON HD.CodDepartamento = D.CodDepartamento JOIN Horario_Posee_Descanso HDS ON H.CodHorario = HDS.CodHorario" +
  " JOIN Descanso DS ON HDS.CodDescanso = DS.CodDescanso WHERE H.CodHorario = @CodHorario;", conex);

            query.Parameters.AddWithValue("@CodHorario", scheduleCode);
            
            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }

            SqlDataReader reader = query.ExecuteReader();

            String oldScheduleCode = "";
            TOSchedule s = new TOSchedule();

            if (reader.HasRows)
            {
                
                while (reader.Read())
                {
                    String currentScheduleCode = reader.GetString(0);

                    s.Code = currentScheduleCode;

                    if (currentScheduleCode == oldScheduleCode)
                    {
                        TORest newRest = new TORest();
                        newRest.Code = reader.GetInt32(9);
                        newRest.Minutes = reader.GetInt32(10);
                        s.RestList.Add(newRest);
                    }
                    else if (s.RestList.Count > 0)
                    {
                        break;
                    }
                    if (c == 0)
                    {
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
                        s.TotalHours = reader.GetInt32(4);
                        s.ExtraDayHours = reader.GetInt32(5);
                        s.ExtraNightHours = reader.GetInt32(6);

                        TODepartment td = new TODepartment();
                        td.Code = reader.GetInt32(7);
                        td.Name = reader.GetString(8);
                        s.depart = td;

                        TORest rest = new TORest();
                        rest.Code = reader.GetInt32(9);
                        rest.Minutes = reader.GetInt32(10);
                        s.RestList.Add(rest);
                        c = 1;
                    }

                    oldScheduleCode = currentScheduleCode;

                }

            }

            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }

            sDone = s;
            sDone.Code = oldScheduleCode;
            return sDone;
        }

        public List<TOSchedule> GetAllSchedules()
        {
            int c = 0;
            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }

            List<TOSchedule> schedules = new List<TOSchedule>();
            SqlCommand query = new SqlCommand("SELECT H.*, D.CodDepartamento, D.NombreDepartamento, DS.*" + 
                " FROM Horario H JOIN Depart_Tiene_Horario HD ON H.CodHorario = HD.CodHorario JOIN Departamento D" +
                " ON HD.CodDepartamento = D.CodDepartamento JOIN Horario_Posee_Descanso HDS ON H.CodHorario = HDS.CodHorario" +
  " JOIN Descanso DS ON HDS.CodDescanso = DS.CodDescanso;", conex);

            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }

            SqlDataReader reader = query.ExecuteReader();

            if (reader.HasRows)
            {
                String oldScheduleCode = "";
                TOSchedule s = new TOSchedule();

                while (reader.Read())
                {
                    String currentScheduleCode = reader.GetString(0);

                    s.Code = currentScheduleCode;

                    if (currentScheduleCode == oldScheduleCode)
                    {
                        TORest newRest = new TORest();
                        newRest.Code = reader.GetInt32(9);
                        newRest.Minutes = reader.GetInt32(10);
                        s.RestList.Add(newRest);
                    }
                    else if (s.RestList.Count > 0)
                    {
                        TOSchedule sDone = s;
                        sDone.Code = oldScheduleCode;
                        schedules.Add(sDone);
                        s = new TOSchedule();
                        s.Code = currentScheduleCode;
                        s.RestList = new List<TORest>();

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
                        s.TotalHours = reader.GetInt32(4);
                        s.ExtraDayHours = reader.GetInt32(5);
                        s.ExtraNightHours = reader.GetInt32(6);

                        TODepartment td = new TODepartment();
                        td.Code = reader.GetInt32(7);
                        td.Name = reader.GetString(8);
                        s.depart = td;

                        TORest rest = new TORest();
                        rest.Code = reader.GetInt32(9);
                        rest.Minutes = reader.GetInt32(10);
                        s.RestList.Add(rest);
                    }
                    if (c == 0)
                    {
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
                        s.TotalHours = reader.GetInt32(4);
                        s.ExtraDayHours = reader.GetInt32(5);
                        s.ExtraNightHours = reader.GetInt32(6);

                        TODepartment td = new TODepartment();
                        td.Code = reader.GetInt32(7);
                        td.Name = reader.GetString(8);
                        s.depart = td;

                        TORest rest = new TORest();
                        rest.Code = reader.GetInt32(9);
                        rest.Minutes = reader.GetInt32(10);
                        s.RestList.Add(rest);
                        c = 1;
                    }
                       
                    oldScheduleCode = currentScheduleCode;
             
                }
                schedules.Add(s);

            }

            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }

            return schedules;
        }
        
        public List<TOSchedule> GetSchedulesDep(int depCode)
        {
            int c = 0;
            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }

            List<TOSchedule> schedules = new List<TOSchedule>();
            SqlCommand query = new SqlCommand("SELECT H.*, D.CodDepartamento, D.NombreDepartamento, DS.*" +
                " FROM Horario H JOIN Depart_Tiene_Horario HD ON H.CodHorario = HD.CodHorario JOIN Departamento D" +
                " ON HD.CodDepartamento = D.CodDepartamento JOIN Horario_Posee_Descanso HDS ON H.CodHorario = HDS.CodHorario" +
                " JOIN Descanso DS ON HDS.CodDescanso = DS.CodDescanso" +
                "WHERE D.CodDepartamento = @departmentCode;", conex);

            query.Parameters.AddWithValue("@departmentCode", depCode);

            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }

            SqlDataReader reader = query.ExecuteReader();

            if (reader.HasRows)
            {
                String oldScheduleCode = "";
                TOSchedule s = new TOSchedule();

                while (reader.Read())
                {
                    String currentScheduleCode = reader.GetString(0);

                    s.Code = currentScheduleCode;

                    if (currentScheduleCode == oldScheduleCode)
                    {
                        TORest newRest = new TORest();
                        newRest.Code = reader.GetInt32(9);
                        newRest.Minutes = reader.GetInt32(10);
                        s.RestList.Add(newRest);
                    }
                    else if (s.RestList.Count > 0)
                    {
                        TOSchedule sDone = s;
                        sDone.Code = oldScheduleCode;
                        schedules.Add(sDone);
                        s = new TOSchedule();
                        s.Code = currentScheduleCode;
                        s.RestList = new List<TORest>();

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
                        s.TotalHours = reader.GetInt32(4);
                        s.ExtraDayHours = reader.GetInt32(5);
                        s.ExtraNightHours = reader.GetInt32(6);

                        TODepartment td = new TODepartment();
                        td.Code = reader.GetInt32(7);
                        td.Name = reader.GetString(8);
                        s.depart = td;

                        TORest rest = new TORest();
                        rest.Code = reader.GetInt32(9);
                        rest.Minutes = reader.GetInt32(10);
                        s.RestList.Add(rest);
                    }
                    if (c == 0)
                    {
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
                        s.TotalHours = reader.GetInt32(4);
                        s.ExtraDayHours = reader.GetInt32(5);
                        s.ExtraNightHours = reader.GetInt32(6);

                        TODepartment td = new TODepartment();
                        td.Code = reader.GetInt32(7);
                        td.Name = reader.GetString(8);
                        s.depart = td;

                        TORest rest = new TORest();
                        rest.Code = reader.GetInt32(9);
                        rest.Minutes = reader.GetInt32(10);
                        s.RestList.Add(rest);
                        c = 1;
                    }

                    oldScheduleCode = currentScheduleCode;

                }
                schedules.Add(s);

            }

            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }

            return schedules;
        }

    }
}
