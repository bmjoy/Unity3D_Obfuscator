using dnlib.DotNet;
using System.Threading;

namespace Unity3DObfuscator
{
    public class MainClass
    {
        // I just made this class for various instances.
        private static readonly ObfuscationSettings settings = new ObfuscationSettings();
        private static readonly RenamingClass renaming = new RenamingClass();
        private static readonly AntiILDasmClass antiILDasm = new AntiILDasmClass();
        private static readonly StringEncryptionClass stringEcnryption = new StringEncryptionClass();
        private static readonly AntiTamperingClass antiTampering = new AntiTamperingClass();
        private static ModuleDefMD mainModule = null;
        private static Thread obfuscationThread = null;

        public static ObfuscationSettings Settings => settings;
        public static AntiILDasmClass AntiILDasm => antiILDasm;
        public static RenamingClass Renaming => renaming;
        public static StringEncryptionClass StringEcnryption => stringEcnryption;
        public static AntiTamperingClass AntiTampering => antiTampering;
        public static ModuleDefMD MainModule { get => mainModule; set => mainModule = value; }
        public static Thread ObfuscationThread { get => obfuscationThread; set => obfuscationThread = value; }
    }
}
