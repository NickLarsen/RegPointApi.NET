using System.Runtime.Serialization;

namespace RegPointApi
{
    [DataContract]
    public class Payment
    {
        [DataMember] public int id { get; set; }
        [DataMember] public string trans_date { get; set; }
        [DataMember] public string type { get; set; }
        [DataMember] public string amount { get; set; }
        [DataMember] public int accountnumber { get; set; }
        [DataMember] public string eventcode { get; set; }
        [DataMember] public string order_number { get; set; }
        [DataMember] public string fname { get; set; }
        [DataMember] public string lname { get; set; }
        [DataMember] public string comment { get; set; }
        [DataMember] public string trans_id { get; set; }
    }
}
