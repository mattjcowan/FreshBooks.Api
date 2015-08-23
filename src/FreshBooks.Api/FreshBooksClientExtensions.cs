using System.Net.Http;

namespace FreshBooks.Api
{
    public static class FreshBooksClientExtensions
    {
        public static FreshBooksClient FreshBooks(this HttpClient httpClient, string account, string token, bool throwOnFail = false)
        {
            return new FreshBooksClient(httpClient, account, new FreshBooksClientOptions
            {
                Token = token,
                ThrowOnFail = throwOnFail
            });
        }

        public static FreshBooksClient FreshBooks(this HttpClient httpClient, string account, FreshBooksClientOptions options)
        {
            return new FreshBooksClient(httpClient, account, options);
        }
    }
}