using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace RegPointApi.Tests
{
    class PromoCodeTests : TestFixtureBase
    {
        private PromoCode entity = new PromoCode()
        {
            code = "test_code",
            amount = "123.45",
            percentage = "10.0",
            type = "test_type",
            valid_through = "2013/1/1",
            assign_code = "test_assign_code",
        };

        [Test]
        public void a_AddValid()
        {
            var response = client.AddPromoCode(entity);
            WasSuccessfulTest(response);
            Assert.True(response.Data.id > 0);
            Assert.True(response.Data.data_saved.id == response.Data.id);
            entity = response.Data.data_saved;
        }

        [Test]
        public void b_ViewAllWithNoFilters()
        {
            var response = client.ViewPromoCodes();
            WasSuccessfulTest(response);
            Assert.True(response.Data.promo_codes.Any());
        }

        [Test]
        public void c_ViewAllWithSingleFilter()
        {
            var filters = new Dictionary<string, object>()
            {
                { "code", entity.code },
            };
            var response = client.ViewPromoCodes(filters);
            WasSuccessfulTest(response);
            Assert.True(response.Data.promo_codes.Any());
            Assert.True(response.Data.promo_codes.All(m => m.code == entity.code));
        }

        [Test]
        public void d_Edit()
        {
            entity.code = "edited " + entity.code;
            var response = client.EditPromoCode(entity);
            WasSuccessfulTest(response);
            Assert.True(response.Data.data.code == entity.code);
        }

        [Test]
        public void e_Delete()
        {
            var response = client.DeletePromoCode(entity.id);
            WasSuccessfulTest(response);
        }
    }
}
