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
        private int CodDepartment;
        DayOfWeek firstDayOfWeek;

        public DayReviewUserControl()
        {
            InitializeComponent();
            EstandarDate = DateTime.Today;
            firstDayOfWeek = DayOfWeek.Monday;
            System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-CR");
        }

        private void mbCheck_Click(object sender, EventArgs e)
        {
            WeekNum = Int32.Parse(mnWeekNum.Value.ToString());
            SundayDate = CalcWeekNum(WeekNum);
            CodDepartment = ((Department)cbDepart.SelectedItem).Code;
        }

        public DateTime CalcWeekNum(int weeknum)
        {
            DayOfWeek firstDay = DayOfWeek.Monday;
            EstandarDate = EstandarDate.AddDays(DayOfWeek.Sunday - EstandarDate.DayOfWeek);

            int week = new GregorianCalendar().GetWeekOfYear(EstandarDate, CalendarWeekRule.FirstDay, firstDay);
            if (weeknum != week)
            {
                EstandarDate = EstandarDate.AddDays((weeknum - week) * 7);
            }

            return EstandarDate;
        }
    }
}
