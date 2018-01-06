using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dnlib.DotNet;
using System.Security.Cryptography;
using System.IO;
using dnlib.DotNet.Emit;

namespace Unity3DObfuscator
{
    //String Encryption class.
    public class StringEncryptionClass
    {
        public void Encrypt()
        {
            if (!MainClass.Settings.StringEcnryption)
            {
                return;
            }
            Protect(MainClass.MainModule);
        }
        private static MethodDef _injectedMethodDef;

        private void Protect(ModuleDefMD module) //module equals the loaded file
        {
            InjectClass(module);
            ProtectStrings(module);
        }
        private void ProtectStrings(ModuleDefMD module) //Encodes all the strings.
        {
            foreach (TypeDef type in module.GetTypes())
            {
                foreach (MethodDef method in type.Methods)
                {
                    if (!method.HasBody) continue;
                    var instr = method.Body.Instructions;
                    for (int i = 0; i < instr.Count; i++)
                    {
                        if (instr[i].OpCode == OpCodes.Ldstr)
                        {
                            var originalStr = instr[i].Operand as string;
                            if (Exclusion.ExcludedStrings.Contains(originalStr))
                            {
                                continue;
                            }
                            var encodedStr = StringEncoding.EncryptString(originalStr);
                            instr[i].Operand = encodedStr;
                            instr.Insert(i + 1, Instruction.Create(OpCodes.Call, _injectedMethodDef));
                            method.Body.SimplifyBranches();
                            method.Body.OptimizeBranches();
                        }
                    }
                }
            }
        }
        private static void InjectClass(ModuleDef module) //Injects the StringDecryptionHelper functions in to the assembly.
        {
            Type type = MainClass.Settings.GetStringDencryptionType();
            ModuleDefMD typeModule = ModuleDefMD.Load(type.Module);
            TypeDef typeDef = typeModule.ResolveTypeDef(MDToken.ToRID(type.MetadataToken));
            IEnumerable<IDnlibDef> members = InjectHelper.Inject(typeDef, module.GlobalType, module);
            _injectedMethodDef = (MethodDef)members.Single(method => method.Name == MainClass.Settings.GetStringDencryptionMethod());
            foreach (MethodDef md in module.GlobalType.Methods)
            {
                if (md.Name == ".ctor")
                {
                    module.GlobalType.Remove(md);
                    break;
                }
            }
        }
    }
}
