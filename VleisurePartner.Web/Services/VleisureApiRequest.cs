using RestSharp;
using VleisurePartner.Web.Models;
using VleisurePartner.Logic;
namespace VleisurePartner.Web.Services
{
    public class VleisureApiRequest : IVleisureApiRequest
    {
        public OperationResult<HotelListResponseModel> GetHotelList()
        {
            RestClient client = new RestClient("http://localhost:9075/api/");
            var requestBody = new HotelListRequestModel();
            var request = new RestRequest();
            request.Method = Method.POST;
            request.AddBody(requestBody);
            var response = client.Execute<HotelListResponseModel>(request);

            if (!response.IsSuccessful)
            {
                return new OperationResult<HotelListResponseModel>(OperationResult.OperationStatus.GeneralError, response.ErrorMessage.ToString());
            }

            return new OperationResult<HotelListResponseModel>(response.Data);
        }
        
    }
}