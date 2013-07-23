using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace RegPointApi.Tests
{
    class ParticipantTests : TestFixtureBase
    {
        private Participant entity = new Participant()
        {
            master_id = 123,
            firstname = "test_firstname",
            middlename = "test_middlename",
            lastname = "test_lastname",
            dob = "2013/1/1",
            address = "test_address",
            city = "test_city",
            state = "test_state",
            zip = "test_zip",
            country = "test_country",
            phone = "123.456.7890",
            email = "test_email@test.com",
            gender = "a",
            relation_to_master = "test_relation_to_master",
        };

        [Test]
        public void a_AddValid()
        {
            var response = client.AddParticipant(entity);
            WasSuccessfulTest(response);
            Assert.True(response.Data.id > 0);
            Assert.True(response.Data.data_saved.id == response.Data.id);
            entity = response.Data.data_saved;
        }

        [Test]
        public void b_ViewAllWithNoFilters()
        {
            var response = client.ViewParticipants();
            WasSuccessfulTest(response);
            Assert.True(response.Data.participants.Any());
        }

        [Test]
        public void c_ViewAllWithSingleFilter()
        {
            var filters = new Dictionary<string, object>()
            {
                { "master_id", entity.master_id },
            };
            var response = client.ViewParticipants(filters);
            WasSuccessfulTest(response);
            Assert.True(response.Data.participants.Any());
            Assert.True(response.Data.participants.All(m => m.master_id == entity.master_id));
        }

        [Test]
        public void d_Edit()
        {
            entity.firstname = "edited " + entity.firstname;
            var response = client.EditParticipant(entity);
            WasSuccessfulTest(response);
            Assert.True(response.Data.data.firstname == entity.firstname);
        }

        [Test]
        public void e_Delete()
        {
            var response = client.DeleteParticipant(entity.id);
            WasSuccessfulTest(response);
        }
    }
}
