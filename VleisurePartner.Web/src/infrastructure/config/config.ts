import { VueRouter } from "vue-router/types/router";

export class AppConfig {
    private static _instance: AppConfig;
    private constructor() {
    }

    public static get Instance() {
        // Do you need arguments? Make it a regular method instead.
        return this._instance || (this._instance = new this());
    }

    // Global config value
    private _tenant: string = "";
    public setTenant(tenant: string): void {
        this._tenant = tenant;
    }
    public getTenant(): string {        
        return this._tenant;
    }

    private _vueRouter: VueRouter;
    public setVueRouter(router: VueRouter){
        this._vueRouter = router;
    }

    public getVueRouter(){
        return this._vueRouter;
    }
}