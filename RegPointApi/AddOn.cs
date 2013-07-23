using System.Runtime.Serialization;

namespace RegPointApi
{
    [DataContract]
    public class AddOn
    {
        [DataMember] public int add_on_id { get; set; }
        [DataMember] public string eventcode { get; set; }
        [DataMember] public string add_on_desc { get; set; }
        [DataMember] public string add_on_price { get; set; }
        [DataMember] public string add_on_detail { get; set; }
        [DataMember] public string add_on_label { get; set; }
        [DataMember] public string add_on_choices { get; set; }
        [DataMember] public string image_name { get; set; }
        [DataMember] public string internal_only { get; set; }
        [DataMember] public string assign_code { get; set; }
        [DataMember] public string reg_status { get; set; }
    }
}
