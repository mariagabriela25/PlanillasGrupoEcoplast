
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
    /// Class WorkWeekDetail. Represents a work week detail in the system.
    /// </summary>
    public class WorkWeekDetail
    {
        /// <summary>
        /// Gets or sets the code of the object
        /// </summary>
        /// <value>The code</value>
        public int Code { get; set; }

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        /// <value>The name.</value>
        public String Name { get; set; }

        /// <summary>
        /// Gets or sets the CCSS hours.
        /// </summary>
        /// <value>The CCSS hours.</value>
        public double CCSSHours { get; set; }
        /// <summary>
        /// Gets or sets the total hours.
        /// </summary>
        /// <value>The total hours.</value>
        public double TotalHours { get; set; }
        /// <summary>
        /// Gets or sets the extra hours of the week
        /// </summary>
        /// <value>The extra hours.</value>
        public double ExtraHours { get; set; }
        /// <summary>
        /// Gets or sets the employee code.
        /// </summary>
        /// <value>The employee code.</value>
        public int EmployeeCode { get; set; }
        /// <summary>
        /// Gets or sets the week number of the week
        /// </summary>
        /// <value>The week number.</value>
        public int WeekNumber { get; set; }
        /// <summary>
        /// Gets or sets the year of the week
        /// </summary>
        /// <value>The year.</value>
        public int Year { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkWeekDetail"/> class.
        /// </summary>
        /// <param name="Code">The code of the week</param>
        /// <param name="CCSSHours">The CCSS hours worked of the week.</param>
        /// <param name="TotalHours">The total hours worked of the week.</param>
        /// <param name="ExtraHours">The extra hours worked of the week.</param>
        /// <param name="EmployeeCode">The employee's code.</param>
        /// <param name="WeekNumber">The week's number.</param>
        /// <param name="Year">The year's week.</param>
        public WorkWeekDetail(int Code, double CCSSHours, double TotalHours, double ExtraHours, int EmployeeCode, int WeekNumber, int Year)
        {
            this.Code = Code;
            this.CCSSHours = CCSSHours;
            this.TotalHours = TotalHours;
            this.ExtraHours = ExtraHours;
            this.EmployeeCode = EmployeeCode;
            this.WeekNumber = WeekNumber;
            this.Year = Year;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkWeekDetail"/> class.
        /// </summary>
        public WorkWeekDetail()
        {
        }

        /// <summary>
        /// Saves the week report.
        /// </summary>
        /// <returns>Boolean true if was saved, false if not</returns>
        public Boolean SaveWeekReport()
        {
            TOWorkWeekDetail twd = new TOWorkWeekDetail();
            twd.CCSSHours = CCSSHours;
            twd.TotalHours = TotalHours;
            twd.ExtraHours = ExtraHours;
            twd.EmployeeCode = EmployeeCode;
            twd.WeekNumber = WeekNumber;
            twd.Year = Year;

            DAOWeekDetail dwd = new DAOWeekDetail();
            return dwd.SaveWeekDetail(twd);
        }

        /// <summary>
        /// Updates the week report.
        /// </summary>
        /// <returns>Boolean true if was updated, false if not</returns>
        public Boolean UpdateWeekReport()
        {
            TOWorkWeekDetail twd = new TOWorkWeekDetail();
            twd.Code = Code;
            twd.CCSSHours = CCSSHours;
            twd.TotalHours = TotalHours;
            twd.ExtraHours = ExtraHours;

            DAOWeekDetail dwd = new DAOWeekDetail();
            return dwd.UpdateWeekDetail(twd);
        }

        /// <summary>
        /// Gets the list of weeks
        /// </summary>
        /// <param name="weekNumber">The week number.</param>
        /// <returns>List<WorkWeekDetail> a list of weeks</returns>
        public List<WorkWeekDetail> getWeek(int weekNumber)
        {
            DAOWeekDetail daow = new DAOWeekDetail();
            TOWorkWeekDetail tow = new TOWorkWeekDetail();
            tow.WeekNumber = WeekNumber;

            List<TOWorkWeekDetail> listTO = daow.getWeekPerNumber(weekNumber);

            List<WorkWeekDetail> list = new List<WorkWeekDetail>();
            foreach (TOWorkWeekDetail week in listTO) {
                WorkWeekDetail w = new WorkWeekDetail();
                w.EmployeeCode = week.EmployeeCode;
                w.CCSSHours = week.CCSSHours;
                w.ExtraHours = week.ExtraHours;
                w.Name = week.Name;
                w.TotalHours = week.TotalHours;
                w.Code = week.Code;

                list.Add(w);
            }
            
            return list;
        }

        /// <summary>
        /// Gets the week numbers.
        /// </summary>
        /// <returns>List&lt;System.Int32&gt;.</returns>
        public List<int> getWeekNumbers()
        {
            DAOWeekDetail daow = new DAOWeekDetail();
            return daow.getWeekNumbers();
        }

        /// <summary>
        /// Gets the employee weeks.
        /// </summary>
        /// <param name="codeEmployee">The code employee.</param>
        /// <returns>List&lt;System.Int32&gt;.</returns>
        public List<int> getEmployeeWeeks(int codeEmployee)
        {
            DAOWeekDetail dao = new DAOWeekDetail();

            List<int> list = dao.getWeekNumbers(codeEmployee);
            return list;
        }

        /// <summary>
        /// Determines whether the specified week is complete.
        /// </summary>
        /// <param name="week">The week selected</param>
        /// <returns>Boolean true if its completed, false if not</returns>
        public Boolean isComplete(int week)
        {
            Boolean result = false;

            int calculatedDepartments = new DAOWorkDay().CalculatedDepartments(week);
            List<TODepartment> departments = new DADepartment().GetAllDepartments();
            int departmentsAmount = departments.Count;

            Boolean isWeekInTable = new DAOWeekDetail().isWeekSaved(week);

            if (calculatedDepartments == departmentsAmount && !isWeekInTable)
            {
                result = true;
            }

            return result;
        }
    }

    

}
