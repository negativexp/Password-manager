using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PWDMNG.Views
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (TextBoxPassword.Text.Equals(TextBoxRePassword.Text))
            {
                Properties.Settings.Default.pwdhash = Hash.SHA_256.Create(TextBoxPassword.Text);
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Please enter the same password twice!","ERROR");
            }
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
    }
}
