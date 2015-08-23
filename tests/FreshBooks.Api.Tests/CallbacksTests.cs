using NUnit.Framework;

namespace FreshBooks.Api.Tests
{
    [TestFixture]
    public class CallbacksTests: BaseTests
    {
        [Test]
        public async void CanListCallbacksAsync()
        {
            var request = new CallbackList.request()
            {
                @event = EventNames.invoice_create
            };

            var response = await client.CallbackList(request);

            Assert.IsTrue(response.status == "ok");
            if (response.callbacks.pages > 0)
            {
                Assert.IsNotNull(response.callbacks.callback);
                Assert.GreaterOrEqual(response.callbacks.callback.Length, 0);
            } else
            {
                Assert.IsNull(response.callbacks.callback);
            }
        }
    }
}
