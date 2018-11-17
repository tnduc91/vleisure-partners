using System.Collections.Generic;
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

            var requestBody = new HotelListRequest();
            requestBody.CityCode = "1";
            requestBody.ArrivalDate = "12/29/2018";
            requestBody.DepartureDate = "12/30/2018";
            requestBody.RoomGuests = new List<RoomGuestRequestModel>();
            //requestBody.HotelIds = new List<int>() { 632882, 148036, 100502 };
            var roomGuest = new RoomGuestRequestModel();
            roomGuest.NumberOfAdults = 1;
            requestBody.RoomGuests.Add(roomGuest);

            var res = SearchHotel(requestBody);


            return View();
        }



        [HttpPost]
        public ProxyResult<HotelListResponseModel> SearchHotel(HotelListRequest req)
        {
            var operationResult = _vleisureApiRequest.GetHotelList(req);

            return operationResult.ToProxyResult();
        }
    }
}