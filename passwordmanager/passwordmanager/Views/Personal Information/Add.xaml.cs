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

namespace passwordmanager.Views.Personal_Information
{
    /// <summary>
    /// Interakční logika pro Add.xaml
    /// </summary>
    public partial class Add : Page
    {
        private readonly MainWindow _mw;
        public Add(MainWindow mw)
        {
            InitializeComponent();
            _mw = mw;
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            _mw.UpdateFrameContent("/Views/Personal Information/Main.xaml", "");
        }

        private void ButtonCreate_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxTitle.Text != "")
            {
                try
                {
                    JSON.JSONcreate.PersonalInformation.Create(TextBoxTitle.Text, TextBoxFullName.Text, TextBoxEmail.Text, TextBoxPhone.Text,
                                                                    TextBoxAddressLine1.Text, TextBoxAddressLine2.Text, TextBoxCity.Text, TextBoxPostalCode.Text,
                                                                    TextBoxStateOrProvince.Text, TextBoxCountryOrRegion.Text);
                    _mw.UpdateFrameContent("/Views/Personal Information/Main.xaml", "");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong! " + ex.ToString(), "ERROR!");
                } 
            }
            else
            {
                MessageBox.Show("The title cannot be empty!", "ERROR!");
            }
        }
    }
}
