﻿using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLogic
{
   public class ValidationProcess
    {
        Check checkin;
        Check checkout;
        Check lastout;

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
        public List<LaboredDay> correctLaboredDays { get; set; }

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
                        if (!checks[i].CheckType.Equals("2"))
                        {

                            if (checks[i].CheckTime.Date == currentDay && checkin == null && checks[i].CheckType.Equals("I"))
                            {
                                checkin = checks[i];
                            }
                            else if (checks[i].CheckType.Equals("I") && checkin != null)
                            {
                                break;
                            }
                            else if (checkin != null && checkout == null && checks[i].CheckType.Equals("O"))
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
                        if(!flag)
                        {
                            new AnomaliesManager().AddValue(employee, currentDay);
                            //MessageBox.Show("Intervalo invalido, Dia: " + currentDay.Date);

                        }

                    }

                    else if (checkin == null)
                    {
                        Boolean flag = false; 
                        foreach(Check c in checks)
                        {
                            if(c.CheckType.Equals("O") && c.CheckTime != lastout.CheckTime)
                            {
                                new AnomaliesManager().AddValue(employee, currentDay);
                                flag = true;
                                break;
                                //MessageBox.Show("Marca Ausente, Dia: " + currentDay.Date);
                            }

                            if (!flag)
                            {
                                new AnomaliesManager().AddValue(employee, currentDay);
                                break;
                                //MessageBox.Show("Marca Ausente, Dia: " + currentDay.Date);
                            }
                        }
                    }

                    //else
                    //{
                    //    new AnomaliesManager().AddValue(employee, currentDay);
                    //    //MessageBox.Show("Marca Ausente, Dia: " + currentDay.Date);
                    //}

                    checkin = null;
                    checkout = null;

                    currentDay = nextDay.Date + timein;
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
