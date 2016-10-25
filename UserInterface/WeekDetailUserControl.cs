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

        List<Employee> list;
        DataTable dt;
        int code;
        public WeekDetailUserControl()
        {
            InitializeComponent();
        }

        private void DayHoursForm_Load(object sender, EventArgs e)
        {
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
                        code = Int32.Parse(mg_employees.Rows[i].Cells[0].Value.ToString());
                        tb_selection.Text = code + " " + selected_employee;
                    }
                }
        }

        private void mt_calculate_Click(object sender, EventArgs e)
        {
            
        }
    }
}

