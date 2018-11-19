using System.Web;
using System.Web.Mvc;
using VleisurePartner.Web.Infrastructure;

namespace VleisurePartner.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //filters.Add(new CustomAuthorizeAttribute());
            //filters.Add(new CustomHandleErrorAttribute(httpApplication, true));
            filters.Add(new JsonNetActionFilter());
        }
    }
}
