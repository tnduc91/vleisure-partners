

/* tslint:disable */

import { HttpService } from '@infrastructure/transport/httpservice'
import OperationResult from '@infrastructure/OperationResult'
import { AppConfig } from '@infrastructure/config/config'


export class HomeController {
    
        public index = (): Promise<OperationResult<any>> => {
            const route = `api/Home/`;
            return HttpService.Instance.request({
                url: this.GetUrl(route, 'HomeController','Index'),
                method: "post",
                data: null,
                headers: {'X-Requested-With': 'XMLHttpRequest'}
            });
        };
    
        public getHotelList = (req: ProxyModel.HotelListRequest): Promise<OperationResult<ProxyModel.HotelListRs>> => {
            const route = `api/Home/`;
            return HttpService.Instance.request({
                url: this.GetUrl(route, 'HomeController','GetHotelList'),
                method: "post",
                data: req,
                headers: {'X-Requested-With': 'XMLHttpRequest'}
            });
        };
    
        public getHotelDetails = (req: ProxyModel.HotelDetailsRequest): Promise<OperationResult<ProxyModel.HotelDetailsResponse>> => {
            const route = `api/Home/`;
            return HttpService.Instance.request({
                url: this.GetUrl(route, 'HomeController','GetHotelDetails'),
                method: "post",
                data: req,
                headers: {'X-Requested-With': 'XMLHttpRequest'}
            });
        };
    
        public getRoomAvailability = (req: ProxyModel.RoomAvailabilityRequest): Promise<OperationResult<ProxyModel.RoomAvailabilityResponse>> => {
            const route = `api/Home/`;
            return HttpService.Instance.request({
                url: this.GetUrl(route, 'HomeController','GetRoomAvailability'),
                method: "post",
                data: req,
                headers: {'X-Requested-With': 'XMLHttpRequest'}
            });
        };
    
        public getRegions = (searchString: string): Promise<OperationResult<ProxyModel.RegionViewModel[]>> => {
            const route = `api/Home/?searchString=${encodeURIComponent(searchString)}`;
            return HttpService.Instance.request({
                url: this.GetUrl(route, 'HomeController','GetRegions'),
                method: "post",
                data: null,
                headers: {'X-Requested-With': 'XMLHttpRequest'}
            });
        };
    
    
    
    private GetUrl(route: string, controller : string,  action : string): string {
        controller = controller.replace('Controller','');

        const param : string[] = route.split("?");
        if(param[1]){
            return `${controller}/${action}?${param[1]}`;
        }

        return `${controller}/${action}`;
    }
}
