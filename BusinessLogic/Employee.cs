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

        public void AddEmployee()
        {

        }
    }
}
