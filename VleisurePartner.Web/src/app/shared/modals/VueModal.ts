import { Vue } from "vue-property-decorator";

export default class VueModal extends Vue {
    public $modal: any;
    constructor() {
        super();
    }
    mounted(): void {
        this.$modal = $(this.$el);
        this.$modal.modal("show");
        this.$modal.on("hidden.bs.modal", e => {
            this.$emit("close");
        });
    }

    protected hideModal(): void {
        this.$modal.modal("hide");
    }
}