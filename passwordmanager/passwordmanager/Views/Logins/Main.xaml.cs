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
        class TextNames
        {
            public string text { get; set; }
        }

        string[] jsonAESfiles = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Logins\", "*.AES");


        private readonly MainWindow _mainWindow;
        public Main(MainWindow mainWindow)
        {
            InitializeComponent();
            UpdateListBox();
            _mainWindow = mainWindow;
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.UpdateFrameContent("/Views/Logins/Add.xaml", "");
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
        private void UpdateListBox()
        {
            ListBoxName.ItemsSource = null;
            ListBoxName.Items.Clear();

            List<TextNames> list = new List<TextNames>();

            foreach (string item in jsonAESfiles)
            {
                list.Add(new TextNames() { text = System.IO.Path.GetFileName(item) });
            }
            ListBoxName.ItemsSource = list;
        }
        private void ListBoxName_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                _mainWindow.UpdateFrameContent("/Views/Logins/View.xaml", jsonAESfiles[ListBoxName.SelectedIndex]);
            }
            catch
            {

            }
        }
    }
}
