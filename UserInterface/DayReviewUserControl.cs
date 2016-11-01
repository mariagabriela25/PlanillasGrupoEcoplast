﻿using System;
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
        public DayOfWeek firstDayOfWeek;
        public List<Anomaly> list;
        public List<Employee> employees;

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
            list = new List<Anomaly>();
            SundayDate = CalcWeekNum(WeekNum);
            CodDepartment = ((Department)cbDepart.SelectedItem).Code;
            employees = new Employee().GetEmployeesDep(CodDepartment);
            mpgCalculation.Maximum = employees.Count;
            mpgCalculation.Value = 0;
            backgroundWorker2.RunWorkerAsync();
            mbCheck.Enabled = false;
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
            int cont = 0;
            foreach (Employee em in employees)
            {
                Boolean test = new ValidationProcess(WeekNum, SundayDate, CodDepartment, em.Code, list).core();
                backgroundWorker2.ReportProgress(++cont);
                System.Threading.Thread.Sleep(5);
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
            mnWeekNum.Value = 1;
            new AnomaliesReview(list, WeekNum).Show();
        }
    }
}
