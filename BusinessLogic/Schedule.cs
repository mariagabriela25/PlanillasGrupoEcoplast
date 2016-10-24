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
        public int OrdinaryHours { get; set; }
        public int ExtraDayHours { get; set; }
        public int ExtraNightHours { get; set; }
        public int TotalHours { get; set; }
        public Department Dept { get; set; }
        public List<Rest> RestList { get; set; }

        public Schedule (string Code, DateTime InitialHour, DateTime finalHour, int OrdinaryHours, int ExtraDayHours, int ExtraNightHours, int TotalHours, Department Dept)
        {
            this.Code = Code;
            this.InitialHour = InitialHour;
            this.finalHour = finalHour;
            this.OrdinaryHours = OrdinaryHours;
            this.ExtraDayHours = ExtraDayHours;
            this.ExtraNightHours = ExtraNightHours;
            this.TotalHours = TotalHours;
            this.RestList = new List<Rest>();
            this.Dept = Dept;
    }

        public Schedule ()
        {
            this.RestList = new List<Rest>();
        }

        public void AddRest(Rest newRest)
        {
            RestList.Add(newRest);
        }

        public bool AddSchedule()
        {
            TOSchedule tos = new TOSchedule();
            TODepartment tod = new TODepartment();
            List<TORest> toList = new List<TORest>();

            tos.Code = Code;
            tos.InitialHour = InitialHour;
            tos.finalHour = finalHour;
            tos.OrdinaryHours = OrdinaryHours;
            tos.ExtraDayHours = ExtraDayHours;
            tos.ExtraNightHours = ExtraNightHours;
            tos.TotalHours = TotalHours;

            tod.Code = Dept.Code;
            tod.Name = Dept.Name;

            tos.depart = tod;

            foreach (var item in RestList)
            {
                TORest tr = new TORest();
                tr.Code = item.Code;
                tr.Minutes = item.Minutes;
                toList.Add(tr);
            }

            tos.RestList = toList;

            DAOSchedule daoS = new DAOSchedule();
            return daoS.AddSchedule(tos);

        }

        public void ModifySchedule()
        {
            TOSchedule tos = new TOSchedule();
            TODepartment tod = new TODepartment();
            List<TORest> toList = new List<TORest>();

            tos.Code = Code;
            tos.InitialHour = InitialHour;
            tos.finalHour = finalHour;
            tos.OrdinaryHours = OrdinaryHours;
            tos.ExtraDayHours = ExtraDayHours;
            tos.ExtraNightHours = ExtraNightHours;
            tos.TotalHours = TotalHours;

            tod.Code = Dept.Code;
            tod.Name = Dept.Name;

            tos.depart = tod;

            foreach (var item in RestList)
            {
                TORest tr = new TORest();
                tr.Code = item.Code;
                tr.Minutes = item.Minutes;
                toList.Add(tr);
            }

            DAOSchedule daoS = new DAOSchedule();
            daoS.ModifySchedule(tos);
        }

        public Schedule GetSchedule()
        {

            DAOSchedule daoS = new DAOSchedule();
            TOSchedule s = daoS.GetSchedule(this.Code);

            Schedule schedule = new Schedule(s.Code, s.InitialHour, s.finalHour, s.OrdinaryHours, s.ExtraDayHours, s.ExtraNightHours, s.TotalHours, new Department(s.depart.Code, s.depart.Name));

            foreach (var item in s.RestList)
            {
                Rest r = new Rest();
                r.Code = item.Code;
                r.Minutes = item.Minutes;
                schedule.AddRest(r);
            }
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
                Schedule schedule = new Schedule(s.Code, s.InitialHour, s.finalHour, s.OrdinaryHours, s.ExtraDayHours, s.ExtraNightHours, s.TotalHours, new Department(s.depart.Code, s.depart.Name));

                foreach (var item in s.RestList)
                {
                    Rest r = new Rest();
                    r.Code = item.Code;
                    r.Minutes = item.Minutes;
                    schedule.AddRest(r);
                }

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
                Schedule schedule = new Schedule(s.Code, s.InitialHour, s.finalHour, s.OrdinaryHours, s.ExtraDayHours, s.ExtraNightHours, s.TotalHours, new Department(s.depart.Code, s.depart.Name));

                foreach (var item in s.RestList)
                {
                    Rest r = new Rest();
                    r.Code = item.Code;
                    r.Minutes = item.Minutes;
                    schedule.AddRest(r);
                }

                schedules.Add(schedule);
            }

            return schedules;
        }

    }
}
