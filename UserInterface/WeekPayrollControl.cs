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
                dt.Columns.Add("No. Empleado");
                dt.Columns.Add("Nombre");
                dt.Columns.Add("Total Horas");
                dt.Columns.Add("Horas Regulares");
                dt.Columns.Add("Horas Extra");
                dt.Columns.Add("Cod. Reporte");

                foreach (WorkWeekDetail week in array)
                {
                    dt.Rows.Add(week.EmployeeCode, week.Name, week.TotalHours,  week.CCSSHours, week.ExtraHours, week.Code);
                }
                mg_weeks.DataSource = dt;
            }
            catch { }
        }

        private void mt_generate_Click(object sender, EventArgs e)
        {
            try
            {
                dt = new DataTable();
                dt.Columns.Add("No. Empleado");
                dt.Columns.Add("Nombre");
                dt.Columns.Add("Total Horas");
                dt.Columns.Add("Horas CCSS");
                dt.Columns.Add("Horas Extra");
                dt.Columns.Add("Cod. Reporte");

                list = week.getWeek(week_selected);

                foreach (WorkWeekDetail w in list)
                {
                    dt.Rows.Add(w.EmployeeCode, w.Name, w.TotalHours, w.CCSSHours, w.ExtraHours, w.Code);
                }
                mg_weeks.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Primero debe escoger una Semana");
            }
        }

        private void mg_weeks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = Int32.Parse(mg_weeks.SelectedRows[0].Index.ToString());
            int codeEmployee = Int32.Parse(mg_weeks.Rows[selectedRow].Cells[0].Value.ToString());
            int totalHours = Int32.Parse(mg_weeks.Rows[selectedRow].Cells[2].Value.ToString());
            int ordinaryHours = Int32.Parse(mg_weeks.Rows[selectedRow].Cells[3].Value.ToString());
            int extraHours = Int32.Parse(mg_weeks.Rows[selectedRow].Cells[4].Value.ToString());
            int weekDBCode = Int32.Parse(mg_weeks.Rows[selectedRow].Cells[5].Value.ToString());

            tb_filter.Text = "";
            new EmployeeWeekLaborDetail(week_selected, codeEmployee, totalHours, ordinaryHours, extraHours, weekDBCode, this).Show();

        }

        private void mbWeekReport_Click(object sender, EventArgs e)
        {
            generateReport(week_selected);
        }

        public void generateReport(int weekS)
        {
            try
            {
                dt = new DataTable();
                dt.Columns.Add("No. Empleado");
                dt.Columns.Add("Nombre");
                dt.Columns.Add("Total Horas");
                dt.Columns.Add("Horas CCSS");
                dt.Columns.Add("Horas Extra");
                dt.Columns.Add("Cod. Reporte");

                list = week.getWeek(weekS);

                foreach (WorkWeekDetail w in list)
                {
                    dt.Rows.Add(w.EmployeeCode, w.Name, w.TotalHours, w.CCSSHours, w.ExtraHours, w.Code);
                }
                mg_weeks.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Primero debe escoger una Semana");
            }
        }

        private void mbAnomaliesReview_Click(object sender, EventArgs e)
        {
            new AnomaliesReview().Show();
        }
    }
    
}
