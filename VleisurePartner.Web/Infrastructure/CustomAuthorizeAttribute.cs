using System.Net.Mime;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace VleisurePartner.Web.Infrastructure
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            var user = httpContext.User;
            if (!user.Identity.IsAuthenticated)
            {
                return false;
            }

            return base.AuthorizeCore(httpContext);
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            var context = filterContext.RequestContext.HttpContext;
            if (context.Request.IsAuthenticated)
            {
                if (context.Request.IsAjaxRequest() || !filterContext.HttpContext.User.Identity.IsAuthenticated)
                {
                    filterContext.Result = new ContentResult
                    {
                        ContentType = MediaTypeNames.Text.Plain,
                        Content = "Unauthorized"
                    };
                    filterContext.HttpContext.Response.Status = "403 Unauthorised";
                }
                else
                {
                    filterContext.Result = new RedirectToRouteResult(
                        new RouteValueDictionary
                        {
                            { "action", "Unauthorized" },
                            { "controller", "Errors" }
                        });
                }
            }
            else
            {
                if (context.Request.IsAjaxRequest())
                {
                    filterContext.Result = new ContentResult
                    {
                        ContentType = MediaTypeNames.Text.Plain,
                        Content = "Unauthorized"
                    };
                    filterContext.HttpContext.Response.Status = "403 Unauthorised";
                }
                else
                {
                    base.HandleUnauthorizedRequest(filterContext);
                }
            }
        }
    }
}