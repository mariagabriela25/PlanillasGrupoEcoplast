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
using System.Threading;

namespace UserInterface
{
    public partial class MiddleStepReview : MetroFramework.Forms.MetroForm
    {
        public DataTable dt;
        List<LaboredDay> correctLaboredDays;
        List<Anomaly> list;
        List<Employee> listEmployees;
        int weekNum;

        public MiddleStepReview(List<LaboredDay> correctLaboredDays, List<Employee> listEmployees, int weekNumber)
        {
            InitializeComponent();
            this.correctLaboredDays = correctLaboredDays;
            this.listEmployees = listEmployees;
            this.weekNum = weekNumber;
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
            mgCorrectChecks.Columns.Insert(5, checkBoxColumn);

            foreach (DataGridViewRow row in mgCorrectChecks.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[5];
                chk.Value = !(chk.Value == null ? false : (bool)chk.Value); 
            }

        }

        void SendAnomalies()
        {
            mgCorrectChecks.Enabled = true;
            mbSendAnomalies.Enabled = true;

            string message = string.Empty;

            foreach (DataGridViewRow row in mgCorrectChecks.Rows)
            {
                int rowNumber = row.Index;

                bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                if (isSelected)
                {
                    new WorkDayDetail(Int32.Parse(row.Cells[0].Value.ToString()), Double.Parse(row.Cells[4].Value.ToString()), Double.Parse(row.Cells[4].Value.ToString()), correctLaboredDays[rowNumber].currentDay, null, true, weekNum, 1).AddWorkDay();
                }
                else
                {
                    new AnomaliesManager().AddValue(Int32.Parse(row.Cells[0].Value.ToString()), correctLaboredDays[rowNumber].currentDay);
                }
            }

            list = new AnomaliesManager().GetValues();
            
            Thread.Sleep(1000);
        }

        private void mbSendAnomalies_Click(object sender, EventArgs e)
        {
            using (var waitForm = new WaitForm(SendAnomalies))
            {
                waitForm.ShowDialog(this);
            }
            if (list.Count != 0)
            {
                this.Hide();
                new AnomaliesReview(list).Show();
            }
            else
            {
                SaveWeeks();
                this.Close();
            }
        }

        public void SaveWeeks()
        {
            foreach (Employee emp in listEmployees)
            {
                double total = new Employee().GetTotalHours(emp.Code, weekNum);
                double ccss = 48;
                double extras = 0;
                if (total <= 48)
                {
                    ccss = total;
                }
                else
                {
                    extras = total - ccss;
                }
                new WorkWeekDetail(1, ccss, total, extras, emp.Code, weekNum, DateTime.Now.Year).SaveWeekReport();
                
            }
            //MessageBox.Show("¡Se guardaron los días laborados seleccionados!");
        }
        
    }
}
