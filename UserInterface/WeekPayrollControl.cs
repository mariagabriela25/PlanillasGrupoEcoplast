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
using System.Windows.Controls;

namespace UserInterface
{
    public partial class WeekPayrollControl : MetroFramework.Controls.MetroUserControl
    {

        List<int> weeksExistence;
        List<WorkWeekDetail> list;
        private WorkWeekDetail week;
        private DataTable dt;
        int week_selected;
        int calculationWeek;

        public WeekPayrollControl()
        {
            InitializeComponent();
            DateTime date = DateTime.Now;
            calculationWeek = System.Globalization.CultureInfo.CurrentUICulture.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
            calculationWeek -= 1;
        }

    

        private void WeekPayrollControl_Load(object sender, EventArgs e)
        {
            mbCreateReport.Text += " " + calculationWeek;
            week = new WorkWeekDetail();
            list = new List<WorkWeekDetail>();
            weeksExistence = week.getWeekNumbers();
            
            foreach (int w in weeksExistence)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Content = w;
                cbo_Weeks.Items.Add(item);
            }
            cbo_Weeks.DisplayMember = "Content";
            
        }

        private void cbo_weekSelection(object sender, EventArgs e)
        {
         
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
            Double totalHours = Double.Parse(mg_weeks.Rows[selectedRow].Cells[2].Value.ToString());
            Double ordinaryHours = Double.Parse(mg_weeks.Rows[selectedRow].Cells[3].Value.ToString());
            Double extraHours = Double.Parse(mg_weeks.Rows[selectedRow].Cells[4].Value.ToString());
            int weekDBCode = Int32.Parse(mg_weeks.Rows[selectedRow].Cells[5].Value.ToString());

            tb_filter.Text = "";
            new EmployeeWeekLaborDetail(week_selected, codeEmployee, totalHours, ordinaryHours, extraHours, weekDBCode, this).Show();

        }

        private void mbWeekReport_Click(object sender, EventArgs e)
        {
            if (cbo_Weeks.SelectedItem != null)
            {
                ComboBoxItem selection = (ComboBoxItem)cbo_Weeks.SelectedItem;
                String selectionString = selection.Content.ToString();
                week_selected = int.Parse(selectionString);
                label2.Visible = true;
                tb_filter.Visible = true;
                generateReport(week_selected);
            }
            else
            {
                MessageBox.Show("Primero debe elegir la semana que desea consultar");
            }
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
            List<Anomaly> list = new AnomaliesManager().GetValues();
            if (list.Count() != 0)
            {
                new AnomaliesReview(list).Show();
            } else
            {
                MessageBox.Show("No existen anomalias pendientes");
            }
        }

        private void mbCreateReport_Click(object sender, EventArgs e)
        {
            if (new WorkWeekDetail().isComplete(calculationWeek))
            {
                List<int> eList = new Employee().getEmployeesCalculatedWeek(calculationWeek);

                foreach (int emp in eList)
                {
                    double total = new Employee().GetTotalHours(emp, calculationWeek);
                    double ccss = 48;
                    double extras = 0;
                    if (total <= 48)
                    {
                        ccss = total;
                    }
                    else
                    {
                        extras = total - ccss;
                    }
                    new WorkWeekDetail(1, ccss, total, extras, emp, calculationWeek, DateTime.Now.Year).SaveWeekReport();

                }
            }
            else
            {
                MessageBox.Show("¡Aún faltan departamentos de calcular o el reporte semanal para esta semana ya existe!");
            }
       
    }
    }
    
}
