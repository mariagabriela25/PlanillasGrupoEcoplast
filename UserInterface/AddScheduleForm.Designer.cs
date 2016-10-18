namespace UserInterface
{
    partial class AddScheduleForm
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
            this.lbCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nupFinalHour = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nupFinalMinute = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nupInitialHour = new System.Windows.Forms.NumericUpDown();
            this.nupInitialMinute = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nupOrdinaryHours = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nupNightExtra = new System.Windows.Forms.NumericUpDown();
            this.nupDayExtra = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbRest1 = new System.Windows.Forms.ComboBox();
            this.lbRest2 = new System.Windows.Forms.Label();
            this.cbRest2 = new System.Windows.Forms.ComboBox();
            this.cbRest3 = new System.Windows.Forms.ComboBox();
            this.lbRest3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.mtAddRest = new MetroFramework.Controls.MetroButton();
            this.mbSave = new MetroFramework.Controls.MetroButton();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupFinalHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupFinalMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupInitialHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupInitialMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupOrdinaryHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNightExtra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDayExtra)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCode.Location = new System.Drawing.Point(59, 525);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(91, 24);
            this.lbCode.TabIndex = 0;
            this.lbCode.Text = "CÓDIGO";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(63, 584);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(249, 27);
            this.txtCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "ENTRADA";
            // 
            // nupFinalHour
            // 
            this.nupFinalHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupFinalHour.Location = new System.Drawing.Point(63, 407);
            this.nupFinalHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nupFinalHour.Name = "nupFinalHour";
            this.nupFinalHour.Size = new System.Drawing.Size(59, 27);
            this.nupFinalHour.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hrs.";
            // 
            // nupFinalMinute
            // 
            this.nupFinalMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupFinalMinute.Location = new System.Drawing.Point(203, 407);
            this.nupFinalMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nupFinalMinute.Name = "nupFinalMinute";
            this.nupFinalMinute.Size = new System.Drawing.Size(55, 27);
            this.nupFinalMinute.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(264, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mins.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "SALIDA";
            // 
            // nupInitialHour
            // 
            this.nupInitialHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupInitialHour.Location = new System.Drawing.Point(63, 305);
            this.nupInitialHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nupInitialHour.Name = "nupInitialHour";
            this.nupInitialHour.Size = new System.Drawing.Size(59, 27);
            this.nupInitialHour.TabIndex = 8;
            // 
            // nupInitialMinute
            // 
            this.nupInitialMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupInitialMinute.Location = new System.Drawing.Point(203, 305);
            this.nupInitialMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nupInitialMinute.Name = "nupInitialMinute";
            this.nupInitialMinute.Size = new System.Drawing.Size(55, 27);
            this.nupInitialMinute.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(533, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ordinarias:";
            // 
            // nupOrdinaryHours
            // 
            this.nupOrdinaryHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupOrdinaryHours.Location = new System.Drawing.Point(691, 271);
            this.nupOrdinaryHours.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.nupOrdinaryHours.Name = "nupOrdinaryHours";
            this.nupOrdinaryHours.Size = new System.Drawing.Size(59, 27);
            this.nupOrdinaryHours.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(554, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "DESGLOSE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(502, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "Extras Diurnas:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(485, 410);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 19);
            this.label10.TabIndex = 16;
            this.label10.Text = "Extras Nocturnas:";
            // 
            // nupNightExtra
            // 
            this.nupNightExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupNightExtra.Location = new System.Drawing.Point(691, 402);
            this.nupNightExtra.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nupNightExtra.Name = "nupNightExtra";
            this.nupNightExtra.Size = new System.Drawing.Size(59, 27);
            this.nupNightExtra.TabIndex = 17;
            // 
            // nupDayExtra
            // 
            this.nupDayExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupDayExtra.Location = new System.Drawing.Point(691, 336);
            this.nupDayExtra.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nupDayExtra.Name = "nupDayExtra";
            this.nupDayExtra.Size = new System.Drawing.Size(59, 27);
            this.nupDayExtra.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(128, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Hrs.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(264, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "Mins.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(945, 162);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 24);
            this.label14.TabIndex = 24;
            this.label14.Text = "DESCANSOS";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(869, 279);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 19);
            this.label15.TabIndex = 25;
            this.label15.Text = "Descanso #1:";
            // 
            // cbRest1
            // 
            this.cbRest1.FormattingEnabled = true;
            this.cbRest1.Location = new System.Drawing.Point(1030, 274);
            this.cbRest1.Name = "cbRest1";
            this.cbRest1.Size = new System.Drawing.Size(121, 24);
            this.cbRest1.TabIndex = 26;
            // 
            // lbRest2
            // 
            this.lbRest2.AutoSize = true;
            this.lbRest2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRest2.Location = new System.Drawing.Point(869, 344);
            this.lbRest2.Name = "lbRest2";
            this.lbRest2.Size = new System.Drawing.Size(110, 19);
            this.lbRest2.TabIndex = 27;
            this.lbRest2.Text = "Descanso #2:";
            this.lbRest2.Visible = false;
            // 
            // cbRest2
            // 
            this.cbRest2.FormattingEnabled = true;
            this.cbRest2.Location = new System.Drawing.Point(1030, 339);
            this.cbRest2.Name = "cbRest2";
            this.cbRest2.Size = new System.Drawing.Size(121, 24);
            this.cbRest2.TabIndex = 28;
            this.cbRest2.Visible = false;
            // 
            // cbRest3
            // 
            this.cbRest3.FormattingEnabled = true;
            this.cbRest3.Location = new System.Drawing.Point(1030, 405);
            this.cbRest3.Name = "cbRest3";
            this.cbRest3.Size = new System.Drawing.Size(121, 24);
            this.cbRest3.TabIndex = 29;
            this.cbRest3.Visible = false;
            // 
            // lbRest3
            // 
            this.lbRest3.AutoSize = true;
            this.lbRest3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRest3.Location = new System.Drawing.Point(869, 410);
            this.lbRest3.Name = "lbRest3";
            this.lbRest3.Size = new System.Drawing.Size(110, 19);
            this.lbRest3.TabIndex = 30;
            this.lbRest3.Text = "Descanso #3:";
            this.lbRest3.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(446, 525);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 24);
            this.label11.TabIndex = 32;
            this.label11.Text = "DEPARTAMENTO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(128, 162);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 24);
            this.label12.TabIndex = 34;
            this.label12.Text = "HORAS";
            // 
            // mtAddRest
            // 
            this.mtAddRest.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mtAddRest.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.mtAddRest.Location = new System.Drawing.Point(873, 210);
            this.mtAddRest.Name = "mtAddRest";
            this.mtAddRest.Size = new System.Drawing.Size(278, 35);
            this.mtAddRest.Style = MetroFramework.MetroColorStyle.Lime;
            this.mtAddRest.TabIndex = 35;
            this.mtAddRest.Text = "¿Más descansos?";
            this.mtAddRest.UseSelectable = true;
            this.mtAddRest.Click += new System.EventHandler(this.mtAddRest_Click_1);
            // 
            // mbSave
            // 
            this.mbSave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbSave.ForeColor = System.Drawing.Color.Lime;
            this.mbSave.Location = new System.Drawing.Point(873, 553);
            this.mbSave.Margin = new System.Windows.Forms.Padding(4);
            this.mbSave.Name = "mbSave";
            this.mbSave.Size = new System.Drawing.Size(284, 55);
            this.mbSave.Style = MetroFramework.MetroColorStyle.Lime;
            this.mbSave.TabIndex = 36;
            this.mbSave.Text = "Guardar";
            this.mbSave.UseSelectable = true;
            this.mbSave.Click += new System.EventHandler(this.mbSave_Click);
            // 
            // cbDepartment
            // 
            this.cbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(450, 580);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(280, 28);
            this.cbDepartment.TabIndex = 37;
            // 
            // AddScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 710);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.mbSave);
            this.Controls.Add(this.mtAddRest);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbRest3);
            this.Controls.Add(this.cbRest3);
            this.Controls.Add(this.cbRest2);
            this.Controls.Add(this.lbRest2);
            this.Controls.Add(this.cbRest1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nupDayExtra);
            this.Controls.Add(this.nupNightExtra);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nupOrdinaryHours);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nupInitialMinute);
            this.Controls.Add(this.nupInitialHour);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nupFinalMinute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nupFinalHour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lbCode);
            this.Name = "AddScheduleForm";
            this.Text = "Agregar nuevo horario";
            this.Load += new System.EventHandler(this.AddScheduleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupFinalHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupFinalMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupInitialHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupInitialMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupOrdinaryHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNightExtra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDayExtra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nupFinalHour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nupFinalMinute;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nupInitialHour;
        private System.Windows.Forms.NumericUpDown nupInitialMinute;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nupOrdinaryHours;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nupNightExtra;
        private System.Windows.Forms.NumericUpDown nupDayExtra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbRest1;
        private System.Windows.Forms.Label lbRest2;
        private System.Windows.Forms.ComboBox cbRest2;
        private System.Windows.Forms.ComboBox cbRest3;
        private System.Windows.Forms.Label lbRest3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private MetroFramework.Controls.MetroButton mtAddRest;
        private MetroFramework.Controls.MetroButton mbSave;
        private System.Windows.Forms.ComboBox cbDepartment;
    }
}