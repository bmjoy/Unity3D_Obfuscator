using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unity3DObfuscator
{
   //All the obfuscation settings.
    public class ObfuscationSettings
    {
        private string assemblyPath = string.Empty;
        private string containingFolder = string.Empty;
        private bool antiILDasm = false;
        private bool renameNamespaces = false;
        private bool renameTypes = false;
        private bool renameMethods = false;
        private bool renameFields = false;
        private bool renameProperties = false;
        private bool stringEcnryption = false;
        private bool antiTampering = false;
        private bool randomName = true;
        private bool emptyName = false;
        public bool IsAssemblyDotNet => GetIsAssemblyDotNet(); 
        public bool AssemblyExists => GetAssemblyExists(); 
        public string AssemblyPath { get => assemblyPath; set => assemblyPath = value; }
        public string ContainingFolder { get => containingFolder; set => containingFolder = value; }
        public bool AntiILDasm { get => antiILDasm; set => antiILDasm = value; }
        public bool RenameNamespaces { get => renameNamespaces; set => renameNamespaces = value; }
        public bool RenameTypes { get => renameTypes; set => renameTypes = value; }
        public bool RenameMethods { get => renameMethods; set => renameMethods = value; }
        public bool RenameFields { get => renameFields; set => renameFields = value; }
        public bool RenameProperties { get => renameProperties; set => renameProperties = value; }
        public bool StringEcnryption { get => stringEcnryption; set => stringEcnryption = value; }
        public bool AntiTampering { get => antiTampering; set => antiTampering = value; }
        public bool RandomName { get => randomName; set => randomName = value; }
        public bool EmptyName { get => emptyName; set => emptyName = value; }

        public void Restart(Form currentForm) //Restats the application.
        {
            Process.Start(Application.ExecutablePath);
            currentForm.Close();
        }
        public void Reset(Control.ControlCollection settingsControls) //Resets all the settings.
        {
            foreach(Control c in settingsControls)
            {
                if (c is CheckBox cb)
                {
                    cb.Checked = false;
                }
            }
        }
        public bool Check() //Checks if one of the checkboxes is checked.
        {
            return (antiILDasm || renameNamespaces || renameTypes || renameMethods || renameFields || renameProperties || antiTampering || stringEcnryption);
        }
        private bool GetIsAssemblyDotNet() //Checks if the selected assembly is a .NET module. Source: https://stackoverflow.com/questions/1366503/best-way-to-check-if-a-dll-file-is-a-clr-assembly-in-c-sharp/1366517#1366517
        {
            Stream fs = new FileStream(assemblyPath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(fs);
            fs.Position = 60;
            var peHeader = reader.ReadUInt32();
            fs.Position = peHeader;
            uint[] dataDictionaryRva = new uint[16];
            uint[] dataDictionarySize = new uint[16];
            var peHeaderSignature = reader.ReadUInt32();
            var machine = reader.ReadUInt16();
            var sections = reader.ReadUInt16();
            var timestamp = reader.ReadUInt32();
            var pSymbolTable = reader.ReadUInt32();
            var noOfSymbol = reader.ReadUInt32();
            var optionalHeaderSize = reader.ReadUInt16();
            var characteristics = reader.ReadUInt16();
            var dataDictionaryStart = Convert.ToUInt16(Convert.ToUInt16(fs.Position) + 96);
            fs.Position = dataDictionaryStart;
            for (int i = 0; i < 15; i++)
            {
                dataDictionaryRva[i] = reader.ReadUInt32();
                dataDictionarySize[i] = reader.ReadUInt32();
            }
            if (dataDictionaryRva[14] == 0)
            {
                fs.Close();
                return false;
            }
            fs.Close();
            return true;
        }
        private bool GetAssemblyExists()
        {
            return (File.Exists(assemblyPath));
        }
    }
}