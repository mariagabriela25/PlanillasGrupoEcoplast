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
    public partial class EmployeeWeekLaborDetail : MetroFramework.Forms.MetroForm
    {
        int week;
        int codeE;
        DateTime iniRange;
        DateTime finRange;
        Employee emp;

        int totalH;
        int ordinaryH;
        int extraH;

        Boolean changesDay1 = false;
        Boolean changesDay2 = false;
        Boolean changesDay3 = false;
        Boolean changesDay4 = false;
        Boolean changesDay5 = false;
        Boolean changesDay6 = false;
        Boolean changesDay7 = false;

        public EmployeeWeekLaborDetail(int weekSelected, int codeEmployee, int totalHours, int ordinaryHours, int extraHours)
        {
            InitializeComponent();
            week = weekSelected;
            codeE = codeEmployee;
            finRange = new DateTime();
            totalH = totalHours;
            ordinaryH = ordinaryHours;
            extraH = extraHours;
        }

        private void EmployeeWeekLaborDetail_Load(object sender, EventArgs e)
        {
            emp = new Employee();
            emp.Code = codeE;
            emp = emp.GetEmployee();

            lbDepartment.Text = emp.Department.Name;
            lbNumberNameEmployee.Text = emp.Code + "  " + emp.Name + " " + emp.LastName;
            lbWeekNo.Text = week + "";
            lbYear.Text = "Año "+ DateTime.Now.Year.ToString();

            txtOrdinaryHours.Text = ordinaryH + "";
            txtExtraHours.Text = extraH + "";
            txtTotalHours.Text = totalH + "";

            List<WorkDayDetail> daysList = new List<WorkDayDetail>();
            WorkDayDetail work = new WorkDayDetail();
            daysList = work.getWeeks(codeE, week);

            int i = 1;
            for (int n = 0; i < daysList.Count; n++)
            {
                if (i==1)
                {
                    setLabels(lbDay1, daysList[i].Day, lbDate1, daysList[i].Date.ToString(),
                        lbH1, txtHours1, daysList[i].TotalHours, lbN1, txtNote1, daysList[i].Note,
                        lbCodeDB1, daysList[i].ID);
                    iniRange = new DateTime(daysList[i].Date.Year, daysList[i].Date.Month, daysList[i].Date.Day, 0,0,0);
                }
                else if (i == 2)
                {
                    setLabels(lbDay2, daysList[i].Day, lbDate2, daysList[i].Date.ToString(),
                        lbH2, txtHours2, daysList[i].TotalHours, lbN2, txtNote2, daysList[i].Note,
                        lbCodeDB2, daysList[i].ID);
                    finRange = new DateTime(daysList[i].Date.Year, daysList[i].Date.Month, daysList[i].Date.Day, 0, 0, 0);
                }
                else if (i == 3)
                {
                    setLabels(lbDay3, daysList[i].Day, lbDate3, daysList[i].Date.ToString(),
                        lbH3, txtHours3, daysList[i].TotalHours, lbN3, txtNote3, daysList[i].Note,
                        lbCodeDB3, daysList[i].ID);
                    separator1.Visible = true;
                    finRange = new DateTime(daysList[i].Date.Year, daysList[i].Date.Month, daysList[i].Date.Day, 0, 0, 0);
                }
                else if (i == 4)
                {
                    setLabels(lbDay4, daysList[i].Day, lbDate4, daysList[i].Date.ToString(),
                        lbH4, txtHours4, daysList[i].TotalHours, lbN4, txtNote4, daysList[i].Note,
                        lbCodeDB4, daysList[i].ID);
                    finRange = new DateTime(daysList[i].Date.Year, daysList[i].Date.Month, daysList[i].Date.Day, 0, 0, 0);
                }
                else if (i == 5)
                {
                    setLabels(lbDay5, daysList[i].Day, lbDate5, daysList[i].Date.ToString(),
                        lbH5, txtHours5, daysList[i].TotalHours, lbN5, txtNote5, daysList[i].Note,
                        lbCodeDB5, daysList[i].ID);
                    separator2.Visible = true;
                    finRange = new DateTime(daysList[i].Date.Year, daysList[i].Date.Month, daysList[i].Date.Day, 0, 0, 0);
                }
                else if (i == 6)
                {
                    setLabels(lbDay6, daysList[i].Day, lbDate6, daysList[i].Date.ToString(),
                        lbH6, txtHours6, daysList[i].TotalHours, lbN6, txtNote6, daysList[i].Note,
                        lbCodeDB6, daysList[i].ID);
                    finRange = new DateTime(daysList[i].Date.Year, daysList[i].Date.Month, daysList[i].Date.Day, 0, 0, 0);
                }
                else if (i == 7)
                {
                    setLabels(lbDay7, daysList[i].Day, lbDate7, daysList[i].Date.ToString(),
                           lbH7, txtHours7, daysList[i].TotalHours, lbN7, txtNote7, daysList[i].Note,
                           lbCodeDB7, daysList[i].ID);
                    separator3.Visible = true;
                    finRange = new DateTime(daysList[i].Date.Year, daysList[i].Date.Month, daysList[i].Date.Day, 0, 0, 0);
                }
                i += 1;
            }
        }

        public void setLabels(Label lbDay, int day, Label lbDate, String date, Label lbH,
            TextBox txtHours, double tHours, Label lbN, TextBox txtNote, String note, Label lbCodeDB,
            int codeDay)
        {
            String rDay = "";
            switch (day)
            {
                case 1:
                    rDay = "Lunes";
                    break;
                case 2:
                    rDay = "Martes";
                    break;
                case 3:
                    rDay = "Miércoles";
                    break;
                case 4:
                    rDay = "Jueves";
                    break;
                case 5:
                    rDay = "Viernes";
                    break;
                case 6:
                    rDay = "Sábado";
                    break;
                case 7:
                    rDay = "Domingo";
                    break;
            }
            lbDay.Text = rDay;
            lbDate.Text = date;
            txtHours.Text = tHours + "";
            txtNote.Text = note;
            lbCodeDB.Text = codeDay + "";

            lbDay.Visible = true;
            lbDate.Visible = true;
            lbH.Visible = true;
            txtHours.Visible = true;
            lbN.Visible = true;
            txtNote.Visible = true;
        }

        public void updateHoursDetail()
        {
            totalH = Int32.Parse(txtHours1.Text) + Int32.Parse(txtHours2.Text) + Int32.Parse(txtHours3.Text)
                + Int32.Parse(txtHours4.Text) + Int32.Parse(txtHours5.Text) + Int32.Parse(txtHours6.Text)
                + Int32.Parse(txtHours7.Text);

            extraH = totalH - 48;
            if (extraH < 0)
            {
                extraH = 0;
            }

            ordinaryH = totalH - extraH;

            txtOrdinaryHours.Text = ordinaryH + "";
            txtExtraHours.Text = extraH + "";
            txtTotalHours.Text = totalH + "";
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            changesDay6 = true;
        }

        private void mbRequestChecks_Click(object sender, EventArgs e)
        {
            ChecksRangeForm cForm = new ChecksRangeForm(emp, iniRange, finRange);
            cForm.Show();
        }

        private void txtHours1_TextChanged(object sender, EventArgs e)
        {
            changesDay1 = true;
        }

        private void txtNote1_TextChanged(object sender, EventArgs e)
        {
            changesDay1 = true;
        }

        private void txtHours2_TextChanged(object sender, EventArgs e)
        {
            changesDay2 = true;
        }

        private void txtNote2_TextChanged(object sender, EventArgs e)
        {
            changesDay2 = true;
        }

        private void txtHours3_TextChanged(object sender, EventArgs e)
        {
            changesDay3 = true;
        }

        private void txtNote3_TextChanged(object sender, EventArgs e)
        {
            changesDay3 = true;
        }

        private void txtHours4_TextChanged(object sender, EventArgs e)
        {
            changesDay4 = true;
        }

        private void txtNote4_TextChanged(object sender, EventArgs e)
        {
            changesDay4 = true;
        }

        private void txtHours5_TextChanged(object sender, EventArgs e)
        {
            changesDay5 = true;
        }

        private void txtNote5_TextChanged(object sender, EventArgs e)
        {
            changesDay5 = true;
        }

        private void txtHours6_TextChanged(object sender, EventArgs e)
        {
            changesDay6 = true;
        }

        private void txtHours7_TextChanged(object sender, EventArgs e)
        {
            changesDay7 = true;
        }

        private void txtNote7_TextChanged(object sender, EventArgs e)
        {
            changesDay7 = true;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //Validar cuales campos de texto cambiaron para poder ser modificados en la base
        }
    }
}
