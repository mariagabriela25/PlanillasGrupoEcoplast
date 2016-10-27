using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class PayrollControl : MetroFramework.Controls.MetroUserControl
    {
        public PayrollControl()
        {
            InitializeComponent();
        }

        private void PayrollControl_Load(object sender, EventArgs e)
        {

        }

        private void mt_day_hours_Click(object sender, EventArgs e)
        {
            new DayReviewUserControl().Show();
        }

        private void mt_week_hours_Click(object sender, EventArgs e)
        {
            new WeekDetailUserControl().Show();
        }
    }
}
