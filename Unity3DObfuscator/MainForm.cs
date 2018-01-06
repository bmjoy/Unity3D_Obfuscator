using dnlib.DotNet;
using dnlib.DotNet.MD;
using dnlib.DotNet.Writer;
using System;
using System.IO;
using System.Media;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using FormSkin;
using System.Collections.Generic;

namespace Unity3DObfuscator
{
    public partial class MainForm : Form
    {
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();
        public MainForm()
        {
            InitializeComponent();
        }
        private void Protect() //The 'protect' function.
        {
            Invoke((MethodInvoker)(() => StatusLbl.Text = "Obfuscating..."));
            Invoke((MethodInvoker)(() => StatusLbl.ForeColor = Color.Yellow));
            Invoke((MethodInvoker)(() => SetControls(false)));
            try
            {
                MainClass.MainModule = ModuleDefMD.Load(File.ReadAllBytes(MainClass.Settings.AssemblyPath));
                MainClass.AntiILDasm.Execute();
                MainClass.Renaming.RenameNamespaces();
                MainClass.Renaming.RenameTypes();
                MainClass.Renaming.RenameMethods();
                MainClass.Renaming.RenameFields();
                MainClass.Renaming.RenameProperties();
                MainClass.StringEcnryption.Encrypt();
                //This part is very important. If the anti tampering is enabled then the type of the custom attribute will be with a radnom namespace and type name.
                //Making it harder for a deobfuscator to detect it. Or else it will have its normal namespace and type name.
                if (!MainClass.Settings.AntiTampering)
                {
                    Watermarking.Watermark("UnityObfuscator.Attributes", "ObfuscatedByAttribute", "Unity3D Obfuscator by AkyrosXD");
                }
                else
                {
                    Watermarking.Watermark(string.Concat(GlobalStrings.RandomString, ".", GlobalStrings.RandomString), string.Concat(GlobalStrings.RandomString, "Attribute"), "Obfuscated by [Unity3D Obfuscator by AkyrosXD]");
                }
                MainClass.AntiTampering.ExecuteAntiTampering();
                SaveProtectedAssembly();
                Invoke((MethodInvoker)(() => StatusLbl.Text = "Obfuscation Completed!"));
                Invoke((MethodInvoker)(() => StatusLbl.ForeColor = Color.LimeGreen));
                Invoke((MethodInvoker)(() => SetControls(true)));
                MainClass.ObfuscationThread = null;
            }
            catch (Exception ex)
            {
                if(ex.Message.Equals("Thread was being aborted."))
                {
                    Invoke((MethodInvoker)(() => CancelBtn.Visible = false));
                    MainClass.ObfuscationThread = null;
                    Invoke((MethodInvoker)(() => SetControls(true)));
                    return;
                }
                Invoke((MethodInvoker)(() => StatusLbl.Text = "Obfuscation Failed!"));
                Invoke((MethodInvoker)(() => StatusLbl.ForeColor = Color.Red));
                Invoke((MethodInvoker)(() => SetControls(true)));
                NativeWindow nativeWindow = new NativeWindow();
                nativeWindow.AssignHandle(GetForegroundWindow());
                MessageBox.Show(nativeWindow, "An error occurred!\nException:\n" + ex.Message, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MainClass.ObfuscationThread = null;

            }
        }
        private void SaveProtectedAssembly() //Saves the protected assembly to disk.
        {
            string file = Path.Combine(Path.GetDirectoryName(MainClass.Settings.AssemblyPath), Path.GetFileNameWithoutExtension(MainClass.Settings.AssemblyPath) + "_protected" + ".dll");
            if (File.Exists(file))
            {
                File.Delete(file);
            }
            ModuleWriter w = new ModuleWriter(MainClass.MainModule, new ModuleWriterOptions(MainClass.MainModule, DummyModuleWriterListener.Instance));
            w.Options.ModuleKind = ModuleKind.Dll;
            w.Options.Logger = DummyLogger.NoThrowInstance;
            MainClass.MainModule.Write(file, w.Options);
        }
        private void SetControls(bool enabled) //Set the controls to enabled / disabled or visible while the obfuscation is in progress or not.
        {
            foreach (Control c in MainTheme.Controls)
            {
                if (c != bottomTxt && c != sLabel && c != StatusLbl && c != CancelBtn)
                {
                    c.Enabled = enabled;
                    
                }
            }
            ProtectBtn.Visible = enabled;
            CancelBtn.Visible = !enabled;
        }
        private void ChooseBtn_Click(object sender, EventArgs e) //Show file dialog.
        { 
            OpenFileDialog dialog = new OpenFileDialog
            {
                Multiselect = false,
                Filter = ".DLL|*.dll; *.Dll"
            };
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                if((MainClass.Settings.AssemblyPath == string.Empty || MainClass.Settings.ContainingFolder == string.Empty) || MainClass.Settings.AssemblyPath != dialog.FileName)
                {
                    StatusLbl.Text = "Idle";
                    StatusLbl.ForeColor = Color.Black;
                    Exclusion.Types.Clear();
                    Exclusion.ExludedTypes.Clear();
                }
                MainClass.Settings.AssemblyPath = dialog.FileName;
                MainClass.Settings.ContainingFolder = Path.GetDirectoryName(MainClass.Settings.AssemblyPath);               
                PathTxt.Text = dialog.FileName;
                try
                {
                    MainClass.MainModule = ModuleDefMD.Load(File.ReadAllBytes(MainClass.Settings.AssemblyPath));
                }
                catch
                {
                    MainClass.MainModule = null;
                }
            }
        }
        private void PathTxt_DragDrop(object sender, DragEventArgs e) //Ignore this.
        {
            
        }
        private void PathTxt_DragEnter(object sender, DragEventArgs e) //You can also drag your assembly directly to the text box instead of browsing it with the file dialog.
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0)
            {
                string file = files[0];
                if (file.EndsWith(".dll"))
                {
                    if ((MainClass.Settings.AssemblyPath == string.Empty || MainClass.Settings.ContainingFolder == string.Empty) || MainClass.Settings.AssemblyPath != file)
                    {
                        StatusLbl.Text = "Idle";
                        StatusLbl.ForeColor = Color.Black;
                        Exclusion.Types.Clear();
                        Exclusion.ExludedTypes.Clear();
                        e.Effect = DragDropEffects.Copy;
                        PathTxt.Text = file;
                        MainClass.Settings.AssemblyPath = file;
                    }
                }
            }
        }
        private void PathTxt_TextChanged(object sender, EventArgs e) //Updates the main module when the path of the assembly changes.
        {
            MainClass.Settings.AssemblyPath = PathTxt.Text;
            try
            {
                MainClass.MainModule = ModuleDefMD.Load(File.ReadAllBytes(MainClass.Settings.AssemblyPath));
            }
            catch
            { 
            }
        }
        /* The rest are just functions of what happens when the checkboxes are checked / unchecked. */
        private void AntiILDasmCB_CheckedChanged(object sender, EventArgs e)
        {
            MainClass.Settings.AntiILDasm = AntiILDasmCB.Checked;
            SystemSounds.Asterisk.Play();
        }
        private void RenameNamespacesCB_CheckedChanged(object sender, EventArgs e)
        {
            MainClass.Settings.RenameNamespaces = RenameNamespacesCB.Checked;
            SystemSounds.Asterisk.Play();
        }

        private void RenameTypesCB_CheckedChanged(object sender, EventArgs e)
        {
            MainClass.Settings.RenameTypes = RenameTypesCB.Checked;
            SystemSounds.Asterisk.Play();
        }

        private void RenameMethodsCB_CheckedChanged(object sender, EventArgs e)
        {
            MainClass.Settings.RenameMethods = RenameMethodsCB.Checked;
            SystemSounds.Asterisk.Play();
        }

        private void RenameFieldsCB_CheckedChanged(object sender, EventArgs e)
        {
            MainClass.Settings.RenameFields = RenameFieldsCB.Checked;
            SystemSounds.Asterisk.Play();
        }

        private void RenamePropertiesCB_CheckedChanged(object sender, EventArgs e)
        {
            MainClass.Settings.RenameProperties = RenamePropertiesCB.Checked;
            SystemSounds.Asterisk.Play();
        }
        private void AntiTamperingCB_CheckedChanged(object sender, EventArgs e)
        {
            MainClass.Settings.AntiTampering = AntiTamperingCB.Checked;
            SystemSounds.Asterisk.Play();
        }
        private void RandomNameRB_CheckedChanged(object sender, EventArgs e)
        {
            MainClass.Settings.RandomName = true;
            MainClass.Settings.EmptyName = false;
            SystemSounds.Asterisk.Play();
        }
        private void StringEcnryptionCB_CheckedChanged(object sender, EventArgs e)
        {
            MainClass.Settings.StringEcnryption = StringEncnryptionCB.Checked;
            SystemSounds.Asterisk.Play();
        }
        private void EmptyNameRB_CheckedChanged(object sender, EventArgs e)
        {
            MainClass.Settings.RandomName = false;
            MainClass.Settings.EmptyName = true;
            SystemSounds.Asterisk.Play();
        }

        private void ExcludeTypesBtn_Click(object sender, EventArgs e) //Shows the 'Exclude Types' form.
        {
            try
            {
                MainClass.MainModule = ModuleDefMD.Load(File.ReadAllBytes(MainClass.Settings.AssemblyPath));
            }
            catch
            {
                MainClass.MainModule = null;
            }
            new ExcludeTypesForm().ShowDialog();
        }
        private void OpenFolderBtn_Click(object sender, EventArgs e) //Opens the containing folder.
        {
            if(MainClass.Settings.ContainingFolder == string.Empty || !Directory.Exists(MainClass.Settings.ContainingFolder))
            {
                return;
            }
            Process.Start(MainClass.Settings.ContainingFolder);
        }
        private void ProtectBtn_Click(object sender, EventArgs e) //Protects the assembly.
        {
            if (!MainClass.Settings.AssemblyExists)
            {
                MessageBox.Show("DLL not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!MainClass.Settings.IsAssemblyDotNet)
            {
                MessageBox.Show("The selected assebly is not a .NET module!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MainClass.Settings.Check())
                {
                    MainClass.ObfuscationThread = new Thread(Protect);
                    MainClass.ObfuscationThread.Start();

                }
            }
        }

        private void AboutBtn_Click(object sender, EventArgs e) //Just an "About" dialog.
        {
            MessageBox.Show("Coded by AkyrosXD", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ResetBtn_Click(object sender, EventArgs e) //Resets all the settings.
        {
            foreach (Control c in SettingsBox.Controls)
            {
                if (c is CheckBox cb)
                {
                    if (cb.Checked)
                    {
                        DialogResult r = MessageBox.Show("All the settings will be reseted!\nAre you sure you want to continue?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if(r == DialogResult.OK)
                        {
                            MainClass.Settings.Reset(SettingsBox.Controls);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
        }
        private void RestartBtn(object sender, EventArgs e) //Restarts the form.
        {
            MainClass.Settings.Restart(this);
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExcludeStringsBtn_Click(object sender, EventArgs e) //Shows the 'Exlude Strings' form.
        {
            try
            {
                MainClass.MainModule = ModuleDefMD.Load(File.ReadAllBytes(MainClass.Settings.AssemblyPath));
            }
            catch
            {
                MainClass.MainModule = null;
            }
            new ExcludeStringsForm().ShowDialog();
        }

        private void HelpBtn_Click(object sender, EventArgs e) //Shows the 'Help' form. For more info if someone needs help.
        {
            new HelpForm().ShowDialog();
        }

        private void CancelBtn_Click(object sender, EventArgs e) //Cancels the obfuscation task if it's still in progress.
        {
            if(MainClass.ObfuscationThread != null)
            {
                MainClass.ObfuscationThread.Abort();
                StatusLbl.Text = "Canceled!";
                StatusLbl.ForeColor = Color.Red;
            }
        }
    }
}