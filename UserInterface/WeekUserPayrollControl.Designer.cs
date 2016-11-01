namespace UserInterface
{
    partial class WeekUserPayrollControl
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
            this.mt_generate = new MetroFramework.Controls.MetroTile();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbo_Weeks = new MetroFramework.Controls.MetroComboBox();
            this.mg_weekDetail = new MetroFramework.Controls.MetroGrid();
            this.cbo_employee = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.mg_weekDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // mt_generate
            // 
            this.mt_generate.ActiveControl = null;
            this.mt_generate.Location = new System.Drawing.Point(50, 231);
            this.mt_generate.Name = "mt_generate";
            this.mt_generate.Size = new System.Drawing.Size(128, 51);
            this.mt_generate.TabIndex = 8;
            this.mt_generate.Text = "Generar Reporte";
            this.mt_generate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mt_generate.UseSelectable = true;
            this.mt_generate.Click += new System.EventHandler(this.mt_generate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Escoger Empleado";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(33, 147);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(106, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Escoger Semana";
            // 
            // cbo_Weeks
            // 
            this.cbo_Weeks.FormattingEnabled = true;
            this.cbo_Weeks.ItemHeight = 23;
            this.cbo_Weeks.Location = new System.Drawing.Point(33, 169);
            this.cbo_Weeks.Name = "cbo_Weeks";
            this.cbo_Weeks.Size = new System.Drawing.Size(265, 29);
            this.cbo_Weeks.TabIndex = 12;
            this.cbo_Weeks.UseSelectable = true;
            // 
            // mg_weekDetail
            // 
            this.mg_weekDetail.AllowUserToResizeRows = false;
            this.mg_weekDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mg_weekDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mg_weekDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mg_weekDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mg_weekDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mg_weekDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mg_weekDetail.DefaultCellStyle = dataGridViewCellStyle2;
            this.mg_weekDetail.EnableHeadersVisualStyles = false;
            this.mg_weekDetail.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mg_weekDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mg_weekDetail.Location = new System.Drawing.Point(304, 46);
            this.mg_weekDetail.Name = "mg_weekDetail";
            this.mg_weekDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mg_weekDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mg_weekDetail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mg_weekDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mg_weekDetail.Size = new System.Drawing.Size(577, 358);
            this.mg_weekDetail.TabIndex = 13;
            // 
            // cbo_employee
            // 
            this.cbo_employee.FormattingEnabled = true;
            this.cbo_employee.ItemHeight = 23;
            this.cbo_employee.Location = new System.Drawing.Point(33, 89);
            this.cbo_employee.Name = "cbo_employee";
            this.cbo_employee.Size = new System.Drawing.Size(265, 29);
            this.cbo_employee.TabIndex = 14;
            this.cbo_employee.UseSelectable = true;
            this.cbo_employee.SelectedValueChanged += new System.EventHandler(this.cbo_employee_selected);
            // 
            // WeekUserPayrollControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbo_employee);
            this.Controls.Add(this.mg_weekDetail);
            this.Controls.Add(this.cbo_Weeks);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mt_generate);
            this.Name = "WeekUserPayrollControl";
            this.Size = new System.Drawing.Size(895, 452);
            this.Load += new System.EventHandler(this.WeekUserPayrollControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mg_weekDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile mt_generate;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cbo_Weeks;
        private MetroFramework.Controls.MetroGrid mg_weekDetail;
        private MetroFramework.Controls.MetroComboBox cbo_employee;
    }
}
