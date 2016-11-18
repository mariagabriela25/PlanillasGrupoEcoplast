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
        int weekReportCodeDB;

        int week;
        int codeE;
        DateTime iniRange;
        DateTime finRange;
        Employee emp;

        Double totalH;
        Double ordinaryH;
        Double extraH;

        bool changesDay1;
        bool changesDay2;
        bool changesDay3;
        bool changesDay4;
        bool changesDay5;
        bool changesDay6;
        bool changesDay7;

        int changesDay1C;
        int changesDay2C;
        int changesDay3C;
        int changesDay4C;
        int changesDay5C;
        int changesDay6C;
        int changesDay7C;

        WeekPayrollControl uc;

        public EmployeeWeekLaborDetail(int weekSelected, int codeEmployee, Double totalHours, Double ordinaryHours, Double extraHours, int weekDBCode, WeekPayrollControl uc)
        {
            InitializeComponent();
            week = weekSelected;
            codeE = codeEmployee;
            finRange = new DateTime();
            totalH = totalHours;
            ordinaryH = ordinaryHours;
            extraH = extraHours;
            weekReportCodeDB = weekDBCode;
            this.uc = uc;
        }

        private void EmployeeWeekLaborDetail_Load(object sender, EventArgs e)
        {
            changesDay1 = false;
            changesDay2 = false;
            changesDay3 = false;
            changesDay4 = false;
            changesDay5 = false;
            changesDay6 = false;
            changesDay7 = false;

            changesDay1C = 0;
            changesDay2C = 0;
            changesDay3C = 0;
            changesDay4C = 0;
            changesDay5C = 0;
            changesDay6C = 0;
            changesDay7C = 0;

            emp = new Employee();
            emp.Code = codeE;
            emp = emp.GetEmployee();

            lbDepartment.Text = emp.Department.Name;
            lbNumberNameEmployee.Text = emp.Code + "  " + emp.Name + " " + emp.LastName;
            lbWeekNo.Text = "Semana " + week + " (" + DateTime.Now.Year.ToString() + ")";

            lbTxtOrdinaryHours.Visible = true;
            lbTxtExtraHours.Visible = true;
            lbTxtTotalHours.Visible = true;

            lbTxtOrdinaryHours.Text = ordinaryH + "";
            lbTxtExtraHours.Text = extraH + "";
            lbTxtTotalHours.Text = totalH + "";

            List<WorkDayDetail> daysList = new List<WorkDayDetail>();
            WorkDayDetail work = new WorkDayDetail();
            daysList = work.getWeeks(codeE, week);

            int i = 1;
            for (int n = 0; n < daysList.Count; n++)
            {
                String dateShort = daysList[n].Date.Date.ToString();
                String sendDate = "";
                for (int x = 0; x < dateShort.Length; x++)
                {
                    sendDate += dateShort[x];
                    if (dateShort[x] == ' ')
                    {
                        break;
                    }
                }
                if (i==1)
                { 
                    setLabels(lbDay1, daysList[n].Day, lbDate1, sendDate,
                        lbH1, txtHours1, daysList[n].TotalHours, lbN1, txtNote1, daysList[n].Note,
                        lbCodeDB1, daysList[n].ID);
                    iniRange = new DateTime(daysList[n].Date.Year, daysList[n].Date.Month, daysList[n].Date.Day, 0,0,0);
                }
                else if (i == 2)
                {
                    setLabels(lbDay2, daysList[n].Day, lbDate2, sendDate,
                        lbH2, txtHours2, daysList[n].TotalHours, lbN2, txtNote2, daysList[n].Note,
                        lbCodeDB2, daysList[n].ID);
                    finRange = new DateTime(daysList[n].Date.Year, daysList[n].Date.Month, daysList[n].Date.Day, 0, 0, 0);
                }
                else if (i == 3)
                {
                    setLabels(lbDay3, daysList[n].Day, lbDate3, sendDate,
                        lbH3, txtHours3, daysList[n].TotalHours, lbN3, txtNote3, daysList[n].Note,
                        lbCodeDB3, daysList[n].ID);
                    finRange = new DateTime(daysList[n].Date.Year, daysList[n].Date.Month, daysList[n].Date.Day, 0, 0, 0);
                }
                else if (i == 4)
                {
                    setLabels(lbDay4, daysList[n].Day, lbDate4, sendDate,
                        lbH4, txtHours4, daysList[n].TotalHours, lbN4, txtNote4, daysList[n].Note,
                        lbCodeDB4, daysList[n].ID);
                    finRange = new DateTime(daysList[n].Date.Year, daysList[n].Date.Month, daysList[n].Date.Day, 0, 0, 0);
                }
                else if (i == 5)
                {
                    setLabels(lbDay5, daysList[n].Day, lbDate5, sendDate,
                        lbH5, txtHours5, daysList[n].TotalHours, lbN5, txtNote5, daysList[n].Note,
                        lbCodeDB5, daysList[n].ID);
                    finRange = new DateTime(daysList[n].Date.Year, daysList[n].Date.Month, daysList[n].Date.Day, 0, 0, 0);
                }
                else if (i == 6)
                {
                    setLabels(lbDay6, daysList[n].Day, lbDate6, sendDate,
                        lbH6, txtHours6, daysList[n].TotalHours, lbN6, txtNote6, daysList[n].Note,
                        lbCodeDB6, daysList[n].ID);
                    finRange = new DateTime(daysList[n].Date.Year, daysList[n].Date.Month, daysList[n].Date.Day, 0, 0, 0);
                }
                else if (i == 7)
                {
                    setLabels(lbDay7, daysList[n].Day, lbDate7, sendDate,
                           lbH7, txtHours7, daysList[n].TotalHours, lbN7, txtNote7, daysList[n].Note,
                           lbCodeDB7, daysList[n].ID);
                    finRange = new DateTime(daysList[n].Date.Year, daysList[n].Date.Month, daysList[n].Date.Day, 0, 0, 0);
                }
                i += 1;
            }
        }

        public void setLabels(Label lbDay, int day, Label lbDate, String date, Label lbH,
            NumericUpDown txtHours, double tHours, Label lbN, TextBox txtNote, String note, Label lbCodeDB,
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
            txtHours.Value = (Decimal)tHours;
            txtNote.Text = note;
            lbCodeDB.Text = codeDay + "";

            lbDay.Visible = true;
            lbDate.Visible = true;
            lbH.Visible = true;
            txtHours.Visible = true;
            lbN.Visible = true;
            txtNote.Visible = true;
        }

        public NumericUpDown getTextBox(int i)
        {
            NumericUpDown tbReturn = null;
            switch (i)
            {
                case 1:
                    tbReturn = txtHours1;
                    break;
                case 2:
                    tbReturn = txtHours2;
                    break;
                case 3:
                    tbReturn = txtHours3;
                    break;
                case 4:
                    tbReturn = txtHours4;
                    break;
                case 5:
                    tbReturn = txtHours5;
                    break;
                case 6:
                    tbReturn = txtHours6;
                    break;
                case 7:
                    tbReturn = txtHours7;
                    break;
            }
            return tbReturn;
        }

        public void updateHoursDetail()
        {
            totalH = 0;
            ordinaryH = 0;
            extraH = 0;
                
            for (int i = 1; i < 8; i++)
            {
                NumericUpDown tb = getTextBox(i);
                if (tb.Value != 0 && tb.Visible)
                {
                    totalH += (Double)tb.Value;
                }
            }

            extraH = totalH - 48;
            if (extraH < 0)
            {
                extraH = 0;
            }

            ordinaryH = totalH - extraH;

            lbTxtOrdinaryHours.Text = ordinaryH + "";
            lbTxtExtraHours.Text = extraH + "";
            lbTxtTotalHours.Text = totalH + "";
        }

        private void mbRequestChecks_Click(object sender, EventArgs e)
        {
            ChecksRangeForm cForm = new ChecksRangeForm(emp, iniRange, finRange.AddDays(1));
            cForm.Show();
        }

        private void txtNote1_TextChanged(object sender, EventArgs e)
        {
            if (changesDay1C == 0)
            {
                changesDay1C = 1;
            }
            else
            {
                changesDay1 = true;
            }
        }

        private void txtNote2_TextChanged(object sender, EventArgs e)
        {
            if (changesDay2C == 0)
            {
                changesDay2C = 1;
            }
            else
            {
                changesDay2 = true;
            }
        }

        private void txtNote3_TextChanged(object sender, EventArgs e)
        {
            if (changesDay3C == 0)
            {
                changesDay3C = 1;
            }
            else
            {
                changesDay3 = true;
            }
        }

        private void txtNote4_TextChanged(object sender, EventArgs e)
        {
            if (changesDay4C == 0)
            {
                changesDay4C = 1;
            }
            else
            {
                changesDay4 = true;
            }
        }

        private void txtNote5_TextChanged(object sender, EventArgs e)
        {
            if (changesDay5C == 0)
            {
                changesDay5C = 1;
            }
            else
            {
                changesDay5 = true;
            }
        }
        
        private void txtNote7_TextChanged(object sender, EventArgs e)
        {
            if (changesDay7C == 0)
            {
                changesDay7C = 1;
            }
            else
            {
                changesDay7 = true;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            updateHoursDetail();
            if (changesDay1)
            {
                updateDayChanges(Double.Parse(txtHours1.Text), Double.Parse(txtHours1.Text), txtNote1.Text, Int32.Parse(lbCodeDB1.Text));
            }
            if (changesDay2)
            {
                updateDayChanges(Double.Parse(txtHours2.Text), Double.Parse(txtHours2.Text), txtNote2.Text, Int32.Parse(lbCodeDB2.Text));
            }
            if (changesDay3)
            {
                updateDayChanges(Double.Parse(txtHours3.Text), Double.Parse(txtHours3.Text), txtNote3.Text, Int32.Parse(lbCodeDB3.Text));
            }
            if (changesDay4)
            {
                updateDayChanges(Double.Parse(txtHours4.Text), Double.Parse(txtHours4.Text), txtNote4.Text, Int32.Parse(lbCodeDB4.Text));
            }
            if (changesDay5)
            {
                updateDayChanges(Double.Parse(txtHours5.Text), Double.Parse(txtHours5.Text), txtNote5.Text, Int32.Parse(lbCodeDB5.Text));
            }
            if (changesDay6)
            {
                updateDayChanges(Double.Parse(txtHours6.Text), Double.Parse(txtHours6.Text), txtNote6.Text, Int32.Parse(lbCodeDB6.Text));
            }
            if (changesDay7)
            {
                updateDayChanges(Double.Parse(txtHours7.Text), Double.Parse(txtHours7.Text), txtNote7.Text, Int32.Parse(lbCodeDB7.Text));
            }
            bool process = new WorkWeekDetail(weekReportCodeDB, ordinaryH, totalH, extraH, 0, 0, 0).UpdateWeekReport();
            if (process)
            {
                MessageBox.Show("¡Los cambios fueron guardados exitosamente!");
                this.Dispose();
                uc.generateReport(week);
            }
            else
            {
                MessageBox.Show("Ocurrió un error ¡inténtelo de nuevo!");
            }
        }

        public void updateDayChanges(Double oHours, Double tHours, String dayNote, int dbCode)
        {
            new WorkDayDetail(0, oHours, tHours, new DateTime(), dayNote, true, 0, 0).UpdateWorkDay(dbCode);
        }

        private void mbExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            uc.generateReport(week);
        }

        private void txtHours1_ValueChanged(object sender, EventArgs e)
        {
            if (changesDay1C == 0)
            {
                changesDay1C = 1;
            }
            else
            {
                changesDay1 = true;
            }
        }

        private void txtHours2_ValueChanged(object sender, EventArgs e)
        {
            if (changesDay2C == 0)
            {
                changesDay2C = 1;
            }
            else
            {
                changesDay2 = true;
            }
        }

        private void txtHours3_ValueChanged(object sender, EventArgs e)
        {
            if (changesDay3C == 0)
            {
                changesDay3C = 1;
            }
            else
            {
                changesDay3 = true;
            }
        }

        private void txtHours4_ValueChanged(object sender, EventArgs e)
        {
            if (changesDay4C == 0)
            {
                changesDay4C = 1;
            }
            else
            {
                changesDay4 = true;
            }
        }

        private void txtHours5_ValueChanged(object sender, EventArgs e)
        {
            if (changesDay5C == 0)
            {
                changesDay5C = 1;
            }
            else
            {
                changesDay5 = true;
            }
        }

        private void txtHours6_ValueChanged(object sender, EventArgs e)
        {
            if (changesDay6C == 0)
            {
                changesDay6C = 1;
            }
            else
            {
                changesDay6 = true;
            }
        }

        private void txtHours7_ValueChanged(object sender, EventArgs e)
        {
            if (changesDay7C == 0)
            {
                changesDay7C = 1;
            }
            else
            {
                changesDay7 = true;
            }
        }

        private void txtNote6_TextChanged(object sender, EventArgs e)
        {
            if (changesDay6C == 0)
            {
                changesDay6C = 1;
            }
            else
            {
                changesDay6 = true;
            }
        }
    }
}
