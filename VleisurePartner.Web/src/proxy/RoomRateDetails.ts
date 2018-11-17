
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
        rateInfos: RateInfo;
        valueAdds: ValueAdd[];
        }
    
}