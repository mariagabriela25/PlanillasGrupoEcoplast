
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObjects;
using DataAccess;

namespace BusinessLogic
{
    /// <summary>
    /// Class Employee.
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>The code.</value>
        public int Code { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>The last name.</value>
        public string LastName { get; set; }
        /// <summary>
        /// Gets or sets the department.
        /// </summary>
        /// <value>The department.</value>
        public Department Department { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        /// <param name="code">The code.</param>
        /// <param name="name">The name.</param>
        /// <param name="lastname">The lastname.</param>
        /// <param name="department">The department.</param>
        public Employee(int code, string name, string lastname, Department department)
        {
            this.Code = code;
            this.Name = name;
            this.LastName = lastname;
            this.Department = department;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        public Employee()
        {
        }

        /// <summary>
        /// Adds the employee.
        /// </summary>
        public void AddEmployee()
        {
            TOEmployee employee = new TOEmployee();
            TODepartment department = new TODepartment();
            DAEmployee dae = new DAEmployee();

            employee.Code = this.Code;
            employee.Name = this.Name;
            employee.LastName = this.LastName;
            department.Name = this.Department.Name;
            department.Code = this.Department.Code;
            employee.Departament = department;

            dae.AddEmployee(employee);

        }

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        public void DeleteEmployee()
        {
            TOEmployee employee = new TOEmployee();
            DAEmployee dae = new DAEmployee();

            employee.Code = this.Code;

            dae.DeleteEmployee(employee);
        }

        /// <summary>
        /// Gets all employees.
        /// </summary>
        /// <returns>List&lt;Employee&gt;.</returns>
        public List<Employee> GetAllEmployees()
        {
            DAEmployee dae = new DAEmployee();
            List<Employee> employees = new List<Employee>();
            List<TOEmployee> list = dae.GetAllEmployees();
            foreach(TOEmployee e in list)
            {
                Employee employee = new Employee(e.Code, e.Name, e.LastName, new Department(e.Departament.Code, e.Departament.Name));
                employees.Add(employee);
            }

            return employees;
        }

        /// <summary>
        /// Gets the employee.
        /// </summary>
        /// <returns>Employee.</returns>
        public Employee GetEmployee()
        {

            DAEmployee dae = new DAEmployee();
            TOEmployee e = dae.GetEmployee(this.Code);
            Employee employee = new Employee(e.Code, e.Name, e.LastName, new Department(e.Departament.Code, e.Departament.Name));

            return employee;
        }

        /// <summary>
        /// Modifies the employee.
        /// </summary>
        public void ModifyEmployee()
        {
            TOEmployee employee = new TOEmployee();
            TODepartment department = new TODepartment();
            DAEmployee dae = new DAEmployee();

            employee.Code = this.Code;
            department.Code = this.Department.Code;
            employee.Departament = department;

            employee.Name = this.Name;
            employee.LastName = this.LastName;

            dae.ModifyEmployee(employee);
        }

        /// <summary>
        /// Gets the employees dep.
        /// </summary>
        /// <param name="depCode">The dep code.</param>
        /// <returns>List&lt;Employee&gt;.</returns>
        public List<Employee> GetEmployeesDep(int depCode)
        {
            DAEmployee dae = new DAEmployee();
            List<Employee> employees = new List<Employee>();
            List<TOEmployee> list = dae.GetEmployeesDepartment(depCode);
            foreach (TOEmployee e in list)
            {
                Employee employee = new Employee(e.Code, e.Name, e.LastName, new Department(e.Departament.Code, e.Departament.Name));
                employees.Add(employee);
            }

            return employees;
        }

        /// <summary>
        /// Gets the total hours.
        /// </summary>
        /// <param name="code">The code.</param>
        /// <param name="week">The week.</param>
        /// <returns>System.Double.</returns>
        public double GetTotalHours(int code, int week)
        {
            return new DAEmployee().GetTotalHoursPerWeek(code, week);
        }

        /// <summary>
        /// Gets the employees calculated week.
        /// </summary>
        /// <param name="week">The week.</param>
        /// <returns>List&lt;System.Int32&gt;.</returns>
        public List<int> getEmployeesCalculatedWeek(int week)
        {
            DAOWorkDay dwd = new DAOWorkDay();
            List<int> employeesRegistered = dwd.getEmployeesCalculatedWeek(week);
            List<int> returnList = new List<int>();

            foreach (int item in employeesRegistered)
            {
                returnList.Add(item);
            }

            return returnList;
        }
        
    }
}
