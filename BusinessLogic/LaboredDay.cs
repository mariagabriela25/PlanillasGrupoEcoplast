
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    /// <summary>
    /// Class LaboredDay. Represents a Labored day in the system.
    /// </summary>
    public class LaboredDay
    {
        /// <summary>
        /// Gets or sets the checked checks.
        /// </summary>
        /// <value> List<Check> The checked checks</value>
        public List<Check> checkedChecks { get; set; }
        /// <summary>
        /// Gets or sets the employee's code of that day.
        /// </summary>
        /// <value>The code of the employee </value>
        public int employee { get; set; }
        /// <summary>
        /// Gets or sets the ordinaryhours.
        /// </summary>
        /// <value>The ordinaryhours</value>
        public double ordinaryhours { get; set; }
        /// <summary>
        /// Gets or sets the current day.
        /// </summary>
        /// <value>The current day.</value>
        public DateTime currentDay { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LaboredDay"/> class.
        /// </summary>
        /// <param name="employee">The employee's code</param>
        /// <param name="ordinaryhours">The ordinaryhours of the day</param>
        public LaboredDay(int employee, double ordinaryhours)
        {
            checkedChecks = new List<Check>();
            this.employee = employee;
            this.ordinaryhours = ordinaryhours;
        }

        /// <summary>
        /// Adds the checked check.
        /// </summary>
        /// <param name="newC">a new check</param>
        public void AddCheckedCheck(Check newC)
        {
            checkedChecks.Add(newC);
        }
        
    }
}
