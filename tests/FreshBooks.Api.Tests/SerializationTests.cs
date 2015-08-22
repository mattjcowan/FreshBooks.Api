using FreshBooks.Api.ServiceTypes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FreshBooks.Api.Tests
{
    [TestFixture]
    public class SerializationTests
    {
        [Test]
        public void CanSerializeRequestCorrectly()
        {
            var validRequest = @"
<?xml version=""1.0"" encoding=""utf-8""?>  
<request method=""callback.list"">
  <event>invoice.create</event>
  <uri>http://example.com/webhooks/ready</uri>
</request>".Trim();

            var request = new CallbackListRequest();
            request.Event = EventNames.invoice_create;
            request.Uri = "http://example.com/webhooks/ready";
            var actual = request.ToXmlString();

            // strip new lines to ensure the same rules apply
            actual = new Regex(@">\s*<").Replace(actual, "><");
            validRequest = new Regex(@">\s*<").Replace(validRequest, "><");

            Assert.AreEqual(validRequest, actual);
        }

        [Test]
        public void CanDeSerializeResponseCorrectly()
        {
            var validResponse = @"
<?xml version=""1.0"" encoding=""utf-8""?>  
<response xmlns=""http://www.freshbooks.com/api/"" status=""ok"">  
  <callbacks page=""1"" per_page=""25"" pages=""1"" total=""2"">  
    <callback>  
      <callback_id>20</callback_id>  
      <uri>http://example.com/webhooks/ready</uri>  
      <event>invoice.create</event>  
      <verified>0</verified>  
    </callback>  
    <callback>  
      <callback_id>21</callback_id>  
      <uri>http://example.com/webhooks/ready</uri>  
      <event>invoice.create</event>  
      <verified>1</verified>  
    </callback>  
  </callbacks>  
</response>".Trim();

            var response = validResponse.FromXmlString<CallbackListResponse>();

            Assert.IsTrue(response.Status == "ok");
        }
    }
}
