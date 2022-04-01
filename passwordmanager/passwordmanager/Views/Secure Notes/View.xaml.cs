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

namespace passwordmanager.Views.Secure_Notes
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

            string folder = AppDomain.CurrentDomain.BaseDirectory + @"\Data\Secure Notes\";
            string cache = x.Replace(folder, "");
            string cache2 = cache.Replace(".json", "");
            string cache3 = cache2.Replace(".AES", "");



            try
            {
                AES.Decryption.Decrypt(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Secure Notes\" + cache3 + ".AES", AppDomain.CurrentDomain.BaseDirectory + @"\Data\Cache\" + cache3 + ".json", Encoding.ASCII.GetBytes(pwdhash));
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

                TextBoxContent.Text = XOR.XOR.EncryptOrDecrypt(Convert.ToString(item.content));
            }
            JSONitems = null;
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            _mw.UpdateFrameContent("/Views/Secure Notes/Main.xaml", "");
        }
        private void JSONdeserializeBasicInfo()
        {
            dynamic JSONitems = JsonConvert.DeserializeObject(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Basic.json"));
            foreach (var item in JSONitems)
            {
                pwdhash = item.pwdhash;
            }
        }

        private void TextBoxContent_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Clipboard.SetText(TextBoxContent.Text);

            TextBlockCopied.Visibility = Visibility.Visible;
            TextBlockCopied.Content = string.Format("Copied: Content");
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
