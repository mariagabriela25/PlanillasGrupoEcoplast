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
    public partial class DepartmentUserControl : MetroFramework.Controls.MetroUserControl
    {

        private DataTable dt;

        public DepartmentUserControl()
        {
            InitializeComponent();
        }
        
        private void DepartmentUserControl_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void mtAdd_Click(object sender, EventArgs e)
        {
            new AddDepartmentForm(this).Show();
        }

        private void mtModify_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < mgDepartment.RowCount; i++)
            {
                if (mgDepartment.Rows[i].Selected)
                {
                    new ModifyDepartmentForm(int.Parse(mgDepartment.Rows[i].Cells[0].Value.ToString()), this).Show();
                }
            }
        }

        private void mtDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < mgDepartment.RowCount; i++)
            {
                if (mgDepartment.Rows[i].Selected)
                {
                    if (MessageBox.Show("¿Está seguro de que desea eliminar el departamento de "+ mgDepartment.Rows[i].Cells[1].Value.ToString() + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Department dep = new Department();
                        dep.Code = int.Parse(mgDepartment.Rows[i].Cells[0].Value.ToString());
                        dep.DeleteDepartment();
                        refresh();
                    }
                }

            }
        }

        public void refresh()
        {
            dt = new DataTable();
            dt.Columns.Add("Código Departamento");
            dt.Columns.Add("Nombre");

            List<Department> departments = new Department().GetAllDepartment();

            foreach (Department dep in departments)
            {
                dt.Rows.Add(dep.Code, dep.Name);
            }
            mgDepartment.DataSource = dt;
        }

       
    }
}
