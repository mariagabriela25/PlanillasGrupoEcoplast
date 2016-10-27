﻿using System;
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
    public partial class MenuUserControl : MetroFramework.Controls.MetroUserControl
    {
        public MenuUserControl()
        {
            InitializeComponent();
        }

        private void mtPayroll_Click(object sender, EventArgs e)
        {
            if (!MainForm.Instance.Content.Controls.ContainsKey("PayrollControl"))
            {
                PayrollControl pc = new PayrollControl();
                pc.Dock = DockStyle.Fill;
                MainForm.Instance.Content.Controls.Add(pc);
            }
            MainForm.Instance.Content.Controls["PayrollControl"].BringToFront();
            MainForm.Instance.BackButton.Visible = true;
            MainForm.Instance.LabelTitle.Text = "Administración de Planillas";
        }

        private void mtEmployees_Click(object sender, EventArgs e)
        {
            if (!MainForm.Instance.Content.Controls.ContainsKey("EmployeeUserControl"))
            {
                EmployeeUserControl uc = new EmployeeUserControl();
                uc.Dock = DockStyle.Fill;
                MainForm.Instance.Content.Controls.Add(uc);
            }
            MainForm.Instance.Content.Controls["EmployeeUserControl"].BringToFront();
            MainForm.Instance.BackButton.Visible = true;
            MainForm.Instance.LabelTitle.Text = "Administración de Empleados";
        }

        private void mtSchedules_Click(object sender, EventArgs e)
        {
            if (!MainForm.Instance.Content.Controls.ContainsKey("ScheduleUserControl"))
            {
                ScheduleUserControl uc = new ScheduleUserControl();
                uc.Dock = DockStyle.Fill;
                MainForm.Instance.Content.Controls.Add(uc);
            }
            MainForm.Instance.Content.Controls["ScheduleUserControl"].BringToFront();
            MainForm.Instance.BackButton.Visible = true;
            MainForm.Instance.LabelTitle.Text = "Administración de Horarios";
        }

        private void mtDepartments_Click(object sender, EventArgs e)
        {
            if (!MainForm.Instance.Content.Controls.ContainsKey("DepartmentUserControl"))
            {
                DepartmentUserControl uc = new DepartmentUserControl();
                uc.Dock = DockStyle.Fill;
                MainForm.Instance.Content.Controls.Add(uc);
            }
            MainForm.Instance.Content.Controls["DepartmentUserControl"].BringToFront();
            MainForm.Instance.BackButton.Visible = true;
            MainForm.Instance.LabelTitle.Text = "Administración de Departamentos";
        }
    }
}
