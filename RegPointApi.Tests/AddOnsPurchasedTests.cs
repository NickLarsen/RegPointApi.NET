using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace RegPointApi.Tests
{
    class AddOnsPurchasedTests : TestFixtureBase
    {
        private AddOnPurchase entity = new AddOnPurchase()
        {
            eventcode = "test_eventcode",
            add_on_desc = "test_add_on_desc",
            add_on_price = "123.45",
            add_on_label = "test_add_on_label",
            add_on_choices = "test_add_on_choices",
            order_number = "test_order_number",
        };

        [Test]
        public void a_AddValid()
        {
            var response = client.AddAddOnPurchase(entity);
            WasSuccessfulTest(response);
            Assert.True(response.Data.add_on_id > 0);
            Assert.True(response.Data.data_saved.add_on_id == response.Data.add_on_id);
            entity = response.Data.data_saved;
        }

        [Test]
        public void b_ViewAllWithNoFilters()
        {
            var response = client.ViewAddOnsPurchased();
            WasSuccessfulTest(response);
            Assert.True(response.Data.add_ons.Any());
        }

        [Test]
        public void c_ViewAllWithSingleFilter()
        {
            var filters = new Dictionary<string, object>()
            {
                { "eventcode", entity.eventcode },
            };
            var response = client.ViewAddOnsPurchased(filters);
            WasSuccessfulTest(response);
            Assert.True(response.Data.add_ons.Any());
            Assert.True(response.Data.add_ons.All(m => m.eventcode == entity.eventcode));
        }

        [Test]
        public void d_Edit()
        {
            entity.add_on_desc = "edited " + entity.add_on_desc;
            var response = client.EditAddOnPurchased(entity);
            WasSuccessfulTest(response);
            Assert.True(response.Data.data.add_on_desc == entity.add_on_desc);
        }

        [Test]
        public void e_Delete()
        {
            var response = client.DeleteAddOnPurchased(entity.add_on_id);
            WasSuccessfulTest(response);
        }
    }
}
