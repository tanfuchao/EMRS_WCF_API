using System;
using System.Runtime.Serialization;

namespace EMRS.Model
{
    [DataContract]
    public class DrugStockDetailViewModel
    {
        [DataMember]
        public string DRUG_NAME { get; set; }

        [DataMember]
        public string DRUG_CODE { get; set; }

        [DataMember]
        public string STORAGE { get; set; }

        [DataMember]
        public string DRUG_SPEC { get; set; }
        [DataMember]
        public string FIRM_ID { get; set; }
        [DataMember]
        public string UNITS { get; set; }
        [DataMember]
        public string BATCH_NO { get; set; }
        [DataMember]
        public DateTime EXPIRE_DATE { get; set; }
        [DataMember]
        public string SUB_STORAGE { get; set; }
        [DataMember]
        public string DOSE_UNITS { get; set; }
        [DataMember]
        public decimal DOSE_PER_UNIT { get; set; }
        [DataMember]
        public string ADMINISTRATION { get; set; }
        [DataMember]
        public string NOTES { get; set; }
        [DataMember]
        public int SUPPLY_INDICATOR { get; set; }
        [DataMember]
        public int QUANTITY { get; set; }
    }
}
