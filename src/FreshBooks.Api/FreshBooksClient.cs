using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Types = FreshBooks.Api.ServiceTypes;

namespace FreshBooks.Api
{
    public enum Http
    {
        Get,
        Post,
        Put,
        Delete
    }

    public class FreshBooksClient
    {
        private string _url;
        private string _token;

        public FreshBooksClient(string url, string token)
        {
            if (string.IsNullOrWhiteSpace(url))
                throw new ArgumentNullException("url");
            if (string.IsNullOrWhiteSpace(token))
                throw new ArgumentNullException("token");

            this._url = url;
            this._token = token;
        }

        #region Callbacks
        public async Task<Types.CallbackCreateResponse> Exec(Types.CallbackCreateRequest request)
        {
            return await SendAsync<Types.CallbackCreateResponse>(Http.Post, request.ToXmlString());
        }
        public async Task<Types.StatusOnlyResponse> Exec(Types.CallbackDeleteRequest request)
        {
            return await SendAsync<Types.StatusOnlyResponse>(Http.Post, request.ToXmlString());
        }
        public async Task<Types.CallbackListResponse> Exec(Types.CallbackListRequest request)
        {
            return await SendAsync<Types.CallbackListResponse>(Http.Post, request.ToXmlString());
        }
        public async Task<Types.StatusOnlyResponse> Exec(Types.CallbackResendTokenRequest request)
        {
            return await SendAsync<Types.StatusOnlyResponse>(Http.Post, request.ToXmlString());
        }
        public async Task<Types.StatusOnlyResponse> Exec(Types.CallbackVerifyRequest request)
        {
            return await SendAsync<Types.StatusOnlyResponse>(Http.Post, request.ToXmlString());
        }
        #endregion

        // this method will ensure that all request/responses are properly matching up as compile time
        public async Task<TReturn> Exec<TRequest, TReturn>(TRequest request) 
            where TRequest : class, Types.IReturn<TReturn>, new() 
            where TReturn: class, Types.IServiceTypeResponse, new()
        {
            return await SendAsync<TReturn>(Http.Post, request.ToXmlString());
        }

        public async Task<T> SendAsync<T>(Http method, string messageBody) where T : class, new()
        {
            var response = await SendAsync(method, _url, messageBody, CancellationToken.None);
            var responseContent = await response.Content.ReadAsStringAsync();
            return responseContent.FromXmlString<T>();
        }

        public async Task<T> SendAsync<T>(Http method, string messageBody, CancellationToken token) where T : class, new()
        {
            var response = await SendAsync(method, _url, messageBody, token);
            var responseContent = await response.Content.ReadAsStringAsync();
            return responseContent.FromXmlString<T>();
        }

        private async Task<HttpResponseMessage> SendAsync(Http method, string url, string messageBody, CancellationToken token)
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

                if (method == Http.Get)
                {
                    response = await httpClient.GetAsync(new Uri(url), token);
                }
                else if (method == Http.Post)
                {
                    response = await httpClient.PostAsync(new Uri(url), request, token);
                }
                else if (method == Http.Put)
                {
                    response = await httpClient.PutAsync(new Uri(url), request, token);
                }
                else if (method == Http.Delete)
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
