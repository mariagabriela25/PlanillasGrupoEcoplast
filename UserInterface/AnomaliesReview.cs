﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using System.Globalization;

namespace UserInterface
{
    public partial class AnomaliesReview : MetroFramework.Forms.MetroForm
    {
        public DataTable dt;
        List<Anomaly> list;
        List<Employee> listEmployees;

        private DateTime currentDate;
        private int empcode;
        private string empname;
        private int weekcode;

        public AnomaliesReview(List<Anomaly> list, int weekcode, List<Employee> listEmployees)
        {
            InitializeComponent();
            /////////////////////////////////
            this.list = list;
            this.weekcode = weekcode;
            this.listEmployees = listEmployees;

        }

        private void AnomaliesReview_Load(object sender, EventArgs e)
        {


       
            dt = new DataTable();
            dt.Columns.Add("Código");
            dt.Columns.Add("Nombre completo");
            dt.Columns.Add("    Fecha");

            CultureInfo ci = new CultureInfo("Es-Es");


            foreach (Anomaly an in list)
            {
                dt.Rows.Add(an.code, an.emp.Name +" "+ an.emp.LastName,"    "+ ci.DateTimeFormat.GetDayName(an.currentDay.DayOfWeek).ToUpper() +" "+an.currentDay.ToString("dd MMMM").ToUpper());
            }

            mgEmployee.DataSource = dt;

            mgEmployee.AutoResizeColumns();
            mgEmployee.AutoResizeRows();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void gbSchedules_Enter(object sender, EventArgs e)
        {

        }

        private void mgEmployee_SelectionChanged(object sender, EventArgs e)
        {
            if (mgEmployee.SelectedCells.Count > 0)
            {
                int selectedrowindex = mgEmployee.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = mgEmployee.Rows[selectedrowindex];
                int a = Convert.ToInt32(selectedRow.Cells["Código"].Value);
                String name = Convert.ToString(selectedRow.Cells["Nombre completo"].Value);
                DateTime d = Convert.ToDateTime(selectedRow.Cells["    Fecha"].Value);
                empcode = a;
                empname = name;
                currentDate = d;

                lbchecks.Text = "";
                foreach (Anomaly item in list)
                {
                    if (item.code == a && item.currentDay.Equals(d))
                    {
                        lbFecha.Text = "Revisión para "+ name + " el "+ d.ToString("dd MMMM, yyyy");
                        lbJornada.Text = " para jornada del " + d.ToString("dd MMMM, yyyy");
                        Employee em = new Employee();
                        em.Code = a;
                        em = em.GetEmployee();
                        gbSchedules.Text = "Horarios para: " + em.Department.Name.ToUpper();

                        List<Schedule> schedules = new Schedule().GetDepSchedules(em.Department.Code);
                        lblist.Text = "";
                        foreach (Schedule s in schedules)
                        {
                            lblist.Text += "\n -> Hora de inicio: " + s.InitialHour.ToString("HH:mm") +"  |   Hora de salida: "+ s.finalHour.ToString("HH:mm") +" <-\n";
                        }

                        List<Check> checks = new Check().GetChecks(em.Code, d + new TimeSpan(0, 0, 0), d.AddDays(1).Date + new TimeSpan(23,59,59));
                        foreach (Check c in checks)
                        {
                            if (c.CheckType == "I")
                            {
                                lbchecks.Text += "→ " + c.CheckTime.ToString("dd /MMMM /yyyy  -  HH:MM:ss") + "\n";
                            }
                            else {
                                lbchecks.Text += "← " + c.CheckTime.ToString("dd /MMMM /yyyy  -  HH:MM:ss") + "\n"; }
                        }

                    }
                }

            } 


        }

        private void linkRests_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new BreakChecks(empname, empcode, currentDate).Visible =true;
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            double totalHours = calculateTotal();
            WorkDayDetail wdd = new WorkDayDetail(empcode, totalHours, totalHours, currentDate, richTextBox1.Text, true, weekcode, 1);
            wdd.AddWorkDay();
            int a = 0;

            foreach (Anomaly an in list)
            {
                if (an.code == empcode && an.currentDay.Equals(currentDate))
                {
                    list.RemoveAt(a);  
                    break;
                }
                a++;
            }

            if (list.Count == 0)
            {
                SaveWeeks();
                this.Close();
            }

            mgEmployee.DataSource = null;

            dt = new DataTable();
            dt.Columns.Add("Código");
            dt.Columns.Add("Nombre completo");
            dt.Columns.Add("    Fecha");

            CultureInfo ci = new CultureInfo("Es-Es");


            foreach (Anomaly an in list)
            {
                dt.Rows.Add(an.code, an.emp.Name + " " + an.emp.LastName, "    " + ci.DateTimeFormat.GetDayName(an.currentDay.DayOfWeek).ToUpper() + " " + an.currentDay.ToString("dd MMMM").ToUpper());
            }

            mgEmployee.DataSource = dt;

            mgEmployee.AutoResizeColumns();
            mgEmployee.AutoResizeRows();

        }

        private double calculateTotal() {
            double full = double.Parse(fullHour.Value.ToString());
            double half = 0;
            if (double.Parse(halfHour.Value.ToString()) == 0)
            {
                half = 0;
            }
            else {
                half = 0.5;
                    }

            return full+half;
        }

        public void SaveWeeks()
        {
            foreach (Employee emp in listEmployees)
            {
                double total = new Employee().GetTotalHours(emp.Code, weekcode);
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
                new WorkWeekDetail(1, ccss, total, extras, emp.Code, weekcode, DateTime.Now.Year).SaveWeekReport();
            }
            MessageBox.Show("Se guardó el detalle de la semana");

        }
    }
}
