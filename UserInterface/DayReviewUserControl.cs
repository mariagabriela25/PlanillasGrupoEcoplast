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
    public partial class DayReviewUserControl : UserControl
    {

        private int WeekNum;
        private DateTime EstandarDate;
        private DateTime SundayDate;
        public int CodDepartment;
        DayOfWeek firstDayOfWeek;

        public DayReviewUserControl()
        {
            InitializeComponent();
            EstandarDate = DateTime.Now;
            firstDayOfWeek = DayOfWeek.Monday;
            System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-CR");
        }

        private void mbCheck_Click(object sender, EventArgs e)
        {
            WeekNum = Int32.Parse(mnWeekNum.Value.ToString());
            SundayDate = CalcWeekNum(WeekNum);
            CodDepartment = ((Department)cbDepart.SelectedItem).Code;

            backgroundWorker2.RunWorkerAsync();
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
            List<Employee> employees = new Employee().GetEmployeesDep(CodDepartment);
            int cont = 0;
            foreach (Employee em in employees)
            {
                Boolean test = new ValidationProcess(WeekNum, SundayDate, CodDepartment, em.Code).core();
                backgroundWorker2.ReportProgress(cont);
                System.Threading.Thread.Sleep(25);
                cont++;
            }
        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            mpgCalculation.Value = e.ProgressPercentage;
            this.label1.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            new AnomaliesReview().Show();
        }
    }
}
