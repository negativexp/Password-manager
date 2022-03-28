using Newtonsoft.Json;
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

namespace passwordmanager.Views.Logins
{
    /// <summary>
    /// Interakční logika pro View.xaml
    /// </summary>
    public partial class View : Page
    {
        private readonly MainWindow _mw;
        public View(string x, MainWindow mw)
        {
            InitializeComponent();
            _mw = mw;

            string folder = AppDomain.CurrentDomain.BaseDirectory + @"\Data\Logins\";
            string cache = x.Replace(folder, "");
            string cache2 = cache.Replace(".json", "");
            string cache3 = cache2.Replace(".AES", "");

            try
            {
                AES.Decryption.Decrypt(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Logins\" + cache3 + ".json.AES", AppDomain.CurrentDomain.BaseDirectory + @"\Data\Cache\" + cache3 + ".json", Encoding.ASCII.GetBytes(Properties.Settings.Default.pwdhash));
                JSONdeserialize(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Cache\" + cache3 + ".json");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while decrypting the data! ", "ERROR!");
            }
            finally
            {
                File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Cache\" + cache3 + ".json");
            }
        }

        private void JSONdeserialize(string path)
        {
            dynamic JSONitems = JsonConvert.DeserializeObject(File.ReadAllText(path));
            foreach (var item in JSONitems)
            {
                TextBlockTitle.Text = item.title;
                TextBlockTime.Text = item.timecreated;

                TextBoxUsername.Text = XOR.XOR.EncryptOrDecrypt(Convert.ToString(item.username));
                TextBoxEmail.Text = XOR.XOR.EncryptOrDecrypt(Convert.ToString(item.email));
                TextBoxPassword.Text = XOR.XOR.EncryptOrDecrypt(Convert.ToString(item.password));
                TextBoxURL.Text = XOR.XOR.EncryptOrDecrypt(Convert.ToString(item.url));
            }
            JSONitems = null;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
