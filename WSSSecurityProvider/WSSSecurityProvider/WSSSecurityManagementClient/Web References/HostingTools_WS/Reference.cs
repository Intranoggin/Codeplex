﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 2.0.50727.1433.
// 
#pragma warning disable 1591

namespace MyLocalBroadband.WSSSecurityManagement.Client.HostingTools_WS {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="HostingToolsSoap", Namespace="http://www.mylocalbroadband.com/")]
    public partial class HostingTools : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback CreateNewSiteNewSQLOwnerOperationCompleted;
        
        private System.Threading.SendOrPostCallback CreateNewSiteExistingSQLOwnerOperationCompleted;
        
        private System.Threading.SendOrPostCallback CreateDNSOperationCompleted;
        
        private System.Threading.SendOrPostCallback DNSExistsOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public HostingTools() {
            this.Url = global::MyLocalBroadband.WSSSecurityManagement.Client.Properties.Settings.Default.MyLocalBroadband_WSSSecurityManagement_Client_HostingTools_WS_HostingTools;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event CreateNewSiteNewSQLOwnerCompletedEventHandler CreateNewSiteNewSQLOwnerCompleted;
        
        /// <remarks/>
        public event CreateNewSiteExistingSQLOwnerCompletedEventHandler CreateNewSiteExistingSQLOwnerCompleted;
        
        /// <remarks/>
        public event CreateDNSCompletedEventHandler CreateDNSCompleted;
        
        /// <remarks/>
        public event DNSExistsCompletedEventHandler DNSExistsCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.mylocalbroadband.com/CreateNewSiteNewSQLOwner", RequestNamespace="http://www.mylocalbroadband.com/", ResponseNamespace="http://www.mylocalbroadband.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void CreateNewSiteNewSQLOwner(string SiteUrl, string SiteTitle, string SiteDescription, string SiteTemplate, string OwnerFirstName, string OwnerLastName, string OwnerLogin, string OwnerPassword, string PwdQuestion, string PwdAnswer, string OwnerEmail, string AppName, string WebAppUrl, string ProviderName, uint nLCID) {
            this.Invoke("CreateNewSiteNewSQLOwner", new object[] {
                        SiteUrl,
                        SiteTitle,
                        SiteDescription,
                        SiteTemplate,
                        OwnerFirstName,
                        OwnerLastName,
                        OwnerLogin,
                        OwnerPassword,
                        PwdQuestion,
                        PwdAnswer,
                        OwnerEmail,
                        AppName,
                        WebAppUrl,
                        ProviderName,
                        nLCID});
        }
        
        /// <remarks/>
        public void CreateNewSiteNewSQLOwnerAsync(string SiteUrl, string SiteTitle, string SiteDescription, string SiteTemplate, string OwnerFirstName, string OwnerLastName, string OwnerLogin, string OwnerPassword, string PwdQuestion, string PwdAnswer, string OwnerEmail, string AppName, string WebAppUrl, string ProviderName, uint nLCID) {
            this.CreateNewSiteNewSQLOwnerAsync(SiteUrl, SiteTitle, SiteDescription, SiteTemplate, OwnerFirstName, OwnerLastName, OwnerLogin, OwnerPassword, PwdQuestion, PwdAnswer, OwnerEmail, AppName, WebAppUrl, ProviderName, nLCID, null);
        }
        
        /// <remarks/>
        public void CreateNewSiteNewSQLOwnerAsync(
                    string SiteUrl, 
                    string SiteTitle, 
                    string SiteDescription, 
                    string SiteTemplate, 
                    string OwnerFirstName, 
                    string OwnerLastName, 
                    string OwnerLogin, 
                    string OwnerPassword, 
                    string PwdQuestion, 
                    string PwdAnswer, 
                    string OwnerEmail, 
                    string AppName, 
                    string WebAppUrl, 
                    string ProviderName, 
                    uint nLCID, 
                    object userState) {
            if ((this.CreateNewSiteNewSQLOwnerOperationCompleted == null)) {
                this.CreateNewSiteNewSQLOwnerOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateNewSiteNewSQLOwnerOperationCompleted);
            }
            this.InvokeAsync("CreateNewSiteNewSQLOwner", new object[] {
                        SiteUrl,
                        SiteTitle,
                        SiteDescription,
                        SiteTemplate,
                        OwnerFirstName,
                        OwnerLastName,
                        OwnerLogin,
                        OwnerPassword,
                        PwdQuestion,
                        PwdAnswer,
                        OwnerEmail,
                        AppName,
                        WebAppUrl,
                        ProviderName,
                        nLCID}, this.CreateNewSiteNewSQLOwnerOperationCompleted, userState);
        }
        
        private void OnCreateNewSiteNewSQLOwnerOperationCompleted(object arg) {
            if ((this.CreateNewSiteNewSQLOwnerCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateNewSiteNewSQLOwnerCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.mylocalbroadband.com/CreateNewSiteExistingSQLOwner", RequestNamespace="http://www.mylocalbroadband.com/", ResponseNamespace="http://www.mylocalbroadband.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void CreateNewSiteExistingSQLOwner(string SiteUrl, string SiteTitle, string SiteDescription, string SiteTemplate, string OwnerLogin, string AppName, string WebAppUrl, string ProviderName, uint nLCID) {
            this.Invoke("CreateNewSiteExistingSQLOwner", new object[] {
                        SiteUrl,
                        SiteTitle,
                        SiteDescription,
                        SiteTemplate,
                        OwnerLogin,
                        AppName,
                        WebAppUrl,
                        ProviderName,
                        nLCID});
        }
        
        /// <remarks/>
        public void CreateNewSiteExistingSQLOwnerAsync(string SiteUrl, string SiteTitle, string SiteDescription, string SiteTemplate, string OwnerLogin, string AppName, string WebAppUrl, string ProviderName, uint nLCID) {
            this.CreateNewSiteExistingSQLOwnerAsync(SiteUrl, SiteTitle, SiteDescription, SiteTemplate, OwnerLogin, AppName, WebAppUrl, ProviderName, nLCID, null);
        }
        
        /// <remarks/>
        public void CreateNewSiteExistingSQLOwnerAsync(string SiteUrl, string SiteTitle, string SiteDescription, string SiteTemplate, string OwnerLogin, string AppName, string WebAppUrl, string ProviderName, uint nLCID, object userState) {
            if ((this.CreateNewSiteExistingSQLOwnerOperationCompleted == null)) {
                this.CreateNewSiteExistingSQLOwnerOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateNewSiteExistingSQLOwnerOperationCompleted);
            }
            this.InvokeAsync("CreateNewSiteExistingSQLOwner", new object[] {
                        SiteUrl,
                        SiteTitle,
                        SiteDescription,
                        SiteTemplate,
                        OwnerLogin,
                        AppName,
                        WebAppUrl,
                        ProviderName,
                        nLCID}, this.CreateNewSiteExistingSQLOwnerOperationCompleted, userState);
        }
        
        private void OnCreateNewSiteExistingSQLOwnerOperationCompleted(object arg) {
            if ((this.CreateNewSiteExistingSQLOwnerCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateNewSiteExistingSQLOwnerCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.mylocalbroadband.com/CreateDNS", RequestNamespace="http://www.mylocalbroadband.com/", ResponseNamespace="http://www.mylocalbroadband.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void CreateDNS(string domainName, string IPAddress) {
            this.Invoke("CreateDNS", new object[] {
                        domainName,
                        IPAddress});
        }
        
        /// <remarks/>
        public void CreateDNSAsync(string domainName, string IPAddress) {
            this.CreateDNSAsync(domainName, IPAddress, null);
        }
        
        /// <remarks/>
        public void CreateDNSAsync(string domainName, string IPAddress, object userState) {
            if ((this.CreateDNSOperationCompleted == null)) {
                this.CreateDNSOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateDNSOperationCompleted);
            }
            this.InvokeAsync("CreateDNS", new object[] {
                        domainName,
                        IPAddress}, this.CreateDNSOperationCompleted, userState);
        }
        
        private void OnCreateDNSOperationCompleted(object arg) {
            if ((this.CreateDNSCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateDNSCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.mylocalbroadband.com/DNSExists", RequestNamespace="http://www.mylocalbroadband.com/", ResponseNamespace="http://www.mylocalbroadband.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool DNSExists(string domainName) {
            object[] results = this.Invoke("DNSExists", new object[] {
                        domainName});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void DNSExistsAsync(string domainName) {
            this.DNSExistsAsync(domainName, null);
        }
        
        /// <remarks/>
        public void DNSExistsAsync(string domainName, object userState) {
            if ((this.DNSExistsOperationCompleted == null)) {
                this.DNSExistsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDNSExistsOperationCompleted);
            }
            this.InvokeAsync("DNSExists", new object[] {
                        domainName}, this.DNSExistsOperationCompleted, userState);
        }
        
        private void OnDNSExistsOperationCompleted(object arg) {
            if ((this.DNSExistsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DNSExistsCompleted(this, new DNSExistsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")]
    public delegate void CreateNewSiteNewSQLOwnerCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")]
    public delegate void CreateNewSiteExistingSQLOwnerCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")]
    public delegate void CreateDNSCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")]
    public delegate void DNSExistsCompletedEventHandler(object sender, DNSExistsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DNSExistsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DNSExistsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591