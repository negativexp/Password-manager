
namespace PasswordManager
{
    partial class MainWindow
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.SideMenuPanel = new System.Windows.Forms.Panel();
            this.panelSubLogins = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonLogins = new System.Windows.Forms.Button();
            this.panelSubPersonalInformation = new System.Windows.Forms.Panel();
            this.buttonPersonalInformationAdd = new System.Windows.Forms.Button();
            this.buttonPersonalInformationRemove = new System.Windows.Forms.Button();
            this.buttonPersonalInformation = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelMove = new System.Windows.Forms.Panel();
            this.buttonSecureNotes = new System.Windows.Forms.Button();
            this.panelSubSecureNotes = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SideMenuPanel.SuspendLayout();
            this.panelSubLogins.SuspendLayout();
            this.panelSubPersonalInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMove.SuspendLayout();
            this.panelSubSecureNotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideMenuPanel
            // 
            this.SideMenuPanel.AutoScroll = true;
            this.SideMenuPanel.BackColor = System.Drawing.Color.Black;
            this.SideMenuPanel.Controls.Add(this.panelSubSecureNotes);
            this.SideMenuPanel.Controls.Add(this.buttonSecureNotes);
            this.SideMenuPanel.Controls.Add(this.panelSubLogins);
            this.SideMenuPanel.Controls.Add(this.buttonLogins);
            this.SideMenuPanel.Controls.Add(this.panelSubPersonalInformation);
            this.SideMenuPanel.Controls.Add(this.buttonPersonalInformation);
            this.SideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenuPanel.Location = new System.Drawing.Point(0, 50);
            this.SideMenuPanel.Name = "SideMenuPanel";
            this.SideMenuPanel.Size = new System.Drawing.Size(150, 550);
            this.SideMenuPanel.TabIndex = 0;
            // 
            // panelSubLogins
            // 
            this.panelSubLogins.BackColor = System.Drawing.Color.DimGray;
            this.panelSubLogins.Controls.Add(this.button3);
            this.panelSubLogins.Controls.Add(this.button1);
            this.panelSubLogins.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubLogins.Location = new System.Drawing.Point(0, 120);
            this.panelSubLogins.Name = "panelSubLogins";
            this.panelSubLogins.Size = new System.Drawing.Size(150, 60);
            this.panelSubLogins.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(0, 30);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(150, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Remove";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(150, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "Add";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // buttonLogins
            // 
            this.buttonLogins.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLogins.FlatAppearance.BorderSize = 0;
            this.buttonLogins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogins.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLogins.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLogins.Location = new System.Drawing.Point(0, 90);
            this.buttonLogins.Name = "buttonLogins";
            this.buttonLogins.Size = new System.Drawing.Size(150, 30);
            this.buttonLogins.TabIndex = 7;
            this.buttonLogins.Text = "Logins";
            this.buttonLogins.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogins.UseVisualStyleBackColor = true;
            this.buttonLogins.Click += new System.EventHandler(this.buttonLogins_Click);
            // 
            // panelSubPersonalInformation
            // 
            this.panelSubPersonalInformation.BackColor = System.Drawing.Color.DimGray;
            this.panelSubPersonalInformation.Controls.Add(this.buttonPersonalInformationAdd);
            this.panelSubPersonalInformation.Controls.Add(this.buttonPersonalInformationRemove);
            this.panelSubPersonalInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubPersonalInformation.Location = new System.Drawing.Point(0, 30);
            this.panelSubPersonalInformation.Name = "panelSubPersonalInformation";
            this.panelSubPersonalInformation.Size = new System.Drawing.Size(150, 60);
            this.panelSubPersonalInformation.TabIndex = 6;
            // 
            // buttonPersonalInformationAdd
            // 
            this.buttonPersonalInformationAdd.BackColor = System.Drawing.Color.Transparent;
            this.buttonPersonalInformationAdd.FlatAppearance.BorderSize = 0;
            this.buttonPersonalInformationAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPersonalInformationAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPersonalInformationAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPersonalInformationAdd.Location = new System.Drawing.Point(0, 0);
            this.buttonPersonalInformationAdd.Name = "buttonPersonalInformationAdd";
            this.buttonPersonalInformationAdd.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonPersonalInformationAdd.Size = new System.Drawing.Size(150, 30);
            this.buttonPersonalInformationAdd.TabIndex = 5;
            this.buttonPersonalInformationAdd.Text = "Add";
            this.buttonPersonalInformationAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPersonalInformationAdd.UseVisualStyleBackColor = false;
            // 
            // buttonPersonalInformationRemove
            // 
            this.buttonPersonalInformationRemove.BackColor = System.Drawing.Color.Transparent;
            this.buttonPersonalInformationRemove.FlatAppearance.BorderSize = 0;
            this.buttonPersonalInformationRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPersonalInformationRemove.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPersonalInformationRemove.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPersonalInformationRemove.Location = new System.Drawing.Point(0, 30);
            this.buttonPersonalInformationRemove.Name = "buttonPersonalInformationRemove";
            this.buttonPersonalInformationRemove.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonPersonalInformationRemove.Size = new System.Drawing.Size(150, 30);
            this.buttonPersonalInformationRemove.TabIndex = 6;
            this.buttonPersonalInformationRemove.Text = "Remove";
            this.buttonPersonalInformationRemove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPersonalInformationRemove.UseVisualStyleBackColor = false;
            // 
            // buttonPersonalInformation
            // 
            this.buttonPersonalInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPersonalInformation.FlatAppearance.BorderSize = 0;
            this.buttonPersonalInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPersonalInformation.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPersonalInformation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPersonalInformation.Location = new System.Drawing.Point(0, 0);
            this.buttonPersonalInformation.Name = "buttonPersonalInformation";
            this.buttonPersonalInformation.Size = new System.Drawing.Size(150, 30);
            this.buttonPersonalInformation.TabIndex = 0;
            this.buttonPersonalInformation.Text = "Personal Information";
            this.buttonPersonalInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPersonalInformation.UseVisualStyleBackColor = true;
            this.buttonPersonalInformation.Click += new System.EventHandler(this.buttonPersonalInformation_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelChildForm.Location = new System.Drawing.Point(150, 50);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(930, 550);
            this.panelChildForm.TabIndex = 1;
            // 
            // panelMove
            // 
            this.panelMove.BackColor = System.Drawing.Color.Black;
            this.panelMove.Controls.Add(this.pictureBox1);
            this.panelMove.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMove.Location = new System.Drawing.Point(0, 0);
            this.panelMove.Name = "panelMove";
            this.panelMove.Size = new System.Drawing.Size(1080, 50);
            this.panelMove.TabIndex = 0;
            this.panelMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseDown);
            this.panelMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseMove);
            this.panelMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseUp);
            // 
            // buttonSecureNotes
            // 
            this.buttonSecureNotes.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSecureNotes.FlatAppearance.BorderSize = 0;
            this.buttonSecureNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSecureNotes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSecureNotes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSecureNotes.Location = new System.Drawing.Point(0, 180);
            this.buttonSecureNotes.Name = "buttonSecureNotes";
            this.buttonSecureNotes.Size = new System.Drawing.Size(150, 30);
            this.buttonSecureNotes.TabIndex = 9;
            this.buttonSecureNotes.Text = "Secure Notes";
            this.buttonSecureNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSecureNotes.UseVisualStyleBackColor = true;
            this.buttonSecureNotes.Click += new System.EventHandler(this.buttonSecureNotes_Click);
            // 
            // panelSubSecureNotes
            // 
            this.panelSubSecureNotes.BackColor = System.Drawing.Color.DimGray;
            this.panelSubSecureNotes.Controls.Add(this.button4);
            this.panelSubSecureNotes.Controls.Add(this.button2);
            this.panelSubSecureNotes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubSecureNotes.Location = new System.Drawing.Point(0, 210);
            this.panelSubSecureNotes.Name = "panelSubSecureNotes";
            this.panelSubSecureNotes.Size = new System.Drawing.Size(150, 60);
            this.panelSubSecureNotes.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(0, 30);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(150, 30);
            this.button4.TabIndex = 6;
            this.button4.Text = "Remove";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(150, 30);
            this.button3.TabIndex = 7;
            this.button3.Text = "Add";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 600);
            this.Controls.Add(this.SideMenuPanel);
            this.Controls.Add(this.panelMove);
            this.Controls.Add(this.panelChildForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.SideMenuPanel.ResumeLayout(false);
            this.panelSubLogins.ResumeLayout(false);
            this.panelSubPersonalInformation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMove.ResumeLayout(false);
            this.panelSubSecureNotes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideMenuPanel;
        private System.Windows.Forms.Button buttonPersonalInformation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel panelMove;
        private System.Windows.Forms.Button buttonPersonalInformationAdd;
        private System.Windows.Forms.Button buttonPersonalInformationRemove;
        private System.Windows.Forms.Panel panelSubLogins;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonLogins;
        private System.Windows.Forms.Panel panelSubPersonalInformation;
        private System.Windows.Forms.Panel panelSubSecureNotes;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonSecureNotes;
        private System.Windows.Forms.Button button3;
    }
}

