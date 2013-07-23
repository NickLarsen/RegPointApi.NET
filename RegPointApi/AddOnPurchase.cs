using System.Runtime.Serialization;

namespace RegPointApi
{
    [DataContract]
    public class AddOnPurchase
    {
        [DataMember] public int add_on_id { get; set; }
        [DataMember] public string eventcode { get; set; }
        [DataMember] public string add_on_desc { get; set; }
        [DataMember] public string add_on_price { get; set; }
        [DataMember] public string add_on_label { get; set; }
        [DataMember] public string add_on_choices { get; set; }
        [DataMember] public string order_number { get; set; }
    }
}
