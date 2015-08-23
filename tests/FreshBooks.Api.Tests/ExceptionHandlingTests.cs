using NUnit.Framework;
using System;
using System.Net;
using System.Net.Http;

namespace FreshBooks.Api.Tests
{
    [TestFixture]
    public class ExceptionHandlingTests: BaseTests
    {
        [Test]
        public async void CanHandleSuccess()
        {
            var request = new CallbackList.request()
            {
                @event = EventNames.invoice_create
            };

            var response = await client.CallbackList(request);

            Assert.AreEqual("ok", response.status);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        [Test]
        public async void CanHandleExceptionsThatDoNotThrow()
        {
            var request = new CallbackList.request()
            {
                @event = EventNames.invoice_create
            };

            // modify the token to ensure it's bad
            var previousToken = client.Options.Token;
            client.Options.Token = Guid.NewGuid().ToString("N").ToLower();

            var response = await client.CallbackList(request);

            // reset the token for future tests
            client.Options.Token = previousToken;

            Assert.AreEqual("fail", response.status);
            Assert.AreEqual(HttpStatusCode.Unauthorized, response.StatusCode);
            Assert.AreEqual("Authentication failed.", response.error);
        }

        [Test]
        [ExpectedException(typeof(FreshBooksException), ExpectedMessage = "Unauthorized", MatchType = MessageMatch.Exact)]
        public async void CanHandleExceptionsThatAreThrown()
        {
            var request = new CallbackList.request()
            {
                @event = EventNames.invoice_create
            };

            // modify the token to ensure it's bad
            client.Options.ThrowOnFail = true; // throw error if not a success status code
            var previousToken = client.Options.Token;
            client.Options.Token = Guid.NewGuid().ToString("N").ToLower();

            try
            {
                var response = await client.CallbackList(request);
            }
            catch (FreshBooksException ex)
            {
                Assert.AreEqual(HttpStatusCode.Unauthorized, ex.StatusCode);
                Assert.AreEqual("Unauthorized", ex.Message);
                Assert.AreEqual("Authentication failed.", ex.error);
                throw;
            }
            finally
            {
                // reset the token for future tests
                client.Options.Token = previousToken;
                client.Options.ThrowOnFail = false;
            }
        }
    }
}
