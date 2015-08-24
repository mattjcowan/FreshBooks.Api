using System;
using System.Threading;
using System.Threading.Tasks;

namespace FreshBooks.Api
{
    public partial class FreshBooksClient
    {
		
        public async Task<CallbackCreate.response> CallbackCreate(CallbackCreate.request request, CancellationToken? token = null)
        {
            return await SendAsync<CallbackCreate.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<CallbackDelete.response> CallbackDelete(CallbackDelete.request request, CancellationToken? token = null)
        {
            return await SendAsync<CallbackDelete.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<CallbackList.response> CallbackList(CallbackList.request request, CancellationToken? token = null)
        {
            return await SendAsync<CallbackList.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<CallbackResendToken.response> CallbackResendToken(CallbackResendToken.request request, CancellationToken? token = null)
        {
            return await SendAsync<CallbackResendToken.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<CallbackVerify.response> CallbackVerify(CallbackVerify.request request, CancellationToken? token = null)
        {
            return await SendAsync<CallbackVerify.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<CategoryCreate.response> CategoryCreate(CategoryCreate.request request, CancellationToken? token = null)
        {
            return await SendAsync<CategoryCreate.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
	}
}
