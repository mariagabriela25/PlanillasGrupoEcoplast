namespace UserInterface
{
    partial class ChecksRangeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbEmployeeNumber = new System.Windows.Forms.Label();
            this.lbEmployeeName = new System.Windows.Forms.Label();
            this.lbDepartment = new System.Windows.Forms.Label();
            this.mgEmployeeRegisteredChecks = new MetroFramework.Controls.MetroGrid();
            this.lbDates = new System.Windows.Forms.Label();
            this.mbPrint = new MetroFramework.Controls.MetroButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.mgEmployeeRegisteredChecks)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEmployeeNumber
            // 
            this.lbEmployeeNumber.AutoSize = true;
            this.lbEmployeeNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmployeeNumber.Location = new System.Drawing.Point(56, 78);
            this.lbEmployeeNumber.Name = "lbEmployeeNumber";
            this.lbEmployeeNumber.Size = new System.Drawing.Size(32, 24);
            this.lbEmployeeNumber.TabIndex = 0;
            this.lbEmployeeNumber.Text = "00";
            // 
            // lbEmployeeName
            // 
            this.lbEmployeeName.AutoSize = true;
            this.lbEmployeeName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmployeeName.Location = new System.Drawing.Point(91, 78);
            this.lbEmployeeName.Name = "lbEmployeeName";
            this.lbEmployeeName.Size = new System.Drawing.Size(172, 24);
            this.lbEmployeeName.TabIndex = 1;
            this.lbEmployeeName.Text = "lbEmployeeName";
            // 
            // lbDepartment
            // 
            this.lbDepartment.AutoSize = true;
            this.lbDepartment.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepartment.ForeColor = System.Drawing.Color.Red;
            this.lbDepartment.Location = new System.Drawing.Point(56, 34);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(167, 29);
            this.lbDepartment.TabIndex = 2;
            this.lbDepartment.Text = "lbDepartment";
            // 
            // mgEmployeeRegisteredChecks
            // 
            this.mgEmployeeRegisteredChecks.AllowUserToAddRows = false;
            this.mgEmployeeRegisteredChecks.AllowUserToDeleteRows = false;
            this.mgEmployeeRegisteredChecks.AllowUserToResizeRows = false;
            this.mgEmployeeRegisteredChecks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgEmployeeRegisteredChecks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgEmployeeRegisteredChecks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgEmployeeRegisteredChecks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgEmployeeRegisteredChecks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgEmployeeRegisteredChecks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgEmployeeRegisteredChecks.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgEmployeeRegisteredChecks.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgEmployeeRegisteredChecks.EnableHeadersVisualStyles = false;
            this.mgEmployeeRegisteredChecks.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgEmployeeRegisteredChecks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgEmployeeRegisteredChecks.Location = new System.Drawing.Point(49, 124);
            this.mgEmployeeRegisteredChecks.Name = "mgEmployeeRegisteredChecks";
            this.mgEmployeeRegisteredChecks.ReadOnly = true;
            this.mgEmployeeRegisteredChecks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgEmployeeRegisteredChecks.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgEmployeeRegisteredChecks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.mgEmployeeRegisteredChecks.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.mgEmployeeRegisteredChecks.RowTemplate.Height = 30;
            this.mgEmployeeRegisteredChecks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgEmployeeRegisteredChecks.Size = new System.Drawing.Size(772, 436);
            this.mgEmployeeRegisteredChecks.Style = MetroFramework.MetroColorStyle.Lime;
            this.mgEmployeeRegisteredChecks.TabIndex = 3;
            // 
            // lbDates
            // 
            this.lbDates.AutoSize = true;
            this.lbDates.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDates.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbDates.Location = new System.Drawing.Point(253, 37);
            this.lbDates.Name = "lbDates";
            this.lbDates.Size = new System.Drawing.Size(65, 24);
            this.lbDates.TabIndex = 4;
            this.lbDates.Text = "label1";
            // 
            // mbPrint
            // 
            this.mbPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mbPrint.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbPrint.ForeColor = System.Drawing.Color.Lime;
            this.mbPrint.Location = new System.Drawing.Point(751, 64);
            this.mbPrint.Margin = new System.Windows.Forms.Padding(4);
            this.mbPrint.Name = "mbPrint";
            this.mbPrint.Size = new System.Drawing.Size(70, 38);
            this.mbPrint.Style = MetroFramework.MetroColorStyle.Lime;
            this.mbPrint.TabIndex = 23;
            this.mbPrint.Text = "PDF";
            this.mbPrint.UseSelectable = true;
            this.mbPrint.Click += new System.EventHandler(this.mbPrint_Click);
            // 
            // ChecksRangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(874, 905);
            this.Controls.Add(this.mbPrint);
            this.Controls.Add(this.lbDates);
            this.Controls.Add(this.mgEmployeeRegisteredChecks);
            this.Controls.Add(this.lbDepartment);
            this.Controls.Add(this.lbEmployeeName);
            this.Controls.Add(this.lbEmployeeNumber);
            this.Name = "ChecksRangeForm";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Load += new System.EventHandler(this.ChecksRangeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mgEmployeeRegisteredChecks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEmployeeNumber;
        private System.Windows.Forms.Label lbEmployeeName;
        private System.Windows.Forms.Label lbDepartment;
        private MetroFramework.Controls.MetroGrid mgEmployeeRegisteredChecks;
        private System.Windows.Forms.Label lbDates;
        private MetroFramework.Controls.MetroButton mbPrint;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}