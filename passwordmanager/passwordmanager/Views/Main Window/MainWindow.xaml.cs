using System;
using System.Collections.Generic;
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
        public MainWindow()
        {
            InitializeComponent();
        }

        public void UpdateFrameContent(string uri, string index)
        {
            if (uri == "/Views/Personal Information/Main.xaml")
                FrameContent.Content = new Views.Personal_Information.Main(this);
            if (uri == "/Views/Personal Information/Add.xaml")
                FrameContent.Content = new Views.Personal_Information.Add(this);
            if (uri == "/Views/Personal Information/View.xaml")
                FrameContent.Content = new Views.Personal_Information.View(index);
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
        }
        private void Logins_Click(object sender, RoutedEventArgs e)
        {
            FrameContent.Content = new Views.Logins.Main(this);
        }
        private void SecureNotes_Click(object sender, RoutedEventArgs e)
        {
        }
        private void CreditCards_Click(object sender, RoutedEventArgs e)
        {
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
        }
    }
}
