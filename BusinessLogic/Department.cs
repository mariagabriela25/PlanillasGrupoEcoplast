
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObjects;

namespace BusinessLogic
{
    /// <summary>
    /// Class Department. Represents a department in the system.
    /// </summary>
    public class Department
    {
        /// <summary>
        /// Gets or sets the code of the department
        /// </summary>
        /// <value>The code </value>
        public int Code { get; set; }
        /// <summary>
        /// Gets or sets the name of the department
        /// </summary>
        /// <value>The name </value>
        public String Name { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="Department"/> class.
        /// </summary>
        /// <param name="code">The code of the department</param>
        /// <param name="name">The name of the department</param>
        public Department(int code, string name)
        {
            this.Code = code;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Department"/> class.
        /// </summary>
        public Department() { }

        /// <summary>
        /// Adds a new department in the database.
        /// </summary>
        public void AddDepartment()
        {            
            TODepartment department = new TODepartment();
            DADepartment daDep = new DADepartment();

            department.Code = this.Code;
            department.Name = this.Name;        

            daDep.addDepartment(department);

        }

        /// <summary>
        /// Modifies a department in the database
        /// </summary>
        public void ModifyDepartment()
        {
            TODepartment department = new TODepartment();
            DADepartment daDep = new DADepartment();

            department.Code = this.Code;
            department.Name = this.Name;

            daDep.modifyDepartment(department);

        }

        /// <summary>
        /// Deletes a department from the database.
        /// </summary>
        public void DeleteDepartment()
        {
            TODepartment department = new TODepartment();
            DADepartment daDep = new DADepartment();

            department.Code = this.Code;

            daDep.deleteDepartment(department);
        }

        /// <summary>
        /// Gets a department from the database based on the code.
        /// </summary>
        /// <returns>Department.</returns>
        public Department GetDepartment()
        {           
            DADepartment daDep = new DADepartment();
            TODepartment dep = daDep.GetDepartment(this.Code);

            Department department = new Department(dep.Code, dep.Name);
            
            return department;
        }

        /// <summary>
        /// Gets all departments
        /// </summary>
        /// <returns>List<Department> a list with all departments</returns>
        public List<Department> GetAllDepartment()
        {
            DADepartment daDep = new DADepartment();
            List<Department> departmentList = new List<Department>();
            List<TODepartment>  departments= daDep.GetAllDepartments();
            foreach (TODepartment dep in departments)
            {
                Department department = new Department(dep.Code, dep.Name);
                departmentList.Add(department);
            }

            return departmentList;
        }
    }
}
