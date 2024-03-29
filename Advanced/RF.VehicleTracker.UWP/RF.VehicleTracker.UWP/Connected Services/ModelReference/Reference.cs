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
namespace RF.VehicleTracker.UWP.ModelReference {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CModel", Namespace="http://schemas.datacontract.org/2004/07/RF.VehicleTracker.BL")]
    public partial class CModel : object, System.ComponentModel.INotifyPropertyChanged {
        
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ModelReference.IModel")]
    public interface IModel {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModel/GetModels", ReplyAction="http://tempuri.org/IModel/GetModelsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<RF.VehicleTracker.UWP.ModelReference.CModel>> GetModelsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModel/Insert", ReplyAction="http://tempuri.org/IModel/InsertResponse")]
        System.Threading.Tasks.Task InsertAsync(string description);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModel/Update", ReplyAction="http://tempuri.org/IModel/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(System.Guid id, string description);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModel/Delete", ReplyAction="http://tempuri.org/IModel/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModel/GetById", ReplyAction="http://tempuri.org/IModel/GetByIdResponse")]
        System.Threading.Tasks.Task<RF.VehicleTracker.UWP.ModelReference.CModel> GetByIdAsync(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModel/UpdateObj", ReplyAction="http://tempuri.org/IModel/UpdateObjResponse")]
        System.Threading.Tasks.Task UpdateObjAsync(RF.VehicleTracker.UWP.ModelReference.CModel model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModel/DeleteObj", ReplyAction="http://tempuri.org/IModel/DeleteObjResponse")]
        System.Threading.Tasks.Task DeleteObjAsync(RF.VehicleTracker.UWP.ModelReference.CModel model);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IModelChannel : RF.VehicleTracker.UWP.ModelReference.IModel, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ModelClient : System.ServiceModel.ClientBase<RF.VehicleTracker.UWP.ModelReference.IModel>, RF.VehicleTracker.UWP.ModelReference.IModel {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ModelClient(EndpointConfiguration endpointConfiguration) : 
                base(ModelClient.GetBindingForEndpoint(endpointConfiguration), ModelClient.GetEndpointAddress(endpointConfiguration)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ModelClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ModelClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ModelClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ModelClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ModelClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<RF.VehicleTracker.UWP.ModelReference.CModel>> GetModelsAsync() {
            return base.Channel.GetModelsAsync();
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
        
        public System.Threading.Tasks.Task<RF.VehicleTracker.UWP.ModelReference.CModel> GetByIdAsync(System.Guid id) {
            return base.Channel.GetByIdAsync(id);
        }
        
        public System.Threading.Tasks.Task UpdateObjAsync(RF.VehicleTracker.UWP.ModelReference.CModel model) {
            return base.Channel.UpdateObjAsync(model);
        }
        
        public System.Threading.Tasks.Task DeleteObjAsync(RF.VehicleTracker.UWP.ModelReference.CModel model) {
            return base.Channel.DeleteObjAsync(model);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IModel)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpsBinding_IModel)) {
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IModel)) {
                return new System.ServiceModel.EndpointAddress("http://rfvehicletracker.azurewebsites.net/Model.svc");
            }
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpsBinding_IModel)) {
                return new System.ServiceModel.EndpointAddress("https://rfvehicletracker.azurewebsites.net/Model.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration {
            
            BasicHttpBinding_IModel,
            
            BasicHttpsBinding_IModel,
        }
    }
}
