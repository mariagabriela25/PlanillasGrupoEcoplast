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
    public partial class AddRestForm : MetroFramework.Forms.MetroForm
    {
        RestsUserControl uc;

        public AddRestForm(RestsUserControl ruc)
        {
            InitializeComponent();
            uc = ruc;
        }

        private void AddRestForm_Load(object sender, EventArgs e)
        {

        }

        private void mbSave_Click(object sender, EventArgs e)
        {
            new Rest().addRest(new Rest
            {
                Minutes = (int)nudMinutos.Value
            });
            uc.refresh();
            this.Close();
        }
    }
}
