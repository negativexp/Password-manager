using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PWDMNG.Views.PersonalInformation
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void buttonPersonalInformation_Click(object sender, EventArgs e)
        {
            JSON.JSONcreate.PersonalInformation JSONpi = new JSON.JSONcreate.PersonalInformation();
            JSONpi.Create(TextBoxTitle.Text, TextBoxFullName.Text,
                TextBoxEmail.Text, TextBoxPhone.Text,
                TextBoxAddressLine1.Text, TextBoxAddressLine2.Text,
                TextBoxCity.Text, TextBoxPostalCode.Text,
                TextBoxStateOrProvince.Text, TextBoxCountryOrRegion.Text);
        }
    }
}
