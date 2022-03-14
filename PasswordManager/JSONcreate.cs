using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Security;
using System.IO;

namespace PasswordManager
{
    public class JSONcreate
    {
        public class PersonalInformation
        {
            List<JSONdata> _JSONDATA = new List<JSONdata>();
            JSONdata JSONdata = new JSONdata();
            string JSONfinal;
            public void create(string title, string fullname, string email, string phone,
                string addressline1, string addressline2, string city, string postalcode,
                string stateorprovince, string countryorregion)
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
                JSONfinal = JsonConvert.SerializeObject(_JSONDATA);
                File.WriteAllText(title+".json", JSONfinal);
            }
        }
    }
}
