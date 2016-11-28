using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace UserInterface
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
            //Application.Run(new Login());



            TimeSpan ini = new TimeSpan(22, 30, 0);
            TimeSpan end = new TimeSpan(6, 0, 0);

            TimeSpan to = ini.Subtract(end);

            TimeSpan total = new TimeSpan(1, 0, 0, 0);

            TimeSpan dd = total.Subtract(to);

            double df = dd.TotalHours;

        }
    }
}
