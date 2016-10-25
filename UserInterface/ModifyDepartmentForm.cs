﻿using System;
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
    public partial class ModifyDepartmentForm : MetroFramework.Forms.MetroForm
    {
        int deptCode;
        DepartmentUserControl uc;

        public ModifyDepartmentForm(int code, DepartmentUserControl duc)
        {
            InitializeComponent();
            deptCode = code;
            uc = duc;
        }

        private void ModifyDepartmentForm_Load(object sender, EventArgs e)
        {
            Department depart = new Department();
            depart.Code = deptCode;
            depart = depart.GetDepartment();

            mLbDepartCode.Text = depart.Code + "";
            txtDepartName.Text = depart.Name;
        }

        private void mBtSaveChanges_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea modificar este departamento?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Department dpt = new Department();
                dpt.Code = deptCode;
                dpt.Name = txtDepartName.Text;

                dpt.ModifyDepartment();

                uc.refresh();
                this.Close();
            }
        }
    }
}
