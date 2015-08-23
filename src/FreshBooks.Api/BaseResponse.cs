using System;
using System.Net;

namespace FreshBooks.Api
{
	public abstract partial class BaseResponse 
	{
		public HttpStatusCode StatusCode { get; set; }
        public string error { get; set; }
        public int code { get; set; }
    }
}
