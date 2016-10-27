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

    }
}
