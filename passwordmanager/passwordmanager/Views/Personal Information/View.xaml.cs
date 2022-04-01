using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace passwordmanager.Views.Personal_Information
{
    /// <summary>
    /// Interakční logika pro View.xaml
    /// </summary>
    public partial class View : Page
    {
        public static string pwdhash;
        private readonly MainWindow _mw;
        public View(string x, MainWindow mw)
        {
            InitializeComponent();
            JSONdeserializeBasicInfo();

            _mw = mw;

            string folder = AppDomain.CurrentDomain.BaseDirectory + @"\Data\Personal Information\";
            string cache = x.Replace(folder, "");
            string cache2 = cache.Replace(".json", "");
            string cache3 = cache2.Replace(".AES", "");



            try
            {
                AES.Decryption.Decrypt(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Personal Information\" + cache3 + ".AES", AppDomain.CurrentDomain.BaseDirectory + @"\Data\Cache\" + cache3 + ".json", Encoding.ASCII.GetBytes(pwdhash));
                JSONdeserialize(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Cache\" + cache3 + ".json");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while decrypting the data! ","ERROR!");
                _mw.UpdateFrameContent("/Views/Personal Information/Main.xaml", "");
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

                TextBoxFullName.Text = XOR.XOR.EncryptOrDecrypt(Convert.ToString(item.fullname));
                TextBoxEmail.Text = XOR.XOR.EncryptOrDecrypt(Convert.ToString(item.email));
                TextBoxPhone.Text = XOR.XOR.EncryptOrDecrypt(Convert.ToString(item.phone));
                TextBoxAddressLine1.Text = XOR.XOR.EncryptOrDecrypt(Convert.ToString(item.addressline1));
                TextBoxAddressLine2.Text = XOR.XOR.EncryptOrDecrypt(Convert.ToString(item.addressline2));
                TextBoxCity.Text = XOR.XOR.EncryptOrDecrypt(Convert.ToString(item.city));
                TextBoxPostalCode.Text = XOR.XOR.EncryptOrDecrypt(Convert.ToString(item.postalcode));
                TextBoxStateOrProvince.Text = XOR.XOR.EncryptOrDecrypt(Convert.ToString(item.stateorprovince));
                TextBoxCountryOrRegion.Text = XOR.XOR.EncryptOrDecrypt(Convert.ToString(item.countryorregion));
            }
            JSONitems = null;
        }


        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            _mw.UpdateFrameContent("/Views/Personal Information/Main.xaml", "");
        }
        private void JSONdeserializeBasicInfo()
        {
            dynamic JSONitems = JsonConvert.DeserializeObject(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Basic.json"));
            foreach (var item in JSONitems)
            {
                pwdhash = item.pwdhash;
            }
        }

        private void TextBoxFullName_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Clipboard.SetText(TextBoxFullName.Text);

            TextBlockCopied.Visibility = Visibility.Visible;
            TextBlockCopied.Content = string.Format("Copied: Full Name " + "({0})", TextBoxFullName.Text);
            t.Start();

        }

        private void TextBoxEmail_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Clipboard.SetText(TextBoxEmail.Text);

            TextBlockCopied.Visibility = Visibility.Visible;
            TextBlockCopied.Content = string.Format("Copied: Email " + "({0})", TextBoxEmail.Text);
            t.Start();
        }

        private void TextBoxPhone_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Clipboard.SetText(TextBoxPhone.Text);

            TextBlockCopied.Visibility = Visibility.Visible;
            TextBlockCopied.Content = string.Format("Copied: Phone " + "({0})", TextBoxPhone.Text);
            t.Start();
        }

        private void TextBoxAddressLine1_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Clipboard.SetText(TextBoxAddressLine1.Text);

            TextBlockCopied.Visibility = Visibility.Visible;
            TextBlockCopied.Content = string.Format("Copied: Address Line 1 " + "({0})", TextBoxAddressLine1.Text);
            t.Start();
        }

        private void TextBoxAddressLine2_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Clipboard.SetText(TextBoxAddressLine2.Text);

            TextBlockCopied.Visibility = Visibility.Visible;
            TextBlockCopied.Content = string.Format("Copied: Address Line 2 " + "({0})", TextBoxAddressLine2.Text);
            t.Start();
        }

        private void TextBoxCity_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Clipboard.SetText(TextBoxCity.Text);

            TextBlockCopied.Visibility = Visibility.Visible;
            TextBlockCopied.Content = string.Format("Copied: City " + "({0})", TextBoxCity.Text);
            t.Start();
        }

        private void TextBoxPostalCode_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Clipboard.SetText(TextBoxPostalCode.Text);

            TextBlockCopied.Visibility = Visibility.Visible;
            TextBlockCopied.Content = string.Format("Copied: ZIP or Postal Code " + "({0})", TextBoxPostalCode.Text);
            t.Start();
        }

        private void TextBoxStateOrProvince_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Clipboard.SetText(TextBoxStateOrProvince.Text);

            TextBlockCopied.Visibility = Visibility.Visible;
            TextBlockCopied.Content = string.Format("Copied: State or Province " + "({0})", TextBoxStateOrProvince.Text);
            t.Start();
        }

        private void TextBoxCountryOrRegion_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Clipboard.SetText(TextBoxCountryOrRegion.Text);

            TextBlockCopied.Visibility = Visibility.Visible;
            TextBlockCopied.Content = string.Format("Copied: Country or Region " + "({0})", TextBoxCountryOrRegion.Text);
            t.Start();
        }

        static DispatcherTimer t = new DispatcherTimer();
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            t.Interval = new TimeSpan(0, 0, 5);
            t.Tick += (EventHandler)delegate (object snd, EventArgs ea)
            {
                TextBlockCopied.Visibility = Visibility.Collapsed;
                ((DispatcherTimer)snd).Stop();
            };

            TextBlockCopied.Visibility = Visibility.Hidden;
        }
    }
}
