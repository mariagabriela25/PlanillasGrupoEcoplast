namespace UserInterface
{
    partial class WelcomeUserControl
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
            this.title = new System.Windows.Forms.Label();
            this.pb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.White;
            this.title.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(391, 116);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(266, 28);
            this.title.TabIndex = 1;
            this.title.Text = "Horas laboradas por día";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb
            // 
            this.pb.Image = global::UserInterface.Properties.Resources.spinner2;
            this.pb.InitialImage = global::UserInterface.Properties.Resources.spinner;
            this.pb.Location = new System.Drawing.Point(457, 301);
            this.pb.Margin = new System.Windows.Forms.Padding(4);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(391, 336);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb.TabIndex = 2;
            this.pb.TabStop = false;
            // 
            // WelcomeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pb);
            this.Controls.Add(this.title);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WelcomeUserControl";
            this.Size = new System.Drawing.Size(1402, 727);
            this.Load += new System.EventHandler(this.WelcomeUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

      
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox pb;
    }
}
