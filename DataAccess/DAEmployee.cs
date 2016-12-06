
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TransferObjects;
using System.Windows.Forms;

namespace DataAccess
{


    /// <summary>
    /// Class DAEmployee. Manages information from employees, and connections with the database 
    /// </summary>
    public class DAEmployee
    {
        /// <summary>
        /// The connection with the database
        /// </summary>
        SqlConnection conex = new SqlConnection(DataAccess.Properties.Settings.Default.StringConexAnviz);

        /// <summary>
        /// Adds a new employee
        /// </summary>
        /// <param name="employee">The new employee</param>
        public void AddEmployee(TOEmployee employee)
        {
            try
            {

                SqlCommand query = new SqlCommand("INSERT INTO Empleado VALUES (@CodEmpleado, @Nombre, @Apellido, @CodDepartamento)", conex);
                query.Parameters.AddWithValue("@CodEmpleado", employee.Code);
                query.Parameters.AddWithValue("@Nombre", employee.Name);
                query.Parameters.AddWithValue("@Apellido", employee.LastName);
                query.Parameters.AddWithValue("@CodDepartamento", employee.Departament.Code);

                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }

                query.ExecuteNonQuery();
                MessageBox.Show("¡El empleado fue agregado con éxito!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("¡Ocurrió un error! Inténtelo de nuevo.");
            }
            finally
            {
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
            }
        }

        /// <summary>
        /// Deletes one employee.
        /// </summary>
        /// <param name="employee">The employee to be deleted</param>
        public void DeleteEmployee(TOEmployee employee)
        {
            try
            {

                SqlCommand query = new SqlCommand("DELETE FROM Empleado WHERE CodEMpleado = @CodEmpleado", conex);
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
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión");
            }
            finally
            {
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
            }
        }

        /// <summary>
        /// Gets all employees.
        /// </summary>
        /// <returns>List<TOEmployee> a list of employees </returns>
        public List<TOEmployee> GetAllEmployees()
        {
            List<TOEmployee> employees = new List<TOEmployee>();

            try
            {

                SqlCommand query = new SqlCommand("SELECT Empleado.*, NombreDepartamento FROM Empleado, Departamento WHERE Departamento.CodDepartamento = Empleado.CodDepartamento;", conex);

                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }
                SqlDataReader reader = query.ExecuteReader();

                if (reader.HasRows)
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

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión");
            }
            finally
            {
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
            }


            return employees;
        }

        /// <summary>
        /// Gets one employee by code
        /// </summary>
        /// <param name="Code">The code of the employee</param>
        /// <returns>TOEmployee the employee found by code</returns>
        public TOEmployee GetEmployee(int Code)
        {
            TOEmployee employee = new TOEmployee();
            try
            {

                SqlCommand query = new SqlCommand("SELECT e.*, NombreDepartamento FROM Empleado e INNER JOIN Departamento d ON e.CodDepartamento = d.CodDepartamento WHERE CodEmpleado = @Code;", conex);
                query.Parameters.AddWithValue("@Code", Code);

                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }

                SqlDataReader reader = query.ExecuteReader();

                if (reader.HasRows)
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

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión");
            }
            finally
            {
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
            }

            return employee;
        }

        /// <summary>
        /// Modifies one employee.
        /// </summary>
        /// <param name="employee">The employee to be modified</param>
        public void ModifyEmployee(TOEmployee employee)
        {
            try
            {

                SqlCommand query = new SqlCommand("UPDATE Empleado SET CodDepartamento = @CodDepartamento, Nombre = @Nombre, Apellido = @Apellido WHERE CodEmpleado = @CodEmpleado;", conex);
                query.Parameters.AddWithValue("@CodDepartamento", employee.Departament.Code);
                query.Parameters.AddWithValue("@CodEmpleado", employee.Code);
                query.Parameters.AddWithValue("@Nombre", employee.Name);
                query.Parameters.AddWithValue("@Apellido", employee.LastName);

                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }

                query.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión");
            }
            finally
            {
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
            }

        }


        /// <summary>
        /// Gets the employee's department.
        /// </summary>
        /// <param name="departmentCode">The department code</param>
        /// <returns>List<TOEmployee> a list of employees that belong to the department requested</returns>
        public List<TOEmployee> GetEmployeesDepartment(int departmentCode)
        {

            List<TOEmployee> employees = new List<TOEmployee>();

            try
            {

                SqlCommand query = new SqlCommand("SELECT * FROM Empleado inner join Departamento ON Empleado.CodDepartamento = Departamento.CodDepartamento WHERE Empleado.CodDepartamento = @depCode;", conex);
                query.Parameters.AddWithValue("@depCode", departmentCode);

                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }
                SqlDataReader reader = query.ExecuteReader();

                if (reader.HasRows)
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

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión");
            }
            finally
            {
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
            }

            return employees;
        }

        /// <summary>
        /// Gets the total hours per week.
        /// </summary>
        /// <param name="code">The code of the week</param>
        /// <param name="weeknumber">The weeknumber.</param>
        /// <returns>System.Double the total hours worked in that week</returns>
        public double GetTotalHoursPerWeek(int code, int weeknumber)
        {

            try
            {
                SqlCommand query = new SqlCommand("SELECT SUM(TotalHoras) FROM DetalleDiaLaborado Where CodEmpleado = @employee AND CodSemana = @week", conex);
                query.Parameters.AddWithValue("@employee", code);
                query.Parameters.AddWithValue("@week", weeknumber);

                if (conex.State != ConnectionState.Open)
                {
                    conex.Open();
                }

                SqlDataReader reader = query.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    return (Double)reader.GetDecimal(0);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión");
            }
            finally
            {
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
            }
            return 0;
        }

    }
}
