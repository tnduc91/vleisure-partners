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
        private regions: Array<ProxyModel.RegionViewModel>;

        constructor() {
            super();
        }

        mounted(): void{
            //this.getHotelList();
            this.getRegions("ho Chi MINh");
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
                secretKey: "",
                signature: ""
            };

            this.homeController.getHotelList(req).then((responseFromWe) => {
                if (!responseFromWe.isSuccessful) {
                    // Errors come from our code
                } else {
                    this.hotelListRs = responseFromWe.successData;
                }
            });
        }

        private getRegions(searchString: string) {
            this.homeController.getRegions(searchString).then(res => {
                if (res.isSuccessful) {
                    debugger;
                    this.regions = res.successData;
                }
            });
        }
    }
</script>