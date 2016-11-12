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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.mbSave = new MetroFramework.Controls.MetroButton();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupFinalHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupFinalMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupInitialHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupInitialMinute)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCode.Location = new System.Drawing.Point(106, 83);
            this.lbCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(73, 19);
            this.lbCode.TabIndex = 0;
            this.lbCode.Text = "CÓDIGO";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(212, 80);
            this.txtCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(188, 23);
            this.txtCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 204);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "ENTRADA";
            // 
            // nupFinalHour
            // 
            this.nupFinalHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupFinalHour.Location = new System.Drawing.Point(212, 259);
            this.nupFinalHour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nupFinalHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nupFinalHour.Name = "nupFinalHour";
            this.nupFinalHour.Size = new System.Drawing.Size(44, 23);
            this.nupFinalHour.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 266);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hrs.";
            // 
            // nupFinalMinute
            // 
            this.nupFinalMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupFinalMinute.Location = new System.Drawing.Point(318, 259);
            this.nupFinalMinute.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nupFinalMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nupFinalMinute.Name = "nupFinalMinute";
            this.nupFinalMinute.Size = new System.Drawing.Size(41, 23);
            this.nupFinalMinute.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(363, 266);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mins.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 263);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "SALIDA";
            // 
            // nupInitialHour
            // 
            this.nupInitialHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupInitialHour.Location = new System.Drawing.Point(212, 200);
            this.nupInitialHour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nupInitialHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nupInitialHour.Name = "nupInitialHour";
            this.nupInitialHour.Size = new System.Drawing.Size(44, 23);
            this.nupInitialHour.TabIndex = 8;
            // 
            // nupInitialMinute
            // 
            this.nupInitialMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupInitialMinute.Location = new System.Drawing.Point(318, 200);
            this.nupInitialMinute.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nupInitialMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nupInitialMinute.Name = "nupInitialMinute";
            this.nupInitialMinute.Size = new System.Drawing.Size(41, 23);
            this.nupInitialMinute.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(261, 206);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Hrs.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(364, 206);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Mins.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 140);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 19);
            this.label11.TabIndex = 32;
            this.label11.Text = "DEPARTAMENTO";
            // 
            // mbSave
            // 
            this.mbSave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbSave.ForeColor = System.Drawing.Color.Lime;
            this.mbSave.Location = new System.Drawing.Point(212, 339);
            this.mbSave.Name = "mbSave";
            this.mbSave.Size = new System.Drawing.Size(188, 45);
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
            this.cbDepartment.Location = new System.Drawing.Point(212, 136);
            this.cbDepartment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(188, 25);
            this.cbDepartment.TabIndex = 37;
            this.cbDepartment.SelectedIndexChanged += new System.EventHandler(this.cbDepartment_SelectedIndexChanged);
            // 
            // AddScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 427);
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
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lbCode);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddScheduleForm";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Agregar nuevo horario";
            this.Load += new System.EventHandler(this.AddScheduleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupFinalHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupFinalMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupInitialHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupInitialMinute)).EndInit();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private MetroFramework.Controls.MetroButton mbSave;
        private System.Windows.Forms.ComboBox cbDepartment;
    }
}