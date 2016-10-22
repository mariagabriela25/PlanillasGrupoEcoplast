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

            //List<Check> checks = new Check().GetChecks(31, initialDay, finalDay);
        }

        public void FillGrid(List<Check> checks)
        {
            dt = new DataTable();
            dt.Columns.Add("Usuario");
            dt.Columns.Add("Marca");
            dt.Columns.Add("Tipo");

            foreach (Check ch in checks)
            {
              
                dt.Rows.Add(ch.ID, ch.CheckTime, convertType(ch.CheckType));
            }
            mgrWorkDayDetail.DataSource = dt;
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
    }
}
