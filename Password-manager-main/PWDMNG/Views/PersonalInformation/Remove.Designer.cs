
namespace PWDMNG.Views.PersonalInformation
{
    partial class Remove
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
            this.ListBoxPersonalInformation = new MetroSet_UI.Controls.MetroSetListBox();
            this.SuspendLayout();
            // 
            // ListBoxPersonalInformation
            // 
            this.ListBoxPersonalInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ListBoxPersonalInformation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ListBoxPersonalInformation.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ListBoxPersonalInformation.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ListBoxPersonalInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxPersonalInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ListBoxPersonalInformation.HoveredItemBackColor = System.Drawing.Color.LightGray;
            this.ListBoxPersonalInformation.HoveredItemColor = System.Drawing.Color.DimGray;
            this.ListBoxPersonalInformation.IsDerivedStyle = true;
            this.ListBoxPersonalInformation.ItemHeight = 30;
            this.ListBoxPersonalInformation.Location = new System.Drawing.Point(0, 0);
            this.ListBoxPersonalInformation.MultiSelect = false;
            this.ListBoxPersonalInformation.Name = "ListBoxPersonalInformation";
            this.ListBoxPersonalInformation.SelectedIndex = -1;
            this.ListBoxPersonalInformation.SelectedItem = null;
            this.ListBoxPersonalInformation.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ListBoxPersonalInformation.SelectedItemColor = System.Drawing.Color.White;
            this.ListBoxPersonalInformation.SelectedText = null;
            this.ListBoxPersonalInformation.SelectedValue = null;
            this.ListBoxPersonalInformation.ShowBorder = false;
            this.ListBoxPersonalInformation.ShowScrollBar = false;
            this.ListBoxPersonalInformation.Size = new System.Drawing.Size(920, 550);
            this.ListBoxPersonalInformation.Style = MetroSet_UI.Enums.Style.Dark;
            this.ListBoxPersonalInformation.StyleManager = null;
            this.ListBoxPersonalInformation.TabIndex = 0;
            this.ListBoxPersonalInformation.ThemeAuthor = "Narwin";
            this.ListBoxPersonalInformation.ThemeName = "MetroDark";
            this.ListBoxPersonalInformation.DoubleClick += new System.EventHandler(this.ListBoxPersonalInformation_DoubleClick);
            // 
            // Remove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 550);
            this.Controls.Add(this.ListBoxPersonalInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Remove";
            this.Text = "Remove";
            this.Load += new System.EventHandler(this.Remove_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetListBox ListBoxPersonalInformation;
    }
}