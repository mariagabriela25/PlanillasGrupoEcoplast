
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using TransferObjects;

namespace BusinessLogic
{
    /// <summary>
    /// Class WorkDayDetail.
    /// </summary>
    public class WorkDayDetail
    {
        /// <summary>
        /// Gets or sets the day.
        /// </summary>
        /// <value>The day.</value>
        public int Day { get; set; }
        /// <summary>
        /// Gets or sets the code employee.
        /// </summary>
        /// <value>The code employee.</value>
        public int CodeEmployee { get; set; }
        /// <summary>
        /// Gets or sets the ordinary hours.
        /// </summary>
        /// <value>The ordinary hours.</value>
        public double OrdinaryHours { get; set; }
        /// <summary>
        /// Gets or sets the total hours.
        /// </summary>
        /// <value>The total hours.</value>
        public double TotalHours { get; set; }
        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>The date.</value>
        public DateTime Date { get; set; }
        /// <summary>
        /// Gets or sets the note.
        /// </summary>
        /// <value>The note.</value>
        public string Note { get; set; }
        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>The state.</value>
        public Boolean State { get; set; }
        /// <summary>
        /// Gets or sets the week code.
        /// </summary>
        /// <value>The week code.</value>
        public int WeekCode { get; set; }
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int ID { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkDayDetail"/> class.
        /// </summary>
        /// <param name="code">The code.</param>
        /// <param name="ordinaryhours">The ordinaryhours.</param>
        /// <param name="totalhours">The totalhours.</param>
        /// <param name="date">The date.</param>
        /// <param name="note">The note.</param>
        /// <param name="state">The state.</param>
        /// <param name="weekcode">The weekcode.</param>
        /// <param name="id">The identifier.</param>
        public WorkDayDetail(int code, double ordinaryhours, double totalhours, DateTime date, string note, Boolean state, int weekcode, int id)
        {
            this.CodeEmployee = code;
            this.OrdinaryHours = ordinaryhours;
            this.TotalHours = totalhours;
            this.Date = date;
            this.WeekCode = weekcode;
            this.Note = note;
            this.State = state;
            this.ID = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkDayDetail"/> class.
        /// </summary>
        public WorkDayDetail() {}

        /// <summary>
        /// Adds the work day.
        /// </summary>
        /// <returns>Boolean.</returns>
        public Boolean AddWorkDay()
        {
            TOWorkDayDetail workday = new TOWorkDayDetail();
            workday.CodeEmployee = this.CodeEmployee;
            workday.OrdinaryHours = this.OrdinaryHours;
            workday.TotalHours = this.TotalHours;
            workday.Date = this.Date;
            workday.WeekCode = this.WeekCode;
            workday.Note = this.Note;
            workday.State = this.State;

            return new DAOWorkDay().AddWorkDayDetail(workday);
        }

        /// <summary>
        /// Updates the work day.
        /// </summary>
        /// <param name="dbCode">The database code.</param>
        /// <returns>Boolean.</returns>
        public Boolean UpdateWorkDay(int dbCode)
        {
            TOWorkDayDetail workday = new TOWorkDayDetail();
            workday.CodeEmployee = this.CodeEmployee;
            workday.OrdinaryHours = this.OrdinaryHours;
            workday.TotalHours = this.TotalHours;
            workday.Date = this.Date;
            workday.WeekCode = this.WeekCode;
            workday.Note = this.Note;
            workday.State = this.State;

            return new DAOWorkDay().UpdateWorkDayDetail(workday, dbCode);
        }

        /// <summary>
        /// Gets the work day user.
        /// </summary>
        /// <param name="code_Employee">The code employee.</param>
        /// <param name="codeWeek">The code week.</param>
        public void get_WorkDayUser(int code_Employee, int codeWeek)
        {
            TOWorkDayDetail toe = new TOWorkDayDetail();
            toe.CodeEmployee = code_Employee;
            toe.WeekCode = codeWeek;
            DAOWorkDay daow = new DAOWorkDay();
            this.TotalHours = daow.getWorkDay(toe).TotalHours;
            
        }

        /// <summary>
        /// Gets the weeks.
        /// </summary>
        /// <param name="codEmpl">The cod empl.</param>
        /// <param name="codWeek">The cod week.</param>
        /// <returns>List&lt;WorkDayDetail&gt;.</returns>
        public List<WorkDayDetail> getWeeks(int codEmpl, int codWeek)
        {
            List<WorkDayDetail> list = new List<WorkDayDetail>();
            DAOWorkDay dao = new DAOWorkDay();

            List<TOWorkDayDetail> tos = dao.getWorkedWeeks(codEmpl, codWeek);

            foreach(TOWorkDayDetail to in tos)
            {
                WorkDayDetail workDay = new WorkDayDetail();
                workDay.ID = to.ID;
                workDay.Date = to.Date;
                workDay.Day = to.Day;
                workDay.TotalHours = to.TotalHours;
                workDay.Note = to.Note;
                list.Add(workDay);
            }

            return list;
        }

        /// <summary>
        /// Determines whether [is department registered] [the specified department code].
        /// </summary>
        /// <param name="departmentCode">The department code.</param>
        /// <param name="weekNum">The week number.</param>
        /// <returns>Boolean.</returns>
        public Boolean isDepartmentRegistered(int departmentCode, int weekNum)
        {
            return new DAOWorkDay().isDepartmentRegistered(departmentCode, weekNum);
        }

    }
}
