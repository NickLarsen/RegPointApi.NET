using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace RegPointApi.Tests
{
    class AddOnTests : TestFixtureBase
    {
        private AddOn entity = new AddOn()
        {
            eventcode = "test_eventcode",
            add_on_desc = "test_add_on_desc",
            add_on_price = "123.45",
            add_on_detail = "test_add_on_detail",
            add_on_label = "test_add_on_label",
            add_on_choices = "test_add_on_choices",
            image_name = "test_image_name",
            internal_only = "a",
            assign_code = "test_assign_code",
            reg_status = "test_reg_status",
        };

        [Test]
        public void a_AddValid()
        {
            var response = client.AddAddOn(entity);
            WasSuccessfulTest(response);
            Assert.True(response.Data.add_on_id > 0);
            Assert.True(response.Data.data_saved.add_on_id == response.Data.add_on_id);
            entity = response.Data.data_saved;
        }

        [Test]
        public void b_ViewAllWithNoFilters()
        {
            var response = client.ViewAddOns();
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
            var response = client.ViewAddOns(filters);
            WasSuccessfulTest(response);
            Assert.True(response.Data.add_ons.Any());
            Assert.True(response.Data.add_ons.All(m => m.eventcode == entity.eventcode));
        }

        [Test]
        public void d_Edit()
        {
            entity.add_on_desc = "edited " + entity.add_on_desc;
            var response = client.EditAddOn(entity);
            WasSuccessfulTest(response);
            Assert.True(response.Data.data.add_on_desc == entity.add_on_desc);
        }

        [Test]
        public void e_Delete()
        {
            var response = client.DeleteAddOn(entity.add_on_id);
            WasSuccessfulTest(response);
        }
    }
}
