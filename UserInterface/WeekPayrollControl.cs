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
    public partial class WeekPayrollControl : MetroFramework.Controls.MetroUserControl
    {

        List<WorkWeekDetail> list;
        private WorkWeekDetail week;
        private DataTable dt;
        int week_selected;

        public WeekPayrollControl()
        {
            InitializeComponent();
        }

        private void WeekPayrollControl_Load(object sender, EventArgs e)
        {
             week = new WorkWeekDetail();
            list = new List<WorkWeekDetail>();

            dt = new DataTable();
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Total Horas");
            dt.Columns.Add("Horas CCSS");
            dt.Columns.Add("Horas Extra");
            
            cbo_Weeks.DataSource = week.getWeekNumbers();
        }

        private void cbo_weekSelection(object sender, EventArgs e)
        {
            week_selected = (Int32) cbo_Weeks.SelectedValue;
        }

        private void filter(object sender, EventArgs e)
        {
            try
            {
                String filter = tb_filter.Text.Trim();
                var query = from l in list where l.Name.ToLower().StartsWith(filter.ToLower()) select l;
                var array = query.ToArray();

                dt = new DataTable();
                dt.Columns.Add("Nombre");
                dt.Columns.Add("Total Horas");
                dt.Columns.Add("Horas CCSS");
                dt.Columns.Add("Horas Extra");

                foreach (WorkWeekDetail week in array)
                {
                    dt.Rows.Add(week.Name, week.TotalHours,  week.CCSSHours, week.ExtraHours);
                }
                mg_weeks.DataSource = dt;
            }
            catch { }
        }

        private void mt_generate_Click(object sender, EventArgs e)
        {
            try
            {
                list = week.getWeek(week_selected);

                foreach (WorkWeekDetail w in list)
                {
                    dt.Rows.Add(w.Name, w.TotalHours, w.CCSSHours, w.ExtraHours);
                }
                mg_weeks.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Primero debe escoger una Semana");
            }
        }
        }
    
}
