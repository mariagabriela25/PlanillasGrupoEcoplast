using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    /// <summary>
    /// Class Anomaly. This represents an anomaly in the system
    /// </summary>
    public class Anomaly
    {
        /// <summary>
        /// The current date of today
        /// </summary>
        public DateTime currentDay;
        /// <summary>
        /// The code of the anomaly
        /// </summary>
        public int code;
        /// <summary>
        /// The employee associated to the anomaly
        /// </summary>
        public Employee emp;
        /// <summary>
        /// the type of the anomaly
        /// </summary>
        public bool type;

        /// <summary>
        /// Initializes a new instance of the <see cref="Anomaly"/> class.
        /// </summary>
        /// <param name="currentday">The current day.</param>
        /// <param name="code">The code of the anomaly.</param>
        /// <param name="type">the type of the anomaly</param>
        public Anomaly(DateTime currentday, int code, bool type)
        {
            this.currentDay = currentday;
            this.code = code;
            this.type = type;
            Employee emp = new Employee();
            emp.Code = this.code;
            emp = emp.GetEmployee();
            this.emp = emp;
        }

    }

}
