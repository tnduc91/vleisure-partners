import Vue, { PluginObject, ComponentOptions } from "vue";
import OperationResult from "@infrastructure/OperationResult";

declare interface INotification {
    show(text: string, type: string): void;

    success(text: string): void;

    error(text: string): void;

    warning(text: string): void;

    info(text: string): void;

    handleOperationResult<T>(result: OperationResult<T>): void;
}

declare module "vue/types/vue" {
  interface Vue {
    $noty: INotification;
  }
}