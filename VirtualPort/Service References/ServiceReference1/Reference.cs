﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VirtualPort.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Device", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary1")]
    [System.SerializableAttribute()]
    public partial class Device : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string dateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int dayField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float hourField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int minuteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float moneyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int monthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string noteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int yearField;
        
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
        public string date {
            get {
                return this.dateField;
            }
            set {
                if ((object.ReferenceEquals(this.dateField, value) != true)) {
                    this.dateField = value;
                    this.RaisePropertyChanged("date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int day {
            get {
                return this.dayField;
            }
            set {
                if ((this.dayField.Equals(value) != true)) {
                    this.dayField = value;
                    this.RaisePropertyChanged("day");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float hour {
            get {
                return this.hourField;
            }
            set {
                if ((this.hourField.Equals(value) != true)) {
                    this.hourField = value;
                    this.RaisePropertyChanged("hour");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int minute {
            get {
                return this.minuteField;
            }
            set {
                if ((this.minuteField.Equals(value) != true)) {
                    this.minuteField = value;
                    this.RaisePropertyChanged("minute");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float money {
            get {
                return this.moneyField;
            }
            set {
                if ((this.moneyField.Equals(value) != true)) {
                    this.moneyField = value;
                    this.RaisePropertyChanged("money");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int month {
            get {
                return this.monthField;
            }
            set {
                if ((this.monthField.Equals(value) != true)) {
                    this.monthField = value;
                    this.RaisePropertyChanged("month");
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
        public string note {
            get {
                return this.noteField;
            }
            set {
                if ((object.ReferenceEquals(this.noteField, value) != true)) {
                    this.noteField = value;
                    this.RaisePropertyChanged("note");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int year {
            get {
                return this.yearField;
            }
            set {
                if ((this.yearField.Equals(value) != true)) {
                    this.yearField = value;
                    this.RaisePropertyChanged("year");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary1")]
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData1", ReplyAction="http://tempuri.org/IService1/GetData1Response")]
        string GetData1(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData1", ReplyAction="http://tempuri.org/IService1/GetData1Response")]
        System.Threading.Tasks.Task<string> GetData1Async(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertDevice", ReplyAction="http://tempuri.org/IService1/InsertDeviceResponse")]
        int InsertDevice(VirtualPort.ServiceReference1.Device devce);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertDevice", ReplyAction="http://tempuri.org/IService1/InsertDeviceResponse")]
        System.Threading.Tasks.Task<int> InsertDeviceAsync(VirtualPort.ServiceReference1.Device devce);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateDevice", ReplyAction="http://tempuri.org/IService1/UpdateDeviceResponse")]
        int UpdateDevice(VirtualPort.ServiceReference1.Device oldDevice, VirtualPort.ServiceReference1.Device newDevice);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateDevice", ReplyAction="http://tempuri.org/IService1/UpdateDeviceResponse")]
        System.Threading.Tasks.Task<int> UpdateDeviceAsync(VirtualPort.ServiceReference1.Device oldDevice, VirtualPort.ServiceReference1.Device newDevice);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteDeviceInDay", ReplyAction="http://tempuri.org/IService1/DeleteDeviceInDayResponse")]
        int DeleteDeviceInDay(string name, int year, int month, int day);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteDeviceInDay", ReplyAction="http://tempuri.org/IService1/DeleteDeviceInDayResponse")]
        System.Threading.Tasks.Task<int> DeleteDeviceInDayAsync(string name, int year, int month, int day);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetYear", ReplyAction="http://tempuri.org/IService1/GetYearResponse")]
        int GetYear();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetYear", ReplyAction="http://tempuri.org/IService1/GetYearResponse")]
        System.Threading.Tasks.Task<int> GetYearAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TotalMoneyInMonth", ReplyAction="http://tempuri.org/IService1/TotalMoneyInMonthResponse")]
        float TotalMoneyInMonth(int month, int year);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TotalMoneyInMonth", ReplyAction="http://tempuri.org/IService1/TotalMoneyInMonthResponse")]
        System.Threading.Tasks.Task<float> TotalMoneyInMonthAsync(int month, int year);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/MoneyInMonth", ReplyAction="http://tempuri.org/IService1/MoneyInMonthResponse")]
        string MoneyInMonth(int month, int year);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/MoneyInMonth", ReplyAction="http://tempuri.org/IService1/MoneyInMonthResponse")]
        System.Threading.Tasks.Task<string> MoneyInMonthAsync(int month, int year);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TotalMoneyInDay", ReplyAction="http://tempuri.org/IService1/TotalMoneyInDayResponse")]
        float TotalMoneyInDay(int day, int month, int year);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TotalMoneyInDay", ReplyAction="http://tempuri.org/IService1/TotalMoneyInDayResponse")]
        System.Threading.Tasks.Task<float> TotalMoneyInDayAsync(int day, int month, int year);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract1", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContract1Response")]
        VirtualPort.ServiceReference1.CompositeType GetDataUsingDataContract1(VirtualPort.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract1", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContract1Response")]
        System.Threading.Tasks.Task<VirtualPort.ServiceReference1.CompositeType> GetDataUsingDataContract1Async(VirtualPort.ServiceReference1.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : VirtualPort.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<VirtualPort.ServiceReference1.IService1>, VirtualPort.ServiceReference1.IService1 {
        
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
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public string GetData1(string value) {
            return base.Channel.GetData1(value);
        }
        
        public System.Threading.Tasks.Task<string> GetData1Async(string value) {
            return base.Channel.GetData1Async(value);
        }
        
        public int InsertDevice(VirtualPort.ServiceReference1.Device devce) {
            return base.Channel.InsertDevice(devce);
        }
        
        public System.Threading.Tasks.Task<int> InsertDeviceAsync(VirtualPort.ServiceReference1.Device devce) {
            return base.Channel.InsertDeviceAsync(devce);
        }
        
        public int UpdateDevice(VirtualPort.ServiceReference1.Device oldDevice, VirtualPort.ServiceReference1.Device newDevice) {
            return base.Channel.UpdateDevice(oldDevice, newDevice);
        }
        
        public System.Threading.Tasks.Task<int> UpdateDeviceAsync(VirtualPort.ServiceReference1.Device oldDevice, VirtualPort.ServiceReference1.Device newDevice) {
            return base.Channel.UpdateDeviceAsync(oldDevice, newDevice);
        }
        
        public int DeleteDeviceInDay(string name, int year, int month, int day) {
            return base.Channel.DeleteDeviceInDay(name, year, month, day);
        }
        
        public System.Threading.Tasks.Task<int> DeleteDeviceInDayAsync(string name, int year, int month, int day) {
            return base.Channel.DeleteDeviceInDayAsync(name, year, month, day);
        }
        
        public int GetYear() {
            return base.Channel.GetYear();
        }
        
        public System.Threading.Tasks.Task<int> GetYearAsync() {
            return base.Channel.GetYearAsync();
        }
        
        public float TotalMoneyInMonth(int month, int year) {
            return base.Channel.TotalMoneyInMonth(month, year);
        }
        
        public System.Threading.Tasks.Task<float> TotalMoneyInMonthAsync(int month, int year) {
            return base.Channel.TotalMoneyInMonthAsync(month, year);
        }
        
        public string MoneyInMonth(int month, int year) {
            return base.Channel.MoneyInMonth(month, year);
        }
        
        public System.Threading.Tasks.Task<string> MoneyInMonthAsync(int month, int year) {
            return base.Channel.MoneyInMonthAsync(month, year);
        }
        
        public float TotalMoneyInDay(int day, int month, int year) {
            return base.Channel.TotalMoneyInDay(day, month, year);
        }
        
        public System.Threading.Tasks.Task<float> TotalMoneyInDayAsync(int day, int month, int year) {
            return base.Channel.TotalMoneyInDayAsync(day, month, year);
        }
        
        public VirtualPort.ServiceReference1.CompositeType GetDataUsingDataContract1(VirtualPort.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract1(composite);
        }
        
        public System.Threading.Tasks.Task<VirtualPort.ServiceReference1.CompositeType> GetDataUsingDataContract1Async(VirtualPort.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract1Async(composite);
        }
    }
}