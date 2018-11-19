using System.Collections.Generic;
using System.Web.Mvc;
using VleisurePartner.Web.Models;
using VleisurePartner.Web.Models.RequestModels;
using VleisurePartner.Web.Infrastructure;
using VleisurePartner.Web.Models.ResponseModels;
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

            return View();
        }

        [HttpPost]
        public ProxyResult<HotelListRs> GetHotelList(HotelListRequest req)
        {
        //    var requestBody = new HotelListRequest
        //    {
        //        CityCode = "",
        //        ArrivalDate = "12/29/2018",
        //        DepartureDate = "12/30/2018",
        //        RoomGuests = new List<RoomGuestRequestModel>(),
        //        HotelIds = new int[]{
        //        632882,
        //        148036,
        //        100502 }
        //    };
        //    var roomGuest = new RoomGuestRequestModel();
        //    roomGuest.NumberOfAdults = 1;
        //    requestBody.RoomGuests.Add(roomGuest);
            
            var operationResult = _vleisureApiRequest.GetHotelList(req);


            return operationResult.ToProxyResult();
        }
        
        [HttpPost]
        public ProxyResult<HotelDetailsResponse> GetHotelDetails(HotelDetailsRequest req)
        {
            var requestBody = new HotelDetailsRequest
            {
                ArrivalDate = "12/29/2018",
                DepartureDate = "12/30/2018",
                RoomGuests = new List<RoomGuestRequestModel>(),
                HotelId = 632882
            };
            var roomGuest = new RoomGuestRequestModel();
            roomGuest.NumberOfAdults = 1;
            requestBody.RoomGuests.Add(roomGuest);
            
            var operationResult = _vleisureApiRequest.GetHotelDetails(requestBody);

            return operationResult.ToProxyResult();
        }
    }
}