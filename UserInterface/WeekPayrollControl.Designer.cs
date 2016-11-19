namespace UserInterface
{
    partial class WeekPayrollControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeekPayrollControl));
            this.tb_filter = new MetroFramework.Controls.MetroTextBox();
            this.mg_weeks = new MetroFramework.Controls.MetroGrid();
            this.cbo_Weeks = new MetroFramework.Controls.MetroComboBox();
            this.mbAnomaliesReview = new MetroFramework.Controls.MetroButton();
            this.mbWeekReport = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mg_weeks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_filter
            // 
            // 
            // 
            // 
            this.tb_filter.CustomButton.Image = null;
            this.tb_filter.CustomButton.Location = new System.Drawing.Point(780, 2);
            this.tb_filter.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.tb_filter.CustomButton.Name = "";
            this.tb_filter.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tb_filter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_filter.CustomButton.TabIndex = 1;
            this.tb_filter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_filter.CustomButton.UseSelectable = true;
            this.tb_filter.CustomButton.Visible = false;
            this.tb_filter.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_filter.Lines = new string[0];
            this.tb_filter.Location = new System.Drawing.Point(172, 85);
            this.tb_filter.Margin = new System.Windows.Forms.Padding(4);
            this.tb_filter.MaxLength = 32767;
            this.tb_filter.Name = "tb_filter";
            this.tb_filter.PasswordChar = '\0';
            this.tb_filter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_filter.SelectedText = "";
            this.tb_filter.SelectionLength = 0;
            this.tb_filter.SelectionStart = 0;
            this.tb_filter.ShortcutsEnabled = true;
            this.tb_filter.Size = new System.Drawing.Size(806, 28);
            this.tb_filter.TabIndex = 0;
            this.tb_filter.UseSelectable = true;
            this.tb_filter.Visible = false;
            this.tb_filter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_filter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_filter.TextChanged += new System.EventHandler(this.filter);
            // 
            // mg_weeks
            // 
            this.mg_weeks.AllowUserToAddRows = false;
            this.mg_weeks.AllowUserToDeleteRows = false;
            this.mg_weeks.AllowUserToResizeRows = false;
            this.mg_weeks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mg_weeks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.mg_weeks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mg_weeks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mg_weeks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mg_weeks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mg_weeks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mg_weeks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mg_weeks.DefaultCellStyle = dataGridViewCellStyle2;
            this.mg_weeks.EnableHeadersVisualStyles = false;
            this.mg_weeks.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mg_weeks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mg_weeks.Location = new System.Drawing.Point(0, 121);
            this.mg_weeks.Margin = new System.Windows.Forms.Padding(4);
            this.mg_weeks.Name = "mg_weeks";
            this.mg_weeks.ReadOnly = true;
            this.mg_weeks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mg_weeks.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mg_weeks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mg_weeks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mg_weeks.Size = new System.Drawing.Size(978, 606);
            this.mg_weeks.TabIndex = 2;
            this.mg_weeks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mg_weeks_CellContentClick);
            // 
            // cbo_Weeks
            // 
            this.cbo_Weeks.FormattingEnabled = true;
            this.cbo_Weeks.ItemHeight = 24;
            this.cbo_Weeks.Location = new System.Drawing.Point(172, 22);
            this.cbo_Weeks.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_Weeks.Name = "cbo_Weeks";
            this.cbo_Weeks.Size = new System.Drawing.Size(122, 30);
            this.cbo_Weeks.TabIndex = 3;
            this.cbo_Weeks.UseSelectable = true;
            this.cbo_Weeks.SelectedValueChanged += new System.EventHandler(this.cbo_weekSelection);
            // 
            // mbAnomaliesReview
            // 
            this.mbAnomaliesReview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.mbAnomaliesReview.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbAnomaliesReview.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mbAnomaliesReview.Location = new System.Drawing.Point(984, 17);
            this.mbAnomaliesReview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mbAnomaliesReview.Name = "mbAnomaliesReview";
            this.mbAnomaliesReview.Size = new System.Drawing.Size(378, 46);
            this.mbAnomaliesReview.TabIndex = 6;
            this.mbAnomaliesReview.Text = "Anomalías Pendientes";
            this.mbAnomaliesReview.UseSelectable = true;
            this.mbAnomaliesReview.Click += new System.EventHandler(this.mbAnomaliesReview_Click);
            // 
            // mbWeekReport
            // 
            this.mbWeekReport.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbWeekReport.Location = new System.Drawing.Point(600, 17);
            this.mbWeekReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mbWeekReport.Name = "mbWeekReport";
            this.mbWeekReport.Size = new System.Drawing.Size(378, 46);
            this.mbWeekReport.TabIndex = 7;
            this.mbWeekReport.Text = "Consultar Reporte";
            this.mbWeekReport.UseSelectable = true;
            this.mbWeekReport.Click += new System.EventHandler(this.mbWeekReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 23);
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
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Empleado:";
            this.label2.Visible = false;
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
            // WeekPayrollControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mbWeekReport);
            this.Controls.Add(this.mbAnomaliesReview);
            this.Controls.Add(this.cbo_Weeks);
            this.Controls.Add(this.mg_weeks);
            this.Controls.Add(this.tb_filter);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WeekPayrollControl";
            this.Size = new System.Drawing.Size(1402, 727);
            this.Load += new System.EventHandler(this.WeekPayrollControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mg_weeks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox tb_filter;
        private MetroFramework.Controls.MetroGrid mg_weeks;
        private MetroFramework.Controls.MetroComboBox cbo_Weeks;
        private MetroFramework.Controls.MetroButton mbAnomaliesReview;
        private MetroFramework.Controls.MetroButton mbWeekReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
