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
            this.title.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(-7, 10);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(520, 37);
            this.title.TabIndex = 1;
            this.title.Text = "Detalle de horas laboradas para la semana";
            // 
            // pb
            // 
            this.pb.Image = global::UserInterface.Properties.Resources.spinner2;
            this.pb.InitialImage = global::UserInterface.Properties.Resources.spinner;
            this.pb.Location = new System.Drawing.Point(52, 76);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(293, 273);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb.TabIndex = 2;
            this.pb.TabStop = false;
            // 
            // WelcomeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pb);
            this.Controls.Add(this.title);
            this.Name = "WelcomeUserControl";
            this.Size = new System.Drawing.Size(677, 665);
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
