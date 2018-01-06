using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Unity3DObfuscator
{
    //String Decryption Helper class.
    public class StringDecryptionHelper
    {
        internal static readonly string P0 = "sec08m52lk323j209di2j99unity"; //Password hash variable
        internal static readonly string S0 = "sec924801294838"; //Salt key variable
        internal static readonly string V0 = "@1C2c3D4e8F6g7F8"; //VIKey variable
        //Encrypts the strings.
        internal static string D0(string encryptedText) //The string decryption function
        {
            byte[] cipherTextBytes = Convert.FromBase64String(encryptedText);
            byte[] keyBytes = new Rfc2898DeriveBytes(P0, Encoding.ASCII.GetBytes(S0)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.None };
            var decryptor = symmetricKey.CreateDecryptor(keyBytes, Encoding.ASCII.GetBytes(V0));
            var memoryStream = new MemoryStream(cipherTextBytes);
            var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            byte[] plainTextBytes = new byte[cipherTextBytes.Length];
            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
            memoryStream.Close();
            cryptoStream.Close();
            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount).TrimEnd("\0".ToCharArray());
        }
    }
}