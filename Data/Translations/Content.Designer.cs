﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data.Translations {
    using System;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Content {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Content() {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Resources.ResourceManager ResourceManager {
            get {
                if (object.Equals(null, resourceMan)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("Data.Translations.Content", typeof(Content).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        internal static string Currency {
            get {
                return ResourceManager.GetString("Currency", resourceCulture);
            }
        }
        
        internal static string ForBuying {
            get {
                return ResourceManager.GetString("ForBuying", resourceCulture);
            }
        }
        
        internal static string ForSelling {
            get {
                return ResourceManager.GetString("ForSelling", resourceCulture);
            }
        }
        
        internal static string Average {
            get {
                return ResourceManager.GetString("Average", resourceCulture);
            }
        }
        
        internal static string YouAreIn {
            get {
                return ResourceManager.GetString("YouAreIn", resourceCulture);
            }
        }
        
        internal static string Is {
            get {
                return ResourceManager.GetString("Is", resourceCulture);
            }
        }
        
        internal static string Countries {
            get {
                return ResourceManager.GetString("Countries", resourceCulture);
            }
        }
    }
}