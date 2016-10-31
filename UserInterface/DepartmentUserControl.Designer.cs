namespace UserInterface
{
    partial class DepartmentUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentUserControl));
            this.mgDepartment = new MetroFramework.Controls.MetroGrid();
            this.mtDelete = new MetroFramework.Controls.MetroTile();
            this.mtModify = new MetroFramework.Controls.MetroTile();
            this.mtAdd = new MetroFramework.Controls.MetroTile();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tb_filter = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mgDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // mgDepartment
            // 
            this.mgDepartment.AllowUserToAddRows = false;
            this.mgDepartment.AllowUserToDeleteRows = false;
            this.mgDepartment.AllowUserToResizeRows = false;
            this.mgDepartment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgDepartment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgDepartment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgDepartment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgDepartment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgDepartment.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgDepartment.EnableHeadersVisualStyles = false;
            this.mgDepartment.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgDepartment.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgDepartment.Location = new System.Drawing.Point(78, 207);
            this.mgDepartment.Name = "mgDepartment";
            this.mgDepartment.ReadOnly = true;
            this.mgDepartment.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgDepartment.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgDepartment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgDepartment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgDepartment.Size = new System.Drawing.Size(639, 287);
            this.mgDepartment.Style = MetroFramework.MetroColorStyle.Teal;
            this.mgDepartment.TabIndex = 9;
            // 
            // mtDelete
            // 
            this.mtDelete.ActiveControl = null;
            this.mtDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtDelete.Location = new System.Drawing.Point(512, 38);
            this.mtDelete.Name = "mtDelete";
            this.mtDelete.Size = new System.Drawing.Size(205, 59);
            this.mtDelete.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtDelete.TabIndex = 8;
            this.mtDelete.Text = "Eliminar";
            this.mtDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtDelete.TileImage = ((System.Drawing.Image)(resources.GetObject("mtDelete.TileImage")));
            this.mtDelete.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtDelete.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtDelete.UseSelectable = true;
            this.mtDelete.UseTileImage = true;
            this.mtDelete.Click += new System.EventHandler(this.mtDelete_Click);
            // 
            // mtModify
            // 
            this.mtModify.ActiveControl = null;
            this.mtModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtModify.Location = new System.Drawing.Point(297, 38);
            this.mtModify.Name = "mtModify";
            this.mtModify.Size = new System.Drawing.Size(209, 59);
            this.mtModify.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtModify.TabIndex = 7;
            this.mtModify.Text = "Modificar";
            this.mtModify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtModify.TileImage = ((System.Drawing.Image)(resources.GetObject("mtModify.TileImage")));
            this.mtModify.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtModify.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtModify.UseSelectable = true;
            this.mtModify.UseTileImage = true;
            this.mtModify.Click += new System.EventHandler(this.mtModify_Click);
            // 
            // mtAdd
            // 
            this.mtAdd.ActiveControl = null;
            this.mtAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtAdd.Location = new System.Drawing.Point(78, 38);
            this.mtAdd.Name = "mtAdd";
            this.mtAdd.Size = new System.Drawing.Size(213, 59);
            this.mtAdd.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtAdd.TabIndex = 4;
            this.mtAdd.Text = "Agregar";
            this.mtAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtAdd.TileImage = ((System.Drawing.Image)(resources.GetObject("mtAdd.TileImage")));
            this.mtAdd.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtAdd.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtAdd.UseSelectable = true;
            this.mtAdd.UseTileImage = true;
            this.mtAdd.Click += new System.EventHandler(this.mtAdd_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(78, 162);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(125, 19);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Filtrar por Nombre:";
            // 
            // tb_filter
            // 
            // 
            // 
            // 
            this.tb_filter.CustomButton.Image = null;
            this.tb_filter.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.tb_filter.CustomButton.Name = "";
            this.tb_filter.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_filter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_filter.CustomButton.TabIndex = 1;
            this.tb_filter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_filter.CustomButton.UseSelectable = true;
            this.tb_filter.CustomButton.Visible = false;
            this.tb_filter.Lines = new string[0];
            this.tb_filter.Location = new System.Drawing.Point(209, 162);
            this.tb_filter.MaxLength = 32767;
            this.tb_filter.Name = "tb_filter";
            this.tb_filter.PasswordChar = '\0';
            this.tb_filter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_filter.SelectedText = "";
            this.tb_filter.SelectionLength = 0;
            this.tb_filter.SelectionStart = 0;
            this.tb_filter.ShortcutsEnabled = true;
            this.tb_filter.Size = new System.Drawing.Size(184, 23);
            this.tb_filter.TabIndex = 13;
            this.tb_filter.UseSelectable = true;
            this.tb_filter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_filter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_filter.TextChanged += new System.EventHandler(this.filter);
            // 
            // DepartmentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.tb_filter);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mgDepartment);
            this.Controls.Add(this.mtDelete);
            this.Controls.Add(this.mtModify);
            this.Controls.Add(this.mtAdd);
            this.Name = "DepartmentUserControl";
            this.Size = new System.Drawing.Size(740, 512);
            this.Load += new System.EventHandler(this.DepartmentUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mgDepartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtAdd;
        private MetroFramework.Controls.MetroTile mtModify;
        private MetroFramework.Controls.MetroTile mtDelete;
        private MetroFramework.Controls.MetroGrid mgDepartment;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tb_filter;
    }
}
