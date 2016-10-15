namespace UserInterface
{
    partial class RestsUserControl
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
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(157, 172);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(75, 23);
            this.metroLink1.TabIndex = 0;
            this.metroLink1.Text = "metroLink1";
            // 
            // RestsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroLink1);
            this.Name = "RestsUserControl";
            this.Size = new System.Drawing.Size(626, 424);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink metroLink1;
    }
}
