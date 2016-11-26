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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyEmployeeForm));
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
            this.metroLabel1.Location = new System.Drawing.Point(23, 197);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(95, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Departamento";
            // 
            // mcbDepart
            // 
            this.mcbDepart.FormattingEnabled = true;
            this.mcbDepart.ItemHeight = 23;
            this.mcbDepart.Location = new System.Drawing.Point(24, 231);
            this.mcbDepart.Name = "mcbDepart";
            this.mcbDepart.Size = new System.Drawing.Size(147, 29);
            this.mcbDepart.TabIndex = 1;
            this.mcbDepart.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.ForeColor = System.Drawing.Color.Lime;
            this.metroButton1.Location = new System.Drawing.Point(218, 222);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(208, 43);
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
            this.mLbEmployeeID.Location = new System.Drawing.Point(306, 25);
            this.mLbEmployeeID.Name = "mLbEmployeeID";
            this.mLbEmployeeID.Size = new System.Drawing.Size(114, 25);
            this.mLbEmployeeID.TabIndex = 3;
            this.mLbEmployeeID.Text = "IDEmployee";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(22, 60);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Nombre";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 126);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Apellidos";
            // 
            // txtEmployeeNames
            // 
            this.txtEmployeeNames.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeNames.Location = new System.Drawing.Point(22, 93);
            this.txtEmployeeNames.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmployeeNames.Name = "txtEmployeeNames";
            this.txtEmployeeNames.Size = new System.Drawing.Size(148, 26);
            this.txtEmployeeNames.TabIndex = 6;
            // 
            // txtEmployeeLastNames
            // 
            this.txtEmployeeLastNames.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeLastNames.Location = new System.Drawing.Point(24, 159);
            this.txtEmployeeLastNames.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmployeeLastNames.Name = "txtEmployeeLastNames";
            this.txtEmployeeLastNames.Size = new System.Drawing.Size(147, 26);
            this.txtEmployeeLastNames.TabIndex = 7;
            // 
            // ModifyEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 284);
            this.Controls.Add(this.txtEmployeeLastNames);
            this.Controls.Add(this.txtEmployeeNames);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mLbEmployeeID);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.mcbDepart);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModifyEmployeeForm";
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