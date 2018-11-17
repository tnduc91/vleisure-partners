using VleisurePartner.Web.Models.RequestModels;
using VleisurePartner.Web.Models;
using VleisurePartner.Logic;
using VleisurePartner.Web.Models.ResponseModels;

namespace VleisurePartner.Web.Services
{
    public interface IVleisureApiRequest
    {
        OperationResult<HotelListResponse> GetHotelList(HotelListRequest request);
        OperationResult<HotelDetailsResponse> GetHotelDetails(HotelDetailsRequest request);
    }
}