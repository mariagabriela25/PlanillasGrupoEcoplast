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
    public partial class AddEmployeeForm : MetroFramework.Forms.MetroForm
    {
        EmployeeUserControl uc;

        public AddEmployeeForm(EmployeeUserControl euc)
        {
            InitializeComponent();
            uc = euc;
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {

            List<Department> list = new Department().GetAllDepartment();

            mcbDepart.DisplayMember = "Name";
            mcbDepart.ValueMember = "Code";
            foreach (Department dep in list)
            {
                mcbDepart.Items.Add(dep);
            }
        }

        private void mbSave_Click(object sender, EventArgs e)
        {
            Department de = (Department)mcbDepart.SelectedItem;
            new Employee(Int32.Parse(mtCod.Text), mtName.Text, mtLastName.Text, new Department(de.Code, de.Name)).AddEmployee();
            uc.refresh();
            this.Close();
        }
    }
}
