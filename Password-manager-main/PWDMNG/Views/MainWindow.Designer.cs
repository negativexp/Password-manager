namespace PWDMNG
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
            this.panelMove = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelSubSecureNotes = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonSecureNotes = new System.Windows.Forms.Button();
            this.panelSubPersonal = new System.Windows.Forms.Panel();
            this.buttonPersonalInformationRemove = new System.Windows.Forms.Button();
            this.buttonPersonalInformationAdd = new System.Windows.Forms.Button();
            this.buttonPersonalInformation = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelChildForm = new MetroSet_UI.Controls.MetroSetPanel();
            this.panelMove.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelSubSecureNotes.SuspendLayout();
            this.panelSubPersonal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMove
            // 
            this.panelMove.BackColor = System.Drawing.Color.Black;
            this.panelMove.Controls.Add(this.label2);
            this.panelMove.Controls.Add(this.label1);
            this.panelMove.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelMove.Location = new System.Drawing.Point(160, 0);
            this.panelMove.Name = "panelMove";
            this.panelMove.Size = new System.Drawing.Size(920, 50);
            this.panelMove.TabIndex = 0;
            this.panelMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseDown);
            this.panelMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseMove);
            this.panelMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(846, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "_";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(878, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.panelSubSecureNotes);
            this.panel2.Controls.Add(this.buttonSecureNotes);
            this.panel2.Controls.Add(this.panelSubPersonal);
            this.panel2.Controls.Add(this.buttonPersonalInformation);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 600);
            this.panel2.TabIndex = 1;
            // 
            // panelSubSecureNotes
            // 
            this.panelSubSecureNotes.Controls.Add(this.button1);
            this.panelSubSecureNotes.Controls.Add(this.button5);
            this.panelSubSecureNotes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubSecureNotes.Location = new System.Drawing.Point(0, 190);
            this.panelSubSecureNotes.Name = "panelSubSecureNotes";
            this.panelSubSecureNotes.Size = new System.Drawing.Size(160, 60);
            this.panelSubSecureNotes.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 30);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(160, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Remove";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DimGray;
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(160, 30);
            this.button5.TabIndex = 4;
            this.button5.Text = "Add";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // buttonSecureNotes
            // 
            this.buttonSecureNotes.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSecureNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSecureNotes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSecureNotes.ForeColor = System.Drawing.Color.White;
            this.buttonSecureNotes.Location = new System.Drawing.Point(0, 150);
            this.buttonSecureNotes.Name = "buttonSecureNotes";
            this.buttonSecureNotes.Size = new System.Drawing.Size(160, 40);
            this.buttonSecureNotes.TabIndex = 3;
            this.buttonSecureNotes.Text = "Secure notes";
            this.buttonSecureNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSecureNotes.UseVisualStyleBackColor = true;
            this.buttonSecureNotes.Click += new System.EventHandler(this.buttonSecureNotes_Click);
            // 
            // panelSubPersonal
            // 
            this.panelSubPersonal.Controls.Add(this.buttonPersonalInformationRemove);
            this.panelSubPersonal.Controls.Add(this.buttonPersonalInformationAdd);
            this.panelSubPersonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubPersonal.Location = new System.Drawing.Point(0, 90);
            this.panelSubPersonal.Name = "panelSubPersonal";
            this.panelSubPersonal.Size = new System.Drawing.Size(160, 60);
            this.panelSubPersonal.TabIndex = 2;
            // 
            // buttonPersonalInformationRemove
            // 
            this.buttonPersonalInformationRemove.BackColor = System.Drawing.Color.DimGray;
            this.buttonPersonalInformationRemove.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPersonalInformationRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPersonalInformationRemove.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPersonalInformationRemove.ForeColor = System.Drawing.Color.White;
            this.buttonPersonalInformationRemove.Location = new System.Drawing.Point(0, 30);
            this.buttonPersonalInformationRemove.Name = "buttonPersonalInformationRemove";
            this.buttonPersonalInformationRemove.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonPersonalInformationRemove.Size = new System.Drawing.Size(160, 30);
            this.buttonPersonalInformationRemove.TabIndex = 4;
            this.buttonPersonalInformationRemove.Text = "Remove";
            this.buttonPersonalInformationRemove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPersonalInformationRemove.UseVisualStyleBackColor = false;
            this.buttonPersonalInformationRemove.Click += new System.EventHandler(this.buttonPersonalInformationRemove_Click);
            // 
            // buttonPersonalInformationAdd
            // 
            this.buttonPersonalInformationAdd.BackColor = System.Drawing.Color.DimGray;
            this.buttonPersonalInformationAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPersonalInformationAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPersonalInformationAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPersonalInformationAdd.ForeColor = System.Drawing.Color.White;
            this.buttonPersonalInformationAdd.Location = new System.Drawing.Point(0, 0);
            this.buttonPersonalInformationAdd.Name = "buttonPersonalInformationAdd";
            this.buttonPersonalInformationAdd.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonPersonalInformationAdd.Size = new System.Drawing.Size(160, 30);
            this.buttonPersonalInformationAdd.TabIndex = 3;
            this.buttonPersonalInformationAdd.Text = "Add";
            this.buttonPersonalInformationAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPersonalInformationAdd.UseVisualStyleBackColor = false;
            this.buttonPersonalInformationAdd.Click += new System.EventHandler(this.buttonPersonalInformationAdd_Click);
            // 
            // buttonPersonalInformation
            // 
            this.buttonPersonalInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPersonalInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPersonalInformation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPersonalInformation.ForeColor = System.Drawing.Color.White;
            this.buttonPersonalInformation.Location = new System.Drawing.Point(0, 50);
            this.buttonPersonalInformation.Name = "buttonPersonalInformation";
            this.buttonPersonalInformation.Size = new System.Drawing.Size(160, 40);
            this.buttonPersonalInformation.TabIndex = 2;
            this.buttonPersonalInformation.Text = "Personal Information";
            this.buttonPersonalInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPersonalInformation.UseVisualStyleBackColor = true;
            this.buttonPersonalInformation.Click += new System.EventHandler(this.buttonPersonalInformation_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(160, 50);
            this.panel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.PanelChildForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(160, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 550);
            this.panel1.TabIndex = 2;
            // 
            // PanelChildForm
            // 
            this.PanelChildForm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PanelChildForm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.PanelChildForm.BorderThickness = 0;
            this.PanelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelChildForm.IsDerivedStyle = true;
            this.PanelChildForm.Location = new System.Drawing.Point(0, 0);
            this.PanelChildForm.Name = "PanelChildForm";
            this.PanelChildForm.Size = new System.Drawing.Size(920, 550);
            this.PanelChildForm.Style = MetroSet_UI.Enums.Style.Dark;
            this.PanelChildForm.StyleManager = null;
            this.PanelChildForm.TabIndex = 0;
            this.PanelChildForm.ThemeAuthor = "Narwin";
            this.PanelChildForm.ThemeName = "MetroDark";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1080, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMove);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMove.ResumeLayout(false);
            this.panelMove.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelSubSecureNotes.ResumeLayout(false);
            this.panelSubPersonal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMove;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelSubSecureNotes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonSecureNotes;
        private System.Windows.Forms.Panel panelSubPersonal;
        private System.Windows.Forms.Button buttonPersonalInformationRemove;
        private System.Windows.Forms.Button buttonPersonalInformationAdd;
        private System.Windows.Forms.Button buttonPersonalInformation;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private MetroSet_UI.Controls.MetroSetPanel PanelChildForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

