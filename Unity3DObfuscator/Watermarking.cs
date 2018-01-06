using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace Unity3DObfuscator
{
    //Watermarking class.
    //Credit: The original custom attribute functions are from the ConfuserEx project.
    public class Watermarking
    {
        public static void AddCustomAttributeToAssembly(string Namespace, string AttributeName, string Value) //Adds a custom attribute to the assembly.
        {
            TypeRef attrRef = MainClass.MainModule.CorLibTypes.GetTypeRef("System", "Attribute");
            TypeDefUser attrType = new TypeDefUser(Namespace, AttributeName, attrRef);
            MainClass.MainModule.Types.Add(attrType);
            MethodDefUser ctor = new MethodDefUser(".ctor", MethodSig.CreateInstance(MainClass.MainModule.CorLibTypes.Void, MainClass.MainModule.CorLibTypes.String), MethodImplAttributes.IL, MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Public | MethodAttributes.HideBySig | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName)
            {
                Body = new CilBody()
                {
                    MaxStack = 1
                }
            };
            ctor.Body.Instructions.Add(OpCodes.Ldarg_0.ToInstruction());
            ctor.Body.Instructions.Add(OpCodes.Call.ToInstruction(new MemberRefUser(MainClass.MainModule, ".ctor", MethodSig.CreateInstance(MainClass.MainModule.CorLibTypes.Void), attrRef)));
            ctor.Body.Instructions.Add(OpCodes.Ret.ToInstruction());
            attrType.Methods.Add(ctor);
            CustomAttribute attr = new CustomAttribute(ctor);
            attr.ConstructorArguments.Add(new CAArgument(MainClass.MainModule.CorLibTypes.String, Value));
            MainClass.MainModule.Assembly.CustomAttributes.Add(attr);
        }
        private static void AddCustomAttributeToModule(string Namespace, string AttributeName, string Value) //Adds a custom attribute to the module.
        {
            TypeRef attrRef = MainClass.MainModule.CorLibTypes.GetTypeRef("System", "Attribute");
            TypeDefUser attrType = new TypeDefUser(Namespace, AttributeName, attrRef);
            MainClass.MainModule.Types.Add(attrType);
            MethodDefUser ctor = new MethodDefUser(".ctor", MethodSig.CreateInstance(MainClass.MainModule.CorLibTypes.Void, MainClass.MainModule.CorLibTypes.String), MethodImplAttributes.IL, MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Public | MethodAttributes.HideBySig | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName)
            {
                Body = new CilBody()
                {
                    MaxStack = 1
                }
            };
            ctor.Body.Instructions.Add(OpCodes.Ldarg_0.ToInstruction());
            ctor.Body.Instructions.Add(OpCodes.Call.ToInstruction(new MemberRefUser(MainClass.MainModule, ".ctor", MethodSig.CreateInstance(MainClass.MainModule.CorLibTypes.Void), attrRef)));
            ctor.Body.Instructions.Add(OpCodes.Ret.ToInstruction());
            attrType.Methods.Add(ctor);
            CustomAttribute attr = new CustomAttribute(ctor);
            attr.ConstructorArguments.Add(new CAArgument(MainClass.MainModule.CorLibTypes.String, Value));
            MainClass.MainModule.CustomAttributes.Add(attr);
        }
        public static void Watermark(string Namespace, string AttributeName, string Value) //Watermaking function.
        {
            AddCustomAttributeToAssembly(Namespace, AttributeName, Value);
            AddCustomAttributeToModule(Namespace, AttributeName, Value);
        }
        public static void RemoveAttributeType(string typeFullName) //Removes a custom attribute. (A part of the Anti Tampering class)
        {
            try
            {
                TypeDef bType = null;
                MethodDef bMethod = null;
                foreach (TypeDef type in MainClass.MainModule.Types)
                {
                    if (type.FullName == typeFullName)
                    {
                        bType = type;
                        foreach(MethodDef method in type.Methods)
                        {
                            bMethod = method;
                        }
                    }
                }
                if(bMethod != null)
                {
                    bType.Remove(bMethod);
                }
                if(bType != null)
                {
                    MainClass.MainModule.Types.Remove(bType);
                }
            }
            catch
            {

            }
        }
    }
}
