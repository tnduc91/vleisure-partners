import "bootstrap-notify/bootstrap-notify.js";
import OperationResult from "@infrastructure/OperationResult";
import { INotification } from "@src/app/shared/plugins/Notification";


export class Notification implements INotification {

    public show(text: string, type: string = "alert") {
        var content = {
            message: text,
        };
        var options = {
            template: `<div data-notify="container" class="col-xs-11 col-sm-4 alert alert-{0}" role="alert">
                            <button type="button" aria-hidden="true" class="close" data-notify="dismiss">&times;</button>
                            <span data-notify="icon"></span>
                            <span data-notify="title">{1}</span>
                            <span data-notify="message">{2}</span>
                            <div class="progress" data-notify="progressbar">
                                <div class="progress-bar progress-bar-{0}" role="progressbar" aria-valuenow="0" aria-valuemin="0" aria-valuemax="100" style="width: 0%;"></div>
                            </div> 
                            <a href="{3}" target="{4}" data-notify="url"></a>
                       </div>`,
            type:type,
            z_index: 2000
        };
        var notiBox = $.notify(content, options);
        $(notiBox.$ele).find("[data-notify=\"dismiss\"]").css({
			top: "50%"
		});
    }

    public success = (text: string) => {
        this.show(text, "success");
    }

    public error = (text: string) =>  {
        this.show(text, "danger");
    }

    public warning = (text: string) => {
        this.show(text, "warning");
    }

    public info = (text: string) => {
        this.show(text, "info");
    }

    public handleOperationResult<T>(result: OperationResult<T>): void {
        if (result.isSuccessful) {
            this.success("Operation successful");
        } else {
            if (result.errorMessages.length > 0) {
                for (let i: number = 0; i < result.errorMessages.length; i++) {
                    this.error(result.errorMessages[i]);
                }
            } else {
                this.error("Operation failed");
            }
        }
    }
}

export default {
    install: function(Vue, opts) {
        const noty = new Notification();
        Vue.prototype.$noty = noty;
        Vue.noty = noty;
    }
};