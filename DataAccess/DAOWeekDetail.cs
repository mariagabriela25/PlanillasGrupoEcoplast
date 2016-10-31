using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using TransferObjects;

namespace DataAccess
{
    public class DAOWeekDetail
    {
        SqlConnection conex = new SqlConnection(DataAccess.Properties.Settings.Default.StringConex);

        public Boolean SaveWeekDetail(TOWorkWeekDetail twd)
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

            if (conex.State != System.Data.ConnectionState.Closed)
            {
                conex.Close();
            }

            return true;
        }

        public List<TOWorkWeekDetail> getWeekPerNumber(int weekNumber)
        {
            List<TOWorkWeekDetail> list = new List<TOWorkWeekDetail>();
            SqlCommand query = new SqlCommand("select e.Nombre, e.Apellido, s.HorasCCSS, s.HorasTotales, s.HorasExtras from DetalleSemanaLaborada as s inner join Empleado as e on s.CodEmpleado = e.CodEmpleado where NumSemana = @WeekNumber", conex);
            query.Parameters.AddWithValue("@WeekNumber", weekNumber);

            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }

            SqlDataReader reader = query.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();

                TOWorkWeekDetail week = new TOWorkWeekDetail();
                week.Name = reader.GetString(0) + " " + reader.GetString(1);
                week.CCSSHours = (Double) reader.GetDecimal(2);
                week.TotalHours = (Double) reader.GetDecimal(3);
                week.ExtraHours = (Double) reader.GetDecimal(4);

                list.Add(week);
            }

            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }
            return list;
        }

        public List<int> getWeekNumbers()
        {
            List<int> weeks = new List<int>();
            SqlCommand query = new SqlCommand("select NumSemana from DetalleSemanaLaborada", conex);

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

            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }
            return weeks;
        }
    }
}
