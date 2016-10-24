namespace UserInterface
{
    partial class ModifyScheduleForm
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
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.mbSave = new MetroFramework.Controls.MetroButton();
            this.mtAddRest = new MetroFramework.Controls.MetroButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbRest3 = new System.Windows.Forms.Label();
            this.cbRest3 = new System.Windows.Forms.ComboBox();
            this.cbRest2 = new System.Windows.Forms.ComboBox();
            this.lbRest2 = new System.Windows.Forms.Label();
            this.cbRest1 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nupDayExtra = new System.Windows.Forms.NumericUpDown();
            this.nupNightExtra = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nupOrdinaryHours = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nupInitialMinute = new System.Windows.Forms.NumericUpDown();
            this.nupInitialHour = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nupFinalMinute = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nupFinalHour = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupDayExtra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNightExtra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupOrdinaryHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupInitialMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupInitialHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupFinalMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupFinalHour)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDepartment
            // 
            this.cbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(454, 598);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(280, 28);
            this.cbDepartment.TabIndex = 68;
            // 
            // mbSave
            // 
            this.mbSave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbSave.ForeColor = System.Drawing.Color.Lime;
            this.mbSave.Location = new System.Drawing.Point(877, 571);
            this.mbSave.Margin = new System.Windows.Forms.Padding(4);
            this.mbSave.Name = "mbSave";
            this.mbSave.Size = new System.Drawing.Size(284, 55);
            this.mbSave.Style = MetroFramework.MetroColorStyle.Lime;
            this.mbSave.TabIndex = 67;
            this.mbSave.Text = "Guardar cambios";
            this.mbSave.UseSelectable = true;
            // 
            // mtAddRest
            // 
            this.mtAddRest.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mtAddRest.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.mtAddRest.Location = new System.Drawing.Point(877, 228);
            this.mtAddRest.Name = "mtAddRest";
            this.mtAddRest.Size = new System.Drawing.Size(278, 35);
            this.mtAddRest.Style = MetroFramework.MetroColorStyle.Lime;
            this.mtAddRest.TabIndex = 66;
            this.mtAddRest.Text = "¿Más descansos?";
            this.mtAddRest.UseSelectable = true;
            this.mtAddRest.Click += new System.EventHandler(this.mtAddRest_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(132, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 24);
            this.label12.TabIndex = 65;
            this.label12.Text = "HORAS";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(450, 543);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 24);
            this.label11.TabIndex = 64;
            this.label11.Text = "DEPARTAMENTO";
            // 
            // lbRest3
            // 
            this.lbRest3.AutoSize = true;
            this.lbRest3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRest3.Location = new System.Drawing.Point(873, 428);
            this.lbRest3.Name = "lbRest3";
            this.lbRest3.Size = new System.Drawing.Size(110, 19);
            this.lbRest3.TabIndex = 63;
            this.lbRest3.Text = "Descanso #3:";
            this.lbRest3.Visible = false;
            // 
            // cbRest3
            // 
            this.cbRest3.FormattingEnabled = true;
            this.cbRest3.Location = new System.Drawing.Point(1034, 423);
            this.cbRest3.Name = "cbRest3";
            this.cbRest3.Size = new System.Drawing.Size(121, 24);
            this.cbRest3.TabIndex = 62;
            this.cbRest3.Visible = false;
            // 
            // cbRest2
            // 
            this.cbRest2.FormattingEnabled = true;
            this.cbRest2.Location = new System.Drawing.Point(1034, 357);
            this.cbRest2.Name = "cbRest2";
            this.cbRest2.Size = new System.Drawing.Size(121, 24);
            this.cbRest2.TabIndex = 61;
            this.cbRest2.Visible = false;
            // 
            // lbRest2
            // 
            this.lbRest2.AutoSize = true;
            this.lbRest2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRest2.Location = new System.Drawing.Point(873, 362);
            this.lbRest2.Name = "lbRest2";
            this.lbRest2.Size = new System.Drawing.Size(110, 19);
            this.lbRest2.TabIndex = 60;
            this.lbRest2.Text = "Descanso #2:";
            this.lbRest2.Visible = false;
            // 
            // cbRest1
            // 
            this.cbRest1.FormattingEnabled = true;
            this.cbRest1.Location = new System.Drawing.Point(1034, 292);
            this.cbRest1.Name = "cbRest1";
            this.cbRest1.Size = new System.Drawing.Size(121, 24);
            this.cbRest1.TabIndex = 59;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(873, 297);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 19);
            this.label15.TabIndex = 58;
            this.label15.Text = "Descanso #1:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(949, 180);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 24);
            this.label14.TabIndex = 57;
            this.label14.Text = "DESCANSOS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(268, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 19);
            this.label6.TabIndex = 56;
            this.label6.Text = "Mins.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(132, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 19);
            this.label5.TabIndex = 55;
            this.label5.Text = "Hrs.";
            // 
            // nupDayExtra
            // 
            this.nupDayExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupDayExtra.Location = new System.Drawing.Point(695, 354);
            this.nupDayExtra.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nupDayExtra.Name = "nupDayExtra";
            this.nupDayExtra.Size = new System.Drawing.Size(59, 27);
            this.nupDayExtra.TabIndex = 54;
            // 
            // nupNightExtra
            // 
            this.nupNightExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupNightExtra.Location = new System.Drawing.Point(695, 420);
            this.nupNightExtra.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nupNightExtra.Name = "nupNightExtra";
            this.nupNightExtra.Size = new System.Drawing.Size(59, 27);
            this.nupNightExtra.TabIndex = 53;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(489, 428);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 19);
            this.label10.TabIndex = 52;
            this.label10.Text = "Extras Nocturnas:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(506, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 19);
            this.label9.TabIndex = 51;
            this.label9.Text = "Extras Diurnas:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(558, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 24);
            this.label8.TabIndex = 50;
            this.label8.Text = "DESGLOSE";
            // 
            // nupOrdinaryHours
            // 
            this.nupOrdinaryHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupOrdinaryHours.Location = new System.Drawing.Point(695, 289);
            this.nupOrdinaryHours.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.nupOrdinaryHours.Name = "nupOrdinaryHours";
            this.nupOrdinaryHours.Size = new System.Drawing.Size(59, 27);
            this.nupOrdinaryHours.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(537, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 19);
            this.label7.TabIndex = 48;
            this.label7.Text = "Ordinarias:";
            // 
            // nupInitialMinute
            // 
            this.nupInitialMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupInitialMinute.Location = new System.Drawing.Point(207, 323);
            this.nupInitialMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nupInitialMinute.Name = "nupInitialMinute";
            this.nupInitialMinute.Size = new System.Drawing.Size(55, 27);
            this.nupInitialMinute.TabIndex = 47;
            // 
            // nupInitialHour
            // 
            this.nupInitialHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupInitialHour.Location = new System.Drawing.Point(67, 323);
            this.nupInitialHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nupInitialHour.Name = "nupInitialHour";
            this.nupInitialHour.Size = new System.Drawing.Size(59, 27);
            this.nupInitialHour.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 22);
            this.label4.TabIndex = 45;
            this.label4.Text = "SALIDA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(268, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 44;
            this.label3.Text = "Mins.";
            // 
            // nupFinalMinute
            // 
            this.nupFinalMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupFinalMinute.Location = new System.Drawing.Point(207, 425);
            this.nupFinalMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nupFinalMinute.Name = "nupFinalMinute";
            this.nupFinalMinute.Size = new System.Drawing.Size(55, 27);
            this.nupFinalMinute.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 42;
            this.label2.Text = "Hrs.";
            // 
            // nupFinalHour
            // 
            this.nupFinalHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupFinalHour.Location = new System.Drawing.Point(67, 425);
            this.nupFinalHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nupFinalHour.Name = "nupFinalHour";
            this.nupFinalHour.Size = new System.Drawing.Size(59, 27);
            this.nupFinalHour.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 40;
            this.label1.Text = "ENTRADA";
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCode.Location = new System.Drawing.Point(63, 543);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(222, 24);
            this.lbCode.TabIndex = 38;
            this.lbCode.Text = "CÓDIGO DE HORARIO";
            // 
            // txtCode
            // 
            this.txtCode.AutoSize = true;
            this.txtCode.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(61, 593);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(120, 33);
            this.txtCode.TabIndex = 69;
            this.txtCode.Text = "txtCode";
            // 
            // ModifyScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 717);
            this.Controls.Add(this.txtCode);
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
            this.Controls.Add(this.lbCode);
            this.Name = "ModifyScheduleForm";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Modificar Horario";
            this.Load += new System.EventHandler(this.ModifyScheduleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupDayExtra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNightExtra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupOrdinaryHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupInitialMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupInitialHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupFinalMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupFinalHour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDepartment;
        private MetroFramework.Controls.MetroButton mbSave;
        private MetroFramework.Controls.MetroButton mtAddRest;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbRest3;
        private System.Windows.Forms.ComboBox cbRest3;
        private System.Windows.Forms.ComboBox cbRest2;
        private System.Windows.Forms.Label lbRest2;
        private System.Windows.Forms.ComboBox cbRest1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nupDayExtra;
        private System.Windows.Forms.NumericUpDown nupNightExtra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nupOrdinaryHours;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nupInitialMinute;
        private System.Windows.Forms.NumericUpDown nupInitialHour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nupFinalMinute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nupFinalHour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.Label txtCode;
    }
}