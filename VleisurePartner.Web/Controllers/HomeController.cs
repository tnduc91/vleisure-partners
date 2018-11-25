using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using VleisurePartner.Domain;
using VleisurePartner.EF;
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
        private readonly IContext _appDbContext;

        public HomeController(IVleisureApiRequest vleisureApiRequest,
            IContext appDbContext)
        {
            _vleisureApiRequest = vleisureApiRequest;
            _appDbContext = appDbContext;
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

        [HttpPost]
        public ProxyResult<RoomAvailabilityResponse> GetRoomAvailability(RoomAvailabilityRequest req)
        {
            var operationResult = _vleisureApiRequest.GetRoomAvailability(req);


            return operationResult.ToProxyResult();
        }

        [HttpPost]
        public ProxyResult<IEnumerable<RegionViewModel>> GetRegions(string searchString)
        {
            var regions = _appDbContext.Regions
                .Where(x => x.RegionNameLong.Contains(searchString))
                .ToList()
                .Select(x =>
                
                    new RegionViewModel
                    {
                        RegionId = x.RegionId,
                        RegionNameLong = x.RegionNameLong
                    }
                )
                .OrderBy(x => x.RegionNameLong.Length)
                .ToList();

            return ProxyResult<IEnumerable<RegionViewModel>>.Success(regions);
        }
        
    }
}