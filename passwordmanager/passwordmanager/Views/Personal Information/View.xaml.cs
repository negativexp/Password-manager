using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace passwordmanager.Views.Personal_Information
{
    /// <summary>
    /// Interakční logika pro View.xaml
    /// </summary>
    public partial class View : Page
    {
        public View(string x)
        {
            InitializeComponent();

            string folder = AppDomain.CurrentDomain.BaseDirectory + @"\Data\Personal Information\";
            string cache = x.Replace(folder, "");
            string cache2 = cache.Replace(".json", "");
            string cache3 = cache2.Replace(".AES", "");
            TextBlockTitle.Text = cache3;

            try
            {
                AES.Decryption.Decrypt(x, AppDomain.CurrentDomain.BaseDirectory + @"\Data\Cache\" + cache3 + ".json", Encoding.ASCII.GetBytes(Properties.Settings.Default.pwdhash));
                JSONdeserialize(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Cache\" + cache3 + ".json");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while decrypting the data!","ERROR!");
            }
            finally
            {
                File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Cache\" + cache3 + ".json");
            }
        }
        private void JSONdeserialize(string path)
        {
            dynamic dynJson = JsonConvert.DeserializeObject(File.ReadAllText(path));
            foreach (var item in dynJson)
            {
                TextBoxTitle.Text = item.title;
            }
            dynJson = null;
        }
    }
}
