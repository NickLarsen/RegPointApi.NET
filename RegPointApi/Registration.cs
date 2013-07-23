using System.Runtime.Serialization;

namespace RegPointApi
{
    [DataContract]
    public class Registration
    {
        [DataMember] public int id { get; set; }
        [DataMember] public string eventdesc { get; set; }
        [DataMember] public string eventcode { get; set; }
        [DataMember] public string participant_fname { get; set; }
        [DataMember] public string participant_lname { get; set; }
        [DataMember] public string group { get; set; }
        [DataMember] public string status { get; set; }
        [DataMember] public string order_number { get; set; }
        [DataMember] public string billing_code { get; set; }
        [DataMember] public int accountnumber { get; set; }
        [DataMember] public string reg_date { get; set; }
        [DataMember] public string participant_mname { get; set; }
        [DataMember] public string participant_phone { get; set; }
        [DataMember] public string email_primary { get; set; }
        [DataMember] public string dob { get; set; }
        [DataMember] public string gender { get; set; }
        [DataMember] public string position { get; set; }
        [DataMember] public string price { get; set; }
        [DataMember] public string address { get; set; }
        [DataMember] public string city { get; set; }
        [DataMember] public string state { get; set; }
        [DataMember] public string postal_code { get; set; }
        [DataMember] public string country { get; set; }
        [DataMember] public string promotional_code { get; set; }
        [DataMember] public string promotional_discount { get; set; }
        [DataMember] public string emergency_contact { get; set; }
        [DataMember] public string emergency_contact_phone { get; set; }
        [DataMember] public string emergency_contact_relation { get; set; }
        [DataMember] public string how_did_you_hear_about_us { get; set; }
        [DataMember] public string health_insur_carrier { get; set; }
        [DataMember] public string health_policy { get; set; }
        [DataMember] public string health_group_name { get; set; }
        [DataMember] public string health_group { get; set; }
        [DataMember] public string health_dr_name { get; set; }
        [DataMember] public string health_dr_phone { get; set; }
        [DataMember] public string health_insured_name { get; set; }
        [DataMember] public string health_insured_dob { get; set; }
        [DataMember] public string health_insured_email { get; set; }
        [DataMember] public string health_insured_address { get; set; }
        [DataMember] public string health_insured_city { get; set; }
        [DataMember] public string health_insured_state { get; set; }
        [DataMember] public string health_insured_zip { get; set; }
        [DataMember] public string activity_log { get; set; }
        [DataMember] public string deposit_paid { get; set; }
        [DataMember] public string deposit_flag { get; set; }
        [DataMember] public string deposit_amnt { get; set; }
        [DataMember] public int? confirmation_sent { get; set; }
        [DataMember] public string confirmation_date { get; set; }
        [DataMember] public string bill_me_flag { get; set; }
        [DataMember] public string form1_recvd { get; set; }
        [DataMember] public string form2_recvd { get; set; }
        [DataMember] public string form3_recvd { get; set; }
        [DataMember] public string form4_recvd { get; set; }
        [DataMember] public string form5_recvd { get; set; }
        [DataMember] public string posting_flag { get; set; }
        [DataMember] public string pay_plan { get; set; }
        [DataMember] public string how_did_you_hear_other { get; set; }
        [DataMember] public int? group_id { get; set; }
        [DataMember] public int? part_id { get; set; }
        [DataMember] public string session_date { get; set; }
    }
}
