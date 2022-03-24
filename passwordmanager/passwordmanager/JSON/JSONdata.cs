using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passwordmanager.JSON
{
    internal class JSONdata
    {
        public static void JSONnull(JSONdata j)
        {
            j.title = "";
            j.fullname = "";
            j.email = "";
            j.phone = "";
            j.addressline1 = "";
            j.addressline2 = "";
            j.city = "";
            j.postalcode = "";
            j.stateorprovince = "";
            j.countryorregion = "";
        }
        public string title { get; set; }
        public DateTime timeCreated { get; set; }

        //personal Information
        public string fullname { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string addressline1 { get; set; }
        public string addressline2 { get; set; }
        public string city { get; set; }
        public string postalcode { get; set; }
        public string stateorprovince { get; set; }
        public string countryorregion { get; set; }
    }
}
