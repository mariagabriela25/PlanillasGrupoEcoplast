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
    public class DAORest
    {

        SqlConnection connection = new SqlConnection("Data Source = .;Initial Catalog = BaseEcoplast; Integrated Security = true");

        public void addRest(TORest rest)
        {
            String query = "insert into Descanso (codDescanso, CantMinutos) values (@codDescanso, @CantMinutos); ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@codDescanso", rest.Code);
            command.Parameters.AddWithValue("@CantMinutos", rest.Minutes);

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            command.ExecuteNonQuery();

            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        public List<TORest> getAllRests()
        {
            SqlCommand query = new SqlCommand("select * from Descanso", connection);
            List<TORest> rests = new List<TORest>();

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            SqlDataReader reader = query.ExecuteReader();

            if(reader.HasRows)
            {
                while (reader.Read())
                {
                    rests.Add(new TORest
                    {
                        Code = reader.GetInt32(0),
                        Minutes = reader.GetInt32(0)
                    });
                }
            }

            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }

            return rests;
        }


        public TORest getRest(int code)
        {
            SqlCommand query = new SqlCommand("select * from Descanso where CodDescanso=@code", connection);
            query.Parameters.AddWithValue("@code", code);

            TORest rest = null;

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            SqlDataReader reader = query.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();

                rest = new TORest
                {
                    Code = reader.GetInt32(0),
                    Minutes = reader.GetInt32(0)
                };

            }

            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }

            return rest;
        }

        public void deleteRest(int code)
        {
            String query = "delete from Descanso where codDescanso=@code ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@code", code);

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            command.ExecuteNonQuery();

            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }
    }
}
