using NUnit.Framework;

namespace RegPointApi.Tests
{
    [TestFixture]
    class TestFixtureBase
    {
        protected IClient client;
        private const string testApiKey = Client.SandboxApiKey;

        [SetUp]
        public void SetUpFixture()
        {
            client = new Client(testApiKey);
        }

        protected void WasSuccessfulTest<TData>(Response<TData> response)
        {
            var message = response.Exception != null ? response.Exception.Message : null;
            Assert.True(response.WasSuccessful, message);
        }
    }
}
