using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
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
    }
}
