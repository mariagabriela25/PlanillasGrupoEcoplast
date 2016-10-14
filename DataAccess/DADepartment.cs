using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class DADepartment
    {
        private SqlConnection conexion = new SqlConnection("Data Source=.; Initial Catalog= BaseEcoplast; Integrated Security=true");

        public void agregarCliente(TOCliente c)
        {
            try
            {

                if (conexion.State != System.Data.ConnectionState.Open)
                {
                    conexion.Open();
                }

                SqlCommand comando = new SqlCommand(sp_InsertarCliente, conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@mail", c.Correo);
                comando.Parameters.AddWithValue("@contrasenna", c.Contrasena);
                comando.Parameters.AddWithValue("@nombre", c.Nombre);
                comando.Parameters.AddWithValue("@apellido", c.Apellido);
                comando.Parameters.AddWithValue("@direccion", c.Direccion);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conexion.State != System.Data.ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
        }
    }
}
