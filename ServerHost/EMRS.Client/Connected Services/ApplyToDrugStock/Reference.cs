﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EMRS.Client.ApplyToDrugStock {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ChooseDrugViewModel", Namespace="http://schemas.datacontract.org/2004/07/EMRS.Model")]
    [System.SerializableAttribute()]
    public partial class ChooseDrugViewModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DrugCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DrugNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string InputCodeField;
        
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
        public string DrugCode {
            get {
                return this.DrugCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.DrugCodeField, value) != true)) {
                    this.DrugCodeField = value;
                    this.RaisePropertyChanged("DrugCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DrugName {
            get {
                return this.DrugNameField;
            }
            set {
                if ((object.ReferenceEquals(this.DrugNameField, value) != true)) {
                    this.DrugNameField = value;
                    this.RaisePropertyChanged("DrugName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string InputCode {
            get {
                return this.InputCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.InputCodeField, value) != true)) {
                    this.InputCodeField = value;
                    this.RaisePropertyChanged("InputCode");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ChooseDrugSizeViewModel", Namespace="http://schemas.datacontract.org/2004/07/EMRS.Model")]
    [System.SerializableAttribute()]
    public partial class ChooseDrugSizeViewModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> AmountPerPackageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DrugCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DrugSpecField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirmIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MinSpecField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MinUnitsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal RetailPriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal TradePriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UnitsField;
        
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
        public System.Nullable<int> AmountPerPackage {
            get {
                return this.AmountPerPackageField;
            }
            set {
                if ((this.AmountPerPackageField.Equals(value) != true)) {
                    this.AmountPerPackageField = value;
                    this.RaisePropertyChanged("AmountPerPackage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DrugCode {
            get {
                return this.DrugCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.DrugCodeField, value) != true)) {
                    this.DrugCodeField = value;
                    this.RaisePropertyChanged("DrugCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DrugSpec {
            get {
                return this.DrugSpecField;
            }
            set {
                if ((object.ReferenceEquals(this.DrugSpecField, value) != true)) {
                    this.DrugSpecField = value;
                    this.RaisePropertyChanged("DrugSpec");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirmId {
            get {
                return this.FirmIdField;
            }
            set {
                if ((object.ReferenceEquals(this.FirmIdField, value) != true)) {
                    this.FirmIdField = value;
                    this.RaisePropertyChanged("FirmId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MinSpec {
            get {
                return this.MinSpecField;
            }
            set {
                if ((object.ReferenceEquals(this.MinSpecField, value) != true)) {
                    this.MinSpecField = value;
                    this.RaisePropertyChanged("MinSpec");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MinUnits {
            get {
                return this.MinUnitsField;
            }
            set {
                if ((object.ReferenceEquals(this.MinUnitsField, value) != true)) {
                    this.MinUnitsField = value;
                    this.RaisePropertyChanged("MinUnits");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal RetailPrice {
            get {
                return this.RetailPriceField;
            }
            set {
                if ((this.RetailPriceField.Equals(value) != true)) {
                    this.RetailPriceField = value;
                    this.RaisePropertyChanged("RetailPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal TradePrice {
            get {
                return this.TradePriceField;
            }
            set {
                if ((this.TradePriceField.Equals(value) != true)) {
                    this.TradePriceField = value;
                    this.RaisePropertyChanged("TradePrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Units {
            get {
                return this.UnitsField;
            }
            set {
                if ((object.ReferenceEquals(this.UnitsField, value) != true)) {
                    this.UnitsField = value;
                    this.RaisePropertyChanged("Units");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CreateDrugListViewModel", Namespace="http://schemas.datacontract.org/2004/07/EMRS.Model")]
    [System.SerializableAttribute()]
    public partial class CreateDrugListViewModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Drug_CodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Drug_NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Drug_SpecField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Enter_Date_TimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Expire_DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Package_SpecField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Package_UnitsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QuantityField;
        
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
        public string Drug_Code {
            get {
                return this.Drug_CodeField;
            }
            set {
                if ((object.ReferenceEquals(this.Drug_CodeField, value) != true)) {
                    this.Drug_CodeField = value;
                    this.RaisePropertyChanged("Drug_Code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Drug_Name {
            get {
                return this.Drug_NameField;
            }
            set {
                if ((object.ReferenceEquals(this.Drug_NameField, value) != true)) {
                    this.Drug_NameField = value;
                    this.RaisePropertyChanged("Drug_Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Drug_Spec {
            get {
                return this.Drug_SpecField;
            }
            set {
                if ((object.ReferenceEquals(this.Drug_SpecField, value) != true)) {
                    this.Drug_SpecField = value;
                    this.RaisePropertyChanged("Drug_Spec");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Enter_Date_Time {
            get {
                return this.Enter_Date_TimeField;
            }
            set {
                if ((this.Enter_Date_TimeField.Equals(value) != true)) {
                    this.Enter_Date_TimeField = value;
                    this.RaisePropertyChanged("Enter_Date_Time");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Expire_Date {
            get {
                return this.Expire_DateField;
            }
            set {
                if ((this.Expire_DateField.Equals(value) != true)) {
                    this.Expire_DateField = value;
                    this.RaisePropertyChanged("Expire_Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Package_Spec {
            get {
                return this.Package_SpecField;
            }
            set {
                if ((object.ReferenceEquals(this.Package_SpecField, value) != true)) {
                    this.Package_SpecField = value;
                    this.RaisePropertyChanged("Package_Spec");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Package_Units {
            get {
                return this.Package_UnitsField;
            }
            set {
                if ((object.ReferenceEquals(this.Package_UnitsField, value) != true)) {
                    this.Package_UnitsField = value;
                    this.RaisePropertyChanged("Package_Units");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Quantity {
            get {
                return this.QuantityField;
            }
            set {
                if ((this.QuantityField.Equals(value) != true)) {
                    this.QuantityField = value;
                    this.RaisePropertyChanged("Quantity");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DrugStockDetailViewModel", Namespace="http://schemas.datacontract.org/2004/07/EMRS.Model")]
    [System.SerializableAttribute()]
    public partial class DrugStockDetailViewModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ADMINISTRATIONField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BATCH_NOField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal DOSE_PER_UNITField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DOSE_UNITSField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DRUG_CODEField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DRUG_NAMEField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DRUG_SPECField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime EXPIRE_DATEField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FIRM_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NOTESField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QUANTITYField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string STORAGEField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SUB_STORAGEField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SUPPLY_INDICATORField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UNITSField;
        
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
        public string ADMINISTRATION {
            get {
                return this.ADMINISTRATIONField;
            }
            set {
                if ((object.ReferenceEquals(this.ADMINISTRATIONField, value) != true)) {
                    this.ADMINISTRATIONField = value;
                    this.RaisePropertyChanged("ADMINISTRATION");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BATCH_NO {
            get {
                return this.BATCH_NOField;
            }
            set {
                if ((object.ReferenceEquals(this.BATCH_NOField, value) != true)) {
                    this.BATCH_NOField = value;
                    this.RaisePropertyChanged("BATCH_NO");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal DOSE_PER_UNIT {
            get {
                return this.DOSE_PER_UNITField;
            }
            set {
                if ((this.DOSE_PER_UNITField.Equals(value) != true)) {
                    this.DOSE_PER_UNITField = value;
                    this.RaisePropertyChanged("DOSE_PER_UNIT");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DOSE_UNITS {
            get {
                return this.DOSE_UNITSField;
            }
            set {
                if ((object.ReferenceEquals(this.DOSE_UNITSField, value) != true)) {
                    this.DOSE_UNITSField = value;
                    this.RaisePropertyChanged("DOSE_UNITS");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DRUG_CODE {
            get {
                return this.DRUG_CODEField;
            }
            set {
                if ((object.ReferenceEquals(this.DRUG_CODEField, value) != true)) {
                    this.DRUG_CODEField = value;
                    this.RaisePropertyChanged("DRUG_CODE");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DRUG_NAME {
            get {
                return this.DRUG_NAMEField;
            }
            set {
                if ((object.ReferenceEquals(this.DRUG_NAMEField, value) != true)) {
                    this.DRUG_NAMEField = value;
                    this.RaisePropertyChanged("DRUG_NAME");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DRUG_SPEC {
            get {
                return this.DRUG_SPECField;
            }
            set {
                if ((object.ReferenceEquals(this.DRUG_SPECField, value) != true)) {
                    this.DRUG_SPECField = value;
                    this.RaisePropertyChanged("DRUG_SPEC");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime EXPIRE_DATE {
            get {
                return this.EXPIRE_DATEField;
            }
            set {
                if ((this.EXPIRE_DATEField.Equals(value) != true)) {
                    this.EXPIRE_DATEField = value;
                    this.RaisePropertyChanged("EXPIRE_DATE");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FIRM_ID {
            get {
                return this.FIRM_IDField;
            }
            set {
                if ((object.ReferenceEquals(this.FIRM_IDField, value) != true)) {
                    this.FIRM_IDField = value;
                    this.RaisePropertyChanged("FIRM_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NOTES {
            get {
                return this.NOTESField;
            }
            set {
                if ((object.ReferenceEquals(this.NOTESField, value) != true)) {
                    this.NOTESField = value;
                    this.RaisePropertyChanged("NOTES");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int QUANTITY {
            get {
                return this.QUANTITYField;
            }
            set {
                if ((this.QUANTITYField.Equals(value) != true)) {
                    this.QUANTITYField = value;
                    this.RaisePropertyChanged("QUANTITY");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string STORAGE {
            get {
                return this.STORAGEField;
            }
            set {
                if ((object.ReferenceEquals(this.STORAGEField, value) != true)) {
                    this.STORAGEField = value;
                    this.RaisePropertyChanged("STORAGE");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SUB_STORAGE {
            get {
                return this.SUB_STORAGEField;
            }
            set {
                if ((object.ReferenceEquals(this.SUB_STORAGEField, value) != true)) {
                    this.SUB_STORAGEField = value;
                    this.RaisePropertyChanged("SUB_STORAGE");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SUPPLY_INDICATOR {
            get {
                return this.SUPPLY_INDICATORField;
            }
            set {
                if ((this.SUPPLY_INDICATORField.Equals(value) != true)) {
                    this.SUPPLY_INDICATORField = value;
                    this.RaisePropertyChanged("SUPPLY_INDICATOR");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UNITS {
            get {
                return this.UNITSField;
            }
            set {
                if ((object.ReferenceEquals(this.UNITSField, value) != true)) {
                    this.UNITSField = value;
                    this.RaisePropertyChanged("UNITS");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ApplyToDrugStock.IApplyToDrugStock")]
    public interface IApplyToDrugStock {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplyToDrugStock/GetChooseDrugListByStorage", ReplyAction="http://tempuri.org/IApplyToDrugStock/GetChooseDrugListByStorageResponse")]
        EMRS.Client.ApplyToDrugStock.ChooseDrugViewModel[] GetChooseDrugListByStorage(string stockId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplyToDrugStock/GetChooseDrugListByStorage", ReplyAction="http://tempuri.org/IApplyToDrugStock/GetChooseDrugListByStorageResponse")]
        System.Threading.Tasks.Task<EMRS.Client.ApplyToDrugStock.ChooseDrugViewModel[]> GetChooseDrugListByStorageAsync(string stockId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplyToDrugStock/GetChooseDrugSizeByCode", ReplyAction="http://tempuri.org/IApplyToDrugStock/GetChooseDrugSizeByCodeResponse")]
        EMRS.Client.ApplyToDrugStock.ChooseDrugSizeViewModel[] GetChooseDrugSizeByCode(string code);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplyToDrugStock/GetChooseDrugSizeByCode", ReplyAction="http://tempuri.org/IApplyToDrugStock/GetChooseDrugSizeByCodeResponse")]
        System.Threading.Tasks.Task<EMRS.Client.ApplyToDrugStock.ChooseDrugSizeViewModel[]> GetChooseDrugSizeByCodeAsync(string code);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplyToDrugStock/GetChooseDrugSize", ReplyAction="http://tempuri.org/IApplyToDrugStock/GetChooseDrugSizeResponse")]
        EMRS.Client.ApplyToDrugStock.ChooseDrugSizeViewModel[] GetChooseDrugSize(string stockId, string code);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplyToDrugStock/GetChooseDrugSize", ReplyAction="http://tempuri.org/IApplyToDrugStock/GetChooseDrugSizeResponse")]
        System.Threading.Tasks.Task<EMRS.Client.ApplyToDrugStock.ChooseDrugSizeViewModel[]> GetChooseDrugSizeAsync(string stockId, string code);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplyToDrugStock/GetAutoCreateDrugList", ReplyAction="http://tempuri.org/IApplyToDrugStock/GetAutoCreateDrugListResponse")]
        EMRS.Client.ApplyToDrugStock.CreateDrugListViewModel[] GetAutoCreateDrugList(string code);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplyToDrugStock/GetAutoCreateDrugList", ReplyAction="http://tempuri.org/IApplyToDrugStock/GetAutoCreateDrugListResponse")]
        System.Threading.Tasks.Task<EMRS.Client.ApplyToDrugStock.CreateDrugListViewModel[]> GetAutoCreateDrugListAsync(string code);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplyToDrugStock/InsertDrugApplication", ReplyAction="http://tempuri.org/IApplyToDrugStock/InsertDrugApplicationResponse")]
        bool InsertDrugApplication(EMRS.Client.ApplyToDrugStock.CreateDrugListViewModel[] list, string applicantStorage, string provideStorage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplyToDrugStock/InsertDrugApplication", ReplyAction="http://tempuri.org/IApplyToDrugStock/InsertDrugApplicationResponse")]
        System.Threading.Tasks.Task<bool> InsertDrugApplicationAsync(EMRS.Client.ApplyToDrugStock.CreateDrugListViewModel[] list, string applicantStorage, string provideStorage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplyToDrugStock/GetDrugDetailList", ReplyAction="http://tempuri.org/IApplyToDrugStock/GetDrugDetailListResponse")]
        EMRS.Client.ApplyToDrugStock.DrugStockDetailViewModel[] GetDrugDetailList(string stockId, string code);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplyToDrugStock/GetDrugDetailList", ReplyAction="http://tempuri.org/IApplyToDrugStock/GetDrugDetailListResponse")]
        System.Threading.Tasks.Task<EMRS.Client.ApplyToDrugStock.DrugStockDetailViewModel[]> GetDrugDetailListAsync(string stockId, string code);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IApplyToDrugStockChannel : EMRS.Client.ApplyToDrugStock.IApplyToDrugStock, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ApplyToDrugStockClient : System.ServiceModel.ClientBase<EMRS.Client.ApplyToDrugStock.IApplyToDrugStock>, EMRS.Client.ApplyToDrugStock.IApplyToDrugStock {
        
        public ApplyToDrugStockClient() {
        }
        
        public ApplyToDrugStockClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ApplyToDrugStockClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ApplyToDrugStockClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ApplyToDrugStockClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public EMRS.Client.ApplyToDrugStock.ChooseDrugViewModel[] GetChooseDrugListByStorage(string stockId) {
            return base.Channel.GetChooseDrugListByStorage(stockId);
        }
        
        public System.Threading.Tasks.Task<EMRS.Client.ApplyToDrugStock.ChooseDrugViewModel[]> GetChooseDrugListByStorageAsync(string stockId) {
            return base.Channel.GetChooseDrugListByStorageAsync(stockId);
        }
        
        public EMRS.Client.ApplyToDrugStock.ChooseDrugSizeViewModel[] GetChooseDrugSizeByCode(string code) {
            return base.Channel.GetChooseDrugSizeByCode(code);
        }
        
        public System.Threading.Tasks.Task<EMRS.Client.ApplyToDrugStock.ChooseDrugSizeViewModel[]> GetChooseDrugSizeByCodeAsync(string code) {
            return base.Channel.GetChooseDrugSizeByCodeAsync(code);
        }
        
        public EMRS.Client.ApplyToDrugStock.ChooseDrugSizeViewModel[] GetChooseDrugSize(string stockId, string code) {
            return base.Channel.GetChooseDrugSize(stockId, code);
        }
        
        public System.Threading.Tasks.Task<EMRS.Client.ApplyToDrugStock.ChooseDrugSizeViewModel[]> GetChooseDrugSizeAsync(string stockId, string code) {
            return base.Channel.GetChooseDrugSizeAsync(stockId, code);
        }
        
        public EMRS.Client.ApplyToDrugStock.CreateDrugListViewModel[] GetAutoCreateDrugList(string code) {
            return base.Channel.GetAutoCreateDrugList(code);
        }
        
        public System.Threading.Tasks.Task<EMRS.Client.ApplyToDrugStock.CreateDrugListViewModel[]> GetAutoCreateDrugListAsync(string code) {
            return base.Channel.GetAutoCreateDrugListAsync(code);
        }
        
        public bool InsertDrugApplication(EMRS.Client.ApplyToDrugStock.CreateDrugListViewModel[] list, string applicantStorage, string provideStorage) {
            return base.Channel.InsertDrugApplication(list, applicantStorage, provideStorage);
        }
        
        public System.Threading.Tasks.Task<bool> InsertDrugApplicationAsync(EMRS.Client.ApplyToDrugStock.CreateDrugListViewModel[] list, string applicantStorage, string provideStorage) {
            return base.Channel.InsertDrugApplicationAsync(list, applicantStorage, provideStorage);
        }
        
        public EMRS.Client.ApplyToDrugStock.DrugStockDetailViewModel[] GetDrugDetailList(string stockId, string code) {
            return base.Channel.GetDrugDetailList(stockId, code);
        }
        
        public System.Threading.Tasks.Task<EMRS.Client.ApplyToDrugStock.DrugStockDetailViewModel[]> GetDrugDetailListAsync(string stockId, string code) {
            return base.Channel.GetDrugDetailListAsync(stockId, code);
        }
    }
}