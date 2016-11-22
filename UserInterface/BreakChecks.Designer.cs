namespace UserInterface
{
    partial class BreakChecks
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
            this.gb = new System.Windows.Forms.GroupBox();
            this.lbChecks = new System.Windows.Forms.Label();
            this.gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb
            // 
            this.gb.Controls.Add(this.lbChecks);
            this.gb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb.Location = new System.Drawing.Point(33, 91);
            this.gb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb.Name = "gb";
            this.gb.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb.Size = new System.Drawing.Size(439, 524);
            this.gb.TabIndex = 0;
            this.gb.TabStop = false;
            this.gb.Text = "groupBox1";
            // 
            // lbChecks
            // 
            this.lbChecks.AutoSize = true;
            this.lbChecks.Location = new System.Drawing.Point(20, 43);
            this.lbChecks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbChecks.Name = "lbChecks";
            this.lbChecks.Size = new System.Drawing.Size(0, 23);
            this.lbChecks.TabIndex = 0;
            // 
            // BreakChecks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 644);
            this.Controls.Add(this.gb);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BreakChecks";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Detalle de marcas de descanso.";
            this.Load += new System.EventHandler(this.BreakChecks_Load);
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.Label lbChecks;
    }
}
