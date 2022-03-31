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
using System.Windows.Shapes;

namespace passwordmanager.Views.Login
{
    /// <summary>
    /// Interakční logika pro Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public static string pwdhash;
        public Login()
        {
            //create folders
            Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "/Data/Cache");
            Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "/Data/Personal Information");
            Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "/Data/Logins");
            Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "/Data/Credit Cards");
            Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "/Data/Secure Notes");

            try
            {
                JSONdeserializeBasicInfo();
            }
            catch (Exception)
            {

            }

            //check if Password has been made
            if (pwdhash == null)
            {
                this.Hide();
                Views.Main_Windows.Setup setup = new Views.Main_Windows.Setup();
                setup.Show();
            }

            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Hash.SHA256.Create(TextBoxPassword.Password).Equals(pwdhash))
            {
                this.Hide();
                MainWindow mw = new MainWindow();
                mw.Show();
            }
            else
                MessageBox.Show("Wrong Password!");
        }
        private void JSONdeserializeBasicInfo()
        {
            dynamic JSONitems = JsonConvert.DeserializeObject(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Basic.json"));
            foreach (var item in JSONitems)
            {
                pwdhash = item.pwdhash;
            }
        }
    }
}
