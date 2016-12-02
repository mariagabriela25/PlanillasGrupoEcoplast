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
using System.Globalization;

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
            MainForm.Instance.LabelTitle.Text = "Empleados";
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
            MainForm.Instance.LabelTitle.Text = "Horarios";
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
            MainForm.Instance.LabelTitle.Text = "Departamentos";
        }

        private void mtDailyPayroll_Click(object sender, EventArgs e)
        {
            MainForm.Instance.Content.Controls["WelcomeUserControl"].BringToFront();
            MainForm.Instance.BackButton.Visible = false;
            MainForm.Instance.LabelTitle.Text = "Sistema de Planillas";
            new DayReviewUserControl().Show();
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
            //int w = System.Globalization.CultureInfo.CurrentUICulture.Calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstDay, DayOfWeek.Monday) - 1;
            //List<Anomaly> list = new AnomaliesManager().GetValues();
            //if (list.Count() != 0)
            //{
            //    MessageBox.Show("¡Existen anomalías pendientes! Debe revisar todas la anomalías antes de exportar los datos a Excel");
            //}
            //else if (!(new WorkWeekDetail().isComplete(w)))
            //{
            //    MessageBox.Show("¡Faltan departamentos por calcular!");
            //}
            //else
            //{
                if (!MainForm.Instance.Content.Controls.ContainsKey("ExcelExportUserControl"))
                {
                    ExcelExportUserControl uc = new ExcelExportUserControl();
                    uc.Dock = DockStyle.Fill;
                    MainForm.Instance.Content.Controls.Add(uc);
                }
                MainForm.Instance.Content.Controls["ExcelExportUserControl"].BringToFront();
                MainForm.Instance.BackButton.Visible = true;
                MainForm.Instance.LabelTitle.Text = "Exportar a Excel";
        //    }            
        }
    }
}
