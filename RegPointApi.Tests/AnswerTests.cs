using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace RegPointApi.Tests
{
    class AnswerTests : TestFixtureBase
    {
        private Answer entity = new Answer()
        {
            question_id = 123,
            order_number = "test_order_number",
            eventcode = "test_eventcode",
            answer = "test_answer",
            assign_type = "test_assign_type",
        };

        [Test]
        public void a_AddValid()
        {
            var response = client.AddAnswer(entity);
            WasSuccessfulTest(response);
            Assert.True(response.Data.id > 0);
            Assert.True(response.Data.data_saved.id == response.Data.id);
            entity = response.Data.data_saved;
        }

        [Test]
        public void b_ViewAllWithNoFilters()
        {
            var response = client.ViewAnswers();
            WasSuccessfulTest(response);
            Assert.True(response.Data.answers.Any());
        }

        [Test]
        public void c_ViewAllWithSingleFilter()
        {
            var filters = new Dictionary<string, object>()
            {
                { "eventcode", entity.eventcode },
            };
            var response = client.ViewAnswers(filters);
            WasSuccessfulTest(response);
            Assert.True(response.Data.answers.Any());
            Assert.True(response.Data.answers.All(m => m.eventcode == entity.eventcode));
        }

        [Test]
        public void d_Edit()
        {
            entity.answer = "edited " + entity.answer;
            var response = client.EditAnswer(entity);
            WasSuccessfulTest(response);
            Assert.True(response.Data.data.answer == entity.answer);
        }

        [Test]
        public void e_Delete()
        {
            var response = client.DeleteAnswer(entity.id);
            WasSuccessfulTest(response);
        }
    }
}
