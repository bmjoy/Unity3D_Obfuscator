namespace Unity3DObfuscator
{
    partial class HelpForm
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
            this.HelpTabControl = new System.Windows.Forms.TabControl();
            this.RenamingPage = new System.Windows.Forms.TabPage();
            this.StringEncryptionPage = new System.Windows.Forms.TabPage();
            this.AntiTamperingPage = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.StringEncryptionTxt = new System.Windows.Forms.TextBox();
            this.AntiTamperingTxt = new System.Windows.Forms.TextBox();
            this.RenamingTxt = new System.Windows.Forms.TextBox();
            this.CloseBtn = new FormSkin.clsButtonBlue();
            this.MainTheme.SuspendLayout();
            this.HelpTabControl.SuspendLayout();
            this.RenamingPage.SuspendLayout();
            this.StringEncryptionPage.SuspendLayout();
            this.AntiTamperingPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTheme
            // 
            this.MainTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.MainTheme.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainTheme.Controls.Add(this.CloseBtn);
            this.MainTheme.Controls.Add(this.HelpTabControl);
            this.MainTheme.Customization = "AAAA/w==";
            this.MainTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTheme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTheme.Image = null;
            this.MainTheme.Location = new System.Drawing.Point(0, 0);
            this.MainTheme.Movable = false;
            this.MainTheme.Name = "MainTheme";
            this.MainTheme.NoRounding = false;
            this.MainTheme.Sizable = false;
            this.MainTheme.Size = new System.Drawing.Size(346, 518);
            this.MainTheme.SmartBounds = true;
            this.MainTheme.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.MainTheme.TabIndex = 0;
            this.MainTheme.Text = "Help";
            this.MainTheme.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.MainTheme.Transparent = false;
            // 
            // HelpTabControl
            // 
            this.HelpTabControl.Controls.Add(this.RenamingPage);
            this.HelpTabControl.Controls.Add(this.StringEncryptionPage);
            this.HelpTabControl.Controls.Add(this.AntiTamperingPage);
            this.HelpTabControl.Location = new System.Drawing.Point(3, 40);
            this.HelpTabControl.Name = "HelpTabControl";
            this.HelpTabControl.SelectedIndex = 0;
            this.HelpTabControl.Size = new System.Drawing.Size(341, 431);
            this.HelpTabControl.TabIndex = 0;
            // 
            // RenamingPage
            // 
            this.RenamingPage.Controls.Add(this.RenamingTxt);
            this.RenamingPage.ForeColor = System.Drawing.Color.Blue;
            this.RenamingPage.Location = new System.Drawing.Point(4, 30);
            this.RenamingPage.Name = "RenamingPage";
            this.RenamingPage.Padding = new System.Windows.Forms.Padding(3);
            this.RenamingPage.Size = new System.Drawing.Size(333, 397);
            this.RenamingPage.TabIndex = 0;
            this.RenamingPage.Text = "Renaming";
            this.RenamingPage.UseVisualStyleBackColor = true;
            // 
            // StringEncryptionPage
            // 
            this.StringEncryptionPage.Controls.Add(this.StringEncryptionTxt);
            this.StringEncryptionPage.Controls.Add(this.textBox1);
            this.StringEncryptionPage.ForeColor = System.Drawing.Color.Blue;
            this.StringEncryptionPage.Location = new System.Drawing.Point(4, 30);
            this.StringEncryptionPage.Name = "StringEncryptionPage";
            this.StringEncryptionPage.Padding = new System.Windows.Forms.Padding(3);
            this.StringEncryptionPage.Size = new System.Drawing.Size(333, 397);
            this.StringEncryptionPage.TabIndex = 1;
            this.StringEncryptionPage.Text = "String Encryption";
            this.StringEncryptionPage.UseVisualStyleBackColor = true;
            // 
            // AntiTamperingPage
            // 
            this.AntiTamperingPage.Controls.Add(this.AntiTamperingTxt);
            this.AntiTamperingPage.ForeColor = System.Drawing.Color.Blue;
            this.AntiTamperingPage.Location = new System.Drawing.Point(4, 30);
            this.AntiTamperingPage.Name = "AntiTamperingPage";
            this.AntiTamperingPage.Size = new System.Drawing.Size(333, 397);
            this.AntiTamperingPage.TabIndex = 2;
            this.AntiTamperingPage.Text = "Anti Tampering";
            this.AntiTamperingPage.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Blue;
            this.textBox1.Location = new System.Drawing.Point(-6, -2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(344, 368);
            this.textBox1.TabIndex = 1;
            // 
            // StringEncryptionTxt
            // 
            this.StringEncryptionTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StringEncryptionTxt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StringEncryptionTxt.ForeColor = System.Drawing.Color.Blue;
            this.StringEncryptionTxt.Location = new System.Drawing.Point(-4, 0);
            this.StringEncryptionTxt.Multiline = true;
            this.StringEncryptionTxt.Name = "StringEncryptionTxt";
            this.StringEncryptionTxt.ReadOnly = true;
            this.StringEncryptionTxt.Size = new System.Drawing.Size(344, 401);
            this.StringEncryptionTxt.TabIndex = 2;
            // 
            // AntiTamperingTxt
            // 
            this.AntiTamperingTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AntiTamperingTxt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AntiTamperingTxt.ForeColor = System.Drawing.Color.Blue;
            this.AntiTamperingTxt.Location = new System.Drawing.Point(-6, -2);
            this.AntiTamperingTxt.Multiline = true;
            this.AntiTamperingTxt.Name = "AntiTamperingTxt";
            this.AntiTamperingTxt.ReadOnly = true;
            this.AntiTamperingTxt.Size = new System.Drawing.Size(344, 403);
            this.AntiTamperingTxt.TabIndex = 1;
            // 
            // RenamingTxt
            // 
            this.RenamingTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RenamingTxt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RenamingTxt.ForeColor = System.Drawing.Color.Blue;
            this.RenamingTxt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RenamingTxt.Location = new System.Drawing.Point(-7, 0);
            this.RenamingTxt.Multiline = true;
            this.RenamingTxt.Name = "RenamingTxt";
            this.RenamingTxt.ReadOnly = true;
            this.RenamingTxt.Size = new System.Drawing.Size(344, 401);
            this.RenamingTxt.TabIndex = 0;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Customization = "9fX1/6mpqf8=";
            this.CloseBtn.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.Image = null;
            this.CloseBtn.Location = new System.Drawing.Point(4, 473);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.NoRounding = false;
            this.CloseBtn.Size = new System.Drawing.Size(337, 42);
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.Transparent = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 518);
            this.Controls.Add(this.MainTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HelpForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.MainTheme.ResumeLayout(false);
            this.HelpTabControl.ResumeLayout(false);
            this.RenamingPage.ResumeLayout(false);
            this.RenamingPage.PerformLayout();
            this.StringEncryptionPage.ResumeLayout(false);
            this.StringEncryptionPage.PerformLayout();
            this.AntiTamperingPage.ResumeLayout(false);
            this.AntiTamperingPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FormSkin.clsNeoBuxTheme MainTheme;
        private System.Windows.Forms.TabControl HelpTabControl;
        private System.Windows.Forms.TabPage RenamingPage;
        private System.Windows.Forms.TabPage StringEncryptionPage;
        private System.Windows.Forms.TabPage AntiTamperingPage;
        private System.Windows.Forms.TextBox StringEncryptionTxt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox AntiTamperingTxt;
        private System.Windows.Forms.TextBox RenamingTxt;
        private FormSkin.clsButtonBlue CloseBtn;
    }
}