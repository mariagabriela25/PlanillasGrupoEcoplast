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
                        cbRest1.Items.Add(rest);
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
                        cbRest2.Items.Add(rest);
                    }

                    cbRest2.SelectedIndex = 0;
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
                        cbRest3.Items.Add(rest);
                    }

                    cbRest3.SelectedIndex = 0;
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
    }
}
