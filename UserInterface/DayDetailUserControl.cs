using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using System.Globalization;

namespace UserInterface
{
    public partial class DayDetailUserControl : MetroFramework.Forms.MetroForm
    {

        public DataTable dt;

        Employee employee;
        Schedule schedule;

        Check checkin;
        Check checkout;

        public TimeSpan worked;
        public TimeSpan expected;
        public TimeSpan allowedPositive;
        public TimeSpan allowedNegative;
        public TimeSpan penaltyPositive;
        public TimeSpan penaltyNegative;
        public TimeSpan interval;


        public DayDetailUserControl()
        {
            InitializeComponent();

            checkin = null;
            checkout = null;

            allowedPositive = new TimeSpan(0, 10, 0);
            allowedNegative = new TimeSpan(0, -10, 0);
            penaltyPositive = new TimeSpan(0, 30, 0);
            penaltyNegative = new TimeSpan(0, -30, 0);
            interval = new TimeSpan(0, 30, 0);
        }

        private void DayDetailUserControl_Load(object sender, EventArgs e)
        {
            List<Department> list = new Department().GetAllDepartment();
            mcbDepartment.DisplayMember = "Name";
            mcbDepartment.ValueMember = "Code";
            foreach (Department dep in list)
            {
                mcbDepartment.Items.Add(dep);
            }
        }

        private void mcbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            List<Schedule> list = new Schedule().GetDepSchedules(((Department)mcbDepartment.SelectedItem).Code);
            mcbSchedule.Items.Clear();
            mcbSchedule.DisplayMember = "Code";
            mcbSchedule.ValueMember = "Code";

            foreach (Schedule s in list)
            {
                mcbSchedule.Items.Add(s);
            }
        }

        private void mcbSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Employee> list = new Employee().GetEmployeesDep(((Department)mcbDepartment.SelectedItem).Code);
            mcbEmployee.Items.Clear();
            mcbEmployee.DisplayMember = "Name";
            mcbEmployee.ValueMember = "Code";

            foreach (Employee empl in list)
            {
                mcbEmployee.Items.Add(empl);
            }
        }

        private void mbCalculate_Click(object sender, EventArgs e)
        {

            checkin = null;
            checkout = null;

            employee = (Employee)mcbEmployee.SelectedItem;
            schedule = (Schedule)mcbSchedule.SelectedItem;
            
            DateTime initialDay = mdtDay.Value;

            TimeSpan timein = new TimeSpan(schedule.InitialHour.Hour - 1, schedule.InitialHour.Minute, 0);
            initialDay = initialDay.Date + timein;


            DateTime finalDay = new DateTime();

            if (schedule.InitialHour.Hour >= schedule.finalHour.Hour)
            {
                finalDay = initialDay.AddDays(1);
            } else
            {
                finalDay = initialDay;
            }

            TimeSpan timeout = new TimeSpan(23, 59, 59);
            finalDay = finalDay.Date + timeout;

            //FillGrid(new Check().GetChecks(employee.Code, initialDay, finalDay));

            expected = schedule.finalHour.Subtract(schedule.InitialHour);
            mlWeekRange.Text = expected.ToString();

        }


        //public void FillGrid(List<Check> checks)
        //{
        //    dt = new DataTable();
        //    dt.Columns.Add("Origen");
        //    dt.Columns.Add("Marca Entrada");
        //    dt.Columns.Add("Descansos");
        //    dt.Columns.Add("Marca Salida");

        //    if (checks == null)
        //    {
        //        dt.Rows.Add("Empleado", "", "No existen marcas registradas para el dia", "");
        //        mgrWorkDayDetail.DataSource = dt;
        //        mgrWorkDayDetail.AutoResizeColumns();
        //        mbSave.Enabled = false;
        //    }
        //    else
        //    {

        //        List<Check> rests = new List<Check>();

        //        foreach (Check ch in checks)
        //        {
        //            String type = convertType(ch.CheckType);
        //            if (type.Equals("Entrada"))
        //            {
        //                checkin = ch;
        //            }
        //            else if (type.Equals("Salida"))
        //            {
        //                checkout = ch;
        //            }
        //            else
        //            {
        //                rests.Add(ch);
        //            }
        //        }

        //        if (checkout == null && checkin == null)
        //        {
        //            dt.Rows.Add("Empleado", "Marca Ausente", RestChecksFormat(rests), "Marca Ausente");
        //            dt.Rows.Add("Horario", schedule.InitialHour.TimeOfDay, schedule.RestList.Count, schedule.finalHour.TimeOfDay);

        //            DateTime entry = SetCheckIn(schedule.InitialHour, rests[0].CheckTime);
        //            DateTime exit = SetCheckOut(schedule.finalHour, rests[rests.Count - 1].CheckTime);
        //            worked = exit.Subtract(entry);
        //            mlWorkedRange.Text = worked.ToString();

        //        }
        //        else if (checkin == null)
        //        {

        //            dt.Rows.Add("Empleado", "Marca Ausente", RestChecksFormat(rests),
        //                String.Format("{0:T}", checkout.CheckTime));
        //            dt.Rows.Add("Horario", schedule.InitialHour.TimeOfDay, schedule.RestList.Count, schedule.finalHour.TimeOfDay);

        //            DateTime entry = SetCheckIn(schedule.InitialHour, rests[0].CheckTime);
        //            DateTime exit = SetCheckOut(schedule.finalHour, checkout.CheckTime);
        //            worked = exit.Subtract(entry);
        //            mlWorkedRange.Text = worked.ToString();

        //        }
        //        else if (checkout == null)
        //        {
        //            dt.Rows.Add("Empleado", String.Format("{0:T}", checkin.CheckTime),
        //                RestChecksFormat(rests), "Marca Ausente");
        //            dt.Rows.Add("Horario", schedule.InitialHour.TimeOfDay, schedule.RestList.Count, schedule.finalHour.TimeOfDay);

        //            DateTime entry = SetCheckIn(schedule.InitialHour, checkin.CheckTime);
        //            DateTime exit = SetCheckOut(schedule.finalHour, rests[rests.Count - 1].CheckTime);
        //            worked = exit.Subtract(entry);
        //            mlWorkedRange.Text = worked.ToString();

        //        }
        //        else
        //        {
        //            dt.Rows.Add("Empleado", String.Format("{0:T}", checkin.CheckTime),
        //                RestChecksFormat(rests),
        //                String.Format("{0:T}", checkout.CheckTime));
        //            dt.Rows.Add("Horario", schedule.InitialHour.TimeOfDay, schedule.RestList.Count, schedule.finalHour.TimeOfDay);

        //            DateTime entry = SetCheckIn(schedule.InitialHour, checkin.CheckTime);
        //            DateTime exit = SetCheckOut(schedule.finalHour, checkout.CheckTime);
        //            worked = exit.Subtract(entry);
        //            mlWorkedRange.Text = worked.ToString();
        //        }

        //        mgrWorkDayDetail.DataSource = dt;
        //        mgrWorkDayDetail.AutoResizeColumns();
        //        //mgrWorkDayDetail.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //        mbSave.Enabled = true;

        //    }
        //}

        public String RestChecksFormat(List<Check> list)
        {
            string txt = "";
            foreach(Check ch in list)
            {
                if (!txt.Equals(""))
                {
                    txt += ", ";
                }
                txt += String.Format("{0:T}", ch.CheckTime);
            }
            return txt;
        }

        public string convertType(string type)
        {
            if (type.Equals("I"))
            {
                return "Entrada";
            }
            else if (type.Equals("2"))
            {
                return "Descanso";
            }
            else
            {
                return "Salida";
            }
        }

        public DateTime SetCheckIn(DateTime timein, DateTime checkin)
        {
            TimeSpan range = timein.TimeOfDay.Subtract(checkin.TimeOfDay);
            if (range >= allowedNegative)
            {
                checkin = checkin.Date + timein.TimeOfDay;
            }
            else if (allowedNegative > range && range >= penaltyNegative)
            {
                checkin = checkin.Date + (timein.TimeOfDay + penaltyPositive);
            }
            else
            {
                checkin = Round(checkin);
            }
            return checkin;
        }

        public DateTime SetCheckOut(DateTime timeout, DateTime checkout) 
        {
            TimeSpan range = timeout.TimeOfDay.Subtract(checkout.TimeOfDay);
            if (penaltyNegative <= range && range <= allowedPositive)
            {
                checkout = checkout.Date + timeout.TimeOfDay;

            }
            else if (penaltyPositive >= range && range > allowedPositive)
            {
                checkout = checkout.Date + (timeout.TimeOfDay - penaltyPositive);
            }
            else
            {
                checkout = Round(checkout);
            }


            return checkout;
        }

        private DateTime Round(DateTime dateTime)
        {
            var halfIntervelTicks = ((interval.Ticks + 1) >> 1);

            return dateTime.AddTicks(halfIntervelTicks - ((dateTime.Ticks + halfIntervelTicks) % interval.Ticks));
        }

        private void mbSave_Click(object sender, EventArgs e)
        {
            WorkDayDetail workday = new WorkDayDetail();
            double hours = radioWorked.Checked ? worked.Hours + (worked.Minutes != 0 ? 0.5 : 0) : expected.Hours + (expected.Minutes != 0 ? 0.5 : 0);

            workday.CodeEmployee = ((Employee)mcbEmployee.SelectedItem).Code;
            workday.OrdinaryHours = hours;
            workday.TotalHours = hours;
            workday.Date = mdtDay.Value + new TimeSpan(0, 0, 0);
            workday.WeekCode = System.Globalization.CultureInfo.CurrentUICulture.Calendar.GetWeekOfYear(workday.Date, CalendarWeekRule.FirstDay, workday.Date.DayOfWeek) - 1;
            workday.Note = mtbNote.Text.Equals("") ? null : mtbNote.Text;
            workday.State = true;
            Boolean saved = workday.AddWorkDay();

            mtbNote.Text = "";
            mlWeekRange.Text = "";
            mlWorkedRange.Text = "";

            mgrWorkDayDetail.DataSource = null;

            if(saved)
            {
                MessageBox.Show("Detalle Guardado exitosamente");
            }

        }

        private void mcbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            mbCalculate.Enabled = true;
        }
    }
}
