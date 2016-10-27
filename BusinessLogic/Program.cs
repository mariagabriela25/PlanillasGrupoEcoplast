using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLogic
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

     
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            DateTime inicio = new DateTime();
            DateTime fin = new DateTime();

            DayOfWeek firstDay = DayOfWeek.Monday;
            System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-CR");
        

            DateTime day = new DateTime(2016, 09, 12);

            day.AddDays(DayOfWeek.Sunday - day.DayOfWeek);

            GregorianCalendar FJ = new GregorianCalendar();

            int w = FJ.GetWeekOfYear(day, CalendarWeekRule.FirstDay, firstDay);

            fin = sem(45);
            inicio = fin.AddDays(-6);

            MessageBox.Show("Inicio: " + inicio.ToShortDateString() + " Fin: " + fin.ToShortDateString());
        }

        public static DateTime sem(int num)
        {
            DayOfWeek firstDay = DayOfWeek.Monday;

            DateTime day = new DateTime(2016, 10,26);
            day = day.AddDays(DayOfWeek.Sunday - day.DayOfWeek);
            GregorianCalendar FJ = new GregorianCalendar();

            int w = FJ.GetWeekOfYear(day, CalendarWeekRule.FirstDay, firstDay);
            if (num != w)
            {
                day = day.AddDays((num - w) * 7);
            }

            return day;
        }

    }
}
