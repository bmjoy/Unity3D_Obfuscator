using dnlib.DotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity3DObfuscator
{
    public class AntiILDasmClass
    {
        // AntiILDasm class.
        // Credit: The original function is from the ConfuserEx project.
        public void Execute()
        {
            if(!MainClass.Settings.AntiILDasm)
            {
                return;
            }
            TypeRef tRef = MainClass.MainModule.CorLibTypes.GetTypeRef("System.Runtime.CompilerServices", "SuppressIldasmAttribute");
            MemberRefUser ctor = new MemberRefUser(MainClass.MainModule, ".ctor", MethodSig.CreateInstance(MainClass.MainModule.CorLibTypes.Void), tRef);
            CustomAttribute attribute = new CustomAttribute(ctor);
            if(MainClass.MainModule.CustomAttributes.Contains(attribute))
            {
                return;
            }
            MainClass.MainModule.CustomAttributes.Add(attribute);
        }
    }
}
