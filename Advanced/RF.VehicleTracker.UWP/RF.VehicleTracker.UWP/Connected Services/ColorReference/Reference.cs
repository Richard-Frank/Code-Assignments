﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.VisualStudio.ServiceReference.Platforms, version 15.0.26720.2
// 
namespace RF.VehicleTracker.UWP.ColorReference {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CColor", Namespace="http://schemas.datacontract.org/2004/07/RF.VehicleTracker.BL")]
    public partial class CColor : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string DescriptionField;
        
        private System.Guid IdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ColorReference.IColor")]
    public interface IColor {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IColor/InsertObj", ReplyAction="http://tempuri.org/IColor/InsertObjResponse")]
        System.Threading.Tasks.Task InsertObjAsync(RF.VehicleTracker.UWP.ColorReference.CColor color);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IColor/GetColors", ReplyAction="http://tempuri.org/IColor/GetColorsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<RF.VehicleTracker.UWP.ColorReference.CColor>> GetColorsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IColor/Insert", ReplyAction="http://tempuri.org/IColor/InsertResponse")]
        System.Threading.Tasks.Task InsertAsync(string description);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IColor/Update", ReplyAction="http://tempuri.org/IColor/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(System.Guid id, string description);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IColor/Delete", ReplyAction="http://tempuri.org/IColor/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IColor/GetById", ReplyAction="http://tempuri.org/IColor/GetByIdResponse")]
        System.Threading.Tasks.Task<RF.VehicleTracker.UWP.ColorReference.CColor> GetByIdAsync(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IColor/UpdateObj", ReplyAction="http://tempuri.org/IColor/UpdateObjResponse")]
        System.Threading.Tasks.Task UpdateObjAsync(RF.VehicleTracker.UWP.ColorReference.CColor color);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IColor/DeleteObj", ReplyAction="http://tempuri.org/IColor/DeleteObjResponse")]
        System.Threading.Tasks.Task DeleteObjAsync(RF.VehicleTracker.UWP.ColorReference.CColor color);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IColorChannel : RF.VehicleTracker.UWP.ColorReference.IColor, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ColorClient : System.ServiceModel.ClientBase<RF.VehicleTracker.UWP.ColorReference.IColor>, RF.VehicleTracker.UWP.ColorReference.IColor {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ColorClient(EndpointConfiguration endpointConfiguration) : 
                base(ColorClient.GetBindingForEndpoint(endpointConfiguration), ColorClient.GetEndpointAddress(endpointConfiguration)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ColorClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ColorClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ColorClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ColorClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ColorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Threading.Tasks.Task InsertObjAsync(RF.VehicleTracker.UWP.ColorReference.CColor color) {
            return base.Channel.InsertObjAsync(color);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<RF.VehicleTracker.UWP.ColorReference.CColor>> GetColorsAsync() {
            return base.Channel.GetColorsAsync();
        }
        
        public System.Threading.Tasks.Task InsertAsync(string description) {
            return base.Channel.InsertAsync(description);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(System.Guid id, string description) {
            return base.Channel.UpdateAsync(id, description);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(System.Guid id) {
            return base.Channel.DeleteAsync(id);
        }
        
        public System.Threading.Tasks.Task<RF.VehicleTracker.UWP.ColorReference.CColor> GetByIdAsync(System.Guid id) {
            return base.Channel.GetByIdAsync(id);
        }
        
        public System.Threading.Tasks.Task UpdateObjAsync(RF.VehicleTracker.UWP.ColorReference.CColor color) {
            return base.Channel.UpdateObjAsync(color);
        }
        
        public System.Threading.Tasks.Task DeleteObjAsync(RF.VehicleTracker.UWP.ColorReference.CColor color) {
            return base.Channel.DeleteObjAsync(color);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IColor)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpsBinding_IColor)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IColor)) {
                return new System.ServiceModel.EndpointAddress("http://rfvehicletracker.azurewebsites.net/Color.svc");
            }
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpsBinding_IColor)) {
                return new System.ServiceModel.EndpointAddress("https://rfvehicletracker.azurewebsites.net/Color.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration {
            
            BasicHttpBinding_IColor,
            
            BasicHttpsBinding_IColor,
        }
    }
}
