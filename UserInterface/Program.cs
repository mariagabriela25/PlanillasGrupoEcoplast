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
            Application.Run(new Login());


            //DateTime hoy = new DateTime(2016, 11, 30, 10, 0, 0);
            //DateTime hoy2 = new DateTime(2016, 11, 30, 18, 0, 0);
            //DateTime hoy3 = new DateTime(2016, 11, 30, 22, 0, 0);


            //Check c = new Check(8, hoy, "O");
            //Check c2 = new Check(8, hoy2, "2");
            //Check c3 = new Check(8, hoy3, "O");


            //List<Check> checks = new List<Check>();
            //checks.Add(c);
            //checks.Add(c2);
            //checks.Add(c3);

            //Check lastout = new Check();
            //int p = 0;
            //foreach (Check i in checks)
            //{
            //    ++p;
            //    if (i.CheckType.Equals("O") && i.CheckTime != lastout.CheckTime)
            //    {
            //        MessageBox.Show("Marca Ausente: " + p);
            //        break;
            //    }
            //}


        }
    }
}
