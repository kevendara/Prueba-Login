﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AplicacionWeb.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="tbl_user", Namespace="http://schemas.datacontract.org/2004/07/Entidades")]
    [System.SerializableAttribute()]
    public partial class tbl_user : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string contraseñaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreCuentaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombrePersonaField;
        
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
        public string contraseña {
            get {
                return this.contraseñaField;
            }
            set {
                if ((object.ReferenceEquals(this.contraseñaField, value) != true)) {
                    this.contraseñaField = value;
                    this.RaisePropertyChanged("contraseña");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nombreCuenta {
            get {
                return this.nombreCuentaField;
            }
            set {
                if ((object.ReferenceEquals(this.nombreCuentaField, value) != true)) {
                    this.nombreCuentaField = value;
                    this.RaisePropertyChanged("nombreCuenta");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nombrePersona {
            get {
                return this.nombrePersonaField;
            }
            set {
                if ((object.ReferenceEquals(this.nombrePersonaField, value) != true)) {
                    this.nombrePersonaField = value;
                    this.RaisePropertyChanged("nombrePersona");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WcfColegio")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUser", ReplyAction="http://tempuri.org/IService1/GetUserResponse")]
        AplicacionWeb.ServiceReference1.tbl_user[] GetUser();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertUser", ReplyAction="http://tempuri.org/IService1/InsertUserResponse")]
        void InsertUser(AplicacionWeb.ServiceReference1.tbl_user nuevoAlumno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateUser", ReplyAction="http://tempuri.org/IService1/UpdateUserResponse")]
        void UpdateUser(AplicacionWeb.ServiceReference1.tbl_user actualizarAlumno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteUser", ReplyAction="http://tempuri.org/IService1/DeleteUserResponse")]
        void DeleteUser(AplicacionWeb.ServiceReference1.tbl_user eliminarUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/login", ReplyAction="http://tempuri.org/IService1/loginResponse")]
        bool login(string usuario, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        AplicacionWeb.ServiceReference1.CompositeType GetDataUsingDataContract(AplicacionWeb.ServiceReference1.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : AplicacionWeb.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<AplicacionWeb.ServiceReference1.IService1>, AplicacionWeb.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public AplicacionWeb.ServiceReference1.tbl_user[] GetUser() {
            return base.Channel.GetUser();
        }
        
        public void InsertUser(AplicacionWeb.ServiceReference1.tbl_user nuevoAlumno) {
            base.Channel.InsertUser(nuevoAlumno);
        }
        
        public void UpdateUser(AplicacionWeb.ServiceReference1.tbl_user actualizarAlumno) {
            base.Channel.UpdateUser(actualizarAlumno);
        }
        
        public void DeleteUser(AplicacionWeb.ServiceReference1.tbl_user eliminarUser) {
            base.Channel.DeleteUser(eliminarUser);
        }
        
        public bool login(string usuario, string password) {
            return base.Channel.login(usuario, password);
        }
        
        public AplicacionWeb.ServiceReference1.CompositeType GetDataUsingDataContract(AplicacionWeb.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
    }
}