
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
    /// Class Schedule. Represents a Schedule in the system.
    /// </summary>
    public class Schedule
    {
        /// <summary>
        /// Gets or sets the code of the schedule
        /// </summary>
        /// <value>The code.</value>
        public string Code { get; set; }
        /// <summary>
        /// Gets or sets the initial hour.
        /// </summary>
        /// <value>The initial hour.</value>
        public DateTime InitialHour { get; set; }
        /// <summary>
        /// Gets or sets the final hour.
        /// </summary>
        /// <value>The final hour.</value>
        public DateTime finalHour { get; set; }
        /// <summary>
        /// Gets or sets the ordinary hours.
        /// </summary>
        /// <value>The ordinary hours.</value>
        public double OrdinaryHours { get; set; }
        /// <summary>
        /// Gets or sets the department to which it belongs 
        /// </summary>
        /// <value>The dept.</value>
        public Department Dept { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Schedule" /> class.
        /// </summary>
        /// <param name="Code">Identifier of the schedule</param>
        /// <param name="InitialHour">The initial hour of the schedule</param>
        /// <param name="finalHour">The final hour of the schedule</param>
        /// <param name="OrdinaryHours">The ordinary hours.</param>
        /// <param name="Dept">The department to which it belongs </param>
        public Schedule (string Code, DateTime InitialHour, DateTime finalHour, double OrdinaryHours, Department Dept)
        {
            this.Code = Code;
            this.InitialHour = InitialHour;
            this.finalHour = finalHour;
            this.OrdinaryHours = OrdinaryHours;
            this.Dept = Dept;
    }

        /// <summary>
        /// Initializes a new instance of the <see cref="Schedule" /> class.
        /// </summary>
        public Schedule ()
        {
        }

        /// <summary>
        /// Adds a new schedule to the list of schedules
        /// </summary>
        /// <returns><c>true</c> returns true if added, otherwise returns false.</returns>
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

        /// <summary>
        /// Modifies the schedule selected.
        /// </summary>
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

        /// <summary>
        /// Gets one schedule.
        /// </summary>
        /// <returns>Schedule the schedule requested</returns>
        public Schedule GetSchedule()
        {

            DAOSchedule daoS = new DAOSchedule();
            TOSchedule s = daoS.GetSchedule(this.Code);

            Schedule schedule = new Schedule(s.Code, s.InitialHour, s.finalHour, s.OrdinaryHours, new Department(s.depart.Code, s.depart.Name));

            return schedule;
        }

        /// <summary>
        /// Deletes one schedule.
        /// </summary>
        public void DeleteSchedule()
        {
            DAOSchedule daos = new DAOSchedule();
            daos.DeleteSchedule(this.Code);
        }

        /// <summary>
        /// Gets all schedules.
        /// </summary>
        /// <returns>a list of schedules</returns>
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

        /// <summary>
        /// Gets the department's schedules.
        /// </summary>
        /// <param name="departmentCode">The department code.</param>
        /// <returns>a list of schedules from one department</returns>
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
