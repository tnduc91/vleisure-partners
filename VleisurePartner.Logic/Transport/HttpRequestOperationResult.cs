using System.Net;

namespace VleisurePartner.Logic.Transport
{
    public class HttpRequestOperationResult<TData> : OperationResult<TData>
    {
        public HttpStatusCode HttpStatusCode { get; }

        /// <summary>
        /// Creates a successful HttpRequestOperationResult with the specified data.
        /// </summary>
        /// <param name="data">The success data.</param>
        public HttpRequestOperationResult(TData data) : base(data)
        {
            HttpStatusCode = HttpStatusCode.OK;
        }

        /// <summary>
        /// Creates an HttpRequestOperationResult with the specified http status code.
        /// It is intended that a successful status code does not have any messages, and an unsuccessful status code may have messages.
        /// </summary>
        /// <param name="httpStatusCode">The http status code.</param>
        /// <param name="errorMessages">The error messages.</param>
        public HttpRequestOperationResult(HttpStatusCode httpStatusCode, params string[] errorMessages)
            : base(httpStatusCode == HttpStatusCode.OK ? OperationStatus.Successful
                : httpStatusCode == HttpStatusCode.NotFound ? OperationStatus.NotFound
                : httpStatusCode == HttpStatusCode.BadRequest ? OperationStatus.InvalidArguments
                : httpStatusCode == HttpStatusCode.Unauthorized ? OperationStatus.Unauthorized
                : OperationStatus.GeneralError,
                  errorMessages)
        {
            HttpStatusCode = httpStatusCode;
        }
    }
}