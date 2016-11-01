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
    public partial class ExcelExportUserControl : MetroFramework.Controls.MetroUserControl
    {
        private string path;
        public ExcelExportUserControl()
        {
            InitializeComponent();
        }

        private void ExcelExportUserControl_Load(object sender, EventArgs e)
        {
            mcbWeeks.DataSource = new WorkWeekDetail().getWeekNumbers();
        }

        private void mbPicker_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                mtbPath.Text = path;
            }
        }

        private void mtExport_Click(object sender, EventArgs e)
        {
            if (mcbWeeks.SelectedValue == null || string.IsNullOrEmpty(path))
            {
                MessageBox.Show("Todos los campos son requeridos", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                new ExcelManager().export(path, int.Parse(mcbWeeks.SelectedValue.ToString()));
            }
        }
    }
}
