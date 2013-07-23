using System.Runtime.Serialization;

namespace RegPointApi
{
    [DataContract]
    public class MasterAccount
    {
        [DataMember] public int id { get; set; }
        [DataMember] public int accountnumber { get; set; }
        [DataMember] public string guard1_fname { get; set; }
        [DataMember] public string guard1_lname { get; set; }
        [DataMember] public string guard1_address { get; set; }
        [DataMember] public string guard1_city { get; set; }
        [DataMember] public string guard1_state { get; set; }
        [DataMember] public string guard1_zip { get; set; }
        [DataMember] public string guard1_country { get; set; }
        [DataMember] public string guard1_phone { get; set; }
        [DataMember] public string guard1_mobile { get; set; }
        [DataMember] public string guard1_work { get; set; }
        [DataMember] public string guard1_email { get; set; }
        [DataMember] public string guard1_relation { get; set; }
        [DataMember] public string guard2_fname { get; set; }
        [DataMember] public string guard2_lname { get; set; }
        [DataMember] public string guard2_address { get; set; }
        [DataMember] public string guard2_city { get; set; }
        [DataMember] public string guard2_state { get; set; }
        [DataMember] public string guard2_zip { get; set; }
        [DataMember] public string guard2_country { get; set; }
        [DataMember] public string guard2_phone { get; set; }
        [DataMember] public string guard2_mobile { get; set; }
        [DataMember] public string guard2_work { get; set; }
        [DataMember] public string guard2_email { get; set; }
        [DataMember] public string guard2_relation { get; set; }
        [DataMember] public string userid { get; set; }
        [DataMember] public string vault_pay_type { get; set; }
        [DataMember] public string date_added { get; set; }
    }
}
