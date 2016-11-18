namespace UserInterface
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mpMenu = new MetroFramework.Controls.MetroPanel();
            this.mpContent = new MetroFramework.Controls.MetroPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // mpMenu
            // 
            resources.ApplyResources(this.mpMenu, "mpMenu");
            this.mpMenu.HorizontalScrollbarBarColor = false;
            this.mpMenu.HorizontalScrollbarHighlightOnWheel = false;
            this.mpMenu.HorizontalScrollbarSize = 0;
            this.mpMenu.Name = "mpMenu";
            this.mpMenu.VerticalScrollbarBarColor = false;
            this.mpMenu.VerticalScrollbarHighlightOnWheel = false;
            this.mpMenu.VerticalScrollbarSize = 0;
            // 
            // mpContent
            // 
            resources.ApplyResources(this.mpContent, "mpContent");
            this.mpContent.HorizontalScrollbar = true;
            this.mpContent.HorizontalScrollbarBarColor = false;
            this.mpContent.HorizontalScrollbarHighlightOnWheel = false;
            this.mpContent.HorizontalScrollbarSize = 0;
            this.mpContent.Name = "mpContent";
            this.mpContent.VerticalScrollbar = true;
            this.mpContent.VerticalScrollbarBarColor = false;
            this.mpContent.VerticalScrollbarHighlightOnWheel = false;
            this.mpContent.VerticalScrollbarSize = 0;
            this.mpContent.Paint += new System.Windows.Forms.PaintEventHandler(this.mpContent_Paint);
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UserInterface.Properties.Resources.Material_Icons_e869_0__64;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.Name = "btnBack";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mpContent);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.mpMenu);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroPanel mpMenu;
        private MetroFramework.Controls.MetroPanel mpContent;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}