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
    /// Interakční logika pro Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public class LoginTitle
        {
            public string title { get; set; }
        }

        string folder = AppDomain.CurrentDomain.BaseDirectory + @"\Data\Logins\";
        string[] jsonAESfiles = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Logins\", "*.AES");

        private readonly MainWindow _mw;
        public Main(MainWindow mw)
        {
            InitializeComponent();
            UpdateListBox();
            _mw = mw;
        }
        private void UpdateListBox()
        {
            ListBoxLogins.ItemsSource = null;
            ListBoxLogins.Items.Clear();
            List<LoginTitle> list = new List<LoginTitle>();

            foreach (string item in jsonAESfiles)
            {
                string cache = item.Replace(folder, "");
                string cache2 = cache.Replace(".json", "");
                list.Add(new LoginTitle() { title = cache2.Replace(".AES", "") });
            }
            ListBoxLogins.ItemsSource = list;
        }

        private void ListBoxLogins_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                _mw.UpdateFrameContent("/Views/Logins/View.xaml", jsonAESfiles[ListBoxLogins.SelectedIndex]);
            }
            catch
            {

            }
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                File.Delete(jsonAESfiles[ListBoxLogins.SelectedIndex]);
                MessageBox.Show("Data has been deleted!", "Success!");
            }
            catch (Exception)
            {
                MessageBox.Show("Please select an item!");
            }
            finally
            {
                UpdateListBox();
            }
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            _mw.UpdateFrameContent("/Views/Logins/Add.xaml", "");
        }
    }
}
