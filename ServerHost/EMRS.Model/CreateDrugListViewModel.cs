using System;
using System.Runtime.Serialization;

namespace EMRS.Model
{
    [DataContract]
    public class CreateDrugListViewModel
    {
        [DataMember]
        public string Drug_Name { get; set; }

        [DataMember]
        public string Drug_Code { get; set; }

        [DataMember]
        public string Drug_Spec { get; set; }

        [DataMember]
        public string Package_Spec { get; set; }

        [DataMember]
        public string Package_Units { get; set; }

        [DataMember]
        public int Quantity { get; set; }

        [DataMember]
        public DateTime Enter_Date_Time { get; set; }

        [DataMember]
        public DateTime Expire_Date { get; set; }


    }


}
