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
            this.mlDepart = new MetroFramework.Controls.MetroLabel();
            this.mnWeekNum = new System.Windows.Forms.NumericUpDown();
            this.mlWeekNum = new MetroFramework.Controls.MetroLabel();
            this.mbCheck = new MetroFramework.Controls.MetroButton();
            this.cbDepart = new System.Windows.Forms.ComboBox();
            this.mpgCalculation = new MetroFramework.Controls.MetroProgressBar();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mnWeekNum)).BeginInit();
            this.SuspendLayout();
            // 
            // mlDepart
            // 
            this.mlDepart.AutoSize = true;
            this.mlDepart.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlDepart.Location = new System.Drawing.Point(220, 50);
            this.mlDepart.Name = "mlDepart";
            this.mlDepart.Size = new System.Drawing.Size(125, 25);
            this.mlDepart.TabIndex = 1;
            this.mlDepart.Text = "Departamento:";
            // 
            // mnWeekNum
            // 
            this.mnWeekNum.Location = new System.Drawing.Point(110, 55);
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
            this.mnWeekNum.Size = new System.Drawing.Size(66, 20);
            this.mnWeekNum.TabIndex = 2;
            this.mnWeekNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // mlWeekNum
            // 
            this.mlWeekNum.AutoSize = true;
            this.mlWeekNum.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlWeekNum.Location = new System.Drawing.Point(27, 50);
            this.mlWeekNum.Name = "mlWeekNum";
            this.mlWeekNum.Size = new System.Drawing.Size(77, 25);
            this.mlWeekNum.TabIndex = 3;
            this.mlWeekNum.Text = "Semana:";
            // 
            // mbCheck
            // 
            this.mbCheck.Enabled = false;
            this.mbCheck.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbCheck.Location = new System.Drawing.Point(197, 114);
            this.mbCheck.Name = "mbCheck";
            this.mbCheck.Size = new System.Drawing.Size(148, 54);
            this.mbCheck.TabIndex = 4;
            this.mbCheck.Text = "Calcular";
            this.mbCheck.UseSelectable = true;
            this.mbCheck.Click += new System.EventHandler(this.mbCheck_Click);
            // 
            // cbDepart
            // 
            this.cbDepart.FormattingEnabled = true;
            this.cbDepart.Location = new System.Drawing.Point(351, 55);
            this.cbDepart.Name = "cbDepart";
            this.cbDepart.Size = new System.Drawing.Size(176, 21);
            this.cbDepart.TabIndex = 5;
            this.cbDepart.SelectedIndexChanged += new System.EventHandler(this.cbDepart_SelectedIndexChanged);
            // 
            // mpgCalculation
            // 
            this.mpgCalculation.Location = new System.Drawing.Point(-2, 210);
            this.mpgCalculation.Name = "mpgCalculation";
            this.mpgCalculation.Size = new System.Drawing.Size(548, 5);
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
            this.label1.Location = new System.Drawing.Point(257, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // DayReviewUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mpgCalculation);
            this.Controls.Add(this.cbDepart);
            this.Controls.Add(this.mbCheck);
            this.Controls.Add(this.mlWeekNum);
            this.Controls.Add(this.mnWeekNum);
            this.Controls.Add(this.mlDepart);
            this.Name = "DayReviewUserControl";
            this.Size = new System.Drawing.Size(547, 214);
            this.Load += new System.EventHandler(this.DayReviewUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mnWeekNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel mlDepart;
        private System.Windows.Forms.NumericUpDown mnWeekNum;
        private MetroFramework.Controls.MetroLabel mlWeekNum;
        private MetroFramework.Controls.MetroButton mbCheck;
        private System.Windows.Forms.ComboBox cbDepart;
        private MetroFramework.Controls.MetroProgressBar mpgCalculation;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label label1;
    }
}
