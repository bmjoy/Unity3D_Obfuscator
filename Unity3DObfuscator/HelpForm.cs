using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unity3DObfuscator
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
            RenamingTxt.Text = ObfuscatorHelp.Renaming;
            StringEncryptionTxt.Text = ObfuscatorHelp.StringEncryption;
            AntiTamperingTxt.Text = ObfuscatorHelp.AntiTampering;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
