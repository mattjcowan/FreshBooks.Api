using System;
using System.Threading.Tasks;

namespace FreshBooks.Api
{
    public partial class FreshBooksClient
    {
		
        public async Task<CallbackCreate.response> CallbackCreate(CallbackCreate.request request)
        {
            return await SendAsync<CallbackCreate.response>(request.ToXmlString());
        }
		
        public async Task<CallbackDelete.response> CallbackDelete(CallbackDelete.request request)
        {
            return await SendAsync<CallbackDelete.response>(request.ToXmlString());
        }
		
        public async Task<CallbackList.response> CallbackList(CallbackList.request request)
        {
            return await SendAsync<CallbackList.response>(request.ToXmlString());
        }
		
        public async Task<CallbackResendToken.response> CallbackResendToken(CallbackResendToken.request request)
        {
            return await SendAsync<CallbackResendToken.response>(request.ToXmlString());
        }
		
        public async Task<CallbackVerify.response> CallbackVerify(CallbackVerify.request request)
        {
            return await SendAsync<CallbackVerify.response>(request.ToXmlString());
        }
	}
}
