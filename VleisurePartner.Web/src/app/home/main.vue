<template>
  <div>
      <p>Home page</p>
  </div>
</template>

<script lang="ts">
    import { Component, Prop, Vue, Watch } from "vue-property-decorator";
    import { HomeController } from "@proxy/HomeController";
    import OperationResult from "@src/infrastructure/OperationResult";


    @Component
    export default class Home extends Vue {
        private homeController: HomeController = new HomeController();
        private hotelListRes: ProxyModel.HotelListResponse;

        constructor() {
            super();
        }

        mounted(): void{
            this.getHotelList();
        }
        private getHotelList(): void {
            debugger;
            let req: ProxyModel.HotelListRequest = {
                arrivalDate : "12/29/2018",
                departureDate: "12/30/2018",
                hotelIds: [
                    632882,
                    148036,
                    100502
                ],
                roomGuests: [
                    {
                        numberOfAdults: 1,
                        numberOfChildren: 0,
                        childAges: []
                    }
                ],
                languageCode: "",
                cityCode: "",
                secretKey: "NsPqcQMB7HJ632jJp4vm4DCb",
                signature: "VkJMN09YdDZ5TFN6RDV3ZSs5Vnd0dz09"
            };

            this.homeController.getHotelList(req).then((response) => {
                debugger;
                let hotelListRes = response.successData;
            });
        }
    }
</script>