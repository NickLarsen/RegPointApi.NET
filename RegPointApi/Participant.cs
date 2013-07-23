using System.Runtime.Serialization;

namespace RegPointApi
{
    [DataContract]
    public class Participant
    {
        [DataMember] public int id { get; set; }
        [DataMember] public int master_id { get; set; }
        [DataMember] public string firstname { get; set; }
        [DataMember] public string middlename { get; set; }
        [DataMember] public string lastname { get; set; }
        [DataMember] public string dob { get; set; }
        [DataMember] public string address { get; set; }
        [DataMember] public string city { get; set; }
        [DataMember] public string state { get; set; }
        [DataMember] public string zip { get; set; }
        [DataMember] public string country { get; set; }
        [DataMember] public string phone { get; set; }
        [DataMember] public string email { get; set; }
        [DataMember] public string gender { get; set; }
        [DataMember] public string relation_to_master { get; set; }
    }
}
