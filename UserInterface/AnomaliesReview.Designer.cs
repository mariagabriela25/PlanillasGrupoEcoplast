﻿namespace UserInterface
{
    partial class AnomaliesReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnomaliesReview));
            this.mgEmployee = new MetroFramework.Controls.MetroGrid();
            this.lbFecha = new System.Windows.Forms.GroupBox();
            this.lbJornada = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.halfHour = new System.Windows.Forms.NumericUpDown();
            this.fullHour = new System.Windows.Forms.NumericUpDown();
            this.linkRests = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.gbSchedules = new System.Windows.Forms.GroupBox();
            this.lblist = new System.Windows.Forms.Label();
            this.lbSchedules = new System.Windows.Forms.Label();
            this.lbchecks = new System.Windows.Forms.Label();
            this.btGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mgEmployee)).BeginInit();
            this.lbFecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.halfHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullHour)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbSchedules.SuspendLayout();
            this.SuspendLayout();
            // 
            // mgEmployee
            // 
            this.mgEmployee.AllowUserToAddRows = false;
            this.mgEmployee.AllowUserToDeleteRows = false;
            this.mgEmployee.AllowUserToResizeRows = false;
            this.mgEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mgEmployee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.mgEmployee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgEmployee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgEmployee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgEmployee.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgEmployee.EnableHeadersVisualStyles = false;
            this.mgEmployee.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgEmployee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgEmployee.Location = new System.Drawing.Point(23, 51);
            this.mgEmployee.Name = "mgEmployee";
            this.mgEmployee.ReadOnly = true;
            this.mgEmployee.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgEmployee.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgEmployee.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgEmployee.Size = new System.Drawing.Size(525, 550);
            this.mgEmployee.TabIndex = 0;
            this.mgEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgEmployee_CellContentClick);
            this.mgEmployee.SelectionChanged += new System.EventHandler(this.mgEmployee_SelectionChanged);
            // 
            // lbFecha
            // 
            this.lbFecha.Controls.Add(this.lbJornada);
            this.lbFecha.Controls.Add(this.label4);
            this.lbFecha.Controls.Add(this.label3);
            this.lbFecha.Controls.Add(this.halfHour);
            this.lbFecha.Controls.Add(this.fullHour);
            this.lbFecha.Controls.Add(this.linkRests);
            this.lbFecha.Controls.Add(this.groupBox1);
            this.lbFecha.Controls.Add(this.gbSchedules);
            this.lbFecha.Controls.Add(this.lbchecks);
            this.lbFecha.Controls.Add(this.btGuardar);
            this.lbFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.Location = new System.Drawing.Point(563, 37);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(415, 564);
            this.lbFecha.TabIndex = 1;
            this.lbFecha.TabStop = false;
            this.lbFecha.Text = "Revisión de marca";
            // 
            // lbJornada
            // 
            this.lbJornada.AutoSize = true;
            this.lbJornada.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJornada.Location = new System.Drawing.Point(218, 475);
            this.lbJornada.Name = "lbJornada";
            this.lbJornada.Size = new System.Drawing.Size(84, 20);
            this.lbJornada.TabIndex = 13;
            this.lbJornada.Text = "Total horas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = ": ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Total horas:";
            // 
            // halfHour
            // 
            this.halfHour.Increment = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.halfHour.Location = new System.Drawing.Point(172, 471);
            this.halfHour.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.halfHour.Name = "halfHour";
            this.halfHour.Size = new System.Drawing.Size(40, 29);
            this.halfHour.TabIndex = 10;
            // 
            // fullHour
            // 
            this.fullHour.Location = new System.Drawing.Point(105, 471);
            this.fullHour.Name = "fullHour";
            this.fullHour.Size = new System.Drawing.Size(40, 29);
            this.fullHour.TabIndex = 8;
            // 
            // linkRests
            // 
            this.linkRests.AutoSize = true;
            this.linkRests.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkRests.Location = new System.Drawing.Point(142, 126);
            this.linkRests.Name = "linkRests";
            this.linkRests.Size = new System.Drawing.Size(257, 17);
            this.linkRests.TabIndex = 7;
            this.linkRests.TabStop = true;
            this.linkRests.Text = "Ver detalle de descansos para esta fecha...";
            this.linkRests.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRests_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(6, 375);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 72);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Observaciones";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(4, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(394, 37);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // gbSchedules
            // 
            this.gbSchedules.Controls.Add(this.lblist);
            this.gbSchedules.Controls.Add(this.lbSchedules);
            this.gbSchedules.Location = new System.Drawing.Point(6, 148);
            this.gbSchedules.Name = "gbSchedules";
            this.gbSchedules.Size = new System.Drawing.Size(403, 220);
            this.gbSchedules.TabIndex = 5;
            this.gbSchedules.TabStop = false;
            this.gbSchedules.Text = "Horarios";
            this.gbSchedules.Enter += new System.EventHandler(this.gbSchedules_Enter);
            // 
            // lblist
            // 
            this.lblist.AutoSize = true;
            this.lblist.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblist.Location = new System.Drawing.Point(12, 25);
            this.lblist.Name = "lblist";
            this.lblist.Size = new System.Drawing.Size(45, 19);
            this.lblist.TabIndex = 1;
            this.lblist.Text = "label3";
            // 
            // lbSchedules
            // 
            this.lbSchedules.AutoSize = true;
            this.lbSchedules.Location = new System.Drawing.Point(16, 29);
            this.lbSchedules.Name = "lbSchedules";
            this.lbSchedules.Size = new System.Drawing.Size(0, 21);
            this.lbSchedules.TabIndex = 0;
            // 
            // lbchecks
            // 
            this.lbchecks.AutoSize = true;
            this.lbchecks.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbchecks.Location = new System.Drawing.Point(17, 25);
            this.lbchecks.Name = "lbchecks";
            this.lbchecks.Size = new System.Drawing.Size(53, 19);
            this.lbchecks.TabIndex = 1;
            this.lbchecks.Text = "Marcas";
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(0, 518);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(414, 44);
            this.btGuardar.TabIndex = 0;
            this.btGuardar.Text = "Aceptar la revisión";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // AnomaliesReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 615);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.mgEmployee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AnomaliesReview";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Revisión de anomalías";
            this.Load += new System.EventHandler(this.AnomaliesReview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mgEmployee)).EndInit();
            this.lbFecha.ResumeLayout(false);
            this.lbFecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.halfHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullHour)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.gbSchedules.ResumeLayout(false);
            this.gbSchedules.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid mgEmployee;
        private System.Windows.Forms.GroupBox lbFecha;
        private System.Windows.Forms.Label lbchecks;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.GroupBox gbSchedules;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lbSchedules;
        private System.Windows.Forms.Label lblist;
        private System.Windows.Forms.LinkLabel linkRests;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown halfHour;
        private System.Windows.Forms.NumericUpDown fullHour;
        private System.Windows.Forms.Label lbJornada;
    }
}
