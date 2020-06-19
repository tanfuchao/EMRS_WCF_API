using System.Collections.Generic;
using System.Runtime.Serialization;

namespace EMRS.Model
{
    [DataContract]
    public class ResultObj
    {
        [DataMember]
        public int code { get; set; }
        [DataMember]
        public bool isSuccess { get; set; }
        [DataMember]
        public string massage { get; set; }
    }

    [DataContract]
    public class ResultObj<T>:ResultObj
    {
        [DataMember]
        public T data { get; set; }
    }

    [DataContract]
    public class ResultObjList<T> : ResultObj
    {
        [DataMember]
        public List<T> data { get; set; }
    }

    
}
