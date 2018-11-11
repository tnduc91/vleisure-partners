using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace VleisurePartner.Logic.Transport
{
    public interface IEndPoint
    {
        Task<HttpRequestOperationResult<TResponse>> GetAsync<TResponse>(string path);
        Task<HttpRequestOperationResult<TResponse>> GetAsync<TRequest, TResponse>(string path, TRequest requestDataObject);
        Task<HttpRequestOperationResult<TResponse>> PostAsync<TRequest, TResponse>(string path, TRequest requestDataObject);

        [Obsolete("This is a stop gap for posting jQuery DataTables form data.")]
        Task<HttpRequestOperationResult<TResponse>> PostAsync<TResponse>(string path, HttpContent content);

        Task<HttpRequestOperationResult<TResponse>> PutAsync<TRequest, TResponse>(string path, TRequest requestDataObject);
    }
}