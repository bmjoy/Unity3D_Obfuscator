using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity3DObfuscator
{
    public class AntiTamperingClass
    {
        //Anti tampering class.
        public void ExecuteAntiTampering()
        {
            if(!MainClass.Settings.AntiTampering)
            {
                return;
            }
            string typeName = "╬.☻♥♦♣♠•◘○";
            string value = GlobalStrings.RandomString;
            Watermarking.AddCustomAttributeToAssembly(string.Empty, typeName, value);
            Watermarking.RemoveAttributeType(typeName);
            //The way the anti tampering works is by adding a custom attribute and removing its type directly from the assembly instead of deleting the attribute from the assembly first.
            //WARNING! Anti tampering may not work in some assemblies.
            //I figured this method by accident, lol! 
        }
    }
}
