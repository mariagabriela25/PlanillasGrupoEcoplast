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
    public partial class MenuUserControl : MetroFramework.Controls.MetroUserControl
    {
        public MenuUserControl()
        {
            InitializeComponent();
        }

        private void mtPayroll_Click(object sender, EventArgs e)
        {
            if (!MainForm.Instance.Content.Controls.ContainsKey("WeekPayrollControl"))
            {
                WeekPayrollControl uc = new WeekPayrollControl();
                uc.Dock = DockStyle.Fill;
                MainForm.Instance.Content.Controls.Add(uc);
            }
            MainForm.Instance.Content.Controls["WeekPayrollControl"].BringToFront();
            MainForm.Instance.BackButton.Visible = true;
            MainForm.Instance.LabelTitle.Text = "Planilla Semanal";
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

        private void mtDailyPayroll_Click(object sender, EventArgs e)
        {
            if (!MainForm.Instance.Content.Controls.ContainsKey("DayReviewUserControl"))
            {
                DayReviewUserControl dd = new DayReviewUserControl();
                dd.Dock = DockStyle.Fill;
                MainForm.Instance.Content.Controls.Add(dd);
            }
            MainForm.Instance.Content.Controls["DayReviewUserControl"].BringToFront();
            MainForm.Instance.BackButton.Visible = true;
            MainForm.Instance.LabelTitle.Text = "Administración de Planillas";
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (!MainForm.Instance.Content.Controls.ContainsKey("ChecksUserControl"))
            {
                ChecksUserControl uc = new ChecksUserControl();
                uc.Dock = DockStyle.Fill;
                MainForm.Instance.Content.Controls.Add(uc);
            }
            MainForm.Instance.Content.Controls["ChecksUserControl"].BringToFront();
            MainForm.Instance.BackButton.Visible = true;
            MainForm.Instance.LabelTitle.Text = "Marcas del Reloj";
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            if (!MainForm.Instance.Content.Controls.ContainsKey("WeekUserPayrollControl"))
            {
                WeekUserPayrollControl uc = new WeekUserPayrollControl();
                uc.Dock = DockStyle.Fill;
                MainForm.Instance.Content.Controls.Add(uc);
            }
            MainForm.Instance.Content.Controls["WeekUserPayrollControl"].BringToFront();
            MainForm.Instance.BackButton.Visible = true;
            MainForm.Instance.LabelTitle.Text = "Detalle de la Semana";
        }

        private void mtExportData_Click(object sender, EventArgs e)
        {
            if (!MainForm.Instance.Content.Controls.ContainsKey("ExcelExportUserControl"))
            {
                ExcelExportUserControl uc = new ExcelExportUserControl();
                uc.Dock = DockStyle.Fill;
                MainForm.Instance.Content.Controls.Add(uc);
            }
            MainForm.Instance.Content.Controls["ExcelExportUserControl"].BringToFront();
            MainForm.Instance.BackButton.Visible = true;
            MainForm.Instance.LabelTitle.Text = "Exportar a Excel";
        }
    }
}
