import { Module } from "vuex";
import * as _ from "lodash";

export default {
    namespaced: true,
    state: new Array<Modals.ModalState>(0),
    mutations: {
        show(state: Modals.ModalState[], data: Modals.ModalState): void {
            state.push({
                id: _.random(1, 1000, false),
                name: data.name,
                params: data.params,
                success: data.success
            });
        },
        close(state: Modals.ModalState[], modalId: number): void {
            let dialogs: Modals.ModalState[] = state.filter((value) => {
                return value.id === modalId;
            });
            if (dialogs.length === 1) {
                let dialogIndex: number = state.indexOf(dialogs[0]);
                state.splice(dialogIndex, 1);
            }
        }
    },
    actions: {
        show(context: any, data: Modals.ModalState): void {
           context.commit("show", data);
        },
        close(context: any, modalId: number): void {
            context.commit("close", modalId);
        }
    }
};