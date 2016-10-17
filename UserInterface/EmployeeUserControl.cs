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
    public partial class EmployeeUserControl : MetroFramework.Controls.MetroUserControl
    {
        public EmployeeUserControl()
        {
            InitializeComponent();
        }

        private DataTable dt;

        private void EmployeeUserControl_Load(object sender, EventArgs e)
        {
            refresh();
        }
 
        public void refresh()
        {
            dt = new DataTable();
            dt.Columns.Add("Código del Empleado");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Apellido");
            dt.Columns.Add("Departamento");

            List<Employee> employees = new Employee().GetAllEmployees();

            foreach (Employee empl in employees)
            {
                dt.Rows.Add(empl.Code, empl.Name, empl.LastName, empl.Department.Name);
            }
            mgEmployees.DataSource = dt;
        }


        private void mtAdd_Click(object sender, EventArgs e)
        {

        }

        private void mgEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mtRefresh_Click(object sender, EventArgs e)
        {
            mgEmployees.DataSource = null;
            refresh();
        }
    }
}
