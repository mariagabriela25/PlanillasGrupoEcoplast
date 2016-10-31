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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeUserControl));
            this.mgEmployees = new MetroFramework.Controls.MetroGrid();
            this.mtModify = new MetroFramework.Controls.MetroTile();
            this.mtDelete = new MetroFramework.Controls.MetroTile();
            this.mtAdd = new MetroFramework.Controls.MetroTile();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tb_filter = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mgEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // mgEmployees
            // 
            this.mgEmployees.AllowUserToAddRows = false;
            this.mgEmployees.AllowUserToDeleteRows = false;
            this.mgEmployees.AllowUserToResizeRows = false;
            this.mgEmployees.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgEmployees.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgEmployees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.mgEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgEmployees.DefaultCellStyle = dataGridViewCellStyle5;
            this.mgEmployees.EnableHeadersVisualStyles = false;
            this.mgEmployees.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgEmployees.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgEmployees.Location = new System.Drawing.Point(62, 191);
            this.mgEmployees.Name = "mgEmployees";
            this.mgEmployees.ReadOnly = true;
            this.mgEmployees.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgEmployees.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.mgEmployees.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgEmployees.Size = new System.Drawing.Size(800, 637);
            this.mgEmployees.Style = MetroFramework.MetroColorStyle.Teal;
            this.mgEmployees.TabIndex = 7;
            this.mgEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgEmployees_CellContentClick);
            // 
            // mtModify
            // 
            this.mtModify.ActiveControl = null;
            this.mtModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtModify.Location = new System.Drawing.Point(248, 3);
            this.mtModify.Name = "mtModify";
            this.mtModify.Size = new System.Drawing.Size(195, 59);
            this.mtModify.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtModify.TabIndex = 6;
            this.mtModify.Text = "Modificar";
            this.mtModify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtModify.TileImage = ((System.Drawing.Image)(resources.GetObject("mtModify.TileImage")));
            this.mtModify.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtModify.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtModify.UseSelectable = true;
            this.mtModify.UseTileImage = true;
            this.mtModify.Click += new System.EventHandler(this.mtModify_Click);
            // 
            // mtDelete
            // 
            this.mtDelete.ActiveControl = null;
            this.mtDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtDelete.Location = new System.Drawing.Point(449, 3);
            this.mtDelete.Name = "mtDelete";
            this.mtDelete.Size = new System.Drawing.Size(189, 59);
            this.mtDelete.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtDelete.TabIndex = 5;
            this.mtDelete.Text = "Eliminar";
            this.mtDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtDelete.TileImage = ((System.Drawing.Image)(resources.GetObject("mtDelete.TileImage")));
            this.mtDelete.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtDelete.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtDelete.UseSelectable = true;
            this.mtDelete.UseTileImage = true;
            this.mtDelete.Click += new System.EventHandler(this.mtDelete_Click);
            // 
            // mtAdd
            // 
            this.mtAdd.ActiveControl = null;
            this.mtAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtAdd.Location = new System.Drawing.Point(62, 3);
            this.mtAdd.Name = "mtAdd";
            this.mtAdd.Size = new System.Drawing.Size(180, 59);
            this.mtAdd.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtAdd.TabIndex = 3;
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
            this.metroLabel2.Location = new System.Drawing.Point(62, 142);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(125, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Filtrar por Nombre:";
            // 
            // tb_filter
            // 
            // 
            // 
            // 
            this.tb_filter.CustomButton.Image = null;
            this.tb_filter.CustomButton.Location = new System.Drawing.Point(163, 1);
            this.tb_filter.CustomButton.Name = "";
            this.tb_filter.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_filter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_filter.CustomButton.TabIndex = 1;
            this.tb_filter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_filter.CustomButton.UseSelectable = true;
            this.tb_filter.CustomButton.Visible = false;
            this.tb_filter.Lines = new string[0];
            this.tb_filter.Location = new System.Drawing.Point(193, 142);
            this.tb_filter.MaxLength = 32767;
            this.tb_filter.Name = "tb_filter";
            this.tb_filter.PasswordChar = '\0';
            this.tb_filter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_filter.SelectedText = "";
            this.tb_filter.SelectionLength = 0;
            this.tb_filter.SelectionStart = 0;
            this.tb_filter.ShortcutsEnabled = true;
            this.tb_filter.Size = new System.Drawing.Size(185, 23);
            this.tb_filter.TabIndex = 11;
            this.tb_filter.UseSelectable = true;
            this.tb_filter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_filter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_filter.TextChanged += new System.EventHandler(this.filter);
            // 
            // EmployeeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.tb_filter);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mgEmployees);
            this.Controls.Add(this.mtModify);
            this.Controls.Add(this.mtDelete);
            this.Controls.Add(this.mtAdd);
            this.Name = "EmployeeUserControl";
            this.Size = new System.Drawing.Size(865, 843);
            this.Load += new System.EventHandler(this.EmployeeUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mgEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtAdd;
        private MetroFramework.Controls.MetroTile mtDelete;
        private MetroFramework.Controls.MetroTile mtModify;
        private MetroFramework.Controls.MetroGrid mgEmployees;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tb_filter;
    }
}
