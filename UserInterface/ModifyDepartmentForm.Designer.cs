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
            this.mLbCode.Location = new System.Drawing.Point(23, 87);
            this.mLbCode.Name = "mLbCode";
            this.mLbCode.Size = new System.Drawing.Size(76, 25);
            this.mLbCode.TabIndex = 1;
            this.mLbCode.Text = "Código:";
            // 
            // mLbDepartCode
            // 
            this.mLbDepartCode.AutoSize = true;
            this.mLbDepartCode.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mLbDepartCode.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mLbDepartCode.Location = new System.Drawing.Point(147, 87);
            this.mLbDepartCode.Name = "mLbDepartCode";
            this.mLbDepartCode.Size = new System.Drawing.Size(159, 25);
            this.mLbDepartCode.TabIndex = 6;
            this.mLbDepartCode.Text = "mLbDepartCode";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(23, 154);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(79, 25);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Nombre";
            // 
            // txtDepartName
            // 
            this.txtDepartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartName.Location = new System.Drawing.Point(23, 197);
            this.txtDepartName.Name = "txtDepartName";
            this.txtDepartName.Size = new System.Drawing.Size(248, 30);
            this.txtDepartName.TabIndex = 8;
            // 
            // mBtSaveChanges
            // 
            this.mBtSaveChanges.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mBtSaveChanges.ForeColor = System.Drawing.Color.Lime;
            this.mBtSaveChanges.Location = new System.Drawing.Point(391, 174);
            this.mBtSaveChanges.Margin = new System.Windows.Forms.Padding(4);
            this.mBtSaveChanges.Name = "mBtSaveChanges";
            this.mBtSaveChanges.Size = new System.Drawing.Size(278, 53);
            this.mBtSaveChanges.Style = MetroFramework.MetroColorStyle.Lime;
            this.mBtSaveChanges.TabIndex = 9;
            this.mBtSaveChanges.Text = "Guardar cambios";
            this.mBtSaveChanges.UseSelectable = true;
            this.mBtSaveChanges.Click += new System.EventHandler(this.mBtSaveChanges_Click);
            // 
            // ModifyDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 266);
            this.Controls.Add(this.mBtSaveChanges);
            this.Controls.Add(this.txtDepartName);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mLbDepartCode);
            this.Controls.Add(this.mLbCode);
            this.Name = "ModifyDepartmentForm";
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