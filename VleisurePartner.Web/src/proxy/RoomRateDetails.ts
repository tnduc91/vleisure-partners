
/* tslint:disable */
declare namespace ProxyModel{
    
    export interface RoomRateDetails  {
        
        token: string;
        roomTypeCode: string[];
        rateCode: string[];
        maxRoomOccupancy: number;
        quotedRoomOccupancy: number;
        minGuestAge: number;
        roomDescription: string[];
        bedTypes: BedType[];
        rateInfos: RateInfo;
        valueAdds: ValueAdd[];
        }
    
}