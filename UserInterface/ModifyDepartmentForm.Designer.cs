namespace UserInterface
{
    partial class ModifyDepartmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyDepartmentForm));
            this.mLbCode = new MetroFramework.Controls.MetroLabel();
            this.mLbDepartCode = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtDepartName = new System.Windows.Forms.TextBox();
            this.mBtSaveChanges = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // mLbCode
            // 
            this.mLbCode.AutoSize = true;
            this.mLbCode.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mLbCode.Location = new System.Drawing.Point(17, 71);
            this.mLbCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mLbCode.Name = "mLbCode";
            this.mLbCode.Size = new System.Drawing.Size(71, 25);
            this.mLbCode.TabIndex = 1;
            this.mLbCode.Text = "Código:";
            // 
            // mLbDepartCode
            // 
            this.mLbDepartCode.AutoSize = true;
            this.mLbDepartCode.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mLbDepartCode.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mLbDepartCode.Location = new System.Drawing.Point(110, 71);
            this.mLbDepartCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mLbDepartCode.Name = "mLbDepartCode";
            this.mLbDepartCode.Size = new System.Drawing.Size(150, 25);
            this.mLbDepartCode.TabIndex = 6;
            this.mLbDepartCode.Text = "mLbDepartCode";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(17, 125);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 25);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Nombre";
            // 
            // txtDepartName
            // 
            this.txtDepartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartName.Location = new System.Drawing.Point(17, 160);
            this.txtDepartName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDepartName.Name = "txtDepartName";
            this.txtDepartName.Size = new System.Drawing.Size(187, 26);
            this.txtDepartName.TabIndex = 8;
            // 
            // mBtSaveChanges
            // 
            this.mBtSaveChanges.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mBtSaveChanges.ForeColor = System.Drawing.Color.Lime;
            this.mBtSaveChanges.Location = new System.Drawing.Point(293, 141);
            this.mBtSaveChanges.Name = "mBtSaveChanges";
            this.mBtSaveChanges.Size = new System.Drawing.Size(208, 43);
            this.mBtSaveChanges.Style = MetroFramework.MetroColorStyle.Lime;
            this.mBtSaveChanges.TabIndex = 9;
            this.mBtSaveChanges.Text = "Guardar cambios";
            this.mBtSaveChanges.UseSelectable = true;
            this.mBtSaveChanges.Click += new System.EventHandler(this.mBtSaveChanges_Click);
            // 
            // ModifyDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 216);
            this.Controls.Add(this.mBtSaveChanges);
            this.Controls.Add(this.txtDepartName);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mLbDepartCode);
            this.Controls.Add(this.mLbCode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ModifyDepartmentForm";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Modificar Departamento";
            this.Load += new System.EventHandler(this.ModifyDepartmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel mLbCode;
        private MetroFramework.Controls.MetroLabel mLbDepartCode;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TextBox txtDepartName;
        private MetroFramework.Controls.MetroButton mBtSaveChanges;
    }
}