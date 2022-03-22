using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PWDMNG.Views.PersonalInformation
{
    public partial class View : Form
    {
        public View(string filename)
        {
            InitializeComponent();
            AES.Decryption.Decrypt(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Personal Information\" + filename + ".json.AES",
                AppDomain.CurrentDomain.BaseDirectory + @"\Data\Cache\" + filename + ".json", Encoding.ASCII.GetBytes(Properties.Settings.Default.pwdhash));
            JSONdeserialize(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Cache\" + filename + ".json");
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
        private void JSONdeserialize(string path)
        {
            dynamic dynJson = JsonConvert.DeserializeObject(File.ReadAllText(path));
            foreach (var item in dynJson)
            {
                labelTitle.Text = labelTitle.Text +item.title;
                labelFullName.Text = labelFullName.Text + XOR.XOR.EncryptOrDecrypt(Convert.ToString(item.fullname));
                labelEmail.Text = labelEmail.Text + XOR.XOR.EncryptOrDecrypt(Convert.ToString(item.email));
                labelPhone.Text = labelPhone.Text + XOR.XOR.EncryptOrDecrypt(Convert.ToString(item.phone));
                labelAddressLine1.Text = labelAddressLine1.Text + XOR.XOR.EncryptOrDecrypt(Convert.ToString(item.addressline1));
                labelAddressLine2.Text = labelAddressLine2.Text + XOR.XOR.EncryptOrDecrypt(Convert.ToString(item.addressline2));
                labelCity.Text = labelCity.Text + XOR.XOR.EncryptOrDecrypt(Convert.ToString(item.city));
                labelPostalCode.Text = labelPostalCode.Text + XOR.XOR.EncryptOrDecrypt(Convert.ToString(item.postalcode));
                labelStateOrProvince.Text = labelStateOrProvince.Text + XOR.XOR.EncryptOrDecrypt(Convert.ToString(item.stateorprovince));
                labelCountryOrRegion.Text = labelCountryOrRegion.Text + XOR.XOR.EncryptOrDecrypt(Convert.ToString(item.countryorregion));
                File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Cache\" + item.title + ".json");
            }
            dynJson = null;
        }

        private void View_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
