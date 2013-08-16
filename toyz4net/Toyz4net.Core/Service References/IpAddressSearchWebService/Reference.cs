﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:2.0.50727.3623
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Toyz4net.Core.IpAddressSearchWebService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://WebXml.com.cn/", ConfigurationName="IpAddressSearchWebService.IpAddressSearchWebServiceSoap")]
    public interface IpAddressSearchWebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebXml.com.cn/getCountryCityByIp", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        string[] getCountryCityByIp(string theIpAddress);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebXml.com.cn/getGeoIPContext", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        string[] getGeoIPContext();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebXml.com.cn/getVersionTime", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        string getVersionTime();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IpAddressSearchWebServiceSoapChannel : Toyz4net.Core.IpAddressSearchWebService.IpAddressSearchWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class IpAddressSearchWebServiceSoapClient : System.ServiceModel.ClientBase<Toyz4net.Core.IpAddressSearchWebService.IpAddressSearchWebServiceSoap>, Toyz4net.Core.IpAddressSearchWebService.IpAddressSearchWebServiceSoap {
        
        public IpAddressSearchWebServiceSoapClient() {
        }
        
        public IpAddressSearchWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IpAddressSearchWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IpAddressSearchWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IpAddressSearchWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] getCountryCityByIp(string theIpAddress) {
            return base.Channel.getCountryCityByIp(theIpAddress);
        }
        
        public string[] getGeoIPContext() {
            return base.Channel.getGeoIPContext();
        }
        
        public string getVersionTime() {
            return base.Channel.getVersionTime();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://WebXml.com.cn/", ConfigurationName="IpAddressSearchWebService.IpAddressSearchWebServiceHttpGet")]
    public interface IpAddressSearchWebServiceHttpGet {
        
        // CODEGEN: 操作 getCountryCityByIp 以后生成的消息协定不是 RPC，也不是换行文档。
        [System.ServiceModel.OperationContractAttribute(Action="http://WebXml.com.cn/IpAddressSearchWebServiceHttpGet/getCountryCityByIpRequest", ReplyAction="http://WebXml.com.cn/IpAddressSearchWebServiceHttpGet/getCountryCityByIpResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        Toyz4net.Core.IpAddressSearchWebService.getCountryCityByIpResponse getCountryCityByIp(Toyz4net.Core.IpAddressSearchWebService.getCountryCityByIpRequest request);
        
        // CODEGEN: 操作 getGeoIPContext 以后生成的消息协定不是 RPC，也不是换行文档。
        [System.ServiceModel.OperationContractAttribute(Action="http://WebXml.com.cn/IpAddressSearchWebServiceHttpGet/getGeoIPContextRequest", ReplyAction="http://WebXml.com.cn/IpAddressSearchWebServiceHttpGet/getGeoIPContextResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        Toyz4net.Core.IpAddressSearchWebService.getGeoIPContextResponse getGeoIPContext(Toyz4net.Core.IpAddressSearchWebService.getGeoIPContextRequest request);
        
        // CODEGEN: 操作 getVersionTime 以后生成的消息协定不是 RPC，也不是换行文档。
        [System.ServiceModel.OperationContractAttribute(Action="http://WebXml.com.cn/IpAddressSearchWebServiceHttpGet/getVersionTimeRequest", ReplyAction="http://WebXml.com.cn/IpAddressSearchWebServiceHttpGet/getVersionTimeResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        Toyz4net.Core.IpAddressSearchWebService.getVersionTimeResponse getVersionTime(Toyz4net.Core.IpAddressSearchWebService.getVersionTimeRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getCountryCityByIpRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string theIpAddress;
        
        public getCountryCityByIpRequest() {
        }
        
        public getCountryCityByIpRequest(string theIpAddress) {
            this.theIpAddress = theIpAddress;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getCountryCityByIpResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebXml.com.cn/", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public string[] ArrayOfString;
        
        public getCountryCityByIpResponse() {
        }
        
        public getCountryCityByIpResponse(string[] ArrayOfString) {
            this.ArrayOfString = ArrayOfString;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getGeoIPContextRequest {
        
        public getGeoIPContextRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getGeoIPContextResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebXml.com.cn/", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public string[] ArrayOfString;
        
        public getGeoIPContextResponse() {
        }
        
        public getGeoIPContextResponse(string[] ArrayOfString) {
            this.ArrayOfString = ArrayOfString;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getVersionTimeRequest {
        
        public getVersionTimeRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getVersionTimeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebXml.com.cn/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string @string;
        
        public getVersionTimeResponse() {
        }
        
        public getVersionTimeResponse(string @string) {
            this.@string = @string;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IpAddressSearchWebServiceHttpGetChannel : Toyz4net.Core.IpAddressSearchWebService.IpAddressSearchWebServiceHttpGet, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class IpAddressSearchWebServiceHttpGetClient : System.ServiceModel.ClientBase<Toyz4net.Core.IpAddressSearchWebService.IpAddressSearchWebServiceHttpGet>, Toyz4net.Core.IpAddressSearchWebService.IpAddressSearchWebServiceHttpGet {
        
        public IpAddressSearchWebServiceHttpGetClient() {
        }
        
        public IpAddressSearchWebServiceHttpGetClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IpAddressSearchWebServiceHttpGetClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IpAddressSearchWebServiceHttpGetClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IpAddressSearchWebServiceHttpGetClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Toyz4net.Core.IpAddressSearchWebService.getCountryCityByIpResponse Toyz4net.Core.IpAddressSearchWebService.IpAddressSearchWebServiceHttpGet.getCountryCityByIp(Toyz4net.Core.IpAddressSearchWebService.getCountryCityByIpRequest request) {
            return base.Channel.getCountryCityByIp(request);
        }
        
        public string[] getCountryCityByIp(string theIpAddress) {
            Toyz4net.Core.IpAddressSearchWebService.getCountryCityByIpRequest inValue = new Toyz4net.Core.IpAddressSearchWebService.getCountryCityByIpRequest();
            inValue.theIpAddress = theIpAddress;
            Toyz4net.Core.IpAddressSearchWebService.getCountryCityByIpResponse retVal = ((Toyz4net.Core.IpAddressSearchWebService.IpAddressSearchWebServiceHttpGet)(this)).getCountryCityByIp(inValue);
            return retVal.ArrayOfString;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Toyz4net.Core.IpAddressSearchWebService.getGeoIPContextResponse Toyz4net.Core.IpAddressSearchWebService.IpAddressSearchWebServiceHttpGet.getGeoIPContext(Toyz4net.Core.IpAddressSearchWebService.getGeoIPContextRequest request) {
            return base.Channel.getGeoIPContext(request);
        }
        
        public string[] getGeoIPContext() {
            Toyz4net.Core.IpAddressSearchWebService.getGeoIPContextRequest inValue = new Toyz4net.Core.IpAddressSearchWebService.getGeoIPContextRequest();
            Toyz4net.Core.IpAddressSearchWebService.getGeoIPContextResponse retVal = ((Toyz4net.Core.IpAddressSearchWebService.IpAddressSearchWebServiceHttpGet)(this)).getGeoIPContext(inValue);
            return retVal.ArrayOfString;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Toyz4net.Core.IpAddressSearchWebService.getVersionTimeResponse Toyz4net.Core.IpAddressSearchWebService.IpAddressSearchWebServiceHttpGet.getVersionTime(Toyz4net.Core.IpAddressSearchWebService.getVersionTimeRequest request) {
            return base.Channel.getVersionTime(request);
        }
        
        public string getVersionTime() {
            Toyz4net.Core.IpAddressSearchWebService.getVersionTimeRequest inValue = new Toyz4net.Core.IpAddressSearchWebService.getVersionTimeRequest();
            Toyz4net.Core.IpAddressSearchWebService.getVersionTimeResponse retVal = ((Toyz4net.Core.IpAddressSearchWebService.IpAddressSearchWebServiceHttpGet)(this)).getVersionTime(inValue);
            return retVal.@string;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://WebXml.com.cn/", ConfigurationName="IpAddressSearchWebService.IpAddressSearchWebServiceHttpPost")]
    public interface IpAddressSearchWebServiceHttpPost {
        
        // CODEGEN: 操作 getCountryCityByIp 以后生成的消息协定不是 RPC，也不是换行文档。
        [System.ServiceModel.OperationContractAttribute(Action="http://WebXml.com.cn/IpAddressSearchWebServiceHttpPost/getCountryCityByIpRequest", ReplyAction="http://WebXml.com.cn/IpAddressSearchWebServiceHttpPost/getCountryCityByIpResponse" +
            "")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        Toyz4net.Core.IpAddressSearchWebService.getCountryCityByIpResponse1 getCountryCityByIp(Toyz4net.Core.IpAddressSearchWebService.getCountryCityByIpRequest1 request);
        
        // CODEGEN: 操作 getGeoIPContext 以后生成的消息协定不是 RPC，也不是换行文档。
        [System.ServiceModel.OperationContractAttribute(Action="http://WebXml.com.cn/IpAddressSearchWebServiceHttpPost/getGeoIPContextRequest", ReplyAction="http://WebXml.com.cn/IpAddressSearchWebServiceHttpPost/getGeoIPContextResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        Toyz4net.Core.IpAddressSearchWebService.getGeoIPContextResponse1 getGeoIPContext(Toyz4net.Core.IpAddressSearchWebService.getGeoIPContextRequest1 request);
        
        // CODEGEN: 操作 getVersionTime 以后生成的消息协定不是 RPC，也不是换行文档。
        [System.ServiceModel.OperationContractAttribute(Action="http://WebXml.com.cn/IpAddressSearchWebServiceHttpPost/getVersionTimeRequest", ReplyAction="http://WebXml.com.cn/IpAddressSearchWebServiceHttpPost/getVersionTimeResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        Toyz4net.Core.IpAddressSearchWebService.getVersionTimeResponse1 getVersionTime(Toyz4net.Core.IpAddressSearchWebService.getVersionTimeRequest1 request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getCountryCityByIpRequest1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string theIpAddress;
        
        public getCountryCityByIpRequest1() {
        }
        
        public getCountryCityByIpRequest1(string theIpAddress) {
            this.theIpAddress = theIpAddress;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getCountryCityByIpResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebXml.com.cn/", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public string[] ArrayOfString;
        
        public getCountryCityByIpResponse1() {
        }
        
        public getCountryCityByIpResponse1(string[] ArrayOfString) {
            this.ArrayOfString = ArrayOfString;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getGeoIPContextRequest1 {
        
        public getGeoIPContextRequest1() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getGeoIPContextResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebXml.com.cn/", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public string[] ArrayOfString;
        
        public getGeoIPContextResponse1() {
        }
        
        public getGeoIPContextResponse1(string[] ArrayOfString) {
            this.ArrayOfString = ArrayOfString;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getVersionTimeRequest1 {
        
        public getVersionTimeRequest1() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getVersionTimeResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebXml.com.cn/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string @string;
        
        public getVersionTimeResponse1() {
        }
        
        public getVersionTimeResponse1(string @string) {
            this.@string = @string;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IpAddressSearchWebServiceHttpPostChannel : Toyz4net.Core.IpAddressSearchWebService.IpAddressSearchWebServiceHttpPost, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class IpAddressSearchWebServiceHttpPostClient : System.ServiceModel.ClientBase<Toyz4net.Core.IpAddressSearchWebService.IpAddressSearchWebServiceHttpPost>, Toyz4net.Core.IpAddressSearchWebService.IpAddressSearchWebServiceHttpPost {
        
        public IpAddressSearchWebServiceHttpPostClient() {
        }
        
        public IpAddressSearchWebServiceHttpPostClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IpAddressSearchWebServiceHttpPostClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IpAddressSearchWebServiceHttpPostClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IpAddressSearchWebServiceHttpPostClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Toyz4net.Core.IpAddressSearchWebService.getCountryCityByIpResponse1 Toyz4net.Core.IpAddressSearchWebService.IpAddressSearchWebServiceHttpPost.getCountryCityByIp(Toyz4net.Core.IpAddressSearchWebService.getCountryCityByIpRequest1 request) {
            return base.Channel.getCountryCityByIp(request);
        }
        
        public string[] getCountryCityByIp(string theIpAddress) {
            Toyz4net.Core.IpAddressSearchWebService.getCountryCityByIpRequest1 inValue = new Toyz4net.Core.IpAddressSearchWebService.getCountryCityByIpRequest1();
            inValue.theIpAddress = theIpAddress;
            Toyz4net.Core.IpAddressSearchWebService.getCountryCityByIpResponse1 retVal = ((Toyz4net.Core.IpAddressSearchWebService.IpAddressSearchWebServiceHttpPost)(this)).getCountryCityByIp(inValue);
            return retVal.ArrayOfString;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Toyz4net.Core.IpAddressSearchWebService.getGeoIPContextResponse1 Toyz4net.Core.IpAddressSearchWebService.IpAddressSearchWebServiceHttpPost.getGeoIPContext(Toyz4net.Core.IpAddressSearchWebService.getGeoIPContextRequest1 request) {
            return base.Channel.getGeoIPContext(request);
        }
        
        public string[] getGeoIPContext() {
            Toyz4net.Core.IpAddressSearchWebService.getGeoIPContextRequest1 inValue = new Toyz4net.Core.IpAddressSearchWebService.getGeoIPContextRequest1();
            Toyz4net.Core.IpAddressSearchWebService.getGeoIPContextResponse1 retVal = ((Toyz4net.Core.IpAddressSearchWebService.IpAddressSearchWebServiceHttpPost)(this)).getGeoIPContext(inValue);
            return retVal.ArrayOfString;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Toyz4net.Core.IpAddressSearchWebService.getVersionTimeResponse1 Toyz4net.Core.IpAddressSearchWebService.IpAddressSearchWebServiceHttpPost.getVersionTime(Toyz4net.Core.IpAddressSearchWebService.getVersionTimeRequest1 request) {
            return base.Channel.getVersionTime(request);
        }
        
        public string getVersionTime() {
            Toyz4net.Core.IpAddressSearchWebService.getVersionTimeRequest1 inValue = new Toyz4net.Core.IpAddressSearchWebService.getVersionTimeRequest1();
            Toyz4net.Core.IpAddressSearchWebService.getVersionTimeResponse1 retVal = ((Toyz4net.Core.IpAddressSearchWebService.IpAddressSearchWebServiceHttpPost)(this)).getVersionTime(inValue);
            return retVal.@string;
        }
    }
}
