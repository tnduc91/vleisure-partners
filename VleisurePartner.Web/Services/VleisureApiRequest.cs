using RestSharp;
using System;
using VleisurePartner.Web.Models;
using VleisurePartner.Logic;
using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace VleisurePartner.Web.Services
{
    public class VleisureApiRequest : IVleisureApiRequest
    {
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

        public OperationResult<HotelListResponseModel> GetHotelList(HotelListRequest request)
        {

            var requestBody = new HotelListRequest();
            requestBody.CityCode = "";
            requestBody.ArrivalDate = "12/29/2018";
            requestBody.DepartureDate = "12/30/2018";
            requestBody.RoomGuests = new List<RoomGuestRequestModel>();
            requestBody.HotelIds = new List<int>() { 632882, 148036, 100502 };

            var roomGuest = new RoomGuestRequestModel();
            roomGuest.NumberOfAdults = 1;
            requestBody.RoomGuests.Add(roomGuest);

            var client = new RestClient("https://hotels-dev.mekongleisuretravel.com/ihs/v2/list");
            var restRequest = InitRestRequest(requestBody);
            var response = client.Execute(restRequest);
            
            if (response.IsSuccessful)
            {
                if (response.ContentType.Contains("application/json"))
                {
                    //var content = Newtonsoft.Json.JsonConvert.DeserializeObject<HotelListResponseModel>(response.Content);
                    JavaScriptSerializer oJS = new JavaScriptSerializer();
                    var hotelListResponse = new HotelListResponseModel();
                    hotelListResponse = oJS.Deserialize<HotelListResponseModel>(response.Content);
                    return new OperationResult<HotelListResponseModel>(hotelListResponse);
                }
            }

            
            return new OperationResult<HotelListResponseModel>(OperationResult.OperationStatus.GeneralError, response.ErrorMessage.ToString());

        }
        
    }
}