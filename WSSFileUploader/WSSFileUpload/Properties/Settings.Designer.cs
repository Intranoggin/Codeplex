﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WSSFileUpload.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://www.mylocalbroadband.com/_vti_bin/Authentication.asmx")]
        public string WSSFileUpload_Authentication_ws_Authentication {
            get {
                return ((string)(this["WSSFileUpload_Authentication_ws_Authentication"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://www.mylocalbroadband.com/_vti_bin/Copy.asmx")]
        public string WSSFileUpload_Copy_ws_Copy {
            get {
                return ((string)(this["WSSFileUpload_Copy_ws_Copy"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("testUser")]
        public string UserNameDefault {
            get {
                return ((string)(this["UserNameDefault"]));
            }
            set {
                this["UserNameDefault"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("!testuser!")]
        public string PasswordDefault {
            get {
                return ((string)(this["PasswordDefault"]));
            }
            set {
                this["PasswordDefault"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://www.mylocalbroadband.com/customers")]
        public string SiteURLDefault {
            get {
                return ((string)(this["SiteURLDefault"]));
            }
            set {
                this["SiteURLDefault"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Shared%20Documents")]
        public string LibraryDefault {
            get {
                return ((string)(this["LibraryDefault"]));
            }
            set {
                this["LibraryDefault"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\logs\\log.txt;C:\\logs\\log1.txt")]
        public string FilesDefault {
            get {
                return ((string)(this["FilesDefault"]));
            }
            set {
                this["FilesDefault"] = value;
            }
        }
    }
}