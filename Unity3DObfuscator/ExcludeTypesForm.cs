using dnlib.DotNet;
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
    public partial class ExcludeTypesForm : Form
    {
        public ExcludeTypesForm()
        {
            InitializeComponent();
            TypesList.Items.Clear();
            ExcludedTypesList.Items.Clear();
            try
            {
                UpdateTypes();
                UpdateExcludedTypes();
            }
            catch
            {

            }
            TypesList.ScrollAlwaysVisible = true; //Sets the vertical scroll bar to be visible.
            ExcludedTypesList.ScrollAlwaysVisible = true; //...
            TypesList.HorizontalScrollbar = true; // Sets the horizontal scroll bar to be visible.
            ExcludedTypesList.HorizontalScrollbar = true; //...
        }
        void UpdateTypes() //Updates the types on the current assembly.
        {
            if (MainClass.MainModule == null)
            {
                return;
            }
            if (!MainClass.MainModule.HasTypes)
            {
                return;
            }
            TypesList.Sorted = true;
            foreach (TypeDef type in MainClass.MainModule.Types)
            {
                if (Exclusion.ExludedTypes.Contains(type.FullName))
                {
                    TypesList.Items.Remove(type.FullName);
                }
                if (!Exclusion.ExludedTypes.Contains(type.FullName))
                {
                    if (!TypesList.Items.Contains(type.FullName))
                    {
                        if (!type.Name.StartsWith("<") && !type.Name.EndsWith(">"))
                        {
                            if (!Exclusion.Types.Contains(type.FullName))
                            {
                                Exclusion.Types.Add(type.FullName);
                            }
                        }
                    }
                }
            }
            foreach (string type in Exclusion.Types)
            {
                if (!TypesList.Items.Contains(type))
                {
                    TypesList.Items.Add(type);
                }
            }
        }
        void ShowSearchedMatchTypes() //Shows only the types that the user searches for.
        {
            foreach (TypeDef type in MainClass.MainModule.Types)
            {
                if (Exclusion.ExludedTypes.Contains(type.FullName))
                {
                    TypesList.Items.Remove(type.FullName);
                }
                if (!TypesList.Items.Contains(type.FullName))
                {
                    if (!Exclusion.ExludedTypes.Contains(type.FullName))
                    {
                        if (!type.Name.StartsWith("<") && !type.Name.EndsWith(">"))
                        {
                            if (type.Name.ToLower().Contains(SearchTypesTxt.Text.ToLower()) || type.FullName.ToLower().Contains(SearchTypesTxt.Text.ToLower()))
                            {
                                TypesList.Items.Add(type.FullName);
                            }
                        }
                    }
                }
            }
        }
        void UpdateExcludedTypes() //Updates the excluded types that are currently on the exclusion list.
        {
            if (MainClass.MainModule == null)
            {
                return;
            }
            if (Exclusion.ExludedTypes.Count <= 0)
            {
                return;
            }
            ExcludedTypesList.Sorted = true;
            foreach (string type in Exclusion.ExludedTypes)
            {
                if (!ExcludedTypesList.Items.Contains(type))
                {
                    if (Exclusion.ExludedTypes.Contains(type))
                    {
                        ExcludedTypesList.Items.Add(type);
                    }
                    else
                    {
                        ExcludedTypesList.Items.Remove(type);
                    }
                }
            }
        }
        void ShowSearchedMatchExcludedTypes() //Shows only the excluded types that the user searches for.
        {
            foreach (string type in Exclusion.ExludedTypes)
            {
                if (!ExcludedTypesList.Items.Contains(type))
                {
                    if (type.ToLower().Contains(SearchExcludedTypes.Text.ToLower()))
                    {
                        ExcludedTypesList.Items.Add(type);
                    }
                }
            }
        }
        private void SearchTypesTxt_TextChanged(object sender, EventArgs e) //The function when the 'search type' text box changes text.
        {
            if (SearchTypesTxt.Text == string.Empty)
            {
                TypesList.Items.Clear();
                try
                {
                    UpdateTypes();
                }
                catch
                {
                }
            }
            else
            {
                TypesList.Items.Clear();
                try
                {
                    ShowSearchedMatchTypes();
                }
                catch
                {
                }
            }
        }
        private void SearchExcludedTypes_TextChanged(object sender, EventArgs e) //The function when the 'search excluded type' text box changes text.
        {
            if (SearchExcludedTypes.Text == string.Empty)
            {
                ExcludedTypesList.Items.Clear();
                try
                {
                    UpdateExcludedTypes();
                }
                catch
                {
                }
            }
            else
            {
                ExcludedTypesList.Items.Clear();
                try
                {
                    ShowSearchedMatchExcludedTypes();
                }
                catch
                {
                }
            }
        }
        private void TypesList_SelectedIndexChanged(object sender, EventArgs e) //Ignore this.
        {

        }
        private void AddBtn_Click(object sender, EventArgs e) //Adds the selected type to the exclusion list.
        {
            if (TypesList.SelectedIndex < 0)
            {
                return;
            }
            string item = TypesList.SelectedItem.ToString();
            if (!Exclusion.ExludedTypes.Contains(item))
            {
                Exclusion.ExludedTypes.Add(item);

            }
            if (!ExcludedTypesList.Items.Contains(item))
            {
                ExcludedTypesList.Items.Add(item);
            }
            if (ExcludedTypesList.Items.Contains(item))
            {
                Exclusion.Types.Remove(item);
                UpdateTypes();
                TypesList.Items.Remove(item);
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e) //Removes the selected type from the exclusion list.
        { 
            if (ExcludedTypesList.SelectedIndex < 0)
            {
                return;
            }
            string item = ExcludedTypesList.SelectedItem.ToString();
            if (Exclusion.ExludedTypes.Contains(item))
            {
                Exclusion.ExludedTypes.Remove(item);
            }
            TypesList.Items.Add(item);
            if (ExcludedTypesList.Items.Contains(item))
            {
                ExcludedTypesList.Items.Remove(item);
            }
            Exclusion.Types.Add(item);
            TypesList.Items.Clear();
            UpdateTypes();
        }

        private void CloseBtn_Click(object sender, EventArgs e) //Closes the form.
        {
            Close();
        }
    }
}
