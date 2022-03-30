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

namespace passwordmanager.Views.Main_Windows
{
    /// <summary>
    /// Interakční logika pro Setup.xaml
    /// </summary>
    public partial class Setup : Window
    {
        public Setup()
        {
            InitializeComponent();
        }
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxPassword.Text.Equals(TextBoxPasswordSecond.Text))
            {
                try
                {
                    Properties.Settings.Default.username = TextBoxUserName.Text;
                    Properties.Settings.Default.preferedName = TextBoxPreferedName.Text;
                    Properties.Settings.Default.birthday = DatePickerBirthDay.SelectedDate.Value.Date;
                }
                catch
                {

                }
                finally
                {
                    Properties.Settings.Default.pwdhash = Hash.SHA256.Create(TextBoxPassword.Text);
                    Properties.Settings.Default.Save();
                    MainWindow mw = new MainWindow();
                    this.Hide();
                    mw.Show();
                }
            }
            else
                MessageBox.Show("Please enter the same password twice!");

        }

        private void DatePicker_Loaded(object sender, RoutedEventArgs e)
        {
            DatePicker datePicker = sender as DatePicker;
            if (datePicker != null)
            {
                System.Windows.Controls.Primitives.DatePickerTextBox datePickerTextBox = FindVisualChild<System.Windows.Controls.Primitives.DatePickerTextBox>(datePicker);
                if (datePickerTextBox != null)
                {

                    ContentControl watermark = datePickerTextBox.Template.FindName("PART_Watermark", datePickerTextBox) as ContentControl;
                    if (watermark != null)
                    {
                        watermark.Content = " When is your birthday?";
                    }
                }
            }
        }
        private T FindVisualChild<T>(DependencyObject depencencyObject) where T : DependencyObject
        {
            if (depencencyObject != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depencencyObject); ++i)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(depencencyObject, i);
                    T result = (child as T) ?? FindVisualChild<T>(child);
                    if (result != null)
                        return result;
                }
            }
            return null;
        }
    }
}
