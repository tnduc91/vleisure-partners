<template>
    <div class="modal-container">
        <component :is="modal.name" :params="modal.params" :modal-id="modal.id" v-for="modal in modals"  :key="modal.id" v-on:close="close(modal.id)" v-on:success="modal.success"></component>
    </div>
</template>

<script lang="ts">
    import { Component, Prop, Vue, Watch } from "vue-property-decorator";

    @Component
    export default class ModalContainer extends Vue {
        $store: any;
        $modal: any;

        constructor() {
            super();
        }

        get modals() {
            return this.$store.state.modalStore;
        }

        close(modalId) {
            this.$store.commit("modalStore/close", modalId);
        }
    }
</script>