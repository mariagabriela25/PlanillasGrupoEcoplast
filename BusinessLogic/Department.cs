using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObjects;

namespace BusinessLogic
{
    public class Department
    {
        public int Code { get; set; }
        public String Name { get; set; }
        public List<Schedule> ScheduleList { get; set; }

        public Department(int code, string name)
        {
            this.Code = code;
            this.Name = name;
        }

        public void AddDepartment()
        {            
            TODepartment department = new TODepartment();
            DADepartment daDep = new DADepartment();

            department.Code = this.Code;
            department.Name = this.Name;        

            daDep.addDepartment(department);

        }

        public void DeleteDepartment()
        {
            TODepartment department = new TODepartment();
            DADepartment daDep = new DADepartment();

            department.Code = this.Code;

            daDep.deleteDepartment(department);
        }

        public Department GetDepartment()
        {           
            DADepartment daDep = new DADepartment();
            TODepartment dep = daDep.GetDepartment(this.Code);

            Department department = new Department(dep.Code, dep.Name);
            
            return department;
        }

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
