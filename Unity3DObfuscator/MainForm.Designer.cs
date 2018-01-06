namespace Unity3DObfuscator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainTheme = new FormSkin.clsNeoBuxTheme();
            this.ExitBtn = new FormSkin.clsButtonGrey();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.HelpBtn = new FormSkin.clsButtonOrange();
            this.sLabel = new System.Windows.Forms.Label();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.ResetBtn = new FormSkin.clsButtonPurple();
            this.AboutBtn = new FormSkin.clsButtonBlue();
            this.clsControlMenu1 = new FormSkin.clsControlMenu();
            this.RestartBtn_ = new FormSkin.clsButtonOrange();
            this.ChooseBtn = new FormSkin.clsButtonGrey();
            this.PathTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProtectBtn = new FormSkin.clsButtonGreen();
            this.SettingsBox = new System.Windows.Forms.GroupBox();
            this.ExcludeStringsBtn = new FormSkin.clsButtonGrey();
            this.label2 = new System.Windows.Forms.Label();
            this.StringEncnryptionCB = new System.Windows.Forms.CheckBox();
            this.AntiILDasmCB = new System.Windows.Forms.CheckBox();
            this.RandomNameRB = new System.Windows.Forms.RadioButton();
            this.EmptyNameRB = new System.Windows.Forms.RadioButton();
            this.OpenFolderBtn = new FormSkin.clsButtonGrey();
            this.AntiTamperingCB = new System.Windows.Forms.CheckBox();
            this.ExcludeTypesBtn = new FormSkin.clsButtonGrey();
            this.RenameFieldsCB = new System.Windows.Forms.CheckBox();
            this.RenameTypesCB = new System.Windows.Forms.CheckBox();
            this.RenamePropertiesCB = new System.Windows.Forms.CheckBox();
            this.RenameMethodsCB = new System.Windows.Forms.CheckBox();
            this.RenameNamespacesCB = new System.Windows.Forms.CheckBox();
            this.bottomTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StringEncrypyionTypeCB = new System.Windows.Forms.ComboBox();
            this.MainTheme.SuspendLayout();
            this.SettingsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTheme
            // 
            this.MainTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.MainTheme.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainTheme.Controls.Add(this.ExitBtn);
            this.MainTheme.Controls.Add(this.CancelBtn);
            this.MainTheme.Controls.Add(this.HelpBtn);
            this.MainTheme.Controls.Add(this.sLabel);
            this.MainTheme.Controls.Add(this.StatusLbl);
            this.MainTheme.Controls.Add(this.ResetBtn);
            this.MainTheme.Controls.Add(this.AboutBtn);
            this.MainTheme.Controls.Add(this.clsControlMenu1);
            this.MainTheme.Controls.Add(this.RestartBtn_);
            this.MainTheme.Controls.Add(this.ChooseBtn);
            this.MainTheme.Controls.Add(this.PathTxt);
            this.MainTheme.Controls.Add(this.label1);
            this.MainTheme.Controls.Add(this.ProtectBtn);
            this.MainTheme.Controls.Add(this.SettingsBox);
            this.MainTheme.Controls.Add(this.bottomTxt);
            this.MainTheme.Customization = "AAAA/w==";
            this.MainTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTheme.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MainTheme.Image = null;
            this.MainTheme.Location = new System.Drawing.Point(0, 0);
            this.MainTheme.Movable = true;
            this.MainTheme.Name = "MainTheme";
            this.MainTheme.NoRounding = false;
            this.MainTheme.Sizable = false;
            this.MainTheme.Size = new System.Drawing.Size(364, 350);
            this.MainTheme.SmartBounds = true;
            this.MainTheme.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MainTheme.TabIndex = 0;
            this.MainTheme.Text = "Unity3D Obfuscator";
            this.MainTheme.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.MainTheme.Transparent = false;
            this.MainTheme.Click += new System.EventHandler(this.MainTheme_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Customization = "9fX1/6mpqf8=";
            this.ExitBtn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Image = null;
            this.ExitBtn.Location = new System.Drawing.Point(272, 268);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.NoRounding = false;
            this.ExitBtn.Size = new System.Drawing.Size(87, 28);
            this.ExitBtn.TabIndex = 17;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.Transparent = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.Red;
            this.CancelBtn.Location = new System.Drawing.Point(235, 313);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(129, 34);
            this.CancelBtn.TabIndex = 19;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Visible = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // HelpBtn
            // 
            this.HelpBtn.Customization = "9fX1/6mpqf8=";
            this.HelpBtn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpBtn.Image = null;
            this.HelpBtn.Location = new System.Drawing.Point(271, 133);
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.NoRounding = false;
            this.HelpBtn.Size = new System.Drawing.Size(87, 28);
            this.HelpBtn.TabIndex = 18;
            this.HelpBtn.Text = "Help";
            this.HelpBtn.Transparent = false;
            this.HelpBtn.Click += new System.EventHandler(this.HelpBtn_Click);
            // 
            // sLabel
            // 
            this.sLabel.AutoSize = true;
            this.sLabel.BackColor = System.Drawing.Color.Gray;
            this.sLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sLabel.Location = new System.Drawing.Point(4, 319);
            this.sLabel.Name = "sLabel";
            this.sLabel.Size = new System.Drawing.Size(65, 25);
            this.sLabel.TabIndex = 1;
            this.sLabel.Text = "Status:";
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.BackColor = System.Drawing.Color.Gray;
            this.StatusLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLbl.Location = new System.Drawing.Point(64, 319);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(41, 25);
            this.StatusLbl.TabIndex = 13;
            this.StatusLbl.Text = "Idle";
            // 
            // ResetBtn
            // 
            this.ResetBtn.Customization = "9fX1/6mpqf8=";
            this.ResetBtn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.Image = null;
            this.ResetBtn.Location = new System.Drawing.Point(271, 201);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.NoRounding = false;
            this.ResetBtn.Size = new System.Drawing.Size(87, 28);
            this.ResetBtn.TabIndex = 12;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.Transparent = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // AboutBtn
            // 
            this.AboutBtn.Customization = "9fX1/6mpqf8=";
            this.AboutBtn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutBtn.Image = null;
            this.AboutBtn.Location = new System.Drawing.Point(271, 104);
            this.AboutBtn.Name = "AboutBtn";
            this.AboutBtn.NoRounding = false;
            this.AboutBtn.Size = new System.Drawing.Size(87, 23);
            this.AboutBtn.TabIndex = 11;
            this.AboutBtn.Text = "About";
            this.AboutBtn.Transparent = false;
            this.AboutBtn.Click += new System.EventHandler(this.AboutBtn_Click);
            // 
            // clsControlMenu1
            // 
            this.clsControlMenu1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clsControlMenu1.Customization = "8u/v/////wD///8A";
            this.clsControlMenu1.Font = new System.Drawing.Font("Verdana", 8F);
            this.clsControlMenu1.Image = null;
            this.clsControlMenu1.Location = new System.Drawing.Point(292, 1);
            this.clsControlMenu1.Name = "clsControlMenu1";
            this.clsControlMenu1.NoRounding = false;
            this.clsControlMenu1.Size = new System.Drawing.Size(71, 19);
            this.clsControlMenu1.TabIndex = 10;
            this.clsControlMenu1.Text = "CtrlMenu";
            this.clsControlMenu1.Transparent = false;
            // 
            // RestartBtn_
            // 
            this.RestartBtn_.Customization = "9fX1/6mpqf8=";
            this.RestartBtn_.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartBtn_.Image = null;
            this.RestartBtn_.Location = new System.Drawing.Point(272, 235);
            this.RestartBtn_.Name = "RestartBtn_";
            this.RestartBtn_.NoRounding = false;
            this.RestartBtn_.Size = new System.Drawing.Size(87, 28);
            this.RestartBtn_.TabIndex = 8;
            this.RestartBtn_.Text = "Restart";
            this.RestartBtn_.Transparent = false;
            this.RestartBtn_.Click += new System.EventHandler(this.RestartBtn);
            // 
            // ChooseBtn
            // 
            this.ChooseBtn.Customization = "9fX1/6mpqf8=";
            this.ChooseBtn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseBtn.Image = null;
            this.ChooseBtn.Location = new System.Drawing.Point(325, 59);
            this.ChooseBtn.Name = "ChooseBtn";
            this.ChooseBtn.NoRounding = false;
            this.ChooseBtn.Size = new System.Drawing.Size(34, 23);
            this.ChooseBtn.TabIndex = 7;
            this.ChooseBtn.Text = "...";
            this.ChooseBtn.Transparent = false;
            this.ChooseBtn.Click += new System.EventHandler(this.ChooseBtn_Click);
            // 
            // PathTxt
            // 
            this.PathTxt.AllowDrop = true;
            this.PathTxt.Location = new System.Drawing.Point(7, 59);
            this.PathTxt.Name = "PathTxt";
            this.PathTxt.Size = new System.Drawing.Size(312, 23);
            this.PathTxt.TabIndex = 6;
            this.PathTxt.TextChanged += new System.EventHandler(this.PathTxt_TextChanged);
            this.PathTxt.DragDrop += new System.Windows.Forms.DragEventHandler(this.PathTxt_DragDrop);
            this.PathTxt.DragEnter += new System.Windows.Forms.DragEventHandler(this.PathTxt_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose Assembly:";
            // 
            // ProtectBtn
            // 
            this.ProtectBtn.Customization = "9fX1/6mpqf8=";
            this.ProtectBtn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProtectBtn.Image = null;
            this.ProtectBtn.Location = new System.Drawing.Point(271, 166);
            this.ProtectBtn.Name = "ProtectBtn";
            this.ProtectBtn.NoRounding = false;
            this.ProtectBtn.Size = new System.Drawing.Size(87, 28);
            this.ProtectBtn.TabIndex = 4;
            this.ProtectBtn.Text = "Protect!";
            this.ProtectBtn.Transparent = false;
            this.ProtectBtn.Click += new System.EventHandler(this.ProtectBtn_Click);
            // 
            // SettingsBox
            // 
            this.SettingsBox.Controls.Add(this.StringEncrypyionTypeCB);
            this.SettingsBox.Controls.Add(this.label3);
            this.SettingsBox.Controls.Add(this.ExcludeStringsBtn);
            this.SettingsBox.Controls.Add(this.label2);
            this.SettingsBox.Controls.Add(this.StringEncnryptionCB);
            this.SettingsBox.Controls.Add(this.AntiILDasmCB);
            this.SettingsBox.Controls.Add(this.RandomNameRB);
            this.SettingsBox.Controls.Add(this.EmptyNameRB);
            this.SettingsBox.Controls.Add(this.OpenFolderBtn);
            this.SettingsBox.Controls.Add(this.AntiTamperingCB);
            this.SettingsBox.Controls.Add(this.ExcludeTypesBtn);
            this.SettingsBox.Controls.Add(this.RenameFieldsCB);
            this.SettingsBox.Controls.Add(this.RenameTypesCB);
            this.SettingsBox.Controls.Add(this.RenamePropertiesCB);
            this.SettingsBox.Controls.Add(this.RenameMethodsCB);
            this.SettingsBox.Controls.Add(this.RenameNamespacesCB);
            this.SettingsBox.Location = new System.Drawing.Point(3, 80);
            this.SettingsBox.Name = "SettingsBox";
            this.SettingsBox.Size = new System.Drawing.Size(262, 233);
            this.SettingsBox.TabIndex = 3;
            this.SettingsBox.TabStop = false;
            this.SettingsBox.Text = "Settings";
            // 
            // ExcludeStringsBtn
            // 
            this.ExcludeStringsBtn.Customization = "9fX1/6mpqf8=";
            this.ExcludeStringsBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExcludeStringsBtn.Image = null;
            this.ExcludeStringsBtn.Location = new System.Drawing.Point(112, 142);
            this.ExcludeStringsBtn.Name = "ExcludeStringsBtn";
            this.ExcludeStringsBtn.NoRounding = false;
            this.ExcludeStringsBtn.Size = new System.Drawing.Size(148, 24);
            this.ExcludeStringsBtn.TabIndex = 19;
            this.ExcludeStringsBtn.Text = "Exclude Strings";
            this.ExcludeStringsBtn.Transparent = false;
            this.ExcludeStringsBtn.Click += new System.EventHandler(this.ExcludeStringsBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Renaming Type:";
            // 
            // StringEncnryptionCB
            // 
            this.StringEncnryptionCB.AutoSize = true;
            this.StringEncnryptionCB.Location = new System.Drawing.Point(3, 93);
            this.StringEncnryptionCB.Name = "StringEncnryptionCB";
            this.StringEncnryptionCB.Size = new System.Drawing.Size(117, 19);
            this.StringEncnryptionCB.TabIndex = 11;
            this.StringEncnryptionCB.Text = "String Encryption";
            this.StringEncnryptionCB.UseVisualStyleBackColor = true;
            this.StringEncnryptionCB.CheckedChanged += new System.EventHandler(this.StringEcnryptionCB_CheckedChanged);
            // 
            // AntiILDasmCB
            // 
            this.AntiILDasmCB.AutoSize = true;
            this.AntiILDasmCB.Location = new System.Drawing.Point(3, 17);
            this.AntiILDasmCB.Name = "AntiILDasmCB";
            this.AntiILDasmCB.Size = new System.Drawing.Size(93, 19);
            this.AntiILDasmCB.TabIndex = 10;
            this.AntiILDasmCB.Text = "Anti ILDASM";
            this.AntiILDasmCB.UseVisualStyleBackColor = true;
            this.AntiILDasmCB.CheckedChanged += new System.EventHandler(this.AntiILDasmCB_CheckedChanged);
            // 
            // RandomNameRB
            // 
            this.RandomNameRB.AutoSize = true;
            this.RandomNameRB.BackColor = System.Drawing.Color.Transparent;
            this.RandomNameRB.Checked = true;
            this.RandomNameRB.Location = new System.Drawing.Point(-1, 166);
            this.RandomNameRB.Name = "RandomNameRB";
            this.RandomNameRB.Size = new System.Drawing.Size(105, 19);
            this.RandomNameRB.TabIndex = 9;
            this.RandomNameRB.TabStop = true;
            this.RandomNameRB.Text = "Random Name";
            this.RandomNameRB.UseVisualStyleBackColor = false;
            this.RandomNameRB.CheckedChanged += new System.EventHandler(this.RandomNameRB_CheckedChanged);
            // 
            // EmptyNameRB
            // 
            this.EmptyNameRB.AutoSize = true;
            this.EmptyNameRB.Location = new System.Drawing.Point(-1, 144);
            this.EmptyNameRB.Name = "EmptyNameRB";
            this.EmptyNameRB.Size = new System.Drawing.Size(94, 19);
            this.EmptyNameRB.TabIndex = 8;
            this.EmptyNameRB.Text = "Empty Name";
            this.EmptyNameRB.UseVisualStyleBackColor = true;
            this.EmptyNameRB.CheckedChanged += new System.EventHandler(this.EmptyNameRB_CheckedChanged);
            // 
            // OpenFolderBtn
            // 
            this.OpenFolderBtn.Customization = "9fX1/6mpqf8=";
            this.OpenFolderBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFolderBtn.Image = null;
            this.OpenFolderBtn.Location = new System.Drawing.Point(112, 172);
            this.OpenFolderBtn.Name = "OpenFolderBtn";
            this.OpenFolderBtn.NoRounding = false;
            this.OpenFolderBtn.Size = new System.Drawing.Size(148, 24);
            this.OpenFolderBtn.TabIndex = 7;
            this.OpenFolderBtn.Text = "Open Containg Folder";
            this.OpenFolderBtn.Transparent = false;
            this.OpenFolderBtn.Click += new System.EventHandler(this.OpenFolderBtn_Click);
            // 
            // AntiTamperingCB
            // 
            this.AntiTamperingCB.AutoSize = true;
            this.AntiTamperingCB.Location = new System.Drawing.Point(126, 93);
            this.AntiTamperingCB.Name = "AntiTamperingCB";
            this.AntiTamperingCB.Size = new System.Drawing.Size(108, 19);
            this.AntiTamperingCB.TabIndex = 6;
            this.AntiTamperingCB.Text = "Anti Tampering";
            this.AntiTamperingCB.UseVisualStyleBackColor = true;
            this.AntiTamperingCB.CheckedChanged += new System.EventHandler(this.AntiTamperingCB_CheckedChanged);
            // 
            // ExcludeTypesBtn
            // 
            this.ExcludeTypesBtn.Customization = "9fX1/6mpqf8=";
            this.ExcludeTypesBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExcludeTypesBtn.Image = null;
            this.ExcludeTypesBtn.Location = new System.Drawing.Point(112, 113);
            this.ExcludeTypesBtn.Name = "ExcludeTypesBtn";
            this.ExcludeTypesBtn.NoRounding = false;
            this.ExcludeTypesBtn.Size = new System.Drawing.Size(150, 24);
            this.ExcludeTypesBtn.TabIndex = 5;
            this.ExcludeTypesBtn.Text = "Exclude Types";
            this.ExcludeTypesBtn.Transparent = false;
            this.ExcludeTypesBtn.Click += new System.EventHandler(this.ExcludeTypesBtn_Click);
            // 
            // RenameFieldsCB
            // 
            this.RenameFieldsCB.AutoSize = true;
            this.RenameFieldsCB.Location = new System.Drawing.Point(125, 68);
            this.RenameFieldsCB.Name = "RenameFieldsCB";
            this.RenameFieldsCB.Size = new System.Drawing.Size(102, 19);
            this.RenameFieldsCB.TabIndex = 4;
            this.RenameFieldsCB.Text = "Rename Fields";
            this.RenameFieldsCB.UseVisualStyleBackColor = true;
            this.RenameFieldsCB.CheckedChanged += new System.EventHandler(this.RenameFieldsCB_CheckedChanged);
            // 
            // RenameTypesCB
            // 
            this.RenameTypesCB.AutoSize = true;
            this.RenameTypesCB.Location = new System.Drawing.Point(3, 42);
            this.RenameTypesCB.Name = "RenameTypesCB";
            this.RenameTypesCB.Size = new System.Drawing.Size(102, 19);
            this.RenameTypesCB.TabIndex = 3;
            this.RenameTypesCB.Text = "Rename Types";
            this.RenameTypesCB.UseVisualStyleBackColor = true;
            this.RenameTypesCB.CheckedChanged += new System.EventHandler(this.RenameTypesCB_CheckedChanged);
            // 
            // RenamePropertiesCB
            // 
            this.RenamePropertiesCB.AutoSize = true;
            this.RenamePropertiesCB.Location = new System.Drawing.Point(3, 67);
            this.RenamePropertiesCB.Name = "RenamePropertiesCB";
            this.RenamePropertiesCB.Size = new System.Drawing.Size(125, 19);
            this.RenamePropertiesCB.TabIndex = 2;
            this.RenamePropertiesCB.Text = "Rename Properties";
            this.RenamePropertiesCB.UseVisualStyleBackColor = true;
            this.RenamePropertiesCB.CheckedChanged += new System.EventHandler(this.RenamePropertiesCB_CheckedChanged);
            // 
            // RenameMethodsCB
            // 
            this.RenameMethodsCB.AutoSize = true;
            this.RenameMethodsCB.Location = new System.Drawing.Point(125, 43);
            this.RenameMethodsCB.Name = "RenameMethodsCB";
            this.RenameMethodsCB.Size = new System.Drawing.Size(119, 19);
            this.RenameMethodsCB.TabIndex = 1;
            this.RenameMethodsCB.Text = "Rename Methods";
            this.RenameMethodsCB.UseVisualStyleBackColor = true;
            this.RenameMethodsCB.CheckedChanged += new System.EventHandler(this.RenameMethodsCB_CheckedChanged);
            // 
            // RenameNamespacesCB
            // 
            this.RenameNamespacesCB.AutoSize = true;
            this.RenameNamespacesCB.Location = new System.Drawing.Point(125, 17);
            this.RenameNamespacesCB.Name = "RenameNamespacesCB";
            this.RenameNamespacesCB.Size = new System.Drawing.Size(139, 19);
            this.RenameNamespacesCB.TabIndex = 0;
            this.RenameNamespacesCB.Text = "Rename Namespaces";
            this.RenameNamespacesCB.UseVisualStyleBackColor = true;
            this.RenameNamespacesCB.CheckedChanged += new System.EventHandler(this.RenameNamespacesCB_CheckedChanged);
            // 
            // bottomTxt
            // 
            this.bottomTxt.BackColor = System.Drawing.Color.Gray;
            this.bottomTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bottomTxt.Enabled = false;
            this.bottomTxt.Location = new System.Drawing.Point(0, 313);
            this.bottomTxt.Multiline = true;
            this.bottomTxt.Name = "bottomTxt";
            this.bottomTxt.ReadOnly = true;
            this.bottomTxt.Size = new System.Drawing.Size(364, 35);
            this.bottomTxt.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "String Encryption Type:";
            // 
            // StringEncrypyionTypeCB
            // 
            this.StringEncrypyionTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StringEncrypyionTypeCB.FormattingEnabled = true;
            this.StringEncrypyionTypeCB.Items.AddRange(new object[] {
            "Weak",
            "Normal",
            "Strong"});
            this.StringEncrypyionTypeCB.Location = new System.Drawing.Point(136, 205);
            this.StringEncrypyionTypeCB.Name = "StringEncrypyionTypeCB";
            this.StringEncrypyionTypeCB.Size = new System.Drawing.Size(120, 23);
            this.StringEncrypyionTypeCB.TabIndex = 20;
            this.StringEncrypyionTypeCB.SelectedIndexChanged += new System.EventHandler(this.StringEncrypyionTypeCB_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 350);
            this.Controls.Add(this.MainTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unity3D Obfuscator";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.MainTheme.ResumeLayout(false);
            this.MainTheme.PerformLayout();
            this.SettingsBox.ResumeLayout(false);
            this.SettingsBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FormSkin.clsNeoBuxTheme MainTheme;
        private FormSkin.clsButtonGrey ChooseBtn;
        private System.Windows.Forms.TextBox PathTxt;
        private System.Windows.Forms.Label label1;
        private FormSkin.clsButtonGreen ProtectBtn;
        private System.Windows.Forms.GroupBox SettingsBox;
        private FormSkin.clsButtonOrange RestartBtn_;
        private System.Windows.Forms.CheckBox RenameFieldsCB;
        private System.Windows.Forms.CheckBox RenameTypesCB;
        private System.Windows.Forms.CheckBox RenamePropertiesCB;
        private System.Windows.Forms.CheckBox RenameMethodsCB;
        private System.Windows.Forms.CheckBox RenameNamespacesCB;
        private FormSkin.clsControlMenu clsControlMenu1;
        private FormSkin.clsButtonBlue AboutBtn;
        private FormSkin.clsButtonGrey ExcludeTypesBtn;
        private System.Windows.Forms.CheckBox AntiTamperingCB;
        private FormSkin.clsButtonPurple ResetBtn;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.Label sLabel;
        private System.Windows.Forms.TextBox bottomTxt;
        private FormSkin.clsButtonGrey OpenFolderBtn;
        private FormSkin.clsButtonGrey ExitBtn;
        private System.Windows.Forms.RadioButton RandomNameRB;
        private System.Windows.Forms.RadioButton EmptyNameRB;
        private System.Windows.Forms.CheckBox AntiILDasmCB;
        private System.Windows.Forms.CheckBox StringEncnryptionCB;
        private System.Windows.Forms.Label label2;
        private FormSkin.clsButtonGrey ExcludeStringsBtn;
        private FormSkin.clsButtonOrange HelpBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.ComboBox StringEncrypyionTypeCB;
        private System.Windows.Forms.Label label3;
    }
}

