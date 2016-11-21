using BusinessLogic;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.AcceptButton = mbSave;
        }

        private void htmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void mbSave_Click(object sender, EventArgs e)
        {
            if (metroTextBox2.Text.Length != 0)
            {
                User user = new User(1, metroTextBox2.Text.Trim());
                if (user.login())
                {
                    MainForm mf = new MainForm();
                    mf.Visible = true;
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar una contraseña");
            }
        }


    }
}
