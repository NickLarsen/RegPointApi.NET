using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace RegPointApi.Tests
{
    class PaymentTests : TestFixtureBase
    {
        private Payment entity = new Payment()
        {
            trans_date = "2013/1/1",
            type = "test_type",
            amount = "123.45",
            accountnumber = 123,
            eventcode = "test_eventcode",
            order_number = "test_order_number",
            fname = "test_fname",
            lname = "test_lname",
            comment = "test_comment",
            trans_id = "test_trans_id",
        };

        [Test]
        public void a_AddValid()
        {
            var response = client.AddPayment(entity);
            WasSuccessfulTest(response);
            Assert.True(response.Data.id > 0);
            Assert.True(response.Data.data_saved.id == response.Data.id);
            entity = response.Data.data_saved;
        }

        [Test]
        public void b_ViewAllWithNoFilters()
        {
            var response = client.ViewPayments();
            WasSuccessfulTest(response);
            Assert.True(response.Data.payments.Any());
        }

        [Test]
        public void c_ViewAllWithSingleFilter()
        {
            var filters = new Dictionary<string, object>()
            {
                { "eventcode", entity.eventcode },
            };
            var response = client.ViewPayments(filters);
            WasSuccessfulTest(response);
            Assert.True(response.Data.payments.Any());
            Assert.True(response.Data.payments.All(m => m.eventcode == entity.eventcode));
        }

        [Test]
        public void d_Edit()
        {
            entity.fname = "edited " + entity.fname;
            var response = client.EditPayment(entity);
            WasSuccessfulTest(response);
            Assert.True(response.Data.data.fname == entity.fname);
        }

        [Test]
        public void e_Delete()
        {
            var response = client.DeletePayment(entity.id);
            WasSuccessfulTest(response);
        }
    }
}
