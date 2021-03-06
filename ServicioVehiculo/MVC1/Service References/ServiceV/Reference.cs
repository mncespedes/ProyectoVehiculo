﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC1.ServiceV {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="VehiculoRespuesta", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class VehiculoRespuesta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MensajeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PosicionField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mensaje {
            get {
                return this.MensajeField;
            }
            set {
                if ((object.ReferenceEquals(this.MensajeField, value) != true)) {
                    this.MensajeField = value;
                    this.RaisePropertyChanged("Mensaje");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Posicion {
            get {
                return this.PosicionField;
            }
            set {
                if ((object.ReferenceEquals(this.PosicionField, value) != true)) {
                    this.PosicionField = value;
                    this.RaisePropertyChanged("Posicion");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceV.IVehiculoService")]
    public interface IVehiculoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVehiculoService/GetPosicion", ReplyAction="http://tempuri.org/IVehiculoService/GetPosicionResponse")]
        string GetPosicion();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVehiculoService/GetPosicion", ReplyAction="http://tempuri.org/IVehiculoService/GetPosicionResponse")]
        System.Threading.Tasks.Task<string> GetPosicionAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVehiculoService/PostConfiguracion", ReplyAction="http://tempuri.org/IVehiculoService/PostConfiguracionResponse")]
        string PostConfiguracion(int n, int m);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVehiculoService/PostConfiguracion", ReplyAction="http://tempuri.org/IVehiculoService/PostConfiguracionResponse")]
        System.Threading.Tasks.Task<string> PostConfiguracionAsync(int n, int m);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVehiculoService/PostValidarComando", ReplyAction="http://tempuri.org/IVehiculoService/PostValidarComandoResponse")]
        MVC1.ServiceV.VehiculoRespuesta PostValidarComando(string comando, int n, int m, string posicion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVehiculoService/PostValidarComando", ReplyAction="http://tempuri.org/IVehiculoService/PostValidarComandoResponse")]
        System.Threading.Tasks.Task<MVC1.ServiceV.VehiculoRespuesta> PostValidarComandoAsync(string comando, int n, int m, string posicion);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IVehiculoServiceChannel : MVC1.ServiceV.IVehiculoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class VehiculoServiceClient : System.ServiceModel.ClientBase<MVC1.ServiceV.IVehiculoService>, MVC1.ServiceV.IVehiculoService {
        
        public VehiculoServiceClient() {
        }
        
        public VehiculoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public VehiculoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VehiculoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VehiculoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetPosicion() {
            return base.Channel.GetPosicion();
        }
        
        public System.Threading.Tasks.Task<string> GetPosicionAsync() {
            return base.Channel.GetPosicionAsync();
        }
        
        public string PostConfiguracion(int n, int m) {
            return base.Channel.PostConfiguracion(n, m);
        }
        
        public System.Threading.Tasks.Task<string> PostConfiguracionAsync(int n, int m) {
            return base.Channel.PostConfiguracionAsync(n, m);
        }
        
        public MVC1.ServiceV.VehiculoRespuesta PostValidarComando(string comando, int n, int m, string posicion) {
            return base.Channel.PostValidarComando(comando, n, m, posicion);
        }
        
        public System.Threading.Tasks.Task<MVC1.ServiceV.VehiculoRespuesta> PostValidarComandoAsync(string comando, int n, int m, string posicion) {
            return base.Channel.PostValidarComandoAsync(comando, n, m, posicion);
        }
    }
}
