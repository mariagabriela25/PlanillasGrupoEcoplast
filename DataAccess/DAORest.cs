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

        SqlConnection connection = new SqlConnection(DataAccess.Properties.Settings.Default.StringConex);

        public void addRest(TORest rest)
        {
            String query = "insert into Descanso (CantMinutos) values (@CantMinutos); ";
            SqlCommand command = new SqlCommand(query, connection);
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
                        Minutes = reader.GetInt32(1)
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
                    Minutes = reader.GetInt32(1)
                };

            }

            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }

            return rest;
        }

        public void modifyRest(TORest modRest)
        {
            String query = "UPDATE Descanso SET CantMinutos = @CantMinutos WHERE CodDescanso = @CodDescanso; ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CodDescanso", modRest.Code);
            command.Parameters.AddWithValue("@CantMinutos", modRest.Minutes);

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
