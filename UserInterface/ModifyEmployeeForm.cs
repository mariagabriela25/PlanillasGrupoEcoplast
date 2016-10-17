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
        public ModifyEmployeeForm(int Code)
        {
            InitializeComponent();
            code = Code;
        }

        private void ModifyEmployeeForm_Load(object sender, EventArgs e)
        {
            List<Department> list = new Department().GetAllDepartment();

            mcbDepart.DisplayMember = "Name";
            mcbDepart.ValueMember = "Code";
            foreach (Department dep in list)
            {
                mcbDepart.Items.Add(dep);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea modificar el departamento del Empleado? " + code, "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Employee empl = new Employee();
                empl.Code = code;
                empl.Department = (Department)mcbDepart.SelectedItem;
                empl.ModifyEmployee();
                this.Close();
            }
        }
    }
}
