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

namespace UserInterface
{
    public partial class DayDetailUserControl : UserControl
    {

        public DataTable dt;
        public DayDetailUserControl()
        {
            InitializeComponent();
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
            
            List<Schedule> list = new Schedule().GetAllSchedules();

            mcbSchedule.DisplayMember = "Code";
            mcbSchedule.ValueMember = "Code";

            foreach (Schedule s in list)
            {
                mcbSchedule.Items.Add(s);
            }
        }

        private void mcbSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Employee> list = new Employee().GetAllEmployees();

            mcbEmployee.DisplayMember = "Name";
            mcbEmployee.ValueMember = "Code";

            foreach (Employee empl in list)
            {
                mcbEmployee.Items.Add(empl);
            }
        }

        private void mbCalculate_Click(object sender, EventArgs e)
        {
            Employee employee = (Employee)mcbEmployee.SelectedItem;
            Schedule schedule = (Schedule)mcbSchedule.SelectedItem;

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


            FillGrid(new Check().GetChecks(31, initialDay, finalDay));

            TimeSpan expected = schedule.finalHour.Subtract(schedule.InitialHour);
            mlWeekRange.Text = expected.Hours.ToString();

        }


        public void FillGrid(List<Check> checks)
        {
            dt = new DataTable();
            dt.Columns.Add("Marca Entrada");
            dt.Columns.Add("Descansos");
            dt.Columns.Add("Marca Salida");
            
            List<Check> rests = new List<Check>();

            Check checkin = null;
            Check checkout = null;

            foreach (Check ch in checks)
            {
                String type = convertType(ch.CheckType);
                if (type.Equals("Entrada"))
                {
                    checkin = ch;
                }
                else if (type.Equals("Salida"))
                {
                    checkout = ch;
                }
                else
                {
                    rests.Add(ch);
                }
            }

            if (checkout == null && checkin == null)
            {
                dt.Rows.Add("Marca Ausente", RestChecksFormat(rests), "Marca Ausente");
            } else if(checkin == null)
            {
                dt.Rows.Add("Marca Ausente", RestChecksFormat(rests), 
                    String.Format("{0:T}", checkout.CheckTime));

                TimeSpan worked = checkout.CheckTime.Subtract(rests[0].CheckTime);
                worked = RoundTimeSpan(worked);
                mlWorkedRange.Text = worked.Hours.ToString();
            } else if (checkout == null)
            {
                dt.Rows.Add(String.Format("{0:T}", checkin.CheckTime),
                    RestChecksFormat(rests), "Marca Ausente");

                TimeSpan worked = rests[rests.Count - 1].CheckTime.Subtract(checkin.CheckTime);
                worked = RoundTimeSpan(worked);
                mlWorkedRange.Text = worked.Hours.ToString();

            } else
            {
                dt.Rows.Add(String.Format("{0:T}", checkin.CheckTime),
                    RestChecksFormat(rests),
                    String.Format("{0:T}", checkout.CheckTime));

                TimeSpan worked = checkout.CheckTime.Subtract(checkin.CheckTime);
                worked = RoundTimeSpan(worked);
                mlWorkedRange.Text = worked.Hours.ToString();
            }

            mgrWorkDayDetail.DataSource = dt;
            mgrWorkDayDetail.AutoResizeColumns();

        }
        public TimeSpan RoundTimeSpan(TimeSpan value)
        {
            return TimeSpan.FromMinutes(System.Math.Ceiling(value.TotalMinutes / 30) * 30);
        }
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

        private void mbSave_Click(object sender, EventArgs e)
        {
            WorkDayDetail workday = new WorkDayDetail();
            int hours = radioWorked.Checked ? Int32.Parse(mlWorkedRange.Text) : Int32.Parse(mlWeekRange.Text);

            workday.OrdinaryHours = hours;
            workday.TotalHours = hours;
            workday.Date = mdtDay.Value;
            workday.Note = mtbNote.Text;
            workday.AddWorkDay();

        }
    }
}
