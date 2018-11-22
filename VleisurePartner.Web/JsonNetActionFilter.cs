using System.Web.Mvc;

namespace VleisurePartner.Web
{
    public class JsonNetActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var jsonResult = UnpackAsJsonResult(filterContext);
            if (jsonResult != null)
            {
                filterContext.Result = new JsonNetResult(jsonResult);
            }

            base.OnActionExecuted(filterContext);
        }

        private JsonResult UnpackAsJsonResult(ActionExecutedContext filterContext)
        {
            var requestHandlerActionResult = filterContext.Result as RequestHandlerActionResult;
            if (requestHandlerActionResult != null)
            {
                return requestHandlerActionResult.GetExecutingActionResult() as JsonResult;
            }

            return filterContext.Result as JsonResult;
        }
    }
}