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
    public partial class AddDepartmentForm : MetroFramework.Forms.MetroForm
    {
        private DepartmentUserControl c;
        public AddDepartmentForm(DepartmentUserControl clasepadre)
        {
            InitializeComponent();
            c = clasepadre;
        }

        private void AddDepartmentForm_Load(object sender, EventArgs e)
        {

        }

        private void mbSave_Click(object sender, EventArgs e)
        {
            InputValidations validation = new InputValidations();
            if (mtbCode.Text.Length != 0 && mtbName.Text.Length != 0)
            {
                if (validation.numbersValidation(mtbCode.Text) && validation.wordsValidation(mtbName.Text))
                {
                    new Department(Int32.Parse(mtbCode.Text), mtbName.Text).AddDepartment();
                    c.refresh();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El codigo debe contener solamente numeros \nEl nombre debe contener solamente letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No deben haber espacios en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
