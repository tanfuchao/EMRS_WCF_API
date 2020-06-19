using System;
using System.Runtime.Serialization;

namespace EMRS.Model
{
    [DataContract]
    public class PrescMasterIndex
    {
        // 联合主键
        [DataMember]
        public DateTime PRESC_DATE { get; set; }

        // 联合主键
        [DataMember]
        public int PRESC_NO { get; set; }

    }
}
