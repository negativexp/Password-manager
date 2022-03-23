using System.IO;
using System.Security.Cryptography;

namespace passwordmanager.AES
{
    internal class Encryption
    {
        public static void Encrypt(string inputFile, string outputFile, byte[] passwordBytes)
        {
            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            string cryptFile = outputFile;
            FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);

            RijndaelManaged _AES = new RijndaelManaged();

            _AES.KeySize = 256;
            _AES.BlockSize = 128;


            var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
            _AES.Key = key.GetBytes(_AES.KeySize / 8);
            _AES.IV = key.GetBytes(_AES.BlockSize / 8);
            _AES.Padding = PaddingMode.Zeros;

            _AES.Mode = CipherMode.CBC;

            CryptoStream cs = new CryptoStream(fsCrypt,
                 _AES.CreateEncryptor(),
                CryptoStreamMode.Write);

            FileStream fsIn = new FileStream(inputFile, FileMode.Open);

            int data;
            while ((data = fsIn.ReadByte()) != -1)
            {
                cs.WriteByte((byte)data);
            }

            fsIn.Close();
            cs.Close();
            fsCrypt.Close();
        }
    }
}
