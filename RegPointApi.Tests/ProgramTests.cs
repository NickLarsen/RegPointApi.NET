using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace RegPointApi.Tests
{
    class ProgramTests : TestFixtureBase
    {
        private Program entity = new Program()
        {
            eventcode = "test_eventcode",
            billing_code = "test_billing_code",
            eventdesc = "test_eventdesc",
            eventdesc_full = "test_eventdesc_full",
            sort_order = "test_sort_order",
            eventdesc_sub = "test_eventdesc_sub",
            reg_status = "test_reg_status",
            date = "2013/1/1",
            date_end = "2013/1/1",
            location = "test_location",
            reg_insurance_amount = "test_reg_insurance_amount",
            deposit_last_pay_date = "2013/1/1",
            max_reg_camp = "test_max_reg_camp",
            max_waitlist = "test_max_waitlist",
            auto_email = "test_auto_email",
            auto_email_type = "test_auto_email_type",
            precamp_email = "test_precamp_email",
            postcamp_email = "test_postcamp_email",
            show_carrier = "test_show_carrier",
            show_policy_no = "test_show_policy_no",
            show_group_name = "test_show_group_name",
            show_group_no = "test_show_group_no",
            show_physician = "test_show_physician",
            show_physician_phone = "test_show_physician_phone",
            show_fullname = "test_show_fullname",
            show_dob = "test_show_dob",
            show_email = "test_show_email",
            show_address = "test_show_address",
            show_city = "test_show_city",
            show_state = "test_show_state",
            show_postalcode = "test_show_postalcode",
            show_healthtitle = "test_show_healthtitle",
            show_insuredtitle = "test_show_insuredtitle",
            program_type = "test_program_type",
            skip_health = "test_skip_health",
            skip_addon = "test_skip_addon",
            skip_questions = "test_skip_questions",
            validate_questions = "test_validate_questions",
            reg_cutoff_date = "2013/1/1",
            min_age = "test_min_age",
            max_age = "test_max_age",
            gender_restrict = "test_gender_restrict",
            strict_eligibility = "test_strict_eligibility",
            skip_econtact = "test_skip_econtact",
            allow_groups = "test_allow_groups",
            max_groups = "test_max_groups",
            max_reg_per_group = "test_max_reg_per_group",
            group_liability_level = "test_group_liability_level",
            group_invite_message = "test_group_invite_message",
            show_regdates = "2013/1/1",
            min_grade = "test_min_grade",
            max_grade = "test_max_grade",
            convenience_fee = "test_convenience_fee",
            staffbios = "test_staffbios",
            onsite_contact_name = "test_onsite_contact_name",
            onsite_contact_email = "test_onsite_contact_email",
            onsite_contact_phone = "test_onsite_contact_phone",
            facility_name = "test_facility_name",
            facility_address = "test_facility_address",
            facility_city = "test_facility_city",
            facility_state = "test_facility_state",
            facility_zip = "test_facility_zip",
            facility_url = "test_facility_url",
            facility_map_url = "test_facility_map_url",
            daily_schedule = "test_daily_schedule",
            daily_schedule2 = "test_daily_schedule2",
            daily_schedule3 = "test_daily_schedule3",
            daily_schedule4 = "test_daily_schedule4",
            daily_schedule5 = "test_daily_schedule5",
            group1 = "test_group1",
            group2 = "test_group2",
            group3 = "test_group3",
            group4 = "test_group4",
            group5 = "test_group5",
            groups = "test_groups",
            meta_info1 = "test_meta_info1",
            meta_info2 = "test_meta_info2",
            meta_info3 = "test_meta_info3",
            meta_info4 = "test_meta_info4",
            meta_info5 = "test_meta_info5",
            message_thankyou = "test_message_thankyou",
            message_registrationpolicy = "test_message_registrationpolicy",
            message_confirm = "test_message_confirm",
            message_decline = "test_message_decline",
            message_waitlist = "test_message_waitlist",
            how_did_you_hear_about_us = "test_how_did_you_hear_about_us",
            reg_policy_title_1 = "test_reg_policy_title_1",
            reg_policy_title_2 = "test_reg_policy_title_2",
            reg_policy_title_3 = "test_reg_policy_title_3",
            reg_policy_1 = "test_reg_policy_1",
            reg_policy_2 = "test_reg_policy_2",
            reg_policy_3 = "test_reg_policy_3",
            program_detail_id = "test_program_detail_id",
        };

        [Test]
        public void a_AddValid()
        {
            var response = client.AddProgram(entity);
            WasSuccessfulTest(response);
            Assert.True(response.Data.id > 0);
            Assert.True(response.Data.data_saved.id == response.Data.id);
            entity = response.Data.data_saved;
        }

        [Test]
        public void b_ViewAllWithNoFilters()
        {
            var response = client.ViewPrograms();
            WasSuccessfulTest(response);
            Assert.True(response.Data.programs.Any());
        }

        [Test]
        public void c_ViewAllWithSingleFilter()
        {
            var filters = new Dictionary<string, object>()
            {
                { "eventcode", entity.eventcode },
            };
            var response = client.ViewPrograms(filters);
            WasSuccessfulTest(response);
            Assert.True(response.Data.programs.Any());
            Assert.True(response.Data.programs.All(m => m.eventcode == entity.eventcode));
        }

        [Test]
        public void d_Edit()
        {
            entity.staffbios = "edited " + entity.staffbios;
            var response = client.EditProgram(entity);
            WasSuccessfulTest(response);
            Assert.True(response.Data.data.staffbios == entity.staffbios);
        }

        [Test]
        public void e_Delete()
        {
            var response = client.DeleteProgram(entity.id);
            WasSuccessfulTest(response);
        }
    }
}
