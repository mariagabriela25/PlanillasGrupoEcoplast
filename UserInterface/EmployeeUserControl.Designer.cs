namespace UserInterface
{
    partial class EmployeeUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeUserControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mtAdd = new MetroFramework.Controls.MetroTile();
            this.mtRefresh = new MetroFramework.Controls.MetroTile();
            this.mtDelete = new MetroFramework.Controls.MetroTile();
            this.mtModify = new MetroFramework.Controls.MetroTile();
            this.mgEmployees = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.mgEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // mtAdd
            // 
            this.mtAdd.ActiveControl = null;
            this.mtAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtAdd.Location = new System.Drawing.Point(13, 25);
            this.mtAdd.Name = "mtAdd";
            this.mtAdd.Size = new System.Drawing.Size(135, 46);
            this.mtAdd.Style = MetroFramework.MetroColorStyle.Lime;
            this.mtAdd.TabIndex = 3;
            this.mtAdd.Text = "Agregar";
            this.mtAdd.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.mtAdd.TileImage = ((System.Drawing.Image)(resources.GetObject("mtAdd.TileImage")));
            this.mtAdd.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtAdd.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtAdd.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtAdd.UseSelectable = true;
            this.mtAdd.UseTileImage = true;
            this.mtAdd.Click += new System.EventHandler(this.mtAdd_Click);
            // 
            // mtRefresh
            // 
            this.mtRefresh.ActiveControl = null;
            this.mtRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtRefresh.Location = new System.Drawing.Point(163, 25);
            this.mtRefresh.Name = "mtRefresh";
            this.mtRefresh.Size = new System.Drawing.Size(135, 46);
            this.mtRefresh.Style = MetroFramework.MetroColorStyle.Lime;
            this.mtRefresh.TabIndex = 4;
            this.mtRefresh.Text = "Actualizar";
            this.mtRefresh.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.mtRefresh.TileImage = ((System.Drawing.Image)(resources.GetObject("mtRefresh.TileImage")));
            this.mtRefresh.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtRefresh.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtRefresh.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtRefresh.UseSelectable = true;
            this.mtRefresh.UseTileImage = true;
            this.mtRefresh.Click += new System.EventHandler(this.mtRefresh_Click);
            // 
            // mtDelete
            // 
            this.mtDelete.ActiveControl = null;
            this.mtDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtDelete.Location = new System.Drawing.Point(464, 25);
            this.mtDelete.Name = "mtDelete";
            this.mtDelete.Size = new System.Drawing.Size(135, 46);
            this.mtDelete.Style = MetroFramework.MetroColorStyle.Lime;
            this.mtDelete.TabIndex = 5;
            this.mtDelete.Text = "Eliminar";
            this.mtDelete.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.mtDelete.TileImage = ((System.Drawing.Image)(resources.GetObject("mtDelete.TileImage")));
            this.mtDelete.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtDelete.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtDelete.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtDelete.UseSelectable = true;
            this.mtDelete.UseTileImage = true;
            // 
            // mtModify
            // 
            this.mtModify.ActiveControl = null;
            this.mtModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtModify.Location = new System.Drawing.Point(313, 25);
            this.mtModify.Name = "mtModify";
            this.mtModify.Size = new System.Drawing.Size(135, 46);
            this.mtModify.Style = MetroFramework.MetroColorStyle.Lime;
            this.mtModify.TabIndex = 6;
            this.mtModify.Text = "Modificar";
            this.mtModify.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.mtModify.TileImage = ((System.Drawing.Image)(resources.GetObject("mtModify.TileImage")));
            this.mtModify.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtModify.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtModify.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtModify.UseSelectable = true;
            this.mtModify.UseTileImage = true;
            // 
            // mgEmployees
            // 
            this.mgEmployees.AllowUserToResizeRows = false;
            this.mgEmployees.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgEmployees.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgEmployees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgEmployees.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgEmployees.EnableHeadersVisualStyles = false;
            this.mgEmployees.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgEmployees.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgEmployees.Location = new System.Drawing.Point(13, 88);
            this.mgEmployees.Name = "mgEmployees";
            this.mgEmployees.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgEmployees.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgEmployees.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgEmployees.Size = new System.Drawing.Size(586, 312);
            this.mgEmployees.Style = MetroFramework.MetroColorStyle.Lime;
            this.mgEmployees.TabIndex = 7;
            this.mgEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgEmployees_CellContentClick);
            // 
            // EmployeeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.mgEmployees);
            this.Controls.Add(this.mtModify);
            this.Controls.Add(this.mtDelete);
            this.Controls.Add(this.mtRefresh);
            this.Controls.Add(this.mtAdd);
            this.Name = "EmployeeUserControl";
            this.Size = new System.Drawing.Size(626, 424);
            this.Load += new System.EventHandler(this.EmployeeUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mgEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtAdd;
        private MetroFramework.Controls.MetroTile mtRefresh;
        private MetroFramework.Controls.MetroTile mtDelete;
        private MetroFramework.Controls.MetroTile mtModify;
        private MetroFramework.Controls.MetroGrid mgEmployees;
    }
}
