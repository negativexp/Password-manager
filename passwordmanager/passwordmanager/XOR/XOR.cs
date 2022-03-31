using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passwordmanager.XOR
{
    internal class XOR
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
        public static string EncryptOrDecrypt(string text)
        {
            JSONdeserializeBasicInfo();

            var result = new StringBuilder();

            for (int c = 0; c < text.Length; c++)
                result.Append((char)((uint)text[c] ^ (uint)pwdhash[c % pwdhash.Length]));

            return result.ToString();
        }
    }
}
