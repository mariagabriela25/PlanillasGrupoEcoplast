using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObjects;

namespace DataAccess
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
            //new DAORest().deleteRest(3);
            ////Application.Run(new Form1());

            //DateTime ini = new DateTime(2016, 10, 17);
            DateTime ini = new DateTime(2016, 10, 19, 23, 59, 59);

            //new DAOAnviz().GetChecks(28, ini, fin);


            //DateTime ini = DateTime.Now;
            MessageBox.Show(ini.Hour +":"+ini.Minute+":"+ini.Second);

        }
    }
}
