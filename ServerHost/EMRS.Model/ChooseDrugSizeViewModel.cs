using System.Runtime.Serialization;

namespace EMRS.Model
{
    [DataContract]
    public class ChooseDrugSizeViewModel
    {
        [DataMember]
        public string DrugCode { get; set; }

        [DataMember]
        public string DrugSpec { get; set; }

        [DataMember]
        public string FirmId { get; set; }

        [DataMember]
        public string Units { get; set; }

        [DataMember]
        public decimal RetailPrice { get; set; }

        [DataMember]
        public decimal TradePrice { get; set; }

        [DataMember]
        public int? AmountPerPackage { get; set; }

        [DataMember]
        public string MinSpec { get; set; }

        [DataMember]
        public string MinUnits { get; set; }
    }
}
