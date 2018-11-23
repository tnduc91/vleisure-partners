<template>
  <div>
    <Header></Header>
    <SearchBe></SearchBe>
    <section class="grey-blue-bg small-padding" id="sec1">
      <div class="container">
        <div class="row">
          <!--filter sidebar -->
          <div class="col-md-8">
            <ListHotel></ListHotel>
          </div>
          <div class="col-md-4">
            <FilterHotel></FilterHotel>
          </div>
        </div>
      </div>
    </section>
     <Footer></Footer>  
  </div>
</template>

<script lang="ts">
    import { Component, Prop, Vue, Watch } from "vue-property-decorator";
    import { HomeController } from "@proxy/HomeController";
    import OperationResult from "@src/infrastructure/OperationResult";

    import Header from './header.vue';
    import SearchBe from './searchbe.vue';
    import ListHotel from './listhotel.vue';
    import FilterHotel from './filterhotel.vue';
    import Footer from './footer.vue';

    @Component({
       components: {
        Header,
        Footer,
        ListHotel,
        FilterHotel,
        SearchBe
        } 
    })
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
                    console.log(this.hotelListRs)
                }
            });
        }
    }
</script>