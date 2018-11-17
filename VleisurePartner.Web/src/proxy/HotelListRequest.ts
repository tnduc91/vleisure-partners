
/* tslint:disable */
declare namespace ProxyModel{
    
    export interface HotelListRequest extends GenericRequest {
        
        arrivalDate: string;
        departureDate: string;
        languageCode: string;
        cityCode: string;
        hotelIds: number[];
        roomGuests: RoomGuestRequestModel[];
        }
    
}