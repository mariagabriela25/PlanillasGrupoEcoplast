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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mtAddSchedule = new MetroFramework.Controls.MetroTile();
            this.mtModifySchedule = new MetroFramework.Controls.MetroTile();
            this.mtDeleteSchedule = new MetroFramework.Controls.MetroTile();
            this.mtUpdateSchedule = new MetroFramework.Controls.MetroTile();
            this.mgSchedules = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.mgSchedules)).BeginInit();
            this.SuspendLayout();
            // 
            // mtAddSchedule
            // 
            this.mtAddSchedule.ActiveControl = null;
            this.mtAddSchedule.Location = new System.Drawing.Point(84, 3);
            this.mtAddSchedule.Name = "mtAddSchedule";
            this.mtAddSchedule.Size = new System.Drawing.Size(266, 76);
            this.mtAddSchedule.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtAddSchedule.TabIndex = 0;
            this.mtAddSchedule.Text = "Agregar";
            this.mtAddSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtAddSchedule.TileImage = ((System.Drawing.Image)(resources.GetObject("mtAddSchedule.TileImage")));
            this.mtAddSchedule.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtAddSchedule.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtAddSchedule.UseSelectable = true;
            this.mtAddSchedule.UseTileImage = true;
            this.mtAddSchedule.Click += new System.EventHandler(this.mtAddSchedule_Click);
            // 
            // mtModifySchedule
            // 
            this.mtModifySchedule.ActiveControl = null;
            this.mtModifySchedule.Location = new System.Drawing.Point(905, 3);
            this.mtModifySchedule.Name = "mtModifySchedule";
            this.mtModifySchedule.Size = new System.Drawing.Size(266, 76);
            this.mtModifySchedule.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtModifySchedule.TabIndex = 3;
            this.mtModifySchedule.Text = "Modificar";
            this.mtModifySchedule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtModifySchedule.TileImage = ((System.Drawing.Image)(resources.GetObject("mtModifySchedule.TileImage")));
            this.mtModifySchedule.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtModifySchedule.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtModifySchedule.UseSelectable = true;
            this.mtModifySchedule.UseTileImage = true;
            this.mtModifySchedule.Visible = false;
            this.mtModifySchedule.Click += new System.EventHandler(this.mtModifySchedule_Click);
            // 
            // mtDeleteSchedule
            // 
            this.mtDeleteSchedule.ActiveControl = null;
            this.mtDeleteSchedule.Location = new System.Drawing.Point(633, 3);
            this.mtDeleteSchedule.Name = "mtDeleteSchedule";
            this.mtDeleteSchedule.Size = new System.Drawing.Size(266, 76);
            this.mtDeleteSchedule.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtDeleteSchedule.TabIndex = 4;
            this.mtDeleteSchedule.Text = "Eliminar";
            this.mtDeleteSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtDeleteSchedule.TileImage = ((System.Drawing.Image)(resources.GetObject("mtDeleteSchedule.TileImage")));
            this.mtDeleteSchedule.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtDeleteSchedule.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtDeleteSchedule.UseSelectable = true;
            this.mtDeleteSchedule.UseTileImage = true;
            this.mtDeleteSchedule.Click += new System.EventHandler(this.mtDeleteSchedule_Click);
            // 
            // mtUpdateSchedule
            // 
            this.mtUpdateSchedule.ActiveControl = null;
            this.mtUpdateSchedule.Location = new System.Drawing.Point(356, 3);
            this.mtUpdateSchedule.Name = "mtUpdateSchedule";
            this.mtUpdateSchedule.Size = new System.Drawing.Size(271, 76);
            this.mtUpdateSchedule.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtUpdateSchedule.TabIndex = 5;
            this.mtUpdateSchedule.Text = "Actualizar";
            this.mtUpdateSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtUpdateSchedule.TileImage = ((System.Drawing.Image)(resources.GetObject("mtUpdateSchedule.TileImage")));
            this.mtUpdateSchedule.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtUpdateSchedule.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtUpdateSchedule.UseSelectable = true;
            this.mtUpdateSchedule.UseTileImage = true;
            this.mtUpdateSchedule.Click += new System.EventHandler(this.mtUpdateSchedule_Click);
            // 
            // mgSchedules
            // 
            this.mgSchedules.AllowUserToResizeRows = false;
            this.mgSchedules.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgSchedules.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgSchedules.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgSchedules.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgSchedules.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.mgSchedules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgSchedules.DefaultCellStyle = dataGridViewCellStyle5;
            this.mgSchedules.EnableHeadersVisualStyles = false;
            this.mgSchedules.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgSchedules.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgSchedules.Location = new System.Drawing.Point(84, 142);
            this.mgSchedules.Name = "mgSchedules";
            this.mgSchedules.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgSchedules.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.mgSchedules.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgSchedules.RowTemplate.Height = 24;
            this.mgSchedules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgSchedules.Size = new System.Drawing.Size(1215, 560);
            this.mgSchedules.Style = MetroFramework.MetroColorStyle.Teal;
            this.mgSchedules.TabIndex = 6;
            // 
            // ScheduleUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.mgSchedules);
            this.Controls.Add(this.mtUpdateSchedule);
            this.Controls.Add(this.mtDeleteSchedule);
            this.Controls.Add(this.mtModifySchedule);
            this.Controls.Add(this.mtAddSchedule);
            this.Name = "ScheduleUserControl";
            this.Size = new System.Drawing.Size(1302, 755);
            this.Load += new System.EventHandler(this.ScheduleUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mgSchedules)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtAddSchedule;
        private MetroFramework.Controls.MetroTile mtModifySchedule;
        private MetroFramework.Controls.MetroTile mtDeleteSchedule;
        private MetroFramework.Controls.MetroTile mtUpdateSchedule;
        private MetroFramework.Controls.MetroGrid mgSchedules;
    }
}
