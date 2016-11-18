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
            this.tb_filter = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mg_weeks = new MetroFramework.Controls.MetroGrid();
            this.cbo_Weeks = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mbAnomaliesReview = new MetroFramework.Controls.MetroButton();
            this.mbWeekReport = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mg_weeks)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_filter
            // 
            // 
            // 
            // 
            this.tb_filter.CustomButton.Image = null;
            this.tb_filter.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.tb_filter.CustomButton.Name = "";
            this.tb_filter.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.tb_filter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_filter.CustomButton.TabIndex = 1;
            this.tb_filter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_filter.CustomButton.UseSelectable = true;
            this.tb_filter.CustomButton.Visible = false;
            this.tb_filter.Lines = new string[0];
            this.tb_filter.Location = new System.Drawing.Point(211, 269);
            this.tb_filter.MaxLength = 32767;
            this.tb_filter.Name = "tb_filter";
            this.tb_filter.PasswordChar = '\0';
            this.tb_filter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_filter.SelectedText = "";
            this.tb_filter.SelectionLength = 0;
            this.tb_filter.SelectionStart = 0;
            this.tb_filter.ShortcutsEnabled = true;
            this.tb_filter.Size = new System.Drawing.Size(145, 23);
            this.tb_filter.TabIndex = 0;
            this.tb_filter.UseSelectable = true;
            this.tb_filter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_filter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_filter.TextChanged += new System.EventHandler(this.filter);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(39, 275);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(125, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Filtrar por Nombre:";
            // 
            // mg_weeks
            // 
            this.mg_weeks.AllowUserToAddRows = false;
            this.mg_weeks.AllowUserToDeleteRows = false;
            this.mg_weeks.AllowUserToResizeRows = false;
            this.mg_weeks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mg_weeks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mg_weeks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mg_weeks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mg_weeks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mg_weeks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mg_weeks.DefaultCellStyle = dataGridViewCellStyle2;
            this.mg_weeks.EnableHeadersVisualStyles = false;
            this.mg_weeks.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mg_weeks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mg_weeks.Location = new System.Drawing.Point(39, 323);
            this.mg_weeks.Name = "mg_weeks";
            this.mg_weeks.ReadOnly = true;
            this.mg_weeks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mg_weeks.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mg_weeks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mg_weeks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mg_weeks.Size = new System.Drawing.Size(518, 214);
            this.mg_weeks.TabIndex = 2;
            this.mg_weeks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mg_weeks_CellContentClick);
            // 
            // cbo_Weeks
            // 
            this.cbo_Weeks.FormattingEnabled = true;
            this.cbo_Weeks.ItemHeight = 23;
            this.cbo_Weeks.Location = new System.Drawing.Point(224, 127);
            this.cbo_Weeks.Name = "cbo_Weeks";
            this.cbo_Weeks.Size = new System.Drawing.Size(65, 29);
            this.cbo_Weeks.TabIndex = 3;
            this.cbo_Weeks.UseSelectable = true;
            this.cbo_Weeks.SelectedValueChanged += new System.EventHandler(this.cbo_weekSelection);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(111, 135);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(93, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Elegir Semana";
            // 
            // mbAnomaliesReview
            // 
            this.mbAnomaliesReview.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbAnomaliesReview.Location = new System.Drawing.Point(88, 41);
            this.mbAnomaliesReview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mbAnomaliesReview.Name = "mbAnomaliesReview";
            this.mbAnomaliesReview.Size = new System.Drawing.Size(267, 41);
            this.mbAnomaliesReview.TabIndex = 6;
            this.mbAnomaliesReview.Text = "Anomalías Pendientes";
            this.mbAnomaliesReview.UseSelectable = true;
            this.mbAnomaliesReview.Click += new System.EventHandler(this.mbAnomaliesReview_Click);
            // 
            // mbWeekReport
            // 
            this.mbWeekReport.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbWeekReport.Location = new System.Drawing.Point(111, 187);
            this.mbWeekReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mbWeekReport.Name = "mbWeekReport";
            this.mbWeekReport.Size = new System.Drawing.Size(212, 37);
            this.mbWeekReport.TabIndex = 7;
            this.mbWeekReport.Text = "Consultar Reporte";
            this.mbWeekReport.UseSelectable = true;
            this.mbWeekReport.Click += new System.EventHandler(this.mbWeekReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(16, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "-      -      -       -      -      -      -      -      -      -      -      -  " +
    "    -      -      -       -      -      - ";
            // 
            // WeekPayrollControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mbWeekReport);
            this.Controls.Add(this.mbAnomaliesReview);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cbo_Weeks);
            this.Controls.Add(this.mg_weeks);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tb_filter);
            this.Name = "WeekPayrollControl";
            this.Size = new System.Drawing.Size(784, 642);
            this.Load += new System.EventHandler(this.WeekPayrollControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mg_weeks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox tb_filter;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid mg_weeks;
        private MetroFramework.Controls.MetroComboBox cbo_Weeks;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton mbAnomaliesReview;
        private MetroFramework.Controls.MetroButton mbWeekReport;
        private System.Windows.Forms.Label label1;
    }
}
