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
using System.Windows.Threading;

namespace passwordmanager.Views.Credit_Cards
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

            string folder = AppDomain.CurrentDomain.BaseDirectory + @"\Data\Credit Cards\";
            string cache = x.Replace(folder, "");
            string cache2 = cache.Replace(".json", "");
            string cache3 = cache2.Replace(".AES", "");



            try
            {
                AES.Decryption.Decrypt(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Credit Cards\" + cache3 + ".AES", AppDomain.CurrentDomain.BaseDirectory + @"\Data\Cache\" + cache3 + ".json", Encoding.ASCII.GetBytes(pwdhash));
                JSONdeserialize(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Cache\" + cache3 + ".json");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while decrypting the data!", "ERROR!");
                _mw.UpdateFrameContent("/Views/Credit Cards/Main.xaml", "");
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

                TextBoxOwner.Text = XOR.XOR.EncryptOrDecrypt(Convert.ToString(item.owner));
                TextBoxCVV.Text = XOR.XOR.EncryptOrDecrypt(Convert.ToString(item.cvv));
                TextBoxCardNumber.Text = XOR.XOR.EncryptOrDecrypt(Convert.ToString(item.cardnumber));
                TextBoxExpireMonth.Text = XOR.XOR.EncryptOrDecrypt(Convert.ToString(item.expiredateMonth));
                TextBoxExpireYear.Text = XOR.XOR.EncryptOrDecrypt(Convert.ToString(item.expiredateYear));
            }
            JSONitems = null;
        }
        private void JSONdeserializeBasicInfo()
        {
            dynamic JSONitems = JsonConvert.DeserializeObject(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Basic.json"));
            foreach (var item in JSONitems)
            {
                pwdhash = item.pwdhash;
            }
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            _mw.UpdateFrameContent("/Views/Credit Cards/Main.xaml", "");
        }

        private void TextBoxOwner_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Clipboard.SetText(TextBoxOwner.Text);

            TextBlockCopied.Visibility = Visibility.Visible;
            TextBlockCopied.Content = string.Format("Copied: Owner " + "({0})", TextBoxOwner.Text);
            t.Start();
        }

        private void TextBoxCVV_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Clipboard.SetText(TextBoxCVV.Text);

            TextBlockCopied.Visibility = Visibility.Visible;
            TextBlockCopied.Content = string.Format("Copied: CVV");
            t.Start();
        }

        private void TextBoxCardNumber_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Clipboard.SetText(TextBoxCardNumber.Text);

            TextBlockCopied.Visibility = Visibility.Visible;
            TextBlockCopied.Content = string.Format("Copied: Card Number " + "({0})", TextBoxCardNumber.Text);
            t.Start();
        }

        private void TextBoxExpireMonth_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Clipboard.SetText(TextBoxExpireMonth.Text);

            TextBlockCopied.Visibility = Visibility.Visible;
            TextBlockCopied.Content = string.Format("Copied: Experation Date - Month " + "({0})", TextBoxExpireMonth.Text);
            t.Start();
        }

        private void TextBoxExpireYear_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Clipboard.SetText(TextBoxExpireYear.Text);

            TextBlockCopied.Visibility = Visibility.Visible;
            TextBlockCopied.Content = string.Format("Copied: Experation Date - Year " + "({0})", TextBoxExpireYear.Text);
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
