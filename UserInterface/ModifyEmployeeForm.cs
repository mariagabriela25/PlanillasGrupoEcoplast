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
    public partial class ModifyEmployeeForm : MetroFramework.Forms.MetroForm
    {
        private int code;
        EmployeeUserControl uc;

        public ModifyEmployeeForm(int Code, EmployeeUserControl euc)
        {
            InitializeComponent();
            code = Code;
            uc = euc;
        }

        private void ModifyEmployeeForm_Load(object sender, EventArgs e)
        {
            mLbEmployeeID.Text = code + "";

            Employee emp = new Employee();
            emp.Code = code;
            emp = emp.GetEmployee();
            txtEmployeeLastNames.Text = emp.LastName;
            txtEmployeeNames.Text = emp.Name;

            mcbDepart.DisplayMember = "Name";
            mcbDepart.ValueMember = "Code";

            mcbDepart.Items.Add(emp.Department);

            List<Department> list = new Department().GetAllDepartment();

            foreach (Department dep in list)
            {
                if (dep.Code != emp.Department.Code)
                {
                    mcbDepart.Items.Add(dep);
                }
            }

            mcbDepart.SelectedIndex = 0;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea modificar el Empleado #" + code + "? ", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtEmployeeNames.Text.Length != 0 && txtEmployeeLastNames.Text.Length != 0 && mcbDepart.SelectedItem != null)
                {
                    Employee empl = new Employee();
                    empl.Code = code;
                    empl.Department = (Department)mcbDepart.SelectedItem;
                    empl.Name = txtEmployeeNames.Text;
                    empl.LastName = txtEmployeeLastNames.Text;
                    empl.ModifyEmployee();
                    uc.refresh();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No deben haber espacios en blanco");
                }
            }
        }
    }
}
