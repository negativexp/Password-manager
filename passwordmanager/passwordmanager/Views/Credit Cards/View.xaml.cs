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
        }

        private void TextBoxCVV_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Clipboard.SetText(TextBoxCVV.Text);
        }

        private void TextBoxCardNumber_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Clipboard.SetText(TextBoxCardNumber.Text);
        }

        private void TextBoxExpireMonth_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Clipboard.SetText(TextBoxExpireMonth.Text);
        }

        private void TextBoxExpireYear_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Clipboard.SetText(TextBoxExpireYear.Text);
        }
    }
}
