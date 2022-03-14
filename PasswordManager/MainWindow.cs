using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            panelSubPersonalInformation.Visible = false;
            panelSubLogins.Visible = false;
            panelSubSecureNotes.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSubPersonalInformation.Visible)
                panelSubPersonalInformation.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelChildForm.Controls.Add(childForm);
            this.panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        bool mouseDown;
        private Point lastLocation;
        private void buttonPersonalInformation_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubPersonalInformation);
            openChildForm(new PersonalInformationForm());
        }

        private void panelMove_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panelMove_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panelMove_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
            }
        }

        private void buttonLogins_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubLogins);
        }

        private void buttonSecureNotes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubSecureNotes);
        }

        private void buttonPersonalInformationAdd_Click(object sender, EventArgs e)
        {
            openChildForm(new PersonalInformationAddForm());
        }
    }
}
