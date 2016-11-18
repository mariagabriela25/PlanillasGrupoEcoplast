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
            this.mcbWeeks = new MetroFramework.Controls.MetroComboBox();
            this.mbPicker = new MetroFramework.Controls.MetroButton();
            this.mtExport = new MetroFramework.Controls.MetroTile();
            this.mtbPath = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mcbWeeks
            // 
            this.mcbWeeks.FormattingEnabled = true;
            this.mcbWeeks.ItemHeight = 24;
            this.mcbWeeks.Location = new System.Drawing.Point(241, 18);
            this.mcbWeeks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mcbWeeks.Name = "mcbWeeks";
            this.mcbWeeks.Size = new System.Drawing.Size(160, 30);
            this.mcbWeeks.TabIndex = 1;
            this.mcbWeeks.UseSelectable = true;
            // 
            // mbPicker
            // 
            this.mbPicker.Location = new System.Drawing.Point(1082, 82);
            this.mbPicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mbPicker.Name = "mbPicker";
            this.mbPicker.Size = new System.Drawing.Size(267, 41);
            this.mbPicker.TabIndex = 3;
            this.mbPicker.Text = "Buscar Archivo";
            this.mbPicker.UseSelectable = true;
            this.mbPicker.Click += new System.EventHandler(this.mbPicker_Click);
            // 
            // mtExport
            // 
            this.mtExport.ActiveControl = null;
            this.mtExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtExport.Location = new System.Drawing.Point(1082, 165);
            this.mtExport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtExport.Name = "mtExport";
            this.mtExport.Size = new System.Drawing.Size(267, 73);
            this.mtExport.Style = MetroFramework.MetroColorStyle.Green;
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
            this.mtbPath.CustomButton.Location = new System.Drawing.Point(758, 2);
            this.mtbPath.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtbPath.CustomButton.Name = "";
            this.mtbPath.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtbPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbPath.CustomButton.TabIndex = 1;
            this.mtbPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbPath.CustomButton.UseSelectable = true;
            this.mtbPath.CustomButton.Visible = false;
            this.mtbPath.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtbPath.Lines = new string[0];
            this.mtbPath.Location = new System.Drawing.Point(241, 83);
            this.mtbPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtbPath.MaxLength = 32767;
            this.mtbPath.Name = "mtbPath";
            this.mtbPath.PasswordChar = '\0';
            this.mtbPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbPath.SelectedText = "";
            this.mtbPath.SelectionLength = 0;
            this.mtbPath.SelectionStart = 0;
            this.mtbPath.ShortcutsEnabled = true;
            this.mtbPath.Size = new System.Drawing.Size(784, 28);
            this.mtbPath.TabIndex = 6;
            this.mtbPath.UseSelectable = true;
            this.mtbPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Semana:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Archivo Destino:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(1207, 592);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // ExcelExportUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtbPath);
            this.Controls.Add(this.mtExport);
            this.Controls.Add(this.mbPicker);
            this.Controls.Add(this.mcbWeeks);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ExcelExportUserControl";
            this.Size = new System.Drawing.Size(1402, 727);
            this.Load += new System.EventHandler(this.ExcelExportUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox mcbWeeks;
        private MetroFramework.Controls.MetroButton mbPicker;
        private MetroFramework.Controls.MetroTile mtExport;
        private MetroFramework.Controls.MetroTextBox mtbPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
