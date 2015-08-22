using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshBooks.Api.ServiceTypes
{
    public interface IReturn<T> where T : IServiceTypeResponse
    {
    }

    public interface IServiceTypeResponse
    {
        string Status { get; set; }
        string ErrorMessage { get; set; }
        string ErrorCode { get; set; }
    }

    public static class ServiceTypeExtensions
    {
        public static bool IsError(this IServiceTypeResponse response) { return response.Status != "ok"; }
        public static bool IsSuccess(this IServiceTypeResponse response) { return response.Status == "ok"; }
        public static bool IsUnknownStatus(this IServiceTypeResponse response) { return !response.IsError() && !response.IsSuccess(); }
    }
}
