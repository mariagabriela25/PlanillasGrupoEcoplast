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
    public partial class ChecksUserControl : MetroFramework.Controls.MetroUserControl
    {

        Employee empControl;
        List<Employee> selectedEmployees;
        Boolean changedIniDate = false;
        Boolean changedFinDate = false;
        DataTable dt;

        public ChecksUserControl()
        {
            InitializeComponent();
        }

        private void ChecksUserControl_Load(object sender, EventArgs e)
        {
            //dt.Columns.Add("Código del Empleado");
            //dt.Columns.Add("Nombre");
            //dt.Columns.Add("Apellido");
            //dt.Columns.Add("Departamento");

            //list = new Employee().GetAllEmployees();

            //foreach (Employee empl in list)
            //{
            //    dt.Rows.Add(empl.Code, empl.Name, empl.LastName, empl.Department.Name);
            //}
            //mgEmployees.DataSource = dt;

            empControl = new Employee();
            selectedEmployees = new List<Employee>();

            //mlvEmployees.BeginUpdate();
            //mlvEmployees.Items.Clear();
            //mlvEmployees.View = View.Details;

            dt = new DataTable();

            dt.Columns.Add("Empleado");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Departamento");

            List<Employee> employeesList = empControl.GetAllEmployees();

            foreach (Employee empl in employeesList)
            {
                dt.Rows.Add(empl.Code, empl.Name + " " + empl.LastName, empl.Department.Name);
            }
            mgEmployeesList.DataSource = dt;

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "";
            checkBoxColumn.Width = 30;
            checkBoxColumn.Name = "checkBoxColumn";
            mgEmployeesList.Columns.Insert(3, checkBoxColumn);

            foreach (DataGridViewRow row in mgEmployeesList.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[3];
            }

            //mlvEmployees.Columns.Add("Empleado");
            //mlvEmployees.Columns.Add("Nombre");
            //mlvEmployees.Columns.Add("Departamento");

            //mlvEmployees.CheckBoxes = true;

            //List<Employee> employeesList = empControl.GetAllEmployees();

            //foreach (var item in employeesList)
            //{
            //    ListViewItem lvi;
            //    lvi = new ListViewItem(new string[] { "        " + item.Code, item.Name + " " + item.LastName, item.Department.Name });
            //    mlvEmployees.Items.Add(lvi);
            //}

            ////mlvEmployees.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            //mlvEmployees.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            //mlvEmployees.EndUpdate();
            //mlvEmployees.AllowSorting = true;

        }

        private void mbSave_Click(object sender, EventArgs e)
        {
            if (!changedIniDate && !changedFinDate)
            {
                MessageBox.Show("Debe indicar el rango de fechas primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!changedIniDate)
            {
                MessageBox.Show("Debe indicar el rango inicial para cargas las marcas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!changedFinDate)
            {
                MessageBox.Show("Debe indicar el rango final para cargas las marcas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                DateTime initialDate = mdtInitialDate.Value;
                DateTime finalDate = mdtFinalDate.Value;

                if (initialDate < finalDate && finalDate < DateTime.Now)
                {
                    int xPosition = 0;
                    int yPosition = 0;

                    GetSelectedEmployees();

                    foreach (Employee emp in selectedEmployees)
                    {
                        ChecksRangeForm cForm = new ChecksRangeForm(emp, initialDate, finalDate);
                        cForm.Show();
                        cForm.StartPosition = FormStartPosition.Manual;
                        cForm.Location = new Point(xPosition, yPosition);
                        xPosition += 200;
                        if (xPosition > SystemInformation.VirtualScreen.Width - 200)
                        {
                            xPosition = 0;
                            yPosition = 500;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("La fecha inicial debe ser anterior a la fecha final \nAmbas fechas deben se anteriores a la fecha actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            selectedEmployees = new List<Employee>();
        }

        public void GetSelectedEmployees()
        {
            foreach (DataGridViewRow row in mgEmployeesList.Rows)
            {
                int rowNumber = row.Index;

                bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                if (isSelected)
                {
                    selectedEmployees.Add(new Employee(Int32.Parse(row.Cells[0].Value.ToString()), row.Cells[1].Value.ToString(), "", new Department(0, row.Cells[2].Value.ToString())));
                }
            }

            //foreach (ListViewItem item in mlvEmployees.CheckedItems)
            //{
            //    selectedEmployees.Add(new Employee(Int32.Parse(item.SubItems[0].Text), item.SubItems[1].Text, "", new Department(0, item.SubItems[2].Text)));
            //}
        }

        private void mdtInitialDate_ValueChanged(object sender, EventArgs e)
        {
            changedIniDate = true;
        }

        private void mdtFinalDate_ValueChanged(object sender, EventArgs e)
        {
            changedFinDate = true;
        }

        private void mgEmployeesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
