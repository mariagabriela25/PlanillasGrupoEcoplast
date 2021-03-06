﻿
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObjects;

namespace DataAccess
{
    /// <summary>
    /// Class DADepartment. Manages information from Departments, and connections with the database 
    /// </summary>
    public class DADepartment
    {

        /// <summary>
        /// The connexion with the database
        /// </summary>
        SqlConnection conexion = new SqlConnection(DataAccess.Properties.Settings.Default.StringConexAnviz);

        /// <summary>
        /// Adds a new department.
        /// </summary>
        /// <param name="dep">The new department</param>
        public void addDepartment(TODepartment dep)
        {
            try
            {

                if (conexion.State != System.Data.ConnectionState.Open)
                {
                    conexion.Open();
                }

                SqlCommand command = new SqlCommand("Insert into Departamento values(@DepartmentName, @DepartmentCode)", conexion);

                command.Parameters.AddWithValue("@DepartmentName", dep.Name);
                command.Parameters.AddWithValue("@DepartmentCode", dep.Code);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión");
            }
            finally
            {
                if (conexion.State != System.Data.ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
        }

        /// <summary>
        /// Modifies one department.
        /// </summary>
        /// <param name="dep"> the department to modified</param>
        public void modifyDepartment(TODepartment dep)
        {
            try
            {

                if (conexion.State != System.Data.ConnectionState.Open)
                {
                    conexion.Open();
                }

                SqlCommand command = new SqlCommand("UPDATE Departamento SET NombreDepartamento = @NombreDepartamento WHERE CodDepartamento = @CodDepartamento;", conexion);

                command.Parameters.AddWithValue("@NombreDepartamento", dep.Name);
                command.Parameters.AddWithValue("@CodDepartamento", dep.Code);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión");
            }
            finally
            {
                if (conexion.State != System.Data.ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
        }


        /// <summary>
        /// Deletes one department.
        /// </summary>
        /// <param name="dep">The department to be deleted</param>
        public void deleteDepartment(TODepartment dep)
        {
            try
            {

                if (conexion.State != System.Data.ConnectionState.Open)
                {
                    conexion.Open();
                }

                SqlCommand command = new SqlCommand("Delete from Departamento where CodDepartamento = @DepartmentCode", conexion);

                command.Parameters.AddWithValue("@DepartmentCode", dep.Code);

                command.ExecuteNonQuery();
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


        /// <summary>
        /// Gets all departments.
        /// </summary>
        /// <returns>List<TODepartment> a list with all the departments</returns>
        public List<TODepartment> GetAllDepartments()
        {
            List<TODepartment> departments = new List<TODepartment>();

            try
            {

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                SqlCommand command = new SqlCommand("SELECT * FROM Departamento;", conexion);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        TODepartment dept = new TODepartment();
                        dept.Code = reader.GetInt32(1);
                        dept.Name = reader.GetString(0);

                        departments.Add(dept);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión");
            }
            finally
            {
                if (conexion.State != System.Data.ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }

            return departments;
        }


        /// <summary>
        /// Gets the department.
        /// </summary>
        /// <param name="Code">The code.</param>
        /// <returns>TODepartment.</returns>
        public TODepartment GetDepartment(int Code)
        {
            TODepartment department = new TODepartment();

            try
            {

                SqlCommand query = new SqlCommand("SELECT * FROM Departamento WHERE CodDepartamento = @Code;", conexion);
                query.Parameters.AddWithValue("@Code", Code);

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                SqlDataReader reader = query.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    department.Code = reader.GetInt32(1);
                    department.Name = reader.GetString(0);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión");
            }
            finally
            {
                if (conexion.State != System.Data.ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
            return department;
        }


        //optional
        /// <summary>
        /// Searches one department.
        /// </summary>
        /// <param name="request">The request from the user</param>
        /// <returns>TODepartment the department requested</returns>
        public TODepartment searchDepartment(String request)
        {
            TODepartment department = new TODepartment();

            try
            {

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                SqlCommand command = new SqlCommand("SELECT * FROM Departamento WHERE(@request like NombreDepartamento OR @request like CodDepartamento);", conexion);
                command.Parameters.AddWithValue("@request", request);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        department.Code = reader.GetInt32(1);
                        department.Name = reader.GetString(0);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión");
            }
            finally
            {
                if (conexion.State != System.Data.ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }

            return department;
        }

    }
}


