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

namespace passwordmanager.Views.Secure_Notes
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

        string[] jsonAESfiles = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Secure Notes\", "*.AES");

        private readonly MainWindow _mainWindow;
        public Main(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            ListBoxName.ItemsSource = null;
            ListBoxName.Items.Clear();

            List<TextNames> list = new List<TextNames>();

            foreach (string item in jsonAESfiles)
            {
                string cache = System.IO.Path.GetFileName(item);
                list.Add(new TextNames() { text = cache.Replace(".AES", "") });
            }
            ListBoxName.ItemsSource = list;
        }

        private void ListBoxName_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                _mainWindow.UpdateFrameContent("/Views/Secure Notes/View.xaml", jsonAESfiles[ListBoxName.SelectedIndex]);
            }
            catch
            {

            }
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.UpdateFrameContent("/Views/Secure Notes/Add.xaml", "");
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                File.Delete(jsonAESfiles[ListBoxName.SelectedIndex]);
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
    }
}
