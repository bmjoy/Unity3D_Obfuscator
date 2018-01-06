using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity3DObfuscator
{
    public struct StringEncoding
    {
        private static string a(string text) //encoding
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(text));
        }
        private static string b(string text) //weak
        {
            return a(a(a(a(a(text)))));
        }
        private static string c(string text) //normal
        {
            return b(b(text));
        }
        private static string d(string text) //strong
        {
            return a(b(text));
        }
        public static string EncryptString(string text)
        {
            switch (MainClass.Settings.StringEncryptionLevel)
            {
                case 1:
                    return c(text);

                case 2:
                    return d(text);
            }
            return b(text);
        }
    }
}
