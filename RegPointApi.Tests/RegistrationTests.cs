using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace RegPointApi.Tests
{
    class RegistrationTests : TestFixtureBase
    {
        private Registration entity = new Registration()
        {
            eventdesc = "test_eventdesc",
            eventcode = "test_eventcode",
            participant_fname = "test_participant_fname",
            participant_lname = "test_participant_lname",
            group = "test_group",
            status = "test_status",
            order_number = "test_order_number",
            billing_code = "test_billing_code",
            accountnumber = 123,
            reg_date = "2013/1/1",
            participant_mname = "test_participant_mname",
            participant_phone = "test_participant_phone",
            email_primary = "test_email_primary",
            dob = "2013/1/1",
            gender = "test_gender",
            position = "test_position",
            price = "123.45",
            address = "test_address",
            city = "test_city",
            state = "test_state",
            postal_code = "test_postal_code",
            country = "test_country",
            promotional_code = "a",
            promotional_discount = "12.34",
            emergency_contact = "test_emergency_contact",
            emergency_contact_phone = "test_ecphone",
            emergency_contact_relation = "test_emergency_contact_relation",
            how_did_you_hear_about_us = "test_how_did_you_hear_about_us",
            health_insur_carrier = "test_health_insur_carrier",
            health_policy = "test_health_policy",
            health_group_name = "test_health_group_name",
            health_group = "test_health_group",
            health_dr_name = "test_health_dr_name",
            health_dr_phone = "test_health_dr_phone",
            health_insured_name = "test_health_insured_name",
            health_insured_dob = "2013/1/1",
            health_insured_email = "test_health_insured_email",
            health_insured_address = "test_health_insured_address",
            health_insured_city = "test_health_insured_city",
            health_insured_state = "test_health_insured_state",
            health_insured_zip = "12345",
            activity_log = "test_activity_log",
            deposit_paid = "a",
            deposit_flag = "a",
            deposit_amnt = "1.23",
            confirmation_sent = 0,
            confirmation_date = "2013/1/1",
            bill_me_flag = "a",
            form1_recvd = "a",
            form2_recvd = "a",
            form3_recvd = "a",
            form4_recvd = "a",
            form5_recvd = "a",
            posting_flag = "a",
            pay_plan = "a",
            how_did_you_hear_other = "test_how_did_you_hear_other",
            group_id = 345,
            part_id = 456,
            session_date = "2013/1/1",
        };

        [Test]
        public void a_AddValid()
        {
            var response = client.AddRegistration(entity);
            WasSuccessfulTest(response);
            Assert.True(response.Data.id > 0);
            Assert.True(response.Data.data_saved.id == response.Data.id);
            entity = response.Data.data_saved;
        }

        [Test]
        public void b_ViewAllWithNoFilters()
        {
            var response = client.ViewRegistrations();
            WasSuccessfulTest(response);
            Assert.True(response.Data.registrations.Any());
        }

        [Test]
        public void c_ViewAllWithSingleFilter()
        {
            var filters = new Dictionary<string, object>()
            {
                { "eventcode", entity.eventcode },
            };
            var response = client.ViewRegistrations(filters);
            WasSuccessfulTest(response);
            Assert.True(response.Data.registrations.Any());
            Assert.True(response.Data.registrations.All(m => m.eventcode == entity.eventcode));
        }

        [Test]
        public void d_Edit()
        {
            entity.eventdesc = "edited " + entity.eventdesc;
            var response = client.EditRegistration(entity);
            WasSuccessfulTest(response);
            Assert.True(response.Data.data.eventdesc == entity.eventdesc);
        }

        [Test]
        public void e_Delete()
        {
            var response = client.DeleteRegistration(entity.id);
            WasSuccessfulTest(response);
        }
    }
}
