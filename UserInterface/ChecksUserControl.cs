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
    public partial class ChecksUserControl : MetroFramework.Controls.MetroUserControl
    {
        public ChecksUserControl()
        {
            InitializeComponent();
        }

        private void mbShowChecks_Click(object sender, EventArgs e)
        {
            DateTime initialDate= mdtInitialDate.Value;
            DateTime finalDate = mdtFinalDate.Value;
        }

        private void ChecksUserControl_Load(object sender, EventArgs e)
        {
            //ListViewItem lvi = new ListViewItem("Extrusión");
            //lvi.SubItems.Add("Juan Perez");
            //lvi.SubItems.Add("12");

            mlvEmployees.Items.Add("Extrusión");
        }
    }
}
