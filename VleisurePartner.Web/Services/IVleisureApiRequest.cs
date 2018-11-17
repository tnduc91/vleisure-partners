using VleisurePartner.Web.Models;
using VleisurePartner.Logic;

namespace VleisurePartner.Web.Services
{
    public interface IVleisureApiRequest
    {
        OperationResult<HotelListResponseModel> GetHotelList(HotelListRequest request);
    }
}