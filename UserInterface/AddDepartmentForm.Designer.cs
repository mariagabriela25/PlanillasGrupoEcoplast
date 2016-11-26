namespace UserInterface
{
    partial class AddDepartmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDepartmentForm));
            this.mlCode = new MetroFramework.Controls.MetroLabel();
            this.mbSave = new MetroFramework.Controls.MetroButton();
            this.mtbCode = new MetroFramework.Controls.MetroTextBox();
            this.mlName = new MetroFramework.Controls.MetroLabel();
            this.mtbName = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // mlCode
            // 
            this.mlCode.AutoSize = true;
            this.mlCode.Location = new System.Drawing.Point(41, 88);
            this.mlCode.Name = "mlCode";
            this.mlCode.Size = new System.Drawing.Size(53, 19);
            this.mlCode.TabIndex = 0;
            this.mlCode.Text = "Codigo";
            // 
            // mbSave
            // 
            this.mbSave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbSave.Location = new System.Drawing.Point(41, 265);
            this.mbSave.Name = "mbSave";
            this.mbSave.Size = new System.Drawing.Size(114, 38);
            this.mbSave.Style = MetroFramework.MetroColorStyle.Lime;
            this.mbSave.TabIndex = 2;
            this.mbSave.Text = "Guardar";
            this.mbSave.UseSelectable = true;
            this.mbSave.Click += new System.EventHandler(this.mbSave_Click);
            // 
            // mtbCode
            // 
            // 
            // 
            // 
            this.mtbCode.CustomButton.Image = null;
            this.mtbCode.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.mtbCode.CustomButton.Name = "";
            this.mtbCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbCode.CustomButton.TabIndex = 1;
            this.mtbCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbCode.CustomButton.UseSelectable = true;
            this.mtbCode.CustomButton.Visible = false;
            this.mtbCode.Lines = new string[0];
            this.mtbCode.Location = new System.Drawing.Point(41, 120);
            this.mtbCode.MaxLength = 32767;
            this.mtbCode.Name = "mtbCode";
            this.mtbCode.PasswordChar = '\0';
            this.mtbCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbCode.SelectedText = "";
            this.mtbCode.SelectionLength = 0;
            this.mtbCode.SelectionStart = 0;
            this.mtbCode.ShortcutsEnabled = true;
            this.mtbCode.Size = new System.Drawing.Size(200, 23);
            this.mtbCode.TabIndex = 2;
            this.mtbCode.UseSelectable = true;
            this.mtbCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlName
            // 
            this.mlName.AutoSize = true;
            this.mlName.Location = new System.Drawing.Point(41, 173);
            this.mlName.Name = "mlName";
            this.mlName.Size = new System.Drawing.Size(59, 19);
            this.mlName.TabIndex = 3;
            this.mlName.Text = "Nombre";
            // 
            // mtbName
            // 
            // 
            // 
            // 
            this.mtbName.CustomButton.Image = null;
            this.mtbName.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.mtbName.CustomButton.Name = "";
            this.mtbName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbName.CustomButton.TabIndex = 1;
            this.mtbName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbName.CustomButton.UseSelectable = true;
            this.mtbName.CustomButton.Visible = false;
            this.mtbName.Lines = new string[0];
            this.mtbName.Location = new System.Drawing.Point(41, 205);
            this.mtbName.MaxLength = 32767;
            this.mtbName.Name = "mtbName";
            this.mtbName.PasswordChar = '\0';
            this.mtbName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbName.SelectedText = "";
            this.mtbName.SelectionLength = 0;
            this.mtbName.SelectionStart = 0;
            this.mtbName.ShortcutsEnabled = true;
            this.mtbName.Size = new System.Drawing.Size(200, 23);
            this.mtbName.TabIndex = 4;
            this.mtbName.UseSelectable = true;
            this.mtbName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AddDepartmentForm
            // 
            this.ClientSize = new System.Drawing.Size(291, 345);
            this.Controls.Add(this.mtbName);
            this.Controls.Add(this.mlName);
            this.Controls.Add(this.mtbCode);
            this.Controls.Add(this.mbSave);
            this.Controls.Add(this.mlCode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddDepartmentForm";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Agregar Departamento";
            this.Load += new System.EventHandler(this.AddDepartmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel mlCode;
        private MetroFramework.Controls.MetroButton mbSave;
        private MetroFramework.Controls.MetroTextBox mtbCode;
        private MetroFramework.Controls.MetroLabel mlName;
        private MetroFramework.Controls.MetroTextBox mtbName;
    }
}