using System.Runtime.Serialization;

namespace etcd.DataContracts
{
    [DataContract]
    public class Node
    {
        [DataMember(Order = 1)]
        public int CreatedIndex { get; set; }

        [DataMember(Order = 2)]
        public string Key { get; set; }

        [DataMember(Order = 3)]
        public int ModifiedIndex { get; set; }

        [DataMember(Order = 4)]
        public string Value { get; set; }
    }
}
