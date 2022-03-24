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

namespace passwordmanager.Views.Personal_Information
{
    /// <summary>
    /// Interakční logika pro Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        class TextNames
        {
            public string text { get; set; }
        }

        string folder = AppDomain.CurrentDomain.BaseDirectory + @"\Data\Personal Information\";
        string[] jsonAESfiles = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Personal Information\", "*.AES");

        private readonly MainWindow _mainWindow;
        public Main(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
            UpdateListBox();
        }

        private void Main_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void UpdateListBox()
        {
            ListBoxPersonal.ItemsSource = null;
            ListBoxPersonal.Items.Clear();
            List<TextNames> list = new List<TextNames>();

            foreach (string item in jsonAESfiles)
            {
                string cache = item.Replace(folder, "");
                string cache2 = cache.Replace(".json", "");
                list.Add(new TextNames() { text = cache2.Replace(".AES", "") });
            }
            ListBoxPersonal.ItemsSource = list;
        }

        private void ListBoxPersonal_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            _mainWindow.UpdateFrameContent("/Views/Personal Information/View.xaml", jsonAESfiles[ListBoxPersonal.SelectedIndex]);
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.UpdateFrameContent("/Views/Personal Information/Add.xaml", "");
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                File.Delete(jsonAESfiles[ListBoxPersonal.SelectedIndex]);
                MessageBox.Show("Data has been deleted!", "Success!");
                UpdateListBox();
            }
            catch (Exception)
            {
                MessageBox.Show("Please select an item!");
            }
        }
    }
}
