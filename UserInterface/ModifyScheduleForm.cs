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
    public partial class ModifyScheduleForm : MetroFramework.Forms.MetroForm
    {
        String sCode;
        ScheduleUserControl uc;

        public ModifyScheduleForm(String scheduleCode, ScheduleUserControl suc)
        {
            InitializeComponent();
            sCode = scheduleCode;
            uc = suc;
        }

        private void ModifyScheduleForm_Load(object sender, EventArgs e)
        {
            txtCode.Text = sCode;

            Schedule s = new Schedule();
            s.Code = sCode;
            s = s.GetSchedule();
            
            nupInitialHour.Value = s.InitialHour.Hour;
            nupInitialMinute.Value = s.InitialHour.Minute;

            nupFinalHour.Value = s.finalHour.Hour;
            nupFinalMinute.Value = s.finalHour.Minute;

            cbDepartment.Items.Add(s.Dept);

            List<Department> listDepartments = new Department().GetAllDepartment();

            cbDepartment.DisplayMember = "Name";
            cbDepartment.ValueMember = "Code";
            foreach (Department dep in listDepartments)
            {
                if (dep.Code != s.Dept.Code)
                {
                    cbDepartment.Items.Add(dep);
                }
            }

            cbDepartment.SelectedIndex = 0;
                       
        }

        private void mbSave_Click(object sender, EventArgs e)
        {
            Department d = new Department(((Department)(cbDepartment.SelectedItem)).Code, ((Department)(cbDepartment.SelectedItem)).Name);

            DateTime initialTime = new DateTime(2016, 10, 18, Int32.Parse(nupInitialHour.Value.ToString()), Int32.Parse(nupInitialMinute.Value.ToString()), 0);
            DateTime finalTime = new DateTime(2016, 10, 18, Int32.Parse(nupFinalHour.Value.ToString()), Int32.Parse(nupFinalMinute.Value.ToString()), 0);

            Schedule newSchedule = new Schedule();
            newSchedule.Code = txtCode.Text;
            newSchedule.InitialHour = initialTime;
            newSchedule.finalHour = finalTime;


            if (newSchedule.finalHour < newSchedule.InitialHour)
            {
                int expected1 = 24 - newSchedule.InitialHour.Hour + newSchedule.finalHour.Hour;
                newSchedule.OrdinaryHours = expected1;
        }
            else
            {
                int expected2 = newSchedule.finalHour.Hour - newSchedule.InitialHour.Hour;
        newSchedule.OrdinaryHours = expected2;
            }

    newSchedule.Dept = d;

            newSchedule.ModifySchedule();
            uc.refresh();
            this.Close();
        }

    }
}
