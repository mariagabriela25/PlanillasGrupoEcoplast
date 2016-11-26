using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using BusinessLogic;

namespace UserInterface
{
    public partial class DayReviewUserControl : MetroFramework.Forms.MetroForm
    {

        private int WeekNum;
        private DateTime EstandarDate;
        private DateTime SundayDate;
        public int CodDepartment;
        public DayOfWeek firstDayOfWeek;
        public List<Anomaly> list;
        public List<Employee> employees;

        public List<LaboredDay> listCorrectDays;

        public DayReviewUserControl()
        {
            InitializeComponent();
            EstandarDate = DateTime.Now;
            firstDayOfWeek = DayOfWeek.Monday;
            System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-CR");
        }

        public DayReviewUserControl(MiddleStepReview msr)
        {
            InitializeComponent();
            EstandarDate = DateTime.Now;
            firstDayOfWeek = DayOfWeek.Monday;
            System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-CR");
            msr.Dispose();
        }

        private void mbCheck_Click(object sender, EventArgs e)
        {
            WeekNum = Int32.Parse(mnWeekNum.Text);
            CodDepartment = ((Department)cbDepart.SelectedItem).Code;
            
            if (new AnomaliesManager().DepartmentInAnomaly(CodDepartment) || new WorkDayDetail().isDepartmentRegistered(CodDepartment, WeekNum))
            {
                MessageBox.Show("¡Ya se calcularon las horas laboradas en este departamento en la semana " + mnWeekNum.Text + "! Elija otro departamento para continuar...");
            }
            else
            {
                WeekNum = Int32.Parse(mnWeekNum.Text);
                list = new List<Anomaly>();
                listCorrectDays = new List<LaboredDay>();
                SundayDate = CalcWeekNum(WeekNum);
                employees = new Employee().GetEmployeesDep(CodDepartment);
                mpgCalculation.Maximum = employees.Count;
                mpgCalculation.Value = 0;
                backgroundWorker2.RunWorkerAsync();
                mbCheck.Enabled = false;
            }
        }

        public DateTime CalcWeekNum(int weeknum)
        {
            EstandarDate = EstandarDate.AddDays(DayOfWeek.Sunday - EstandarDate.DayOfWeek);

            int week = new GregorianCalendar().GetWeekOfYear(EstandarDate, CalendarWeekRule.FirstDay, firstDayOfWeek);
            if (weeknum != week)
            {
                EstandarDate = EstandarDate.AddDays((weeknum - week) * 7);
            }

            return EstandarDate;
        }

        private void DayReviewUserControl_Load(object sender, EventArgs e)
        {
            mnWeekNum.Text = (System.Globalization.CultureInfo.CurrentUICulture.Calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstDay, DayOfWeek.Monday) -1) + "";
            List<Department> list = new Department().GetAllDepartment();
            cbDepart.DisplayMember = "Name";
            cbDepart.ValueMember = "Code";
            foreach (Department d in list)
            {
                cbDepart.Items.Add(d);
            }

            backgroundWorker2.WorkerReportsProgress = true;

        }

        private void cbDepart_SelectedIndexChanged(object sender, EventArgs e)
        {
            mbCheck.Enabled = true;

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            int cont = 0;
            foreach (Employee em in employees)
            {
                ValidationProcess testProcess = new ValidationProcess(WeekNum, SundayDate, CodDepartment, em.Code, list, listCorrectDays);
                Boolean test = testProcess.core();
                listCorrectDays = testProcess.correctLaboredDays;
                backgroundWorker2.ReportProgress(++cont);
                System.Threading.Thread.Sleep(100);
            }
        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            mpgCalculation.Value = e.ProgressPercentage;
            this.label1.Text = e.ProgressPercentage.ToString() + "/" + mpgCalculation.Maximum;
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            mbCheck.Enabled = true;
            cbDepart.SelectedItem = null;
            if (listCorrectDays.Count > 0)
            {
                new MiddleStepReview(listCorrectDays, employees, WeekNum).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("¡No se registraron MARCAS CORRECTAS para este departamento!");
                List<Anomaly> anomaliesGottenList = new AnomaliesManager().GetValues();
                if (anomaliesGottenList.Count != 0)
                {
                    this.Hide();
                    new AnomaliesReview(anomaliesGottenList).Show();
                }
                else
                {
                    MessageBox.Show("¡No se registraron ANOMALÍAS para este departamento!");
                }

            }
        }

    }
}
