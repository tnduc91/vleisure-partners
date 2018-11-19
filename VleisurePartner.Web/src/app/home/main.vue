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
        private hotelListRs: ProxyModel.HotelListRs;

        constructor() {
            super();
        }

        mounted(): void{
            this.getHotelList();
        }
        private getHotelList(): void {
            let roomGuest: ProxyModel.RoomGuestRequestModel = {
                numberOfAdults: 1,
                numberOfChildren: 0,
                childAges: []
            };

            let roomGuestList = new Array<ProxyModel.RoomGuestRequestModel>();
            roomGuestList = [roomGuest];

            let req: ProxyModel.HotelListRequest = {
                arrivalDate : "12/29/2018",
                departureDate: "12/30/2018",
                hotelIds: [
                    632882,
                    148036,
                    100502
                ],
                roomGuests: roomGuestList,
                languageCode: "",
                cityCode: "",
                secretKey: "NsPqcQMB7HJ632jJp4vm4DCb",
                signature: "VkJMN09YdDZ5TFN6RDV3ZSs5Vnd0dz09"
            };

            this.homeController.getHotelList(req).then((responseFromWe) => {
                if (!responseFromWe.isSuccessful) {
                    // Errors come from our code
                } else {
                    this.hotelListRs = responseFromWe.successData;
                }
            });
        }
    }
</script>