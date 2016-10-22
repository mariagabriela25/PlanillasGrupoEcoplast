namespace UserInterface
{
    partial class DayDetailUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mcbDepartment = new MetroFramework.Controls.MetroComboBox();
            this.mcbSchedule = new MetroFramework.Controls.MetroComboBox();
            this.mcbEmployee = new MetroFramework.Controls.MetroComboBox();
            this.mgrWorkDayDetail = new MetroFramework.Controls.MetroGrid();
            this.mtbNote = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mbCalculate = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.mdtDay = new MetroFramework.Controls.MetroDateTime();
            ((System.ComponentModel.ISupportInitialize)(this.mgrWorkDayDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // mcbDepartment
            // 
            this.mcbDepartment.FormattingEnabled = true;
            this.mcbDepartment.ItemHeight = 23;
            this.mcbDepartment.Location = new System.Drawing.Point(35, 66);
            this.mcbDepartment.Name = "mcbDepartment";
            this.mcbDepartment.Size = new System.Drawing.Size(139, 29);
            this.mcbDepartment.TabIndex = 6;
            this.mcbDepartment.UseSelectable = true;
            this.mcbDepartment.SelectedIndexChanged += new System.EventHandler(this.mcbDepartment_SelectedIndexChanged);
            // 
            // mcbSchedule
            // 
            this.mcbSchedule.FormattingEnabled = true;
            this.mcbSchedule.ItemHeight = 23;
            this.mcbSchedule.Location = new System.Drawing.Point(180, 66);
            this.mcbSchedule.Name = "mcbSchedule";
            this.mcbSchedule.Size = new System.Drawing.Size(139, 29);
            this.mcbSchedule.TabIndex = 7;
            this.mcbSchedule.UseSelectable = true;
            this.mcbSchedule.SelectedIndexChanged += new System.EventHandler(this.mcbSchedule_SelectedIndexChanged);
            // 
            // mcbEmployee
            // 
            this.mcbEmployee.FormattingEnabled = true;
            this.mcbEmployee.ItemHeight = 23;
            this.mcbEmployee.Location = new System.Drawing.Point(325, 66);
            this.mcbEmployee.Name = "mcbEmployee";
            this.mcbEmployee.Size = new System.Drawing.Size(139, 29);
            this.mcbEmployee.TabIndex = 8;
            this.mcbEmployee.UseSelectable = true;
            // 
            // mgrWorkDayDetail
            // 
            this.mgrWorkDayDetail.AllowUserToResizeRows = false;
            this.mgrWorkDayDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgrWorkDayDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgrWorkDayDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgrWorkDayDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgrWorkDayDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.mgrWorkDayDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgrWorkDayDetail.DefaultCellStyle = dataGridViewCellStyle8;
            this.mgrWorkDayDetail.EnableHeadersVisualStyles = false;
            this.mgrWorkDayDetail.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgrWorkDayDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgrWorkDayDetail.Location = new System.Drawing.Point(35, 194);
            this.mgrWorkDayDetail.Name = "mgrWorkDayDetail";
            this.mgrWorkDayDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgrWorkDayDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.mgrWorkDayDetail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgrWorkDayDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgrWorkDayDetail.Size = new System.Drawing.Size(645, 99);
            this.mgrWorkDayDetail.TabIndex = 9;
            // 
            // mtbNote
            // 
            // 
            // 
            // 
            this.mtbNote.CustomButton.Image = null;
            this.mtbNote.CustomButton.Location = new System.Drawing.Point(623, 1);
            this.mtbNote.CustomButton.Name = "";
            this.mtbNote.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbNote.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbNote.CustomButton.TabIndex = 1;
            this.mtbNote.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbNote.CustomButton.UseSelectable = true;
            this.mtbNote.CustomButton.Visible = false;
            this.mtbNote.Lines = new string[0];
            this.mtbNote.Location = new System.Drawing.Point(35, 334);
            this.mtbNote.MaxLength = 32767;
            this.mtbNote.Name = "mtbNote";
            this.mtbNote.PasswordChar = '\0';
            this.mtbNote.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbNote.SelectedText = "";
            this.mtbNote.SelectionLength = 0;
            this.mtbNote.SelectionStart = 0;
            this.mtbNote.ShortcutsEnabled = true;
            this.mtbNote.Size = new System.Drawing.Size(645, 23);
            this.mtbNote.TabIndex = 10;
            this.mtbNote.UseSelectable = true;
            this.mtbNote.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbNote.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(35, 312);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(41, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Nota:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(35, 41);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(94, 19);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Departamento";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(180, 41);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(54, 19);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Horario";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(325, 41);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(69, 19);
            this.metroLabel4.TabIndex = 14;
            this.metroLabel4.Text = "Empleado";
            // 
            // mbCalculate
            // 
            this.mbCalculate.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbCalculate.Location = new System.Drawing.Point(35, 114);
            this.mbCalculate.Name = "mbCalculate";
            this.mbCalculate.Size = new System.Drawing.Size(119, 53);
            this.mbCalculate.TabIndex = 15;
            this.mbCalculate.Text = "Calcular";
            this.mbCalculate.UseSelectable = true;
            this.mbCalculate.Click += new System.EventHandler(this.mbCalculate_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(470, 41);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(28, 19);
            this.metroLabel5.TabIndex = 17;
            this.metroLabel5.Text = "Dia";
            // 
            // mdtDay
            // 
            this.mdtDay.Location = new System.Drawing.Point(470, 66);
            this.mdtDay.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdtDay.Name = "mdtDay";
            this.mdtDay.Size = new System.Drawing.Size(200, 29);
            this.mdtDay.TabIndex = 18;
            // 
            // DayDetailUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.mdtDay);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.mbCalculate);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mtbNote);
            this.Controls.Add(this.mgrWorkDayDetail);
            this.Controls.Add(this.mcbEmployee);
            this.Controls.Add(this.mcbSchedule);
            this.Controls.Add(this.mcbDepartment);
            this.Name = "DayDetailUserControl";
            this.Size = new System.Drawing.Size(740, 405);
            this.Load += new System.EventHandler(this.DayDetailUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mgrWorkDayDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox mcbDepartment;
        private MetroFramework.Controls.MetroComboBox mcbSchedule;
        private MetroFramework.Controls.MetroComboBox mcbEmployee;
        private MetroFramework.Controls.MetroGrid mgrWorkDayDetail;
        private MetroFramework.Controls.MetroTextBox mtbNote;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton mbCalculate;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroDateTime mdtDay;
    }
}
