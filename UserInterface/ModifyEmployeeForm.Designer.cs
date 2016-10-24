namespace UserInterface
{
    partial class ModifyEmployeeForm
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mcbDepart = new MetroFramework.Controls.MetroComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.mLbEmployeeID = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtEmployeeNames = new System.Windows.Forms.TextBox();
            this.txtEmployeeLastNames = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(31, 242);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(99, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Departamento";
            // 
            // mcbDepart
            // 
            this.mcbDepart.FormattingEnabled = true;
            this.mcbDepart.ItemHeight = 24;
            this.mcbDepart.Location = new System.Drawing.Point(32, 284);
            this.mcbDepart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mcbDepart.Name = "mcbDepart";
            this.mcbDepart.Size = new System.Drawing.Size(195, 30);
            this.mcbDepart.TabIndex = 1;
            this.mcbDepart.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.ForeColor = System.Drawing.Color.Lime;
            this.metroButton1.Location = new System.Drawing.Point(290, 273);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(278, 53);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Guardar cambios";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // mLbEmployeeID
            // 
            this.mLbEmployeeID.AutoSize = true;
            this.mLbEmployeeID.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mLbEmployeeID.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mLbEmployeeID.Location = new System.Drawing.Point(408, 31);
            this.mLbEmployeeID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLbEmployeeID.Name = "mLbEmployeeID";
            this.mLbEmployeeID.Size = new System.Drawing.Size(118, 25);
            this.mLbEmployeeID.TabIndex = 3;
            this.mLbEmployeeID.Text = "IDEmployee";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(30, 74);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(61, 20);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Nombre";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(31, 155);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 20);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Apellidos";
            // 
            // txtEmployeeNames
            // 
            this.txtEmployeeNames.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeNames.Location = new System.Drawing.Point(30, 115);
            this.txtEmployeeNames.Name = "txtEmployeeNames";
            this.txtEmployeeNames.Size = new System.Drawing.Size(196, 30);
            this.txtEmployeeNames.TabIndex = 6;
            // 
            // txtEmployeeLastNames
            // 
            this.txtEmployeeLastNames.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeLastNames.Location = new System.Drawing.Point(32, 196);
            this.txtEmployeeLastNames.Name = "txtEmployeeLastNames";
            this.txtEmployeeLastNames.Size = new System.Drawing.Size(195, 30);
            this.txtEmployeeLastNames.TabIndex = 7;
            // 
            // ModifyEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 349);
            this.Controls.Add(this.txtEmployeeLastNames);
            this.Controls.Add(this.txtEmployeeNames);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mLbEmployeeID);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.mcbDepart);
            this.Controls.Add(this.metroLabel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ModifyEmployeeForm";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Modificar empleado #";
            this.Load += new System.EventHandler(this.ModifyEmployeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox mcbDepart;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel mLbEmployeeID;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.TextBox txtEmployeeNames;
        private System.Windows.Forms.TextBox txtEmployeeLastNames;
    }
}