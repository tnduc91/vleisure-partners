import Vue, { PluginObject, ComponentOptions } from "vue";

declare interface IDialogModal {
    confirm(title: string, text: string, yesFunction: Function, noFunction?: Function): void;
    info(title: string, message: string, callback: Function)
}

declare module "vue/types/vue" {
  interface Vue {
    $dialog: IDialogModal;
  }
}