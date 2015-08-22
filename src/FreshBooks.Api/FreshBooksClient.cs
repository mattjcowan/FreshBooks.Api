using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FreshBooks.Api
{
    public partial class FreshBooksClient
    {
        private string _url;
        private string _token;

        public FreshBooksClient(string account, string token)
        {
            if (string.IsNullOrWhiteSpace(account))
                throw new ArgumentNullException("account");
            if (string.IsNullOrWhiteSpace(token))
                throw new ArgumentNullException("token");

            this._url = string.Format("https://{0}.freshbooks.com/api/2.1/xml-in", account);
            this._token = token;
        }

        public async Task<T> SendAsync<T>(string messageBody = null) where T : class, new()
        {
            var response = await SendAsync("POST", _url, messageBody, CancellationToken.None);
            var responseContent = await response.Content.ReadAsStringAsync();
            return responseContent.FromXmlString<T>();
        }

        public async Task<T> SendAsync<T>(string method, string messageBody) where T : class, new()
        {
            var response = await SendAsync(method, _url, messageBody, CancellationToken.None);
            var responseContent = await response.Content.ReadAsStringAsync();
            return responseContent.FromXmlString<T>();
        }

        public async Task<T> SendAsync<T>(string method, string messageBody, CancellationToken token) where T : class, new()
        {
            var response = await SendAsync(method, _url, messageBody, token);
            var responseContent = await response.Content.ReadAsStringAsync();
            return responseContent.FromXmlString<T>();
        }

        private async Task<HttpResponseMessage> SendAsync(string method, string url, string messageBody, CancellationToken token)
        {

            if (String.IsNullOrEmpty(url))
                throw new ArgumentNullException("url");

            HttpResponseMessage response = null;

            using (var httpClient = new HttpClient())
            {
                var request = new StringContent(messageBody ?? string.Empty);
                request.Headers.ContentType = new MediaTypeHeaderValue("application/xml");
                var credentials = Encoding.UTF8.GetBytes(string.Format("{0}:X", this._token));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(credentials));

                if (method == "GET")
                {
                    response = await httpClient.GetAsync(new Uri(url), token);
                }
                else if (method == "POST")
                {
                    response = await httpClient.PostAsync(new Uri(url), request, token);
                }
                else if (method == "PUT")
                {
                    response = await httpClient.PutAsync(new Uri(url), request, token);
                }
                else if (method == "DELETE")
                {
                    response = await httpClient.DeleteAsync(new Uri(url), token);
                } else
                {
                    throw new ArgumentException("Unsupported http method " + method);
                }
            }

            return response;
        }
    }
}
