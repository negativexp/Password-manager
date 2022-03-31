using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passwordmanager.JSON
{
    internal class JSONdata
    {
        public class BasicInfo
        {
            public string pwdhash { get; set; }
            public string basicusername { get; set; }
            public string basicpreferdname { get; set; }
            public string birthday { get; set; }
        }

        //personal Information
        public class PersonalInformation
        {
            public string fullname { get; set; }
            public string phone { get; set; }
            public string addressline1 { get; set; }
            public string addressline2 { get; set; }
            public string city { get; set; }
            public string postalcode { get; set; }
            public string stateorprovince { get; set; }
            public string countryorregion { get; set; }
            public string title { get; set; }
            public string timecreated { get; set; }
            public string email { get; set; }
        }

        //logins
        public class Logins
        {
            public string username { get; set; }
            public string password { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string timecreated { get; set; }
            public string email { get; set; }
        }

        //credit cards
        public class CreditCards
        {
            public string owner { get; set; }
            public string cvv { get; set; }
            public string cardnumber { get; set; }
            public string expiredateMonth { get; set; }
            public string expiredateYear { get; set; }
            public string title { get; set; }
            public string timecreated { get; set; }
        }

        //secure notes
        public class SecureNotes
        {
            public string content { get; set; }
            public string title { get; set; }
            public string timecreated { get; set; }
        }
    }
}
