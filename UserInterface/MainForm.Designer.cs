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
            this.metroUserControl1 = new MetroFramework.Controls.MetroUserControl();
            this.mpMenu = new MetroFramework.Controls.MetroPanel();
            this.mpContent = new MetroFramework.Controls.MetroPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // metroUserControl1
            // 
            resources.ApplyResources(this.metroUserControl1, "metroUserControl1");
            this.metroUserControl1.Name = "metroUserControl1";
            this.metroUserControl1.UseSelectable = true;
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
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.ForeColor = System.Drawing.Color.Lime;
            this.lblTitle.Name = "lblTitle";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.mpContent);
            this.Controls.Add(this.mpMenu);
            this.Controls.Add(this.metroUserControl1);
            this.Name = "MainForm";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroUserControl metroUserControl1;
        private MetroFramework.Controls.MetroPanel mpMenu;
        private MetroFramework.Controls.MetroPanel mpContent;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
    }
}