using System;
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
        public static string pwdhash;
        public static void JSONdeserializeBasicInfo()
        {
            dynamic JSONitems = JsonConvert.DeserializeObject(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Basic.json"));
            foreach (var item in JSONitems)
            {
                pwdhash = item.pwdhash;
            }
        }
        public class PersonalInformation
        {
            public static void Create(string title, string fullname, string email, string phone,
                                string addressline1, string addressline2, string city, string postalcode,
                                string stateorprovince, string countryorregion)
            {
                JSONdeserializeBasicInfo();
                List<JSONdata.PersonalInformation> _JSONDATA = new List<JSONdata.PersonalInformation>();
                string path = AppDomain.CurrentDomain.BaseDirectory + @"\Data\Personal Information\" + title + ".AES";
                try
                {
                    if (!File.Exists(path))
                    {
                        _JSONDATA.Add(new JSONdata.PersonalInformation()
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
                            timecreated = DateTime.Now.ToString("dd/MM/yyyy h:mm tt")
                        });
                        File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Cache\" + title + ".json",
                                            JsonConvert.SerializeObject(_JSONDATA));
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
                    AES.Encryption.Encrypt(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Cache\" + title + ".json",
                            AppDomain.CurrentDomain.BaseDirectory + @"\Data\Personal Information\" + title + ".AES",
                            Encoding.ASCII.GetBytes(pwdhash));

                    File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Cache\" + title + ".json");
                        MessageBox.Show("Data has been created!", "Personal Information");
                }
            }
        }
        public class Logins
        {
            public static void Create(string title, string username, string email, string passowrd, string url)
            {
                JSONdeserializeBasicInfo();
                List<JSONdata.Logins> _JSONDATA = new List<JSONdata.Logins>();
                string path = AppDomain.CurrentDomain.BaseDirectory + @"\Data\Logins\" + title + ".AES";

                try
                {
                    if (!File.Exists(path))
                    {
                        _JSONDATA.Add(new JSONdata.Logins()
                        {
                            title = title,
                            username = XOR.XOR.EncryptOrDecrypt(username),
                            email = XOR.XOR.EncryptOrDecrypt(email),
                            password = XOR.XOR.EncryptOrDecrypt(passowrd),
                            url = XOR.XOR.EncryptOrDecrypt(url),
                            timecreated = DateTime.Now.ToString("dd/MM/yyyy h:mm tt")
                        });
                        File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Cache\" + title + ".json",
                                            JsonConvert.SerializeObject(_JSONDATA));
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
                    AES.Encryption.Encrypt(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Cache\" + title + ".json",
                            AppDomain.CurrentDomain.BaseDirectory + @"\Data\Logins\" + title + ".AES",
                            Encoding.ASCII.GetBytes(pwdhash));

                    File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Cache\" + title + ".json");
                        MessageBox.Show("Data has been created!", "Logins");
                }
            }
        }
        public class CreditCards
        {
            public static void Create(string title, string owner, string cvv, string cardnumber, string expiredateMonth, string expiredateYear)
            {
                JSONdeserializeBasicInfo();
                List<JSONdata.CreditCards> _JSONDATA = new List<JSONdata.CreditCards>();
                string path = AppDomain.CurrentDomain.BaseDirectory + @"\Data\Credit Cards\" + title + ".AES";

                try
                {
                    if (!File.Exists(path))
                    {
                        _JSONDATA.Add(new JSONdata.CreditCards()
                        {
                            title = title,
                            owner = XOR.XOR.EncryptOrDecrypt(owner),
                            cvv = XOR.XOR.EncryptOrDecrypt(cvv),
                            cardnumber = XOR.XOR.EncryptOrDecrypt(cardnumber),
                            expiredateMonth = XOR.XOR.EncryptOrDecrypt(expiredateMonth),
                            expiredateYear = XOR.XOR.EncryptOrDecrypt(expiredateYear),
                            timecreated = DateTime.Now.ToString("dd/MM/yyyy h:mm tt")
                        });
                        File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Cache\" + title + ".json",
                                            JsonConvert.SerializeObject(_JSONDATA));
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
                    AES.Encryption.Encrypt(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Cache\" + title + ".json",
                            AppDomain.CurrentDomain.BaseDirectory + @"\Data\Credit Cards\" + title + ".AES",
                            Encoding.ASCII.GetBytes(pwdhash));

                    File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Cache\" + title + ".json");
                    MessageBox.Show("Data has been created!", "Credit Cards");
                }
            }
        }
        public class SecureNotes
        {
            public static void Create(string title, string content)
            {
                JSONdeserializeBasicInfo();
                List<JSONdata.SecureNotes> _JSONDATA = new List<JSONdata.SecureNotes>();
                string path = AppDomain.CurrentDomain.BaseDirectory + @"\Data\Secure Notes\" + title + ".AES";

                try
                {
                    if (!File.Exists(path))
                    {
                        _JSONDATA.Add(new JSONdata.SecureNotes()
                        {
                            title = title,
                            content = XOR.XOR.EncryptOrDecrypt(content),
                            timecreated = DateTime.Now.ToString("dd/MM/yyyy h:mm tt")
                        });
                        File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Cache\" + title + ".json",
                                            JsonConvert.SerializeObject(_JSONDATA));
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
                    AES.Encryption.Encrypt(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Cache\" + title + ".json",
                            AppDomain.CurrentDomain.BaseDirectory + @"\Data\Secure Notes\" + title + ".AES",
                            Encoding.ASCII.GetBytes(pwdhash));

                    File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Cache\" + title + ".json");
                    MessageBox.Show("Data has been created!", "Secure Notes");
                }
            }
        }
        public class BasicInfo
        {
            public static void Create(string pwd, string username, string preferdusername, string birthday)
            {
                List<JSONdata.BasicInfo> _JSONDATA = new List<JSONdata.BasicInfo>();
                string path = AppDomain.CurrentDomain.BaseDirectory + @"\Data\Basic.json";

                if (!File.Exists(path))
                {
                    _JSONDATA.Add(new JSONdata.BasicInfo()
                    {
                        pwdhash = pwd,
                        basicusername = username,
                        basicpreferdname = preferdusername,
                        birthday = birthday
                    });
                    File.WriteAllText(path, JsonConvert.SerializeObject(_JSONDATA));
                }
            }
        }
    }
}
