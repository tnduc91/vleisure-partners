// Themes Import
import "./themes";

// App Import
import RouterConfig from "@infrastructure/config/router";
import { AppConfig } from "@infrastructure/config/config";
import Notification from "@src/app/shared/plugins/Notification/notification";
import ConfirmDialog from "@src/app/shared/plugins/Dialogs/confirmDialog";
import ModalContainer from "@app/shared/modals/main.vue";
import ModalStore from "@app/shared/modals/stores/modalStore";
import "@app/shared/filters/filters";

// node_modules Import
import Vuex from "vuex";
import vuexI18n from "vuex-i18n";
import Vue, { PluginObject } from "vue";
import VeeValidate from "vee-validate";
import { ComponentOptions } from "vue/types/options";
import VueRouter, { RouterOptions } from "vue-router";
import VModal from "vue-js-modal";
import BootstrapVue from "bootstrap-vue";
import "es6-promise/auto";
import * as tinymce from "tinymce/tinymce";
import "tinymce/themes/modern/theme";
import CreatePersistedState from "vuex-persistedstate";

// Plugin Reference
Vue.use(Vuex);
Vue.use(VueRouter as PluginObject<Vue>);
Vue.use(BootstrapVue as PluginObject<Vue>);
Vue.use(VModal, { dialog: true });
Vue.use(VeeValidate, { fieldsBagName: "formFields" });
Vue.use(Notification as PluginObject<Vue>);
Vue.use(ConfirmDialog as PluginObject<Vue>);

 
import vSelect from 'vue-select'
Vue.component('v-select', vSelect)

const store = new Vuex.Store({
    modules: {
        modalStore: ModalStore,
    },
    plugins: [CreatePersistedState({ paths: ["calendarStore"] })]
});


const router = new VueRouter(RouterConfig as RouterOptions);
AppConfig.Instance.setVueRouter(router);

const app = new Vue({
    el: "#app",
    router,
    store,
    components: {
        ModalContainer
    }
});
//Config TinyMCE BaseURL to make it works with IE
var appBaseUrl = window.location.origin;
if (typeof location === "undefined") {
    appBaseUrl = window.location.protocol + "//" + window.location.host;
}
tinymce.baseURL = appBaseUrl + "/dist/main.js";

// fade in after render completed
$("#app").fadeIn();