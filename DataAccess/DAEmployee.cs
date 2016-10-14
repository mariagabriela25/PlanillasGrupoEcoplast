using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TransferObjects;

namespace DataAccess
{


    public class DAEmployee
    {
        SqlConnection conex = new SqlConnection("");

        public void AddEmployee(TOEmployee employee)
        {
            SqlCommand query = new SqlCommand("INSERT INTO Empleado VALUES (@CodEmpleado, @Nombre, @Apellido, @CodDepartamento)", conex);
            query.Parameters.AddWithValue("@CodEmpleado", employee.Code);
            query.Parameters.AddWithValue("@Nombre", employee.Name);
            query.Parameters.AddWithValue("@Apellido", employee.LastName);
            query.Parameters.AddWithValue("@CodDepartamento", employee.Departament);

            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }

            query.ExecuteNonQuery();

            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }
        }

        public void DeleteEmployee(TOEmployee employee)
        {
            SqlCommand query =  new SqlCommand("DELETE FROM Empleado WHERE CodEMpleado = @CodEmpleado", conex);
            query.Parameters.AddWithValue("@CodEmpleado", employee.Code);

            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }

            query.ExecuteNonQuery();

            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }
        }
        
        public List<TOEmployee> GetAllEmployees()
        {
            List<TOEmployee> employees = new List<TOEmployee>();
            SqlCommand query = new SqlCommand("SELECT Empleado.*, NombreDepartamento FROM Empleado, Departamento WHERE Departamento.CodDepartamento = Empleado.CodDepartamento;", conex);

            SqlDataReader reader = query.ExecuteReader();

            if(reader.HasRows)
            {

                while (reader.Read())
                {
                    TOEmployee e = new TOEmployee();
                    TODepartment d = new TODepartment();
                    e.Code = reader.GetInt32(0);
                    e.Name = reader.GetString(1);
                    e.LastName = reader.GetString(2);
                    d.Code = reader.GetInt32(3);
                    d.Name = reader.GetString(4);
                    e.Departament = d;

                    employees.Add(e);
                }
            }
            return employees;
        }

        public TOEmployee GetEmployee(int Code)
        {
            TOEmployee employee = new TOEmployee();

            SqlCommand query = new SqlCommand("SELECT e.*, NombreDepartamento FROM Empleado e INNER JOIN Departamento d ON e.CodDepartamento = d.CodDepartamento WHERE CodEmpleado = @Code;", conex);
            query.Parameters.AddWithValue("@Code", Code);

            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }

            SqlDataReader reader = query.ExecuteReader();

            if(reader.HasRows)
            {
                reader.Read();

                TODepartment d = new TODepartment();
                employee.Code = reader.GetInt32(0);
                employee.Name = reader.GetString(1);
                employee.LastName = reader.GetString(2);
                d.Code = reader.GetInt32(3);
                d.Name = reader.GetString(4);
                employee.Departament = d;
            }

            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }

            return employee;
        }

        public void ModifyEmployee(TOEmployee employee)
        {
            SqlCommand query = new SqlCommand("UPDATE Empleado SET CodDepartamento = @CodDepartamento WHERE CodEmpleado = @CodEmpleado;", conex);
            query.Parameters.AddWithValue("@CodDepartamento", employee.Departament.Code);
            query.Parameters.AddWithValue("@CodEmpleado", employee.Code);

            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }

            query.ExecuteNonQuery();

            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }

        }

    }
}
