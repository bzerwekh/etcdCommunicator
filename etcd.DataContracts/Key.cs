using System.Runtime.Serialization;

namespace etcd.DataContracts
{
    [DataContract]
    public class Key
    {
        [DataMember]
        public string Action { get; set; }

        [DataMember]
        public Node Node { get; set; }
    }
}
