using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
  public class Anomaly
    {
        int employeeCode;
        TimeSpan checkin;
        TimeSpan checkout;
        DateTime dayOfTheWeek;


        public Anomaly(int employeeCode, TimeSpan checkin, TimeSpan checkout, DateTime dayOfTheWeek) {
            this.employeeCode = employeeCode;
            this.checkin = checkin;
            this.checkout = checkout;
            this.dayOfTheWeek = dayOfTheWeek;
        }
    }
}
