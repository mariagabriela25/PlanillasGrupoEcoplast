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
using System.Globalization;

namespace UserInterface
{
    public partial class AnomaliesReview : MetroFramework.Forms.MetroForm
    {
        public DataTable dt;
        List<Anomaly> list;
        private DateTime currentDate;
        private int empcode;
        private string empname;

        public AnomaliesReview(List<Anomaly> list)
        {
            InitializeComponent();
            /////////////////////////////////
            this.list = list;
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
                    dt.Rows.Add(an.code, an.emp.Name + " " + an.emp.LastName, "    " + ci.DateTimeFormat.GetDayName(an.currentDay.DayOfWeek).ToUpper() + " " + an.currentDay.ToString("dd MMMM").ToUpper());
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

                String dateString = selectedRow.Cells["    Fecha"].Value.ToString();
                String[] dateStringVector = dateString.Split(' ');

                String month = dateStringVector[6];
                int convertedMonth = 0;

                switch (month)
                {
                    case "ENERO":
                        convertedMonth = 1;
                        break;
                    case "FEBRERO":
                        convertedMonth = 2;
                        break;
                    case "MARZO":
                        convertedMonth = 3;
                        break;
                    case "ABRIL":
                        convertedMonth = 4;
                        break;
                    case "MAYO":
                        convertedMonth = 5;
                        break;
                    case "JUNIO":
                        convertedMonth = 6;
                        break;
                    case "JULIO":
                        convertedMonth = 7;
                        break;
                    case "AGOSTO":
                        convertedMonth = 8;
                        break;
                    case "SEPTIEMBRE":
                        convertedMonth = 9;
                        break;
                    case "OCTUBRE":
                        convertedMonth = 10;
                        break;
                    case "NOVIEMBRE":
                        convertedMonth = 11;
                        break;
                    case "DICIEMBRE":
                        convertedMonth = 12;
                        break;
                }

                int tdtY = DateTime.Now.Year;
                int tdtM = convertedMonth;
                int tdtD = int.Parse(dateStringVector[5]);

                DateTime d = new DateTime(tdtY, tdtM, tdtD);

                //DateTime d = Convert.ToDateTime(selectedRow.Cells["    Fecha"].Value);

                empcode = a;
                empname = name;
                currentDate = d;

                lbchecks.Text = "";
                foreach (Anomaly item in list)
                {
                    if (item.code == a && item.currentDay.Equals(d))
                    {
                        lbFecha.Text = "Revisión para "+ name + " el "+ d.ToString("dd MMMM, yyyy");
                        lbJornada.Text = " para el " + d.ToString("dd MMMM, yyyy");
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
            WorkDayDetail wdd = new WorkDayDetail(empcode, totalHours, totalHours, currentDate, richTextBox1.Text, true, WeekCode(currentDate), 1);
            wdd.AddWorkDay();
            int a = 0;

            foreach (Anomaly an in list)
            {
                if (an.code == empcode && an.currentDay.Equals(currentDate))
                {
                    list.RemoveAt(a);
                    new AnomaliesManager().RemoveValue(an.code, an.currentDay);
                    break;
                }
                a++;
            }

            if (list.Count == 0)
            {
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

        private int WeekCode(DateTime date)
        {
            return System.Globalization.CultureInfo.CurrentUICulture.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
        }

        private void mgEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
