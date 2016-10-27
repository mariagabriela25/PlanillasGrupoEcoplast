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

        public TimeSpan allowedPositive;
        public TimeSpan allowedNegative;
        public TimeSpan penaltyPositive;
        public TimeSpan penaltyNegative;
        public TimeSpan interval;


        int weekNumber;

        DateTime lastWeekDay;
        DateTime firstWeekDay;

        DateTime currentDay;
        DateTime nextDay;

        int department;
        int employee;

        List<Anomaly> weeklyAnomalies;

        public ValidationProcess(int weekNumber, DateTime lastWeekDay, int departmentCode, int employeeCode) {

            allowedPositive = new TimeSpan(0, 10, 0);
            allowedNegative = new TimeSpan(0, -10, 0);
            penaltyPositive = new TimeSpan(1, 0, 0);
            penaltyNegative = new TimeSpan(0, -30, 0);
            interval = new TimeSpan(0, 30, 0);

            this.weekNumber = weekNumber;
            this.lastWeekDay = lastWeekDay;
            this.firstWeekDay = lastWeekDay.AddDays(-6);

            this.department = departmentCode;
            this.employee = employeeCode;

            weeklyAnomalies = new List<Anomaly>();

        }
        public Boolean core()
        {
            checkin = null;
            checkout = null;

            List<Schedule> schedules = new Schedule().GetDepSchedules(department);

            TimeSpan timein = new TimeSpan(0, 0, 0);
            TimeSpan timeout = new TimeSpan(23, 59, 59);
            
            currentDay = firstWeekDay.Date + timein;
            nextDay = currentDay.AddDays(1).Date + timeout;

            while (nextDay <= lastWeekDay) {

                List<Check> checks = new Check().GetChecks(employee, currentDay, nextDay);
                if (checks == null)
                {
                    return false;
                }
                else
                {


                    for (int i = 0; i < checks.Count; i++)
                    {

                        if (i == 0 && checkin == null && checks[i].CheckType.Equals("I"))
                        {
                            checkin = checks[i];
                        }
                        else if (i == 1 && checkout == null && checks[i].CheckType.Equals("O"))
                        {
                            checkout = checks[i];
                        }
                    }

                    if (checkin != null && checkout != null)
                    {
                        for (int i = 0; i < schedules.Count; i++)
                        {

                            if (SetCheckIn(schedules[i].InitialHour, checkin.CheckTime) &&
                                SetCheckOut(schedules[i].finalHour, checkout.CheckTime))
                            {
                                //VA A GUARDAR A LA BASE  
                            }
                            else
                            {
                                //LISTA DE ANOMALIAS
                            }
                        }

                    }
                    else
                    {
                        //VAYA ANOMALIA
                    }

                    checkin = null;
                    checkout = null;

                    currentDay = nextDay + timein;
                    nextDay = nextDay.AddDays(1);
                }
            }
            return true;
        }

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

        private DateTime Round(DateTime dateTime)
        {
            var halfIntervelTicks = ((interval.Ticks + 1) >> 1);

            return dateTime.AddTicks(halfIntervelTicks - ((dateTime.Ticks + halfIntervelTicks) % interval.Ticks));
        }

    }
}



            //if (schedule.InitialHour.Hour >= schedule.finalHour.Hour)
            //{
            //    finalDay = initialDay.AddDays(1);
            //}
            //else
            //{
            //    finalDay = initialDay;
            //}
