namespace UserInterface
{
    partial class PayrollControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mt_week_hours = new MetroFramework.Controls.MetroTile();
            this.mt_day_hours = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // mt_week_hours
            // 
            this.mt_week_hours.ActiveControl = null;
            this.mt_week_hours.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mt_week_hours.Location = new System.Drawing.Point(331, 269);
            this.mt_week_hours.Name = "mt_week_hours";
            this.mt_week_hours.Size = new System.Drawing.Size(155, 53);
            this.mt_week_hours.TabIndex = 0;
            this.mt_week_hours.Text = "Horas por Semana";
            this.mt_week_hours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mt_week_hours.UseSelectable = true;
            this.mt_week_hours.Click += new System.EventHandler(this.mt_week_hours_Click);
            // 
            // mt_day_hours
            // 
            this.mt_day_hours.ActiveControl = null;
            this.mt_day_hours.Location = new System.Drawing.Point(331, 165);
            this.mt_day_hours.Name = "mt_day_hours";
            this.mt_day_hours.Size = new System.Drawing.Size(155, 53);
            this.mt_day_hours.TabIndex = 1;
            this.mt_day_hours.Text = "Horas por Día ";
            this.mt_day_hours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mt_day_hours.UseSelectable = true;
            this.mt_day_hours.Click += new System.EventHandler(this.mt_day_hours_Click);
            // 
            // PayrollControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mt_day_hours);
            this.Controls.Add(this.mt_week_hours);
            this.Name = "PayrollControl";
            this.Size = new System.Drawing.Size(539, 503);
            this.Load += new System.EventHandler(this.PayrollControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mt_week_hours;
        private MetroFramework.Controls.MetroTile mt_day_hours;
    }
}
