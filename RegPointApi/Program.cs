﻿using System.Runtime.Serialization;

namespace RegPointApi
{
    [DataContract]
    public class Program
    {
        [DataMember] public int id { get; set; }
        [DataMember] public string eventcode { get; set; }
        [DataMember] public string billing_code { get; set; }
        [DataMember] public string eventdesc { get; set; }
        [DataMember] public string eventdesc_full { get; set; }
        [DataMember] public string sort_order { get; set; }
        [DataMember] public string eventdesc_sub { get; set; }
        [DataMember] public string reg_status { get; set; }
        [DataMember] public string date { get; set; }
        [DataMember] public string date_end { get; set; }
        [DataMember] public string location { get; set; }
        [DataMember] public string reg_insurance_amount { get; set; }
        [DataMember] public string deposit_last_pay_date { get; set; }
        [DataMember] public string max_reg_camp { get; set; }
        [DataMember] public string max_waitlist { get; set; }
        [DataMember] public string auto_email { get; set; }
        [DataMember] public string auto_email_type { get; set; }
        [DataMember] public string precamp_email { get; set; }
        [DataMember] public string postcamp_email { get; set; }
        [DataMember] public string show_carrier { get; set; }
        [DataMember] public string show_policy_no { get; set; }
        [DataMember] public string show_group_name { get; set; }
        [DataMember] public string show_group_no { get; set; }
        [DataMember] public string show_physician { get; set; }
        [DataMember] public string show_physician_phone { get; set; }
        [DataMember] public string show_fullname { get; set; }
        [DataMember] public string show_dob { get; set; }
        [DataMember] public string show_email { get; set; }
        [DataMember] public string show_address { get; set; }
        [DataMember] public string show_city { get; set; }
        [DataMember] public string show_state { get; set; }
        [DataMember] public string show_postalcode { get; set; }
        [DataMember] public string show_healthtitle { get; set; }
        [DataMember] public string show_insuredtitle { get; set; }
        [DataMember] public string program_type { get; set; }
        [DataMember] public string skip_health { get; set; }
        [DataMember] public string skip_addon { get; set; }
        [DataMember] public string skip_questions { get; set; }
        [DataMember] public string validate_questions { get; set; }
        [DataMember] public string reg_cutoff_date { get; set; }
        [DataMember] public string min_age { get; set; }
        [DataMember] public string max_age { get; set; }
        [DataMember] public string gender_restrict { get; set; }
        [DataMember] public string strict_eligibility { get; set; }
        [DataMember] public string skip_econtact { get; set; }
        [DataMember] public string allow_groups { get; set; }
        [DataMember] public string max_groups { get; set; }
        [DataMember] public string max_reg_per_group { get; set; }
        [DataMember] public string group_liability_level { get; set; }
        [DataMember] public string group_invite_message { get; set; }
        [DataMember] public string show_regdates { get; set; }
        [DataMember] public string min_grade { get; set; }
        [DataMember] public string max_grade { get; set; }
        [DataMember] public string convenience_fee { get; set; }
        [DataMember] public string staffbios { get; set; }
        [DataMember] public string onsite_contact_name { get; set; }
        [DataMember] public string onsite_contact_email { get; set; }
        [DataMember] public string onsite_contact_phone { get; set; }
        [DataMember] public string facility_name { get; set; }
        [DataMember] public string facility_address { get; set; }
        [DataMember] public string facility_city { get; set; }
        [DataMember] public string facility_state { get; set; }
        [DataMember] public string facility_zip { get; set; }
        [DataMember] public string facility_url { get; set; }
        [DataMember] public string facility_map_url { get; set; }
        [DataMember] public string daily_schedule { get; set; }
        [DataMember] public string daily_schedule2 { get; set; }
        [DataMember] public string daily_schedule3 { get; set; }
        [DataMember] public string daily_schedule4 { get; set; }
        [DataMember] public string daily_schedule5 { get; set; }
        [DataMember] public string group1 { get; set; }
        [DataMember] public string group2 { get; set; }
        [DataMember] public string group3 { get; set; }
        [DataMember] public string group4 { get; set; }
        [DataMember] public string group5 { get; set; }
        [DataMember] public string groups { get; set; }
        [DataMember] public string meta_info1 { get; set; }
        [DataMember] public string meta_info2 { get; set; }
        [DataMember] public string meta_info3 { get; set; }
        [DataMember] public string meta_info4 { get; set; }
        [DataMember] public string meta_info5 { get; set; }
        [DataMember] public string message_thankyou { get; set; }
        [DataMember] public string message_registrationpolicy { get; set; }
        [DataMember] public string message_confirm { get; set; }
        [DataMember] public string message_decline { get; set; }
        [DataMember] public string message_waitlist { get; set; }
        [DataMember] public string how_did_you_hear_about_us { get; set; }
        [DataMember] public string reg_policy_title_1 { get; set; }
        [DataMember] public string reg_policy_title_2 { get; set; }
        [DataMember] public string reg_policy_title_3 { get; set; }
        [DataMember] public string reg_policy_1 { get; set; }
        [DataMember] public string reg_policy_2 { get; set; }
        [DataMember] public string reg_policy_3 { get; set; }
        [DataMember] public string program_detail_id { get; set; }
    }
}
