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
    public partial class WaitForm : MetroFramework.Forms.MetroForm
    {
        public Action Worker { get; set; }
        public WaitForm(Action worker, String message)
        {
            InitializeComponent();
            lbMessage.Text = message;
            if (worker == null)
            {
                throw new ArgumentException();
            }
            Worker = worker;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }
        
    }
}
