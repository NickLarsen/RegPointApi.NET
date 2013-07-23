using System.Runtime.Serialization;

namespace RegPointApi
{
    [DataContract]
    public class PromoCode
    {
        [DataMember] public int id { get; set; }
        [DataMember] public string code { get; set; }
        [DataMember] public string amount { get; set; }
        [DataMember] public string percentage { get; set; }
        [DataMember] public string type { get; set; }
        [DataMember] public string valid_through { get; set; }
        [DataMember] public string assign_code { get; set; }
    }
}
