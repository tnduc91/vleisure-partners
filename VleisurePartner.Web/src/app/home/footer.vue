<template>
    <!--footer-widget -->
    <div class="footer-widget">
        <div class="row">
            <div class="col-md-4"><a class="contact-btn color-bg" href="contacts.html">Get In Touch<i class="fal fa-envelope"></i></a></div>
            <div class="col-md-8">
                <div class="customer-support-widget fl-wrap">
                    <h4>Customer support : </h4>
                    <a href="tel:+19012300888" class="cs-mumber">+1(901)2300888</a>
                    <a href="tel:+19012300888" class="cs-mumber-button color2-bg">Call Now <i class="far fa-phone-volume"></i></a>
                </div>
            </div>
        </div>
    </div>
    <!--footer-widget end -->
</template>


<script lang="ts">
    import { Component, Prop, Vue, Watch } from "vue-property-decorator";
    @Component
    export default class Footer extends Vue {
        constructor() {
            super();
        }
    }
</script>