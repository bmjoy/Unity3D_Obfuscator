using dnlib.DotNet;
using System.Collections.Generic;

namespace Unity3DObfuscator
{
    //The renaming class.
    public class RenamingClass
    {
        public void RenameNamespaces() //Renames the namespaces. It doesn't rename a namespace of a type if the type is excluded.
        {
            if (!MainClass.Settings.RenameNamespaces)
            {
                return;
            }
            foreach (TypeDef type in MainClass.MainModule.Types)
            {
                if (TypeExists(type))
                {
                    if (!Exclusion.ExludedTypes.Contains(type.FullName))
                    {
                        if (IsMonoType(type))
                        {
                            continue;
                        }
                        else
                        {
                            type.Namespace = GlobalStrings.RandomString;
                        }
                    }
                }
            }
        }
        public void RenameTypes() //Renames the types. It doesn't rename the types that are excluded or have 'MonoBehaviour' as BaseType.
        {
            if (!MainClass.Settings.RenameTypes)
            {
                return;
            }
            foreach (TypeDef type in MainClass.MainModule.Types)
            {
                if (TypeExists(type))
                {
                    if (!Exclusion.ExludedTypes.Contains(type.FullName))
                    {
                        if(IsMonoType(type))
                        {
                            continue;
                        }
                        else
                        {
                            type.Name = GlobalStrings.RenamingString;
                        }
                        foreach (TypeDef nestedType in type.NestedTypes)
                        {
                            if (TypeExists(nestedType))
                            {
                                nestedType.Name = GlobalStrings.RenamingString;
                            }
                        }
                    }
                }
            }
        }
        public void RenameMethods() //Renames the methods. It doesn't rename the methods that their type is excluded or are execution functions in Unity. Example: Start, Update, OnGUI, etc...
        {
            if (!MainClass.Settings.RenameMethods)
            {
                return;
            }
            foreach (TypeDef type in MainClass.MainModule.Types)
            {
                if (TypeExists(type))
                {
                    if (!Exclusion.ExludedTypes.Contains(type.FullName))
                    {
                        foreach (MethodDef method in type.Methods)
                        {
                            if (MethodExists(type, method))
                            {
                                if (method.Name != ".ctor" && method.Name != ".cctor")
                                {
                                    if (IsMonoType(type))
                                    {
                                        if (!Exclusion.UnityFunctions.Contains(method.Name))
                                        {
                                            method.Name = GlobalStrings.RenamingString;
                                        }
                                    }
                                    else
                                    {
                                        method.Name = GlobalStrings.RenamingString;
                                    }
                                    if (method.HasParamDefs)
                                    {
                                        foreach (ParamDef pr in method.ParamDefs)
                                        {
                                            if (pr == null)
                                            {
                                                return;
                                            }
                                            pr.Name = GlobalStrings.RandomString;
                                        }
                                    }
                                }
                            }
                            KeepOldMaxStack(method); //Keeps the old MaxStack.
                        }
                    }
                }
            }
        }
        public void RenameFields() //Renames the fields. It doesn't rename the fields that their type is excluded.
        {
            if (!MainClass.Settings.RenameFields)
            {
                return;
            }
            foreach (TypeDef type in MainClass.MainModule.Types)
            {
                if (TypeExists(type))
                {
                    if (!Exclusion.ExludedTypes.Contains(type.FullName))
                    {
                        foreach (FieldDef field in type.Fields)
                        {
                            if (FieldExists(type, field))
                            {
                                field.Name = GlobalStrings.RenamingString;
                            }
                        }
                        foreach (TypeDef nestedType in type.NestedTypes)
                        {
                            if (TypeExists(nestedType))
                            {
                                foreach (FieldDef field in nestedType.Fields)
                                {
                                    if (FieldExists(nestedType, field))
                                    {
                                        field.Name = GlobalStrings.RenamingString;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        public void RenameProperties() //Renames the properties. It doesn't rename the properties that their type is excluded.
        {
            if (!MainClass.Settings.RenameProperties)
            {
                return;
            }
            foreach (TypeDef type in MainClass.MainModule.Types)
            {
                if (TypeExists(type))
                {
                    if (!Exclusion.ExludedTypes.Contains(type.FullName))
                    {
                        foreach (PropertyDef property in type.Properties)
                        {
                            if (PropertyExists(type, property))
                            {
                                property.Name = GlobalStrings.RenamingString;
                            }
                        }
                        foreach (TypeDef nestedType in type.NestedTypes)
                        {
                            if (TypeExists(nestedType))
                            {
                                foreach (PropertyDef property in nestedType.Properties)
                                {
                                    if (PropertyExists(nestedType, property))
                                    {
                                        property.Name = GlobalStrings.RenamingString;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void KeepOldMaxStack(MethodDef method) //Keeps the old MaxStack of every method.
        {
            if (method != null)
            {
                if (method.HasBody)
                {
                    if (!method.Body.KeepOldMaxStack)
                    {
                        method.Body.KeepOldMaxStack = true;
                    }
                }
            }
        }
        private TypeDef FindType(string typeName) //I made this functions that finds the Type by their name.
        {
            foreach (TypeDef type in MainClass.MainModule.Types)
            {
                if (type.Name == typeName)
                {
                    return type;
                }
            }
            return null;
        }
        private bool TypeExists(TypeDef type) //Checks if the type exists.
        {
            return (type != null && MainClass.MainModule.HasTypes && !type.IsGlobalModuleType && (!type.Name.StartsWith("<") && !type.Name.EndsWith(">")));
        }
        private bool MethodExists(TypeDef type, MethodDef method) //Checks if the method exists.
        {
            return (method != null && !type.IsGlobalModuleType && (!type.Name.StartsWith("<") && !type.Name.EndsWith(">")) && type.HasMethods && method != null && method.HasBody && !method.IsVirtual);
        }
        private bool FieldExists(TypeDef type, FieldDef field) //Checks if the field exists.
        {
            return (type != null && !type.IsGlobalModuleType && (!type.Name.StartsWith("<") && !type.Name.EndsWith(">")) && type.HasFields && field != null);
        }
        private bool PropertyExists(TypeDef type, PropertyDef property) //Checks if the property exists.
        {
            return (type != null && !type.IsGlobalModuleType && (!type.Name.StartsWith("<") && !type.Name.EndsWith(">")) && type.HasProperties && property != null);
        }
        private bool IsMonoType(TypeDef type) //Checks if the type is a 'MonoBehaviour' type. which most of the time a 'MonoBehaviour' type is a script of the game and it won't work if the type gets renamed.
        {
            List<TypeDef> monoTypes = new List<TypeDef>(new TypeDef[0]);
            if (type.BaseType != null && type.BaseType.TypeName == "MonoBehaviour")
            {
                if (!monoTypes.Contains(type))
                {
                    monoTypes.Add(type);
                }
            }
            TypeDef bType2 = null;
            TypeDef bType3 = null;
            TypeDef bType4 = null;
            TypeDef bType5 = null;
            if (type.BaseType != null)
            {
                bType2 = FindType(type.BaseType.TypeName);
            }
            if (bType2 != null && bType2.BaseType != null)
            {
                bType3 = FindType(bType2.BaseType.TypeName);
            }
            if (bType3 != null && bType3.BaseType != null)
            {
                bType4 = FindType(bType2.BaseType.TypeName);
            }
            if (bType4 != null && bType4.BaseType != null)
            {
                bType5 = FindType(bType2.BaseType.TypeName);
            }
            return ((type.BaseType != null && type.BaseType.TypeName == "MonoBehaviour") || (monoTypes.Contains(type)) || (FindType(type.BaseType.TypeName) != null && monoTypes.Contains(FindType(type.BaseType.TypeName))) || (type.BaseType != null && type.BaseType.TypeName == "MonoBehaviour") || ((bType2 != null && bType2.BaseType.TypeName == "MonoBehaviour") || (bType3 != null && bType3.BaseType.TypeName == "MonoBehaviour") || (bType4 != null && bType4.BaseType.TypeName == "MonoBehaviour") || (bType5 != null && bType5.BaseType.TypeName == "MonoBehaviour")));
        }
    }
}