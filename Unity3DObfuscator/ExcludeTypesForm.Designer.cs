namespace Unity3DObfuscator
{
    partial class ExcludeTypesForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchExcludedTypes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ExcludedTypesList = new System.Windows.Forms.ListBox();
            this.SearchTypesTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TypesList = new System.Windows.Forms.ListBox();
            this.CloseBtn = new FormSkin.clsButtonPurple();
            this.RemoveBtn = new FormSkin.clsButtonOrange();
            this.AddBtn = new FormSkin.clsButtonGreen();
            this.MainTheme.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTheme
            // 
            this.MainTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.MainTheme.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainTheme.Controls.Add(this.label4);
            this.MainTheme.Controls.Add(this.label3);
            this.MainTheme.Controls.Add(this.SearchExcludedTypes);
            this.MainTheme.Controls.Add(this.label2);
            this.MainTheme.Controls.Add(this.ExcludedTypesList);
            this.MainTheme.Controls.Add(this.SearchTypesTxt);
            this.MainTheme.Controls.Add(this.label1);
            this.MainTheme.Controls.Add(this.TypesList);
            this.MainTheme.Controls.Add(this.CloseBtn);
            this.MainTheme.Controls.Add(this.RemoveBtn);
            this.MainTheme.Controls.Add(this.AddBtn);
            this.MainTheme.Customization = "AAAA/w==";
            this.MainTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTheme.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MainTheme.Image = null;
            this.MainTheme.Location = new System.Drawing.Point(0, 0);
            this.MainTheme.Movable = true;
            this.MainTheme.Name = "MainTheme";
            this.MainTheme.NoRounding = false;
            this.MainTheme.Sizable = false;
            this.MainTheme.Size = new System.Drawing.Size(755, 478);
            this.MainTheme.SmartBounds = true;
            this.MainTheme.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MainTheme.TabIndex = 0;
            this.MainTheme.Text = "Exlude Types";
            this.MainTheme.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.MainTheme.Transparent = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Excluded Types:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Types:";
            // 
            // SearchExcludedTypes
            // 
            this.SearchExcludedTypes.Location = new System.Drawing.Point(607, 41);
            this.SearchExcludedTypes.Name = "SearchExcludedTypes";
            this.SearchExcludedTypes.Size = new System.Drawing.Size(144, 23);
            this.SearchExcludedTypes.TabIndex = 10;
            this.SearchExcludedTypes.TextChanged += new System.EventHandler(this.SearchExcludedTypes_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(545, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Search:";
            // 
            // ExcludedTypesList
            // 
            this.ExcludedTypesList.FormattingEnabled = true;
            this.ExcludedTypesList.ItemHeight = 15;
            this.ExcludedTypesList.Location = new System.Drawing.Point(381, 65);
            this.ExcludedTypesList.Name = "ExcludedTypesList";
            this.ExcludedTypesList.Size = new System.Drawing.Size(370, 334);
            this.ExcludedTypesList.TabIndex = 8;
            // 
            // SearchTypesTxt
            // 
            this.SearchTypesTxt.Location = new System.Drawing.Point(229, 41);
            this.SearchTypesTxt.Name = "SearchTypesTxt";
            this.SearchTypesTxt.Size = new System.Drawing.Size(144, 23);
            this.SearchTypesTxt.TabIndex = 7;
            this.SearchTypesTxt.TextChanged += new System.EventHandler(this.SearchTypesTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search:";
            // 
            // TypesList
            // 
            this.TypesList.FormattingEnabled = true;
            this.TypesList.ItemHeight = 15;
            this.TypesList.Location = new System.Drawing.Point(3, 65);
            this.TypesList.Name = "TypesList";
            this.TypesList.Size = new System.Drawing.Size(370, 334);
            this.TypesList.TabIndex = 5;
            this.TypesList.SelectedIndexChanged += new System.EventHandler(this.TypesList_SelectedIndexChanged);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Customization = "9fX1/6mpqf8=";
            this.CloseBtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.Image = null;
            this.CloseBtn.Location = new System.Drawing.Point(3, 443);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.NoRounding = false;
            this.CloseBtn.Size = new System.Drawing.Size(747, 31);
            this.CloseBtn.TabIndex = 4;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.Transparent = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Customization = "9fX1/6mpqf8=";
            this.RemoveBtn.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveBtn.Image = null;
            this.RemoveBtn.Location = new System.Drawing.Point(381, 405);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.NoRounding = false;
            this.RemoveBtn.Size = new System.Drawing.Size(369, 32);
            this.RemoveBtn.TabIndex = 2;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.Transparent = false;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Customization = "9fX1/6mpqf8=";
            this.AddBtn.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Image = null;
            this.AddBtn.Location = new System.Drawing.Point(3, 405);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.NoRounding = false;
            this.AddBtn.Size = new System.Drawing.Size(370, 32);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Add";
            this.AddBtn.Transparent = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ExcludeTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 478);
            this.Controls.Add(this.MainTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExcludeTypesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exclude Types";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.MainTheme.ResumeLayout(false);
            this.MainTheme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FormSkin.clsNeoBuxTheme MainTheme;
        private FormSkin.clsButtonPurple CloseBtn;
        private FormSkin.clsButtonOrange RemoveBtn;
        private FormSkin.clsButtonGreen AddBtn;
        private System.Windows.Forms.ListBox TypesList;
        private System.Windows.Forms.TextBox SearchTypesTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchExcludedTypes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ExcludedTypesList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}