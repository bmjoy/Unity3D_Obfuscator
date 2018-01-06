using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity3DObfuscator
{
    //The help tabs.
    public struct ObfuscatorHelp
    {
        public static string Renaming => GetRenaming();
        public static string StringEncryption => GetStringEcryption();
        public static string AntiTampering => GetAntiTampering();

        private static string GetRenaming()
        {
            return "Renaming obfuscation protects your assembly by renaming classes, methods, fields and properties with random letters or an empty text. You can also exclude the types that you don't wanna be renamed, that also includes its methods, fields and other.. Classes that have  'MonoBehaviour' as Base Type, will not be renamed. This obfuscation will make it harder for a person to understand what some classes and other things do.";
        }
        private static string GetStringEcryption()
        {
            return "String encryption encrypts all the strings in the assembly. Which means it will be harder for a person to read a string / text by encoding it. This function is very usefull if you want to hide a license key or something similar.";
        }
        private static string GetAntiTampering()
        {
            return "Anti tampering is a protection that prevents your assembly to be modified. If someone tries to modify your assembly, None of the code on the assembly will work when the hacker tries to open the game with the modified version of the assembly.";
        }
    }
}
