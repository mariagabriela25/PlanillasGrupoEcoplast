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
    public partial class MiddleStepReview : MetroFramework.Forms.MetroForm
    {
        public DataTable dt;
        List<LaboredDay> correctLaboredDays;
        List<Anomaly> list;
        List<Employee> listEmployees;

        public MiddleStepReview(List<LaboredDay> correctLaboredDays, List<Anomaly> list, List<Employee> listEmployees)
        {
            InitializeComponent();
            this.correctLaboredDays = correctLaboredDays;
            this.list = list;
            this.listEmployees = listEmployees;
        }

        private void MiddleStepReview_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add("#");
            dt.Columns.Add("Empleado");
            dt.Columns.Add("Entrada");
            dt.Columns.Add("Salida");
            dt.Columns.Add("Total de Horas");

            int foundCode = 0;
            String foundEmployeeName = "";
            Check entrance = new Check();
            Check exit = new Check();

            foreach (LaboredDay item in correctLaboredDays)
            {
                Employee currentEmp = new Employee();
                currentEmp.Code = item.employee;
                if (foundCode != currentEmp.Code)
                {
                    currentEmp = currentEmp.GetEmployee();
                    foundCode = currentEmp.Code;
                    foundEmployeeName = currentEmp.Name + " " + currentEmp.LastName;
                }
                foreach (Check itemC in item.checkedChecks)
                {
                    if (itemC.CheckType == "I")
                    {
                        entrance = itemC;
                    }
                    else if (itemC.CheckType == "O")
                    {
                        exit = itemC;
                    }
                }
                dt.Rows.Add(foundCode, foundEmployeeName, entrance.CheckTime.ToString(), exit.CheckTime.ToString(), item.ordinaryhours);
            }
            mgCorrectChecks.DataSource = dt;
            mgCorrectChecks.AutoResizeColumns();
            mgCorrectChecks.AutoResizeRows();

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "";
            checkBoxColumn.Width = 30;
            checkBoxColumn.Name = "checkBoxColumn";
            mgCorrectChecks.Columns.Insert(0, checkBoxColumn);

            foreach (DataGridViewRow row in mgCorrectChecks.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                chk.Value = !(chk.Value == null ? false : (bool)chk.Value); 
            }

        }

        private void mgCorrectChecks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mbSendAnomalies_Click(object sender, EventArgs e)
        {
            string message = string.Empty;
            foreach (DataGridViewRow row in mgCorrectChecks.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                if (isSelected)
                {
                    message += Environment.NewLine;
                    message += row.Cells[2].Value.ToString();
                }
            }

            MessageBox.Show("Selected Values" + message);
        }
    }
}
