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
    public partial class AddRestForm : Form
    {
        public AddRestForm()
        {
            InitializeComponent();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            new Rest().addRest(new Rest
            {
                Code = 3,
                Minutes = (int)nudMinutos.Value
            });
        }
    }
}
