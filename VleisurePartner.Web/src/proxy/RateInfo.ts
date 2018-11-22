
/* tslint:disable */
declare namespace ProxyModel{
    
    export interface RateInfo  {
        
        priceBreakDown: boolean;
        promo: boolean;
        rateChange: boolean;
        roomGroup: RoomGroup[];
        chargeableRateInfo: ChargeableRateInfo;
        nonRefundable: boolean;
        promoDescription: string;
        currentAllotment: string;
        cancellationList: string;
        }
    
}