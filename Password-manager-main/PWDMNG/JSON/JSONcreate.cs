using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PWDMNG.JSON
{
    internal class JSONcreate
    {
        static void NullData()
        {
            JSONdata JSONdata = new JSONdata();
            JSONdata.title = "";
            JSONdata.fullname = "";
            JSONdata.email = "";
            JSONdata.phone = "";
            JSONdata.addressline2 = "";
            JSONdata.addressline1 = "";
            JSONdata.city = "";
            JSONdata.postalcode = "";
            JSONdata.stateorprovince = "";
            JSONdata.countryorregion = "";
        }
        public class PersonalInformation
        {
            List<JSONdata> _JSONDATA = new List<JSONdata>();
            JSONdata JSONdata = new JSONdata();
            public void Create(string title, string fullname, string email, string phone,
                                string addressline1, string addressline2, string city, string postalcode,
                                string stateorprovince, string countryorregion)
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + @"\Data\Personal Information\" + title + ".json.AES";
                try
                {
                    if(!File.Exists(path))
                    {
                        _JSONDATA.Add(new JSONdata()
                        {
                            title = title,
                            fullname = XOR.XOR.EncryptOrDecrypt(fullname),
                            email = XOR.XOR.EncryptOrDecrypt(email),
                            phone = XOR.XOR.EncryptOrDecrypt(phone),
                            addressline1 = XOR.XOR.EncryptOrDecrypt(addressline1),
                            addressline2 = XOR.XOR.EncryptOrDecrypt(addressline2),
                            city = XOR.XOR.EncryptOrDecrypt(city),
                            postalcode = XOR.XOR.EncryptOrDecrypt(postalcode),
                            stateorprovince = XOR.XOR.EncryptOrDecrypt(stateorprovince),
                            countryorregion = XOR.XOR.EncryptOrDecrypt(countryorregion)
                        });
                        JSONcreate.NullData();
                    }
                    else
                    {
                        MessageBox.Show("The title you entered already exists!", "ERROR");
                    }
                }
                catch (Exception e)
                {
                    WriteLogs.Write(e);
                    MessageBox.Show("Please check logs", "Something went wrong!");
                }
                finally
                {
                    if(!File.Exists(path))
                    {
                        AES.Encryption.EncryptV2(JsonConvert.SerializeObject(_JSONDATA),
                            AppDomain.CurrentDomain.BaseDirectory + @"\Data\Personal Information\" + title + ".json.AES", Encoding.ASCII.GetBytes(Properties.Settings.Default.pwdhash));
                    }
                    else
                    {

                    }    
                }
            }
        }
    }
}
