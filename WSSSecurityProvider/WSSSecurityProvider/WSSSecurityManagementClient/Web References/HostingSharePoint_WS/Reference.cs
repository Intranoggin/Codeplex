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

namespace MyLocalBroadband.WSSSecurityManagement.Client.HostingSharePoint_WS {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="SharePointServiceSoap", Namespace="http://www.mylocalbroadband.com/")]
    public partial class SharePointService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback hstCreateSiteOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public SharePointService() {
            this.Url = global::MyLocalBroadband.WSSSecurityManagement.Client.Properties.Settings.Default.MyLocalBroadband_WSSSecurityManagement_Client_HostingSharePoint_WS_SharePointService;
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
        public event hstCreateSiteCompletedEventHandler hstCreateSiteCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.mylocalbroadband.com/hstCreateSite", RequestNamespace="http://www.mylocalbroadband.com/", ResponseNamespace="http://www.mylocalbroadband.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void hstCreateSite(string webAppURL, string strURL, string strTitle, string strDesc, uint nLCID, string strTemplate, string strOwnerLogin1, string strOwnerName1, string strOwnerEmail1, string strOwnerLogin2, string strOwnerName2, string strOwnerEmail2, bool hhMode) {
            this.Invoke("hstCreateSite", new object[] {
                        webAppURL,
                        strURL,
                        strTitle,
                        strDesc,
                        nLCID,
                        strTemplate,
                        strOwnerLogin1,
                        strOwnerName1,
                        strOwnerEmail1,
                        strOwnerLogin2,
                        strOwnerName2,
                        strOwnerEmail2,
                        hhMode});
        }
        
        /// <remarks/>
        public void hstCreateSiteAsync(string webAppURL, string strURL, string strTitle, string strDesc, uint nLCID, string strTemplate, string strOwnerLogin1, string strOwnerName1, string strOwnerEmail1, string strOwnerLogin2, string strOwnerName2, string strOwnerEmail2, bool hhMode) {
            this.hstCreateSiteAsync(webAppURL, strURL, strTitle, strDesc, nLCID, strTemplate, strOwnerLogin1, strOwnerName1, strOwnerEmail1, strOwnerLogin2, strOwnerName2, strOwnerEmail2, hhMode, null);
        }
        
        /// <remarks/>
        public void hstCreateSiteAsync(string webAppURL, string strURL, string strTitle, string strDesc, uint nLCID, string strTemplate, string strOwnerLogin1, string strOwnerName1, string strOwnerEmail1, string strOwnerLogin2, string strOwnerName2, string strOwnerEmail2, bool hhMode, object userState) {
            if ((this.hstCreateSiteOperationCompleted == null)) {
                this.hstCreateSiteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnhstCreateSiteOperationCompleted);
            }
            this.InvokeAsync("hstCreateSite", new object[] {
                        webAppURL,
                        strURL,
                        strTitle,
                        strDesc,
                        nLCID,
                        strTemplate,
                        strOwnerLogin1,
                        strOwnerName1,
                        strOwnerEmail1,
                        strOwnerLogin2,
                        strOwnerName2,
                        strOwnerEmail2,
                        hhMode}, this.hstCreateSiteOperationCompleted, userState);
        }
        
        private void OnhstCreateSiteOperationCompleted(object arg) {
            if ((this.hstCreateSiteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.hstCreateSiteCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public delegate void hstCreateSiteCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591