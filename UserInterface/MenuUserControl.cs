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

        }

        private void mtRests_Click(object sender, EventArgs e)
        {
            if (!MainForm.Instance.Content.Controls.ContainsKey("RestsUserControl"))
            {
                RestsUserControl uc = new RestsUserControl();
                uc.Dock = DockStyle.Fill;
                MainForm.Instance.Content.Controls.Add(uc);
            }
            MainForm.Instance.Content.Controls["RestsUserControl"].BringToFront();
            MainForm.Instance.BackButton.Visible = true;
            MainForm.Instance.LabelTitle.Text = "Administración de Descansos";
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
    }
}
