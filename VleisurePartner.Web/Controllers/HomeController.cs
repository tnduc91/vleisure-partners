using System.Web.Mvc;
using VleisurePartner.Web.Models;
using VleisurePartner.Web.Infrastructure;
using VleisurePartner.Web.Services;

namespace VleisurePartner.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IVleisureApiRequest _vleisureApiRequest;

        public HomeController(IVleisureApiRequest vleisureApiRequest)
        {
            _vleisureApiRequest = vleisureApiRequest;
        }

        public ActionResult Index()
        {
            var operationResult = _vleisureApiRequest.GetHotelList();
            return View();
        }



        [HttpPost]
        public ProxyResult<HotelListResponseModel> SearchHotel()
        {
            var operationResult = _vleisureApiRequest.GetHotelList();

            return operationResult.ToProxyResult();
        }
    }
}