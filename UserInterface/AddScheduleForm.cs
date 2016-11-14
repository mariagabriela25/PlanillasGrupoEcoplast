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
    public partial class AddScheduleForm : MetroFramework.Forms.MetroForm
    {
        ScheduleUserControl scheduleControl;

        public AddScheduleForm(ScheduleUserControl sh)
        {
            InitializeComponent();
            scheduleControl = sh;
        }

        private void mbSave_Click(object sender, EventArgs e)
        {
            InputValidations validation = new InputValidations();

            if (txtCode.Text.Length != 0 && cbDepartment.SelectedItem != null)
            {
                if (validation.numbersValidation(txtCode.Text))
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
                    newSchedule.AddSchedule();
                    scheduleControl.refresh();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El codigo debe contener solamente numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No deben haber espacios en blanco \nLa hora debe ser mayor a cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddScheduleForm_Load(object sender, EventArgs e)
        {
            List<Department> listDepartments = new Department().GetAllDepartment();

            cbDepartment.DisplayMember = "Name";
            cbDepartment.ValueMember = "Code";
            foreach (Department dep in listDepartments)
            {
                cbDepartment.Items.Add(dep);
            }

        }

        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
