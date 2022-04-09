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

        private bool CheckDirectory()
        {
            return
            Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "/Data/Cache") &
            Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "/Data/Personal Information") &
            Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "/Data/Logins") &
            Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "/Data/Credit Cards") &
            Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "/Data/Secure Notes");
        }
        private string[] GetjsonAESfiles()
        {
            if (!CheckDirectory())
            {
                MessageBox.Show("Missing folders");
                Environment.Exit(1);
                return null;
            }
            return Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Personal Information\", "*.AES");
        }

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

            foreach (string item in GetjsonAESfiles())
            {
                string cache = System.IO.Path.GetFileName(item);
                list.Add(new TextNames() { text = cache.Replace(".AES", "")});
            }
            ListBoxName.ItemsSource = list;
        }

        private void ListBoxName_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                _mainWindow.UpdateFrameContent("/Views/Personal Information/View.xaml", GetjsonAESfiles()[ListBoxName.SelectedIndex]);
            }
            catch
            {

            }
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.UpdateFrameContent("/Views/Personal Information/Add.xaml", "");
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                File.Delete(GetjsonAESfiles()[ListBoxName.SelectedIndex]);
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
