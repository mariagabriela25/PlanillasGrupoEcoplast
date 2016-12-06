
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLogic
{
    /// <summary>
    /// Class ValidationProcess.
    /// </summary>
    public class ValidationProcess
    {
        /// <summary>
        /// The checkin the check that represents an entrance
        /// </summary>
        Check checkin;
        /// <summary>
        /// The checkout the check that represents an exit
        /// </summary>
        Check checkout;
        /// <summary>
        /// The lastout the last check that represents an exit off all the lastouts.
        /// </summary>
        Check lastout;

        /// <summary>
        /// The allowed positive (after the hour of entrance)
        /// </summary>
        public TimeSpan allowedPositive;
        /// <summary>
        /// The allowed negative (before the hour of entrance)
        /// </summary>
        public TimeSpan allowedNegative;
        /// <summary>
        /// The penalty positive (after the entrance)
        /// </summary>
        public TimeSpan penaltyPositive;
        /// <summary>
        /// The penalty negative (before the entrance)
        /// </summary>
        public TimeSpan penaltyNegative;
        /// <summary>
        /// The interval
        /// </summary>
        public TimeSpan interval;


        /// <summary>
        /// The week number
        /// </summary>
        int weekNumber;

        /// <summary>
        /// The last week day
        /// </summary>
        DateTime lastWeekDay;
        /// <summary>
        /// The first week day
        /// </summary>
        DateTime firstWeekDay;

        /// <summary>
        /// The current day
        /// </summary>
        DateTime currentDay;
        /// <summary>
        /// The next day
        /// </summary>
        DateTime nextDay;

        /// <summary>
        /// The department
        /// </summary>
        int department;
        /// <summary>
        /// The employee 
        /// </summary>
        int employee;

        /// <summary>
        /// The weekly anomalies. A list of all the anomalies
        /// </summary>
        List<Anomaly> weeklyAnomalies;
        /// <summary>
        /// Gets or sets the correct labored days.
        /// </summary>
        /// <value>The correct labored days.</value>
        public List<LaboredDay> correctLaboredDays { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationProcess"/> class.
        /// </summary>
        /// <param name="weekNumber">The week number.</param>
        /// <param name="lastWeekDay">The last week day.</param>
        /// <param name="departmentCode">The department's code.</param>
        /// <param name="employeeCode">The employee's code.</param>
        /// <param name="list">The list of anomalies</param>
        /// <param name="correctDays">The correct days.</param>
        public ValidationProcess(int weekNumber, DateTime lastWeekDay, int departmentCode, int employeeCode, List<Anomaly> list, List<LaboredDay> correctDays) {

            allowedPositive = new TimeSpan(0, new ConfigManager().GetValue("allowedPositive"), 0);
            allowedNegative = new TimeSpan(0, -1 * new ConfigManager().GetValue("allowedNegative"), 0);
            penaltyPositive = new TimeSpan(0, new ConfigManager().GetValue("penaltyPositive"), 0);
            penaltyNegative = new TimeSpan(0, -1 * new ConfigManager().GetValue("penaltyNegative"), 0);

            interval = new TimeSpan(0, 30, 0);

            this.weekNumber = weekNumber;
            this.lastWeekDay = lastWeekDay;
            this.firstWeekDay = lastWeekDay.AddDays(-6);

            this.department = departmentCode;
            this.employee = employeeCode;

            weeklyAnomalies = list;
            correctLaboredDays = correctDays;

            
        }

        /// <summary>
        /// The process that validates the checks with the schedule of the employee
        /// </summary>
        /// <returns>Boolean true if the validation is correct, false if it is an anomaly</returns>
        public Boolean core()
        {
            checkin = null;
            checkout = null;
            lastout = new Check();

            List<Schedule> schedules = new Schedule().GetDepSchedules(department);

            TimeSpan timein = new TimeSpan(0, 0, 0);
            TimeSpan timeout = new TimeSpan(23, 59, 59);

            //MessageBox.Show("Empleado: " + employee);
            currentDay = firstWeekDay.Date + timein;
            nextDay = currentDay.AddDays(1).Date + timeout;

            while (currentDay <= lastWeekDay) {

                List<Check> checks = new Check().GetChecksWithRests(employee, currentDay, nextDay);
                if (checks == null)
                {
                    checkin = null;
                    checkout = null;

                    //MessageBox.Show("Dia no laborado, Dia: " + currentDay.Date);

                    currentDay = nextDay.Date + timein;
                    nextDay = nextDay.AddDays(1);
                   
                }
                else
                {
                    

                        for (int i = 0; i < checks.Count; i++)
                        {
                            if (!checks[i].CheckType.Equals("DS"))
                            {

                                if (checks[i].CheckTime.Date == currentDay && checkin == null && checks[i].CheckType.Equals("Entrada"))
                                {
                                    checkin = checks[i];
                                }
                                else if (checks[i].CheckType.Equals("Entrada") && checkin != null)
                                {
                                    break;
                                }
                                else if (checkin != null && checkout == null && checks[i].CheckType.Equals("Salida"))
                                {
                                    checkout = checks[i];
                                    lastout = checkout;
                                    break;
                                }
                            }
                        }

                        if (checkin != null && checkout != null)
                        {
                            bool flag = false;
                            for (int i = 0; i < schedules.Count; i++)
                            {

                                if (SetCheckIn(schedules[i].InitialHour, checkin.CheckTime) &&
                                    SetCheckOut(schedules[i].finalHour, checkout.CheckTime))
                                {

                                    flag = true;
                                    double ordinaryhours = schedules[i].OrdinaryHours;
                                    LaboredDay ld = new LaboredDay(employee, ordinaryhours);
                                    ld.AddCheckedCheck(checkin);
                                    ld.AddCheckedCheck(checkout);
                                    correctLaboredDays.Add(ld);
                                    ld.currentDay = currentDay;

                                    //new WorkDayDetail(employee, ordinaryhours, ordinaryhours, currentDay, null, true, weekNumber, 1).AddWorkDay();
                                    //MessageBox.Show("Dia Correcto, Dia: " + currentDay.Date);
                                    break;
                                }
                            }
                            if (!flag)
                            {
                                new AnomaliesManager().AddValue(employee, currentDay);
                                //MessageBox.Show("Intervalo invalido, Dia: " + currentDay.Date);

                            }

                        }

                        else if (checkin == null)
                        {
                            Boolean flag = false;
                            foreach (Check c in checks)
                            {
                                if (c.CheckType.Equals("Salida") && c.CheckTime != lastout.CheckTime)
                                {
                                    new AnomaliesManager().AddValue(employee, currentDay);
                                    flag = true;
                                    break;
                                    //MessageBox.Show("Marca Ausente, Dia: " + currentDay.Date);
                                }


                            }

                            if (!flag)
                            {
                                new AnomaliesManager().AddValue(employee, currentDay);
                                break;
                                //MessageBox.Show("Marca Ausente, Dia: " + currentDay.Date);
                            }
                        }

                        else if (checkin != null && checkout == null)

                        {
                            new AnomaliesManager().AddValue(employee, currentDay);

                            //messagebox.show("marca ausente, dia: " + currentday.date);
                        }

                        checkin = null;
                        checkout = null;

                        currentDay = nextDay.Date + timein;
                        nextDay = nextDay.AddDays(1);
                    }
                
            }
            return true;
        }

        /// <summary>
        /// Sets the check in after being formated
        /// </summary>
        /// <param name="timein">The time in</param>
        /// <param name="checkin">The check in.</param>
        /// <returns>Boolean.</returns>
        public Boolean SetCheckIn(DateTime timein, DateTime checkin)
        {
            TimeSpan range = timein.TimeOfDay.Subtract(checkin.TimeOfDay);
            if (allowedNegative <= range && range <= penaltyPositive)
            {
                return true;
            } else
            {
                return false;
            }
            
        }

        /// <summary>
        /// Sets the check out after being formated
        /// </summary>
        /// <param name="timeout">The timeout.</param>
        /// <param name="checkout">The checkout.</param>
        /// <returns>Boolean.</returns>
        public Boolean SetCheckOut(DateTime timeout, DateTime checkout)
        {
            TimeSpan range = timeout.TimeOfDay.Subtract(checkout.TimeOfDay);
            if (penaltyNegative <= range && range <= allowedPositive)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Rounds the specified date time.
        /// </summary>
        /// <param name="dateTime">The date time.</param>
        /// <returns>DateTime </returns>
        private DateTime Round(DateTime dateTime)
        {
            var halfIntervelTicks = ((interval.Ticks + 1) >> 1);

            return dateTime.AddTicks(halfIntervelTicks - ((dateTime.Ticks + halfIntervelTicks) % interval.Ticks));
        }

    }
}
