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
    public partial class RestsUserControl : MetroFramework.Controls.MetroUserControl
    {


        public RestsUserControl()
        {
            InitializeComponent();
        }

        private DataTable dt;

        private void RestsUserControl_Load(object sender, EventArgs e)
        {
            refresh();
        }

        public void refresh()
        {
            dt = new DataTable();
            dt.Columns.Add("Código del Descanso");
            dt.Columns.Add("Cantidad de Minutos");
            List<Rest> rests = new Rest().getAllRests();

            foreach (Rest rest in rests)
            {
                dt.Rows.Add(rest.Code, rest.Minutes);
            }
            mgRests.DataSource = dt;
        }
        

        private void mtAdd_Click(object sender, EventArgs e)
        {
            new AddRestForm().Show();
        }

        private void mtRefresh_Click(object sender, EventArgs e)
        {
            mgRests.DataSource = null;
            refresh();
        }

        private void mtDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Está seguro de que desea eliminar este Descanso?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = 0; i < mgRests.RowCount; i++)
                {
                    if (mgRests.Rows[i].Selected)
                    {
                        new Rest().deleteRest(int.Parse(mgRests.Rows[i].Cells[0].Value.ToString()));
                        refresh();
                    }
                }
            }
        }
    }
}
