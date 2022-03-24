﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;

namespace passwordmanager.JSON
{
    internal class JSONcreate
    {
        public class PersonalInformation
        {
            public static void Create(string title, string fullname, string email, string phone,
                                string addressline1, string addressline2, string city, string postalcode,
                                string stateorprovince, string countryorregion)
            {
                List<JSONdata> _JSONDATA = new List<JSONdata>();
                string path = AppDomain.CurrentDomain.BaseDirectory + @"\Data\Personal Information\" + title + ".json.AES";
                try
                {
                    if (!File.Exists(path))
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
                            countryorregion = XOR.XOR.EncryptOrDecrypt(countryorregion),
                            timeCreated = DateTime.Now
                        });
                    }
                    else
                    {
                        MessageBox.Show("The title you entered already exists!", "ERROR");
                    }
                }
                catch (Exception e)
                {
                    //WriteLogs.Write(e);
                    MessageBox.Show("Please check logs" + e.ToString(), "Something went wrong!");
                }
                finally
                {
                    if (!File.Exists(path))
                    {
                        File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Cache\" + title + ".json",
                            JsonConvert.SerializeObject(_JSONDATA));

                        AES.Encryption.Encrypt(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Cache\" + title + ".json",
                            AppDomain.CurrentDomain.BaseDirectory + @"\Data\Personal Information\" + title + ".json.AES",
                            Encoding.ASCII.GetBytes(Properties.Settings.Default.pwdhash));

                        File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Cache\" + title + ".json");
                        MessageBox.Show("Data has been created!", "Success!");
                    }
                    else
                    {

                    }
                }
            }
        }
    }
}
