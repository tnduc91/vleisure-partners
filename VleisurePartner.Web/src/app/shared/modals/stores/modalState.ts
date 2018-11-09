declare namespace Modals {
    // tslint:disable-next-line:interface-name
    export interface ModalState {
        id?: number;
        name: string;
        params: any;
        success: Function;
    }
}