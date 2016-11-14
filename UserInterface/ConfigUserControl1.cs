using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace UserInterface
{
    public partial class ConfigUserControl1 : MetroFramework.Controls.MetroUserControl
    {
        public ConfigUserControl1()
        {
            InitializeComponent();
        }

        private void ConfigUserControl1_Load(object sender, EventArgs e)
        {
            allowedN.Text += " " + Math.Abs(new ConfigManager().GetValue("allowedNegative")) + " minutos";
            allowedP.Text += " " + Math.Abs(new ConfigManager().GetValue("allowedPositive")) + " minutos";
            penaltyN.Text += " " + Math.Abs(new ConfigManager().GetValue("penaltyNegative")) + " minutos";
            penaltyP.Text += " " + Math.Abs(new ConfigManager().GetValue("penaltyPositive")) + " minutos";
        }
    }
}
