using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

namespace passwordmanager.Views.Main_Windows.Change_Password_Window
{
    /// <summary>
    /// Interakční logika pro ChangePasswordWindow.xaml
    /// </summary>
    public partial class ChangePasswordWindow : Page
    {
        public ChangePasswordWindow()
        {
            InitializeComponent();
            JSONdeserialize();
        }
        private string oldPassHash;
        private void JSONdeserialize()
        {
            dynamic JSONitems = JsonConvert.DeserializeObject(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Basic.json"));
            foreach (var item in JSONitems)
            {
                oldPassHash = item.pwdhash;
            }
            TextBoxOldPass.Text = oldPassHash;
            JSONitems = null;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Hash.SHA256.Create(TextBoxOldPass.Text).Equals(oldPassHash))
            {
                if (TextBoxNewPass.Text.Equals(TextBoxNewPassRepeat.Text) && TextBoxNewPass.Text != "")
                {
                    //overwrite "Basic.json" file
                    string jsonString = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Basic.json");
                    JObject jObject = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonString) as JObject;
                    JToken jToken = jObject.SelectToken("basicusername");
                    jToken.Replace(Hash.SHA256.Create(TextBoxNewPass.Text));
                    string updateJsonString = jObject.ToString();
                    File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Basic.json", updateJsonString);
                }
                else
                    MessageBox.Show("Please enter the new password twice!");
            }
            else
                MessageBox.Show("Please enter the right password you have in-use right now!");
        }
    }
}
