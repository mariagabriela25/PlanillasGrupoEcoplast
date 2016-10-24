namespace UserInterface
{
    partial class ModifyRestForm
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
            this.mLbCode = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mBtSaveChanges = new MetroFramework.Controls.MetroButton();
            this.nudMinutos = new System.Windows.Forms.NumericUpDown();
            this.mLbRestCode = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutos)).BeginInit();
            this.SuspendLayout();
            // 
            // mLbCode
            // 
            this.mLbCode.AutoSize = true;
            this.mLbCode.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mLbCode.Location = new System.Drawing.Point(23, 86);
            this.mLbCode.Name = "mLbCode";
            this.mLbCode.Size = new System.Drawing.Size(76, 25);
            this.mLbCode.TabIndex = 0;
            this.mLbCode.Text = "Código:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(23, 169);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(179, 25);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Cantidad de minutos";
            // 
            // mBtSaveChanges
            // 
            this.mBtSaveChanges.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mBtSaveChanges.ForeColor = System.Drawing.Color.Lime;
            this.mBtSaveChanges.Location = new System.Drawing.Point(375, 187);
            this.mBtSaveChanges.Margin = new System.Windows.Forms.Padding(4);
            this.mBtSaveChanges.Name = "mBtSaveChanges";
            this.mBtSaveChanges.Size = new System.Drawing.Size(278, 53);
            this.mBtSaveChanges.Style = MetroFramework.MetroColorStyle.Lime;
            this.mBtSaveChanges.TabIndex = 3;
            this.mBtSaveChanges.Text = "Guardar cambios";
            this.mBtSaveChanges.UseSelectable = true;
            this.mBtSaveChanges.Click += new System.EventHandler(this.mBtSaveChanges_Click);
            // 
            // nudMinutos
            // 
            this.nudMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMinutos.Location = new System.Drawing.Point(24, 210);
            this.nudMinutos.Margin = new System.Windows.Forms.Padding(4);
            this.nudMinutos.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudMinutos.Name = "nudMinutos";
            this.nudMinutos.Size = new System.Drawing.Size(160, 30);
            this.nudMinutos.TabIndex = 4;
            // 
            // mLbRestCode
            // 
            this.mLbRestCode.AutoSize = true;
            this.mLbRestCode.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mLbRestCode.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mLbRestCode.Location = new System.Drawing.Point(147, 86);
            this.mLbRestCode.Name = "mLbRestCode";
            this.mLbRestCode.Size = new System.Drawing.Size(124, 25);
            this.mLbRestCode.TabIndex = 5;
            this.mLbRestCode.Text = "metroLabel1";
            // 
            // ModifyRestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 279);
            this.Controls.Add(this.mLbRestCode);
            this.Controls.Add(this.nudMinutos);
            this.Controls.Add(this.mBtSaveChanges);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mLbCode);
            this.Name = "ModifyRestForm";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Modificar Descanso";
            this.Load += new System.EventHandler(this.ModifyRestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel mLbCode;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton mBtSaveChanges;
        private System.Windows.Forms.NumericUpDown nudMinutos;
        private MetroFramework.Controls.MetroLabel mLbRestCode;
    }
}