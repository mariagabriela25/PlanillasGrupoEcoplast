namespace UserInterface
{
    partial class MenuUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuUserControl));
            this.mtEmployees = new MetroFramework.Controls.MetroTile();
            this.mtDepartments = new MetroFramework.Controls.MetroTile();
            this.mtSchedules = new MetroFramework.Controls.MetroTile();
            this.mtRests = new MetroFramework.Controls.MetroTile();
            this.mtPayroll = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // mtEmployees
            // 
            this.mtEmployees.ActiveControl = null;
            this.mtEmployees.BackColor = System.Drawing.SystemColors.Control;
            this.mtEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtEmployees.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mtEmployees.Location = new System.Drawing.Point(0, 94);
            this.mtEmployees.Name = "mtEmployees";
            this.mtEmployees.Size = new System.Drawing.Size(153, 85);
            this.mtEmployees.Style = MetroFramework.MetroColorStyle.Lime;
            this.mtEmployees.TabIndex = 0;
            this.mtEmployees.Text = "Empleados";
            this.mtEmployees.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtEmployees.TileImage = ((System.Drawing.Image)(resources.GetObject("mtEmployees.TileImage")));
            this.mtEmployees.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtEmployees.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtEmployees.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtEmployees.UseSelectable = true;
            this.mtEmployees.UseTileImage = true;
            // 
            // mtDepartments
            // 
            this.mtDepartments.ActiveControl = null;
            this.mtDepartments.BackColor = System.Drawing.SystemColors.Control;
            this.mtDepartments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtDepartments.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mtDepartments.Location = new System.Drawing.Point(0, 185);
            this.mtDepartments.Name = "mtDepartments";
            this.mtDepartments.Size = new System.Drawing.Size(153, 85);
            this.mtDepartments.Style = MetroFramework.MetroColorStyle.Lime;
            this.mtDepartments.TabIndex = 1;
            this.mtDepartments.Text = "Departamentos";
            this.mtDepartments.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtDepartments.TileImage = ((System.Drawing.Image)(resources.GetObject("mtDepartments.TileImage")));
            this.mtDepartments.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtDepartments.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtDepartments.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtDepartments.UseSelectable = true;
            this.mtDepartments.UseTileImage = true;
            // 
            // mtSchedules
            // 
            this.mtSchedules.ActiveControl = null;
            this.mtSchedules.BackColor = System.Drawing.SystemColors.Control;
            this.mtSchedules.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtSchedules.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mtSchedules.Location = new System.Drawing.Point(0, 277);
            this.mtSchedules.Name = "mtSchedules";
            this.mtSchedules.Size = new System.Drawing.Size(153, 85);
            this.mtSchedules.Style = MetroFramework.MetroColorStyle.Lime;
            this.mtSchedules.TabIndex = 2;
            this.mtSchedules.Text = "Horarios";
            this.mtSchedules.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtSchedules.TileImage = ((System.Drawing.Image)(resources.GetObject("mtSchedules.TileImage")));
            this.mtSchedules.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtSchedules.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtSchedules.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtSchedules.UseSelectable = true;
            this.mtSchedules.UseTileImage = true;
            // 
            // mtRests
            // 
            this.mtRests.ActiveControl = null;
            this.mtRests.BackColor = System.Drawing.SystemColors.Control;
            this.mtRests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtRests.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mtRests.Location = new System.Drawing.Point(0, 368);
            this.mtRests.Name = "mtRests";
            this.mtRests.Size = new System.Drawing.Size(153, 85);
            this.mtRests.Style = MetroFramework.MetroColorStyle.Lime;
            this.mtRests.TabIndex = 3;
            this.mtRests.Text = "Descansos";
            this.mtRests.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtRests.TileImage = ((System.Drawing.Image)(resources.GetObject("mtRests.TileImage")));
            this.mtRests.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtRests.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtRests.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtRests.UseSelectable = true;
            this.mtRests.UseTileImage = true;
            this.mtRests.Click += new System.EventHandler(this.mtRests_Click);
            // 
            // mtPayroll
            // 
            this.mtPayroll.ActiveControl = null;
            this.mtPayroll.BackColor = System.Drawing.SystemColors.Control;
            this.mtPayroll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtPayroll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mtPayroll.Location = new System.Drawing.Point(0, 3);
            this.mtPayroll.Name = "mtPayroll";
            this.mtPayroll.Size = new System.Drawing.Size(153, 85);
            this.mtPayroll.Style = MetroFramework.MetroColorStyle.Lime;
            this.mtPayroll.TabIndex = 4;
            this.mtPayroll.Text = "Planillas";
            this.mtPayroll.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtPayroll.TileImage = ((System.Drawing.Image)(resources.GetObject("mtPayroll.TileImage")));
            this.mtPayroll.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtPayroll.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtPayroll.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtPayroll.UseSelectable = true;
            this.mtPayroll.UseTileImage = true;
            this.mtPayroll.Click += new System.EventHandler(this.mtPayroll_Click);
            // 
            // MenuUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.Controls.Add(this.mtPayroll);
            this.Controls.Add(this.mtRests);
            this.Controls.Add(this.mtSchedules);
            this.Controls.Add(this.mtDepartments);
            this.Controls.Add(this.mtEmployees);
            this.Name = "MenuUserControl";
            this.Size = new System.Drawing.Size(157, 550);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtEmployees;
        private MetroFramework.Controls.MetroTile mtDepartments;
        private MetroFramework.Controls.MetroTile mtSchedules;
        private MetroFramework.Controls.MetroTile mtRests;
        private MetroFramework.Controls.MetroTile mtPayroll;
    }
}
