using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace RegPointApi.Tests
{
    class QuestionTests : TestFixtureBase
    {
        private Question entity = new Question()
        {
            eventcode = "test_eventcode",
            question_type = "test_question_type",
            question_choices = "test_question_choices",
            question_index = "123",
            question = "test_question",
            require_validation = "a",
            internal_only = "a",
            assign_code = "test_assign_code",
            reg_status = "test_reg_status",
            assign_type = "test_assign_type",
        };

        [Test]
        public void a_AddValid()
        {
            var response = client.AddQuestion(entity);
            WasSuccessfulTest(response);
            Assert.True(response.Data.id > 0);
            Assert.True(response.Data.data_saved.id == response.Data.id);
            entity = response.Data.data_saved;
        }

        [Test]
        public void b_ViewAllWithNoFilters()
        {
            var response = client.ViewQuestions();
            WasSuccessfulTest(response);
            Assert.True(response.Data.questions.Any());
        }

        [Test]
        public void c_ViewAllWithSingleFilter()
        {
            var filters = new Dictionary<string, object>()
            {
                { "eventcode", entity.eventcode },
            };
            var response = client.ViewQuestions(filters);
            WasSuccessfulTest(response);
            Assert.True(response.Data.questions.Any());
            Assert.True(response.Data.questions.All(m => m.eventcode == entity.eventcode));
        }

        [Test]
        public void d_Edit()
        {
            entity.question = "edited " + entity.question;
            var response = client.EditQuestion(entity);
            WasSuccessfulTest(response);
            Assert.True(response.Data.data.question == entity.question);
        }

        [Test]
        public void e_Delete()
        {
            var response = client.DeleteQuestion(entity.id);
            WasSuccessfulTest(response);
        }
    }
}
