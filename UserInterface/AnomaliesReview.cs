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
    public partial class AnomaliesReview : MetroFramework.Forms.MetroForm
    {
        public DataTable dt;
        public AnomaliesReview()
        {
            InitializeComponent();
        }

        private void AnomaliesReview_Load(object sender, EventArgs e)
        {
            List<Employee> list = new Employee().GetAllEmployees();
            dt = new DataTable();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Nombre");

            foreach (Employee emp in list)
            {
                dt.Rows.Add(emp.Code, emp.Name + " " + emp.LastName);
            }
            mgEmployee.DataSource = dt;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void mtAnomalies_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("R/: " + mtAnomalies.SelectedTab.Name);
        }
    }
}
