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
    public partial class ConfigTime : MetroFramework.Forms.MetroForm
    {
        String param;
        ConfigUserControl1 config;
        public ConfigTime(String param, ConfigUserControl1 config)
        {
            InitializeComponent();
            this.param = param;
            this.config = config;
        }

        private void ConfigTime_Load(object sender, EventArgs e)
        {

        }

        private void bSave_Click(object sender, EventArgs e)
        {
            int newvalue = Int32.Parse(numValue.Value.ToString());
            new ConfigManager().SetValue(param, newvalue);
            config.setValues();
            this.Close();
        }
    }
}
