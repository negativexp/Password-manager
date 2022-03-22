using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace PWDMNG.AES
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
        public static void EncryptV2(string json, string outputFile, byte[] passwordBytes)
        {
            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            string cryptFile = outputFile;
            // Convert our plaintext into a byte array.
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(json);

            RijndaelManaged _AES = new RijndaelManaged();
            _AES.KeySize = 256;
            _AES.BlockSize = 128;

            var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
            _AES.Key = key.GetBytes(_AES.KeySize / 8);
            _AES.IV = key.GetBytes(_AES.BlockSize / 8);
            _AES.Mode = CipherMode.CBC;

            ICryptoTransform encryptor = _AES.CreateEncryptor();

            // Define memory stream which will be used to hold encrypted data.
            MemoryStream memoryStream = new MemoryStream();

            // Define cryptographic stream (always use Write mode for encryption).
            CryptoStream cryptoStream = new CryptoStream
            (
                memoryStream,
                encryptor,
                CryptoStreamMode.Write
            );

            // Start encrypting.
            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);

            // Finish encrypting.
            cryptoStream.FlushFinalBlock();

            // Convert our encrypted data from a memory stream into a byte array.
            byte[] cipherTextBytes = memoryStream.ToArray();

            // Close both streams.
            memoryStream.Close();
            cryptoStream.Close();

            // Convert encrypted data into a base64-encoded string.
            FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);
            Stream crypt = new MemoryStream(cipherTextBytes)

        }
    }
}
