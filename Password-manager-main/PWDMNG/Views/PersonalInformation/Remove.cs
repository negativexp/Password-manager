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
    public partial class Remove : Form
    {
        public Remove()
        {
            InitializeComponent();
        }

        private void Remove_Load(object sender, EventArgs e)
        {
            ListBoxPersonalInformation.Items.Clear();
            string folder = AppDomain.CurrentDomain.BaseDirectory + @"\Data\Personal Information";
            string[] jsonAESfiles = Directory.GetFiles(folder, "*.json.AES");
            foreach (var item in jsonAESfiles)
            {
                string filename = Path.GetFileNameWithoutExtension(item);
                ListBoxPersonalInformation.Items.Add(filename.Replace(".json", ""));
            }
        }

        private void ListBoxPersonalInformation_DoubleClick(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete '" + ListBoxPersonalInformation.SelectedItem + "'?", "File delete", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    {
                        File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Personal Information\" + ListBoxPersonalInformation.SelectedItem + ".json.AES");
                        MessageBox.Show("File deleted!");
                        break;
                    }
                case DialogResult.No:
                    {
                        break;
                    }
            }
        }
    }
}
