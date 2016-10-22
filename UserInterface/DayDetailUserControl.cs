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
    public partial class DayDetailUserControl : UserControl
    {

        public DataTable dt;
        public DayDetailUserControl()
        {
            InitializeComponent();
        }

        private void DayDetailUserControl_Load(object sender, EventArgs e)
        {
            List<Department> list = new Department().GetAllDepartment();

            mcbDepartment.DisplayMember = "Name";
            mcbDepartment.ValueMember = "Code";
            foreach (Department dep in list)
            {
                mcbDepartment.Items.Add(dep);
            }
        }

        private void mcbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Department de = (Department)mcbDepartment.SelectedItem;
            List<Schedule> list = new Schedule().GetAllSchedules();

            mcbSchedule.DisplayMember = "Code";
            mcbSchedule.ValueMember = "Code";

            foreach (Schedule s in list)
            {
                mcbDepartment.Items.Add(s);
            }
        }
    }
}
