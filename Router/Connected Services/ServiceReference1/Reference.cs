﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Router.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="JCDecauxItem", Namespace="http://schemas.datacontract.org/2004/07/ProxyCache")]
    [System.SerializableAttribute()]
    public partial class JCDecauxItem : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Router.ServiceReference1.Station[] _stationsField;
        
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
        public Router.ServiceReference1.Station[] _stations {
            get {
                return this._stationsField;
            }
            set {
                if ((object.ReferenceEquals(this._stationsField, value) != true)) {
                    this._stationsField = value;
                    this.RaisePropertyChanged("_stations");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Station", Namespace="http://schemas.datacontract.org/2004/07/ProxyCache")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Router.ServiceReference1.JCDecauxItem))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Router.ServiceReference1.Station[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Router.ServiceReference1.Stands))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Router.ServiceReference1.Availibilities))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Router.ServiceReference1.Position))]
    public partial class Station : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string addressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool bankingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool bonusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool connectedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string contractNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string lastUpdateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Router.ServiceReference1.Stands mainStandsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int numberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool overflowField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private object overflowStandsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Router.ServiceReference1.Position positionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string shapeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string statusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Router.ServiceReference1.Stands totalStandsField;
        
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
        public string address {
            get {
                return this.addressField;
            }
            set {
                if ((object.ReferenceEquals(this.addressField, value) != true)) {
                    this.addressField = value;
                    this.RaisePropertyChanged("address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool banking {
            get {
                return this.bankingField;
            }
            set {
                if ((this.bankingField.Equals(value) != true)) {
                    this.bankingField = value;
                    this.RaisePropertyChanged("banking");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool bonus {
            get {
                return this.bonusField;
            }
            set {
                if ((this.bonusField.Equals(value) != true)) {
                    this.bonusField = value;
                    this.RaisePropertyChanged("bonus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool connected {
            get {
                return this.connectedField;
            }
            set {
                if ((this.connectedField.Equals(value) != true)) {
                    this.connectedField = value;
                    this.RaisePropertyChanged("connected");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string contractName {
            get {
                return this.contractNameField;
            }
            set {
                if ((object.ReferenceEquals(this.contractNameField, value) != true)) {
                    this.contractNameField = value;
                    this.RaisePropertyChanged("contractName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string lastUpdate {
            get {
                return this.lastUpdateField;
            }
            set {
                if ((object.ReferenceEquals(this.lastUpdateField, value) != true)) {
                    this.lastUpdateField = value;
                    this.RaisePropertyChanged("lastUpdate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Router.ServiceReference1.Stands mainStands {
            get {
                return this.mainStandsField;
            }
            set {
                if ((object.ReferenceEquals(this.mainStandsField, value) != true)) {
                    this.mainStandsField = value;
                    this.RaisePropertyChanged("mainStands");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int number {
            get {
                return this.numberField;
            }
            set {
                if ((this.numberField.Equals(value) != true)) {
                    this.numberField = value;
                    this.RaisePropertyChanged("number");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool overflow {
            get {
                return this.overflowField;
            }
            set {
                if ((this.overflowField.Equals(value) != true)) {
                    this.overflowField = value;
                    this.RaisePropertyChanged("overflow");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public object overflowStands {
            get {
                return this.overflowStandsField;
            }
            set {
                if ((object.ReferenceEquals(this.overflowStandsField, value) != true)) {
                    this.overflowStandsField = value;
                    this.RaisePropertyChanged("overflowStands");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Router.ServiceReference1.Position position {
            get {
                return this.positionField;
            }
            set {
                if ((object.ReferenceEquals(this.positionField, value) != true)) {
                    this.positionField = value;
                    this.RaisePropertyChanged("position");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string shape {
            get {
                return this.shapeField;
            }
            set {
                if ((object.ReferenceEquals(this.shapeField, value) != true)) {
                    this.shapeField = value;
                    this.RaisePropertyChanged("shape");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string status {
            get {
                return this.statusField;
            }
            set {
                if ((object.ReferenceEquals(this.statusField, value) != true)) {
                    this.statusField = value;
                    this.RaisePropertyChanged("status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Router.ServiceReference1.Stands totalStands {
            get {
                return this.totalStandsField;
            }
            set {
                if ((object.ReferenceEquals(this.totalStandsField, value) != true)) {
                    this.totalStandsField = value;
                    this.RaisePropertyChanged("totalStands");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Stands", Namespace="http://schemas.datacontract.org/2004/07/ProxyCache")]
    [System.SerializableAttribute()]
    public partial class Stands : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Router.ServiceReference1.Availibilities availabilitiesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int capacityField;
        
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
        public Router.ServiceReference1.Availibilities availabilities {
            get {
                return this.availabilitiesField;
            }
            set {
                if ((object.ReferenceEquals(this.availabilitiesField, value) != true)) {
                    this.availabilitiesField = value;
                    this.RaisePropertyChanged("availabilities");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int capacity {
            get {
                return this.capacityField;
            }
            set {
                if ((this.capacityField.Equals(value) != true)) {
                    this.capacityField = value;
                    this.RaisePropertyChanged("capacity");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Position", Namespace="http://schemas.datacontract.org/2004/07/ProxyCache")]
    [System.SerializableAttribute()]
    public partial class Position : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double latitudeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double longitudeField;
        
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
        public double latitude {
            get {
                return this.latitudeField;
            }
            set {
                if ((this.latitudeField.Equals(value) != true)) {
                    this.latitudeField = value;
                    this.RaisePropertyChanged("latitude");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double longitude {
            get {
                return this.longitudeField;
            }
            set {
                if ((this.longitudeField.Equals(value) != true)) {
                    this.longitudeField = value;
                    this.RaisePropertyChanged("longitude");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Availibilities", Namespace="http://schemas.datacontract.org/2004/07/ProxyCache")]
    [System.SerializableAttribute()]
    public partial class Availibilities : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int bikesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int electricalBikesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int electricalInternalBatteryBikesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int electricalRemovableBatteryBikesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int mechanicalBikesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int standsField;
        
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
        public int bikes {
            get {
                return this.bikesField;
            }
            set {
                if ((this.bikesField.Equals(value) != true)) {
                    this.bikesField = value;
                    this.RaisePropertyChanged("bikes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int electricalBikes {
            get {
                return this.electricalBikesField;
            }
            set {
                if ((this.electricalBikesField.Equals(value) != true)) {
                    this.electricalBikesField = value;
                    this.RaisePropertyChanged("electricalBikes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int electricalInternalBatteryBikes {
            get {
                return this.electricalInternalBatteryBikesField;
            }
            set {
                if ((this.electricalInternalBatteryBikesField.Equals(value) != true)) {
                    this.electricalInternalBatteryBikesField = value;
                    this.RaisePropertyChanged("electricalInternalBatteryBikes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int electricalRemovableBatteryBikes {
            get {
                return this.electricalRemovableBatteryBikesField;
            }
            set {
                if ((this.electricalRemovableBatteryBikesField.Equals(value) != true)) {
                    this.electricalRemovableBatteryBikesField = value;
                    this.RaisePropertyChanged("electricalRemovableBatteryBikes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int mechanicalBikes {
            get {
                return this.mechanicalBikesField;
            }
            set {
                if ((this.mechanicalBikesField.Equals(value) != true)) {
                    this.mechanicalBikesField = value;
                    this.RaisePropertyChanged("mechanicalBikes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int stands {
            get {
                return this.standsField;
            }
            set {
                if ((this.standsField.Equals(value) != true)) {
                    this.standsField = value;
                    this.RaisePropertyChanged("stands");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IProxy")]
    public interface IProxy {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProxy/GetAllStation", ReplyAction="http://tempuri.org/IProxy/GetAllStationResponse")]
        Router.ServiceReference1.JCDecauxItem GetAllStation();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProxy/GetAllStation", ReplyAction="http://tempuri.org/IProxy/GetAllStationResponse")]
        System.Threading.Tasks.Task<Router.ServiceReference1.JCDecauxItem> GetAllStationAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProxy/GetStation", ReplyAction="http://tempuri.org/IProxy/GetStationResponse")]
        Router.ServiceReference1.JCDecauxItem GetStation(string key);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProxy/GetStation", ReplyAction="http://tempuri.org/IProxy/GetStationResponse")]
        System.Threading.Tasks.Task<Router.ServiceReference1.JCDecauxItem> GetStationAsync(string key);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProxyChannel : Router.ServiceReference1.IProxy, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProxyClient : System.ServiceModel.ClientBase<Router.ServiceReference1.IProxy>, Router.ServiceReference1.IProxy {
        
        public ProxyClient() {
        }
        
        public ProxyClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProxyClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProxyClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProxyClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Router.ServiceReference1.JCDecauxItem GetAllStation() {
            return base.Channel.GetAllStation();
        }
        
        public System.Threading.Tasks.Task<Router.ServiceReference1.JCDecauxItem> GetAllStationAsync() {
            return base.Channel.GetAllStationAsync();
        }
        
        public Router.ServiceReference1.JCDecauxItem GetStation(string key) {
            return base.Channel.GetStation(key);
        }
        
        public System.Threading.Tasks.Task<Router.ServiceReference1.JCDecauxItem> GetStationAsync(string key) {
            return base.Channel.GetStationAsync(key);
        }
    }
}