using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObjects;
using DataAccess;

namespace BusinessLogic
{
    public class Employee
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Department Department { get; set; }

        public Employee(int code, string name, string lastname, Department department)
        {
            this.Code = code;
            this.Name = name;
            this.LastName = lastname;
            this.Department = department;
        }

        public Employee()
        {
        }

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

        public void DeleteEmployee()
        {
            TOEmployee employee = new TOEmployee();
            DAEmployee dae = new DAEmployee();

            employee.Code = this.Code;

            dae.DeleteEmployee(employee);
        }

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

        public Employee GetEmployee()
        {

            DAEmployee dae = new DAEmployee();
            TOEmployee e = dae.GetEmployee(this.Code);
            Employee employee = new Employee(e.Code, e.Name, e.LastName, new Department(e.Departament.Code, e.Departament.Name));

            return employee;
        }

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


    }
}
