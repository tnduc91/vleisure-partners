<template>
  <div>
    <!--col-list-wrap -->
    <div class="col-list-wrap fw-col-list-wrap post-container">
      <!-- list-main-wrap-->
      <div class="list-main-wrap fl-wrap card-listing">
        <!-- list-main-wrap-opt-->
        <div class="list-main-wrap-opt fl-wrap">
          <div class="list-main-wrap-title fl-wrap col-title">
            <h2>Results For : <span>New York </span></h2>
          </div>
          <!-- price-opt-->
          <div class="price-opt">
            <span class="price-opt-title">Sort results by:</span>
            <div class="listsearch-input-item">
           
              <select data-placeholder="Popularity" class="chosen-select no-search-select">
                <option>Popularity</option>
                <option>Average rating</option>
                <option>Price: low to high</option>
                <option>Price: high to low</option>
              </select>
            </div>
          </div>
          <!-- price-opt end-->
        </div>
        <!-- list-main-wrap-opt end-->
        <!-- listing-item-container -->
        <div class="listing-item-container init-grid-items fl-wrap">
          <!-- listing-item  -->
          <div v-for="hotel in hotelListRS" class="listing-item has_two_column has_one_column">
            <article class="geodir-category-listing fl-wrap">
              <div class="geodir-category-img">
                <a href="listing-single.html"><img :src="hotel.thumbNailUrl" alt=""></a>
                <div class="listing-avatar"><a href="author-single.html"><img src="assets/images/avatar/1.jpg" alt=""></a>
                  <span class="avatar-tooltip">Added By <strong>Alisa Noory</strong></span>
                </div>
                <div class="sale-window" v-if="hotel.roomRateDetailsList[0].rateInfos.promoDescription">{{hotel.roomRateDetailsList[0].rateInfos.promoDescription}}</div>
                <div class="geodir-category-opt">
                  <div class="listing-rating card-popup-rainingvis" data-starrating2="5"></div>
                  <div class="rate-class-name">
                    <div class="score"><strong>Very Good</strong>27 Reviews </div>
                    <span>{{hotel.hotelRating}}</span>
                  </div>
                </div>
              </div>
              <div class="geodir-category-content fl-wrap title-sin_item">
                <div class="geodir-category-content-title fl-wrap">
                  <div class="geodir-category-content-title-item">
                    <h3 class="title-sin_map"><a href="/detail">{{hotel.name}}</a></h3>
                    <div class="geodir-category-location fl-wrap"><a href="#" class="map-item"><i class="fas fa-map-marker-alt"></i>
                      {{hotel.address1}} </a></div>
                  </div>
                </div>
                <p  v-html="hotel.shortDescription">  </p>
                <!-- <ul class="facilities-list fl-wrap">
                  <li><i class="fal fa-wifi"></i><span>Free WiFi</span></li>
                  <li><i class="fal fa-parking"></i><span>Parking</span></li>
                  <li><i class="fal fa-smoking-ban"></i><span>Non-smoking Rooms</span></li>
                  <li><i class="fal fa-utensils"></i><span> Restaurant</span></li>
                </ul> -->
                <div class="geodir-category-footer fl-wrap">
                  <div class="geodir-category-price">Awg/Night <span v-if="hotel.roomRateDetailsList&&hotel.roomRateDetailsList[0].rateInfos&&hotel.roomRateDetailsList[0].rateInfos.chargeableRateInfo"> {{hotel.roomRateDetailsList[0].rateInfos.chargeableRateInfo.currencyCode}}  {{hotel.roomRateDetailsList[0].rateInfos.chargeableRateInfo.total}}</span></div>
                  <div class="geodir-opt-list">
                    <a href="#" class="single-map-item" data-newlatitude="40.72956781" data-newlongitude="-73.99726866"><i
                        class="fal fa-map-marker-alt"></i><span class="geodir-opt-tooltip">On the map</span></a>
                    <a href="#" class="geodir-js-favorite"><i class="fal fa-heart"></i><span class="geodir-opt-tooltip">Save</span></a>
                    <a href="#" class="geodir-js-booking"><i class="fal fa-exchange"></i><span class="geodir-opt-tooltip">Find
                        Directions</span></a>
                  </div>
                </div>
              </div>
            </article>
          </div>
          <!-- listing-item end --> 
        </div>
        <!-- listing-item-container end-->
        <a class="load-more-button" href="#">Load more <i class="fal fa-spinner"></i> </a>
      </div>
      <!-- list-main-wrap end-->
    </div>
    <!--col-list-wrap end -->
  </div>
  <!--listing  end-->
</template>

<script>
import { serverBus } from "../../main";
export default {
  data() {
    return {
      server: {},
      filter: {},
      hotelListRS: [
        {
          hotelId: "1212586",
          name: "Empress Hotel HoChiMinh City",
          address1: "136 Bui Thi Xuan Street, District 1",
          address2: "",
          city: "Ho Chi Minh City",
          cityCode: "",
          sessionId: "AC110002-764C-CD91-6732-BA69725973B6",
          stateProvinceCode: "",
          countryCode: "VN",
          airportCode: "SGN",
          propertyCategory: "1",
          hotelRating: "2.5",
          hotelRatingDisplay: "Star",
          confidenceRating: "52",
          amenityMask: "2304",
          locationDescription: "In Ho Chi Minh City (Bui Thi Xuan)",
          shortDescription:
            "<p><b>Property Location</b> <br />With a stay at Empress Hotel HoChiMinh City, you'll be centrally located in Ho Chi Minh City, just a 5-minute walk from September 23 Park and 5 minutes by foot from",
          highRate: "100.00",
          lowRate: "35.34",
          latitude: "10.76996",
          longitude: "106.68862",
          proximityDistance: "-1.0",
          proximityUnit: "MI",
          hotelInDestination: "true",
          thumbNailUrl:
            "http://i.travelapi.com/hotels/1000000/920000/911000/910909/d575fcad_t.jpg",
          roomRateDetailsList: [
            {
              token:
                "e3gZR3f2NxanZfFZ1PvLR%2bGCYjv%2f%2fnqyQ7GK3%2fNUTAPDaYVnAv%2b8cz1krQv%2bBno2",
              roomTypeCode: ["494573"],
              rateCode: ["205810097"],
              maxRoomOccupancy: "2",
              quotedRoomOccupancy: "2",
              minGuestAge: "0",
              roomDescription: ["Standard Room, 1 Bedroom"],
              rateInfos: {
                priceBreakdown: "true",
                promo: "true",
                rateChange: "false",
                roomGroup: [
                  {
                    numberOfAdults: "2",
                    numberOfChildren: "0",
                    rateKey: "6e247709-f49d-4b4c-a7d3-d7500096d4a1-5001-024"
                  }
                ],
                chargeableRateInfo: {
                  currencyCode: "VND",
                  total: "972665.000",
                  commission: "68086.550"
                },
                nonRefundable: "false",
                promoDescription: "Book early and save 10%",
                currentAllotment: "2",
                cancellationList: null
              },
              valueAdds: null
            }
          ]
        },
        {
          hotelId: "1221584",
          name: "Harmony Saigon Hotel & Spa",
          address1: "32A-34 Bui Thi Xuan Street",
          address2: "District 1",
          city: "Ho Chi Minh City",
          cityCode: "",
          sessionId: "AC110002-764C-CD91-6732-BA69725973B6",
          stateProvinceCode: "",
          countryCode: "VN",
          airportCode: "SGN",
          propertyCategory: "1",
          hotelRating: "4.0",
          hotelRatingDisplay: "Star",
          confidenceRating: "52",
          amenityMask: "134234627",
          locationDescription: "In Ho Chi Minh City (Bui Thi Xuan)",
          shortDescription:
            "<p><b>Property Location</b> <br />With a stay at Harmony Saigon Hotel & Spa, you'll be centrally located in Ho Chi Minh City, within a 10-minute walk of Tao Dan Park and Golden Dragon Water Puppet",
          highRate: "153.65",
          lowRate: "81.50",
          latitude: "10.77218",
          longitude: "106.69063",
          proximityDistance: "-1.0",
          proximityUnit: "MI",
          hotelInDestination: "true",
          thumbNailUrl:
            "http://i.travelapi.com/hotels/3000000/2470000/2464400/2464328/717b58f7_t.jpg",
          roomRateDetailsList: [
            {
              token:
                "52vt9YCa6M78bA9%2bOCbJx%2b8YiTEVE1oHBD9OuQnmHx9S9vv6ZUtP%2bhrVLRa4TkVB",
              roomTypeCode: ["200282896"],
              rateCode: ["203000012"],
              maxRoomOccupancy: "2",
              quotedRoomOccupancy: "2",
              minGuestAge: "0",
              roomDescription: ["Deluxe No window and Free Minibar"],
              rateInfos: {
                priceBreakdown: "true",
                promo: "true",
                rateChange: "false",
                roomGroup: [
                  {
                    numberOfAdults: "2",
                    numberOfChildren: "0",
                    rateKey: "8f324b7a-04b6-4009-816c-d7c7d5381a72-5001-024"
                  }
                ],
                chargeableRateInfo: {
                  currencyCode: "VND",
                  total: "2258115.000",
                  commission: "158068.050"
                },
                nonRefundable: "true",
                promoDescription: "Save 40%",
                currentAllotment: "2",
                cancellationList: null
              },
              valueAdds: null
            }
          ]
        },
        {
          hotelId: "1202380",
          name: "Hoang Ngan Hotel",
          address1: "29 - 31 Bui Thi Xuan St",
          address2: "Ben Thanh Ward, Dist 1",
          city: "Ho Chi Minh City",
          cityCode: "",
          sessionId: "AC110002-764C-CD91-6732-BA69725973B6",
          stateProvinceCode: "",
          countryCode: "VN",
          airportCode: "SGN",
          propertyCategory: "1",
          hotelRating: "3.0",
          hotelRatingDisplay: "Star",
          confidenceRating: "52",
          amenityMask: "2304",
          locationDescription: "In Ho Chi Minh City (Bui Thi Xuan)",
          shortDescription:
            "<p><b>Property Location</b> <br />A stay at Hoang Ngan Hotel places you in the heart of Ho Chi Minh City, within a 10-minute walk of Tao Dan Park and Zen Plaza.  This hotel is 0.5 mi (0.7 km) from",
          highRate: "47.50",
          lowRate: "37.21",
          latitude: "10.77196",
          longitude: "106.69051",
          proximityDistance: "-1.0",
          proximityUnit: "MI",
          hotelInDestination: "true",
          thumbNailUrl:
            "http://i.travelapi.com/hotels/4000000/3890000/3884200/3884184/d5a9082b_t.jpg",
          roomRateDetailsList: [
            {
              token:
                "A5FYSpvXtE69VzepLqjH%2f5Trbbk%2f7tM%2bQOgtQ6F3iACMSjvsgnx1yviSy8c1aJMo",
              roomTypeCode: ["200360798"],
              rateCode: ["202201841"],
              maxRoomOccupancy: "2",
              quotedRoomOccupancy: "2",
              minGuestAge: "0",
              roomDescription: ["Standard Room, No Windows"],
              rateInfos: {
                priceBreakdown: "true",
                promo: "true",
                rateChange: "false",
                roomGroup: [
                  {
                    numberOfAdults: "2",
                    numberOfChildren: "0",
                    rateKey: "0fb95830-139e-4b8f-a148-b8e41e5e290e-5001-024"
                  }
                ],
                chargeableRateInfo: {
                  currencyCode: "VND",
                  total: "1024365.000",
                  commission: "71705.550"
                },
                nonRefundable: "true",
                promoDescription: "Save 20%",
                currentAllotment: "5",
                cancellationList: null
              },
              valueAdds: null
            }
          ]
        },
        {
          hotelId: "1011340",
          name: "Queen Ann Hotel",
          address1: "86-88 Bui Thi Xuan Street",
          address2: "District 1",
          city: "Ho Chi Minh City",
          cityCode: "",
          sessionId: "AC110002-764C-CD91-6732-BA69725973B6",
          stateProvinceCode: "",
          countryCode: "VN",
          airportCode: "SGN",
          propertyCategory: "1",
          hotelRating: "3.0",
          hotelRatingDisplay: "Star",
          confidenceRating: "52",
          amenityMask: "2305",
          locationDescription: "In Ho Chi Minh City (Bui Thi Xuan)",
          shortDescription:
            "<p><b>Property Location</b> <br />A stay at Queen Ann Hotel places you in the heart of Ho Chi Minh City, within a 10-minute walk of Zen Plaza and September 23 Park.  This hotel is 0.5 mi (0.7 km)",
          highRate: "61.61",
          lowRate: "38.19",
          latitude: "10.7711",
          longitude: "106.68964",
          proximityDistance: "-1.0",
          proximityUnit: "MI",
          hotelInDestination: "true",
          thumbNailUrl:
            "http://i.travelapi.com/hotels/6000000/5010000/5000100/5000001/dad7eadf_t.jpg",
          roomRateDetailsList: [
            {
              token:
                "KQN117jZWGVGKyOtZkwYyrDuo1W5ajxMrsPrNyS5SKIQb6euCoEQmDGxZp3%2frBg5",
              roomTypeCode: ["200156807"],
              rateCode: ["211246764"],
              maxRoomOccupancy: "2",
              quotedRoomOccupancy: "2",
              minGuestAge: "0",
              roomDescription: [
                "Superior Double or Twin Room, 1 Double or 2 Twin Beds, No Windows"
              ],
              rateInfos: {
                priceBreakdown: "true",
                promo: "true",
                rateChange: "false",
                roomGroup: [
                  {
                    numberOfAdults: "2",
                    numberOfChildren: "0",
                    rateKey: "d091ecb6-c92a-4778-8b20-b15df5260c5e-5001-024"
                  }
                ],
                chargeableRateInfo: {
                  currencyCode: "VND",
                  total: "1050920.000",
                  commission: "73564.400"
                },
                nonRefundable: "false",
                promoDescription: "Save 30%",
                currentAllotment: "5",
                cancellationList: null
              },
              valueAdds: null
            }
          ]
        },
        {
          hotelId: "1004122",
          name: "City View Hotel",
          address1: "15 Bui Thi Xuan Street",
          address2: "Ben Thanh Ward,  District 1",
          city: "Ho Chi Minh City",
          cityCode: "",
          sessionId: "AC110002-764C-CD91-6732-BA69725973B6",
          stateProvinceCode: "",
          countryCode: "VN",
          airportCode: "SGN",
          propertyCategory: "1",
          hotelRating: "2.0",
          hotelRatingDisplay: "Star",
          confidenceRating: "52",
          amenityMask: "2304",
          locationDescription: "In Ho Chi Minh City (Bui Thi Xuan)",
          shortDescription:
            "<p><b>Property Location</b> <br />A stay at City View Hotel places you in the heart of Ho Chi Minh City, within a 10-minute walk of Tao Dan Park and Zen Plaza.  This hotel is 0.5 mi (0.8 km) from",
          highRate: "51.08",
          lowRate: "20.43",
          latitude: "10.77236",
          longitude: "106.69082",
          proximityDistance: "-1.0",
          proximityUnit: "MI",
          hotelInDestination: "true",
          thumbNailUrl:
            "http://i.travelapi.com/hotels/5000000/4660000/4650300/4650230/ec25a661_t.jpg",
          roomRateDetailsList: [
            {
              token:
                "kviR4LvIv9T92tHz%2b24b8inmh9xCKwi5UDPkGrwbn5a5SCcBmlVUZEUCCpxAspry",
              roomTypeCode: ["200110035"],
              rateCode: ["207344172"],
              maxRoomOccupancy: "2",
              quotedRoomOccupancy: "2",
              minGuestAge: "0",
              roomDescription: ["Standard Room, No Windows"],
              rateInfos: {
                priceBreakdown: "true",
                promo: "true",
                rateChange: "false",
                roomGroup: [
                  {
                    numberOfAdults: "2",
                    numberOfChildren: "0",
                    rateKey: "7a46a2f1-1b9d-4139-8396-6ddd8e489a51-5001-024"
                  }
                ],
                chargeableRateInfo: {
                  currencyCode: "VND",
                  total: "569875.000",
                  commission: "39891.250"
                },
                nonRefundable: "false",
                promoDescription: "Save30%",
                currentAllotment: "6",
                cancellationList: null
              },
              valueAdds: null
            }
          ]
        },
        {
          hotelId: "1012897",
          name: "A25 Hotel - Luong Huu Khanh",
          address1: "14 Luong Huu Khanh",
          address2: "Pham Ngu Lao Ward",
          city: "Ho Chi Minh City",
          cityCode: "",
          sessionId: "AC110002-764C-CD91-6732-BA69725973B6",
          stateProvinceCode: "",
          countryCode: "VN",
          airportCode: "SGN",
          propertyCategory: "1",
          hotelRating: "2.5",
          hotelRatingDisplay: "Star",
          confidenceRating: "52",
          amenityMask: "134236416",
          locationDescription: "In Ho Chi Minh City (Bui Thi Xuan)",
          shortDescription:
            "<p><b>Property Location</b> <br />With a stay at A25 Hotel - Luong Huu Khanh in Ho Chi Minh City (Bui Thi Xuan), you'll be within a 10-minute walk of Pham Ngu Lao Backpacker Area and September 23",
          highRate: "35.27",
          lowRate: "34.02",
          latitude: "10.76971",
          longitude: "106.68645",
          proximityDistance: "-1.0",
          proximityUnit: "MI",
          hotelInDestination: "true",
          thumbNailUrl:
            "http://i.travelapi.com/hotels/6000000/5430000/5424400/5424363/3e45d9e3_t.jpg",
          roomRateDetailsList: [
            {
              token:
                "UvhEkXwR%2b7vk5NLZtLl26qMJM0eYVVcG228CYm3MzJc03tKEfYcL7zPZrjxJJH3s",
              roomTypeCode: ["200892439"],
              rateCode: ["204526571"],
              maxRoomOccupancy: "2",
              quotedRoomOccupancy: "2",
              minGuestAge: "0",
              roomDescription: ["Superior Double Room"],
              rateInfos: {
                priceBreakdown: "true",
                promo: "false",
                rateChange: "false",
                roomGroup: [
                  {
                    numberOfAdults: "2",
                    numberOfChildren: "0",
                    rateKey: "e7537cec-b94a-4703-bf0c-116c7f48a13a-5001-024"
                  }
                ],
                chargeableRateInfo: {
                  currencyCode: "VND",
                  total: "948695.000",
                  commission: "66408.650"
                },
                nonRefundable: "false",
                promoDescription: "",
                currentAllotment: "3",
                cancellationList: null
              },
              valueAdds: null
            }
          ]
        },
        {
          hotelId: "1213204",
          name: "EdenStar Saigon Hotel & Spa",
          address1: "38 Bui Thi Xuan Street",
          address2: "Ben Thanh Ward, District 1",
          city: "Ho Chi Minh City",
          cityCode: "",
          sessionId: "AC110002-764C-CD91-6732-BA69725973B6",
          stateProvinceCode: "",
          countryCode: "VN",
          airportCode: "SGN",
          propertyCategory: "1",
          hotelRating: "4.0",
          hotelRatingDisplay: "Star",
          confidenceRating: "52",
          amenityMask: "25347",
          locationDescription: "In Ho Chi Minh City (Bui Thi Xuan)",
          shortDescription:
            "<p><b>Property Location</b> <br />A stay at EdenStar Saigon Hotel & Spa places you in the heart of Ho Chi Minh City, within a 10-minute walk of Zen Plaza and September 23 Park.  This 4-star hotel is",
          highRate: "303.03",
          lowRate: "129.87",
          latitude: "10.77117",
          longitude: "106.68974",
          proximityDistance: "-1.0",
          proximityUnit: "MI",
          hotelInDestination: "true",
          thumbNailUrl:
            "http://i.travelapi.com/hotels/6000000/5570000/5563000/5562969/a414d59b_t.jpg",
          roomRateDetailsList: [
            {
              token:
                "WhCMrwUbLgmF4pzqpZH6LKcO1nZvpfZ1EQwWifW6WFeLYZ4A5pbfKtXbGbMU0JQ3",
              roomTypeCode: ["201660213"],
              rateCode: ["208287171"],
              maxRoomOccupancy: "3",
              quotedRoomOccupancy: "2",
              minGuestAge: "0",
              roomDescription: ["PANORAMA SUITE City View with Free Minibar"],
              rateInfos: {
                priceBreakdown: "true",
                promo: "true",
                rateChange: "false",
                roomGroup: [
                  {
                    numberOfAdults: "2",
                    numberOfChildren: "0",
                    rateKey: "7b2ce5e6-6cc9-45ab-81e6-da53fca1efcf-5001-024"
                  }
                ],
                chargeableRateInfo: {
                  currencyCode: "VND",
                  total: "6116815.000",
                  commission: "428177.050"
                },
                nonRefundable: "true",
                promoDescription: "Save 15%",
                currentAllotment: "1",
                cancellationList: null
              },
              valueAdds: null
            }
          ]
        },
        {
          hotelId: "1003491",
          name: "A25 Hotel - 13 Bui Thi Xuan",
          address1: "13 Bui Thi Xuan, Ben Thanh Ward",
          address2: "District 1",
          city: "Ho Chi Minh City",
          cityCode: "",
          sessionId: "AC110002-764C-CD91-6732-BA69725973B6",
          stateProvinceCode: "",
          countryCode: "VN",
          airportCode: "SGN",
          propertyCategory: "1",
          hotelRating: "2.5",
          hotelRatingDisplay: "Star",
          confidenceRating: "52",
          amenityMask: "134236416",
          locationDescription: "In Ho Chi Minh City (Bui Thi Xuan)",
          shortDescription:
            "<p><b>Property Location</b> <br />A stay at A25 Hotel - 13 Bui Thi Xuan places you in the heart of Ho Chi Minh City, within a 10-minute walk of Tao Dan Park and Zen Plaza.  This hotel is 0.4 mi (0.7",
          highRate: "52.08",
          lowRate: "21.70",
          latitude: "10.77191",
          longitude: "106.69039",
          proximityDistance: "-1.0",
          proximityUnit: "MI",
          hotelInDestination: "true",
          thumbNailUrl:
            "http://i.travelapi.com/hotels/7000000/6650000/6641300/6641263/7923c754_t.jpg",
          roomRateDetailsList: [
            {
              token:
                "8Rrp%2bgAaosS8nYtRryyDTdYAxGTn8t5zM6%2btU64CF6TrU2QBkSLc7dh9POwEOOOk",
              roomTypeCode: ["200372617"],
              rateCode: ["202262014"],
              maxRoomOccupancy: "2",
              quotedRoomOccupancy: "2",
              minGuestAge: "0",
              roomDescription: ["Superior Room"],
              rateInfos: {
                priceBreakdown: "true",
                promo: "true",
                rateChange: "false",
                roomGroup: [
                  {
                    numberOfAdults: "2",
                    numberOfChildren: "0",
                    rateKey: "6c639b5e-af9b-4c3f-bcab-e8ef5a263182-5001-024"
                  }
                ],
                chargeableRateInfo: {
                  currencyCode: "VND",
                  total: "653770.000",
                  commission: "45763.900"
                },
                nonRefundable: "false",
                promoDescription: "Save55%",
                currentAllotment: "3",
                cancellationList: null
              },
              valueAdds: null
            }
          ]
        },
        {
          hotelId: "1011426",
          name: "Asian Ruby Boutique Hotel",
          address1: "20 BIS Bui Thi Xuan, District 1",
          address2: "",
          city: "Ho Chi Minh City",
          cityCode: "",
          sessionId: "AC110002-764C-CD91-6732-BA69725973B6",
          stateProvinceCode: "",
          countryCode: "VN",
          airportCode: "SGN",
          propertyCategory: "1",
          hotelRating: "2.5",
          hotelRatingDisplay: "Star",
          confidenceRating: "52",
          amenityMask: "134236929",
          locationDescription: "In Ho Chi Minh City (Bui Thi Xuan)",
          shortDescription:
            "<p><b>Property Location</b> <br />With a stay at Asian Ruby Boutique Hotel in Ho Chi Minh City (Bui Thi Xuan), you'll be within a 10-minute walk of Tao Dan Park and Zen Plaza.  This romantic hotel is",
          highRate: "72.83",
          lowRate: "26.84",
          latitude: "10.77212",
          longitude: "106.69061",
          proximityDistance: "-1.0",
          proximityUnit: "MI",
          hotelInDestination: "true",
          thumbNailUrl:
            "http://i.travelapi.com/hotels/7000000/6660000/6657800/6657734/0b0b69d8_t.jpg",
          roomRateDetailsList: [
            {
              token:
                "nvymu5VZNTuprrnzpDJV8W20N%2ffBbLTiI2cO9xNuztSFX7wU0WEbB%2b4%2f0w7LB1rl",
              roomTypeCode: ["216024336"],
              rateCode: ["260115345"],
              maxRoomOccupancy: "2",
              quotedRoomOccupancy: "2",
              minGuestAge: "0",
              roomDescription: ["Superior Double Room"],
              rateInfos: {
                priceBreakdown: "true",
                promo: "true",
                rateChange: "false",
                roomGroup: [
                  {
                    numberOfAdults: "2",
                    numberOfChildren: "0",
                    rateKey: "20c6609d-6939-466f-8200-0a7073f3bc54-5001-024"
                  }
                ],
                chargeableRateInfo: {
                  currencyCode: "VND",
                  total: "738840.000",
                  commission: "51718.800"
                },
                nonRefundable: "false",
                promoDescription: "Save 50%",
                currentAllotment: "3",
                cancellationList: null
              },
              valueAdds: null
            }
          ]
        },
        {
          hotelId: "1208182",
          name: "Rang Dong Hotel",
          address1: "81-83 Cach Mang Thang Tam 1",
          address2: "Ben Thanh Ward, District 1",
          city: "Ho Chi Minh City",
          cityCode: "",
          sessionId: "AC110002-764C-CD91-6732-BA69725973B6",
          stateProvinceCode: "",
          countryCode: "VN",
          airportCode: "SGN",
          propertyCategory: "1",
          hotelRating: "3.0",
          hotelRatingDisplay: "Star",
          confidenceRating: "0",
          amenityMask: "134236417",
          locationDescription: "In Ho Chi Minh City (Bui Thi Xuan)",
          shortDescription:
            "<p><b>Property Location</b> <br />With a stay at Rang Dong Hotel, you'll be centrally located in Ho Chi Minh City, just a 4-minute walk from Zen Plaza and 6 minutes by foot from Tao Dan Park.  This",
          highRate: "112.28",
          lowRate: "34.61",
          latitude: "10.7722",
          longitude: "106.69201",
          proximityDistance: "-1.0",
          proximityUnit: "MI",
          hotelInDestination: "true",
          thumbNailUrl:
            "http://i.travelapi.com/hotels/7000000/6520000/6516300/6516295/65aae176_t.jpg",
          roomRateDetailsList: [
            {
              token:
                "nKAET0fbibtrW1Fj7dglYu0qdqnIGV9sTqzHBpK%2fPh7U9tnxPuwGC32BloT3IJwq",
              roomTypeCode: ["200830894"],
              rateCode: ["204194486"],
              maxRoomOccupancy: "3",
              quotedRoomOccupancy: "2",
              minGuestAge: "0",
              roomDescription: ["Superior Twin Room"],
              rateInfos: {
                priceBreakdown: "true",
                promo: "true",
                rateChange: "false",
                roomGroup: [
                  {
                    numberOfAdults: "2",
                    numberOfChildren: "0",
                    rateKey: "689adf15-c359-4126-8675-35a9d34ed018-5001-024"
                  }
                ],
                chargeableRateInfo: {
                  currencyCode: "VND",
                  total: "958800.000",
                  commission: "67116.000"
                },
                nonRefundable: "false",
                promoDescription: "Save 30%",
                currentAllotment: "10",
                cancellationList: null
              },
              valueAdds: null
            }
          ]
        },
        {
          hotelId: "1200460",
          name: "Little Brick Saigon Hotel",
          address1: "18 Bui Thi Xuan Str., District 1",
          address2: "",
          city: "Ho Chi Minh City",
          cityCode: "",
          sessionId: "AC110002-764C-CD91-6732-BA69725973B6",
          stateProvinceCode: "",
          countryCode: "VN",
          airportCode: "SGN",
          propertyCategory: "1",
          hotelRating: "2.0",
          hotelRatingDisplay: "Star",
          confidenceRating: "0",
          amenityMask: "2304",
          locationDescription: "In Ho Chi Minh City (Bui Thi Xuan)",
          shortDescription:
            "<p><b>Property Location</b> <br />A stay at Little Brick Saigon Hotel places you in the heart of Ho Chi Minh City, within a 10-minute walk of Tao Dan Park and Zen Plaza.  This hotel is 0.5 mi (0.8",
          highRate: "58.63",
          lowRate: "19.63",
          latitude: "10.77219",
          longitude: "106.69067",
          proximityDistance: "-1.0",
          proximityUnit: "MI",
          hotelInDestination: "true",
          thumbNailUrl:
            "http://i.travelapi.com/hotels/10000000/9480000/9477400/9477314/c38926fa_t.jpg",
          roomRateDetailsList: [
            {
              token:
                "sfNKo0cp78x51ybUNB3WN28FIj%2bKBVnzBOFw%2fFuRRm4KlPEYpnuziQ7Fq4wkVO%2bm",
              roomTypeCode: ["200834961"],
              rateCode: ["207772372"],
              maxRoomOccupancy: "2",
              quotedRoomOccupancy: "2",
              minGuestAge: "0",
              roomDescription: ["Standard Room"],
              rateInfos: {
                priceBreakdown: "true",
                promo: "true",
                rateChange: "false",
                roomGroup: [
                  {
                    numberOfAdults: "2",
                    numberOfChildren: "0",
                    rateKey: "918ade56-1b5e-4198-88d0-c7ce93c22078-5001-024"
                  }
                ],
                chargeableRateInfo: {
                  currencyCode: "VND",
                  total: "542380.000",
                  commission: "37966.600"
                },
                nonRefundable: "true",
                promoDescription: "Book early and save 46%",
                currentAllotment: "5",
                cancellationList: null
              },
              valueAdds: null
            }
          ]
        },
        {
          hotelId: "1182925",
          name: "Nguyen Thanh Hotel",
          address1: "19-B Bui Thi Xuan Street",
          address2: "",
          city: "Ho Chi Minh City",
          cityCode: "",
          sessionId: "AC110002-764C-CD91-6732-BA69725973B6",
          stateProvinceCode: "",
          countryCode: "VN",
          airportCode: "SGN",
          propertyCategory: "1",
          hotelRating: "2.0",
          hotelRatingDisplay: "Star",
          confidenceRating: "0",
          amenityMask: "0",
          locationDescription: "In Ho Chi Minh City (Bui Thi Xuan)",
          shortDescription:
            "<p><b>Property Location</b> <br />With a stay at Nguyen Thanh Hotel in Ho Chi Minh City (Bui Thi Xuan), you'll be within a 10-minute walk of Tao Dan Park and Zen Plaza.  This hotel is 0.4 mi (0.7 km)",
          highRate: "26.18",
          lowRate: "15.91",
          latitude: "10.77195",
          longitude: "106.69044",
          proximityDistance: "-1.0",
          proximityUnit: "MI",
          hotelInDestination: "true",
          thumbNailUrl:
            "http://i.travelapi.com/hotels/10000000/9630000/9625000/9624926/99eb6c9c_t.jpg",
          roomRateDetailsList: [
            {
              token:
                "ASCc7iUpp%2bjkrgQDbaNRxrovKMWMBRwxuCmY2qO2YIh8rkGOlWUzTiKAOTO0QZjt",
              roomTypeCode: ["200964034"],
              rateCode: ["204740379"],
              maxRoomOccupancy: "2",
              quotedRoomOccupancy: "2",
              minGuestAge: "0",
              roomDescription: ["Standard Room"],
              rateInfos: {
                priceBreakdown: "true",
                promo: "false",
                rateChange: "false",
                roomGroup: [
                  {
                    numberOfAdults: "2",
                    numberOfChildren: "0",
                    rateKey: "96846736-c994-4fcf-9dec-89026ba3e1b4-5001-024"
                  }
                ],
                chargeableRateInfo: {
                  currencyCode: "VND",
                  total: "443915.000",
                  commission: "31074.050"
                },
                nonRefundable: "false",
                promoDescription: "",
                currentAllotment: "1",
                cancellationList: null
              },
              valueAdds: null
            }
          ]
        },
        {
          hotelId: "1036834",
          name: "Trieu Han Hotel",
          address1: "382/1-3 Nguyen Thi Minh Khai St, ward 5",
          address2: "War Remnants Museum",
          city: "Ho Chi Minh City",
          cityCode: "",
          sessionId: "AC110002-764C-CD91-6732-BA69725973B6",
          stateProvinceCode: "",
          countryCode: "VN",
          airportCode: "SGN",
          propertyCategory: "1",
          hotelRating: "2.5",
          hotelRatingDisplay: "Star",
          confidenceRating: "0",
          amenityMask: "134234112",
          locationDescription: "In Ho Chi Minh City (Bui Thi Xuan)",
          shortDescription:
            "<p><b>Property Location</b> <br />With a stay at Trieu Han Hotel in Ho Chi Minh City (Bui Thi Xuan), you'll be within a 10-minute walk of September 23 Park and Golden Dragon Water Puppet Theatre. ",
          highRate: "26.87",
          lowRate: "22.24",
          latitude: "10.77181",
          longitude: "106.68765",
          proximityDistance: "-1.0",
          proximityUnit: "MI",
          hotelInDestination: "true",
          thumbNailUrl:
            "http://i.travelapi.com/hotels/13000000/12240000/12233700/12233611/ef277184_t.jpg",
          roomRateDetailsList: [
            {
              token:
                "oGTQueriLiFWN7RBgO0Rp23Y5BFAeKXdX2KCkvHIg7XOn2pYzak1b1Nhl9mQeEPU",
              roomTypeCode: ["201243809"],
              rateCode: ["206046282"],
              maxRoomOccupancy: "2",
              quotedRoomOccupancy: "2",
              minGuestAge: "0",
              roomDescription: ["Superior Double Room"],
              rateInfos: {
                priceBreakdown: "true",
                promo: "true",
                rateChange: "false",
                roomGroup: [
                  {
                    numberOfAdults: "2",
                    numberOfChildren: "0",
                    rateKey: "627c7bb6-7fbe-4f09-81e9-0833981c13ca-5001-024"
                  }
                ],
                chargeableRateInfo: {
                  currencyCode: "VND",
                  total: "620165.000",
                  commission: "43411.550"
                },
                nonRefundable: "false",
                promoDescription: "Save10%",
                currentAllotment: "1",
                cancellationList: null
              },
              valueAdds: null
            }
          ]
        },
        {
          hotelId: "1210356",
          name: "Fusion Suites Saigon",
          address1: "3-5 Suong Nguyet Anh Street",
          address2: "District 1",
          city: "Ho Chi Minh City",
          cityCode: "",
          sessionId: "AC110002-764C-CD91-6732-BA69725973B6",
          stateProvinceCode: "",
          countryCode: "VN",
          airportCode: "SGN",
          propertyCategory: "1",
          hotelRating: "4.0",
          hotelRatingDisplay: "Star",
          confidenceRating: "0",
          amenityMask: "1444354",
          locationDescription: "In Ho Chi Minh City (Bui Thi Xuan)",
          shortDescription:
            "<p><b>Property Location</b> <br />A stay at Fusion Suites Saigon places you in the heart of Ho Chi Minh City, within a 10-minute walk of Tao Dan Park and Golden Dragon Water Puppet Theatre.  This",
          highRate: "278.81",
          lowRate: "112.98",
          latitude: "10.77265",
          longitude: "106.68983",
          proximityDistance: "-1.0",
          proximityUnit: "MI",
          hotelInDestination: "true",
          thumbNailUrl:
            "http://i.travelapi.com/hotels/16000000/15100000/15093300/15093292/723da4ed_t.jpg",
          roomRateDetailsList: [
            {
              token:
                "xU28nCQX6QIxKGQmJJN4QSItnZUkswS%2bU1k9tLvC0mtPhHYCVW9TWS9NdrSG9wP%2b",
              roomTypeCode: ["201509094"],
              rateCode: ["290021517"],
              maxRoomOccupancy: "2",
              quotedRoomOccupancy: "2",
              minGuestAge: "0",
              roomDescription: ["Suite Double Room"],
              rateInfos: {
                priceBreakdown: "true",
                promo: "true",
                rateChange: "false",
                roomGroup: [
                  {
                    numberOfAdults: "2",
                    numberOfChildren: "0",
                    rateKey: "00fc7f75-90f5-46d5-9b8a-7a6158660bc1-5001-024"
                  }
                ],
                chargeableRateInfo: {
                  currencyCode: "VND",
                  total: "6566135.000",
                  commission: "459629.450"
                },
                nonRefundable: "true",
                promoDescription: "Book early and save 15%",
                currentAllotment: "12",
                cancellationList: null
              },
              valueAdds: null
            }
          ]
        },
        {
          hotelId: "1232450",
          name: "Icon 36 Hotel",
          address1: "33 Bui Thi Xuan Street, District 1",
          address2: "",
          city: "Ho Chi Minh City",
          cityCode: "",
          sessionId: "AC110002-764C-CD91-6732-BA69725973B6",
          stateProvinceCode: "",
          countryCode: "VN",
          airportCode: "SGN",
          propertyCategory: "1",
          hotelRating: "3.0",
          hotelRatingDisplay: "Star",
          confidenceRating: "0",
          amenityMask: "2304",
          locationDescription: "In Ho Chi Minh City (Bui Thi Xuan)",
          shortDescription:
            "<p><b>Property Location</b> <br />With a stay at Icon 36 Hotel in Ho Chi Minh City (Bui Thi Xuan), you'll be within a 10-minute walk of Zen Plaza and September 23 Park.  This hotel is 0.5 mi (0.7 km)",
          highRate: "96.76",
          lowRate: "32.52",
          latitude: "10.77118",
          longitude: "106.68971",
          proximityDistance: "-1.0",
          proximityUnit: "MI",
          hotelInDestination: "true",
          thumbNailUrl:
            "http://i.travelapi.com/hotels/16000000/15430000/15422900/15422845/93a8d56d_t.jpg",
          roomRateDetailsList: [
            {
              token:
                "aO6bX4O4ILc%2fOUQouzhEboczXOqJdI7WSEjdF7wLcvd09lSptHBN5ECd0uFY1z2x",
              roomTypeCode: ["201549874"],
              rateCode: ["207992718"],
              maxRoomOccupancy: "2",
              quotedRoomOccupancy: "2",
              minGuestAge: "0",
              roomDescription: ["Superior Room"],
              rateInfos: {
                priceBreakdown: "true",
                promo: "true",
                rateChange: "false",
                roomGroup: [
                  {
                    numberOfAdults: "2",
                    numberOfChildren: "0",
                    rateKey: "e5fdcd23-b2a6-49e9-92ff-5e722b2359c6-5001-024"
                  }
                ],
                chargeableRateInfo: {
                  currencyCode: "VND",
                  total: "906865.000",
                  commission: "63480.550"
                },
                nonRefundable: "true",
                promoDescription: "Save 45%",
                currentAllotment: "4",
                cancellationList: null
              },
              valueAdds: null
            }
          ]
        },
        {
          hotelId: "1203074",
          name: "Onetel Saigon Hostel",
          address1: "35 Nguyen Van Trang, District 1",
          address2: "",
          city: "Ho Chi Minh City",
          cityCode: "",
          sessionId: "AC110002-764C-CD91-6732-BA69725973B6",
          stateProvinceCode: "",
          countryCode: "VN",
          airportCode: "SGN",
          propertyCategory: "1",
          hotelRating: "1.5",
          hotelRatingDisplay: "Star",
          confidenceRating: "0",
          amenityMask: "133120",
          locationDescription: "In Ho Chi Minh City (Bui Thi Xuan)",
          shortDescription:
            "<p><b>Property Location</b> <br />A stay at Onetel Saigon Hostel places you in the heart of Ho Chi Minh City, within a 10-minute drive of War Remnants Museum and Ben Thanh Market.  This hostel is 1.1",
          highRate: "53.06",
          lowRate: "26.05",
          latitude: "10.77069",
          longitude: "106.69183",
          proximityDistance: "-1.0",
          proximityUnit: "MI",
          hotelInDestination: "true",
          thumbNailUrl:
            "http://i.travelapi.com/hotels/16000000/15590000/15586500/15586408/94212483_t.jpg",
          roomRateDetailsList: [
            {
              token:
                "xDqjMt%2bI8ssWuhQHHJaoZ87MM00rm410aC1z6HVX4YEOCRFZLBLsnkBIIzBHgQTE",
              roomTypeCode: ["220219151"],
              rateCode: ["288062834"],
              maxRoomOccupancy: "8",
              quotedRoomOccupancy: "8",
              minGuestAge: "0",
              roomDescription: ["Basic Room, 1 Bedroom, Ground Floor"],
              rateInfos: {
                priceBreakdown: "true",
                promo: "false",
                rateChange: "false",
                roomGroup: [
                  {
                    numberOfAdults: "2",
                    numberOfChildren: "0",
                    rateKey: "1602a61c-5901-425c-b3fc-aaf58f5dc75c-5001-024"
                  }
                ],
                chargeableRateInfo: {
                  currencyCode: "VND",
                  total: "1479795.000",
                  commission: "103585.650"
                },
                nonRefundable: "false",
                promoDescription: "",
                currentAllotment: "1",
                cancellationList: null
              },
              valueAdds: null
            }
          ]
        },
        {
          hotelId: "1209535",
          name: "Ambassador Hotel Saigon",
          address1: "84A  Bui Thi Xuan, District 1",
          address2: "",
          city: "Ho Chi Minh City",
          cityCode: "",
          sessionId: "AC110002-764C-CD91-6732-BA69725973B6",
          stateProvinceCode: "",
          countryCode: "VN",
          airportCode: "",
          propertyCategory: "1",
          hotelRating: "3.5",
          hotelRatingDisplay: "Star",
          confidenceRating: "0",
          amenityMask: "134236416",
          locationDescription: "In Ho Chi Minh City (Bui Thi Xuan)",
          shortDescription:
            "<p><b>Property Location</b> <br />With a stay at Ambassador Hotel Saigon in Ho Chi Minh City (Bui Thi Xuan), you'll be within a 10-minute walk of Zen Plaza and September 23 Park.  This hotel is 0.5",
          highRate: "89.09",
          lowRate: "32.29",
          latitude: "10.77127",
          longitude: "106.68963",
          proximityDistance: "-1.0",
          proximityUnit: "MI",
          hotelInDestination: "true",
          thumbNailUrl:
            "http://i.travelapi.com/hotels/16000000/15830000/15820600/15820564/607e6a65_t.jpg",
          roomRateDetailsList: [
            {
              token:
                "C2c%2fkkC%2bmZnAr2JCTyCMBq57pT243Fwuy5UqGyolskh6NM82FdoTcDKrapojZT7o",
              roomTypeCode: ["201620836"],
              rateCode: ["208111726"],
              maxRoomOccupancy: "2",
              quotedRoomOccupancy: "2",
              minGuestAge: "0",
              roomDescription: ["Superior Room (No Window)"],
              rateInfos: {
                priceBreakdown: "true",
                promo: "true",
                rateChange: "false",
                roomGroup: [
                  {
                    numberOfAdults: "2",
                    numberOfChildren: "0",
                    rateKey: "92ebb86f-2282-40db-ac4a-aa989f0d5083-5001-024"
                  }
                ],
                chargeableRateInfo: {
                  currencyCode: "VND",
                  total: "894645.000",
                  commission: "62625.150"
                },
                nonRefundable: "false",
                promoDescription: "Save 52%",
                currentAllotment: "5",
                cancellationList: null
              },
              valueAdds: null
            }
          ]
        },
        {
          hotelId: "1007028",
          name: "A25 Hotel - 19 Bui Thi Xuan",
          address1: "19 Bui Thi Xuan",
          address2: "District 1",
          city: "Ho Chi Minh City",
          cityCode: "",
          sessionId: "AC110002-764C-CD91-6732-BA69725973B6",
          stateProvinceCode: "",
          countryCode: "VN",
          airportCode: "",
          propertyCategory: "1",
          hotelRating: "3.0",
          hotelRatingDisplay: "Star",
          confidenceRating: "0",
          amenityMask: "0",
          locationDescription: "In Ho Chi Minh City (Bui Thi Xuan)",
          shortDescription:
            "<p><b>Property Location</b> <br />With a stay at A25 Hotel - 19 Bui Thi Xuan in Ho Chi Minh City (Bui Thi Xuan), you'll be a 3-minute walk from Zen Plaza and 6 minutes by foot from September 23 Park.",
          highRate: "35.84",
          lowRate: "21.74",
          latitude: "10.77189",
          longitude: "106.69089",
          proximityDistance: "-1.0",
          proximityUnit: "MI",
          hotelInDestination: "true",
          thumbNailUrl:
            "http://i.travelapi.com/hotels/19000000/18590000/18589600/18589504/6f4b86c1_t.jpg",
          roomRateDetailsList: [
            {
              token:
                "TIJvOXV3S6S5kpQvfpdPdr3Nf3UFfA%2bMPRBi5%2bl8JnW010gP7skSV3kO5%2fwg%2b6JU",
              roomTypeCode: ["201989751"],
              rateCode: ["210152063"],
              maxRoomOccupancy: "3",
              quotedRoomOccupancy: "2",
              minGuestAge: "0",
              roomDescription: ["Standard Double Room"],
              rateInfos: {
                priceBreakdown: "true",
                promo: "true",
                rateChange: "false",
                roomGroup: [
                  {
                    numberOfAdults: "2",
                    numberOfChildren: "0",
                    rateKey: "727d66fe-8a5b-4990-936a-bcd6fd5d6161-5001-024"
                  }
                ],
                chargeableRateInfo: {
                  currencyCode: "VND",
                  total: "674685.000",
                  commission: "47227.950"
                },
                nonRefundable: "false",
                promoDescription: "Save10%",
                currentAllotment: "1",
                cancellationList: null
              },
              valueAdds: null
            }
          ]
        },
        {
          hotelId: "1010860",
          name: "A25 Hotel - 20 Bui Thi Xuan",
          address1: "20 Bui Thi Xuan, District 1",
          address2: "",
          city: "Ho Chi Minh City",
          cityCode: "",
          sessionId: "AC110002-764C-CD91-6732-BA69725973B6",
          stateProvinceCode: "",
          countryCode: "VN",
          airportCode: "",
          propertyCategory: "1",
          hotelRating: "3.0",
          hotelRatingDisplay: "Star",
          confidenceRating: "0",
          amenityMask: "0",
          locationDescription: "In Ho Chi Minh City (Bui Thi Xuan)",
          shortDescription:
            "<p><b>Property Location</b> <br />With a stay at A25 Hotel - 20 Bui Thi Xuan in Ho Chi Minh City (Bui Thi Xuan), you'll be within a 10-minute walk of Tao Dan Park and Zen Plaza.  This hotel is 0.5 mi",
          highRate: "33.18",
          lowRate: "33.18",
          latitude: "10.77231",
          longitude: "106.69066",
          proximityDistance: "-1.0",
          proximityUnit: "MI",
          hotelInDestination: "true",
          thumbNailUrl:
            "http://i.travelapi.com/hotels/20000000/19370000/19362000/19361937/41bd5238_t.jpg",
          roomRateDetailsList: [
            {
              token:
                "gpOP9aVeJw4jwZ9PZivOLi4LRS8jP2B6rcygE5u2lAR8uLrxj%2fX%2fMN4SE5jqub5b",
              roomTypeCode: ["202091963"],
              rateCode: ["210737815"],
              maxRoomOccupancy: "3",
              quotedRoomOccupancy: "2",
              minGuestAge: "0",
              roomDescription: ["Superior Room"],
              rateInfos: {
                priceBreakdown: "true",
                promo: "false",
                rateChange: "false",
                roomGroup: [
                  {
                    numberOfAdults: "2",
                    numberOfChildren: "0",
                    rateKey: "1c35ee82-26e5-460f-9b6f-6f795925e8d9-5001-024"
                  }
                ],
                chargeableRateInfo: {
                  currencyCode: "VND",
                  total: "919085.000",
                  commission: "64335.950"
                },
                nonRefundable: "false",
                promoDescription: "",
                currentAllotment: "20",
                cancellationList: null
              },
              valueAdds: null
            }
          ]
        },
        {
          hotelId: "1099064",
          name: "Smiley Apartment 11",
          address1: "45 Bui Thi Xuan Street, District 1",
          address2: "",
          city: "Ho Chi Minh City",
          cityCode: "",
          sessionId: "AC110002-764C-CD91-6732-BA69725973B6",
          stateProvinceCode: "",
          countryCode: "VN",
          airportCode: "SGN",
          propertyCategory: "4",
          hotelRating: "2.0",
          hotelRatingDisplay: "Star",
          confidenceRating: "0",
          amenityMask: "0",
          locationDescription: "In Ho Chi Minh City (Bui Thi Xuan)",
          shortDescription:
            "<p><b>Property Location</b> <br />With a stay at Smiley Apartment 11 in Ho Chi Minh City (Bui Thi Xuan), you'll be within a 10-minute walk of Zen Plaza and September 23 Park.  This apartment is 0.5",
          highRate: "72.73",
          lowRate: "72.73",
          latitude: "10.77123",
          longitude: "106.68978",
          proximityDistance: "-1.0",
          proximityUnit: "MI",
          hotelInDestination: "true",
          thumbNailUrl:
            "http://i.travelapi.com/hotels/20000000/19480000/19473700/19473675/40bef4f4_t.jpg",
          roomRateDetailsList: [
            {
              token:
                "as45GB1wMbTbeMktI5yw3eQdU97kDvMrSSp0Ko6UDfGDipLvcXmohTDAiDKPZqWm",
              roomTypeCode: ["202108961"],
              rateCode: ["210808605"],
              maxRoomOccupancy: "3",
              quotedRoomOccupancy: "2",
              minGuestAge: "0",
              roomDescription: ["501 One Bedroom Apartment"],
              rateInfos: {
                priceBreakdown: "true",
                promo: "false",
                rateChange: "false",
                roomGroup: [
                  {
                    numberOfAdults: "2",
                    numberOfChildren: "0",
                    rateKey: "908c2cd4-c7d0-4526-9bcf-ea96812fe7a5-5001-024"
                  }
                ],
                chargeableRateInfo: {
                  currencyCode: "VND",
                  total: "2028285.000",
                  commission: "141979.950"
                },
                nonRefundable: "false",
                promoDescription: "",
                currentAllotment: "1",
                cancellationList: null
              },
              valueAdds: null
            }
          ]
        },
        {
          hotelId: "1100322",
          name: "Hoan Thai Hotel",
          address1: "82 Ton That Tung, Quan 1",
          address2: "",
          city: "Ho Chi Minh City",
          cityCode: "",
          sessionId: "AC110002-764C-CD91-6732-BA69725973B6",
          stateProvinceCode: "",
          countryCode: "VN",
          airportCode: "",
          propertyCategory: "1",
          hotelRating: "3.0",
          hotelRatingDisplay: "Star",
          confidenceRating: "0",
          amenityMask: "0",
          locationDescription: "In Ho Chi Minh City (Bui Thi Xuan)",
          shortDescription:
            "<p><b>Property Location</b> <br />With a stay at Hoan Thai Hotel in Ho Chi Minh City (Bui Thi Xuan), you'll be within a 10-minute walk of September 23 Park and Pham Ngu Lao Backpacker Area.  This",
          highRate: "43.27",
          lowRate: "20.34",
          latitude: "10.77029",
          longitude: "106.68855",
          proximityDistance: "-1.0",
          proximityUnit: "MI",
          hotelInDestination: "true",
          thumbNailUrl:
            "http://i.travelapi.com/hotels/20000000/19650000/19641300/19641289/7c211483_t.jpg",
          roomRateDetailsList: [
            {
              token:
                "2urkZ6TNu2QGC13M8KE6FPjvWAf7znALIlpP4TyESPHAur2RWR8r5JzRWqGF7FzP",
              roomTypeCode: ["202131073"],
              rateCode: ["210947345"],
              maxRoomOccupancy: "2",
              quotedRoomOccupancy: "2",
              minGuestAge: "0",
              roomDescription: ["Standard Room"],
              rateInfos: {
                priceBreakdown: "true",
                promo: "true",
                rateChange: "false",
                roomGroup: [
                  {
                    numberOfAdults: "2",
                    numberOfChildren: "0",
                    rateKey: "49a0b580-91df-448b-8372-d3930982dea5-5001-024"
                  }
                ],
                chargeableRateInfo: {
                  currencyCode: "VND",
                  total: "567290.000",
                  commission: "39710.300"
                },
                nonRefundable: "false",
                promoDescription: "Save:53%",
                currentAllotment: "11",
                cancellationList: null
              },
              valueAdds: null
            }
          ]
        },
        {
          hotelId: "1114733",
          name: "TRIIP Le Han Dai Nam",
          address1: "142 Bui Thi Xuan",
          address2: "District 1",
          city: "Ho Chi Minh City",
          cityCode: "",
          sessionId: "AC110002-764C-CD91-6732-BA69725973B6",
          stateProvinceCode: "",
          countryCode: "VN",
          airportCode: "SGN",
          propertyCategory: "1",
          hotelRating: "2.0",
          hotelRatingDisplay: "Star",
          confidenceRating: "0",
          amenityMask: "512",
          locationDescription: "In Ho Chi Minh City (Bui Thi Xuan)",
          shortDescription:
            "<p><b>Property Location</b> <br />With a stay at TRIIP Le Han Dai Nam in Ho Chi Minh City (Bui Thi Xuan), you'll be a 5-minute walk from Pham Ngu Lao Backpacker Area and 7 minutes by foot from",
          highRate: "50.18",
          lowRate: "42.65",
          latitude: "10.7693",
          longitude: "106.68774",
          proximityDistance: "-1.0",
          proximityUnit: "MI",
          hotelInDestination: "true",
          thumbNailUrl:
            "http://i.travelapi.com/hotels/22000000/21340000/21338700/21338658/414b6986_t.jpg",
          roomRateDetailsList: [
            {
              token:
                "snBW5hFAqG41znxs2pN%2fPGcqsH8er4A3hygoSeN6QmLF9oC4%2bnsvWBOluW8vbh8F",
              roomTypeCode: ["202319013"],
              rateCode: ["211983316"],
              maxRoomOccupancy: "3",
              quotedRoomOccupancy: "2",
              minGuestAge: "0",
              roomDescription: ["Standard Room"],
              rateInfos: {
                priceBreakdown: "true",
                promo: "true",
                rateChange: "false",
                roomGroup: [
                  {
                    numberOfAdults: "2",
                    numberOfChildren: "0",
                    rateKey: "985c93af-6f1b-45f2-b5a8-2604f13a64c6-5001-024"
                  }
                ],
                chargeableRateInfo: {
                  currencyCode: "VND",
                  total: "1189570.000",
                  commission: "83269.900"
                },
                nonRefundable: "false",
                promoDescription: "Book early and save 15%",
                currentAllotment: "6",
                cancellationList: null
              },
              valueAdds: null
            }
          ]
        },
        {
          hotelId: "1015539",
          name: "A25 Hotel Le Thi Rieng",
          address1: "145 Le Thi Rieng, Ben Thanh Ward",
          address2: "",
          city: "Ho Chi Minh City",
          cityCode: "",
          sessionId: "AC110002-764C-CD91-6732-BA69725973B6",
          stateProvinceCode: "",
          countryCode: "VN",
          airportCode: "",
          propertyCategory: "1",
          hotelRating: "3.0",
          hotelRatingDisplay: "Star",
          confidenceRating: "0",
          amenityMask: "134234369",
          locationDescription: "In Ho Chi Minh City (Bui Thi Xuan)",
          shortDescription:
            "<p><b>Property Location</b> <br />With a stay at A25 Hotel Le Thi Rieng in Ho Chi Minh City (Bui Thi Xuan), you'll be within a 10-minute walk of Pham Ngu Lao Backpacker Area and Zen Plaza.  This",
          highRate: "38.43",
          lowRate: "34.59",
          latitude: "10.77032",
          longitude: "106.68913",
          proximityDistance: "-1.0",
          proximityUnit: "MI",
          hotelInDestination: "true",
          thumbNailUrl:
            "http://i.travelapi.com/hotels/22000000/21540000/21539900/21539846/8e8b824c_t.jpg",
          roomRateDetailsList: [
            {
              token:
                "Gq%2bePM4zO8OnF6Tids%2ficYiYaheYpahjpZcf2k6ntxVcVdntUDKHarxBaVPbgdq3",
              roomTypeCode: ["202360096"],
              rateCode: ["212120337"],
              maxRoomOccupancy: "3",
              quotedRoomOccupancy: "2",
              minGuestAge: "0",
              roomDescription: ["Deluxe Double or Twin Room"],
              rateInfos: {
                priceBreakdown: "true",
                promo: "true",
                rateChange: "false",
                roomGroup: [
                  {
                    numberOfAdults: "2",
                    numberOfChildren: "0",
                    rateKey: "76a5f2e5-7782-4f4d-92b1-6376b8a7ea45-5001-024"
                  }
                ],
                chargeableRateInfo: {
                  currencyCode: "VND",
                  total: "958330.000",
                  commission: "67083.100"
                },
                nonRefundable: "false",
                promoDescription: "Save:10%",
                currentAllotment: "15",
                cancellationList: null
              },
              valueAdds: null
            }
          ]
        },
        {
          hotelId: "1029346",
          name: "Condodo Hostel",
          address1: "149/22A Le Thi Rieng, District 1",
          address2: "",
          city: "Ho Chi Minh City",
          cityCode: "",
          sessionId: "AC110002-764C-CD91-6732-BA69725973B6",
          stateProvinceCode: "",
          countryCode: "VN",
          airportCode: "",
          propertyCategory: "1",
          hotelRating: "1.5",
          hotelRatingDisplay: "Star",
          confidenceRating: "0",
          amenityMask: "393216",
          locationDescription: "In Ho Chi Minh City (Bui Thi Xuan)",
          shortDescription:
            "<p><b>Property Location</b> <br />With a stay at Condodo Hostel in Ho Chi Minh City (Bui Thi Xuan), you'll be a 5-minute walk from Pham Ngu Lao Backpacker Area and 5 minutes by foot from Zen Plaza. ",
          highRate: "20.00",
          lowRate: "18.00",
          latitude: "10.77004",
          longitude: "106.68934",
          proximityDistance: "-1.0",
          proximityUnit: "MI",
          hotelInDestination: "true",
          thumbNailUrl:
            "http://i.travelapi.com/hotels/23000000/22400000/22398000/22397991/6afc618f_t.jpg",
          roomRateDetailsList: [
            {
              token:
                "1ms2NSiHTec4dtnwHZXKxsMiBqi91tpOz2BXR2IxBca8mTWUGvdAjNQfGw4a0tkA",
              roomTypeCode: ["220800681"],
              rateCode: ["292001667"],
              maxRoomOccupancy: "3",
              quotedRoomOccupancy: "2",
              minGuestAge: "0",
              roomDescription: ["Twin Room"],
              rateInfos: {
                priceBreakdown: "true",
                promo: "true",
                rateChange: "false",
                roomGroup: [
                  {
                    numberOfAdults: "2",
                    numberOfChildren: "0",
                    rateKey: "03c9ad71-8e9b-4b53-b84e-7e94b41653ab-5001-024"
                  }
                ],
                chargeableRateInfo: {
                  currencyCode: "VND",
                  total: "498670.000",
                  commission: "34906.900"
                },
                nonRefundable: "false",
                promoDescription: "Save10%",
                currentAllotment: "1",
                cancellationList: null
              },
              valueAdds: null
            }
          ]
        },
        {
          hotelId: "1139813",
          name: "TRIIP Cupid",
          address1: "2 bis Nam Quoc Cang",
          address2: "Pham Ngu Lao Ward, District 1",
          city: "Ho Chi Minh City",
          cityCode: "",
          sessionId: "AC110002-764C-CD91-6732-BA69725973B6",
          stateProvinceCode: "",
          countryCode: "VN",
          airportCode: "",
          propertyCategory: "1",
          hotelRating: "3.0",
          hotelRatingDisplay: "Star",
          confidenceRating: "0",
          amenityMask: "0",
          locationDescription: "In Ho Chi Minh City (Bui Thi Xuan)",
          shortDescription:
            "<p><b>Property Location</b> <br />With a stay at TRIIP Cupid in Ho Chi Minh City (Bui Thi Xuan), you'll be steps from Pham Ngu Lao Backpacker Area and 5 minutes by foot from Bui Vien Walking Street. ",
          highRate: "50.91",
          lowRate: "50.91",
          latitude: "10.76768",
          longitude: "106.6883",
          proximityDistance: "-1.0",
          proximityUnit: "MI",
          hotelInDestination: "true",
          thumbNailUrl:
            "http://i.travelapi.com/hotels/24000000/23260000/23255000/23254947/3186a0b3_t.jpg",
          roomRateDetailsList: [
            {
              token:
                "cp09Aj1kCU3G3SbtB1lTiNPCSzr%2fbSIh%2foCCb0RgeFztwgA35bzagNkemC5EIzZg",
              roomTypeCode: ["219306442"],
              rateCode: ["282022693"],
              maxRoomOccupancy: "3",
              quotedRoomOccupancy: "2",
              minGuestAge: "0",
              roomDescription: ["Superior Room"],
              rateInfos: {
                priceBreakdown: "true",
                promo: "false",
                rateChange: "false",
                roomGroup: [
                  {
                    numberOfAdults: "2",
                    numberOfChildren: "0",
                    rateKey: "62fe633e-b2bc-4d04-abc8-562957cc5cc5-5001-024"
                  }
                ],
                chargeableRateInfo: {
                  currencyCode: "VND",
                  total: "1419870.000",
                  commission: "99390.900"
                },
                nonRefundable: "false",
                promoDescription: "",
                currentAllotment: "5",
                cancellationList: null
              },
              valueAdds: null
            }
          ]
        },
        {
          hotelId: "1150289",
          name: "Namoo's stories - Home",
          address1: "05 Luong Huu Khanh, Ward Pham Ngu Lao",
          address2: "District 1",
          city: "Ho Chi Minh City",
          cityCode: "",
          sessionId: "AC110002-764C-CD91-6732-BA69725973B6",
          stateProvinceCode: "",
          countryCode: "VN",
          airportCode: "",
          propertyCategory: "4",
          hotelRating: "2.5",
          hotelRatingDisplay: "Star",
          confidenceRating: "0",
          amenityMask: "134234112",
          locationDescription: "In Ho Chi Minh City (Bui Thi Xuan)",
          shortDescription:
            "<p><b>Property Location</b> <br />With a stay at Namoo's stories - Home in Ho Chi Minh City (Bui Thi Xuan), you'll be steps from Pham Ngu Lao Backpacker Area and 5 minutes by foot from September 23",
          highRate: "20.78",
          lowRate: "18.70",
          latitude: "10.76797",
          longitude: "106.68851",
          proximityDistance: "-1.0",
          proximityUnit: "MI",
          hotelInDestination: "true",
          thumbNailUrl:
            "http://i.travelapi.com/hotels/25000000/24130000/24127500/24127425/b7a20ba1_t.jpg",
          roomRateDetailsList: [
            {
              token:
                "LeeFI%2fXd2ckK%2bAcBdg78TVT8DmE8fU8lW5KdfEVUPWaDLLCwhWnqcJeAYk3z3kuF",
              roomTypeCode: ["217207087"],
              rateCode: ["268029548"],
              maxRoomOccupancy: "2",
              quotedRoomOccupancy: "2",
              minGuestAge: "0",
              roomDescription: ["Blueberry Room"],
              rateInfos: {
                priceBreakdown: "true",
                promo: "true",
                rateChange: "false",
                roomGroup: [
                  {
                    numberOfAdults: "2",
                    numberOfChildren: "0",
                    rateKey: "8347386f-bcb4-469b-bc53-6725e126daf9-5001-024"
                  }
                ],
                chargeableRateInfo: {
                  currencyCode: "VND",
                  total: "519585.000",
                  commission: "36370.950"
                },
                nonRefundable: "false",
                promoDescription: "Save10%",
                currentAllotment: "1",
                cancellationList: null
              },
              valueAdds: null
            }
          ]
        },
        {
          hotelId: "1153354",
          name: "Alleyway Home - Hostel",
          address1: "162/9 Bui Thi Xuan, District 1",
          address2: "",
          city: "Ho Chi Minh City",
          cityCode: "",
          sessionId: "AC110002-764C-CD91-6732-BA69725973B6",
          stateProvinceCode: "",
          countryCode: "VN",
          airportCode: "",
          propertyCategory: "1",
          hotelRating: "2.0",
          hotelRatingDisplay: "Star",
          confidenceRating: "0",
          amenityMask: "0",
          locationDescription: "In Ho Chi Minh City (Bui Thi Xuan)",
          shortDescription:
            "<p><b>Property Location</b> <br />With a stay at Alleyway Home - Hostel in Ho Chi Minh City (Bui Thi Xuan), you'll be a 5-minute walk from Pham Ngu Lao Backpacker Area and 7 minutes by foot from",
          highRate: "21.82",
          lowRate: "19.64",
          latitude: "10.76891",
          longitude: "106.68803",
          proximityDistance: "-1.0",
          proximityUnit: "MI",
          hotelInDestination: "true",
          thumbNailUrl:
            "http://i.travelapi.com/hotels/25000000/24320000/24317700/24317656/02ae7362_t.jpg",
          roomRateDetailsList: [
            {
              token:
                "k04GXkv8liPI8YBNuSToHPg%2bdfgtI%2fCOKiZBQcYD18a65c8moYCFCw2VeO32IsBy",
              roomTypeCode: ["220812105"],
              rateCode: ["292040726"],
              maxRoomOccupancy: "3",
              quotedRoomOccupancy: "2",
              minGuestAge: "0",
              roomDescription: ["Superior Double Room"],
              rateInfos: {
                priceBreakdown: "true",
                promo: "true",
                rateChange: "false",
                roomGroup: [
                  {
                    numberOfAdults: "2",
                    numberOfChildren: "0",
                    rateKey: "b2043262-4024-4729-9355-7211ad7f9e82-5001-024"
                  }
                ],
                chargeableRateInfo: {
                  currencyCode: "VND",
                  total: "547550.000",
                  commission: "38328.500"
                },
                nonRefundable: "false",
                promoDescription: "Save10%",
                currentAllotment: "1",
                cancellationList: null
              },
              valueAdds: null
            }
          ]
        },
        {
          hotelId: "1153452",
          name: "9 Hostel and Bar",
          address1: "9 Bui Thi Xuan",
          address2: "District 1",
          city: "Ho Chi Minh City",
          cityCode: "",
          sessionId: "AC110002-764C-CD91-6732-BA69725973B6",
          stateProvinceCode: "",
          countryCode: "VN",
          airportCode: "",
          propertyCategory: "1",
          hotelRating: "2.0",
          hotelRatingDisplay: "Star",
          confidenceRating: "0",
          amenityMask: "0",
          locationDescription: "In Ho Chi Minh City (Bui Thi Xuan)",
          shortDescription:
            "<p><b>Property Location</b> <br />With a stay at 9 Hostel and Bar in Ho Chi Minh City (Bui Thi Xuan), you'll be within a 15-minute walk of Bui Vien Walking Street and Ben Thanh Market.  This hostel",
          highRate: "16.51",
          lowRate: "9.91",
          latitude: "10.77206",
          longitude: "106.69082",
          proximityDistance: "-1.0",
          proximityUnit: "MI",
          hotelInDestination: "true",
          thumbNailUrl:
            "http://i.travelapi.com/hotels/25000000/24330000/24327800/24327715/bf0583c0_t.jpg",
          roomRateDetailsList: [
            {
              token:
                "2HhoWxJLe824cuoAeXl0DP8%2bwmTozpholzYVhTwHZWLj3n%2bsodAlb080LpxPOuVi",
              roomTypeCode: ["215708323"],
              rateCode: ["258034905"],
              maxRoomOccupancy: "12",
              quotedRoomOccupancy: "2",
              minGuestAge: "0",
              roomDescription: ["Bunk Bed in 12 Beds Mixed Dormitory Room"],
              rateInfos: {
                priceBreakdown: "true",
                promo: "true",
                rateChange: "false",
                roomGroup: [
                  {
                    numberOfAdults: "2",
                    numberOfChildren: "0",
                    rateKey: "f83256ba-909c-4508-878f-97a30866915b-5001-024"
                  }
                ],
                chargeableRateInfo: {
                  currencyCode: "VND",
                  total: "276360.000",
                  commission: "19345.200"
                },
                nonRefundable: "false",
                promoDescription: "Flash sale: save 40%",
                currentAllotment: "20",
                cancellationList: null
              },
              valueAdds: null
            }
          ]
        },
        {
          hotelId: "1165017",
          name: "Bonita Signature Hotel",
          address1: "118A Bui Thi Xuan",
          address2: "District 1",
          city: "Ho Chi Minh City",
          cityCode: "",
          sessionId: "AC110002-764C-CD91-6732-BA69725973B6",
          stateProvinceCode: "",
          countryCode: "VN",
          airportCode: "",
          propertyCategory: "1",
          hotelRating: "2.5",
          hotelRatingDisplay: "Star",
          confidenceRating: "0",
          amenityMask: "0",
          locationDescription: "In Ho Chi Minh City (Bui Thi Xuan)",
          shortDescription:
            "<p><b>Property Location</b> <br />With a stay at Bonita Signature Hotel in Ho Chi Minh City (Bui Thi Xuan), you'll be within a 10-minute walk of September 23 Park and Pham Ngu Lao Backpacker Area. ",
          highRate: "32.00",
          lowRate: "25.60",
          latitude: "10.77024",
          longitude: "106.68866",
          proximityDistance: "-1.0",
          proximityUnit: "MI",
          hotelInDestination: "true",
          thumbNailUrl:
            "http://i.travelapi.com/hotels/27000000/26770000/26768200/26768147/9fabe47e_t.jpg",
          roomRateDetailsList: [
            {
              token:
                "HbuCbsgWUrVa6wl71GjjQCKYNX5rdDPgVEaYPbbP5PgOLkNY9JZdoNodz4BSJjhN",
              roomTypeCode: ["221717010"],
              rateCode: ["298057543"],
              maxRoomOccupancy: "3",
              quotedRoomOccupancy: "2",
              minGuestAge: "0",
              roomDescription: ["Single Room"],
              rateInfos: {
                priceBreakdown: "true",
                promo: "true",
                rateChange: "false",
                roomGroup: [
                  {
                    numberOfAdults: "2",
                    numberOfChildren: "0",
                    rateKey: "fe7a2a4c-bb98-4644-981f-c48d8ad6c411-5001-024"
                  }
                ],
                chargeableRateInfo: {
                  currencyCode: "VND",
                  total: "714165.000",
                  commission: "49991.550"
                },
                nonRefundable: "false",
                promoDescription: "Save20%",
                currentAllotment: "6",
                cancellationList: null
              },
              valueAdds: null
            }
          ]
        },
        {
          hotelId: "1169670",
          name: "Language Exchange",
          address1: "399/43/5 Nguyen Dinh Chieu, District 3",
          address2: "",
          city: "Ho Chi Minh City",
          cityCode: "",
          sessionId: "AC110002-764C-CD91-6732-BA69725973B6",
          stateProvinceCode: "",
          countryCode: "VN",
          airportCode: "SGN",
          propertyCategory: "1",
          hotelRating: "2.0",
          hotelRatingDisplay: "Star",
          confidenceRating: "0",
          amenityMask: "134234112",
          locationDescription: "In Ho Chi Minh City (Bui Thi Xuan)",
          shortDescription:
            "<p><b>Property Location</b> <br />Located in Ho Chi Minh City (Bui Thi Xuan), Language Exchange is within a 5-minute drive of Zen Plaza and September 23 Park.  This hostel is 0.3 mi (0.5 km) from",
          highRate: "16.36",
          lowRate: "14.72",
          latitude: "10.76967",
          longitude: "106.69053",
          proximityDistance: "-1.0",
          proximityUnit: "MI",
          hotelInDestination: "true",
          thumbNailUrl:
            "http://i.travelapi.com/hotels/28000000/27300000/27298800/27298774/e1c4ae75_t.jpg",
          roomRateDetailsList: [
            {
              token:
                "IRRnfMsdmCUgn2ZPFRysrX8M%2fifdB0TnHfy5qouBzKaAJYO%2bDt6YXqRU1eLahv%2b%2f",
              roomTypeCode: ["216916795"],
              rateCode: ["266060311"],
              maxRoomOccupancy: "2",
              quotedRoomOccupancy: "2",
              minGuestAge: "0",
              roomDescription: ["Superior Double Room"],
              rateInfos: {
                priceBreakdown: "true",
                promo: "true",
                rateChange: "false",
                roomGroup: [
                  {
                    numberOfAdults: "2",
                    numberOfChildren: "0",
                    rateKey: "6bf5ecb9-2b02-4329-bf78-0ae6c7418c08-5001-024"
                  }
                ],
                chargeableRateInfo: {
                  currencyCode: "VND",
                  total: "410545.000",
                  commission: "28738.150"
                },
                nonRefundable: "false",
                promoDescription: "Book early and save 10%",
                currentAllotment: "1",
                cancellationList: null
              },
              valueAdds: null
            }
          ]
        },
        {
          hotelId: "1381120",
          name: "Kim Long Chau Hotel",
          address1: "19D Bui Thi Xuan Street",
          address2: "District 1",
          city: "Ho Chi Minh City",
          cityCode: "",
          sessionId: "AC110002-764C-CD91-6732-BA69725973B6",
          stateProvinceCode: "",
          countryCode: "VN",
          airportCode: "",
          propertyCategory: "1",
          hotelRating: "3.0",
          hotelRatingDisplay: "Star",
          confidenceRating: "0",
          amenityMask: "0",
          locationDescription: "In Ho Chi Minh City (Bui Thi Xuan)",
          shortDescription:
            "<p><b>Property Location</b> <br />With a stay at Kim Long Chau Hotel in Ho Chi Minh City (Bui Thi Xuan), you'll be minutes from Zen Plaza and Tao Dan Park.  This hotel is within close proximity of",
          highRate: "40.00",
          lowRate: "20.00",
          latitude: "10.772",
          longitude: "106.69055",
          proximityDistance: "-1.0",
          proximityUnit: "MI",
          hotelInDestination: "true",
          thumbNailUrl:
            "http://i.travelapi.com/hotels/29000000/28920000/28918000/28917905/a3b3ec3f_t.jpg",
          roomRateDetailsList: [
            {
              token:
                "3VrU2xgwK80fyKAtsB1dckxeksQRHvcqqe9d7kmbQHVSC3MK2iCSMbetFWauGEhp",
              roomTypeCode: ["215716867"],
              rateCode: ["258065084"],
              maxRoomOccupancy: "2",
              quotedRoomOccupancy: "2",
              minGuestAge: "0",
              roomDescription: ["Superior Double Room"],
              rateInfos: {
                priceBreakdown: "true",
                promo: "true",
                rateChange: "false",
                roomGroup: [
                  {
                    numberOfAdults: "2",
                    numberOfChildren: "0",
                    rateKey: "d0c12bdc-88f3-434c-a76f-e77536fdd32f-5001-024"
                  }
                ],
                chargeableRateInfo: {
                  currencyCode: "VND",
                  total: "557655.000",
                  commission: "39035.850"
                },
                nonRefundable: "false",
                promoDescription: "Save 50%",
                currentAllotment: "2",
                cancellationList: null
              },
              valueAdds: null
            }
          ]
        }
      ]
    };
  },
  methods: {},
  created: function() {
    this.backupHotelListRS = JSON.parse(JSON.stringify(this.hotelListRS));
    // Using the service bus
    serverBus.$on("serverSelected", filters => {
      this.filters = filters;
      this.hotelListRS = JSON.parse(JSON.stringify(this.backupHotelListRS));
      if (this.filters && this.filters.favorite&&this.filters.favorite.hotelId) {
        this.hotelListRS = this.hotelListRS.filter(
          h => h.hotelId === this.filters.favorite.hotelId
        );
      }

      if (
        this.filters &&
        this.filters.rating &&
        this.filters.rating.length > 0
      ) {
        this.hotelListRS = this.hotelListRS.filter(h => {
          return this.filters.rating.indexOf(h.hotelRating) != -1;
        });
      }
      if (this.filters && this.filters.Promotion) {
        this.hotelListRS = this.hotelListRS.filter(h => {
          return (
            h.roomRateDetailsList &&
            h.roomRateDetailsList[0].rateInfos &&
            h.roomRateDetailsList[0].rateInfos.promo === "true"
          );
        });
      }
    });
  }
};
</script>