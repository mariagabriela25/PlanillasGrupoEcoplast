namespace UserInterface
{
    partial class WeekDetailUserControl
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mg_employees = new MetroFramework.Controls.MetroGrid();
            this.tb_filter = new MetroFramework.Controls.MetroTextBox();
            this.tb_selection = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mt_calculate = new MetroFramework.Controls.MetroTile();
            this.tb_ordinaryHours = new MetroFramework.Controls.MetroTextBox();
            this.ml_total = new MetroFramework.Controls.MetroLabel();
            this.tb_ExtraHours = new MetroFramework.Controls.MetroTextBox();
            this.tb_week = new MetroFramework.Controls.MetroTextBox();
            this.ml_extra = new MetroFramework.Controls.MetroLabel();
            this.ml_week = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.nudWeek = new System.Windows.Forms.NumericUpDown();
            this.mBtSaveWeekDetail = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.mg_employees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeek)).BeginInit();
            this.SuspendLayout();
            // 
            // mg_employees
            // 
            this.mg_employees.AllowUserToAddRows = false;
            this.mg_employees.AllowUserToDeleteRows = false;
            this.mg_employees.AllowUserToResizeRows = false;
            this.mg_employees.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mg_employees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mg_employees.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mg_employees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mg_employees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.mg_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mg_employees.DefaultCellStyle = dataGridViewCellStyle8;
            this.mg_employees.EnableHeadersVisualStyles = false;
            this.mg_employees.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mg_employees.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mg_employees.Location = new System.Drawing.Point(87, 95);
            this.mg_employees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mg_employees.Name = "mg_employees";
            this.mg_employees.ReadOnly = true;
            this.mg_employees.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mg_employees.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.mg_employees.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mg_employees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mg_employees.Size = new System.Drawing.Size(616, 480);
            this.mg_employees.TabIndex = 0;
            this.mg_employees.SelectionChanged += new System.EventHandler(this.mg_selection);
            // 
            // tb_filter
            // 
            // 
            // 
            // 
            this.tb_filter.CustomButton.Image = null;
            this.tb_filter.CustomButton.Location = new System.Drawing.Point(292, 2);
            this.tb_filter.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_filter.CustomButton.Name = "";
            this.tb_filter.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.tb_filter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_filter.CustomButton.TabIndex = 1;
            this.tb_filter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_filter.CustomButton.UseSelectable = true;
            this.tb_filter.CustomButton.Visible = false;
            this.tb_filter.Lines = new string[0];
            this.tb_filter.Location = new System.Drawing.Point(229, 41);
            this.tb_filter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_filter.MaxLength = 32767;
            this.tb_filter.Name = "tb_filter";
            this.tb_filter.PasswordChar = '\0';
            this.tb_filter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_filter.SelectedText = "";
            this.tb_filter.SelectionLength = 0;
            this.tb_filter.SelectionStart = 0;
            this.tb_filter.ShortcutsEnabled = true;
            this.tb_filter.Size = new System.Drawing.Size(245, 28);
            this.tb_filter.TabIndex = 1;
            this.tb_filter.UseSelectable = true;
            this.tb_filter.Visible = false;
            this.tb_filter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_filter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_filter.TextChanged += new System.EventHandler(this.filter);
            // 
            // tb_selection
            // 
            // 
            // 
            // 
            this.tb_selection.CustomButton.Enabled = false;
            this.tb_selection.CustomButton.Image = null;
            this.tb_selection.CustomButton.Location = new System.Drawing.Point(164, 2);
            this.tb_selection.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_selection.CustomButton.Name = "";
            this.tb_selection.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tb_selection.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_selection.CustomButton.TabIndex = 1;
            this.tb_selection.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_selection.CustomButton.UseSelectable = true;
            this.tb_selection.CustomButton.Visible = false;
            this.tb_selection.Enabled = false;
            this.tb_selection.Lines = new string[0];
            this.tb_selection.Location = new System.Drawing.Point(969, 41);
            this.tb_selection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_selection.MaxLength = 32767;
            this.tb_selection.Name = "tb_selection";
            this.tb_selection.PasswordChar = '\0';
            this.tb_selection.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_selection.SelectedText = "";
            this.tb_selection.SelectionLength = 0;
            this.tb_selection.SelectionStart = 0;
            this.tb_selection.ShortcutsEnabled = true;
            this.tb_selection.Size = new System.Drawing.Size(190, 28);
            this.tb_selection.TabIndex = 2;
            this.tb_selection.UseSelectable = true;
            this.tb_selection.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_selection.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(31, 49);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(122, 20);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Filtar por Nombre:";
            this.metroLabel1.Visible = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(792, 49);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(124, 20);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Empleado elegido:";
            // 
            // mt_calculate
            // 
            this.mt_calculate.ActiveControl = null;
            this.mt_calculate.Location = new System.Drawing.Point(991, 186);
            this.mt_calculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mt_calculate.Name = "mt_calculate";
            this.mt_calculate.Size = new System.Drawing.Size(168, 52);
            this.mt_calculate.Style = MetroFramework.MetroColorStyle.Silver;
            this.mt_calculate.TabIndex = 5;
            this.mt_calculate.Text = "Calcular Horas";
            this.mt_calculate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mt_calculate.UseSelectable = true;
            this.mt_calculate.Click += new System.EventHandler(this.mt_calculate_Click);
            // 
            // tb_ordinaryHours
            // 
            // 
            // 
            // 
            this.tb_ordinaryHours.CustomButton.Enabled = false;
            this.tb_ordinaryHours.CustomButton.Image = null;
            this.tb_ordinaryHours.CustomButton.Location = new System.Drawing.Point(175, 2);
            this.tb_ordinaryHours.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_ordinaryHours.CustomButton.Name = "";
            this.tb_ordinaryHours.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tb_ordinaryHours.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_ordinaryHours.CustomButton.TabIndex = 1;
            this.tb_ordinaryHours.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_ordinaryHours.CustomButton.UseSelectable = true;
            this.tb_ordinaryHours.CustomButton.Visible = false;
            this.tb_ordinaryHours.Lines = new string[0];
            this.tb_ordinaryHours.Location = new System.Drawing.Point(969, 370);
            this.tb_ordinaryHours.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_ordinaryHours.MaxLength = 32767;
            this.tb_ordinaryHours.Name = "tb_ordinaryHours";
            this.tb_ordinaryHours.PasswordChar = '\0';
            this.tb_ordinaryHours.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_ordinaryHours.SelectedText = "";
            this.tb_ordinaryHours.SelectionLength = 0;
            this.tb_ordinaryHours.SelectionStart = 0;
            this.tb_ordinaryHours.ShortcutsEnabled = true;
            this.tb_ordinaryHours.Size = new System.Drawing.Size(201, 28);
            this.tb_ordinaryHours.TabIndex = 6;
            this.tb_ordinaryHours.UseSelectable = true;
            this.tb_ordinaryHours.Visible = false;
            this.tb_ordinaryHours.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_ordinaryHours.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ml_total
            // 
            this.ml_total.AutoSize = true;
            this.ml_total.Location = new System.Drawing.Point(804, 378);
            this.ml_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ml_total.Name = "ml_total";
            this.ml_total.Size = new System.Drawing.Size(115, 20);
            this.ml_total.TabIndex = 7;
            this.ml_total.Text = "Horas Ordinarias:";
            this.ml_total.Visible = false;
            // 
            // tb_ExtraHours
            // 
            // 
            // 
            // 
            this.tb_ExtraHours.CustomButton.Enabled = false;
            this.tb_ExtraHours.CustomButton.Image = null;
            this.tb_ExtraHours.CustomButton.Location = new System.Drawing.Point(175, 2);
            this.tb_ExtraHours.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_ExtraHours.CustomButton.Name = "";
            this.tb_ExtraHours.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tb_ExtraHours.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_ExtraHours.CustomButton.TabIndex = 1;
            this.tb_ExtraHours.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_ExtraHours.CustomButton.UseSelectable = true;
            this.tb_ExtraHours.CustomButton.Visible = false;
            this.tb_ExtraHours.Lines = new string[0];
            this.tb_ExtraHours.Location = new System.Drawing.Point(969, 449);
            this.tb_ExtraHours.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_ExtraHours.MaxLength = 32767;
            this.tb_ExtraHours.Name = "tb_ExtraHours";
            this.tb_ExtraHours.PasswordChar = '\0';
            this.tb_ExtraHours.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_ExtraHours.SelectedText = "";
            this.tb_ExtraHours.SelectionLength = 0;
            this.tb_ExtraHours.SelectionStart = 0;
            this.tb_ExtraHours.ShortcutsEnabled = true;
            this.tb_ExtraHours.Size = new System.Drawing.Size(201, 28);
            this.tb_ExtraHours.TabIndex = 8;
            this.tb_ExtraHours.UseSelectable = true;
            this.tb_ExtraHours.Visible = false;
            this.tb_ExtraHours.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_ExtraHours.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_week
            // 
            // 
            // 
            // 
            this.tb_week.CustomButton.Enabled = false;
            this.tb_week.CustomButton.Image = null;
            this.tb_week.CustomButton.Location = new System.Drawing.Point(175, 2);
            this.tb_week.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_week.CustomButton.Name = "";
            this.tb_week.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tb_week.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_week.CustomButton.TabIndex = 1;
            this.tb_week.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_week.CustomButton.UseSelectable = true;
            this.tb_week.CustomButton.Visible = false;
            this.tb_week.Enabled = false;
            this.tb_week.Lines = new string[0];
            this.tb_week.Location = new System.Drawing.Point(969, 296);
            this.tb_week.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_week.MaxLength = 32767;
            this.tb_week.Name = "tb_week";
            this.tb_week.PasswordChar = '\0';
            this.tb_week.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_week.SelectedText = "";
            this.tb_week.SelectionLength = 0;
            this.tb_week.SelectionStart = 0;
            this.tb_week.ShortcutsEnabled = true;
            this.tb_week.Size = new System.Drawing.Size(201, 28);
            this.tb_week.TabIndex = 9;
            this.tb_week.UseSelectable = true;
            this.tb_week.Visible = false;
            this.tb_week.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_week.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ml_extra
            // 
            this.ml_extra.AutoSize = true;
            this.ml_extra.Location = new System.Drawing.Point(837, 457);
            this.ml_extra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ml_extra.Name = "ml_extra";
            this.ml_extra.Size = new System.Drawing.Size(82, 20);
            this.ml_extra.TabIndex = 10;
            this.ml_extra.Text = "Horas Extra:";
            this.ml_extra.Visible = false;
            // 
            // ml_week
            // 
            this.ml_week.AutoSize = true;
            this.ml_week.Location = new System.Drawing.Point(845, 304);
            this.ml_week.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ml_week.Name = "ml_week";
            this.ml_week.Size = new System.Drawing.Size(71, 20);
            this.ml_week.TabIndex = 11;
            this.ml_week.Text = "Semana #";
            this.ml_week.Visible = false;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(779, 118);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(137, 20);
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "Número de Semana:";
            // 
            // nudWeek
            // 
            this.nudWeek.Location = new System.Drawing.Point(969, 116);
            this.nudWeek.Maximum = new decimal(new int[] {
            52,
            0,
            0,
            0});
            this.nudWeek.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWeek.Name = "nudWeek";
            this.nudWeek.Size = new System.Drawing.Size(190, 22);
            this.nudWeek.TabIndex = 14;
            this.nudWeek.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // mBtSaveWeekDetail
            // 
            this.mBtSaveWeekDetail.ActiveControl = null;
            this.mBtSaveWeekDetail.Location = new System.Drawing.Point(991, 523);
            this.mBtSaveWeekDetail.Margin = new System.Windows.Forms.Padding(4);
            this.mBtSaveWeekDetail.Name = "mBtSaveWeekDetail";
            this.mBtSaveWeekDetail.Size = new System.Drawing.Size(168, 52);
            this.mBtSaveWeekDetail.Style = MetroFramework.MetroColorStyle.Silver;
            this.mBtSaveWeekDetail.TabIndex = 15;
            this.mBtSaveWeekDetail.Text = "Guardar Reporte";
            this.mBtSaveWeekDetail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mBtSaveWeekDetail.UseSelectable = true;
            this.mBtSaveWeekDetail.Click += new System.EventHandler(this.mBtSaveWeekDetail_Click);
            // 
            // WeekDetailUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 626);
            this.Controls.Add(this.mBtSaveWeekDetail);
            this.Controls.Add(this.nudWeek);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.ml_week);
            this.Controls.Add(this.ml_extra);
            this.Controls.Add(this.tb_week);
            this.Controls.Add(this.tb_ExtraHours);
            this.Controls.Add(this.ml_total);
            this.Controls.Add(this.tb_ordinaryHours);
            this.Controls.Add(this.mt_calculate);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tb_selection);
            this.Controls.Add(this.tb_filter);
            this.Controls.Add(this.mg_employees);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WeekDetailUserControl";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Load += new System.EventHandler(this.WeekDetailUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mg_employees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroGrid mg_employees;
        private MetroFramework.Controls.MetroTextBox tb_filter;
        private MetroFramework.Controls.MetroTextBox tb_selection;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile mt_calculate;
        private MetroFramework.Controls.MetroTextBox tb_ordinaryHours;
        private MetroFramework.Controls.MetroLabel ml_total;
        private MetroFramework.Controls.MetroTextBox tb_ExtraHours;
        private MetroFramework.Controls.MetroTextBox tb_week;
        private MetroFramework.Controls.MetroLabel ml_extra;
        private MetroFramework.Controls.MetroLabel ml_week;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.NumericUpDown nudWeek;
        private MetroFramework.Controls.MetroTile mBtSaveWeekDetail;
    }
}