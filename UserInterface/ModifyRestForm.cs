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
    public partial class ModifyRestForm : MetroFramework.Forms.MetroForm
    {
        RestsUserControl uc;
        int restCode;

        public ModifyRestForm(int code, RestsUserControl ruc)
        {
            InitializeComponent();
            restCode = code;
            uc = ruc;
        }

        private void ModifyRestForm_Load(object sender, EventArgs e)
        {
            Rest rest = new Rest().getRest(restCode);
            mLbRestCode.Text = rest.Code + "";
            nudMinutos.Value = rest.Minutes;
        }

        private void mBtSaveChanges_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea modificar este descanso?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Rest rst = new Rest();
                rst.Code = restCode;
                rst.Minutes = Int32.Parse(nudMinutos.Value.ToString());

                rst.modifyRest();
                uc.refresh();
                this.Close();
            }
        }
    }
}
