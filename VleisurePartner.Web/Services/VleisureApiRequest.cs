using RestSharp;
using System;
using VleisurePartner.Web.Models.RequestModels;
using VleisurePartner.Logic;
using System.Web.Script.Serialization;
using VleisurePartner.Web.Models.ResponseModels;

namespace VleisurePartner.Web.Services
{
    public class VleisureApiRequest : IVleisureApiRequest
    {
        private readonly JavaScriptSerializer _javaScriptScriptSerializer;

        public VleisureApiRequest()
        {
            _javaScriptScriptSerializer = new JavaScriptSerializer();
        }

        private string ToJsonString(Object obj)
        {
            var jsonParam = new JavaScriptSerializer().Serialize(obj);
            return jsonParam;
        }

        private RestRequest InitRestRequest(Object requestModel)
        {
            var jsonParam = ToJsonString(requestModel);

            var request = new RestRequest
            {
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };

            request.AddHeader("Accept", "application/json");
            request.Parameters.Clear();
            request.AddParameter("application/json", jsonParam, ParameterType.RequestBody);

            return request;
        }

        public OperationResult<HotelListResponse> GetHotelList(HotelListRequest request)
        {
            var client = new RestClient("https://hotels-dev.mekongleisuretravel.com/ihs/v2/list");
            var restRequest = InitRestRequest(request);
            var response = client.Execute(restRequest);
            
            if (response.IsSuccessful)
            {
                if (response.ContentType.Contains("application/json"))
                {
                    var hotelListResponse = _javaScriptScriptSerializer.Deserialize<HotelListResponse>(response.Content);
                    return new OperationResult<HotelListResponse>(hotelListResponse);
                }
            }

            return new OperationResult<HotelListResponse>(OperationResult.OperationStatus.GeneralError, response.ErrorMessage.ToString());
        }

        public OperationResult<HotelDetailsResponse> GetHotelDetails(HotelDetailsRequest req)
        {
            var client = new RestClient("https://hotels-dev.mekongleisuretravel.com/ihs/v2/detail");
            var restRequest = InitRestRequest(req);
            var response = client.Execute(restRequest);

            if (response.IsSuccessful)
            {
                if (response.ContentType.Contains("application/json"))
                {
                    var hotelDetailsResponse = _javaScriptScriptSerializer.Deserialize<HotelDetailsResponse>(response.Content);
                    return new OperationResult<HotelDetailsResponse>(hotelDetailsResponse);
                }
            }

            return new OperationResult<HotelDetailsResponse>(OperationResult.OperationStatus.GeneralError, response.ErrorMessage.ToString());

        }

    }
}