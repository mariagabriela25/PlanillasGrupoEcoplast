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

            nupOrdinaryHours.Value = s.OrdinaryHours;
            nupDayExtra.Value = s.ExtraDayHours;
            nupNightExtra.Value = s.ExtraNightHours;

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

            List<Rest> listRests = new Rest().getAllRests();

            for (int i = 0; i < s.RestList.Count; i++)
            {
                if (i==0)
                {
                    cbRest1.Items.Add(s.RestList[i]);

                    cbRest1.DisplayMember = "Minutes";
                    cbRest1.ValueMember = "Code";
                    foreach (Rest rest in listRests)
                    {
                        if (rest.Code != s.RestList[i].Code)
                        {
                            cbRest1.Items.Add(rest);
                        }
                    }

                    cbRest1.SelectedIndex = 0;
                }

                if (i == 1)
                {
                    cbRest2.Visible = true;
                    lbRest2.Visible = true;
                    cbRest2.Items.Add(s.RestList[i]);

                    cbRest2.DisplayMember = "Minutes";
                    cbRest2.ValueMember = "Code";
                    foreach (Rest rest in listRests)
                    {
                        if (rest.Code != s.RestList[i].Code)
                        {
                            cbRest2.Items.Add(rest);
                        }
                    }

                    cbRest2.SelectedIndex = 0;
                    mBtDeleteRest2.Visible = true;
                }

                if (i == 2)
                {
                    cbRest3.Visible = true;
                    lbRest3.Visible = true;
                    cbRest3.Items.Add(s.RestList[i]);

                    cbRest3.DisplayMember = "Minutes";
                    cbRest3.ValueMember = "Code";
                    foreach (Rest rest in listRests)
                    {
                        if (rest.Code != s.RestList[i].Code)
                        {
                            cbRest3.Items.Add(rest);
                        }
                    }

                    cbRest3.SelectedIndex = 0;
                    mBtDeleteRest3.Visible = true;
                }
            }
           
        }

        private void mtAddRest_Click(object sender, EventArgs e)
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

            newSchedule.ModifySchedule();
            uc.refresh();
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
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
