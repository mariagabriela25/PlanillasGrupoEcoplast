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

        private void mtAddRest_Click_1(object sender, EventArgs e)
        {
            if (cbRest1.SelectedItem != null)
            {
                if (!lbRest2.Visible)
                {
                    List<Rest> listRests = new Rest().getAllRests();

                    cbRest2.DisplayMember = "Minutes";
                    cbRest2.ValueMember = "Code";
                    foreach (Rest rest in listRests)
                    {
                            cbRest2.Items.Add(rest);
                    }
                    lbRest2.Visible = true;
                    cbRest2.Visible = true;
                    mBtDeleteRest2.Visible = true;
                }
                else
                {
                    if (cbRest2.SelectedItem != null)
                    {
                        if (lbRest2.Visible && !lbRest3.Visible)
                        {
                            List<Rest> listRests = new Rest().getAllRests();

                            cbRest3.DisplayMember = "Minutes";
                            cbRest3.ValueMember = "Code";
                            foreach (Rest rest in listRests)
                            {
                                    cbRest3.Items.Add(rest);
                            }
                            lbRest3.Visible = true;
                            cbRest3.Visible = true;
                            mBtDeleteRest3.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("¡No se permiten más descansos!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe elegir primero el Descanso #2");
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Debe elegir primero el Descanso #1");
            }
            
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
            newSchedule.OrdinaryHours = Int32.Parse(nupOrdinaryHours.Value.ToString());
            newSchedule.ExtraDayHours = Int32.Parse(nupDayExtra.Value.ToString());
            newSchedule.ExtraNightHours = Int32.Parse(nupNightExtra.Value.ToString());
            newSchedule.Dept = d;
            newSchedule.TotalHours = newSchedule.OrdinaryHours + newSchedule.ExtraDayHours + newSchedule.ExtraNightHours;

            if (cbRest1.SelectedItem != null)
            {
                newSchedule.AddRest((Rest)cbRest1.SelectedItem);
            }
            if (cbRest2.SelectedItem != null)
            {
                newSchedule.AddRest((Rest)cbRest2.SelectedItem);
            }
            if (cbRest3.SelectedItem != null)
            {
                newSchedule.AddRest((Rest)cbRest3.SelectedItem);
            }

            newSchedule.AddSchedule();
            scheduleControl.refresh();
            this.Close();
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

            List<Rest> listRests = new Rest().getAllRests();

            cbRest1.DisplayMember = "Minutes";
            cbRest1.ValueMember = "Code";
            foreach (Rest rest in listRests)
            {
                cbRest1.Items.Add(rest);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void mBtDeleteRest2_Click(object sender, EventArgs e)
        {
            cbRest2.SelectedItem = null;
            lbRest2.Visible = false;
            cbRest2.Visible = false;
            mBtDeleteRest2.Visible = false;
            cbRest2.Items.Clear();
        }

        private void mBtDeleteRest3_Click(object sender, EventArgs e)
        {
            cbRest3.SelectedItem = null;
            lbRest3.Visible = false;
            cbRest3.Visible = false;
            mBtDeleteRest3.Visible = false;
            cbRest3.Items.Clear();
        }
    }
}
