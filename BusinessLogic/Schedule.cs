using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObjects;
using DataAccess;

namespace BusinessLogic
{
    public class Schedule
    {
        public string Code { get; set; }
        public DateTime InitialHour { get; set; }
        public DateTime finalHour { get; set; }
        public double OrdinaryHours { get; set; }
        public Department Dept { get; set; }

        public Schedule (string Code, DateTime InitialHour, DateTime finalHour, double OrdinaryHours, Department Dept)
        {
            this.Code = Code;
            this.InitialHour = InitialHour;
            this.finalHour = finalHour;
            this.OrdinaryHours = OrdinaryHours;
            this.Dept = Dept;
    }

        public Schedule ()
        {
        }

        public bool AddSchedule()
        {
            TOSchedule tos = new TOSchedule();
            TODepartment tod = new TODepartment();

            tos.Code = Code;
            tos.InitialHour = InitialHour;
            tos.finalHour = finalHour;
            tos.OrdinaryHours = OrdinaryHours;

            tod.Code = Dept.Code;
            tod.Name = Dept.Name;

            tos.depart = tod;

            DAOSchedule daoS = new DAOSchedule();
            return daoS.AddSchedule(tos);

        }

        public void ModifySchedule()
        {
            TOSchedule tos = new TOSchedule();
            TODepartment tod = new TODepartment();

            tos.Code = Code;
            tos.InitialHour = InitialHour;
            tos.finalHour = finalHour;
            tos.OrdinaryHours = OrdinaryHours;

            tod.Code = Dept.Code;
            tod.Name = Dept.Name;

            tos.depart = tod;
            
            DAOSchedule daoS = new DAOSchedule();
            daoS.ModifySchedule(tos);
        }

        public Schedule GetSchedule()
        {

            DAOSchedule daoS = new DAOSchedule();
            TOSchedule s = daoS.GetSchedule(this.Code);

            Schedule schedule = new Schedule(s.Code, s.InitialHour, s.finalHour, s.OrdinaryHours, new Department(s.depart.Code, s.depart.Name));

            return schedule;
        }

        public void DeleteSchedule()
        {
            DAOSchedule daos = new DAOSchedule();
            daos.DeleteSchedule(this.Code);
        }

        public List<Schedule> GetAllSchedules()
        {
            DAOSchedule daos = new DAOSchedule();
            List<Schedule> schedules = new List<Schedule>();
            List<TOSchedule> listReturn = daos.GetAllSchedules();
            
            foreach (TOSchedule s in listReturn)
            {
                Schedule schedule = new Schedule(s.Code, s.InitialHour, s.finalHour, s.OrdinaryHours, new Department(s.depart.Code, s.depart.Name));

                schedules.Add(schedule);
            }

            return schedules;
        }

        public List<Schedule> GetDepSchedules(int departmentCode)
        {
            DAOSchedule daos = new DAOSchedule();
            List<Schedule> schedules = new List<Schedule>();
            List<TOSchedule> listReturn = daos.GetSchedulesDep(departmentCode);

            foreach (TOSchedule s in listReturn)
            {
                Schedule schedule = new Schedule(s.Code, s.InitialHour, s.finalHour, s.OrdinaryHours, new Department(s.depart.Code, s.depart.Name));
                
                schedules.Add(schedule);
            }

            return schedules;
        }

    }
}
