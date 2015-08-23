using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FreshBooks.Api
{
    // Learn about HttpClient here:
    // http://chimera.labs.oreilly.com/books/1234000001708/ch14.html

    public partial class FreshBooksClient
    {
        private string _url;
        private HttpClient _httpClient;

        public FreshBooksClient(HttpClient httpClient, string account, FreshBooksClientOptions options)
        {
            if (httpClient == null)
                throw new ArgumentNullException("httpClient");
            if (options == null)
                throw new ArgumentNullException("options");

            _url = string.Format("https://{0}.freshbooks.com/api/2.1/xml-in", account);
            _httpClient = httpClient;
            Options = options;
        }

        public FreshBooksClientAuthStrategy AuthStrategy
        {
            get
            {
                return string.IsNullOrEmpty(Options.Token)
                    ? FreshBooksClientAuthStrategy.OAuth1A
                    : FreshBooksClientAuthStrategy.Token;
            }
        }

        public FreshBooksClientOptions Options { get; private set; }

        private async Task<T> SendAsync<T>(string messageBody, CancellationToken token) where T : BaseResponse, new()
        {
            HttpResponseMessage response = null;

            var request = new StringContent(messageBody ?? string.Empty);
            request.Headers.ContentType = new MediaTypeHeaderValue("application/xml");

            if (AuthStrategy == FreshBooksClientAuthStrategy.Token)
            {
                var credentials = Encoding.UTF8.GetBytes(string.Format("{0}:X", Options.Token));
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                    Convert.ToBase64String(credentials));
            }
            else
            {

                throw new NotImplementedException("Current version of this client requires a Token to authenticate!");
            }

            response = await _httpClient.PostAsync(new Uri(_url), request, token);

            var responseContent = await response.Content.ReadAsStringAsync();
            var dto = responseContent.FromXmlString<T>();
            dto.StatusCode = response.StatusCode;

            if (!response.IsSuccessStatusCode && Options.ThrowOnFail)
            {
                throw new FreshBooksException(response.ReasonPhrase)
                {
                    StatusCode = response.StatusCode,
                    error = dto.error,
                    code = dto.code
                };
            }

            return dto;
        }
    }
}
