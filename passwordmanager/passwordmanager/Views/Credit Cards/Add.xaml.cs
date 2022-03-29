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

namespace passwordmanager.Views.Credit_Cards
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
            _mw.UpdateFrameContent("/Views/Credit Cards/Main.xaml", "");
        }

        private void ButtonCreate_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxTitle.Text != "")
            {
                try
                {
                    JSON.JSONcreate.CreditCards.Create(TextBoxTitle.Text, TextBoxOwner.Text, TextBoxCVV.Text,
                                    TextBoxCardNumber.Text, TextBoxExpireMonth.Text, TextBoxExpireYear.Text);
                    _mw.UpdateFrameContent("/Views/Credit Cards/Main.xaml", "");
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
