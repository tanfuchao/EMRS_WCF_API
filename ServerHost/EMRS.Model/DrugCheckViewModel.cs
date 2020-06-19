using System;
using System.Runtime.Serialization;

namespace EMRS.Model
{
    /// <summary>
    /// Defines the <see cref="DrugCheckViewModel" />.
    /// </summary>
    [DataContract]
    public class DrugCheckViewModel
    {
        [DataMember]
        public string STORAGE { get; set; }

        [DataMember]
        public string DRUG_CODE { get; set; }

        [DataMember]
        public string DRUG_SPEC { get; set; }

        [DataMember]
        public string UNITS { get; set; }

        [DataMember]
        public string BATCH_NO { get; set; }

        [DataMember]
        public DateTime EXPIRE_DATE { get; set; }

        [DataMember]
        public string FIRM_ID { get; set; }

        [DataMember]
        public decimal PURCHASE_PRICE { get; set; }

        [DataMember]
        public int QUANTITY { get; set; }

        [DataMember]
        public string LOCATION { get; set; }

        [DataMember]
        public string DRUG_NAME { get; set; }
    }
}
