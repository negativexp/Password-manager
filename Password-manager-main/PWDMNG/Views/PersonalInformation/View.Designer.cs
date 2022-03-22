namespace PWDMNG.Views.PersonalInformation
{
    partial class View
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
            this.PanelMain = new MetroSet_UI.Controls.MetroSetPanel();
            this.panelMove = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelAddressLine1 = new System.Windows.Forms.Label();
            this.labelAddressLine2 = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelPostalCode = new System.Windows.Forms.Label();
            this.labelStateOrProvince = new System.Windows.Forms.Label();
            this.labelCountryOrRegion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelMain.SuspendLayout();
            this.panelMove.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PanelMain.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.PanelMain.BorderThickness = 0;
            this.PanelMain.Controls.Add(this.labelCountryOrRegion);
            this.PanelMain.Controls.Add(this.labelStateOrProvince);
            this.PanelMain.Controls.Add(this.labelPostalCode);
            this.PanelMain.Controls.Add(this.labelCity);
            this.PanelMain.Controls.Add(this.labelAddressLine2);
            this.PanelMain.Controls.Add(this.labelAddressLine1);
            this.PanelMain.Controls.Add(this.labelEmail);
            this.PanelMain.Controls.Add(this.labelPhone);
            this.PanelMain.Controls.Add(this.labelFullName);
            this.PanelMain.Controls.Add(this.labelTitle);
            this.PanelMain.Controls.Add(this.panelMove);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.IsDerivedStyle = true;
            this.PanelMain.Location = new System.Drawing.Point(0, 0);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(920, 550);
            this.PanelMain.Style = MetroSet_UI.Enums.Style.Dark;
            this.PanelMain.StyleManager = null;
            this.PanelMain.TabIndex = 2;
            this.PanelMain.ThemeAuthor = "Narwin";
            this.PanelMain.ThemeName = "MetroDark";
            // 
            // panelMove
            // 
            this.panelMove.BackColor = System.Drawing.Color.Black;
            this.panelMove.Controls.Add(this.label1);
            this.panelMove.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMove.Location = new System.Drawing.Point(0, 0);
            this.panelMove.Name = "panelMove";
            this.panelMove.Size = new System.Drawing.Size(920, 50);
            this.panelMove.TabIndex = 0;
            this.panelMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseDown);
            this.panelMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseMove);
            this.panelMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseUp);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Calibri", 12F);
            this.labelTitle.Location = new System.Drawing.Point(169, 100);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(46, 19);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Title: ";
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Calibri", 12F);
            this.labelFullName.Location = new System.Drawing.Point(169, 135);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(82, 19);
            this.labelFullName.TabIndex = 2;
            this.labelFullName.Text = "Full Name: ";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Calibri", 12F);
            this.labelPhone.Location = new System.Drawing.Point(170, 202);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(57, 19);
            this.labelPhone.TabIndex = 3;
            this.labelPhone.Text = "Phone: ";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Calibri", 12F);
            this.labelEmail.Location = new System.Drawing.Point(170, 169);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(53, 19);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Email: ";
            // 
            // labelAddressLine1
            // 
            this.labelAddressLine1.AutoSize = true;
            this.labelAddressLine1.Font = new System.Drawing.Font("Calibri", 12F);
            this.labelAddressLine1.Location = new System.Drawing.Point(169, 233);
            this.labelAddressLine1.Name = "labelAddressLine1";
            this.labelAddressLine1.Size = new System.Drawing.Size(112, 19);
            this.labelAddressLine1.TabIndex = 5;
            this.labelAddressLine1.Text = "Address Line 1: ";
            // 
            // labelAddressLine2
            // 
            this.labelAddressLine2.AutoSize = true;
            this.labelAddressLine2.Font = new System.Drawing.Font("Calibri", 12F);
            this.labelAddressLine2.Location = new System.Drawing.Point(169, 270);
            this.labelAddressLine2.Name = "labelAddressLine2";
            this.labelAddressLine2.Size = new System.Drawing.Size(112, 19);
            this.labelAddressLine2.TabIndex = 6;
            this.labelAddressLine2.Text = "Address Line 2: ";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Calibri", 12F);
            this.labelCity.Location = new System.Drawing.Point(169, 307);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(42, 19);
            this.labelCity.TabIndex = 7;
            this.labelCity.Text = "City: ";
            // 
            // labelPostalCode
            // 
            this.labelPostalCode.AutoSize = true;
            this.labelPostalCode.Font = new System.Drawing.Font("Calibri", 12F);
            this.labelPostalCode.Location = new System.Drawing.Point(169, 347);
            this.labelPostalCode.Name = "labelPostalCode";
            this.labelPostalCode.Size = new System.Drawing.Size(135, 19);
            this.labelPostalCode.TabIndex = 8;
            this.labelPostalCode.Text = "ZIP or Postal Code: ";
            // 
            // labelStateOrProvince
            // 
            this.labelStateOrProvince.AutoSize = true;
            this.labelStateOrProvince.Font = new System.Drawing.Font("Calibri", 12F);
            this.labelStateOrProvince.Location = new System.Drawing.Point(169, 380);
            this.labelStateOrProvince.Name = "labelStateOrProvince";
            this.labelStateOrProvince.Size = new System.Drawing.Size(126, 19);
            this.labelStateOrProvince.TabIndex = 9;
            this.labelStateOrProvince.Text = "State or Province: ";
            // 
            // labelCountryOrRegion
            // 
            this.labelCountryOrRegion.AutoSize = true;
            this.labelCountryOrRegion.Font = new System.Drawing.Font("Calibri", 12F);
            this.labelCountryOrRegion.Location = new System.Drawing.Point(169, 414);
            this.labelCountryOrRegion.Name = "labelCountryOrRegion";
            this.labelCountryOrRegion.Size = new System.Drawing.Size(133, 19);
            this.labelCountryOrRegion.TabIndex = 10;
            this.labelCountryOrRegion.Text = "Country or Region: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(883, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 550);
            this.Controls.Add(this.PanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "View";
            this.Text = "View";
            this.Load += new System.EventHandler(this.View_Load);
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            this.panelMove.ResumeLayout(false);
            this.panelMove.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetPanel PanelMain;
        private System.Windows.Forms.Panel panelMove;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAddressLine2;
        private System.Windows.Forms.Label labelAddressLine1;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelCountryOrRegion;
        private System.Windows.Forms.Label labelStateOrProvince;
        private System.Windows.Forms.Label labelPostalCode;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label label1;
    }
}