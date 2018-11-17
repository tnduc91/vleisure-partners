using VleisurePartner.Web.Models.RequestModels;
using VleisurePartner.Web.Models;
using VleisurePartner.Logic;

namespace VleisurePartner.Web.Services
{
    public interface IVleisureApiRequest
    {
        OperationResult<HotelListResponse> GetHotelList(HotelListRequest request);
        OperationResult<HotelDetailsResponse> GetHotelDetails(HotelDetailsRequest request);
    }
}