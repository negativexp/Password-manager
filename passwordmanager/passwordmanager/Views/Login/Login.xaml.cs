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
using System.Windows.Shapes;

namespace passwordmanager.Views.Login
{
    /// <summary>
    /// Interakční logika pro Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();

            //check if user has already made a password
            if (Properties.Settings.Default.pwdhash == "")
            {
                //user havent created a password
            }
            else
            {
                TextBoxPasswordRepeat.Visibility = Visibility.Hidden;
            }
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //check if user has already made a password
            if (Properties.Settings.Default.pwdhash == "")
            {
                //user havent created a password
                CreatePassword();
            }
            else
            {
                CheckPassword();
            }
            }
            private void CreatePassword()
        {
            if (TextBoxPassword.Text.Equals(TextBoxPasswordRepeat.Text))
            {
                Properties.Settings.Default.pwdhash = Hash.SHA256.Create(TextBoxPassword.Text);
                Properties.Settings.Default.Save();
            }
            else
                MessageBox.Show("Please type in the same password!","ERROR!");
        }
        private void CheckPassword()
        {
            if(Hash.SHA256.Create(TextBoxPassword.Text).Equals(Properties.Settings.Default.pwdhash))
            {
                this.Hide();
                MainWindow mw = new MainWindow();
                mw.Show();
            }
            else
                MessageBox.Show("Wrong Password!");
        }
    }
}
