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
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        private static MainForm instance;
        public MainForm()
        {
            InitializeComponent();
            
        }

        public static MainForm Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MainForm();
                }
                return instance;
            }
        }

        public MetroFramework.Controls.MetroPanel Content
        {
            get { return mpContent;  }
            set { mpContent = value; }
        }

        public MetroFramework.Controls.MetroPanel MainMenu
        {
            get { return mpMenu; }
            set { mpMenu = value; }
        }

        public Button BackButton
        {
            get { return btnBack; }
            set { btnBack = value; }
        }

        public Label LabelTitle
        {
            get { return lblTitle; }
            set { lblTitle = value; }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btnBack.Visible = false;
            instance = this;
            MenuUserControl menu = new MenuUserControl();
            menu.Dock = DockStyle.Fill;
            mpMenu.Controls.Add(menu);

            WelcomeUserControl uc = new WelcomeUserControl();
            uc.Dock = DockStyle.Fill;
            mpContent.Controls.Add(uc);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mpContent.Controls["WelcomeUserControl"].BringToFront();
            btnBack.Visible = false;
            lblTitle.Text = "Sistema de Planillas";
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

    }
}
