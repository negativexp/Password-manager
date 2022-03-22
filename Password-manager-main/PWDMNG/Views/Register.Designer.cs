namespace PWDMNG.Views
{
    partial class Register
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
            this.panelMove = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.metroSetPanel1 = new MetroSet_UI.Controls.MetroSetPanel();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.TextBoxRePassword = new MetroSet_UI.Controls.MetroSetTextBox();
            this.TextBoxPassword = new MetroSet_UI.Controls.MetroSetTextBox();
            this.panelMove.SuspendLayout();
            this.metroSetPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMove
            // 
            this.panelMove.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelMove.Controls.Add(this.label1);
            this.panelMove.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMove.Location = new System.Drawing.Point(0, 0);
            this.panelMove.Name = "panelMove";
            this.panelMove.Size = new System.Drawing.Size(250, 25);
            this.panelMove.TabIndex = 0;
            this.panelMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseDown);
            this.panelMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseMove);
            this.panelMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(229, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            // 
            // metroSetPanel1
            // 
            this.metroSetPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetPanel1.BorderThickness = 0;
            this.metroSetPanel1.Controls.Add(this.buttonRegister);
            this.metroSetPanel1.Controls.Add(this.TextBoxRePassword);
            this.metroSetPanel1.Controls.Add(this.TextBoxPassword);
            this.metroSetPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetPanel1.IsDerivedStyle = true;
            this.metroSetPanel1.Location = new System.Drawing.Point(0, 25);
            this.metroSetPanel1.Name = "metroSetPanel1";
            this.metroSetPanel1.Size = new System.Drawing.Size(250, 125);
            this.metroSetPanel1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetPanel1.StyleManager = null;
            this.metroSetPanel1.TabIndex = 2;
            this.metroSetPanel1.ThemeAuthor = "Narwin";
            this.metroSetPanel1.ThemeName = "MetroDark";
            // 
            // buttonRegister
            // 
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.ForeColor = System.Drawing.Color.White;
            this.buttonRegister.Location = new System.Drawing.Point(163, 90);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(75, 23);
            this.buttonRegister.TabIndex = 2;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // TextBoxRePassword
            // 
            this.TextBoxRePassword.AutoCompleteCustomSource = null;
            this.TextBoxRePassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TextBoxRePassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TextBoxRePassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.TextBoxRePassword.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TextBoxRePassword.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.TextBoxRePassword.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.TextBoxRePassword.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxRePassword.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.TextBoxRePassword.Image = null;
            this.TextBoxRePassword.IsDerivedStyle = true;
            this.TextBoxRePassword.Lines = null;
            this.TextBoxRePassword.Location = new System.Drawing.Point(12, 39);
            this.TextBoxRePassword.MaxLength = 32767;
            this.TextBoxRePassword.Multiline = false;
            this.TextBoxRePassword.Name = "TextBoxRePassword";
            this.TextBoxRePassword.ReadOnly = false;
            this.TextBoxRePassword.Size = new System.Drawing.Size(226, 27);
            this.TextBoxRePassword.Style = MetroSet_UI.Enums.Style.Light;
            this.TextBoxRePassword.StyleManager = null;
            this.TextBoxRePassword.TabIndex = 1;
            this.TextBoxRePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBoxRePassword.ThemeAuthor = "Narwin";
            this.TextBoxRePassword.ThemeName = "MetroLite";
            this.TextBoxRePassword.UseSystemPasswordChar = false;
            this.TextBoxRePassword.WatermarkText = "Repeat Password";
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.AutoCompleteCustomSource = null;
            this.TextBoxPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TextBoxPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TextBoxPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.TextBoxPassword.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TextBoxPassword.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.TextBoxPassword.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.TextBoxPassword.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxPassword.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.TextBoxPassword.Image = null;
            this.TextBoxPassword.IsDerivedStyle = true;
            this.TextBoxPassword.Lines = null;
            this.TextBoxPassword.Location = new System.Drawing.Point(12, 6);
            this.TextBoxPassword.MaxLength = 32767;
            this.TextBoxPassword.Multiline = false;
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.ReadOnly = false;
            this.TextBoxPassword.Size = new System.Drawing.Size(226, 27);
            this.TextBoxPassword.Style = MetroSet_UI.Enums.Style.Light;
            this.TextBoxPassword.StyleManager = null;
            this.TextBoxPassword.TabIndex = 0;
            this.TextBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBoxPassword.ThemeAuthor = "Narwin";
            this.TextBoxPassword.ThemeName = "MetroLite";
            this.TextBoxPassword.UseSystemPasswordChar = false;
            this.TextBoxPassword.WatermarkText = "Password";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 150);
            this.Controls.Add(this.metroSetPanel1);
            this.Controls.Add(this.panelMove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.Text = "Register";
            this.panelMove.ResumeLayout(false);
            this.panelMove.PerformLayout();
            this.metroSetPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMove;
        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel1;
        private System.Windows.Forms.Button buttonRegister;
        private MetroSet_UI.Controls.MetroSetTextBox TextBoxRePassword;
        private MetroSet_UI.Controls.MetroSetTextBox TextBoxPassword;
        private System.Windows.Forms.Label label1;
    }
}