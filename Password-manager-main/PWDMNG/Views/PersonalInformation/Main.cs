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

namespace PWDMNG.Views.PersonalInformation
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ListBoxPersonalInformation.Items.Clear();
            string folder = AppDomain.CurrentDomain.BaseDirectory + @"\Data\Personal Information";
            string[] jsonAESfiles = Directory.GetFiles(folder, "*.json.AES");
            foreach(var item in jsonAESfiles)
            {
                string filename = Path.GetFileNameWithoutExtension(item);
                ListBoxPersonalInformation.Items.Add(filename.Replace(".json",""));
            }
            if (ListBoxPersonalInformation.Items.Count == 0)
            {
                label1.Visible = true;
            }
            else
                label1.Visible = false;

        }

        private void ListBoxPersonalInformation_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (ListBoxPersonalInformation.SelectedItem != null)
                {
                    Views.PersonalInformation.View windowview = new Views.PersonalInformation.View(ListBoxPersonalInformation.SelectedItem.ToString());
                    windowview.Show();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("The data you tried to open canno't be opened! " + ex.ToString(),"Cannot open!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ListBoxPersonalInformation_SelectedIndexChanged(object sender)
        {

        }
    }
}
