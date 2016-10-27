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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleUserControl));
            this.mgSchedules = new MetroFramework.Controls.MetroGrid();
            this.mtUpdateSchedule = new MetroFramework.Controls.MetroTile();
            this.mtDeleteSchedule = new MetroFramework.Controls.MetroTile();
            this.mtAddSchedule = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.mgSchedules)).BeginInit();
            this.SuspendLayout();
            // 
            // mgSchedules
            // 
            this.mgSchedules.AllowUserToAddRows = false;
            this.mgSchedules.AllowUserToDeleteRows = false;
            this.mgSchedules.AllowUserToResizeRows = false;
            this.mgSchedules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.mgSchedules.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.mgSchedules.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgSchedules.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgSchedules.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgSchedules.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.mgSchedules.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgSchedules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgSchedules.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgSchedules.EnableHeadersVisualStyles = false;
            this.mgSchedules.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgSchedules.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgSchedules.Location = new System.Drawing.Point(18, 85);
            this.mgSchedules.Name = "mgSchedules";
            this.mgSchedules.ReadOnly = true;
            this.mgSchedules.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgSchedules.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgSchedules.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgSchedules.RowTemplate.Height = 24;
            this.mgSchedules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgSchedules.Size = new System.Drawing.Size(1662, 627);
            this.mgSchedules.Style = MetroFramework.MetroColorStyle.Teal;
            this.mgSchedules.TabIndex = 6;
            // 
            // mtUpdateSchedule
            // 
            this.mtUpdateSchedule.ActiveControl = null;
            this.mtUpdateSchedule.Location = new System.Drawing.Point(521, 3);
            this.mtUpdateSchedule.Name = "mtUpdateSchedule";
            this.mtUpdateSchedule.Size = new System.Drawing.Size(581, 76);
            this.mtUpdateSchedule.Style = MetroFramework.MetroColorStyle.Silver;
            this.mtUpdateSchedule.TabIndex = 5;
            this.mtUpdateSchedule.Text = "Modificar";
            this.mtUpdateSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtUpdateSchedule.TileImage = ((System.Drawing.Image)(resources.GetObject("mtUpdateSchedule.TileImage")));
            this.mtUpdateSchedule.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtUpdateSchedule.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtUpdateSchedule.UseSelectable = true;
            this.mtUpdateSchedule.UseTileImage = true;
            this.mtUpdateSchedule.Click += new System.EventHandler(this.mtUpdateSchedule_Click);
            // 
            // mtDeleteSchedule
            // 
            this.mtDeleteSchedule.ActiveControl = null;
            this.mtDeleteSchedule.Location = new System.Drawing.Point(1108, 3);
            this.mtDeleteSchedule.Name = "mtDeleteSchedule";
            this.mtDeleteSchedule.Size = new System.Drawing.Size(549, 76);
            this.mtDeleteSchedule.Style = MetroFramework.MetroColorStyle.Red;
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
            // mtAddSchedule
            // 
            this.mtAddSchedule.ActiveControl = null;
            this.mtAddSchedule.Location = new System.Drawing.Point(18, 3);
            this.mtAddSchedule.Name = "mtAddSchedule";
            this.mtAddSchedule.Size = new System.Drawing.Size(497, 76);
            this.mtAddSchedule.Style = MetroFramework.MetroColorStyle.Silver;
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
            // ScheduleUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.mgSchedules);
            this.Controls.Add(this.mtUpdateSchedule);
            this.Controls.Add(this.mtDeleteSchedule);
            this.Controls.Add(this.mtAddSchedule);
            this.Name = "ScheduleUserControl";
            this.Size = new System.Drawing.Size(1791, 755);
            this.Load += new System.EventHandler(this.ScheduleUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mgSchedules)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtAddSchedule;
        private MetroFramework.Controls.MetroTile mtDeleteSchedule;
        private MetroFramework.Controls.MetroTile mtUpdateSchedule;
        private MetroFramework.Controls.MetroGrid mgSchedules;
    }
}
