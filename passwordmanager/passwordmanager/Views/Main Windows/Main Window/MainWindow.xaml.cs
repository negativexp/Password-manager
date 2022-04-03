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

namespace passwordmanager
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string preferdname;
        public MainWindow()
        {
            InitializeComponent();
            JSONdeserializeBasicInfo();
            ChangeData();
        }

        private void JSONdeserializeBasicInfo()
        {
            dynamic JSONitems = JsonConvert.DeserializeObject(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Basic.json"));
            foreach (var item in JSONitems)
            {
                preferdname = item.basicpreferdname;
            }
        }

        public void UpdateFrameContent(string uri, string index)
        {
            //personal information
            if (uri == "/Views/Personal Information/Main.xaml")
                FrameContent.Content = new Views.Personal_Information.Main(this);
            if (uri == "/Views/Personal Information/Add.xaml")
                FrameContent.Content = new Views.Personal_Information.Add(this);
            if (uri == "/Views/Personal Information/View.xaml")
                FrameContent.Content = new Views.Personal_Information.View(index, this);

            //logins
            if (uri == "/Views/Logins/Main.xaml")
                FrameContent.Content = new Views.Logins.Main(this);
            if (uri == "/Views/Logins/Add.xaml")
                FrameContent.Content = new Views.Logins.Add(this);
            if (uri == "/Views/Logins/View.xaml")
                FrameContent.Content = new Views.Logins.View(index, this);

            //credit cards
            if (uri == "/Views/Credit Cards/Main.xaml")
                FrameContent.Content = new Views.Credit_Cards.Main(this);
            if (uri == "/Views/Credit Cards/Add.xaml")
                FrameContent.Content = new Views.Credit_Cards.Add(this);
            if (uri == "/Views/Credit Cards/View.xaml")
                FrameContent.Content = new Views.Credit_Cards.View(index, this);

            //secure notes
            if (uri == "/Views/Secure Notes/Main.xaml")
                FrameContent.Content = new Views.Secure_Notes.Main(this);
            if (uri == "/Views/Secure Notes/Add.xaml")
                FrameContent.Content = new Views.Secure_Notes.Add(this);
            if (uri == "/Views/Secure Notes/View.xaml")
                FrameContent.Content = new Views.Secure_Notes.View(index, this);


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        private void PersonalInformation_Click(object sender, RoutedEventArgs e)
        {
            FrameContent.Content = new Views.Personal_Information.Main(this);
            MainGrid.Visibility = Visibility.Hidden;
        }
        private void Logins_Click(object sender, RoutedEventArgs e)
        {
            FrameContent.Content = new Views.Logins.Main(this);
            MainGrid.Visibility = Visibility.Hidden;
        }
        private void SecureNotes_Click(object sender, RoutedEventArgs e)
        {
            FrameContent.Content = new Views.Secure_Notes.Main(this);
            MainGrid.Visibility = Visibility.Hidden;
        }
        private void CreditCards_Click(object sender, RoutedEventArgs e)
        {
            FrameContent.Content = new Views.Credit_Cards.Main(this);
            MainGrid.Visibility = Visibility.Hidden;
        }
        private void PasswordGenerator_Click(object sender, RoutedEventArgs e)
        {
            FrameContent.Content = new Views.Password_Generator.PasswordGenerator();
            MainGrid.Visibility = Visibility.Hidden;
        }
        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            FrameContent.Content = new Views.Main_Windows.Settings.Settings();
            MainGrid.Visibility = Visibility.Hidden;
        }

        private void ButtonX_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
        private void ButtonMinimze_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;

        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            FrameContent.Content = null;
            MainGrid.Visibility = Visibility.Visible;
            ChangeData();
        }
        private void ChangeData()
        {
            TextBlockPreferdName.Text = "Welcome back, " + preferdname + "!";

            string[] data = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + "/Data/", "*.AES", SearchOption.AllDirectories);
            TextBlockAmountOfData.Text = "Amount of data: " + data.Count();
        }
    }
}
