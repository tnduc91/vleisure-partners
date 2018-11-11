import axios, { AxiosRequestConfig } from "axios";
import { AppConfig } from "@infrastructure/config/config";
import * as _ from "lodash";
export class HttpService {

    private static _instance: HttpService;

    public static get Instance() {
        return this._instance || (this._instance = new this());
    }

    request<T>(httpConfig: AxiosRequestConfig): Promise<T> {
        httpConfig.url = this.getTenantUrl(httpConfig.url);

        if (httpConfig.method.toLowerCase() == "get") {
            httpConfig.params = httpConfig.data;
        }
        var self = this;
        var response = axios.request(httpConfig);

        return new Promise<T>((resolve) => {
            response.then((success) => {
                self.handleAjaxResponse(success, resolve);
            }).catch((error) => self.onError(error.response.status, error.response.statusText));
        });
    }

    get(url: string, params?: any) {
        return this.request({
            method: HttpRequestType[HttpRequestType.Get],
            url: url,
            params: params,
            headers: { Pragma: "no-cache" }
        });
    }

    post(url: string, data?: any) {
        return this.request({
            method: HttpRequestType[HttpRequestType.Post],
            url: url,
            data: data
        });
    }

    private handleAjaxResponse(response, resolve){
        var data = response.data;
        switch(data.status) {
           case OperationResultStatus.NotFound: {
                this.onError("404", data.errorMessages[0]);
                break;
           }
           case OperationResultStatus.Unauthorized: {
              this.onError("401", data.errorMessages[0]);
              break;
            }
           default: {
               resolve(data);
               break;
           }
        }
    }

    private getTenantUrl(url: string): string {
        var tenant = AppConfig.Instance.getTenant().toLowerCase();

        if (location.pathname.toLowerCase().indexOf(`/${tenant}`) >= 0) {
            return `/${tenant}/${url}`;
        }

        return url;
    }

    private _isSigningOut: boolean = false;

    private onError(errorStatus, errorMessage) {
        const router = AppConfig.Instance.getVueRouter();
        router.push({ name: "error", params: { errorCode: errorStatus, errorMessage: errorMessage } });
    }
}

enum HttpRequestType {
    Get,
    Post,
    Delete,
    Put
}

enum OperationResultStatus {
    Successful = 0,
    GeneralError = 1,
    NotFound = 2,
    InvalidArguments = 3,
    Unauthorized = 4,
    FailedValidation = 5
}