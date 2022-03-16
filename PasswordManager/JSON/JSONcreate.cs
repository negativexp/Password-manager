using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Security;
using System.IO;
using System.Windows.Forms;

namespace PasswordManager
{
    public class JSONcreate
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
            JSONdata.stateorprovince ="";
            JSONdata.countryorregion ="";
        }

        public class PersonalInformation
        {
            List<JSONdata> _JSONDATA = new List<JSONdata>();
            JSONdata JSONdata = new JSONdata();
            public void Create(string title, string fullname, string email, string phone,
                string addressline1, string addressline2, string city, string postalcode,
                string stateorprovince, string countryorregion)
            {
                try
                {
                    _JSONDATA.Add(new JSONdata()
                    {
                        title = title,
                        fullname = fullname,
                        email = email,
                        phone = phone,
                        addressline1 = addressline1,
                        addressline2 = addressline2,
                        city = city,
                        postalcode = postalcode,
                        stateorprovince = stateorprovince,
                        countryorregion = countryorregion
                    });
                    JSONcreate.NullData();
                }
                catch (Exception e)
                {
                    WriteLogs.Write(e);
                    MessageBox.Show("Please check logs", "Something went wrong!");
                }
                finally
                {
                    try
                    {
                        File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\data\personal\" + title + ".json", JsonConvert.SerializeObject(_JSONDATA));
                    }
                    catch (Exception e)
                    {
                        WriteLogs.Write(e);
                        MessageBox.Show("Please check logs", "Something went wrong!");
                    }
                    finally
                    {
                        string pass = "1234";
                        AES.Encryption.Encrypt(AppDomain.CurrentDomain.BaseDirectory + @"\data\personal\" + title + ".json",
                            AppDomain.CurrentDomain.BaseDirectory + @"\data\personal\" + title + ".json.AES", Encoding.ASCII.GetBytes(pass));

                        AES.Decryption.Decrypt(AppDomain.CurrentDomain.BaseDirectory + @"\data\personal\" + title + ".json.AES",
                            AppDomain.CurrentDomain.BaseDirectory + @"\data\personal\" + title +"_decrypted" +".json", Encoding.ASCII.GetBytes(pass));
                    }
                }
            }
        }
    }
}
