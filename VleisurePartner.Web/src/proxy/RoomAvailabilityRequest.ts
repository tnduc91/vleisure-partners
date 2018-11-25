
/* tslint:disable */
declare namespace ProxyModel{
    
    export interface RoomAvailabilityRequest extends GenericRequest {
        
        arrivalDate: string;
        departureDate: string;
        hotelId: number;
        cityCode: string;
        token: string;
        sessionId: string;
        roomGuests: RoomGuestRequestModel[];
        roomTypeCode: string[];
        rateCode: string[];
        }
    
}