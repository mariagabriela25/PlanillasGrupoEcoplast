using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
   public class ValidationProcess
    {
        Check checkin;
        Check checkout;

      


        public TimeSpan worked;
        public TimeSpan expected;
        public TimeSpan allowedPositive;
        public TimeSpan allowedNegative;
        public TimeSpan penaltyPositive;
        public TimeSpan penaltyNegative;
        public TimeSpan interval;


        int weekNumber;

        DateTime lastDay;

        int department;

        List<Anomaly> weeklyAnomalies;



        public ValidationProcess(int weekNumber, DateTime lastDay, int departmentCode ) {
            checkin = null;
            checkout = null;

            allowedPositive = new TimeSpan(0, 10, 0);
            allowedNegative = new TimeSpan(0, -10, 0);
            penaltyPositive = new TimeSpan(0, 30, 0);
            penaltyNegative = new TimeSpan(0, -30, 0);
            interval = new TimeSpan(0, 30, 0);

            this.weekNumber = weekNumber;
            this.lastDay = lastDay;
            this.department = departmentCode;
        }


        private List<Anomaly> core(object sender, EventArgs e)
        {
            weeklyAnomalies = new List<Anomaly>();

            checkin = null;
            checkout = null;

            List<Employee> employees = new Employee().GetEmployeesDep(department);
            Schedule schedule = null;


            DateTime initialDay = lastDay.AddDays(-6);

          //  TimeSpan timein = new TimeSpan(schedule.InitialHour.Hour - 1, schedule.InitialHour.Minute, 0);
           // initialDay = initialDay.Date + timein;


            DateTime finalDay = new DateTime();

            if (schedule.InitialHour.Hour >= schedule.finalHour.Hour)
            {
                finalDay = initialDay.AddDays(1);
            }
            else
            {
                finalDay = initialDay;
            }

            TimeSpan timeout = new TimeSpan(23, 59, 59);
            finalDay = finalDay.Date + timeout;

           // FillGrid(new Check().GetChecks(employee.Code, initialDay, finalDay));

            expected = schedule.finalHour.Subtract(schedule.InitialHour);
            //  mlWeekRange.Text = expected.ToString();


            return weeklyAnomalies;
        }


    }
}
