﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebServiceKatodikSoap")]
    public interface WebServiceKatodikSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> HelloWorldAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SinyalGetir", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference1.SinyalGetirResponse> SinyalGetirAsync(ServiceReference1.SinyalGetirRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SebekeArizaGetir", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference1.SebekeArizaGetirResponse> SebekeArizaGetirAsync(ServiceReference1.SebekeArizaGetirRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TumArizaGetir", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference1.TumArizaGetirResponse> TumArizaGetirAsync(ServiceReference1.TumArizaGetirRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/KatodikKorumaArizaGetir", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference1.KatodikKorumaArizaGetirResponse> KatodikKorumaArizaGetirAsync(ServiceReference1.KatodikKorumaArizaGetirRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListeGetir", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference1.ListeGetirResponse> ListeGetirAsync(ServiceReference1.ListeGetirRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/istasyonGetir", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference1.istasyonGetirResponse> istasyonGetirAsync(ServiceReference1.istasyonGetirRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class AuthHeader
    {
        
        private string userNameField;
        
        private string passwordField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string UserName
        {
            get
            {
                return this.userNameField;
            }
            set
            {
                this.userNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/")]
    public partial class SinyalGetirResponseSinyalGetirResult
    {
        
        private System.Xml.XmlElement[] anyField;
        
        private System.Xml.XmlElement any1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="http://www.w3.org/2001/XMLSchema", Order=0)]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="urn:schemas-microsoft-com:xml-diffgram-v1", Order=1)]
        public System.Xml.XmlElement Any1
        {
            get
            {
                return this.any1Field;
            }
            set
            {
                this.any1Field = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SinyalGetir", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SinyalGetirRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public ServiceReference1.AuthHeader AuthHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string parentID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string yil;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string ay;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public string gun;
        
        public SinyalGetirRequest()
        {
        }
        
        public SinyalGetirRequest(ServiceReference1.AuthHeader AuthHeader, string parentID, string yil, string ay, string gun)
        {
            this.AuthHeader = AuthHeader;
            this.parentID = parentID;
            this.yil = yil;
            this.ay = ay;
            this.gun = gun;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SinyalGetirResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SinyalGetirResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference1.SinyalGetirResponseSinyalGetirResult SinyalGetirResult;
        
        public SinyalGetirResponse()
        {
        }
        
        public SinyalGetirResponse(ServiceReference1.SinyalGetirResponseSinyalGetirResult SinyalGetirResult)
        {
            this.SinyalGetirResult = SinyalGetirResult;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/")]
    public partial class SebekeArizaGetirResponseSebekeArizaGetirResult
    {
        
        private System.Xml.XmlElement[] anyField;
        
        private System.Xml.XmlElement any1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="http://www.w3.org/2001/XMLSchema", Order=0)]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="urn:schemas-microsoft-com:xml-diffgram-v1", Order=1)]
        public System.Xml.XmlElement Any1
        {
            get
            {
                return this.any1Field;
            }
            set
            {
                this.any1Field = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SebekeArizaGetir", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SebekeArizaGetirRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public ServiceReference1.AuthHeader AuthHeader;
        
        public SebekeArizaGetirRequest()
        {
        }
        
        public SebekeArizaGetirRequest(ServiceReference1.AuthHeader AuthHeader)
        {
            this.AuthHeader = AuthHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SebekeArizaGetirResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SebekeArizaGetirResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference1.SebekeArizaGetirResponseSebekeArizaGetirResult SebekeArizaGetirResult;
        
        public SebekeArizaGetirResponse()
        {
        }
        
        public SebekeArizaGetirResponse(ServiceReference1.SebekeArizaGetirResponseSebekeArizaGetirResult SebekeArizaGetirResult)
        {
            this.SebekeArizaGetirResult = SebekeArizaGetirResult;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/")]
    public partial class TumArizaGetirResponseTumArizaGetirResult
    {
        
        private System.Xml.XmlElement[] anyField;
        
        private System.Xml.XmlElement any1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="http://www.w3.org/2001/XMLSchema", Order=0)]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="urn:schemas-microsoft-com:xml-diffgram-v1", Order=1)]
        public System.Xml.XmlElement Any1
        {
            get
            {
                return this.any1Field;
            }
            set
            {
                this.any1Field = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="TumArizaGetir", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class TumArizaGetirRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public ServiceReference1.AuthHeader AuthHeader;
        
        public TumArizaGetirRequest()
        {
        }
        
        public TumArizaGetirRequest(ServiceReference1.AuthHeader AuthHeader)
        {
            this.AuthHeader = AuthHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="TumArizaGetirResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class TumArizaGetirResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference1.TumArizaGetirResponseTumArizaGetirResult TumArizaGetirResult;
        
        public TumArizaGetirResponse()
        {
        }
        
        public TumArizaGetirResponse(ServiceReference1.TumArizaGetirResponseTumArizaGetirResult TumArizaGetirResult)
        {
            this.TumArizaGetirResult = TumArizaGetirResult;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/")]
    public partial class KatodikKorumaArizaGetirResponseKatodikKorumaArizaGetirResult
    {
        
        private System.Xml.XmlElement[] anyField;
        
        private System.Xml.XmlElement any1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="http://www.w3.org/2001/XMLSchema", Order=0)]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="urn:schemas-microsoft-com:xml-diffgram-v1", Order=1)]
        public System.Xml.XmlElement Any1
        {
            get
            {
                return this.any1Field;
            }
            set
            {
                this.any1Field = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="KatodikKorumaArizaGetir", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class KatodikKorumaArizaGetirRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public ServiceReference1.AuthHeader AuthHeader;
        
        public KatodikKorumaArizaGetirRequest()
        {
        }
        
        public KatodikKorumaArizaGetirRequest(ServiceReference1.AuthHeader AuthHeader)
        {
            this.AuthHeader = AuthHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="KatodikKorumaArizaGetirResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class KatodikKorumaArizaGetirResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference1.KatodikKorumaArizaGetirResponseKatodikKorumaArizaGetirResult KatodikKorumaArizaGetirResult;
        
        public KatodikKorumaArizaGetirResponse()
        {
        }
        
        public KatodikKorumaArizaGetirResponse(ServiceReference1.KatodikKorumaArizaGetirResponseKatodikKorumaArizaGetirResult KatodikKorumaArizaGetirResult)
        {
            this.KatodikKorumaArizaGetirResult = KatodikKorumaArizaGetirResult;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/")]
    public partial class ListeGetirResponseListeGetirResult
    {
        
        private System.Xml.XmlElement[] anyField;
        
        private System.Xml.XmlElement any1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="http://www.w3.org/2001/XMLSchema", Order=0)]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="urn:schemas-microsoft-com:xml-diffgram-v1", Order=1)]
        public System.Xml.XmlElement Any1
        {
            get
            {
                return this.any1Field;
            }
            set
            {
                this.any1Field = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListeGetir", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ListeGetirRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public ServiceReference1.AuthHeader AuthHeader;
        
        public ListeGetirRequest()
        {
        }
        
        public ListeGetirRequest(ServiceReference1.AuthHeader AuthHeader)
        {
            this.AuthHeader = AuthHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ListeGetirResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ListeGetirResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference1.ListeGetirResponseListeGetirResult ListeGetirResult;
        
        public ListeGetirResponse()
        {
        }
        
        public ListeGetirResponse(ServiceReference1.ListeGetirResponseListeGetirResult ListeGetirResult)
        {
            this.ListeGetirResult = ListeGetirResult;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/")]
    public partial class istasyonGetirResponseIstasyonGetirResult
    {
        
        private System.Xml.XmlElement[] anyField;
        
        private System.Xml.XmlElement any1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="http://www.w3.org/2001/XMLSchema", Order=0)]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="urn:schemas-microsoft-com:xml-diffgram-v1", Order=1)]
        public System.Xml.XmlElement Any1
        {
            get
            {
                return this.any1Field;
            }
            set
            {
                this.any1Field = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="istasyonGetir", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class istasyonGetirRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public ServiceReference1.AuthHeader AuthHeader;
        
        public istasyonGetirRequest()
        {
        }
        
        public istasyonGetirRequest(ServiceReference1.AuthHeader AuthHeader)
        {
            this.AuthHeader = AuthHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="istasyonGetirResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class istasyonGetirResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference1.istasyonGetirResponseIstasyonGetirResult istasyonGetirResult;
        
        public istasyonGetirResponse()
        {
        }
        
        public istasyonGetirResponse(ServiceReference1.istasyonGetirResponseIstasyonGetirResult istasyonGetirResult)
        {
            this.istasyonGetirResult = istasyonGetirResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public interface WebServiceKatodikSoapChannel : ServiceReference1.WebServiceKatodikSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class WebServiceKatodikSoapClient : System.ServiceModel.ClientBase<ServiceReference1.WebServiceKatodikSoap>, ServiceReference1.WebServiceKatodikSoap
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public WebServiceKatodikSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(WebServiceKatodikSoapClient.GetBindingForEndpoint(endpointConfiguration), WebServiceKatodikSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WebServiceKatodikSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(WebServiceKatodikSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WebServiceKatodikSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(WebServiceKatodikSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WebServiceKatodikSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<string> HelloWorldAsync()
        {
            return base.Channel.HelloWorldAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.SinyalGetirResponse> ServiceReference1.WebServiceKatodikSoap.SinyalGetirAsync(ServiceReference1.SinyalGetirRequest request)
        {
            return base.Channel.SinyalGetirAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.SinyalGetirResponse> SinyalGetirAsync(ServiceReference1.AuthHeader AuthHeader, string parentID, string yil, string ay, string gun)
        {
            ServiceReference1.SinyalGetirRequest inValue = new ServiceReference1.SinyalGetirRequest();
            inValue.AuthHeader = AuthHeader;
            inValue.parentID = parentID;
            inValue.yil = yil;
            inValue.ay = ay;
            inValue.gun = gun;
            return ((ServiceReference1.WebServiceKatodikSoap)(this)).SinyalGetirAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.SebekeArizaGetirResponse> ServiceReference1.WebServiceKatodikSoap.SebekeArizaGetirAsync(ServiceReference1.SebekeArizaGetirRequest request)
        {
            return base.Channel.SebekeArizaGetirAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.SebekeArizaGetirResponse> SebekeArizaGetirAsync(ServiceReference1.AuthHeader AuthHeader)
        {
            ServiceReference1.SebekeArizaGetirRequest inValue = new ServiceReference1.SebekeArizaGetirRequest();
            inValue.AuthHeader = AuthHeader;
            return ((ServiceReference1.WebServiceKatodikSoap)(this)).SebekeArizaGetirAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.TumArizaGetirResponse> ServiceReference1.WebServiceKatodikSoap.TumArizaGetirAsync(ServiceReference1.TumArizaGetirRequest request)
        {
            return base.Channel.TumArizaGetirAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.TumArizaGetirResponse> TumArizaGetirAsync(ServiceReference1.AuthHeader AuthHeader)
        {
            ServiceReference1.TumArizaGetirRequest inValue = new ServiceReference1.TumArizaGetirRequest();
            inValue.AuthHeader = AuthHeader;
            return ((ServiceReference1.WebServiceKatodikSoap)(this)).TumArizaGetirAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.KatodikKorumaArizaGetirResponse> ServiceReference1.WebServiceKatodikSoap.KatodikKorumaArizaGetirAsync(ServiceReference1.KatodikKorumaArizaGetirRequest request)
        {
            return base.Channel.KatodikKorumaArizaGetirAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.KatodikKorumaArizaGetirResponse> KatodikKorumaArizaGetirAsync(ServiceReference1.AuthHeader AuthHeader)
        {
            ServiceReference1.KatodikKorumaArizaGetirRequest inValue = new ServiceReference1.KatodikKorumaArizaGetirRequest();
            inValue.AuthHeader = AuthHeader;
            return ((ServiceReference1.WebServiceKatodikSoap)(this)).KatodikKorumaArizaGetirAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.ListeGetirResponse> ServiceReference1.WebServiceKatodikSoap.ListeGetirAsync(ServiceReference1.ListeGetirRequest request)
        {
            return base.Channel.ListeGetirAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.ListeGetirResponse> ListeGetirAsync(ServiceReference1.AuthHeader AuthHeader)
        {
            ServiceReference1.ListeGetirRequest inValue = new ServiceReference1.ListeGetirRequest();
            inValue.AuthHeader = AuthHeader;
            return ((ServiceReference1.WebServiceKatodikSoap)(this)).ListeGetirAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.istasyonGetirResponse> ServiceReference1.WebServiceKatodikSoap.istasyonGetirAsync(ServiceReference1.istasyonGetirRequest request)
        {
            return base.Channel.istasyonGetirAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.istasyonGetirResponse> istasyonGetirAsync(ServiceReference1.AuthHeader AuthHeader)
        {
            ServiceReference1.istasyonGetirRequest inValue = new ServiceReference1.istasyonGetirRequest();
            inValue.AuthHeader = AuthHeader;
            return ((ServiceReference1.WebServiceKatodikSoap)(this)).istasyonGetirAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.WebServiceKatodikSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.WebServiceKatodikSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpsTransportBindingElement httpsBindingElement = new System.ServiceModel.Channels.HttpsTransportBindingElement();
                httpsBindingElement.AllowCookies = true;
                httpsBindingElement.MaxBufferSize = int.MaxValue;
                httpsBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpsBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.WebServiceKatodikSoap))
            {
                return new System.ServiceModel.EndpointAddress("https://dis.botas.gov.tr/ws/WebServiceKatodik.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.WebServiceKatodikSoap12))
            {
                return new System.ServiceModel.EndpointAddress("https://dis.botas.gov.tr/ws/WebServiceKatodik.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            WebServiceKatodikSoap,
            
            WebServiceKatodikSoap12,
        }
    }
}
