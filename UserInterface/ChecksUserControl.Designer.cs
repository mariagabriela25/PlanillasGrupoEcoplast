namespace UserInterface
{
    partial class ChecksUserControl
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mdtFinalDate = new MetroFramework.Controls.MetroDateTime();
            this.mdtInitialDate = new MetroFramework.Controls.MetroDateTime();
            this.mbSave = new MetroFramework.Controls.MetroButton();
            this.mlvEmployees = new MetroFramework.Controls.MetroListView();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(36, 47);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(144, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "FECHA INICIAL:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(50, 107);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(130, 25);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "FECHA FINAL:";
            // 
            // mdtFinalDate
            // 
            this.mdtFinalDate.Location = new System.Drawing.Point(367, 102);
            this.mdtFinalDate.Margin = new System.Windows.Forms.Padding(4);
            this.mdtFinalDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdtFinalDate.Name = "mdtFinalDate";
            this.mdtFinalDate.Size = new System.Drawing.Size(363, 29);
            this.mdtFinalDate.TabIndex = 19;
            this.mdtFinalDate.ValueChanged += new System.EventHandler(this.mdtFinalDate_ValueChanged);
            // 
            // mdtInitialDate
            // 
            this.mdtInitialDate.Location = new System.Drawing.Point(367, 42);
            this.mdtInitialDate.Margin = new System.Windows.Forms.Padding(4);
            this.mdtInitialDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdtInitialDate.Name = "mdtInitialDate";
            this.mdtInitialDate.Size = new System.Drawing.Size(363, 29);
            this.mdtInitialDate.TabIndex = 20;
            this.mdtInitialDate.ValueChanged += new System.EventHandler(this.mdtInitialDate_ValueChanged);
            // 
            // mbSave
            // 
            this.mbSave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbSave.ForeColor = System.Drawing.Color.Lime;
            this.mbSave.Location = new System.Drawing.Point(465, 706);
            this.mbSave.Margin = new System.Windows.Forms.Padding(4);
            this.mbSave.Name = "mbSave";
            this.mbSave.Size = new System.Drawing.Size(265, 61);
            this.mbSave.Style = MetroFramework.MetroColorStyle.Lime;
            this.mbSave.TabIndex = 22;
            this.mbSave.Text = "Cargar Marcas";
            this.mbSave.UseSelectable = true;
            this.mbSave.Click += new System.EventHandler(this.mbSave_Click);
            // 
            // mlvEmployees
            // 
            this.mlvEmployees.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.mlvEmployees.AllowSorting = true;
            this.mlvEmployees.Font = new System.Drawing.Font("Arial", 16F);
            this.mlvEmployees.FullRowSelect = true;
            this.mlvEmployees.Location = new System.Drawing.Point(36, 175);
            this.mlvEmployees.Margin = new System.Windows.Forms.Padding(0);
            this.mlvEmployees.Name = "mlvEmployees";
            this.mlvEmployees.OwnerDraw = true;
            this.mlvEmployees.Size = new System.Drawing.Size(694, 497);
            this.mlvEmployees.Style = MetroFramework.MetroColorStyle.Lime;
            this.mlvEmployees.TabIndex = 23;
            this.mlvEmployees.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mlvEmployees.UseCompatibleStateImageBehavior = false;
            this.mlvEmployees.UseSelectable = true;
            // 
            // ChecksUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mlvEmployees);
            this.Controls.Add(this.mbSave);
            this.Controls.Add(this.mdtInitialDate);
            this.Controls.Add(this.mdtFinalDate);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ChecksUserControl";
            this.Size = new System.Drawing.Size(888, 804);
            this.Load += new System.EventHandler(this.ChecksUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime mdtFinalDate;
        private MetroFramework.Controls.MetroDateTime mdtInitialDate;
        private MetroFramework.Controls.MetroButton mbSave;
        private MetroFramework.Controls.MetroListView mlvEmployees;
    }
}