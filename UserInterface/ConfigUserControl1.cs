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
            setValues();
        }

        public void setValues()
        {
            l_an.Text = "Entrada después: " + Math.Abs(new ConfigManager().GetValue("allowedNegative")) + " minutos";
            l_ap.Text = "Salida antes: " + Math.Abs(new ConfigManager().GetValue("allowedPositive")) + " minutos";
            l_pn.Text = "Salida después: " + Math.Abs(new ConfigManager().GetValue("penaltyNegative")) + " minutos";
            l_pp.Text = "Entrada antes: " + Math.Abs(new ConfigManager().GetValue("penaltyPositive")) + " minutos";

        }

        private void b_an_Click(object sender, EventArgs e)
        {
            new ConfigTime("allowedNegative", this).Show();
        }

        private void b_pp_Click(object sender, EventArgs e)
        {
            new ConfigTime("penaltyPositive", this).Show();
        }

        private void b_ap_Click(object sender, EventArgs e)
        {
            new ConfigTime("allowedPositive", this).Show();
        }

        private void b_pn_Click(object sender, EventArgs e)
        {
            new ConfigTime("penaltyNegative", this).Show();
        }

        private void b_psw_Click(object sender, EventArgs e)
        {
            new PswChangeForm().Show();
        }
    }
}
