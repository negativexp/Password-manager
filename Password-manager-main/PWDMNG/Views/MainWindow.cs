using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PWDMNG
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //on load hide all sub panels
            panelSubPersonal.Visible = false;
            panelSubSecureNotes.Visible = false;
        }

        private void HideSubMenus()
        {
            if (panelSubPersonal.Visible)
            {
                panelSubPersonal.Visible = false;
            }
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenus();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        //mouse
        bool mouseDown;
        private Point lastLocation;
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
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
            }
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.PanelChildForm.Controls.Add(childForm);
            this.PanelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void buttonPersonalInformation_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubPersonal);
            openChildForm(new Views.PersonalInformation.Main());
        }

        private void buttonSecureNotes_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubSecureNotes);
        }

        private void buttonPersonalInformationAdd_Click(object sender, EventArgs e)
        {
            openChildForm(new Views.PersonalInformation.Add());
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonPersonalInformationRemove_Click(object sender, EventArgs e)
        {
            openChildForm(new Views.PersonalInformation.Remove());
        }
    }
}
