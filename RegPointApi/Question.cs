using System.Runtime.Serialization;

namespace RegPointApi
{
    [DataContract]
    public class Question
    {
        [DataMember] public int id { get; set; }
        [DataMember] public string eventcode { get; set; }
        [DataMember] public string question_type { get; set; }
        [DataMember] public string question_choices { get; set; }
        [DataMember] public string question_index { get; set; }
        [DataMember] public string question { get; set; }
        [DataMember] public string require_validation { get; set; }
        [DataMember] public string internal_only { get; set; }
        [DataMember] public string assign_code { get; set; }
        [DataMember] public string reg_status { get; set; }
        [DataMember] public string assign_type { get; set; }
    }
}
