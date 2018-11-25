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
            this.getHotelList();
            this.getRegions("ho Chi MINh");
            this.getRoomAvailability();
            this.getHotelDetails();
        }

        private getHotelDetails(): void {
            let req: ProxyModel.HotelDetailsRequest;
            this.homeController.getHotelDetails(req);
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

        private getRoomAvailability() {
            let roomGuest: ProxyModel.RoomGuestRequestModel = {
                numberOfAdults: 1,
                numberOfChildren: 0,
                childAges: []
            };
            let roomGuest2: ProxyModel.RoomGuestRequestModel = {
                numberOfAdults: 3,
                numberOfChildren: 1,
                childAges: [7]
            };

            let roomGuestList = new Array<ProxyModel.RoomGuestRequestModel>();
            roomGuestList = [roomGuest, roomGuest2];

            let req: ProxyModel.RoomAvailabilityRequest = {
                arrivalDate: "01\/07\/2019",
                departureDate: "01\/08\/2019",
                hotelId: 632882,
                token: "oUYge2twIY7d5le%2bcAYflMA5tKTDDpfIQNVpHkrAzZhF7x2m8uiBRkl7Dep6HDyi",
                sessionId: "AC110003-8585-7916-7492-E89623903902",
                roomGuests: roomGuestList,
                roomTypeCode: ["200122977", "200122977"],
                rateCode: ["200665441", "200665441"],
                cityCode: "",
                secretKey: "",
                signature: ""
            };
            this.homeController.getRoomAvailability(req).then(res => {

                debugger;
            });
        }
    }
</script>