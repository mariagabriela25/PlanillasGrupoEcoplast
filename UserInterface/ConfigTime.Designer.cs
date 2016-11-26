namespace UserInterface
{
    partial class ConfigTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigTime));
            this.numValue = new System.Windows.Forms.NumericUpDown();
            this.bSave = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.numValue)).BeginInit();
            this.SuspendLayout();
            // 
            // numValue
            // 
            this.numValue.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numValue.Location = new System.Drawing.Point(23, 89);
            this.numValue.Name = "numValue";
            this.numValue.Size = new System.Drawing.Size(85, 32);
            this.numValue.TabIndex = 0;
            // 
            // bSave
            // 
            this.bSave.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bSave.Location = new System.Drawing.Point(141, 89);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(120, 32);
            this.bSave.TabIndex = 1;
            this.bSave.Text = "Guardar";
            this.bSave.UseSelectable = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // ConfigTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 165);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.numValue);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigTime";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Cambiar Tiempo";
            this.Load += new System.EventHandler(this.ConfigTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numValue;
        private MetroFramework.Controls.MetroButton bSave;
    }
}