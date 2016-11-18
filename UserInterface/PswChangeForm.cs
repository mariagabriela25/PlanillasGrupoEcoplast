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
    public partial class PswChangeForm : MetroFramework.Forms.MetroForm
    {
        public PswChangeForm()
        {
            InitializeComponent();
        }

        private void PswChangeForm_Load(object sender, EventArgs e)
        {

        }

        private void b_Save_Click(object sender, EventArgs e)
        {
            if (l_newpsw.Text.Equals(l_newpsw2.Text)) {
                if (new User().ChangePsw(l_oldpsw.Text, l_newpsw.Text))
                {
                    this.Close();
                } else
                {
                    l_oldpsw.Text = "";
                    l_newpsw.Text = "";
                    l_newpsw2.Text = "";
                }
            } else
            {
                MessageBox.Show("Digite la nueva contraseña correctamente");
                l_newpsw2.Text = "";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
