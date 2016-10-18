namespace UserInterface
{
    partial class ScheduleUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleUserControl));
            this.mtAddSchedule = new MetroFramework.Controls.MetroTile();
            this.mtModifySchedule = new MetroFramework.Controls.MetroTile();
            this.mtDeleteSchedule = new MetroFramework.Controls.MetroTile();
            this.mtUpdateSchedule = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // mtAddSchedule
            // 
            this.mtAddSchedule.ActiveControl = null;
            this.mtAddSchedule.Location = new System.Drawing.Point(51, 38);
            this.mtAddSchedule.Name = "mtAddSchedule";
            this.mtAddSchedule.Size = new System.Drawing.Size(266, 76);
            this.mtAddSchedule.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtAddSchedule.TabIndex = 0;
            this.mtAddSchedule.Text = "Agregar";
            this.mtAddSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtAddSchedule.TileImage = ((System.Drawing.Image)(resources.GetObject("mtAddSchedule.TileImage")));
            this.mtAddSchedule.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtAddSchedule.UseSelectable = true;
            this.mtAddSchedule.UseTileImage = true;
            this.mtAddSchedule.Click += new System.EventHandler(this.mtAddSchedule_Click);
            // 
            // mtModifySchedule
            // 
            this.mtModifySchedule.ActiveControl = null;
            this.mtModifySchedule.Location = new System.Drawing.Point(595, 38);
            this.mtModifySchedule.Name = "mtModifySchedule";
            this.mtModifySchedule.Size = new System.Drawing.Size(266, 76);
            this.mtModifySchedule.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtModifySchedule.TabIndex = 3;
            this.mtModifySchedule.Text = "Modificar";
            this.mtModifySchedule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtModifySchedule.TileImage = ((System.Drawing.Image)(resources.GetObject("mtModifySchedule.TileImage")));
            this.mtModifySchedule.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtModifySchedule.UseSelectable = true;
            this.mtModifySchedule.UseTileImage = true;
            // 
            // mtDeleteSchedule
            // 
            this.mtDeleteSchedule.ActiveControl = null;
            this.mtDeleteSchedule.Location = new System.Drawing.Point(867, 38);
            this.mtDeleteSchedule.Name = "mtDeleteSchedule";
            this.mtDeleteSchedule.Size = new System.Drawing.Size(266, 76);
            this.mtDeleteSchedule.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtDeleteSchedule.TabIndex = 4;
            this.mtDeleteSchedule.Text = "Eliminar";
            this.mtDeleteSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtDeleteSchedule.TileImage = ((System.Drawing.Image)(resources.GetObject("mtDeleteSchedule.TileImage")));
            this.mtDeleteSchedule.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtDeleteSchedule.UseSelectable = true;
            this.mtDeleteSchedule.UseTileImage = true;
            // 
            // mtUpdateSchedule
            // 
            this.mtUpdateSchedule.ActiveControl = null;
            this.mtUpdateSchedule.Location = new System.Drawing.Point(323, 38);
            this.mtUpdateSchedule.Name = "mtUpdateSchedule";
            this.mtUpdateSchedule.Size = new System.Drawing.Size(266, 76);
            this.mtUpdateSchedule.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtUpdateSchedule.TabIndex = 5;
            this.mtUpdateSchedule.Text = "Actualizar";
            this.mtUpdateSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtUpdateSchedule.TileImage = ((System.Drawing.Image)(resources.GetObject("mtUpdateSchedule.TileImage")));
            this.mtUpdateSchedule.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtUpdateSchedule.UseSelectable = true;
            this.mtUpdateSchedule.UseTileImage = true;
            // 
            // ScheduleUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.mtUpdateSchedule);
            this.Controls.Add(this.mtDeleteSchedule);
            this.Controls.Add(this.mtModifySchedule);
            this.Controls.Add(this.mtAddSchedule);
            this.Name = "ScheduleUserControl";
            this.Size = new System.Drawing.Size(1178, 755);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtAddSchedule;
        private MetroFramework.Controls.MetroTile mtModifySchedule;
        private MetroFramework.Controls.MetroTile mtDeleteSchedule;
        private MetroFramework.Controls.MetroTile mtUpdateSchedule;
    }
}
