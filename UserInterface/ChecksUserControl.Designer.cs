namespace UserInterface
{
    partial class ChecksUserControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mdtInitialDate = new MetroFramework.Controls.MetroDateTime();
            this.mlvEmployees = new MetroFramework.Controls.MetroListView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mdtFinalDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mbShowChecks = new MetroFramework.Controls.MetroButton();
            this.department = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.employee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idEmployee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // mdtInitialDate
            // 
            this.mdtInitialDate.Location = new System.Drawing.Point(213, 103);
            this.mdtInitialDate.Margin = new System.Windows.Forms.Padding(4);
            this.mdtInitialDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.mdtInitialDate.Name = "mdtInitialDate";
            this.mdtInitialDate.Size = new System.Drawing.Size(265, 30);
            this.mdtInitialDate.TabIndex = 19;
            // 
            // mlvEmployees
            // 
            this.mlvEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.department,
            this.employee,
            this.idEmployee});
            this.mlvEmployees.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mlvEmployees.FullRowSelect = true;
            this.mlvEmployees.Location = new System.Drawing.Point(40, 236);
            this.mlvEmployees.Name = "mlvEmployees";
            this.mlvEmployees.OwnerDraw = true;
            this.mlvEmployees.Size = new System.Drawing.Size(438, 360);
            this.mlvEmployees.TabIndex = 21;
            this.mlvEmployees.UseCompatibleStateImageBehavior = false;
            this.mlvEmployees.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(40, 113);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(111, 20);
            this.metroLabel1.TabIndex = 22;
            this.metroLabel1.Text = "FECHA INICIO:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(40, 174);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(108, 20);
            this.metroLabel2.TabIndex = 23;
            this.metroLabel2.Text = "FECHA FINAL:";
            // 
            // mdtFinalDate
            // 
            this.mdtFinalDate.Location = new System.Drawing.Point(213, 164);
            this.mdtFinalDate.Margin = new System.Windows.Forms.Padding(4);
            this.mdtFinalDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.mdtFinalDate.Name = "mdtFinalDate";
            this.mdtFinalDate.Size = new System.Drawing.Size(265, 30);
            this.mdtFinalDate.TabIndex = 24;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(40, 28);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(189, 25);
            this.metroLabel3.TabIndex = 25;
            this.metroLabel3.Text = "MARCAS DEL RELOJ";
            // 
            // mbShowChecks
            // 
            this.mbShowChecks.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbShowChecks.ForeColor = System.Drawing.Color.Lime;
            this.mbShowChecks.Location = new System.Drawing.Point(213, 634);
            this.mbShowChecks.Margin = new System.Windows.Forms.Padding(4);
            this.mbShowChecks.Name = "mbShowChecks";
            this.mbShowChecks.Size = new System.Drawing.Size(265, 41);
            this.mbShowChecks.Style = MetroFramework.MetroColorStyle.Lime;
            this.mbShowChecks.TabIndex = 26;
            this.mbShowChecks.Text = "Cargar Marcas";
            this.mbShowChecks.UseSelectable = true;
            this.mbShowChecks.Click += new System.EventHandler(this.mbShowChecks_Click);
            // 
            // department
            // 
            this.department.Text = "Departamento";
            // 
            // employee
            // 
            this.employee.Text = "Empleado";
            // 
            // idEmployee
            // 
            this.idEmployee.Text = "Número de empleado";
            // 
            // ChecksUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mbShowChecks);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.mdtFinalDate);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mlvEmployees);
            this.Controls.Add(this.mdtInitialDate);
            this.Name = "ChecksUserControl";
            this.Size = new System.Drawing.Size(524, 731);
            this.Load += new System.EventHandler(this.ChecksUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroDateTime mdtInitialDate;
        private MetroFramework.Controls.MetroListView mlvEmployees;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime mdtFinalDate;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton mbShowChecks;
        private System.Windows.Forms.ColumnHeader department;
        private System.Windows.Forms.ColumnHeader employee;
        private System.Windows.Forms.ColumnHeader idEmployee;
    }
}