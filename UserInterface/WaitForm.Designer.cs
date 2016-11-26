namespace UserInterface
{
    partial class WaitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaitForm));
            this.lbMessage = new System.Windows.Forms.Label();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.SuspendLayout();
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.Location = new System.Drawing.Point(17, 107);
            this.lbMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(250, 18);
            this.lbMessage.TabIndex = 0;
            this.lbMessage.Text = "Registrando entradas aprobadas...";
            this.lbMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Location = new System.Drawing.Point(130, 26);
            this.metroProgressSpinner1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(66, 56);
            this.metroProgressSpinner1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroProgressSpinner1.TabIndex = 1;
            this.metroProgressSpinner1.UseSelectable = true;
            // 
            // WaitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 142);
            this.Controls.Add(this.metroProgressSpinner1);
            this.Controls.Add(this.lbMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "WaitForm";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMessage;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
    }
}