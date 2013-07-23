using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace RegPointApi.Tests
{
    class MasterAccountTests : TestFixtureBase
    {
        private MasterAccount entity = new MasterAccount()
        {
            accountnumber = 123,
            guard1_fname = "test_guard1_fname",
            guard1_lname = "test_guard1_lname",
            guard1_address = "test_guard1_address",
            guard1_city = "test_guard1_city",
            guard1_state = "test_guard1_state",
            guard1_zip = "test_guard1_zip",
            guard1_country = "test_guard1_country",
            guard1_phone = "123.456.7890",
            guard1_mobile = "123.456.7890",
            guard1_work = "test_guard1_work",
            guard1_email = "test_guard1_email@test.com",
            guard1_relation = "test_guard1_relation",
            guard2_fname = "test_guard2_fname",
            guard2_lname = "test_guard2_lname",
            guard2_address = "test_guard2_address",
            guard2_city = "test_guard2_city",
            guard2_state = "test_guard2_state",
            guard2_zip = "test_guard2_zip",
            guard2_country = "test_guard2_country",
            guard2_phone = "123.456.7890",
            guard2_mobile = "123.456.7890",
            guard2_work = "test_guard2_work",
            guard2_email = "test_guard2_email@test.com",
            guard2_relation = "test_guard2_relation",
            userid = "test_userid@test.com",
            vault_pay_type = "test_vault_pay_type",
            date_added = "2013/1/1",
        };

        [Test]
        public void a_AddValid()
        {
            var response = client.AddMasterAccount(entity);
            WasSuccessfulTest(response);
            Assert.True(response.Data.id > 0);
            Assert.True(response.Data.data_saved.id == response.Data.id);
            entity = response.Data.data_saved;
        }

        [Test]
        public void b_ViewAllWithNoFilters()
        {
            var response = client.ViewMasterAccounts();
            WasSuccessfulTest(response);
            Assert.True(response.Data.master_accounts.Any());
        }

        [Test]
        public void c_ViewAllWithSingleFilter()
        {
            var filters = new Dictionary<string, object>()
            {
                { "accountnumber", entity.accountnumber },
            };
            var response = client.ViewMasterAccounts(filters);
            WasSuccessfulTest(response);
            Assert.True(response.Data.master_accounts.Any());
            Assert.True(response.Data.master_accounts.All(m => m.accountnumber == entity.accountnumber));
        }

        [Test]
        public void d_Edit()
        {
            entity.guard1_address = "edited " + entity.guard1_address;
            var response = client.EditMasterAccount(entity);
            WasSuccessfulTest(response);
            Assert.True(response.Data.data.guard1_address == entity.guard1_address);
        }

        [Test]
        public void e_Delete()
        {
            var response = client.DeleteMasterAccount(entity.id);
            WasSuccessfulTest(response);
        }
    }
}
