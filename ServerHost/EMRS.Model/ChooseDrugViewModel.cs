using System.Runtime.Serialization;

namespace EMRS.Model
{
    /// <summary>
    /// 入库申请时，选择药品列表
    /// </summary>
    [DataContract]
    public class ChooseDrugViewModel
    {
        [DataMember]
        public string DrugCode { get; set; }

        [DataMember]
        public string DrugName { get; set; }

        [DataMember]
        public string InputCode { get; set; }
    }
}
