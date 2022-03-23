using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passwordmanager.XOR
{
    internal class XOR
    {
        public static string EncryptOrDecrypt(string text)
        {
            var result = new StringBuilder();

            for (int c = 0; c < text.Length; c++)
                result.Append((char)((uint)text[c] ^ (uint)Properties.Settings.Default.pwdhash[c % Properties.Settings.Default.pwdhash.Length]));

            return result.ToString();
        }
    }
}
