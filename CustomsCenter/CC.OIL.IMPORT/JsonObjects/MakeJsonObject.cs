using System.Runtime.Serialization;

namespace CC.OIL.IMPORT.JsonObjects
{

    [DataContract]
    internal class MakeJsonObject
    {
        [DataMember]
        public string xpath { get; set; }

        [DataMember]
        public string src { get; set; }

        [DataMember]
        public string alt { get; set; }

        [DataMember]
        public string onclick { get; set; }

        [DataMember]
        public SubParam[] subParam { get; set; }
    }

    [DataContract]
    internal class SubParam
    {
        [DataMember]
        public string onclick { get; set; }

        [DataMember]
        public string title { get; set; }
    }

}