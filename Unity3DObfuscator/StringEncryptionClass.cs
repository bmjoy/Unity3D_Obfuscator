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
                            if (Exclusion.ExcludedStrings.Contains(originalStr) || Exclusion.StringDecryptionHelperStrings.Contains(originalStr))
                            {
                                continue;
                            }
                            var encodedStr = EncryptString(originalStr);
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
            ModuleDefMD typeModule = ModuleDefMD.Load(typeof(StringDecryptionHelper).Module);
            TypeDef typeDef = typeModule.ResolveTypeDef(MDToken.ToRID(typeof(StringDecryptionHelper).MetadataToken));
            IEnumerable<IDnlibDef> members = InjectHelper.Inject(typeDef, module.GlobalType, module);
            _injectedMethodDef = (MethodDef)members.Single(method => method.Name == "D0");

            foreach (MethodDef md in module.GlobalType.Methods)
            {
                if (md.Name == ".ctor")
                {
                    module.GlobalType.Remove(md);
                    break;
                }
            }
        }

        private string EncryptString(string plainText) //The function that encodes the string
        {
            string PasswordHash = "sec08m52lk323j209di2j99unity";
            string SaltKey = "sec924801294838";
            string VIKey = "@1C2c3D4e8F6g7F8";

            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.Zeros };
            var encryptor = symmetricKey.CreateEncryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));

            byte[] cipherTextBytes;

            using (var memoryStream = new MemoryStream())
            {
                using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                {
                    cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                    cryptoStream.FlushFinalBlock();
                    cipherTextBytes = memoryStream.ToArray();
                    cryptoStream.Close();
                }
                memoryStream.Close();
            }
            return Convert.ToBase64String(cipherTextBytes);
        }
    }
}
