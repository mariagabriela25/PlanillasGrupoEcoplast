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
            this.mlDepart.Location = new System.Drawing.Point(293, 62);
            this.mlDepart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlDepart.Name = "mlDepart";
            this.mlDepart.Size = new System.Drawing.Size(134, 25);
            this.mlDepart.TabIndex = 1;
            this.mlDepart.Text = "Departamento:";
            // 
            // mnWeekNum
            // 
            this.mnWeekNum.Location = new System.Drawing.Point(188, 68);
            this.mnWeekNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.mnWeekNum.Size = new System.Drawing.Size(88, 22);
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
            this.mlWeekNum.Location = new System.Drawing.Point(36, 62);
            this.mlWeekNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlWeekNum.Name = "mlWeekNum";
            this.mlWeekNum.Size = new System.Drawing.Size(79, 25);
            this.mlWeekNum.TabIndex = 3;
            this.mlWeekNum.Text = "Semana:";
            // 
            // mbCheck
            // 
            this.mbCheck.Enabled = false;
            this.mbCheck.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbCheck.Location = new System.Drawing.Point(263, 140);
            this.mbCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mbCheck.Name = "mbCheck";
            this.mbCheck.Size = new System.Drawing.Size(197, 66);
            this.mbCheck.TabIndex = 4;
            this.mbCheck.Text = "Calcular";
            this.mbCheck.UseSelectable = true;
            this.mbCheck.Click += new System.EventHandler(this.mbCheck_Click);
            // 
            // cbDepart
            // 
            this.cbDepart.FormattingEnabled = true;
            this.cbDepart.Location = new System.Drawing.Point(468, 68);
            this.cbDepart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDepart.Name = "cbDepart";
            this.cbDepart.Size = new System.Drawing.Size(233, 24);
            this.cbDepart.TabIndex = 5;
            this.cbDepart.SelectedIndexChanged += new System.EventHandler(this.cbDepart_SelectedIndexChanged);
            // 
            // mpgCalculation
            // 
            this.mpgCalculation.Location = new System.Drawing.Point(-3, 258);
            this.mpgCalculation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mpgCalculation.Name = "mpgCalculation";
            this.mpgCalculation.Size = new System.Drawing.Size(731, 6);
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
            // DayReviewUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 263);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mpgCalculation);
            this.Controls.Add(this.cbDepart);
            this.Controls.Add(this.mbCheck);
            this.Controls.Add(this.mlWeekNum);
            this.Controls.Add(this.mnWeekNum);
            this.Controls.Add(this.mlDepart);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DayReviewUserControl";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
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
