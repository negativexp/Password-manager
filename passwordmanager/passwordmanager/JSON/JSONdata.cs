using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passwordmanager.JSON
{
    internal class JSONdata
    {
        public string title { get; set; }
        public string timecreated { get; set; }
        public string email { get; set; }

        //personal Information
        public string fullname { get; set; }
        public string phone { get; set; }
        public string addressline1 { get; set; }
        public string addressline2 { get; set; }
        public string city { get; set; }
        public string postalcode { get; set; }
        public string stateorprovince { get; set; }
        public string countryorregion { get; set; }

        //logins
        public string username { get; set; }
        public string password { get; set; }
        public string url { get; set; }

    }
}
