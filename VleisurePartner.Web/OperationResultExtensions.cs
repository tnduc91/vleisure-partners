using VleisurePartner.Logic;
using VleisurePartner.Web.Infrastructure;

namespace VleisurePartner.Web
{
    public static class OperationResultExtensions
    {
        public static ProxyResult<TModel> ToProxyResult<TModel>(this OperationResult<TModel> operationResult)
        {
            return new ProxyResult<TModel>(operationResult);
        }
    }
}