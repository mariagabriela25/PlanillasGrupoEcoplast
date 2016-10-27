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
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.cbDepartment.Location = new System.Drawing.Point(286, 180);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(238, 28);
            this.cbDepartment.TabIndex = 68;
            // 
            // mbSave
            // 
            this.mbSave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbSave.ForeColor = System.Drawing.Color.Lime;
            this.mbSave.Location = new System.Drawing.Point(286, 436);
            this.mbSave.Margin = new System.Windows.Forms.Padding(4);
            this.mbSave.Name = "mbSave";
            this.mbSave.Size = new System.Drawing.Size(238, 55);
            this.mbSave.Style = MetroFramework.MetroColorStyle.Lime;
            this.mbSave.TabIndex = 67;
            this.mbSave.Text = "Guardar cambios";
            this.mbSave.UseSelectable = true;
            this.mbSave.Click += new System.EventHandler(this.mbSave_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(40, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 24);
            this.label11.TabIndex = 64;
            this.label11.Text = "DEPARTAMENTO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(476, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 19);
            this.label6.TabIndex = 56;
            this.label6.Text = "Mins.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(351, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 19);
            this.label5.TabIndex = 55;
            this.label5.Text = "Hrs.";
            // 
            // nupInitialMinute
            // 
            this.nupInitialMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupInitialMinute.Location = new System.Drawing.Point(415, 258);
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
            this.nupInitialHour.Location = new System.Drawing.Point(286, 259);
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
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 22);
            this.label4.TabIndex = 45;
            this.label4.Text = "SALIDA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(476, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 44;
            this.label3.Text = "Mins.";
            // 
            // nupFinalMinute
            // 
            this.nupFinalMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupFinalMinute.Location = new System.Drawing.Point(415, 333);
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
            this.label2.Location = new System.Drawing.Point(351, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 42;
            this.label2.Text = "Hrs.";
            // 
            // nupFinalHour
            // 
            this.nupFinalHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupFinalHour.Location = new System.Drawing.Point(286, 333);
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
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 40;
            this.label1.Text = "ENTRADA";
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCode.Location = new System.Drawing.Point(112, 100);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(102, 24);
            this.lbCode.TabIndex = 38;
            this.lbCode.Text = "HORARIO";
            // 
            // txtCode
            // 
            this.txtCode.AutoSize = true;
            this.txtCode.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(281, 95);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(102, 29);
            this.txtCode.TabIndex = 69;
            this.txtCode.Text = "txtCode";
            // 
            // ModifyScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 563);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.mbSave);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
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