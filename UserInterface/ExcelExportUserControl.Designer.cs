namespace UserInterface
{
    partial class ExcelExportUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelExportUserControl));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mcbWeeks = new MetroFramework.Controls.MetroComboBox();
            this.ml2 = new MetroFramework.Controls.MetroLabel();
            this.mbPicker = new MetroFramework.Controls.MetroButton();
            this.mtExport = new MetroFramework.Controls.MetroTile();
            this.mtbPath = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(66, 38);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Semana";
            // 
            // mcbWeeks
            // 
            this.mcbWeeks.FormattingEnabled = true;
            this.mcbWeeks.ItemHeight = 23;
            this.mcbWeeks.Location = new System.Drawing.Point(66, 69);
            this.mcbWeeks.Name = "mcbWeeks";
            this.mcbWeeks.Size = new System.Drawing.Size(121, 29);
            this.mcbWeeks.TabIndex = 1;
            this.mcbWeeks.UseSelectable = true;
            // 
            // ml2
            // 
            this.ml2.AutoSize = true;
            this.ml2.Location = new System.Drawing.Point(69, 148);
            this.ml2.Name = "ml2";
            this.ml2.Size = new System.Drawing.Size(118, 19);
            this.ml2.TabIndex = 2;
            this.ml2.Text = "Archivo de destino";
            // 
            // mbPicker
            // 
            this.mbPicker.Location = new System.Drawing.Point(69, 187);
            this.mbPicker.Name = "mbPicker";
            this.mbPicker.Size = new System.Drawing.Size(118, 33);
            this.mbPicker.TabIndex = 3;
            this.mbPicker.Text = "Buscar Archivo";
            this.mbPicker.UseSelectable = true;
            this.mbPicker.Click += new System.EventHandler(this.mbPicker_Click);
            // 
            // mtExport
            // 
            this.mtExport.ActiveControl = null;
            this.mtExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtExport.Location = new System.Drawing.Point(66, 291);
            this.mtExport.Name = "mtExport";
            this.mtExport.Size = new System.Drawing.Size(200, 59);
            this.mtExport.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtExport.TabIndex = 5;
            this.mtExport.Text = "Exportar";
            this.mtExport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtExport.TileImage = ((System.Drawing.Image)(resources.GetObject("mtExport.TileImage")));
            this.mtExport.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtExport.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtExport.UseSelectable = true;
            this.mtExport.UseTileImage = true;
            this.mtExport.Click += new System.EventHandler(this.mtExport_Click);
            // 
            // mtbPath
            // 
            // 
            // 
            // 
            this.mtbPath.CustomButton.Image = null;
            this.mtbPath.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.mtbPath.CustomButton.Name = "";
            this.mtbPath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbPath.CustomButton.TabIndex = 1;
            this.mtbPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbPath.CustomButton.UseSelectable = true;
            this.mtbPath.CustomButton.Visible = false;
            this.mtbPath.Lines = new string[0];
            this.mtbPath.Location = new System.Drawing.Point(270, 187);
            this.mtbPath.MaxLength = 32767;
            this.mtbPath.Name = "mtbPath";
            this.mtbPath.PasswordChar = '\0';
            this.mtbPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbPath.SelectedText = "";
            this.mtbPath.SelectionLength = 0;
            this.mtbPath.SelectionStart = 0;
            this.mtbPath.ShortcutsEnabled = true;
            this.mtbPath.Size = new System.Drawing.Size(588, 23);
            this.mtbPath.TabIndex = 6;
            this.mtbPath.UseSelectable = true;
            this.mtbPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ExcelExportUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtbPath);
            this.Controls.Add(this.mtExport);
            this.Controls.Add(this.mbPicker);
            this.Controls.Add(this.ml2);
            this.Controls.Add(this.mcbWeeks);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ExcelExportUserControl";
            this.Size = new System.Drawing.Size(884, 396);
            this.Load += new System.EventHandler(this.ExcelExportUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox mcbWeeks;
        private MetroFramework.Controls.MetroLabel ml2;
        private MetroFramework.Controls.MetroButton mbPicker;
        private MetroFramework.Controls.MetroTile mtExport;
        private MetroFramework.Controls.MetroTextBox mtbPath;
    }
}
