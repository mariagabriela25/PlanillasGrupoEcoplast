namespace UserInterface
{
    partial class DayReviewUserControl
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
            this.mnWeekNum = new System.Windows.Forms.NumericUpDown();
            this.mbCheck = new MetroFramework.Controls.MetroButton();
            this.cbDepart = new System.Windows.Forms.ComboBox();
            this.mpgCalculation = new MetroFramework.Controls.MetroProgressBar();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mnWeekNum)).BeginInit();
            this.SuspendLayout();
            // 
            // mnWeekNum
            // 
            this.mnWeekNum.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnWeekNum.Location = new System.Drawing.Point(196, 58);
            this.mnWeekNum.Margin = new System.Windows.Forms.Padding(4);
            this.mnWeekNum.Maximum = new decimal(new int[] {
            52,
            0,
            0,
            0});
            this.mnWeekNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mnWeekNum.Name = "mnWeekNum";
            this.mnWeekNum.Size = new System.Drawing.Size(88, 34);
            this.mnWeekNum.TabIndex = 2;
            this.mnWeekNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // mbCheck
            // 
            this.mbCheck.Enabled = false;
            this.mbCheck.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbCheck.Location = new System.Drawing.Point(545, 153);
            this.mbCheck.Margin = new System.Windows.Forms.Padding(4);
            this.mbCheck.Name = "mbCheck";
            this.mbCheck.Size = new System.Drawing.Size(197, 59);
            this.mbCheck.TabIndex = 4;
            this.mbCheck.Text = "Calcular";
            this.mbCheck.UseSelectable = true;
            this.mbCheck.Click += new System.EventHandler(this.mbCheck_Click);
            // 
            // cbDepart
            // 
            this.cbDepart.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepart.FormattingEnabled = true;
            this.cbDepart.Location = new System.Drawing.Point(524, 60);
            this.cbDepart.Margin = new System.Windows.Forms.Padding(4);
            this.cbDepart.Name = "cbDepart";
            this.cbDepart.Size = new System.Drawing.Size(218, 32);
            this.cbDepart.TabIndex = 5;
            this.cbDepart.SelectedIndexChanged += new System.EventHandler(this.cbDepart_SelectedIndexChanged);
            // 
            // mpgCalculation
            // 
            this.mpgCalculation.Location = new System.Drawing.Point(-3, 258);
            this.mpgCalculation.Margin = new System.Windows.Forms.Padding(4);
            this.mpgCalculation.Name = "mpgCalculation";
            this.mpgCalculation.Size = new System.Drawing.Size(804, 10);
            this.mpgCalculation.Style = MetroFramework.MetroColorStyle.Lime;
            this.mpgCalculation.TabIndex = 6;
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 224);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Semana:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(319, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "Departamento:";
            // 
            // DayReviewUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 263);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mpgCalculation);
            this.Controls.Add(this.cbDepart);
            this.Controls.Add(this.mbCheck);
            this.Controls.Add(this.mnWeekNum);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DayReviewUserControl";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Load += new System.EventHandler(this.DayReviewUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mnWeekNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown mnWeekNum;
        private MetroFramework.Controls.MetroButton mbCheck;
        private System.Windows.Forms.ComboBox cbDepart;
        private MetroFramework.Controls.MetroProgressBar mpgCalculation;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
