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
    public partial class ScheduleUserControl : UserControl
    {
        public ScheduleUserControl()
        {
            InitializeComponent();
        }

        private DataTable dt;

        private void mtAddSchedule_Click(object sender, EventArgs e)
        {
            new AddScheduleForm(this).Show();
        }

        private void ScheduleUserControl_Load(object sender, EventArgs e)
        {
            refresh();
        }
        public void refresh()
        {
            dt = new DataTable();
            dt.Columns.Add("Código");
            dt.Columns.Add("Entrada");
            dt.Columns.Add("Salida");
            dt.Columns.Add("H. Ordinarias");
            dt.Columns.Add("Departamento");

            List<Schedule> schedules = new Schedule().GetAllSchedules();

            foreach (Schedule s in schedules)
            {
                
                int iniHour = s.InitialHour.Hour;
                int iniMin = s.InitialHour.Minute;
                String iniHourString = "" +iniHour;
                String iniMinString = ""+iniMin;
                if (iniHour < 10)
                {
                    iniHourString = "0" + iniHour;
                }
                if (iniMin < 10)
                {
                    iniMinString = "0" + iniMin;
                }
                int finHour = s.finalHour.Hour;
                int finMin = s.finalHour.Minute;
                String finHourString = ""+finHour;
                String finMinString = ""+finMin;
                if (finHour < 10)
                {
                    finHourString = "0" + finHour;
                }
                if (finMin < 10)
                {
                    finMinString = "0" + finMin;
                }
                dt.Rows.Add(s.Code, iniHourString + ":" + iniMinString, finHourString + ":"+ finMinString, s.OrdinaryHours, s.Dept.Name);
            }
            mgSchedules.DataSource = dt;
        }

        private void mtUpdateSchedule_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < mgSchedules.RowCount; i++)
            {
                if (mgSchedules.Rows[i].Selected)
                {
                    new ModifyScheduleForm(mgSchedules.Rows[i].Cells[0].Value.ToString(), this).Show();
                }
            }
        }

        private void mtDeleteSchedule_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < mgSchedules.RowCount; i++)
            {
                if (mgSchedules.Rows[i].Selected)
                {
                    if (MessageBox.Show("¿Seguro desea eliminar este horario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Schedule s = new Schedule();
                        s.Code = mgSchedules.Rows[i].Cells[0].Value.ToString();
                        s.DeleteSchedule();
                        refresh();
                    }
                }

            }
        }

        private void mgSchedules_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
