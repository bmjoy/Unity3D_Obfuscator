using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity3DObfuscator
{
    //The strings for the renaming function.
    public struct GlobalStrings
    {
        private static Random random = new Random();

        public static string RenamingString => GetRenamingString();
        public static string RandomString => GetRandomString();
        private static string GetRandomString() //Generates a radmom string.
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var stringChars = new char[19];
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            var finalString = new String(stringChars);
            return string.Concat("=", finalString);
        }
        private static string GetEmpty() //Returns an empty string.
        {
            return string.Empty;
        }
        private static string GetRenamingString() //Gets the renaming type of the 'Renaming Obfuscation'. Radmm name or empty.
        {
            if (MainClass.Settings.RandomName && !MainClass.Settings.EmptyName)
            {
                return GetRandomString();
            }
            if (MainClass.Settings.EmptyName && !MainClass.Settings.RandomName)
            {
                return GetEmpty();
            }
            return "xxx";
        }
    }
}
