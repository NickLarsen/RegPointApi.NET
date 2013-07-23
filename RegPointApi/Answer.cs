using System.Runtime.Serialization;

namespace RegPointApi
{
    [DataContract]
    public class Answer
    {
        [DataMember] public int id { get; set; }
        [DataMember] public int question_id { get; set; }
        [DataMember] public string order_number { get; set; }
        [DataMember] public string eventcode { get; set; }
        [DataMember] public string answer { get; set; }
        [DataMember] public string assign_type { get; set; }
    }
}
