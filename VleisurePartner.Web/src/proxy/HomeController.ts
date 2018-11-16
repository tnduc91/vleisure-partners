

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
    
        public searchHotel = (): Promise<OperationResult<ProxyModel.HotelListResponseModel>> => {
            const route = `api/Home/`;
            return HttpService.Instance.request({
                url: this.GetUrl(route, 'HomeController','SearchHotel'),
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
