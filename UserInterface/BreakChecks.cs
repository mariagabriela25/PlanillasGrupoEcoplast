using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class BreakChecks : MetroFramework.Forms.MetroForm
    {
        public BreakChecks(String name, int id, DateTime date)
        {
            InitializeComponent();
            gb.Text = name + ", el " + date.ToString("dd MMMM yyyy");
            List<Check> list = new Check().GetChecksWithRests(id, date + new TimeSpan(0, 0, 0), date.AddDays(1).Date + new TimeSpan(23, 59, 59));
            foreach (Check i in list)
            {
                if (i.CheckType == "DS")
                {
                    lbChecks.Text += "- DESCANSO: " + i.CheckTime.ToString("dd /MMMM /yyyy  -  HH:MM:ss") + "\n";
                }
            }

        }

        private void BreakChecks_Load(object sender, EventArgs e)
        {

        }
    }
}
