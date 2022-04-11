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

namespace passwordmanager.Views.Password_Generator
{
    /// <summary>
    /// Interakční logika pro PasswordGenerator.xaml
    /// </summary>
    public partial class PasswordGenerator : Page
    {
        public PasswordGenerator()
        {
            InitializeComponent();
        }

        const string UppercaseCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string LowercaseCharacters = "abcdefghijklmnopqrstuvwxyz";
        const string Symbols = "!;#$%&'()*+,-./:;<=>?@[]^_{|}~";
        const string Numbers = "0123456789";
        const string AmbiguousCharacters = "{}[]()/\'`~,;:.<>";

        private void ButtonGenerate_Click(object sender, RoutedEventArgs e)
        {
            Random rdm = new Random();
            StringBuilder sb = new StringBuilder();
            string characters = "";

            if ((bool)CheckBoxUppercaseCharacters.IsChecked)
            {
                characters += UppercaseCharacters;
            }
            if ((bool)CheckBoxLowercaseCharacters.IsChecked)
            {
                characters += LowercaseCharacters;
            }
            if ((bool)CheckBoxSymbols.IsChecked)
            {
                characters += Symbols;
            }
            if ((bool)CheckBoxNumbers.IsChecked)
            {
                characters += Numbers;
            }
            if ((bool)CheckBoxAmbiguousCharacters.IsChecked)
            {
                characters += AmbiguousCharacters;
            }

            char[] charactersArray = characters.ToCharArray();

            if(charactersArray.Length != 0)
            {
                int value = 0;

                try
                {
                    value = Convert.ToInt32(TextBoxPasswordLenght.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter a valid password lenght!");
                }


                while (0 < value--)
                {
                    sb.Append(charactersArray[rdm.Next(charactersArray.Length)]);
                }
                TextBoxPassowrd.Text = sb.ToString();
            }
            else
            {
                MessageBox.Show("Please enter a valid value");
            }
        }
    }
}
