using System.Runtime.Serialization;

namespace EMRS.Model
{
    [DataContract]
    public class InpChargeItemViewModel
    {
        //费用 --前端对应costs
        [DataMember]
        public decimal COSTS { get; set; }

        //实付费用 --前端对应dcharges
        [DataMember]
        public decimal PAYMENTS { get; set; }


        // 药名 --对应strItemName
        [DataMember]
        public string DRUG_NAME { get; set; }

        // 药代码 --对应strItemCode
        [DataMember]
        public string DRUG_CODE { get; set; }

        // 数量 --对应dAmount
        [DataMember]
        public int QUANTITY { get; set; }



    }
}
