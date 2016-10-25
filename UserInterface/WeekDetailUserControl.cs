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
                DateTime firstDate = Convert.ToDateTime(tb_firstDate.Text);
                DateTime lastDate = Convert.ToDateTime(tb_lastDate.Text);

                work_day.get_WorkDayUser(codeE, firstDate, lastDate);
                
                tb_week.Text = firstDate.ToShortDateString() + " al " + lastDate.ToShortDateString();
                ml_week.Visible = true;
                tb_week.Visible = true;

                int totalHours = Int32.Parse(work_day.TotalHours.ToString());

                tb_totalHours.Text = totalHours.ToString();
                ml_total.Visible = true;
                tb_totalHours.Visible = true;

                int Extrahours = 0;
                if (totalHours - HORAS >= 0)
                {
                    Extrahours = totalHours - HORAS;
                }


                tb_ExtraHours.Text = Extrahours.ToString();
                ml_extra.Visible = true;
                tb_ExtraHours.Visible = true;
               
            }
            catch (FormatException)
            {
                tb_firstDate.Text = "";
                tb_lastDate.Text = "";
                MessageBox.Show("Recuerde Digitar la fecha de manera correcta:  dia/mes/año");
            } catch (System.Data.SqlTypes.SqlNullValueException)
            {
                MessageBox.Show("No se encuentran Registros Asociados");
            }
            
        }

    }
}

