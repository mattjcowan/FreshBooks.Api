using System.Net;
using System.Net.Http;

namespace FreshBooks.Api
{
    public class FreshBooksException : HttpRequestException
    {
        public FreshBooksException(string message): base(message) { }
        
        public HttpStatusCode StatusCode { get; set; }
        public string error { get; set; }
        public int code { get; set; }
    }
}