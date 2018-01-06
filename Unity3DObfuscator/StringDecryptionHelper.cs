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
    public class StringDecryptionHelpers
    {
        internal class Weak
        {
            internal static string a(string text)
            {
                return Encoding.ASCII.GetString(Convert.FromBase64String(text));
            }
            internal static string b(string text)
            {
                return a(a(a(a(a(text)))));
            }
        }
        internal class Normal
        {
            internal static string a(string text)
            {
                return Encoding.ASCII.GetString(Convert.FromBase64String(text));
            }
            internal static string b(string text)
            {
                return a(a(a(a(a(text)))));
            }
            internal static string c(string text)
            {
                return b(b(text));
            }
        }
        internal class Strong
        {
            internal static string a(string text)
            {
                return Encoding.ASCII.GetString(Convert.FromBase64String(text));
            }
            internal static string b(string text)
            {
                return a(a(a(a(a(text)))));
            }
            internal static string c(string text)
            {
                return b(b(text));
            }
            internal static string d(string text)
            {
                return a(b(text));
            }
        }
    }
}