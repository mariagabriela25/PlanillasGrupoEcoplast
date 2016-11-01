using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObjects;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DAOWorkDay
    {
        SqlConnection conex = new SqlConnection(DataAccess.Properties.Settings.Default.StringConex);

        public Boolean AddWorkDayDetail(TOWorkDayDetail workday)
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

            if (conex.State != System.Data.ConnectionState.Closed)
            {
                conex.Close();
            }

            return true;
        }

        public TOWorkDayDetail getWorkDay(TOWorkDayDetail tow)
        {
            TOWorkDayDetail workDay = new TOWorkDayDetail();

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



            if (conex.State != System.Data.ConnectionState.Closed)
            {
                conex.Close();
            }

            return workDay;
        }

        public List<TOWorkDayDetail> getWorkedWeeks(int codEmpl, int codWeek)
        {
            List<TOWorkDayDetail> list = new List<TOWorkDayDetail>();

           SqlCommand query = new SqlCommand("select d.Fecha, d.TotalHoras from DetalleDiaLaborado as d where CodEmpleado = @CodeEmployee and CodSemana = @CodeWeek", conex);
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

                    DateTime datevalue = reader.GetDateTime(0);
                    int day = (Int32) datevalue.DayOfWeek;

                    e.Date = datevalue;
                    e.Day = day;
                    e.TotalHours = (Double) reader.GetDecimal(1);

                    list.Add(e);
                }
            }

            if (conex.State != System.Data.ConnectionState.Closed)
            {
                conex.Close();
            }

            return list;

        }

    }
}
