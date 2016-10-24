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
            this.mgDepartment.Location = new System.Drawing.Point(104, 155);
            this.mgDepartment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.mgDepartment.Size = new System.Drawing.Size(852, 453);
            this.mgDepartment.Style = MetroFramework.MetroColorStyle.Teal;
            this.mgDepartment.TabIndex = 9;
            // 
            // mtDelete
            // 
            this.mtDelete.ActiveControl = null;
            this.mtDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtDelete.Location = new System.Drawing.Point(683, 47);
            this.mtDelete.Margin = new System.Windows.Forms.Padding(4);
            this.mtDelete.Name = "mtDelete";
            this.mtDelete.Size = new System.Drawing.Size(273, 73);
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
            this.mtModify.Location = new System.Drawing.Point(396, 47);
            this.mtModify.Margin = new System.Windows.Forms.Padding(4);
            this.mtModify.Name = "mtModify";
            this.mtModify.Size = new System.Drawing.Size(279, 73);
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
            this.mtAdd.Location = new System.Drawing.Point(104, 47);
            this.mtAdd.Margin = new System.Windows.Forms.Padding(4);
            this.mtAdd.Name = "mtAdd";
            this.mtAdd.Size = new System.Drawing.Size(284, 73);
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
            // DepartmentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.mgDepartment);
            this.Controls.Add(this.mtDelete);
            this.Controls.Add(this.mtModify);
            this.Controls.Add(this.mtAdd);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DepartmentUserControl";
            this.Size = new System.Drawing.Size(987, 630);
            this.Load += new System.EventHandler(this.DepartmentUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mgDepartment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtAdd;
        private MetroFramework.Controls.MetroTile mtModify;
        private MetroFramework.Controls.MetroTile mtDelete;
        private MetroFramework.Controls.MetroGrid mgDepartment;
    }
}
