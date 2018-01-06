using dnlib.DotNet;
using dnlib.DotNet.Emit;
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
    public partial class ExcludeStringsForm : Form
    {
        public ExcludeStringsForm()
        {
            InitializeComponent();
            StringsList.Items.Clear();
            ExcludedStringsList.Items.Clear();
            try
            {
                UpdateStrings();
                UpdateExludedStrings();
            }
            catch
            {

            }
            StringsList.ScrollAlwaysVisible = true; //Sets the vertical scroll bar to be visible.
            StringsList.HorizontalScrollbar = true; // Sets the horizontal scroll bar to be visible.
            ExcludedStringsList.ScrollAlwaysVisible = true; //...
            ExcludedStringsList.HorizontalScrollbar = true; //...
        }

        void UpdateStrings() //Updates the strings on the current assembly.
        {
            if (MainClass.MainModule == null)
            {
                return;
            }
            if (!MainClass.MainModule.HasTypes)
            {
                return;
            }
            StringsList.Sorted = true;
            foreach (TypeDef type in MainClass.MainModule.GetTypes())
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
                            if (Exclusion.ExcludedStrings.Contains(originalStr) || Exclusion.ExcludedStrings.Contains(originalStr))
                            {
                                StringsList.Items.Remove(originalStr);
                            }
                            if (!Exclusion.ExcludedStrings.Contains(originalStr))
                            {
                                if (!StringsList.Items.Contains(originalStr))
                                {
                                    if (!Exclusion.Strings.Contains(originalStr))
                                    {
                                        Exclusion.Strings.Add(originalStr);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            foreach (string str in Exclusion.Strings)
            {
                if (!StringsList.Items.Contains(str))
                {
                    StringsList.Items.Add(str);
                }
            }
        }
        void ShowSearchedMatchStrings() //Shows only the strings that the user searches for.
        {
            foreach (TypeDef type in MainClass.MainModule.GetTypes())
            {
                foreach (MethodDef method in type.Methods)
                {
                    if (!method.HasBody) continue;
                    var instr = method.Body.Instructions;
                    for (int i = 0; i < instr.Count - 3; i++)
                    {
                        if (instr[i].OpCode == OpCodes.Ldstr)
                        {
                            var originalStr = instr[i].Operand as string;
                            if (Exclusion.ExcludedStrings.Contains(originalStr))
                            {
                                StringsList.Items.Remove(originalStr);
                            }
                            if (!StringsList.Items.Contains(originalStr))
                            {
                                if (!Exclusion.ExcludedStrings.Contains(originalStr))
                                {
                                    if (originalStr.ToLower().Contains(SearchStringsTxt.Text.ToLower()) || originalStr.ToLower().Contains(SearchStringsTxt.Text.ToLower()))
                                    {
                                        StringsList.Items.Add(originalStr);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        void UpdateExludedStrings() //Updates the excluded strings that are currently on the exclusion list.
        {
            if (MainClass.MainModule == null)
            {
                return;
            }
            if (Exclusion.ExcludedStrings.Count <= 0)
            {
                return;
            }
            ExcludedStringsList.Sorted = true;
            foreach (string str in Exclusion.ExcludedStrings)
            {
                if (!ExcludedStringsList.Items.Contains(str))
                {
                    if (Exclusion.ExcludedStrings.Contains(str))
                    {
                        ExcludedStringsList.Items.Add(str);
                    }
                    else
                    {
                        ExcludedStringsList.Items.Remove(str);
                    }
                }
            }
        }
        void ShowSearchedMatchExcludedStings() ////Shows only the excluded strings that the user searches for.
        {
            foreach (string type in Exclusion.ExcludedStrings)
            {
                if (!ExcludedStringsList.Items.Contains(type))
                {
                    if (type.ToLower().Contains(SearchExcludedStringsTxt.Text.ToLower()))
                    {
                        ExcludedStringsList.Items.Add(type);
                    }
                }
            }
        }
        private void CloseBtn_Click(object sender, EventArgs e) //Closes the form.
        {
            Close();
        }

        private void AddBtn_Click(object sender, EventArgs e) //Adds the selected type to the exclusion list.
        {
            if (StringsList.SelectedIndex < 0)
            {
                return;
            }
            string item = StringsList.SelectedItem.ToString();
            if (!Exclusion.ExcludedStrings.Contains(item))
            {
                Exclusion.ExcludedStrings.Add(item);

            }
            if (!ExcludedStringsList.Items.Contains(item))
            {
                ExcludedStringsList.Items.Add(item);
            }
            if (ExcludedStringsList.Items.Contains(item))
            {
                Exclusion.Strings.Remove(item);
                UpdateStrings();
                StringsList.Items.Remove(item);
            }
        }

        private void SearchStringsTxt_TextChanged(object sender, EventArgs e) //The function when the 'search string' text box changes text.
        {
            if (SearchStringsTxt.Text == string.Empty)
            {
                StringsList.Items.Clear();
                try
                {
                    UpdateStrings();
                }
                catch
                {
                }
            }
            else
            {
                StringsList.Items.Clear();
                try
                {
                    ShowSearchedMatchStrings();
                }
                catch
                {
                }
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e) //Removes the selected type from the exclusion list.
        {
            if (ExcludedStringsList.SelectedIndex < 0)
            {
                return;
            }
            string item = ExcludedStringsList.SelectedItem.ToString();
            if (Exclusion.ExcludedStrings.Contains(item))
            {
                Exclusion.ExcludedStrings.Remove(item);
            }
            StringsList.Items.Add(item);
            if (ExcludedStringsList.Items.Contains(item))
            {
                ExcludedStringsList.Items.Remove(item);
            }
            Exclusion.Strings.Add(item);
            StringsList.Items.Clear();
            UpdateStrings();
        }

        private void SearchExcludedStringsTxt_TextChanged(object sender, EventArgs e) //The function when the 'search excluded string' text box changes text.
        {
            if (SearchExcludedStringsTxt.Text == string.Empty)
            {
                ExcludedStringsList.Items.Clear();
                try
                {
                    UpdateExludedStrings();
                }
                catch { }
            }
            else
            {
                ExcludedStringsList.Items.Clear();
                try
                {
                    ShowSearchedMatchExcludedStings();
                }
                catch { }
            }
        }
    }
}
