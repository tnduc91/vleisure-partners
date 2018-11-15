using RestSharp;
using System;
using VleisurePartner.Web.Models;
using VleisurePartner.Logic;
using System.Collections.Generic;
namespace VleisurePartner.Web.Services
{
    public class VleisureApiRequest : IVleisureApiRequest
    {
        public OperationResult<HotelListResponseModel> GetHotelList()
        {
            RestClient client = new RestClient("https://hotels-dev.mekongleisuretravel.com/ihs/v2/list");
            var requestBody = new HotelListRequestModel();

            requestBody.CityCode = "";
            requestBody.ArrivalDate = "12/29/2018";
            requestBody.DepartureDate = "12/30/2018";
            requestBody.RoomGuests = new List<RoomGuestRequestModel>();
            var roomguest = new RoomGuestRequestModel();
            roomguest.NumberOfAdults = 1;
            requestBody.RoomGuests.Add(roomguest);

            var request = new RestRequest();
            request.Method = Method.POST;
            request.AddBody(requestBody);
            var response = client.Execute<HotelListResponseModel>(request);
            var data = response.Data;
            if (!response.IsSuccessful)
            {
                return new OperationResult<HotelListResponseModel>(OperationResult.OperationStatus.GeneralError, response.ErrorMessage.ToString());
            }

            return new OperationResult<HotelListResponseModel>(response.Data);
        }
        
    }
}