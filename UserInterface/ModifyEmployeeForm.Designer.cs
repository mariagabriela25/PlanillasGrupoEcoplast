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
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(204, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Seleccion el nuevo departamento";
            // 
            // mcbDepart
            // 
            this.mcbDepart.FormattingEnabled = true;
            this.mcbDepart.ItemHeight = 23;
            this.mcbDepart.Location = new System.Drawing.Point(24, 121);
            this.mcbDepart.Name = "mcbDepart";
            this.mcbDepart.Size = new System.Drawing.Size(121, 29);
            this.mcbDepart.TabIndex = 1;
            this.mcbDepart.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.ForeColor = System.Drawing.Color.Lime;
            this.metroButton1.Location = new System.Drawing.Point(24, 189);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(95, 33);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Cambiar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // ModifyEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 262);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.mcbDepart);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ModifyEmployeeForm";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Cambiar departamento del empleado";
            this.Load += new System.EventHandler(this.ModifyEmployeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox mcbDepart;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}