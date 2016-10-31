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
        private List<Employee> list;

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

            list = new Employee().GetAllEmployees();

            foreach (Employee empl in list)
            {
                dt.Rows.Add(empl.Code, empl.Name, empl.LastName, empl.Department.Name);
            }
            mgEmployees.DataSource = dt;
        }


        private void mtAdd_Click(object sender, EventArgs e)
        {
            new AddEmployeeForm(this).Show();
        }

        private void mgEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                dt.Columns.Add("Código del Empleado");
                dt.Columns.Add("Nombre");
                dt.Columns.Add("Apellido");
                dt.Columns.Add("Departamento");

                foreach (Employee empl in array)
                {
                    dt.Rows.Add(empl.Code, empl.Name, empl.LastName, empl.Department.Name);
                }
                mgEmployees.DataSource = dt;   
            }
            catch { }
        }

        private void mtRefresh_Click(object sender, EventArgs e)
        {
            mgEmployees.DataSource = null;
            refresh();
        }

        private void mtDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < mgEmployees.RowCount; i++)
            {
                if (mgEmployees.Rows[i].Selected)
                {
                    if (MessageBox.Show("¿Está seguro de que desea eliminar este Empleado?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Employee empl = new Employee();
                        empl.Code = int.Parse(mgEmployees.Rows[i].Cells[0].Value.ToString());
                        empl.DeleteEmployee();
                        refresh();
                    }
                }

            }
        }

        private void mtModify_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < mgEmployees.RowCount; i++)
            {
                if (mgEmployees.Rows[i].Selected)
                {
                    new ModifyEmployeeForm(int.Parse(mgEmployees.Rows[i].Cells[0].Value.ToString()), this).Show();   
                }
            }

        }
    }
}
