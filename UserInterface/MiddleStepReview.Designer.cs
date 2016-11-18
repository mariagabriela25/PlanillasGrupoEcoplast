﻿namespace UserInterface
{
    partial class MiddleStepReview
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
            this.mgCorrectChecks = new MetroFramework.Controls.MetroGrid();
            this.mbSendAnomalies = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.mgCorrectChecks)).BeginInit();
            this.SuspendLayout();
            // 
            // mgCorrectChecks
            // 
            this.mgCorrectChecks.AllowUserToAddRows = false;
            this.mgCorrectChecks.AllowUserToDeleteRows = false;
            this.mgCorrectChecks.AllowUserToResizeRows = false;
            this.mgCorrectChecks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgCorrectChecks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgCorrectChecks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgCorrectChecks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgCorrectChecks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgCorrectChecks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgCorrectChecks.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgCorrectChecks.EnableHeadersVisualStyles = false;
            this.mgCorrectChecks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgCorrectChecks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgCorrectChecks.Location = new System.Drawing.Point(23, 95);
            this.mgCorrectChecks.Name = "mgCorrectChecks";
            this.mgCorrectChecks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgCorrectChecks.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgCorrectChecks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgCorrectChecks.RowTemplate.Height = 24;
            this.mgCorrectChecks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgCorrectChecks.Size = new System.Drawing.Size(1008, 571);
            this.mgCorrectChecks.TabIndex = 0;
            this.mgCorrectChecks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgCorrectChecks_CellContentClick);
            // 
            // mbSendAnomalies
            // 
            this.mbSendAnomalies.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mbSendAnomalies.Location = new System.Drawing.Point(689, 716);
            this.mbSendAnomalies.Name = "mbSendAnomalies";
            this.mbSendAnomalies.Size = new System.Drawing.Size(342, 49);
            this.mbSendAnomalies.TabIndex = 1;
            this.mbSendAnomalies.Text = "Continuar";
            this.mbSendAnomalies.UseSelectable = true;
            this.mbSendAnomalies.Click += new System.EventHandler(this.mbSendAnomalies_Click);
            // 
            // MiddleStepReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 788);
            this.Controls.Add(this.mbSendAnomalies);
            this.Controls.Add(this.mgCorrectChecks);
            this.Name = "MiddleStepReview";
            this.Text = "Marcas Correctas";
            this.Load += new System.EventHandler(this.MiddleStepReview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mgCorrectChecks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid mgCorrectChecks;
        private MetroFramework.Controls.MetroButton mbSendAnomalies;
    }
}