namespace PWDMNG.JSON
{
    internal class JSONdata
    {
        public static void nullData()
        {
            JSONdata js = new JSONdata();
            js.title = "";
            js.fullname = "";
            js.email = "";
            js.phone = "";
            js.addressline1 = "";
            js.addressline2 = "";
            js.city = "";
            js.postalcode = "";
            js.stateorprovince = "";
            js.countryorregion = "";
        }
        public string title { get; set; }
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
