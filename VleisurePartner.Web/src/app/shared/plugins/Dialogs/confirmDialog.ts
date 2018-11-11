import { IDialogModal } from "@src/app/shared/plugins/Dialogs";
import Vue from "vue";

class ConfirmDialog extends Vue implements IDialogModal {
    confirm(title: string, text: string, yesFunction: Function, noFunction?: Function): void {
        this.$modal.show("dialog", {
            title: title,
            text: text,
            buttons: [
                {
                    title: "Yes",
                    handler: () => {
                        yesFunction();
                        this.$modal.hide("dialog");
                    }
                },
                {
                    title: "No",
                    handler: () => {
                        //help us to check noFunction is a function or not.
                        var getType = {};
                        if (noFunction && getType.toString.call(noFunction) === "[object Function]") {
                            noFunction();
                        }
                        this.$modal.hide("dialog");
                    }
                }
            ]
        });
    }

    info(title: string, message: string, callback: Function): void {
        this.$modal.show("dialog", {
            title: title,
            text: message,
            buttons: [
                {
                    title: "Ok",
                    handler: () => {
                        callback();
                        this.$modal.hide("dialog");
                    }
                }
            ]
        });
    }
}

export default {
    install: function (Vue, opts) {
        Vue.prototype.$dialog = new ConfirmDialog();
    }
};