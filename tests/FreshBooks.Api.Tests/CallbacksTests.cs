using FreshBooks.Api.ServiceTypes;
using NUnit.Framework;

namespace FreshBooks.Api.Tests
{
    [TestFixture]
    public class CallbacksTests: BaseTests
    {

        [Test]
        public async void CanListCallbacksAsync()
        {
            var callbackRequest = new CallbackListRequest
            {
                Event = EventNames.invoice_create
            };

            var response = await client.Exec(callbackRequest);

            Assert.IsFalse(response.IsError());

        }
    }
}
