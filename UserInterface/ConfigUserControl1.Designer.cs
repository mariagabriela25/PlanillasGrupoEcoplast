namespace UserInterface
{
    partial class ConfigUserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.allowedN = new MetroFramework.Controls.MetroLabel();
            this.allowedP = new MetroFramework.Controls.MetroLabel();
            this.penaltyP = new MetroFramework.Controls.MetroLabel();
            this.penaltyN = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // allowedN
            // 
            this.allowedN.AutoSize = true;
            this.allowedN.Location = new System.Drawing.Point(65, 122);
            this.allowedN.Name = "allowedN";
            this.allowedN.Size = new System.Drawing.Size(233, 19);
            this.allowedN.TabIndex = 0;
            this.allowedN.Text = "Entrada después de la hora permitida:";
            // 
            // allowedP
            // 
            this.allowedP.AutoSize = true;
            this.allowedP.Location = new System.Drawing.Point(65, 223);
            this.allowedP.Name = "allowedP";
            this.allowedP.Size = new System.Drawing.Size(206, 19);
            this.allowedP.TabIndex = 1;
            this.allowedP.Text = "Salida antes de la hora permitida:";
            // 
            // penaltyP
            // 
            this.penaltyP.AutoSize = true;
            this.penaltyP.Location = new System.Drawing.Point(65, 172);
            this.penaltyP.Name = "penaltyP";
            this.penaltyP.Size = new System.Drawing.Size(216, 19);
            this.penaltyP.TabIndex = 2;
            this.penaltyP.Text = "Entrada antes de la hora permitida:";
            // 
            // penaltyN
            // 
            this.penaltyN.AutoSize = true;
            this.penaltyN.Location = new System.Drawing.Point(65, 271);
            this.penaltyN.Name = "penaltyN";
            this.penaltyN.Size = new System.Drawing.Size(223, 19);
            this.penaltyN.TabIndex = 3;
            this.penaltyN.Text = "Salida después de la hora permitida:";
            // 
            // ConfigUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.penaltyN);
            this.Controls.Add(this.penaltyP);
            this.Controls.Add(this.allowedP);
            this.Controls.Add(this.allowedN);
            this.Name = "ConfigUserControl1";
            this.Size = new System.Drawing.Size(545, 366);
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Load += new System.EventHandler(this.ConfigUserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel allowedN;
        private MetroFramework.Controls.MetroLabel allowedP;
        private MetroFramework.Controls.MetroLabel penaltyP;
        private MetroFramework.Controls.MetroLabel penaltyN;
    }
}
