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
            new AddScheduleForm().Show();
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
            dt.Columns.Add("H. Extras");
            dt.Columns.Add("Total de horas");
            dt.Columns.Add("Descansos");
            dt.Columns.Add("Departamento");

            List<Schedule> schedules = new Schedule().GetAllSchedules();

            foreach (Schedule s in schedules)
            {
                List<Rest> lr = s.RestList;
                String rests = "";
                foreach (var item in lr)
                {
                    rests += item.Minutes + ", ";
                }
                dt.Rows.Add(s.Code, s.InitialHour, s.finalHour, s.OrdinaryHours, s.ExtraHours, s.TotalHours, rests, s.Dept.Name);
            }
            mgSchedules.DataSource = dt;
        }

        private void mtUpdateSchedule_Click(object sender, EventArgs e)
        {
            mgSchedules.DataSource = null;
            refresh();
        }

        private void mtModifySchedule_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < mgSchedules.RowCount; i++)
            {
                if (mgSchedules.Rows[i].Selected)
                {
                    new ModifyScheduleForm(mgSchedules.Rows[i].Cells[0].Value.ToString()).Show();
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
    }
}
