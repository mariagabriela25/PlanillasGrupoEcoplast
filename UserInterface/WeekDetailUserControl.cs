using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace UserInterface
{
    public partial class WeekDetailUserControl : MetroFramework.Forms.MetroForm
    {

       private WorkDayDetail work_day;
       private WorkWeekDetail work_week;
       private List<Employee> list;
       private DataTable dt;
       private const int HORAS = 48;
        int codeE;
        public WeekDetailUserControl()
        {
            InitializeComponent();
        }

        private void WeekDetailUserControl_Load(object sender, EventArgs e)
        {
            work_day = new WorkDayDetail();
            work_week = new WorkWeekDetail();

            dt = new DataTable();
            dt.Columns.Add("Código del Empleado");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Apellido");
            dt.Columns.Add("Departamento");

            list = new Employee().GetAllEmployees();

            foreach (Employee empl in list)
            {
                dt.Rows.Add(empl.Code, empl.Name, empl.LastName, empl.Department.Name);
            }
            mg_employees.DataSource = dt;
        }

        private void filter(object sender, EventArgs e)
        {
            try
            {
                String filter = tb_filter.Text.Trim();
                var query = from l in list where l.Name.ToLower().StartsWith(filter.ToLower()) select l;
                mg_employees.DataSource = query.ToList();
            }
            catch { }
        }

        private void mg_selection(object sender, EventArgs e)
        {
                for (int i = 0; i < mg_employees.RowCount; i++)
                {
                    if (mg_employees.Rows[i].Selected)
                    {
                        String selected_employee = mg_employees.Rows[i].Cells[1].Value.ToString() + " " + mg_employees.Rows[i].Cells[2].Value.ToString();
                    codeE = Int32.Parse(mg_employees.Rows[i].Cells[0].Value.ToString());
                        tb_selection.Text = selected_employee;
                    }
                }
        }

        private void mt_calculate_Click(object sender, EventArgs e)
        {
            try
            {
                work_day.get_WorkDayUser(codeE, Int32.Parse(nudWeek.Value.ToString()));
                
                tb_week.Text = nudWeek.Value.ToString();
                ml_week.Visible = true;
                tb_week.Visible = true;

                int totalHours = Int32.Parse(work_day.TotalHours.ToString());

                int Extrahours = 0;
                if (totalHours - HORAS >= 0)
                {
                    Extrahours = totalHours - HORAS;
                }


                tb_ExtraHours.Text = Extrahours.ToString();
                ml_extra.Visible = true;
                tb_ExtraHours.Visible = true;

                if (totalHours < HORAS)
                {
                    tb_ordinaryHours.Text = totalHours.ToString();
                }
                else
                {
                    tb_ordinaryHours.Text = HORAS + "";
                }
                
                ml_total.Visible = true;
                tb_ordinaryHours.Visible = true;

            }
            catch (System.Data.SqlTypes.SqlNullValueException)
            {
                MessageBox.Show("No se encuentran Registros Asociados");
            }
            
        }

        private void mBtSaveWeekDetail_Click(object sender, EventArgs e)
        {
            int employeeCode = codeE;
            int weekNumber = Int32.Parse(tb_week.Text);
            double extraHours = Double.Parse(tb_ExtraHours.Text);
            double ordinaryHours = Double.Parse(tb_ordinaryHours.Text);
            int currentYear = new DateTime().Year;
            double totalHours = extraHours + ordinaryHours;

            work_week = new WorkWeekDetail(0,ordinaryHours,totalHours,extraHours,employeeCode,weekNumber,currentYear);
            Boolean saved = work_week.SaveWeekReport();

            if(saved)
            {
                MessageBox.Show("Detalle Guardado de forma correcta");
            }

            tb_week.Text = "";
            tb_ExtraHours.Text = "";
            tb_ordinaryHours.Text = "";
        }
    }
}

