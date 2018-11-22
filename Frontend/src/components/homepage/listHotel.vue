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
          <div  v-for="hotel in hotelListRS" class="listing-item has_two_column has_one_column">
            <article class="geodir-category-listing fl-wrap">
              <div class="geodir-category-img">
                <a href="listing-single.html"><img :src="hotel.cover" alt=""></a>
                <div class="listing-avatar"><a href="author-single.html"><img src="assets/images/avatar/1.jpg" alt=""></a>
                  <span class="avatar-tooltip">Added By <strong>Alisa Noory</strong></span>
                </div>
                <div class="sale-window">{{hotel.promotion}}</div>
                <div class="geodir-category-opt">
                  <div class="listing-rating card-popup-rainingvis" data-starrating2="5"></div>
                  <div class="rate-class-name">
                    <div class="score"><strong>Very Good</strong>27 Reviews </div>
                    <span>{{hotel.rate}}</span>
                  </div>
                </div>
              </div>
              <div class="geodir-category-content fl-wrap title-sin_item">
                <div class="geodir-category-content-title fl-wrap">
                  <div class="geodir-category-content-title-item">
                    <h3 class="title-sin_map"><a href="listing-single.html">{{hotel.hotelName}}</a></h3>
                    <div class="geodir-category-location fl-wrap"><a href="#" class="map-item"><i class="fas fa-map-marker-alt"></i>
                      {{hotel.hotelAddress}} </a></div>
                  </div>
                </div>
                <p  v-html="hotel.hotelDescription">  </p>
                <!-- <ul class="facilities-list fl-wrap">
                  <li><i class="fal fa-wifi"></i><span>Free WiFi</span></li>
                  <li><i class="fal fa-parking"></i><span>Parking</span></li>
                  <li><i class="fal fa-smoking-ban"></i><span>Non-smoking Rooms</span></li>
                  <li><i class="fal fa-utensils"></i><span> Restaurant</span></li>
                </ul> -->
                <div class="geodir-category-footer fl-wrap">
                  <div class="geodir-category-price">Awg/Night <span> {{hotel.roomGroup.currencyCode}}  {{hotel.roomGroup.totalPrice}}</span></div>
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
          <!-- listing-item  -->
          <div class="listing-item has_two_column has_one_column">
            <article class="geodir-category-listing fl-wrap">
              <div class="geodir-category-img">
                <a href="listing-single.html"><img src="assets/images/gal/1.jpg" alt=""></a>
                <div class="listing-avatar"><a href="author-single.html"><img src="assets/images/avatar/1.jpg" alt=""></a>
                  <span class="avatar-tooltip">Added By <strong>Julie Cramp</strong></span>
                </div>
                <div class="sale-window big-sale">Sale 50%</div>
                <div class="geodir-category-opt">
                  <div class="listing-rating card-popup-rainingvis" data-starrating2="4"></div>
                  <div class="rate-class-name">
                    <div class="score"><strong>Good</strong>12 Reviews </div>
                    <span>4.2</span>
                  </div>
                </div>
              </div>
              <div class="geodir-category-content fl-wrap title-sin_item">
                <div class="geodir-category-content-title fl-wrap">
                  <div class="geodir-category-content-title-item">
                    <h3 class="title-sin_map"><a href="listing-single.html">Grand Hero Palace</a></h3>
                    <div class="geodir-category-location fl-wrap"><a href="#" class="map-item"><i class="fas fa-map-marker-alt"></i>
                        W 85th St, New York, USA</a></div>
                  </div>
                </div>
                <p> Morbi suscipit erat in diam bibendum rutrum in nisl. Aliquam et purus ante.</p>
                <ul class="facilities-list fl-wrap">
                  <li><i class="fal fa-wifi"></i><span>Free WiFi</span></li>
                  <li><i class="fal fa-parking"></i><span>Parking</span></li>
                  <li><i class="fal fa-smoking-ban"></i><span>Non-smoking Rooms</span></li>
                  <li><i class="fal fa-utensils"></i><span> Restaurant</span></li>
                </ul>
                <div class="geodir-category-footer fl-wrap">
                  <div class="geodir-opt-link">
                    <div class="geodir-category-price">Awg/Night <span>$ 120</span></div>
                  </div>
                  <div class="geodir-opt-list">
                    <a href="#" class="single-map-item" data-newlatitude="40.76221766" data-newlongitude="-73.96511769"><i
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
          <!-- listing-item  -->
          <div class="listing-item has_two_column has_one_column">
            <article class="geodir-category-listing fl-wrap">
              <div class="geodir-category-img">
                <a href="listing-single.html"><img src="assets/images/gal/1.jpg" alt=""></a>
                <div class="listing-avatar"><a href="author-single.html"><img src="assets/images/avatar/1.jpg" alt=""></a>
                  <span class="avatar-tooltip">Added By <strong>Andy Moore</strong></span>
                </div>
                <div class="geodir-category-opt">
                  <div class="listing-rating card-popup-rainingvis" data-starrating2="5"></div>
                  <div class="rate-class-name">
                    <div class="score"><strong>Good</strong>6 Reviews </div>
                    <span>4.7</span>
                  </div>
                </div>
              </div>
              <div class="geodir-category-content fl-wrap title-sin_item">
                <div class="geodir-category-content-title fl-wrap">
                  <div class="geodir-category-content-title-item">
                    <h3 class="title-sin_map"><a href="listing-single.html">Park Central</a></h3>
                    <div class="geodir-category-location fl-wrap"><a href="#" class="map-item"><i class="fas fa-map-marker-alt"></i>40
                        Journal Square Plaza, NJ, USA</a></div>
                  </div>
                </div>
                <p> Sed tempor iaculis massa faucibus feugiat. In fermentum facilisis massa.</p>
                <ul class="facilities-list fl-wrap">
                  <li><i class="fal fa-wifi"></i><span>Free WiFi</span></li>
                  <li><i class="fal fa-parking"></i><span>Parking</span></li>
                  <li><i class="fal fa-smoking-ban"></i><span>Non-smoking Rooms</span></li>
                  <li><i class="fal fa-utensils"></i><span> Restaurant</span></li>
                </ul>
                <div class="geodir-category-footer fl-wrap">
                  <div class="geodir-opt-link">
                    <div class="geodir-category-price">Awg/Night <span>$ 80</span></div>
                  </div>
                  <div class="geodir-opt-list">
                    <a href="#" class="single-map-item" data-newlatitude="40.88496706" data-newlongitude="-73.88191222"><i
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
          <!-- listing-item  -->
          <div class="listing-item has_two_column has_one_column">
            <article class="geodir-category-listing fl-wrap">
              <div class="geodir-category-img">
                <a href="listing-single.html"><img src="assets/images/gal/1.jpg" alt=""></a>
                <div class="listing-avatar"><a href="author-single.html"><img src="assets/images/avatar/1.jpg" alt=""></a>
                  <span class="avatar-tooltip">Added By <strong>Mary Jones</strong></span>
                </div>
                <div class="sale-window">Sale 20%</div>
                <div class="geodir-category-opt">
                  <div class="listing-rating card-popup-rainingvis" data-starrating2="3"></div>
                  <div class="rate-class-name">
                    <div class="score"><strong>Pleasant</strong>10 Reviews </div>
                    <span>3.2</span>
                  </div>
                </div>
              </div>
              <div class="geodir-category-content fl-wrap title-sin_item">
                <div class="geodir-category-content-title fl-wrap">
                  <div class="geodir-category-content-title-item">
                    <h3 class="title-sin_map"><a href="listing-single.html">Holiday Home</a></h3>
                    <div class="geodir-category-location fl-wrap"><a href="#" class="map-item"><i class="fas fa-map-marker-alt"></i>
                        75 Prince St, NY, USA</a></div>
                  </div>
                </div>
                <p> Mauris ac maximus neque. Nam in mauris quis libero sodales eleifend.</p>
                <ul class="facilities-list fl-wrap">
                  <li><i class="fal fa-wifi"></i><span>Free WiFi</span></li>
                  <li><i class="fal fa-parking"></i><span>Parking</span></li>
                  <li><i class="fal fa-smoking-ban"></i><span>Non-smoking Rooms</span></li>
                  <li><i class="fal fa-utensils"></i><span> Restaurant</span></li>
                </ul>
                <div class="geodir-category-footer fl-wrap">
                  <div class="geodir-opt-link">
                    <div class="geodir-category-price">Awg/Night <span>$ 50</span></div>
                  </div>
                  <div class="geodir-opt-list">
                    <a href="#" class="single-map-item" data-newlatitude="40.72228267" data-newlongitude="-73.99246214"><i
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
          <!-- listing-item  -->
          <div class="listing-item has_two_column has_one_column">
            <article class="geodir-category-listing fl-wrap">
              <div class="geodir-category-img">
                <a href="listing-single.html"><img src="assets/images/gal/1.jpg" alt=""></a>
                <div class="listing-avatar"><a href="author-single.html"><img src="assets/images/avatar/1.jpg" alt=""></a>
                  <span class="avatar-tooltip">Added By <strong>Fider Mamby</strong></span>
                </div>
                <div class="sale-window">Sale 10%</div>
                <div class="geodir-category-opt">
                  <div class="listing-rating card-popup-rainingvis" data-starrating2="5"></div>
                  <div class="rate-class-name">
                    <div class="score"><strong>Very Good</strong>102 Reviews </div>
                    <span>4.7</span>
                  </div>
                </div>
              </div>
              <div class="geodir-category-content fl-wrap title-sin_item">
                <div class="geodir-category-content-title fl-wrap">
                  <div class="geodir-category-content-title-item">
                    <h3 class="title-sin_map"><a href="listing-single.html">Gold Plaza Hotel</a></h3>
                    <div class="geodir-category-location fl-wrap"><a href="#" class="map-item"><i class="fas fa-map-marker-alt"></i>
                        34-42 Montgomery St , NY, USA</a></div>
                  </div>
                </div>
                <p> Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut nec tincidunt arcu, sit amet . </p>
                <ul class="facilities-list fl-wrap">
                  <li><i class="fal fa-wifi"></i><span>Free WiFi</span></li>
                  <li><i class="fal fa-parking"></i><span>Parking</span></li>
                  <li><i class="fal fa-smoking-ban"></i><span>Non-smoking Rooms</span></li>
                  <li><i class="fal fa-utensils"></i><span> Restaurant</span></li>
                </ul>
                <div class="geodir-category-footer fl-wrap">
                  <div class="geodir-opt-link">
                    <div class="geodir-category-price">Awg/Night <span>$ 210</span></div>
                  </div>
                  <div class="geodir-opt-list">
                    <a href="#" class="single-map-item" data-newlatitude="40.94982541" data-newlongitude="-73.84357452"><i
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
          <!-- listing-item  -->
          <div class="listing-item has_two_column has_one_column">
            <article class="geodir-category-listing fl-wrap">
              <div class="geodir-category-img">
                <a href="listing-single.html"><img src="assets/images/gal/1.jpg" alt=""></a>
                <div class="listing-avatar"><a href="author-single.html"><img src="assets/images/avatar/1.jpg" alt=""></a>
                  <span class="avatar-tooltip">Added By <strong>Alisa Noory</strong></span>
                </div>
                <div class="sale-window big-sale">Sale 70%</div>
                <div class="geodir-category-opt">
                  <div class="listing-rating card-popup-rainingvis" data-starrating2="4"></div>
                  <div class="rate-class-name">
                    <div class="score"><strong> Good</strong>8 Reviews </div>
                    <span>4.1</span>
                  </div>
                </div>
              </div>
              <div class="geodir-category-content fl-wrap title-sin_item">
                <div class="geodir-category-content-title fl-wrap">
                  <div class="geodir-category-content-title-item">
                    <h3 class="title-sin_map"><a href="listing-single.html">Moonlight Hotel</a></h3>
                    <div class="geodir-category-location fl-wrap"><a href="#" class="map-item"><i class="fas fa-map-marker-alt"></i>
                        70 Bright St New York, USA</a></div>
                  </div>
                </div>
                <p> Class aptent taciti Mauris ac maximus neque. Nam in mauris quis libero sodales eleifend.</p>
                <ul class="facilities-list fl-wrap">
                  <li><i class="fal fa-wifi"></i><span>Free WiFi</span></li>
                  <li><i class="fal fa-parking"></i><span>Parking</span></li>
                  <li><i class="fal fa-smoking-ban"></i><span>Non-smoking Rooms</span></li>
                  <li><i class="fal fa-utensils"></i><span> Restaurant</span></li>
                </ul>
                <div class="geodir-category-footer fl-wrap">
                  <div class="geodir-opt-link">
                    <div class="geodir-category-price">Awg/Night <span>$ 105</span></div>
                  </div>
                  <div class="geodir-opt-list">
                    <a href="#" class="single-map-item" data-newlatitude="40.90261483" data-newlongitude="-74.15737152"><i
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
export default {
    data(){
        return {
           hotelListRS: 
 [
    {
      "roomGroup": {
        "totalPrice": "240883.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Economy Shared Dormitory, Mixed Dorm",
            "roomCode": "210005029",
            "boardName": "",
            "specialOffer": "",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Economy Shared Dormitory, Mixed Dorm",
            "roomCode": "210005029",
            "boardName": "",
            "specialOffer": "",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "7D19",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "444445",
      "cover": "http://i.travelapi.com/hotels/7000000/6910000/6905800/6905788/3f21e53a_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Phuc Khanh Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Phuc Khanh Hotel places you in the heart of Ho Chi Minh City, within a 10-minute walk of Saigon River and Pham Ngu Lao Backpacker Area.  This hotel is 0.4 …",
      "longitude": "106.69862",
      "latitude": "10.76517",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "9 Yersin, Ben Thanh Market, "
    },
    {
      "roomGroup": {
        "totalPrice": "260712.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Bed in Dorm Room",
            "roomCode": "220506806",
            "boardName": "",
            "specialOffer": "Save 49%",
            "availability": "14",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Bed in Dorm Room",
            "roomCode": "220506806",
            "boardName": "",
            "specialOffer": "Save 49%",
            "availability": "14",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "836D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "880316",
      "cover": "http://i.travelapi.com/hotels/24000000/23420000/23415400/23415325/84c7a5ca_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Aloha Saigon - Hostel - Adults Only",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Aloha Saigon - Hostel - Adults Only in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Pham Ngu Lao Backpacker Area and Bui Vien …",
      "longitude": "106.69127",
      "latitude": "10.76672",
      "promotion": "Save 49%",
      "supplierCode": "s007",
      "hotelAddress": "24/3 Do Quang Dau, District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "296697.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "201900548",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "201900548",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "8EE9",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "679963",
      "cover": "http://i.travelapi.com/hotels/18000000/17890000/17880400/17880357/a2aad9d4_t.jpg",
      "rate": "1.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Vinabooker Huynh Tan Phat",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Vinabooker Huynh Tan Phat in Ho Chi Minh City, you'll be 6.8 mi (11 km) from SC VivoCity and 6.8 mi (11 km) from Saigon Paragon Mall.  This guesthouse …",
      "longitude": "106.73932",
      "latitude": "10.67915",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "A8-31 Phu Xuan (Cotec) Huynh Tan Phat, "
    },
    {
      "roomGroup": {
        "totalPrice": "346392.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Bed in 8-bed Mixed Dormitory Room",
            "roomCode": "201687279",
            "boardName": "",
            "specialOffer": "Member’s price: 30%",
            "availability": "8",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Bed in 8-bed Mixed Dormitory Room",
            "roomCode": "201687279",
            "boardName": "",
            "specialOffer": "Member’s price: 30%",
            "availability": "8",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "9EC5",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "628612",
      "cover": "http://i.travelapi.com/hotels/17000000/16190000/16189500/16189463/0e6adb0f_t.jpg",
      "rate": "1.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Sakura Hostel Saigon",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Sakura Hostel Saigon in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Zen Plaza and 3 minutes by foot from September 23 Park.  …",
      "longitude": "106.69285",
      "latitude": "10.77026",
      "promotion": "Member’s price: 30%",
      "supplierCode": "s007",
      "hotelAddress": "39/26 Nguyen Trai, "
    },
    {
      "roomGroup": {
        "totalPrice": "374788.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "216612174",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "216612174",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "A7D5",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "970992",
      "cover": "http://i.travelapi.com/hotels/27000000/26960000/26952400/26952386/a7eb9149_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Tay Bac Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, Tay Bac Hotel is within a 15-minute drive of Binh Tay Market and Dam Sen Water Park.  This hotel is 3 mi (4.8 km) from Dam Sen Park and …",
      "longitude": "106.6265",
      "latitude": "10.73434",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "68 SONG HANH, "
    },
    {
      "roomGroup": {
        "totalPrice": "390945.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Bed in 8-Bed Mixed Dormitory",
            "roomCode": "215713586",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 10%",
            "availability": "16",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Bed in 8-Bed Mixed Dormitory",
            "roomCode": "215713586",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 10%",
            "availability": "16",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "ACFD",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1025845",
      "cover": "http://i.travelapi.com/hotels/28000000/27170000/27169400/27169325/69d2e32c_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "WillHome Hostel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at WillHome Hostel in Ho Chi Minh City, you'll be a 4-minute walk from Saigon Culinary Arts Centre and 5 minutes by foot from Pham Ngu Lao Backpacker …",
      "longitude": "106.68583",
      "latitude": "10.76559",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "212B/D13 Nguyen Trai, "
    },
    {
      "roomGroup": {
        "totalPrice": "394617.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "1 Bed in 8 Beds, Mix Dorm",
            "roomCode": "201538545",
            "boardName": "",
            "specialOffer": "",
            "availability": "16",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "1 Bed in 8 Beds, Mix Dorm",
            "roomCode": "201538545",
            "boardName": "",
            "specialOffer": "",
            "availability": "16",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "AE29",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "596877",
      "cover": "http://i.travelapi.com/hotels/16000000/15260000/15253700/15253664/9c394fdf_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "GoCo Hostel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at GoCo Hostel places you in the heart of Ho Chi Minh City, within a 10-minute drive of Ben Thanh Market and An Dong Market.  This hostel is 1.3 mi (2.1 km) …",
      "longitude": "106.6865",
      "latitude": "10.7628",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "214/1 Nguyen Trai, "
    },
    {
      "roomGroup": {
        "totalPrice": "405633.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Bed in 8-bed Mixed Room, Women Only",
            "roomCode": "216919794",
            "boardName": "",
            "specialOffer": "Save 60%",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Bed in 8-bed Mixed Room, Women Only",
            "roomCode": "216919794",
            "boardName": "",
            "specialOffer": "Save 60%",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "B1AD",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1019851",
      "cover": "http://i.travelapi.com/hotels/28000000/27340000/27332600/27332551/4add7726_t.jpg",
      "rate": "1.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Saigon Capsule Hostel - Adults Only",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Saigon Capsule Hostel - Adults Only, you'll be centrally located in Ho Chi Minh City, steps from Taka Plaza and Takashimaya Vietnam.  This hostel is …",
      "longitude": "106.70033",
      "latitude": "10.77434",
      "promotion": "Save 60%",
      "supplierCode": "s007",
      "hotelAddress": "36 Le Loi Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "410774.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "221415687",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "10",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "221415687",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "10",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "B351",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "952455",
      "cover": "http://i.travelapi.com/hotels/26000000/25820000/25814500/25814443/9ea96d07_t.jpg",
      "rate": "1.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Nguyen Thao Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Nguyen Thao Hotel in Ho Chi Minh City (Go Vap), you'll be 4.6 mi (7.3 km) from Gia Dinh Park and 5.3 mi (8.5 km) from Parkson CT Plaza.  This hotel is …",
      "longitude": "106.64318",
      "latitude": "10.84645",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "91/2 Pham VanChieu, Phuong 14, "
    },
    {
      "roomGroup": {
        "totalPrice": "416404.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Shared Dormitory, Mixed Dorm (10 bed Mix)",
            "roomCode": "200437944",
            "boardName": "",
            "specialOffer": "",
            "availability": "9",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Shared Dormitory, Mixed Dorm (10 bed Mix)",
            "roomCode": "200437944",
            "boardName": "",
            "specialOffer": "",
            "availability": "9",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "B51D",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "445350",
      "cover": "http://i.travelapi.com/hotels/8000000/7020000/7018600/7018518/885e33d1_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Dream Station - Saigon Hostel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Dream Station - Saigon Hostel in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Pham Ngu Lao Backpacker Area and Bui Vien Walking …",
      "longitude": "106.68932",
      "latitude": "10.76625",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "200 Cong Quynh, Dist 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "416404.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "8 Bed Female Dorm",
            "roomCode": "200443526",
            "boardName": "Free Breakfast",
            "specialOffer": "",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "8 Bed Female Dorm",
            "roomCode": "200443526",
            "boardName": "Free Breakfast",
            "specialOffer": "",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "B51D",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "445416",
      "cover": "http://i.travelapi.com/hotels/8000000/7040000/7032900/7032809/d554b4db_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Saigon Backpackers Hostel @ Pham Ngu Lao",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Saigon Backpackers Hostel @ Pham Ngu Lao places you in the heart of Ho Chi Minh City, within a 10-minute drive of Museum of Fine Arts and Ben Thanh Market. …",
      "longitude": "106.68968",
      "latitude": "10.76671",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "373/20 Pham Ngu Lao, "
    },
    {
      "roomGroup": {
        "totalPrice": "431092.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "200964941",
            "boardName": "",
            "specialOffer": "Last minute deal: save 30%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "200964941",
            "boardName": "",
            "specialOffer": "Last minute deal: save 30%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "B9CD",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "503793",
      "cover": "http://i.travelapi.com/hotels/10000000/9630000/9626200/9626110/b912f6b8_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Hung Anh Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />When you stay at Hung Anh Hotel in Ho Chi Minh City, you'll be near the airport and 14 minutes by foot from Ho Chi Minh City International Exhibition and Convention …",
      "longitude": "106.64815",
      "latitude": "10.79659",
      "promotion": "Last minute deal: save 30%",
      "supplierCode": "s007",
      "hotelAddress": "35 Thep Moi Street, Ward 12, "
    },
    {
      "roomGroup": {
        "totalPrice": "440150.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Shared Dormitory, Mixed Dorm",
            "roomCode": "201993102",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 33%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Shared Dormitory, Mixed Dorm",
            "roomCode": "201993102",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 33%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "BCB1",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "699659",
      "cover": "http://i.travelapi.com/hotels/19000000/18610000/18608900/18608852/52ac00a8_t.jpg",
      "rate": "1.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "New Saigon Hostel 2",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at New Saigon Hostel 2 in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Pham Ngu Lao Backpacker Area and 5 minutes by foot from Bui …",
      "longitude": "106.68968",
      "latitude": "10.76672",
      "promotion": "Private sale: save 33%",
      "supplierCode": "s007",
      "hotelAddress": "373/16 Pham Ngu Lao Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "444801.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room, Shared Bathroom",
            "roomCode": "218103617",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room, Shared Bathroom",
            "roomCode": "218103617",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "BE2D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "871797",
      "cover": "http://i.travelapi.com/hotels/24000000/23280000/23279400/23279317/a0c9a7de_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Welcome Home Homestay - Hostel",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, Welcome Home Homestay - Hostel is within a 10-minute drive of Museum of Fine Arts and Ben Thanh Market.  This hostel is 1.5 mi (2.5 km) …",
      "longitude": "106.68908",
      "latitude": "10.75872",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "TK 29/23 Nguyen Canh Chan street, "
    },
    {
      "roomGroup": {
        "totalPrice": "450676.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Bed in Mixed Dorm Room",
            "roomCode": "220211662",
            "boardName": "",
            "specialOffer": "Save 40%",
            "availability": "8",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Bed in Mixed Dorm Room",
            "roomCode": "220211662",
            "boardName": "",
            "specialOffer": "Save 40%",
            "availability": "8",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "C00D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "910308",
      "cover": "http://i.travelapi.com/hotels/25000000/24170000/24161700/24161643/242bef77_t.jpg",
      "rate": "1.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "JoJo Dorm Homestay - Hostel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at JoJo Dorm Homestay - Hostel in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Ben Thanh Market and Benthanh Street Food Market.  …",
      "longitude": "106.69721",
      "latitude": "10.77247",
      "promotion": "Save 40%",
      "supplierCode": "s007",
      "hotelAddress": "37 Phan Chu Trinh, "
    },
    {
      "roomGroup": {
        "totalPrice": "451900.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Bunk Bed in 12 Beds Mixed Dormitory Room",
            "roomCode": "215708323",
            "boardName": "",
            "specialOffer": "Member’s price: 45%",
            "availability": "6",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Bunk Bed in 12 Beds Mixed Dormitory Room",
            "roomCode": "215708323",
            "boardName": "",
            "specialOffer": "Member’s price: 45%",
            "availability": "6",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "C071",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "918784",
      "cover": "http://i.travelapi.com/hotels/25000000/24330000/24327800/24327715/bf0583c0_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "9 Hostel and Bar",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at 9 Hostel and Bar in Ho Chi Minh City (Bui Thi Xuan), you'll be within a 15-minute walk of Bui Vien Walking Street and Ben Thanh Market.  This hostel …",
      "longitude": "106.69082",
      "latitude": "10.77206",
      "promotion": "Member’s price: 45%",
      "supplierCode": "s007",
      "hotelAddress": "9 Bui Thi Xuan, "
    },
    {
      "roomGroup": {
        "totalPrice": "455817.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Bed in 16-Bed Mixed Dorm",
            "roomCode": "215104080",
            "boardName": "Free Breakfast",
            "specialOffer": "",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Bed in 16-Bed Mixed Dorm",
            "roomCode": "215104080",
            "boardName": "Free Breakfast",
            "specialOffer": "",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "C1B1",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "889728",
      "cover": "http://i.travelapi.com/hotels/24000000/23650000/23648600/23648531/929af661_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Hangout Hostel HCM",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Hangout Hostel HCM places you in the heart of Ho Chi Minh City, within a 10-minute drive of Bui Vien Walking Street and Museum of Fine Arts.  This hostel …",
      "longitude": "106.68963",
      "latitude": "10.76708",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "361A Pham Ngu Lao Street, District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "456552.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Bed in 14-Bed in Female Dormitory",
            "roomCode": "218422884",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Bed in 14-Bed in Female Dormitory",
            "roomCode": "218422884",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": false,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "C1ED",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1022531",
      "cover": "http://i.travelapi.com/hotels/28000000/27330000/27329800/27329755/17bf8889_t.jpg",
      "rate": "1.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Sakura Cholon Hostel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Sakura Cholon Hostel in Ho Chi Minh City, you'll be a 3-minute walk from Cho Quan Church and 14 minutes by foot from Saigon Culinary Arts Centre.  …",
      "longitude": "106.68001",
      "latitude": "10.75851",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "60/11 Nguyen Trai Quan 5, "
    },
    {
      "roomGroup": {
        "totalPrice": "466099.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Bed in 12 Beds Dorm Room",
            "roomCode": "202102267",
            "boardName": "",
            "specialOffer": "Private sale: save 4%",
            "availability": "12",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Bed in 12 Beds Dorm Room",
            "roomCode": "202102267",
            "boardName": "",
            "specialOffer": "Private sale: save 4%",
            "availability": "12",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "C4F9",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "723865",
      "cover": "http://i.travelapi.com/hotels/20000000/19410000/19408100/19408036/21fe2097_t.jpg",
      "rate": "1.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "The Luci's House - Hostel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at The Luci's House - Hostel places you in the heart of Ho Chi Minh City, steps from September 23 Park and 4 minutes by foot from Zen Plaza.  This hostel is …",
      "longitude": "106.69109",
      "latitude": "10.76928",
      "promotion": "Private sale: save 4%",
      "supplierCode": "s007",
      "hotelAddress": "174/4 Le Lai Street, Quan 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "469036.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room (Type A2)",
            "roomCode": "201261987",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room (Type A2)",
            "roomCode": "201261987",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "C5E9",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "546640",
      "cover": "http://i.travelapi.com/hotels/13000000/12330000/12328700/12328679/12328679_5_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Hoa Bao 2 Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Hoa Bao 2 Hotel in Ho Chi Minh City (Go Vap), you'll be 14 minutes by car from Gia Dinh Park.  This hotel is 4.3 mi (6.9 km) from Parkson CT Plaza and …",
      "longitude": "106.66495",
      "latitude": "10.84968",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "393 Thong Nhat Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "470750.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Shared Dormitory (8 beds) (2018 Offer - Free Walking City Tour (On Request))",
            "roomCode": "202091961",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 7%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Shared Dormitory (8 beds) (2018 Offer - Free Walking City Tour (On Request))",
            "roomCode": "202091961",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 7%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": false,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "C675",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "722085",
      "cover": "http://i.travelapi.com/hotels/20000000/19380000/19370700/19370644/3e50055e_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Lala Hostel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Lala Hostel in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Pham Ngu Lao Backpacker Area and 5 minutes by foot from Bui Vien …",
      "longitude": "106.68992",
      "latitude": "10.76657",
      "promotion": "Private sale: save 7%",
      "supplierCode": "s007",
      "hotelAddress": "373/30 Pham Ngu Lao Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "479318.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room, 1 Queen Bed",
            "roomCode": "219904740",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room, 1 Queen Bed",
            "roomCode": "219904740",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "C931",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "853986",
      "cover": "http://i.travelapi.com/hotels/24000000/23040000/23038500/23038413/c50520de_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Kim Long Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Kim Long Hotel in Ho Chi Minh City (Phu Nhuan), you'll be a 5-minute drive from Hoang Van Thu Park and 8 minutes from Parkson CT Plaza.  This hotel is …",
      "longitude": "106.6762",
      "latitude": "10.80277",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "43D/3 Ho Van Hue, "
    },
    {
      "roomGroup": {
        "totalPrice": "479808.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "1 bed in 8 beds Mixed Dorm",
            "roomCode": "201142876",
            "boardName": "Free Breakfast",
            "specialOffer": "Member’s price: 50%",
            "availability": "10",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "1 bed in 8 beds Mixed Dorm",
            "roomCode": "201142876",
            "boardName": "Free Breakfast",
            "specialOffer": "Member’s price: 50%",
            "availability": "10",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "C959",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "529977",
      "cover": "http://i.travelapi.com/hotels/12000000/11470000/11464000/11463968/46c22f99_t.jpg",
      "rate": "1.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Vintage Hostel Saigon",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Vintage Hostel Saigon places you in the heart of Ho Chi Minh City, steps from Bui Vien Walking Street and Pham Ngu Lao Backpacker Area.  This hostel is 0.6 …",
      "longitude": "106.69347",
      "latitude": "10.76717",
      "promotion": "Member’s price: 50%",
      "supplierCode": "s007",
      "hotelAddress": "80 Bui Vien Street, District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "481766.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Shared Dormitory, City View",
            "roomCode": "201892252",
            "boardName": "Free Breakfast",
            "specialOffer": "Limited time offer:  save 30%",
            "availability": "8",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Shared Dormitory, City View",
            "roomCode": "201892252",
            "boardName": "Free Breakfast",
            "specialOffer": "Limited time offer:  save 30%",
            "availability": "8",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "C9F9",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "678436",
      "cover": "http://i.travelapi.com/hotels/18000000/17830000/17825100/17825100/43c6fac8_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Saigon Marvel Hostel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Saigon Marvel Hostel places you in the heart of Ho Chi Minh City, steps from Pham Ngu Lao Backpacker Area and Bui Vien Walking Street.  This hostel is 0.5 …",
      "longitude": "106.69071",
      "latitude": "10.76656",
      "promotion": "Limited time offer:  save 30%",
      "supplierCode": "s007",
      "hotelAddress": "47 Do Quang Dau Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "488865.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "221723298",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "221723298",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "CC3D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1026695",
      "cover": "http://i.travelapi.com/hotels/29000000/28940000/28938500/28938423/a77e3ee2_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Hoang Dung Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, Hoang Dung Hotel is minutes from Gia Dinh Park and close to Parkson CT Plaza.  This hotel is within close proximity of Vietnam People's …",
      "longitude": "106.67181",
      "latitude": "10.81473",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "63 Bach Dang street, Tan Binh Ward, "
    },
    {
      "roomGroup": {
        "totalPrice": "488865.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room (Type 2)",
            "roomCode": "200835064",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room (Type 2)",
            "roomCode": "200835064",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "CC3D",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "481702",
      "cover": "http://i.travelapi.com/hotels/10000000/9480000/9477900/9477830/23765d91_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Hoa Bao Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Hoa Bao Hotel in Ho Chi Minh City (Go Vap), you'll be within a 15-minute drive of Gia Dinh Park and Parkson CT Plaza.  This hotel is 3.3 mi (5.3 km) …",
      "longitude": "106.68673",
      "latitude": "10.83169",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "6C Duong Quang Ham street, Ward 5, "
    },
    {
      "roomGroup": {
        "totalPrice": "488865.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Studio",
            "roomCode": "221718442",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Studio",
            "roomCode": "221718442",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "CC3D",
        "contractName": ""
      },
      "destinationCode": "TSN",
      "hotelId": "980465",
      "cover": "http://i.travelapi.com/hotels/28000000/27080000/27072700/27072698/5fb92664_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Linh Homes for Expat",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Linh Homes for Expat in Ho Chi Minh City, you'll be within a 15-minute walk of Ear Nose Throat Hospital and Southern Vietnam Women Museum.  This …",
      "longitude": "106.688",
      "latitude": "10.79022",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "28/1 Nguyen Van Mai, "
    },
    {
      "roomGroup": {
        "totalPrice": "490334.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Basic Shared Dormitory, Mixed Dorm",
            "roomCode": "221724708",
            "boardName": "Free Breakfast",
            "specialOffer": "Save 44%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Basic Shared Dormitory, Mixed Dorm",
            "roomCode": "221724708",
            "boardName": "Free Breakfast",
            "specialOffer": "Save 44%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "CCB5",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "1034871",
      "cover": "http://i.travelapi.com/hotels/30000000/29310000/29307000/29306903/8fe71128_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Himalaya Phoenix Saigon Hostel",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City (Downtown Ho Chi Minh City), Himalaya Phoenix Saigon Hostel is minutes from Zen Plaza and September 23 Park.  This hostel is within close …",
      "longitude": "106.69306",
      "latitude": "10.77081",
      "promotion": "Save 44%",
      "supplierCode": "s007",
      "hotelAddress": "7/12 Nguyen Trai Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "497923.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "201883551",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "201883551",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": false,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "CF21",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "676173",
      "cover": "http://i.travelapi.com/hotels/18000000/17780000/17774700/17774606/e176d3dd_t.jpg",
      "rate": "1.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Vinabooker Cong Quynh",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Vinabooker Cong Quynh in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be a 3-minute walk from Pham Ngu Lao Backpacker Area and 7 minutes by …",
      "longitude": "106.68588",
      "latitude": "10.7677",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "304, Block A4, 189B Cong Quynh St., "
    },
    {
      "roomGroup": {
        "totalPrice": "505267.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "202138451",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "202138451",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": false,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "D179",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "736205",
      "cover": "http://i.travelapi.com/hotels/20000000/19710000/19701000/19700945/12e0f4b6_t.jpg",
      "rate": "1.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "An Nam Corner - Bui Vien",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at An Nam Corner - Bui Vien places you in the heart of Ho Chi Minh City, steps from Pham Ngu Lao Backpacker Area and Bui Vien Walking Street.  This hostel is …",
      "longitude": "106.69143",
      "latitude": "10.7657",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "183/58 Bui Vien Street, District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "520689.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Comfort Shared Dormitory, Mixed Dorm",
            "roomCode": "200504214",
            "boardName": "Full Breakfast",
            "specialOffer": "Tonight only: save 31%",
            "availability": "6",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Comfort Shared Dormitory, Mixed Dorm",
            "roomCode": "200504214",
            "boardName": "Full Breakfast",
            "specialOffer": "Tonight only: save 31%",
            "availability": "6",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "D665",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "448272",
      "cover": "http://i.travelapi.com/hotels/8000000/7340000/7339200/7339142/f629379f_t.jpg",
      "rate": "0.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Suite Backpackers Inn",
      "hotelDescription": "<p><b>Property Location</b> <br />Suite Backpackers Inn is centrally located in Ho Chi Minh City, a 1-minute walk from Bui Vien Walking Street and 11 minutes by foot from Ben Thanh Market.  This …",
      "longitude": "106.69397",
      "latitude": "10.7674",
      "promotion": "Tonight only: save 31%",
      "supplierCode": "s007",
      "hotelAddress": "230 De Tham Street, District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "521424.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "220519687",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "6",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "220519687",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "6",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "D6A1",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1001394",
      "cover": "http://i.travelapi.com/hotels/28000000/27210000/27200300/27200256/6d500dd5_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Bin Bin Hotel 1",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Bin Bin Hotel 1 in Ho Chi Minh City, you'll be within a 10-minute drive of The Cresent Mall and SC VivoCity.  This hotel is 2.3 mi (3.6 km) from …",
      "longitude": "106.69659",
      "latitude": "10.72741",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "No. 02, Street 01, "
    },
    {
      "roomGroup": {
        "totalPrice": "527299.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room, 1 Queen Bed, Refrigerator & Microwave, City View",
            "roomCode": "216907405",
            "boardName": "",
            "specialOffer": "Special deal: save 50%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room, 1 Queen Bed, Refrigerator & Microwave, City View",
            "roomCode": "216907405",
            "boardName": "",
            "specialOffer": "Special deal: save 50%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "D881",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "912455",
      "cover": "http://i.travelapi.com/hotels/25000000/24210000/24202200/24202132/eb4c5aa7_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Starlight Guesthouse",
      "hotelDescription": "<p><b>Property Location</b> <br />When you stay at Starlight Guesthouse in Ho Chi Minh City, you'll be within a 10-minute drive of Phu My Bridge and FV Hospital.  This guesthouse is 2 mi (3.3 km) …",
      "longitude": "106.72867",
      "latitude": "10.74705",
      "promotion": "Special deal: save 50%",
      "supplierCode": "s007",
      "hotelAddress": "388/11A Huynh Tan Phat, "
    },
    {
      "roomGroup": {
        "totalPrice": "529502.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "200125405",
            "boardName": "Free Breakfast",
            "specialOffer": "Member’s price: 75%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "200125405",
            "boardName": "Free Breakfast",
            "specialOffer": "Member’s price: 75%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "D935",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "396567",
      "cover": "http://i.travelapi.com/hotels/5000000/4740000/4735800/4735716/5528ab06_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Ava 3 Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Ava 3 Hotel, you'll be centrally located in Ho Chi Minh City, just a 4-minute walk from Bui Vien Walking Street and 5 minutes by foot from Pham Ngu …",
      "longitude": "106.69494",
      "latitude": "10.7649",
      "promotion": "Member’s price: 75%",
      "supplierCode": "s007",
      "hotelAddress": "137 De Tham St, Dist 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "532440.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "1 Bed in 6 Beds Female Dormitory",
            "roomCode": "219920031",
            "boardName": "",
            "specialOffer": "Tonight only: save 30%",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "1 Bed in 6 Beds Female Dormitory",
            "roomCode": "219920031",
            "boardName": "",
            "specialOffer": "Tonight only: save 30%",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "DA25",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1012119",
      "cover": "http://i.travelapi.com/hotels/28000000/27370000/27365900/27365864/36b5a570_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "6feet Hostel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at 6feet Hostel in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be within a 5-minute drive of Pham Ngu Lao Backpacker Area and Saigon Culinary …",
      "longitude": "106.6872",
      "latitude": "10.76589",
      "promotion": "Tonight only: save 30%",
      "supplierCode": "s007",
      "hotelAddress": "212A3/14 Nguyen Trai, "
    },
    {
      "roomGroup": {
        "totalPrice": "537580.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "220220984",
            "boardName": "",
            "specialOffer": "Seasonal deal: save 10%",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "220220984",
            "boardName": "",
            "specialOffer": "Seasonal deal: save 10%",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "DBC9",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1025010",
      "cover": "http://i.travelapi.com/hotels/28000000/27550000/27546700/27546661/0bb23069_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Ha My Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City (Linh Trung IEPZ), Ha My Hotel is within the region of Opera House and War Remnants Museum.  This hotel is within the region of Saigon …",
      "longitude": "106.76626",
      "latitude": "10.85926",
      "promotion": "Seasonal deal: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "32 duong so 6, phuong, Linh Trung, "
    },
    {
      "roomGroup": {
        "totalPrice": "543211.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "201041293",
            "boardName": "",
            "specialOffer": "",
            "availability": "7",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "201041293",
            "boardName": "",
            "specialOffer": "",
            "availability": "7",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "DD95",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "503544",
      "cover": "http://i.travelapi.com/hotels/10000000/9630000/9625500/9625460/9625460_35_t.jpg",
      "rate": "1.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Hoa Dong Duong Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Hoa Dong Duong Hotel in Ho Chi Minh City (Phu Nhuan), you'll be within a 10-minute drive of Hoang Van Thu Park and Gia Dinh Park.  This hotel is 1.3 …",
      "longitude": "106.677",
      "latitude": "10.7994",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "122-124 Hoang Van Thu Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "543211.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "202198612",
            "boardName": "",
            "specialOffer": "Member’s price: 40%",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "202198612",
            "boardName": "",
            "specialOffer": "Member’s price: 40%",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": false,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "DD95",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "755193",
      "cover": "http://i.travelapi.com/hotels/21000000/20100000/20096500/20096417/429b4c76_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Mekong Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />When you stay at Mekong Hotel in Ho Chi Minh City, you'll be 8 minutes by car from Quang Trung Software City.  This hotel is 4.7 mi (7.5 km) from Ho Chi Minh City …",
      "longitude": "106.61149",
      "latitude": "10.83054",
      "promotion": "Member’s price: 40%",
      "supplierCode": "s007",
      "hotelAddress": "53/1 Phan Van Hon, Tan Thoi Nhat 8, "
    },
    {
      "roomGroup": {
        "totalPrice": "543211.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double Room",
            "roomCode": "202135462",
            "boardName": "",
            "specialOffer": "",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double Room",
            "roomCode": "202135462",
            "boardName": "",
            "specialOffer": "",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "DD95",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "735979",
      "cover": "http://i.travelapi.com/hotels/20000000/19710000/19700600/19700560/a8b8e4fc_t.jpg",
      "rate": "1.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "GoWhere AirPort Homestay",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, GoWhere AirPort Homestay is within a 10-minute drive of Hoang Van Thu Park and Ho Chi Minh City International Exhibition and Convention …",
      "longitude": "106.63946",
      "latitude": "10.8027",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "554/14 Cong Hoa, Ward 13, "
    },
    {
      "roomGroup": {
        "totalPrice": "550310.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room, No Windows",
            "roomCode": "201683914",
            "boardName": "",
            "specialOffer": "Member’s price: 60%",
            "availability": "8",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room, No Windows",
            "roomCode": "201683914",
            "boardName": "",
            "specialOffer": "Member’s price: 60%",
            "availability": "8",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "DFD9",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "626877",
      "cover": "http://i.travelapi.com/hotels/17000000/16180000/16174400/16174308/56577e24_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "You And Me Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, You And Me Hotel is within a 15-minute drive of SC VivoCity and FV Hospital.  This hotel is 3.3 mi (5.3 km) from The Cresent Mall and …",
      "longitude": "106.69067",
      "latitude": "10.73479",
      "promotion": "Member’s price: 60%",
      "supplierCode": "s007",
      "hotelAddress": "27-29, 5B Street, Trung Son R.A., "
    },
    {
      "roomGroup": {
        "totalPrice": "553737.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "202225728",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "10",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "202225728",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "10",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "E0F1",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "758005",
      "cover": "http://i.travelapi.com/hotels/21000000/20150000/20146200/20146108/bfbbe380_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Binh Dung Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Binh Dung Hotel in Ho Chi Minh City (Phu Nhuan), you'll be within a 15-minute drive of Jade Emperor Pagoda and Southern Vietnam Women Museum.  This …",
      "longitude": "106.68946",
      "latitude": "10.7983",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "88 Hoa Cuc ,Quan Phu Nhuan, "
    },
    {
      "roomGroup": {
        "totalPrice": "563774.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Room",
            "roomCode": "214503558",
            "boardName": "",
            "specialOffer": "",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Room",
            "roomCode": "214503558",
            "boardName": "",
            "specialOffer": "",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "E425",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "901177",
      "cover": "http://i.travelapi.com/hotels/25000000/24010000/24006400/24006365/ab520cfd_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Anh Quoc Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Anh Quoc Hotel in Ho Chi Minh City, you'll be 3.9 mi (6.2 km) from Dam Sen Water Park and 4.6 mi (7.4 km) from War Remnants Museum.  This hotel is 5.2 …",
      "longitude": "106.63927",
      "latitude": "10.8029",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "564 cong hoa phuong 13 tan binh, "
    },
    {
      "roomGroup": {
        "totalPrice": "564019.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Basic Double Room, 1 Double Bed",
            "roomCode": "221727172",
            "boardName": "",
            "specialOffer": "Tonight only: save 65%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Basic Double Room, 1 Double Bed",
            "roomCode": "221727172",
            "boardName": "",
            "specialOffer": "Tonight only: save 65%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "E439",
        "contractName": ""
      },
      "destinationCode": "TSN",
      "hotelId": "760172",
      "cover": "http://i.travelapi.com/hotels/21000000/20190000/20189000/20188996/c4bd9e74_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Anh Sao Xanh Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Anh Sao Xanh Hotel in Ho Chi Minh City (Tan Phu District), you'll be within a 10-minute drive of Dam Sen Park and Dam Sen Water Park.  This hotel is …",
      "longitude": "106.62853",
      "latitude": "10.77381",
      "promotion": "Tonight only: save 65%",
      "supplierCode": "s007",
      "hotelAddress": "202/18 To Hieu Street, Tan Phu district, "
    },
    {
      "roomGroup": {
        "totalPrice": "570628.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "201908266",
            "boardName": "",
            "specialOffer": "Book now and save!",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "201908266",
            "boardName": "",
            "specialOffer": "Book now and save!",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "E655",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "680152",
      "cover": "http://i.travelapi.com/hotels/18000000/17900000/17894300/17894217/7fafa971_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Hotel Kim Yen",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Hotel Kim Yen in Ho Chi Minh City (Phu Nhuan), you'll be within a 10-minute drive of Hoang Van Thu Park and Southern Vietnam Women Museum.  This hotel …",
      "longitude": "106.67801",
      "latitude": "10.79738",
      "promotion": "Book now and save!",
      "supplierCode": "s007",
      "hotelAddress": "so 1 Dang Dung, Phuong Tan Dinh, Quan 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "570628.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room",
            "roomCode": "218116090",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room",
            "roomCode": "218116090",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "E655",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "965852",
      "cover": "http://i.travelapi.com/hotels/27000000/26780000/26776300/26776267/1c004156_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "95 Lam Son Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at 95 Lam Son Hotel in Ho Chi Minh City, you'll be near the airport, just a 3-minute walk from Parkson CT Plaza and 12 minutes by foot from Gia Dinh …",
      "longitude": "106.667",
      "latitude": "10.81289",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "95 Lam Son, Ward 2, Tan Binh District, "
    },
    {
      "roomGroup": {
        "totalPrice": "573076.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "217825251",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "35",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "217825251",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "35",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "E71D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1033967",
      "cover": "http://i.travelapi.com/hotels/30000000/29470000/29464100/29464048/12804bb9_t.jpg",
      "rate": "3.0",
      "destinationName": "Thu Dau Mot",
      "hotelName": "Tran Long Binh Duong Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />When you stay at Tran Long Binh Duong Hotel in Thu Dau Mot, you'll be within the region of Royal Island Golf.</p><p><b>Rooms</b> <br />Make yourself at home in one …",
      "longitude": "106.68293",
      "latitude": "11.0719",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "K07 Unitown Area, Hoa Phu Ward, "
    },
    {
      "roomGroup": {
        "totalPrice": "575035.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room",
            "roomCode": "217213321",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "12",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room",
            "roomCode": "217213321",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "12",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "E7BD",
        "contractName": ""
      },
      "destinationCode": "TSN",
      "hotelId": "1032988",
      "cover": "http://i.travelapi.com/hotels/28000000/27170000/27168800/27168703/5a508d11_t.jpg",
      "rate": "1.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Anh Ha Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Anh Ha Hotel in Ho Chi Minh City (Phu Nhuan), you'll be convenient to Hoang Van Thu Park and Gia Dinh Park.  This hotel is within close proximity of …",
      "longitude": "106.67729",
      "latitude": "10.79952",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "106hoang van thu phuong 9 quan phu nhuan, "
    },
    {
      "roomGroup": {
        "totalPrice": "576259.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "210004126",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "210004126",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "E821",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "893930",
      "cover": "http://i.travelapi.com/hotels/24000000/23780000/23775900/23775802/7015f5ab_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Ha Long Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Ha Long Hotel in Ho Chi Minh City (Linh Trung IEPZ), you'll be 8 minutes by car from Suoi Tien Amusement Park.  This hotel is 5.7 mi (9.2 km) from …",
      "longitude": "106.78147",
      "latitude": "10.86452",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "76/2K Le Van Chi Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "579196.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room",
            "roomCode": "202441669",
            "boardName": "",
            "specialOffer": "",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room",
            "roomCode": "202441669",
            "boardName": "",
            "specialOffer": "",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "E911",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "815033",
      "cover": "http://i.travelapi.com/hotels/23000000/22250000/22242800/22242795/8d9fc592_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Thanh Lan Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />When you stay at Thanh Lan Hotel in Ho Chi Minh City, you'll be within a 10-minute drive of Thong Nhat Stadium and An Dong Market.  This hotel is 1.2 mi (2 km) from …",
      "longitude": "106.66742",
      "latitude": "10.75255",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "51Tran Xuan Hoa Phuong 7 Quan 5, "
    },
    {
      "roomGroup": {
        "totalPrice": "579196.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room (2 guests)",
            "roomCode": "201627683",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room (2 guests)",
            "roomCode": "201627683",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "E911",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "617566",
      "cover": "http://i.travelapi.com/hotels/16000000/15870000/15860100/15860006/af131968_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Sao Mai Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Sao Mai Hotel in Ho Chi Minh City (Chinatown), you'll be within a 10-minute drive of Thong Nhat Stadium and Binh Tay Market.  This hotel is 1.6 mi …",
      "longitude": "106.65556",
      "latitude": "10.75284",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "896 Nguyen Trai, "
    },
    {
      "roomGroup": {
        "totalPrice": "586785.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "200667442",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "200667442",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "EB7D",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "456117",
      "cover": "http://i.travelapi.com/hotels/9000000/8080000/8072200/8072136/8072136_61_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Thanh Hong Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, Thanh Hong Hotel is a 3-minute drive from Ho Chi Minh City International Exhibition and Convention Centre and 7 minutes from Hoang Van …",
      "longitude": "106.65504",
      "latitude": "10.79687",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "64/19 Xuan Dieu Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "586785.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "201836399",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "201836399",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "EB7D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "663771",
      "cover": "http://i.travelapi.com/hotels/18000000/17400000/17399000/17398973/244a24ee_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Atana Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />When you stay at Atana Hotel in Ho Chi Minh City, you'll be 9 minutes by car from Quang Trung Software City.  This hotel is 4.8 mi (7.7 km) from Ho Chi Minh City …",
      "longitude": "106.60968",
      "latitude": "10.83249",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "327 Phan Van Hon, Tan Thoi Nhat Ward, "
    },
    {
      "roomGroup": {
        "totalPrice": "586785.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "220225371",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "9",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "220225371",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "9",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "EB7D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1036737",
      "cover": "http://i.travelapi.com/hotels/30000000/29470000/29465100/29465067/0a4a5047_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Tran Long 2 Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Tran Long 2 Hotel in Ho Chi Minh City (Go Vap), you'll be close to Gia Dinh Park and Parkson CT Plaza.  This hotel is within close proximity of Van …",
      "longitude": "106.69591",
      "latitude": "10.82599",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "1/16 Street 06, Ward 05, Go Vap, "
    },
    {
      "roomGroup": {
        "totalPrice": "588254.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double City View",
            "roomCode": "200670884",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double City View",
            "roomCode": "200670884",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "EBF5",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "456587",
      "cover": "http://i.travelapi.com/hotels/9000000/8100000/8091600/8091582/8091582_35_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Mai Phuong Thao Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />When you stay at Mai Phuong Thao Hotel in Ho Chi Minh City, you'll be 5 minutes by car from Quang Trung Software City.  This hotel is 5.3 mi (8.6 km) from Ho Chi …",
      "longitude": "106.61797",
      "latitude": "10.83855",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "614 Truong Chinh, "
    },
    {
      "roomGroup": {
        "totalPrice": "593884.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Shared Dormitory, Mixed Dorm (8 beds)",
            "roomCode": "200840462",
            "boardName": "Free Breakfast",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Shared Dormitory, Mixed Dorm (8 beds)",
            "roomCode": "200840462",
            "boardName": "Free Breakfast",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "EDC1",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "481827",
      "cover": "http://i.travelapi.com/hotels/10000000/9490000/9482500/9482442/4d7f8216_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Khoi Hostel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Khoi Hostel places you in the heart of Ho Chi Minh City, steps from Pham Ngu Lao Backpacker Area and 4 minutes by foot from Bui Vien Walking Street.  This …",
      "longitude": "106.68958",
      "latitude": "10.76676",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "373/11 Pham Ngu Lao St, Dist 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "594864.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "202200325",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "202200325",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "EE11",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "751911",
      "cover": "http://i.travelapi.com/hotels/21000000/20060000/20058500/20058454/7f8693a3_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Ba Dat Homestay Q6",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City (Korean Industrial Zone), Ba Dat Homestay Q6 is within a 5-minute drive of Dam Sen Water Park and Dam Sen Park.  This guesthouse is 2.1 …",
      "longitude": "106.63381",
      "latitude": "10.757",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "68b/13 Dang Nguyen Can, "
    },
    {
      "roomGroup": {
        "totalPrice": "621302.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "8 Beds Share Mixed Room (Floor 1)",
            "roomCode": "202082543",
            "boardName": "",
            "specialOffer": "Tonight only: save 17%",
            "availability": "8",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "8 Beds Share Mixed Room (Floor 1)",
            "roomCode": "202082543",
            "boardName": "",
            "specialOffer": "Tonight only: save 17%",
            "availability": "8",
            "boardCode": ""
          }
        ],
        "nonRefundable": false,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "F681",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "720791",
      "cover": "http://i.travelapi.com/hotels/20000000/19330000/19328900/19328811/6f460dd6_t.jpg",
      "rate": "1.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "S Phuot Coffee & Homestay",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at S Phuot Coffee & Homestay in Ho Chi Minh City (Go Vap), you'll be a 3-minute drive from Gia Dinh Park and 12 minutes from Vinh Nghiem Pagoda.  This …",
      "longitude": "106.67852",
      "latitude": "10.82082",
      "promotion": "Tonight only: save 17%",
      "supplierCode": "s007",
      "hotelAddress": "891/9 Nguyen Kiem, "
    },
    {
      "roomGroup": {
        "totalPrice": "635500.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "202313872",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "8",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "202313872",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "8",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "FB09",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "787838",
      "cover": "http://i.travelapi.com/hotels/22000000/21310000/21303300/21303215/1148a5b4_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Khang An hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Khang An hotel in Ho Chi Minh City (An Phu), you'll be within a 15-minute drive of Snow Town Saigon and FV Hospital.  This hotel is 4.8 mi (7.7 km) …",
      "longitude": "106.77078",
      "latitude": "10.77223",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "6 Pham Cong Tru St, Thanh My Loi Ward, "
    },
    {
      "roomGroup": {
        "totalPrice": "641865.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room, 1 Double Bed, Bathtub",
            "roomCode": "214503955",
            "boardName": "",
            "specialOffer": "",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room, 1 Double Bed, Bathtub",
            "roomCode": "214503955",
            "boardName": "",
            "specialOffer": "",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "FD11",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "906076",
      "cover": "http://i.travelapi.com/hotels/25000000/24090000/24085400/24085399/d760cd3b_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Phung Hoang Gold Palace",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Phung Hoang Gold Palace in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Bui Vien Walking Street and Pham Ngu Lao Backpacker …",
      "longitude": "106.69273",
      "latitude": "10.76679",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "97 BUI VIEN, "
    },
    {
      "roomGroup": {
        "totalPrice": "651657.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "217219168",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "15",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "217219168",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "15",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "10031",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1033152",
      "cover": "http://i.travelapi.com/hotels/30000000/29470000/29463300/29463252/48524484_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Tran Long Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Tran Long Hotel in Ho Chi Minh City (Go Vap), you'll be minutes from Gia Dinh Park and close to Parkson CT Plaza.  This hotel is within close …",
      "longitude": "106.67621",
      "latitude": "10.81528",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "31, Street 7, Ward 17, Go Vap, "
    },
    {
      "roomGroup": {
        "totalPrice": "657777.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double or Twin Room",
            "roomCode": "201744734",
            "boardName": "",
            "specialOffer": "Last minute deal: save 65%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double or Twin Room",
            "roomCode": "201744734",
            "boardName": "",
            "specialOffer": "Last minute deal: save 65%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "10225",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "642894",
      "cover": "http://i.travelapi.com/hotels/17000000/16530000/16529200/16529184/a6225262_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Ha Trang Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Ha Trang Hotel in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Pham Ngu Lao Backpacker Area and 3 minutes by foot from Bui Vien …",
      "longitude": "106.69405",
      "latitude": "10.77012",
      "promotion": "Last minute deal: save 65%",
      "supplierCode": "s007",
      "hotelAddress": "90 Le Lai Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "664387.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Studio",
            "roomCode": "219312357",
            "boardName": "Free Breakfast",
            "specialOffer": "Save 40%",
            "availability": "9",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Studio",
            "roomCode": "219312357",
            "boardName": "Free Breakfast",
            "specialOffer": "Save 40%",
            "availability": "9",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "10441",
        "contractName": ""
      },
      "destinationCode": "TSN",
      "hotelId": "916165",
      "cover": "http://i.travelapi.com/hotels/25000000/24290000/24284200/24284109/9670e604_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Blue Sapphire Hotel & Apartment",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Blue Sapphire Hotel & Apartment in Ho Chi Minh City, you'll be convenient to Museum of Fine Arts and Ben Thanh Market.  This aparthotel is within …",
      "longitude": "106.68588",
      "latitude": "10.75729",
      "promotion": "Save 40%",
      "supplierCode": "s007",
      "hotelAddress": "304 Tran Hung Dao, Nguyen Cu Trinh Ward, "
    },
    {
      "roomGroup": {
        "totalPrice": "670017.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room",
            "roomCode": "201116576",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room",
            "roomCode": "201116576",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1060D",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "503978",
      "cover": "http://i.travelapi.com/hotels/10000000/9630000/9626900/9626828/abee5c7d_t.jpg",
      "rate": "1.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Hoa Thinh Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Hoa Thinh Hotel in Ho Chi Minh City (Tan Phu District), you'll be within a 15-minute drive of Hoang Van Thu Park and Ho Chi Minh City International …",
      "longitude": "106.63261",
      "latitude": "10.80773",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "20/72 Ho Dac Di, Phuong Tay Thanh, "
    },
    {
      "roomGroup": {
        "totalPrice": "670017.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Mixed Dormitory Room",
            "roomCode": "202159217",
            "boardName": "",
            "specialOffer": "",
            "availability": "20",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Mixed Dormitory Room",
            "roomCode": "202159217",
            "boardName": "",
            "specialOffer": "",
            "availability": "20",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1060D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "743172",
      "cover": "http://i.travelapi.com/hotels/20000000/19840000/19839100/19839093/d028e1eb_t.jpg",
      "rate": "1.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Saigon Fantastic Hostel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Saigon Fantastic Hostel in Ho Chi Minh City, you'll be a 5-minute walk from Museum of Fine Arts and 6 minutes by foot from Saigon River.  This hostel …",
      "longitude": "106.69903",
      "latitude": "10.76736",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "165/72 Nguyen Thai Binh street, "
    },
    {
      "roomGroup": {
        "totalPrice": "670996.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "202441684",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "202441684",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1065D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "812008",
      "cover": "http://i.travelapi.com/hotels/23000000/22180000/22171800/22171763/8977ee2f_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "New Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, New Hotel  is within a 15-minute drive of FV Hospital and Saigon Paragon Mall.  This hotel is 1.9 mi (3.1 km) from Saigon Exhibition and …",
      "longitude": "106.71665",
      "latitude": "10.74937",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "23M Duong 9M, "
    },
    {
      "roomGroup": {
        "totalPrice": "670996.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Shared Dormitory, Mixed Dorm, City View",
            "roomCode": "201403748",
            "boardName": "Continental Breakfast",
            "specialOffer": "Private sale: save 4%",
            "availability": "14",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Shared Dormitory, Mixed Dorm, City View",
            "roomCode": "201403748",
            "boardName": "Continental Breakfast",
            "specialOffer": "Private sale: save 4%",
            "availability": "14",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1065D",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "568117",
      "cover": "http://i.travelapi.com/hotels/14000000/13330000/13321700/13321674/a87519fa_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Vitamin Smiles Hostel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Vitamin Smiles Hostel, you'll be centrally located in Ho Chi Minh City, just a 4-minute walk from Bui Vien Walking Street and 5 minutes by foot from …",
      "longitude": "106.69504",
      "latitude": "10.76471",
      "promotion": "Private sale: save 4%",
      "supplierCode": "s007",
      "hotelAddress": "96 De Tham Street, District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "679075.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double or Twin Room",
            "roomCode": "201994612",
            "boardName": "",
            "specialOffer": "",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double or Twin Room",
            "roomCode": "201994612",
            "boardName": "",
            "specialOffer": "",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "108F1",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "699112",
      "cover": "http://i.travelapi.com/hotels/19000000/18600000/18597600/18597589/1e106a6e_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Quynh Kim Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Quynh Kim Hotel in Ho Chi Minh City, you'll be within a 5-minute walk of Pham Ngu Lao Backpacker Area and Bui Vien Walking Street.  This hotel is 0.4 …",
      "longitude": "106.69651",
      "latitude": "10.7675",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "28 Trinh Van Can St, Dist 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "679075.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room",
            "roomCode": "219322952",
            "boardName": "",
            "specialOffer": "",
            "availability": "11",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room",
            "roomCode": "219322952",
            "boardName": "",
            "specialOffer": "",
            "availability": "11",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "108F1",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1023759",
      "cover": "http://i.travelapi.com/hotels/30000000/29080000/29070200/29070180/8912436d_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "RedDoorz Plus near Lotte Mart D7",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at RedDoorz Plus near Lotte Mart D7 in Ho Chi Minh City, you'll be convenient to SC VivoCity and FV Hospital.  This hotel is within close proximity of …",
      "longitude": "106.70544",
      "latitude": "10.73827",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "42, Street 73, District 7, "
    },
    {
      "roomGroup": {
        "totalPrice": "684216.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room",
            "roomCode": "202126080",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room",
            "roomCode": "202126080",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "10A95",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "729131",
      "cover": "http://i.travelapi.com/hotels/20000000/19530000/19527200/19527167/7eb535b7_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Huy Hoang Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Huy Hoang Hotel in Ho Chi Minh City, you'll be within a 10-minute drive of Ho Chi Minh City International Exhibition and Convention Centre and Hoang …",
      "longitude": "106.6416",
      "latitude": "10.79791",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "74 Binh Gia, P.13, Q. Tan Binh, "
    },
    {
      "roomGroup": {
        "totalPrice": "684216.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "202431159",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "7",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "202431159",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "7",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "10A95",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "811424",
      "cover": "http://i.travelapi.com/hotels/23000000/22170000/22160100/22160012/da839077_t.jpg",
      "rate": "1.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Thu Tuyen Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Thu Tuyen Hotel in Ho Chi Minh City, you'll be within a 10-minute walk of Thong Nhat Stadium and An Dong Market.  This hotel is 1.4 mi (2.2 km) from …",
      "longitude": "106.66725",
      "latitude": "10.76044",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "61 Dao Duy Tu, Ward 5, District 10, "
    },
    {
      "roomGroup": {
        "totalPrice": "688132.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "200978916",
            "boardName": "",
            "specialOffer": "Save 5%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "200978916",
            "boardName": "",
            "specialOffer": "Save 5%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "10BD5",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "506649",
      "cover": "http://i.travelapi.com/hotels/11000000/10380000/10373900/10373803/0fe075b9_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Sunny Hotel Ho Chi Minh",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Sunny Hotel Ho Chi Minh places you in the heart of Ho Chi Minh City, steps from Pham Ngu Lao Backpacker Area and Bui Vien Walking Street.  This hotel is …",
      "longitude": "106.69382",
      "latitude": "10.76772",
      "promotion": "Save 5%",
      "supplierCode": "s007",
      "hotelAddress": "232 De Tham Street, Pham Ngu Lao Ward, "
    },
    {
      "roomGroup": {
        "totalPrice": "688132.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard 4th Floor",
            "roomCode": "201039244",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard 4th Floor",
            "roomCode": "201039244",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "10BD5",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "502652",
      "cover": "http://i.travelapi.com/hotels/10000000/9630000/9624700/9624654/be761947_t.jpg",
      "rate": "1.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Minh Chau Hotel - Dien Bien Phu",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Minh Chau Hotel - Dien Bien Phu in Ho Chi Minh City, you'll be within a 15-minute walk of Quoc Tu Pagoda and Museum of Traditional Vietnamese …",
      "longitude": "106.67645",
      "latitude": "10.76908",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "611/18 Dien Bien Phu Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "690336.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room, 1 Double Bed",
            "roomCode": "200210474",
            "boardName": "",
            "specialOffer": "Save 50%",
            "availability": "6",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room, 1 Double Bed",
            "roomCode": "200210474",
            "boardName": "",
            "specialOffer": "Save 50%",
            "availability": "6",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "10C89",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "402414",
      "cover": "http://i.travelapi.com/hotels/5000000/4920000/4918700/4918624/4918624_41_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Sen Saigon Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Sen Saigon Hotel places you in the heart of Ho Chi Minh City, within a 5-minute walk of September 23 Park and Pham Ngu Lao Backpacker Area.  This hotel is …",
      "longitude": "106.69365",
      "latitude": "10.76996",
      "promotion": "Save 50%",
      "supplierCode": "s007",
      "hotelAddress": "82 Le Lai Str, Ben Thanh Ward, Dist1, "
    },
    {
      "roomGroup": {
        "totalPrice": "691315.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior No Window",
            "roomCode": "200531642",
            "boardName": "",
            "specialOffer": "Special deal: save 30%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior No Window",
            "roomCode": "200531642",
            "boardName": "",
            "specialOffer": "Special deal: save 30%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "10CD9",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "444316",
      "cover": "http://i.travelapi.com/hotels/7000000/6660000/6654000/6653923/4d079169_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Minh Chau Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />When you stay at Minh Chau Hotel in Ho Chi Minh City, you'll be within a 10-minute drive of The Most Holy Redeemer Saigon and Museum of Traditional Vietnamese …",
      "longitude": "106.67286",
      "latitude": "10.77863",
      "promotion": "Special deal: save 30%",
      "supplierCode": "s007",
      "hotelAddress": "119 Hoa Hung St. Ward 12, District 10, "
    },
    {
      "roomGroup": {
        "totalPrice": "700862.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "201505538",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "201505538",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "10FE5",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "590690",
      "cover": "http://i.travelapi.com/hotels/16000000/15080000/15074500/15074466/469bcca6_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Melody Viet Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, Melody Viet Hotel is within a 15-minute walk of Parkson CT Plaza and Gia Dinh Park.  This hotel is 1.4 mi (2.2 km) from Vietnam People's …",
      "longitude": "106.66662",
      "latitude": "10.81116",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "25/22 Cuu Long St, Tan Binh District, "
    },
    {
      "roomGroup": {
        "totalPrice": "702086.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Room",
            "roomCode": "202223067",
            "boardName": "",
            "specialOffer": "Save 15%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Room",
            "roomCode": "202223067",
            "boardName": "",
            "specialOffer": "Save 15%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "11049",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "761275",
      "cover": "http://i.travelapi.com/hotels/21000000/20220000/20218800/20218778/5c52e07d_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Wanderlust Homestay",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Wanderlust Homestay in Ho Chi Minh City, you'll be a 3-minute walk from Saigon Culinary Arts Centre and 7 minutes by foot from Pham Ngu Lao Backpacker …",
      "longitude": "106.68642",
      "latitude": "10.76337",
      "promotion": "Save 15%",
      "supplierCode": "s007",
      "hotelAddress": "214/B14/A3 Nguyen Trai, "
    },
    {
      "roomGroup": {
        "totalPrice": "704044.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Room (Big Windows)",
            "roomCode": "216604713",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Room (Big Windows)",
            "roomCode": "216604713",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "110E9",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "894229",
      "cover": "http://i.travelapi.com/hotels/24000000/23780000/23778200/23778126/66f6e5f7_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Masion Hometel 2",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Masion Hometel 2 in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be a 2-minute walk from Pham Ngu Lao Backpacker Area and 6 minutes by foot …",
      "longitude": "106.68631",
      "latitude": "10.76752",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "191/A22 Cong Quynh Street. District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "705513.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room, No Windows (very small room 9m2  )",
            "roomCode": "200351196",
            "boardName": "Free Breakfast",
            "specialOffer": "Last minute deal: save 65%",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room, No Windows (very small room 9m2  )",
            "roomCode": "200351196",
            "boardName": "Free Breakfast",
            "specialOffer": "Last minute deal: save 65%",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "11161",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "435730",
      "cover": "http://i.travelapi.com/hotels/7000000/6300000/6291300/6291298/02796fc0_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Ava 2 Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Ava 2 Hotel places you in the heart of Ho Chi Minh City, within a 5-minute walk of Bui Vien Walking Street and Pham Ngu Lao Backpacker Area.  This hotel is …",
      "longitude": "106.69481",
      "latitude": "10.76522",
      "promotion": "Last minute deal: save 65%",
      "supplierCode": "s007",
      "hotelAddress": "126 De Tham St., Dist. 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "706982.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "220217516",
            "boardName": "",
            "specialOffer": "Tonight only: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "220217516",
            "boardName": "",
            "specialOffer": "Tonight only: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "111D9",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "967739",
      "cover": "http://i.travelapi.com/hotels/27000000/26820000/26815900/26815846/307c9f1d_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Ben Thanh Motel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Ben Thanh Motel in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Benthanh Street Food Market and 4 minutes by foot from Ben Thanh …",
      "longitude": "106.6975",
      "latitude": "10.77342",
      "promotion": "Tonight only: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "24/10 thu khoa huan street, district 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "724363.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room, 1 Double Bed, No Windows",
            "roomCode": "202031317",
            "boardName": "",
            "specialOffer": "",
            "availability": "6",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room, 1 Double Bed, No Windows",
            "roomCode": "202031317",
            "boardName": "",
            "specialOffer": "",
            "availability": "6",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "11765",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "706768",
      "cover": "http://i.travelapi.com/hotels/19000000/18900000/18895300/18895286/beba6a58_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Le Petit Sai Gon Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Le Petit Sai Gon Hotel in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Bui Vien Walking Street and Pham Ngu Lao Backpacker Area. …",
      "longitude": "106.6936",
      "latitude": "10.76733",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "64 Bui Vien, District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "724363.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Basic Double Room, 1 Double Bed, City View",
            "roomCode": "221720611",
            "boardName": "Free Breakfast",
            "specialOffer": "",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Basic Double Room, 1 Double Bed, City View",
            "roomCode": "221720611",
            "boardName": "Free Breakfast",
            "specialOffer": "",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "11765",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "718436",
      "cover": "http://i.travelapi.com/hotels/20000000/19270000/19264600/19264507/4882a3ec_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Hotel 175",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Hotel 175 in Ho Chi Minh City (Go Vap), you'll be a 3-minute drive from Gia Dinh Park and 8 minutes from Parkson CT Plaza.  This spa hotel is 2.3 mi …",
      "longitude": "106.67887",
      "latitude": "10.82201",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "786B Nguyen Kiem Street, Ward 3, "
    },
    {
      "roomGroup": {
        "totalPrice": "724363.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "201543415",
            "boardName": "",
            "specialOffer": "",
            "availability": "9",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "201543415",
            "boardName": "",
            "specialOffer": "",
            "availability": "9",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "11765",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "599912",
      "cover": "http://i.travelapi.com/hotels/16000000/15390000/15383900/15383822/9f21d732_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Crystal Hotel Saigon",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Crystal Hotel Saigon in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be within a 15-minute walk of Ben Thanh Market and Museum of Fine Arts.  …",
      "longitude": "106.69172",
      "latitude": "10.77023",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "70 Nguyen Trai St, "
    },
    {
      "roomGroup": {
        "totalPrice": "733420.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room",
            "roomCode": "202076949",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room",
            "roomCode": "202076949",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "11A49",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "718938",
      "cover": "http://i.travelapi.com/hotels/20000000/19280000/19276200/19276174/241faf08_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Uyen Anh Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Uyen Anh Hotel in Ho Chi Minh City, you'll be a 4-minute walk from Parkson CT Plaza and 10 minutes by foot from Gia Dinh Park.  This hotel is 1.4 mi …",
      "longitude": "106.66841",
      "latitude": "10.81279",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "43-45 Yen The Street, Ward 2, "
    },
    {
      "roomGroup": {
        "totalPrice": "733420.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Twin Room",
            "roomCode": "202198082",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Twin Room",
            "roomCode": "202198082",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "11A49",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "750737",
      "cover": "http://i.travelapi.com/hotels/21000000/20010000/20000300/20000206/ba1590b7_t.jpg",
      "rate": "1.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Around the World Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Around the World Hotel in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Bui Vien Walking Street and Pham Ngu Lao Backpacker Area. …",
      "longitude": "106.69319",
      "latitude": "10.76694",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "65 Bui Vien, Phuong Pham Ngu Lao, D1, "
    },
    {
      "roomGroup": {
        "totalPrice": "733420.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "216614018",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "8",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "216614018",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "8",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "11A49",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1001367",
      "cover": "http://i.travelapi.com/hotels/28000000/27210000/27200900/27200881/447d966d_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Bin Bin Hotel 5",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, Bin Bin Hotel 5 is within a 10-minute drive of FV Hospital and SC VivoCity.  This hotel is 1.9 mi (3 km) from Saigon Paragon Mall and …",
      "longitude": "106.70539",
      "latitude": "10.73767",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "42 Street 73 Tan Quy Dong Residence, "
    },
    {
      "roomGroup": {
        "totalPrice": "742478.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room, Balcony",
            "roomCode": "221413084",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room, Balcony",
            "roomCode": "221413084",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": false,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "11D2D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "925483",
      "cover": "http://i.travelapi.com/hotels/25000000/24460000/24454300/24454255/daec096d_t.jpg",
      "rate": "1.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Condodo Homestay",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, Condodo Homestay is within a 15-minute walk of Saigon Culinary Arts Centre and Pham Ngu Lao Backpacker Area.  This hostel is 0.5 mi (0.8 …",
      "longitude": "106.69175",
      "latitude": "10.7605",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "48B1 Tran Dinh Xu street, "
    },
    {
      "roomGroup": {
        "totalPrice": "749577.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room",
            "roomCode": "216604847",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room",
            "roomCode": "216604847",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "11F71",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "886710",
      "cover": "http://i.travelapi.com/hotels/24000000/23560000/23557800/23557791/4c5a17ac_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Phuong Van Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Phuong Van Hotel in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Pham Ngu Lao Backpacker Area and Bui Vien Walking Street.  This …",
      "longitude": "106.69321",
      "latitude": "10.76742",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "84/12B Bui Vien, Pham Ngu Lao Ward, "
    },
    {
      "roomGroup": {
        "totalPrice": "750067.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Economy Double Room, No Windows",
            "roomCode": "217825117",
            "boardName": "",
            "specialOffer": "Save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Economy Double Room, No Windows",
            "roomCode": "217825117",
            "boardName": "",
            "specialOffer": "Save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "11F99",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1033606",
      "cover": "http://i.travelapi.com/hotels/30000000/29390000/29387500/29387457/10cfd488_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Kezuo",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, Kezuo is minutes from FV Hospital and Saigon Exhibition and Convention Center.  This hotel is within close proximity of Saigon Paragon …",
      "longitude": "106.72161",
      "latitude": "10.73402",
      "promotion": "Save 10%",
      "supplierCode": "s007",
      "hotelAddress": "R4-41, 42 Hung Phuoc 3, PMH, "
    },
    {
      "roomGroup": {
        "totalPrice": "753249.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room, No Windows",
            "roomCode": "201331400",
            "boardName": "Free Breakfast",
            "specialOffer": "Flash sale: save 20%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room, No Windows",
            "roomCode": "201331400",
            "boardName": "Free Breakfast",
            "specialOffer": "Flash sale: save 20%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1209D",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "558107",
      "cover": "http://i.travelapi.com/hotels/13000000/12770000/12768600/12768577/28d07d6f_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Bich Duyen Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Bich Duyen Hotel in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Pham Ngu Lao Backpacker Area and 3 minutes by foot from Bui …",
      "longitude": "106.69124",
      "latitude": "10.76748",
      "promotion": "Flash sale: save 20%",
      "supplierCode": "s007",
      "hotelAddress": "283/4 Pham Ngu Lao, "
    },
    {
      "roomGroup": {
        "totalPrice": "753249.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Bed in 6 - Female Dormitory Room",
            "roomCode": "202203312",
            "boardName": "Free Breakfast",
            "specialOffer": "Save 5%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Bed in 6 - Female Dormitory Room",
            "roomCode": "202203312",
            "boardName": "Free Breakfast",
            "specialOffer": "Save 5%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1209D",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "755178",
      "cover": "http://i.travelapi.com/hotels/21000000/20100000/20094700/20094661/c31bd028_t.jpg",
      "rate": "1.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Coco Hostel Bar",
      "hotelDescription": "<p><b>Property Location</b> <br />Coco Hostel Bar is in the heart of Ho Chi Minh City, within a 5-minute walk of Saigon Notre-Dame Basilica and Saigon Central Post Office.  This hostel is 0.3 mi (0.5 …",
      "longitude": "106.69854",
      "latitude": "10.77845",
      "promotion": "Save 5%",
      "supplierCode": "s007",
      "hotelAddress": "178/15 Pasteur, District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "753249.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Bed (Bunk bed)",
            "roomCode": "219917392",
            "boardName": "",
            "specialOffer": "Tonight only: save 35%",
            "availability": "6",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Bed (Bunk bed)",
            "roomCode": "219917392",
            "boardName": "",
            "specialOffer": "Tonight only: save 35%",
            "availability": "6",
            "boardCode": ""
          }
        ],
        "nonRefundable": false,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1209D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "964530",
      "cover": "http://i.travelapi.com/hotels/27000000/26750000/26747100/26747072/cc24abd9_t.jpg",
      "rate": "1.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "S Phuot Airport Homestay",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at S Phuot Airport Homestay in Ho Chi Minh City, you'll be 4.3 mi (6.9 km) from War Remnants Museum and 5 mi (8 km) from Saigon Square.  This hostel is …",
      "longitude": "106.66629",
      "latitude": "10.80729",
      "promotion": "Tonight only: save 35%",
      "supplierCode": "s007",
      "hotelAddress": "3A Lam Son, 2 Ward, "
    },
    {
      "roomGroup": {
        "totalPrice": "756187.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Apartment, 1 Bedroom",
            "roomCode": "221716828",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Apartment, 1 Bedroom",
            "roomCode": "221716828",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1218D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "961217",
      "cover": "http://i.travelapi.com/hotels/27000000/26700000/26690300/26690218/290527b8_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Saigon House",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Saigon House in Ho Chi Minh City (Hang Xanh), you'll be convenient to Jade Emperor Pagoda and Vietnam National Museum of History.  This apartment is …",
      "longitude": "106.70507",
      "latitude": "10.79672",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "153 Nguyen Cuu Van Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "757166.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Shared Dormitory, Mixed Dorm",
            "roomCode": "214519365",
            "boardName": "",
            "specialOffer": "",
            "availability": "16",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Shared Dormitory, Mixed Dorm",
            "roomCode": "214519365",
            "boardName": "",
            "specialOffer": "",
            "availability": "16",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "121DD",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "1032759",
      "cover": "http://i.travelapi.com/hotels/28000000/27710000/27705400/27705374/0301dcc3_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Ben Thanh Dorm Homestay Central Saigon - Hostel",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City (Downtown Ho Chi Minh City), Ben Thanh Dorm Homestay Central Saigon - Hostel is minutes from Benthanh Street Food Market and Ben Thanh …",
      "longitude": "106.69725",
      "latitude": "10.77262",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "43 Phan Chu Trinh, "
    },
    {
      "roomGroup": {
        "totalPrice": "760348.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Basic Room, 1 King Bed, Non Smoking, Shared Bathroom",
            "roomCode": "202228198",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Basic Room, 1 King Bed, Non Smoking, Shared Bathroom",
            "roomCode": "202228198",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "122E1",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "760000",
      "cover": "http://i.travelapi.com/hotels/21000000/20180000/20179900/20179892/c1913deb_t.jpg",
      "rate": "1.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Mai Home Hostel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Mai Home Hostel in Ho Chi Minh City, you'll be within a 10-minute walk of Saigon Culinary Arts Centre and Pham Ngu Lao Backpacker Area.  This hostel …",
      "longitude": "106.69025",
      "latitude": "10.76132",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "69/15-17 Tran Ðinh Xu, "
    },
    {
      "roomGroup": {
        "totalPrice": "760348.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "218721924",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "218721924",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "122E1",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1010885",
      "cover": "http://i.travelapi.com/hotels/28000000/27800000/27791900/27791801/cade14a7_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "RedDoorz Plus near Ba Chieu Local Market",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, RedDoorz Plus near Ba Chieu Local Market is convenient to Jade Emperor Pagoda and Gia Dinh Park.  This hotel is within close proximity …",
      "longitude": "106.69429",
      "latitude": "10.8059",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "5/24 No Trang Long street,, "
    },
    {
      "roomGroup": {
        "totalPrice": "764755.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "201264699",
            "boardName": "",
            "specialOffer": "Private sale: save 35%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "201264699",
            "boardName": "",
            "specialOffer": "Private sale: save 35%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "12449",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "546970",
      "cover": "http://i.travelapi.com/hotels/13000000/12340000/12335100/12335062/52473bfd_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Anh Ngoc Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Anh Ngoc Hotel in Ho Chi Minh City, you'll be 1.8 mi (3 km) from War Remnants Museum and 2.6 mi (4.2 km) from Saigon Square.  This hotel is 2.8 mi …",
      "longitude": "106.67172",
      "latitude": "10.77578",
      "promotion": "Private sale: save 35%",
      "supplierCode": "s007",
      "hotelAddress": "9/4-6 Hoang Du Khuong, "
    },
    {
      "roomGroup": {
        "totalPrice": "765734.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "200722495",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "200722495",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "12499",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "463983",
      "cover": "http://i.travelapi.com/hotels/9000000/8420000/8415600/8415574/1ffb20d4_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Tan Hotel Saigon",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Tan Hotel Saigon in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Bui Vien Walking Street and Pham Ngu Lao Backpacker Area.  This …",
      "longitude": "106.6927",
      "latitude": "10.76682",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "126-128 Bui Vien, "
    },
    {
      "roomGroup": {
        "totalPrice": "766958.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room",
            "roomCode": "221419525",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "11",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room",
            "roomCode": "221419525",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "11",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "124FD",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1001357",
      "cover": "http://i.travelapi.com/hotels/28000000/27210000/27200500/27200407/6f8c37c7_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Bin Bin Hotel 2",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, Bin Bin Hotel 2 is within a 15-minute drive of SC VivoCity and FV Hospital.  This hotel is 2.4 mi (3.9 km) from Cho Quan Church and 2.5 …",
      "longitude": "106.69572",
      "latitude": "10.74051",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "L19, Street No. 14,, "
    },
    {
      "roomGroup": {
        "totalPrice": "771854.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "202101454",
            "boardName": "",
            "specialOffer": "Private sale: save 45%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "202101454",
            "boardName": "",
            "specialOffer": "Private sale: save 45%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1268D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "725318",
      "cover": "http://i.travelapi.com/hotels/20000000/19450000/19441400/19441394/702a73e1_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Thinh Gia Phat Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />When you stay at Thinh Gia Phat Hotel in Ho Chi Minh City, you'll be within a 10-minute drive of Ho Chi Minh City International Exhibition and Convention Centre and …",
      "longitude": "106.64774",
      "latitude": "10.80481",
      "promotion": "Private sale: save 45%",
      "supplierCode": "s007",
      "hotelAddress": "155 Hoang Hoa Tham, Ward 13, "
    },
    {
      "roomGroup": {
        "totalPrice": "775036.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "215102664",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "215102664",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "12791",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "869050",
      "cover": "http://i.travelapi.com/hotels/24000000/23240000/23236000/23235979/1bdf235a_t.jpg",
      "rate": "1.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Saigon River Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Saigon River Hotel in Ho Chi Minh City (Thu Thiem), you'll be within a 10-minute drive of Vincom Mega Mall and Van Thanh Tourist Park.  This hotel is …",
      "longitude": "106.73026",
      "latitude": "10.79787",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "35/8 Street No. 19, "
    },
    {
      "roomGroup": {
        "totalPrice": "776016.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room",
            "roomCode": "217801335",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "7",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room",
            "roomCode": "217801335",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "7",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "127E1",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "850794",
      "cover": "http://i.travelapi.com/hotels/23000000/22960000/22954100/22954079/a34009fa_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Phuc Duc Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Phuc Duc Hotel in Ho Chi Minh City, you'll be within a 5-minute walk of Saigon Culinary Arts Centre and Pham Ngu Lao Backpacker Area.  This hotel is …",
      "longitude": "106.68681",
      "latitude": "10.76532",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "212b/1 Nguyen Trai, "
    },
    {
      "roomGroup": {
        "totalPrice": "778464.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Single Room",
            "roomCode": "202157652",
            "boardName": "",
            "specialOffer": "",
            "availability": "10",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Single Room",
            "roomCode": "202157652",
            "boardName": "",
            "specialOffer": "",
            "availability": "10",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "128A9",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "742826",
      "cover": "http://i.travelapi.com/hotels/20000000/19830000/19828700/19828688/1965f2d4_t.jpg",
      "rate": "1.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "My Xuan Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at My Xuan Hotel in Ho Chi Minh City (Hang Xanh), you'll be a 4-minute drive from Van Thanh Tourist Park and 7 minutes from Jade Emperor Pagoda.  This …",
      "longitude": "106.70944",
      "latitude": "10.80349",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "11 Dinh Bo Linh St., Ward 24, "
    },
    {
      "roomGroup": {
        "totalPrice": "782136.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double Room, 1 Bedroom, Balcony, Garden View",
            "roomCode": "202400912",
            "boardName": "",
            "specialOffer": "Member’s price: 73%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double Room, 1 Bedroom, Balcony, Garden View",
            "roomCode": "202400912",
            "boardName": "",
            "specialOffer": "Member’s price: 73%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "129D5",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "803212",
      "cover": "http://i.travelapi.com/hotels/22000000/21840000/21834200/21834113/68d13755_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Cucu Hostel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Cucu Hostel in Ho Chi Minh City, you'll be within a 10-minute walk of Saigon Culinary Arts Centre and Pham Ngu Lao Backpacker Area.  This hostel is …",
      "longitude": "106.69069",
      "latitude": "10.76104",
      "promotion": "Member’s price: 73%",
      "supplierCode": "s007",
      "hotelAddress": "65/5 Tran Dinh Xu, Cau Kho Ward, "
    },
    {
      "roomGroup": {
        "totalPrice": "782136.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "200844078",
            "boardName": "Full Breakfast",
            "specialOffer": "Private sale: save 10%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "200844078",
            "boardName": "Full Breakfast",
            "specialOffer": "Private sale: save 10%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "129D5",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "482863",
      "cover": "http://i.travelapi.com/hotels/10000000/9550000/9544900/9544806/ac89dc81_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Saigon Cosy Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Saigon Cosy Hotel places you in the heart of Ho Chi Minh City, steps from September 23 Park and Zen Plaza.  This hotel is 0.5 mi (0.7 km) from Bui Vien …",
      "longitude": "106.69233",
      "latitude": "10.76946",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "120/6 Le Lai, Ben Thanh Ward, Dist.1, "
    },
    {
      "roomGroup": {
        "totalPrice": "782136.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Studio",
            "roomCode": "218721825",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "6",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Studio",
            "roomCode": "218721825",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "6",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "129D5",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1011236",
      "cover": "http://i.travelapi.com/hotels/28000000/27790000/27788300/27788229/89b6ca5f_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Quang Duy Apartment",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Quang Duy Apartment in Ho Chi Minh City (Phu My Hung), you'll be convenient to SC VivoCity and FV Hospital.  This aparthotel is within close proximity …",
      "longitude": "106.70804",
      "latitude": "10.7325",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "R4-80 Hung Gia 2, "
    },
    {
      "roomGroup": {
        "totalPrice": "791193.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room",
            "roomCode": "200830621",
            "boardName": "",
            "specialOffer": "",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room",
            "roomCode": "200830621",
            "boardName": "",
            "specialOffer": "",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "12CB9",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "480572",
      "cover": "http://i.travelapi.com/hotels/10000000/9430000/9427100/9427023/6bfccbcf_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Mai Vy",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Mai Vy places you in the heart of Ho Chi Minh City, steps from Pham Ngu Lao Backpacker Area and Bui Vien Walking Street.  This hotel is 0.7 mi (1.1 km) …",
      "longitude": "106.69254",
      "latitude": "10.7679",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "241/12 Pham Ngu Lao Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "794131.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room",
            "roomCode": "202156060",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room",
            "roomCode": "202156060",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "12DA9",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "742629",
      "cover": "http://i.travelapi.com/hotels/20000000/19820000/19818300/19818247/8954aeca_t.jpg",
      "rate": "1.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Hanh Phuc Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Hanh Phuc Hotel in Ho Chi Minh City, you'll be within a 5-minute walk of Saigon Culinary Arts Centre and Pham Ngu Lao Backpacker Area.  This hotel is …",
      "longitude": "106.68749",
      "latitude": "10.76459",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "265 Nguyen Trai St., "
    },
    {
      "roomGroup": {
        "totalPrice": "796824.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "201670699",
            "boardName": "",
            "specialOffer": "",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "201670699",
            "boardName": "",
            "specialOffer": "",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "12E85",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "626365",
      "cover": "http://i.travelapi.com/hotels/17000000/16110000/16106700/16106622/fb58ba12_t.jpg",
      "rate": "1.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Tuan Viet Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Tuan Viet Hotel in Ho Chi Minh City, you'll be a 4-minute walk from Jade Emperor Pagoda and within a 5-minute drive of Southern Vietnam Women Museum.  …",
      "longitude": "106.69588",
      "latitude": "10.79252",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "232 Dinh Tien Hoang, "
    },
    {
      "roomGroup": {
        "totalPrice": "796824.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "215716867",
            "boardName": "Free Breakfast",
            "specialOffer": "Member’s price: 60%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "215716867",
            "boardName": "Free Breakfast",
            "specialOffer": "Member’s price: 60%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "12E85",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1030724",
      "cover": "http://i.travelapi.com/hotels/29000000/28920000/28918000/28917905/a3b3ec3f_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Kim Long Chau Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Kim Long Chau Hotel in Ho Chi Minh City (Bui Thi Xuan), you'll be minutes from Zen Plaza and Tao Dan Park.  This hotel is within close proximity of …",
      "longitude": "106.69055",
      "latitude": "10.772",
      "promotion": "Member’s price: 60%",
      "supplierCode": "s007",
      "hotelAddress": "19D Bui Thi Xuan Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "798292.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Studio",
            "roomCode": "216915743",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "40",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Studio",
            "roomCode": "216915743",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "40",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "12EFD",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1009148",
      "cover": "http://i.travelapi.com/hotels/28000000/27770000/27767300/27767276/28c6970e_t.jpg",
      "rate": "3.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "ND Building",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, ND Building is convenient to Ho Chi Minh City International Exhibition and Convention Centre and Vietnam People's Air Force Museum.  …",
      "longitude": "106.64076",
      "latitude": "10.80302",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "9 Le Van Huan, Ward 13, Tan Binh, "
    },
    {
      "roomGroup": {
        "totalPrice": "806371.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "215714428",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "215714428",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "13191",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1031268",
      "cover": "http://i.travelapi.com/hotels/28000000/27500000/27495400/27495310/897aa61f_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Sati Apartment Riverside",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, Sati Apartment Riverside is within a 15-minute walk of Jade Emperor Pagoda and Vietnam National Museum of History.  This hotel is 1 mi …",
      "longitude": "106.70413",
      "latitude": "10.79201",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "41 Hoang Sa, "
    },
    {
      "roomGroup": {
        "totalPrice": "814449.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "202331474",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 10%",
            "availability": "6",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "202331474",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 10%",
            "availability": "6",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "13425",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "793933",
      "cover": "http://i.travelapi.com/hotels/22000000/21460000/21456000/21455967/d879567f_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Mekong Hotels",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Mekong Hotels in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Pham Ngu Lao Backpacker Area and 3 minutes by foot from Bui Vien …",
      "longitude": "106.69316",
      "latitude": "10.76854",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "203 Pham Ngu Lao, Pham Ngu Lao Ward, "
    },
    {
      "roomGroup": {
        "totalPrice": "814449.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room",
            "roomCode": "202157728",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "10",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room",
            "roomCode": "202157728",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "10",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "13425",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "742852",
      "cover": "http://i.travelapi.com/hotels/20000000/19830000/19829500/19829424/8fdd4a3b_t.jpg",
      "rate": "1.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Vuon Tao Dan Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Vuon Tao Dan Hotel in Ho Chi Minh City, you'll be within a 5-minute walk of Golden Dragon Water Puppet Theatre and Tao Dan Park.  This hotel is 0.5 mi …",
      "longitude": "106.6901",
      "latitude": "10.77445",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "220 Nguyen Thi Minh Khai St., Ward 6, "
    },
    {
      "roomGroup": {
        "totalPrice": "814449.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Private Room",
            "roomCode": "217804828",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "21",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Private Room",
            "roomCode": "217804828",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "21",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "13425",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "888311",
      "cover": "http://i.travelapi.com/hotels/24000000/23600000/23599700/23599693/8bb1aa19_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "An Corner Homestay",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at this guesthouse, you'll be centrally located in Ho Chi Minh City, within a 10-minute drive of Ear Nose Throat Hospital and Southern Vietnam Women …",
      "longitude": "106.68733",
      "latitude": "10.7929",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "214/19/50 Nguyen Van Nguyen, Tan Dinh, "
    },
    {
      "roomGroup": {
        "totalPrice": "814449.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "217211504",
            "boardName": "",
            "specialOffer": "Seasonal deal: save 10%",
            "availability": "7",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "217211504",
            "boardName": "",
            "specialOffer": "Seasonal deal: save 10%",
            "availability": "7",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "13425",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "950971",
      "cover": "http://i.travelapi.com/hotels/26000000/25790000/25785200/25785139/b3d53ecc_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Nhat Hoang Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Nhat Hoang Hotel in Ho Chi Minh City, you'll be within a 10-minute walk of Nha Rong Wharf and Saigon River.  This hotel is 1.1 mi (1.7 km) from …",
      "longitude": "106.70809",
      "latitude": "10.76274",
      "promotion": "Seasonal deal: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "180 Nguyen Tat Thanh Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "814449.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Studio",
            "roomCode": "202115373",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Studio",
            "roomCode": "202115373",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "13425",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "729329",
      "cover": "http://i.travelapi.com/hotels/20000000/19530000/19528300/19528248/f2dd24ee_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "The Green House - District 5",
      "hotelDescription": "<p><b>Property Location</b> <br />When you stay at The Green House - District 5 in Ho Chi Minh City, you'll be within a 10-minute drive of Cho Quan Church and An Dong Market.  This apartment is 1.3 …",
      "longitude": "106.67254",
      "latitude": "10.75195",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "112/8/10 An Binh St., "
    },
    {
      "roomGroup": {
        "totalPrice": "814939.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room (No Window)",
            "roomCode": "200667180",
            "boardName": "",
            "specialOffer": "",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room (No Window)",
            "roomCode": "200667180",
            "boardName": "",
            "specialOffer": "",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1344D",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "456104",
      "cover": "http://i.travelapi.com/hotels/9000000/8080000/8071100/8071001/a4846864_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Hotel Tuan Anh 168",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Hotel Tuan Anh 168 in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Pham Ngu Lao Backpacker Area and Bui Vien Walking Street.  …",
      "longitude": "106.68956",
      "latitude": "10.76609",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "168 Cong Quynh, "
    },
    {
      "roomGroup": {
        "totalPrice": "814939.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "202394003",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "202394003",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1344D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "801004",
      "cover": "http://i.travelapi.com/hotels/22000000/21650000/21640600/21640565/842e8c4e_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Friday Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Friday Hotel in Ho Chi Minh City, you'll be a 2-minute walk from Quoc Tu Pagoda and 5 minutes by foot from Museum of Traditional Vietnamese Medicine.  …",
      "longitude": "106.67187",
      "latitude": "10.77256",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "781/ a11 Le Hong Phong Street, Ward 12, "
    },
    {
      "roomGroup": {
        "totalPrice": "823752.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Luxury Dorm with Window",
            "roomCode": "202264092",
            "boardName": "",
            "specialOffer": "Save 5%",
            "availability": "7",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Luxury Dorm with Window",
            "roomCode": "202264092",
            "boardName": "",
            "specialOffer": "Save 5%",
            "availability": "7",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1371D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "769324",
      "cover": "http://i.travelapi.com/hotels/21000000/20490000/20485000/20484979/535b7d68_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Full House Homestay",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Full House Homestay in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Zen Plaza and September 23 Park.  This hotel is 0.3 mi (0.5 …",
      "longitude": "106.6933",
      "latitude": "10.76987",
      "promotion": "Save 5%",
      "supplierCode": "s007",
      "hotelAddress": "174/6 Le Lai st., Ben Thanh Ward, Dist 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "825710.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double or Twin Room",
            "roomCode": "220515765",
            "boardName": "",
            "specialOffer": "Save 52%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double or Twin Room",
            "roomCode": "220515765",
            "boardName": "",
            "specialOffer": "Save 52%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "137BD",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "944553",
      "cover": "http://i.travelapi.com/hotels/26000000/25150000/25147700/25147619/bfcb609e_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Winston Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />When you stay at Winston Hotel in Ho Chi Minh City, you'll be 13 minutes by car from Van Thanh Tourist Park.  This hotel is 3.4 mi (5.5 km) from Jade Emperor Pagoda …",
      "longitude": "106.71882",
      "latitude": "10.81879",
      "promotion": "Save 52%",
      "supplierCode": "s007",
      "hotelAddress": "76 Thanh Da street, Ward 27,, "
    },
    {
      "roomGroup": {
        "totalPrice": "825710.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double Room, 1 Queen Bed, Ensuite",
            "roomCode": "215406256",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double Room, 1 Queen Bed, Ensuite",
            "roomCode": "215406256",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "137BD",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "892456",
      "cover": "http://i.travelapi.com/hotels/24000000/23700000/23691800/23691718/28f46603_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "NogiasHostel",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, NogiasHostel is a 3-minute drive from Bui Vien Walking Street and 7 minutes from Riverside.  This hostel is 1.1 mi (1.8 km) from Museum …",
      "longitude": "106.69322",
      "latitude": "10.76042",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "19 Ho Hao Hon, "
    },
    {
      "roomGroup": {
        "totalPrice": "832809.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Room (2 double beds)",
            "roomCode": "201790242",
            "boardName": "",
            "specialOffer": "",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Room (2 double beds)",
            "roomCode": "201790242",
            "boardName": "",
            "specialOffer": "",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "13A01",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "652265",
      "cover": "http://i.travelapi.com/hotels/18000000/17070000/17069200/17069115/87636fb5_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Venus Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Venus Hotel in Ho Chi Minh City, you'll be a 3-minute walk from Vietnam People's Air Force Museum and 10 minutes by foot from Hoang Van Thu Park.  …",
      "longitude": "106.66239",
      "latitude": "10.80381",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "2/1 Phan Thuc Duyen Street, Ward 4, "
    },
    {
      "roomGroup": {
        "totalPrice": "832809.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room",
            "roomCode": "202125477",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room",
            "roomCode": "202125477",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "13A01",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "732559",
      "cover": "http://i.travelapi.com/hotels/20000000/19640000/19639800/19639785/7a2af1b1_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Memoires de Saigon",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Memoires de Saigon in Ho Chi Minh City, you'll be within a 10-minute walk of Bui Vien Walking Street and Pham Ngu Lao Backpacker Area.  This hostel is …",
      "longitude": "106.69284",
      "latitude": "10.7632",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "252A1 Co Bac, District 1, Pham Ngu Lao, "
    },
    {
      "roomGroup": {
        "totalPrice": "841867.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double Room, 1 King Bed, River View",
            "roomCode": "216013938",
            "boardName": "",
            "specialOffer": "Private sale: save 25%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double Room, 1 King Bed, River View",
            "roomCode": "216013938",
            "boardName": "",
            "specialOffer": "Private sale: save 25%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "13CE5",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1019846",
      "cover": "http://i.travelapi.com/hotels/28000000/27300000/27295100/27295083/acc50277_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh",
      "hotelName": "iHome Homestay",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at iHome Homestay in Ho Chi Minh City, you'll be within a 15-minute walk of Vietnam National Museum of History and Saigon Zoo and Botanic Garden.  This …",
      "longitude": "106.70482",
      "latitude": "10.79181",
      "promotion": "Private sale: save 25%",
      "supplierCode": "s007",
      "hotelAddress": "11 Hoang Sa Phuong Da Kao Quan 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "847497.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "201712760",
            "boardName": "",
            "specialOffer": "Save 10%",
            "availability": "7",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "201712760",
            "boardName": "",
            "specialOffer": "Save 10%",
            "availability": "7",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "13EB1",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "633368",
      "cover": "http://i.travelapi.com/hotels/17000000/16350000/16345900/16345849/96abdc07_t.jpg",
      "rate": "1.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Legend Saigon Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Legend Saigon Hotel places you in the heart of Ho Chi Minh City, steps from Pham Ngu Lao Backpacker Area and 3 minutes by foot from Bui Vien Walking …",
      "longitude": "106.69278",
      "latitude": "10.76844",
      "promotion": "Save 10%",
      "supplierCode": "s007",
      "hotelAddress": "219/8 Pham Ngu Lao Str, "
    },
    {
      "roomGroup": {
        "totalPrice": "850435.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "200838886",
            "boardName": "",
            "specialOffer": "Save 15%",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "200838886",
            "boardName": "",
            "specialOffer": "Save 15%",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "13FA1",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "482316",
      "cover": "http://i.travelapi.com/hotels/10000000/9510000/9506700/9506612/5e9c71da_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Southern Star Hotel - Sao Nam",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Southern Star Hotel - Sao Nam places you in the heart of Ho Chi Minh City, steps from Pham Ngu Lao Backpacker Area and Bui Vien Walking Street.  This hotel …",
      "longitude": "106.69407",
      "latitude": "10.76827",
      "promotion": "Save 15%",
      "supplierCode": "s007",
      "hotelAddress": "175/5 Pham Ngu Lao, "
    },
    {
      "roomGroup": {
        "totalPrice": "850924.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Studio",
            "roomCode": "202447520",
            "boardName": "",
            "specialOffer": "",
            "availability": "6",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Studio",
            "roomCode": "202447520",
            "boardName": "",
            "specialOffer": "",
            "availability": "6",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "13FC9",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "815640",
      "cover": "http://i.travelapi.com/hotels/23000000/22260000/22257700/22257677/2962a0cd_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Airstar Apartment",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, Airstar Apartment is within a 15-minute drive of Hoang Van Thu Park and Dam Sen Park.  This aparthotel is 2.9 mi (4.7 km) from Vinh …",
      "longitude": "106.6499",
      "latitude": "10.78783",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "1017/6A Lac Long Quan, Ward 11, Tan Binh, "
    },
    {
      "roomGroup": {
        "totalPrice": "850924.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "202199740",
            "boardName": "",
            "specialOffer": "",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "202199740",
            "boardName": "",
            "specialOffer": "",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "13FC9",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "753393",
      "cover": "http://i.travelapi.com/hotels/21000000/20060000/20057600/20057520/558b9a2c_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "The Blue Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at The Blue Hotel in Ho Chi Minh City, you'll be a 2-minute walk from Vietnam People's Air Force Museum and 10 minutes by foot from Hoang Van Thu Park.  …",
      "longitude": "106.66221",
      "latitude": "10.80378",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "2/37 Phan Thuc Duyen Street, Ward 4, "
    },
    {
      "roomGroup": {
        "totalPrice": "852148.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Family Room, 2 Windows",
            "roomCode": "202444659",
            "boardName": "",
            "specialOffer": "",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Family Room, 2 Windows",
            "roomCode": "202444659",
            "boardName": "",
            "specialOffer": "",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1402D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "809280",
      "cover": "http://i.travelapi.com/hotels/23000000/22110000/22101700/22101687/7d43b9d5_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "The Lucky House",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at The Lucky House in Ho Chi Minh City (Bach Dang Riverside), you'll be within a 10-minute walk of Pham Ngu Lao Backpacker Area and Bui Vien Walking …",
      "longitude": "106.6986",
      "latitude": "10.76571",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "319/19-20 Nguyen Cong Tru, "
    },
    {
      "roomGroup": {
        "totalPrice": "852148.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "218723230",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "218723230",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1402D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1022972",
      "cover": "http://i.travelapi.com/hotels/29000000/28880000/28877200/28877116/8145aa29_t.jpg",
      "rate": "1.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Moc Lan 1 Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City (Phu Nhuan), Moc Lan 1 Hotel is convenient to Jade Emperor Pagoda and Southern Vietnam Women Museum.  This hotel is within close …",
      "longitude": "106.68957",
      "latitude": "10.79684",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "79 Hoa Hong street,, "
    },
    {
      "roomGroup": {
        "totalPrice": "852148.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room, No Windows",
            "roomCode": "201543207",
            "boardName": "Free Breakfast",
            "specialOffer": "Save 55%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room, No Windows",
            "roomCode": "201543207",
            "boardName": "Free Breakfast",
            "specialOffer": "Save 55%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1402D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "599915",
      "cover": "http://i.travelapi.com/hotels/16000000/15390000/15382700/15382649/f389f579_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Nhat Yen HotelHCM",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Nhat Yen HotelHCM in Ho Chi Minh City (Phu My Hung), you'll be within a 5-minute drive of FV Hospital and The Cresent Mall.  This hotel is 0.8 mi (1.4 …",
      "longitude": "106.71011",
      "latitude": "10.73385",
      "promotion": "Save 55%",
      "supplierCode": "s007",
      "hotelAddress": "R4 - 06 No.2 Street, Hung Gia 5, Phu My, "
    },
    {
      "roomGroup": {
        "totalPrice": "852148.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "216317565",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "216317565",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1402D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1020683",
      "cover": "http://i.travelapi.com/hotels/29000000/28880000/28878400/28878312/24697f02_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Moc Lan 3 Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Moc Lan 3 Hotel in Ho Chi Minh City (Phu Nhuan), you'll be convenient to Jade Emperor Pagoda and Ear Nose Throat Hospital.  This hotel is within close …",
      "longitude": "106.68876",
      "latitude": "10.79746",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "129 Hoa Lan street,, "
    },
    {
      "roomGroup": {
        "totalPrice": "852148.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "220523736",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "220523736",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1402D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1025369",
      "cover": "http://i.travelapi.com/hotels/29000000/28880000/28877400/28877311/249491ff_t.jpg",
      "rate": "1.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Moc Lan 2 Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Moc Lan 2 Hotel in Ho Chi Minh City (Phu Nhuan), you'll be convenient to Jade Emperor Pagoda and Southern Vietnam Women Museum.  This hotel is within …",
      "longitude": "106.6891",
      "latitude": "10.79664",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "54 Cu Lao street,, "
    },
    {
      "roomGroup": {
        "totalPrice": "855576.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room ((C1))",
            "roomCode": "200829962",
            "boardName": "Free Breakfast",
            "specialOffer": "Member’s price: 30%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room ((C1))",
            "roomCode": "200829962",
            "boardName": "Free Breakfast",
            "specialOffer": "Member’s price: 30%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "14145",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "480477",
      "cover": "http://i.travelapi.com/hotels/10000000/9430000/9421700/9421689/4606abdc_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Yen's Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Yen's Hotel places you in the heart of Ho Chi Minh City, steps from Pham Ngu Lao Backpacker Area and 3 minutes by foot from Bui Vien Walking Street.  This …",
      "longitude": "106.69288",
      "latitude": "10.7685",
      "promotion": "Member’s price: 30%",
      "supplierCode": "s007",
      "hotelAddress": "185/34 Pham Ngu Lao, "
    },
    {
      "roomGroup": {
        "totalPrice": "860227.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Bed in 12-Bed Mixed Dorm Shared Bathroom",
            "roomCode": "216903333",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 10%",
            "availability": "6",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Bed in 12-Bed Mixed Dorm Shared Bathroom",
            "roomCode": "216903333",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 10%",
            "availability": "6",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "142C1",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "881958",
      "cover": "http://i.travelapi.com/hotels/24000000/23480000/23478400/23478338/c28a1f8d_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Town House 23 Saigon Hotel - Hostel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Town House 23 Saigon Hotel - Hostel in Ho Chi Minh City, you'll be within a 5-minute walk of Pham Ngu Lao Backpacker Area and Bui Vien Walking Street. …",
      "longitude": "106.69737",
      "latitude": "10.76935",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "23 Dang Thi Nhu Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "861696.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room, Ensuite",
            "roomCode": "220522818",
            "boardName": "",
            "specialOffer": "Flash sale: save 30%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room, Ensuite",
            "roomCode": "220522818",
            "boardName": "",
            "specialOffer": "Flash sale: save 30%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "14339",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "1013677",
      "cover": "http://i.travelapi.com/hotels/28000000/27160000/27156900/27156801/0c6c9b5d_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Palms Garden Saigon Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City (Phu My Hung), Palms Garden Saigon Hotel is minutes from Canadian International School and The Japanese School in Ho Chi Minh City.  This …",
      "longitude": "106.73327",
      "latitude": "10.71943",
      "promotion": "Flash sale: save 30%",
      "supplierCode": "s007",
      "hotelAddress": "448 Tan Phu street, Phu My Hung, "
    },
    {
      "roomGroup": {
        "totalPrice": "869284.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room No Window",
            "roomCode": "201495310",
            "boardName": "Breakfast for 2",
            "specialOffer": "Save 40%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room No Window",
            "roomCode": "201495310",
            "boardName": "Breakfast for 2",
            "specialOffer": "Save 40%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "145A5",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "464244",
      "cover": "http://i.travelapi.com/hotels/9000000/8510000/8508900/8508831/96a368ea_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Ha Vy Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Ha Vy Hotel in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Pham Ngu Lao Backpacker Area and Bui Vien Walking Street.  This …",
      "longitude": "106.69119",
      "latitude": "10.76648",
      "promotion": "Save 40%",
      "supplierCode": "s007",
      "hotelAddress": "16 - 18 Do Quang Dau Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "869284.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room, No Windows",
            "roomCode": "215706533",
            "boardName": "",
            "specialOffer": "Member’s price: 20%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room, No Windows",
            "roomCode": "215706533",
            "boardName": "",
            "specialOffer": "Member’s price: 20%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "145A5",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "913831",
      "cover": "http://i.travelapi.com/hotels/25000000/24240000/24230200/24230130/d8108274_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "TRIIP Hoan Thai 2",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at TRIIP Hoan Thai 2 in Ho Chi Minh City, you'll be just steps from Pham Ngu Lao Backpacker Area and Bui Vien Walking Street.  This hotel is 0.7 mi (1.1 …",
      "longitude": "106.6961",
      "latitude": "10.76647",
      "promotion": "Member’s price: 20%",
      "supplierCode": "s007",
      "hotelAddress": "69 Nguyen Thai Hoc, "
    },
    {
      "roomGroup": {
        "totalPrice": "882014.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "219316976",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "219316976",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "149B5",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "970808",
      "cover": "http://i.travelapi.com/hotels/27000000/26940000/26935800/26935789/d8d3328d_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Jenny's Place",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Jenny's Place in Ho Chi Minh City (Bach Dang Riverside), you'll be within a 10-minute walk of Pham Ngu Lao Backpacker Area and Bui Vien Walking …",
      "longitude": "106.6962",
      "latitude": "10.76369",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "61/23 Co Giang street,, "
    },
    {
      "roomGroup": {
        "totalPrice": "882748.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "200761241",
            "boardName": "",
            "specialOffer": "",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "200761241",
            "boardName": "",
            "specialOffer": "",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "149F1",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "469054",
      "cover": "http://i.travelapi.com/hotels/9000000/8380000/8372700/8372636/8372636_26_t.jpg",
      "rate": "1.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Hong Kong Kaiteki Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Hong Kong Kaiteki Hotel in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Bui Vien Walking Street and Pham Ngu Lao Backpacker …",
      "longitude": "106.69496",
      "latitude": "10.76785",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "22 Bui Vien Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "885441.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Single Room",
            "roomCode": "216602055",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Single Room",
            "roomCode": "216602055",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "14ACD",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "859570",
      "cover": "http://i.travelapi.com/hotels/24000000/23120000/23116300/23116238/d64f3d11_t.jpg",
      "rate": "1.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Thadico 1 Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Thadico 1 Hotel in Ho Chi Minh City (Thu Thiem), you'll be within a 10-minute drive of Vincom Mega Mall and Van Thanh Tourist Park.  This hotel is 3.5 …",
      "longitude": "106.73076",
      "latitude": "10.79772",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "11/1 Duong 19, "
    },
    {
      "roomGroup": {
        "totalPrice": "885441.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Single Room",
            "roomCode": "221705471",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Single Room",
            "roomCode": "221705471",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "14ACD",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "859529",
      "cover": "http://i.travelapi.com/hotels/24000000/23120000/23116400/23116368/5f0bc315_t.jpg",
      "rate": "1.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Thadico 3 Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Thadico 3 Hotel in Ho Chi Minh City (Thu Thiem), you'll be within a 10-minute drive of Vincom Mega Mall and Van Thanh Tourist Park.  This hotel is 3.5 …",
      "longitude": "106.73077",
      "latitude": "10.79769",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "6-8 Duong 19B, "
    },
    {
      "roomGroup": {
        "totalPrice": "889113.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room, 1 Queen Bed, Accessible, Private Bathroom",
            "roomCode": "220803506",
            "boardName": "",
            "specialOffer": "",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room, 1 Queen Bed, Accessible, Private Bathroom",
            "roomCode": "220803506",
            "boardName": "",
            "specialOffer": "",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "14BF9",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "842428",
      "cover": "http://i.travelapi.com/hotels/23000000/22730000/22727100/22727033/96db7a57_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Shinhua Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, Shinhua Hotel is on the riverwalk, within a 15-minute drive of The Cresent Mall and Saigon Exhibition and Convention Center.  This hotel …",
      "longitude": "106.69626",
      "latitude": "10.73901",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "99 Duong D1, Tan Hung, District 7, "
    },
    {
      "roomGroup": {
        "totalPrice": "896212.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double Room, 1 Double Bed",
            "roomCode": "201157131",
            "boardName": "",
            "specialOffer": "Member’s price: 55%",
            "availability": "8",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double Room, 1 Double Bed",
            "roomCode": "201157131",
            "boardName": "",
            "specialOffer": "Member’s price: 55%",
            "availability": "8",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "14E3D",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "453283",
      "cover": "http://i.travelapi.com/hotels/8000000/7840000/7832500/7832425/072e61ad_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Madam Cuc 127",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Madam Cuc 127 places you in the heart of Ho Chi Minh City, steps from Pham Ngu Lao Backpacker Area and 4 minutes by foot from Saigon Culinary Arts Centre.  …",
      "longitude": "106.68763",
      "latitude": "10.76648",
      "promotion": "Member’s price: 55%",
      "supplierCode": "s007",
      "hotelAddress": "127 Cong Quynh, District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "896212.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "215704725",
            "boardName": "",
            "specialOffer": "Save 45%",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "215704725",
            "boardName": "",
            "specialOffer": "Save 45%",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "14E3D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "896215",
      "cover": "http://i.travelapi.com/hotels/24000000/23920000/23912000/23911963/0ace7249_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Lai Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Lai Hotel in Ho Chi Minh City (Phu Nhuan), you'll be within a 10-minute drive of Southern Vietnam Women Museum and Ear Nose Throat Hospital.  This …",
      "longitude": "106.68556",
      "latitude": "10.79296",
      "promotion": "Save 45%",
      "supplierCode": "s007",
      "hotelAddress": "8 Phan Dinh Phung, "
    },
    {
      "roomGroup": {
        "totalPrice": "896212.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room",
            "roomCode": "221722733",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room",
            "roomCode": "221722733",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "14E3D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "978079",
      "cover": "http://i.travelapi.com/hotels/28000000/27030000/27026100/27026005/bf54943e_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Sai Gon Homestay",
      "hotelDescription": "<p><b>Property Location</b> <br />When you stay at this guesthouse in Ho Chi Minh City, you'll be within a 10-minute drive of Nha Rong Wharf and Riverside.  This guesthouse is 1.1 mi (1.8 km) from …",
      "longitude": "106.6987",
      "latitude": "10.76022",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "79 Duong so 45, Phuong 6, "
    },
    {
      "roomGroup": {
        "totalPrice": "904780.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "216316408",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "216316408",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "150F9",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "1007343",
      "cover": "http://i.travelapi.com/hotels/28000000/27440000/27436600/27436575/e31f9d67_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Drop By Saigon Hostel",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, Drop By Saigon Hostel is minutes from Saigon Culinary Arts Centre and close to Bui Vien Walking Street.  This guesthouse is within close …",
      "longitude": "106.68897",
      "latitude": "10.75994",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "391 A/12 Tran Hung Dao Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "905270.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Triple Room",
            "roomCode": "201501739",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Triple Room",
            "roomCode": "201501739",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "15121",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "590506",
      "cover": "http://i.travelapi.com/hotels/16000000/15070000/15067200/15067110/1cc33b4a_t.jpg",
      "rate": "1.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Quy Thanh Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Quy Thanh Hotel places you in the heart of Ho Chi Minh City, within a 5-minute walk of Temple of Mariamman and Zen Plaza.  This hotel is 0.3 mi (0.4 km) …",
      "longitude": "106.69419",
      "latitude": "10.77236",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "10 Dang Tran Con Street, District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "905270.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double or Twin Room",
            "roomCode": "201627632",
            "boardName": "Free Breakfast",
            "specialOffer": "",
            "availability": "6",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double or Twin Room",
            "roomCode": "201627632",
            "boardName": "Free Breakfast",
            "specialOffer": "",
            "availability": "6",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "15121",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "617563",
      "cover": "http://i.travelapi.com/hotels/16000000/15860000/15859700/15859698/b4bc845b_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Goldland Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Goldland Hotel in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Zen Plaza and 4 minutes by foot from September 23 Park.  This …",
      "longitude": "106.69289",
      "latitude": "10.77106",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "10 - 12 Nguyen Trai, "
    },
    {
      "roomGroup": {
        "totalPrice": "906249.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room, 1 Double Bed",
            "roomCode": "200208206",
            "boardName": "Full Breakfast",
            "specialOffer": "Private sale: save 28%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room, 1 Double Bed",
            "roomCode": "200208206",
            "boardName": "Full Breakfast",
            "specialOffer": "Private sale: save 28%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "15171",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "417306",
      "cover": "http://i.travelapi.com/hotels/6000000/5360000/5359700/5359634/0dde019d_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Phan Anh Backpackers Hostel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Phan Anh Backpackers Hostel places you in the heart of Ho Chi Minh City, steps from Pham Ngu Lao Backpacker Area and 4 minutes by foot from Bui Vien …",
      "longitude": "106.68927",
      "latitude": "10.76708",
      "promotion": "Private sale: save 28%",
      "supplierCode": "s007",
      "hotelAddress": "373/6 Pham Ngu Lao Street, District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "907228.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "201565896",
            "boardName": "Free Breakfast",
            "specialOffer": "Save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "201565896",
            "boardName": "Free Breakfast",
            "specialOffer": "Save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "151C1",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "603722",
      "cover": "http://i.travelapi.com/hotels/16000000/15500000/15497300/15497268/c3c6985b_t.jpg",
      "rate": "2.0",
      "destinationName": "Thu Dau Mot",
      "hotelName": "Hoang Yen 2 Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Hoang Yen 2 Hotel in Thu Dau Mot, you'll be 16.3 mi (26.3 km) from Royal Island Golf and 18.4 mi (29.7 km) from Ho Chi Minh City International …",
      "longitude": "106.64483",
      "latitude": "11.00733",
      "promotion": "Save 10%",
      "supplierCode": "s007",
      "hotelAddress": "12/66 Nguyen Chi Thanh Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "912369.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "200145641",
            "boardName": "",
            "specialOffer": "Limited time offer:  save 10%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "200145641",
            "boardName": "",
            "specialOffer": "Limited time offer:  save 10%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "15365",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "402337",
      "cover": "http://i.travelapi.com/hotels/5000000/4920000/4912100/4912021/5ca2a6b8_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Saigon Odyssey Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Saigon Odyssey Hotel places you in the heart of Ho Chi Minh City, steps from Bui Vien Walking Street and Pham Ngu Lao Backpacker Area.  This hotel is 0.6 …",
      "longitude": "106.69473",
      "latitude": "10.76775",
      "promotion": "Limited time offer:  save 10%",
      "supplierCode": "s007",
      "hotelAddress": "38 Bui Vien Str, Dist 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "912369.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "201025283",
            "boardName": "",
            "specialOffer": "Limited time offer:  save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "201025283",
            "boardName": "",
            "specialOffer": "Limited time offer:  save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "15365",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "513109",
      "cover": "http://i.travelapi.com/hotels/11000000/10920000/10915900/10915851/2f3d7ffd_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Saigon Odyssey 1 Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Saigon Odyssey 1 Hotel places you in the heart of Ho Chi Minh City, steps from Bui Vien Walking Street and Pham Ngu Lao Backpacker Area.  This hotel is 0.5 …",
      "longitude": "106.69414",
      "latitude": "10.76748",
      "promotion": "Limited time offer:  save 10%",
      "supplierCode": "s007",
      "hotelAddress": "40/2 Bui Vien, Pham Ngu Lao Ward, Dist.1, "
    },
    {
      "roomGroup": {
        "totalPrice": "916041.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room, No Windows",
            "roomCode": "201935359",
            "boardName": "Free Breakfast",
            "specialOffer": "",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room, No Windows",
            "roomCode": "201935359",
            "boardName": "Free Breakfast",
            "specialOffer": "",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": false,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "15491",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "686578",
      "cover": "http://i.travelapi.com/hotels/19000000/18110000/18104200/18104132/f2b46bac_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Khoi 2 Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Khoi 2 Hotel in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Pham Ngu Lao Backpacker Area and 5 minutes by foot from Bui Vien …",
      "longitude": "106.68979",
      "latitude": "10.76663",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "373/49 Pham Ngu Lao Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "916041.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Luxury Studio",
            "roomCode": "202034430",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Luxury Studio",
            "roomCode": "202034430",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "15491",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "707421",
      "cover": "http://i.travelapi.com/hotels/19000000/18910000/18907500/18907482/d44a264b_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Happy Homes - Co Giang",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Happy Homes - Co Giang in Ho Chi Minh City, you'll be within a 15-minute walk of Bui Vien Walking Street and Pham Ngu Lao Backpacker Area.  This …",
      "longitude": "106.69326",
      "latitude": "10.76172",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "178/20 Co Giang Street, Co Giang Ward, "
    },
    {
      "roomGroup": {
        "totalPrice": "923630.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "201234543",
            "boardName": "",
            "specialOffer": "Save 15%",
            "availability": "6",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "201234543",
            "boardName": "",
            "specialOffer": "Save 15%",
            "availability": "6",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "156FD",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "542583",
      "cover": "http://i.travelapi.com/hotels/13000000/12030000/12021600/12021508/9ccaa163_t.jpg",
      "rate": "1.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Holiday Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Holiday Hotel in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be within a 5-minute walk of Zen Plaza and Temple of Mariamman.  This hotel is …",
      "longitude": "106.69379",
      "latitude": "10.77169",
      "promotion": "Save 15%",
      "supplierCode": "s007",
      "hotelAddress": "270 Ly Tu Trong Street, Ben Thanh Ward, "
    },
    {
      "roomGroup": {
        "totalPrice": "925099.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Triple Room with Private External Bathroom",
            "roomCode": "219902300",
            "boardName": "Free Breakfast",
            "specialOffer": "Tonight only: save 30%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Triple Room with Private External Bathroom",
            "roomCode": "219902300",
            "boardName": "Free Breakfast",
            "specialOffer": "Tonight only: save 30%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "15775",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "804973",
      "cover": "http://i.travelapi.com/hotels/22000000/21900000/21897800/21897724/995a8fce_t.jpg",
      "rate": "1.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "TimeMark Travel Homestay & Hostel",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City (Downtown Ho Chi Minh City), TimeMark Travel Homestay & Hostel is within a 5-minute walk of Pham Ngu Lao Backpacker Area and Saigon …",
      "longitude": "106.68728",
      "latitude": "10.76623",
      "promotion": "Tonight only: save 30%",
      "supplierCode": "s007",
      "hotelAddress": "212A/A41 Nguyen Trai, "
    },
    {
      "roomGroup": {
        "totalPrice": "928526.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "202231741",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 10%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "202231741",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 10%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": false,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1588D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "760171",
      "cover": "http://i.travelapi.com/hotels/21000000/20190000/20189000/20188973/f47ea4df_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Ben Thanh Inn Hotel - Hostel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Ben Thanh Inn Hotel - Hostel in Ho Chi Minh City (Dong Khoi), you'll be steps from Saigon River and 3 minutes by foot from Dong Khoi Shopping Street.  …",
      "longitude": "106.70224",
      "latitude": "10.77239",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "51 Huynh Thuc Khang, Ben Nghe, Quan 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "930729.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "200786017",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Private sale: save 10%",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "200786017",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Private sale: save 10%",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "15941",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "475039",
      "cover": "http://i.travelapi.com/hotels/10000000/9080000/9079400/9079395/0e306a1c_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Lily's Hostel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Lily's Hostel in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Bui Vien Walking Street and Pham Ngu Lao Backpacker Area.  This …",
      "longitude": "106.69438",
      "latitude": "10.76759",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "35/5 Bui Vien Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "930729.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room, Private Bathroom",
            "roomCode": "219914231",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "6",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room, Private Bathroom",
            "roomCode": "219914231",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "6",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "15941",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "936118",
      "cover": "http://i.travelapi.com/hotels/26000000/25020000/25012300/25012209/964fa026_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Four of a Kind Hostel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Four of a Kind Hostel in Ho Chi Minh City, you'll be a 3-minute walk from Saigon Culinary Arts Centre and 7 minutes by foot from Pham Ngu Lao …",
      "longitude": "106.68601",
      "latitude": "10.76348",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "214/B14D Nguyen Trai Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "936849.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double Room, Kitchenette",
            "roomCode": "202216869",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double Room, Kitchenette",
            "roomCode": "202216869",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "15B35",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "760937",
      "cover": "http://i.travelapi.com/hotels/21000000/20210000/20205100/20205048/1f4a1439_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "123Smile House",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at 123Smile House in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Pham Ngu Lao Backpacker Area and Bui Vien Walking Street.  This …",
      "longitude": "106.69157",
      "latitude": "10.76672",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "26/50 Bis Do Quang Dau, "
    },
    {
      "roomGroup": {
        "totalPrice": "941256.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "221104522",
            "boardName": "",
            "specialOffer": "Private sale: save 60%",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "221104522",
            "boardName": "",
            "specialOffer": "Private sale: save 60%",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "15C9D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "850901",
      "cover": "http://i.travelapi.com/hotels/23000000/22960000/22956300/22956221/a734bddc_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "New Star Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at New Star Hotel in Ho Chi Minh City (Phu Nhuan), you'll be a 5-minute drive from Jade Emperor Pagoda and 8 minutes from Van Thanh Tourist Park.  This …",
      "longitude": "106.69203",
      "latitude": "10.79662",
      "promotion": "Private sale: save 60%",
      "supplierCode": "s007",
      "hotelAddress": "37L, Duong 11  Mieu Noi, "
    },
    {
      "roomGroup": {
        "totalPrice": "947376.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "200967376",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "200967376",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "15E91",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "503952",
      "cover": "http://i.travelapi.com/hotels/10000000/9630000/9626800/9626714/9626714_26_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Golden Palm Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />When you stay at Golden Palm Hotel in Ho Chi Minh City, you'll be near the airport, within a 10-minute walk of Gia Dinh Park and Parkson CT Plaza.  This hotel is 1.2 …",
      "longitude": "106.67086",
      "latitude": "10.81436",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "33 Bach Dang Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "948355.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard No Breakfast",
            "roomCode": "200124517",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard No Breakfast",
            "roomCode": "200124517",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "15EE1",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "396532",
      "cover": "http://i.travelapi.com/hotels/3000000/2540000/2536300/2536227/090bc3ca_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Saigon Zoom Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Saigon Zoom Hotel places you in the heart of Ho Chi Minh City, steps from Pham Ngu Lao Backpacker Area and Bui Vien Walking Street.  This hotel is 0.4 mi …",
      "longitude": "106.69026",
      "latitude": "10.76512",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "102/1A Cong Quynh Street, District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "948355.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room (No window)",
            "roomCode": "201838005",
            "boardName": "Free Breakfast",
            "specialOffer": "Tonight only: save 55%",
            "availability": "9",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room (No window)",
            "roomCode": "201838005",
            "boardName": "Free Breakfast",
            "specialOffer": "Tonight only: save 55%",
            "availability": "9",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "15EE1",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "577301",
      "cover": "http://i.travelapi.com/hotels/15000000/14740000/14738400/14738360/97588326_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Airport Saigon Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, Airport Saigon Hotel is connected to the airport, a 5-minute drive from Hoang Van Thu Park and 5 minutes from Ho Chi Minh City …",
      "longitude": "106.66321",
      "latitude": "10.79575",
      "promotion": "Tonight only: save 55%",
      "supplierCode": "s007",
      "hotelAddress": "34 Ngo Thi Thu Minh, "
    },
    {
      "roomGroup": {
        "totalPrice": "949824.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Twin Room",
            "roomCode": "218716301",
            "boardName": "Free Breakfast",
            "specialOffer": "Tonight only: save 24%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Twin Room",
            "roomCode": "218716301",
            "boardName": "Free Breakfast",
            "specialOffer": "Tonight only: save 24%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "15F59",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "957744",
      "cover": "http://i.travelapi.com/hotels/27000000/26560000/26551900/26551872/401b18a0_t.jpg",
      "rate": "3.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Asian Kitchen Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Asian Kitchen Hotel in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Pham Ngu Lao Backpacker Area and Bui Vien Walking Street.  …",
      "longitude": "106.69384",
      "latitude": "10.76871",
      "promotion": "Tonight only: save 24%",
      "supplierCode": "s007",
      "hotelAddress": "185/6 Pham Ngu Lao, Quan 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "950558.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room, 1 Double Bed",
            "roomCode": "200233753",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Member’s price: 25%",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room, 1 Double Bed",
            "roomCode": "200233753",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Member’s price: 25%",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "15F95",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "374041",
      "cover": "http://i.travelapi.com/hotels/5000000/4280000/4275000/4274990/fecd756d_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "DDA Hotel District 1",
      "hotelDescription": "<p><b>Property Location</b> <br />Centrally located in Ho Chi Minh City, DDA Hotel District 1 is within a 15-minute walk of Museum of Fine Arts and Ben Thanh Market.  This hotel is 1.5 mi (2.4 km) …",
      "longitude": "106.69396",
      "latitude": "10.7674",
      "promotion": "Member’s price: 25%",
      "supplierCode": "s007",
      "hotelAddress": "183 De Tham St, District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "955944.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room (Windows)",
            "roomCode": "216319278",
            "boardName": "Free Breakfast",
            "specialOffer": "Save 20%",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room (Windows)",
            "roomCode": "216319278",
            "boardName": "Free Breakfast",
            "specialOffer": "Save 20%",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1614D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1032218",
      "cover": "http://i.travelapi.com/hotels/30000000/29470000/29462600/29462571/cd0d4fcb_t.jpg",
      "rate": "1.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Thanh Thuong Guesthouse",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Thanh Thuong Guesthouse in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Pham Ngu Lao Backpacker Area.  This hostel is within …",
      "longitude": "106.69242",
      "latitude": "10.76827",
      "promotion": "Save 20%",
      "supplierCode": "s007",
      "hotelAddress": "241/6 Pham Ngu Lao, "
    },
    {
      "roomGroup": {
        "totalPrice": "958147.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "215415692",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "24",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "215415692",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "24",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "16201",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1031759",
      "cover": "http://i.travelapi.com/hotels/28000000/27930000/27921700/27921639/626d79ab_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Khach San Thien Cung",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, Khach San Thien Cung is convenient to Ho Chi Minh City International Exhibition and Convention Centre and Vietnam People's Air Force …",
      "longitude": "106.64969",
      "latitude": "10.79847",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "69 DUONG A4, P12, Q TAN BINH, "
    },
    {
      "roomGroup": {
        "totalPrice": "958636.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "201144886",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "201144886",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "16229",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "530344",
      "cover": "http://i.travelapi.com/hotels/12000000/11480000/11475500/11475457/11475457_20_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Hoang Le Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, Hoang Le Hotel is within a 15-minute drive of Hoa Binh Market and An Dong Market.  This hotel is 2.4 mi (3.8 km) from Cho Quan Church …",
      "longitude": "106.6737",
      "latitude": "10.73448",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "No 69, Street No 9 Pham Hung, Binh Hung, "
    },
    {
      "roomGroup": {
        "totalPrice": "958636.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room, 1 Queen Bed",
            "roomCode": "218718892",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "6",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room, 1 Queen Bed",
            "roomCode": "218718892",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "6",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "16229",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1000440",
      "cover": "http://i.travelapi.com/hotels/28000000/27210000/27200600/27200532/c0346d3c_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Bin Bin Hotel 3",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Bin Bin Hotel 3 in Ho Chi Minh City (Phu My Hung), you'll be a 5-minute drive from FV Hospital and 6 minutes from The Cresent Mall.  This hotel is 0.7 …",
      "longitude": "106.70869",
      "latitude": "10.73381",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "58 Duong So 2, Tan Phong, Quan 7, "
    },
    {
      "roomGroup": {
        "totalPrice": "958636.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room, 1 Queen Bed",
            "roomCode": "216013986",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room, 1 Queen Bed",
            "roomCode": "216013986",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "16229",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1001316",
      "cover": "http://i.travelapi.com/hotels/28000000/27210000/27200800/27200763/412ce6b1_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Bin Bin Hotel 4",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, Bin Bin Hotel 4 is within a 15-minute drive of FV Hospital and Saigon Paragon Mall.  This hotel is 2 mi (3.2 km) from SC VivoCity and …",
      "longitude": "106.7094",
      "latitude": "10.7464",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "No. 20, Street 11, "
    },
    {
      "roomGroup": {
        "totalPrice": "958636.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Basic Studio, 1 Bedroom, Smoking, Kitchen",
            "roomCode": "216600589",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Basic Studio, 1 Bedroom, Smoking, Kitchen",
            "roomCode": "216600589",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "16229",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "848920",
      "cover": "http://i.travelapi.com/hotels/23000000/22880000/22876100/22876093/cdf81208_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "The Phans Apartment",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, The Phans Apartment is within a 15-minute walk of Parkson CT Plaza and Gia Dinh Park.  This apartment is 1.6 mi (2.6 km) from Vietnam …",
      "longitude": "106.66899",
      "latitude": "10.81017",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "22/36 Yen The, 2, Tan Binh, "
    },
    {
      "roomGroup": {
        "totalPrice": "962064.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Studio, 1 Double Bed, Non Smoking",
            "roomCode": "202461841",
            "boardName": "",
            "specialOffer": "Private sale: save 30%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Studio, 1 Double Bed, Non Smoking",
            "roomCode": "202461841",
            "boardName": "",
            "specialOffer": "Private sale: save 30%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "16341",
        "contractName": ""
      },
      "destinationCode": "TSN",
      "hotelId": "806333",
      "cover": "http://i.travelapi.com/hotels/22000000/21940000/21935500/21935452/66bab8ac_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Tropical House",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Tropical House in Ho Chi Minh City, you'll be 1.5 mi (2.4 km) from War Remnants Museum and 2.3 mi (3.7 km) from Saigon Square.  This aparthotel is 2.4 …",
      "longitude": "106.67543",
      "latitude": "10.78871",
      "promotion": "Private sale: save 30%",
      "supplierCode": "s007",
      "hotelAddress": "413/37 A Le Van Sy, Ward 12, "
    },
    {
      "roomGroup": {
        "totalPrice": "963043.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "200391881",
            "boardName": "Breakfast Buffet",
            "specialOffer": "",
            "availability": "10",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "200391881",
            "boardName": "Breakfast Buffet",
            "specialOffer": "",
            "availability": "10",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "16391",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "444135",
      "cover": "http://i.travelapi.com/hotels/7000000/6630000/6621600/6621589/d33b0505_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Can Gio Resort",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Can Gio Resort in Ho Chi Minh City (Can Gio), you'll be within a 15-minute drive of Can Gio Mangrove Forest and Can Gio Park.  This beach resort is …",
      "longitude": "106.91989",
      "latitude": "10.38674",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "Thanh Thoi, Long Hoa, Can Gio Dist., "
    },
    {
      "roomGroup": {
        "totalPrice": "963043.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "215414803",
            "boardName": "Free Breakfast",
            "specialOffer": "Save 20%",
            "availability": "6",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "215414803",
            "boardName": "Free Breakfast",
            "specialOffer": "Save 20%",
            "availability": "6",
            "boardCode": ""
          }
        ],
        "nonRefundable": false,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "16391",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1019125",
      "cover": "http://i.travelapi.com/hotels/28000000/27590000/27586700/27586608/8c162b64_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Hoang Yen Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Hoang Yen Hotel in Ho Chi Minh City (Phu My Hung), you'll be a 5-minute drive from SC VivoCity and 6 minutes from FV Hospital.  This hotel is 1.1 mi …",
      "longitude": "106.70739",
      "latitude": "10.73332",
      "promotion": "Save 20%",
      "supplierCode": "s007",
      "hotelAddress": "R4 - 62-63-64 Hung gia 2, "
    },
    {
      "roomGroup": {
        "totalPrice": "967449.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room, No Windows",
            "roomCode": "200227511",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Flash sale: save 33%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room, No Windows",
            "roomCode": "200227511",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Flash sale: save 33%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "164F9",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "351507",
      "cover": "http://i.travelapi.com/hotels/4000000/3750000/3743100/3743014/af6a0e68_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Thien Thao Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />Centrally located in Ho Chi Minh City, Thien Thao Hotel is within a 15-minute walk of Quoc Tu Pagoda and Xa Loi Pagoda.  This family-friendly hotel is 1.3 mi (2.1 …",
      "longitude": "106.67965",
      "latitude": "10.77216",
      "promotion": "Flash sale: save 33%",
      "supplierCode": "s007",
      "hotelAddress": "89 Cao Thang street, 3 Ward, 3 District, "
    },
    {
      "roomGroup": {
        "totalPrice": "968184.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "201262091",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "6",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "201262091",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "6",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "16535",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "546607",
      "cover": "http://i.travelapi.com/hotels/13000000/12330000/12329200/12329184/72b292b3_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Hoang Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Hoang Hotel in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Zen Plaza and September 23 Park.  This hotel is 0.4 mi (0.7 km) from …",
      "longitude": "106.69248",
      "latitude": "10.76987",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "5 Nguyen Van Trang St., "
    },
    {
      "roomGroup": {
        "totalPrice": "970142.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room, Private Bathroom",
            "roomCode": "221417429",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room, Private Bathroom",
            "roomCode": "221417429",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "165D5",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "953835",
      "cover": "http://i.travelapi.com/hotels/27000000/26090000/26084400/26084373/0515d113_t.jpg",
      "rate": "1.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Tropical Vibes Homestay in Sai Gon - Hostel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Tropical Vibes Homestay in Sai Gon - Hostel in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be a 4-minute walk from Pham Ngu Lao Backpacker …",
      "longitude": "106.68568",
      "latitude": "10.76759",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "189B/A2 Cong Quynh street, "
    },
    {
      "roomGroup": {
        "totalPrice": "977731.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Triple Room",
            "roomCode": "202329906",
            "boardName": "",
            "specialOffer": "Tonight only: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Triple Room",
            "roomCode": "202329906",
            "boardName": "",
            "specialOffer": "Tonight only: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "16841",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "791687",
      "cover": "http://i.travelapi.com/hotels/22000000/21410000/21403600/21403510/b31bafd5_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Laverne Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Laverne Hotel in Ho Chi Minh City, you'll be within a 15-minute drive of Jade Emperor Pagoda and Southern Vietnam Women Museum.  This hotel is 2 mi …",
      "longitude": "106.69411",
      "latitude": "10.80578",
      "promotion": "Tonight only: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "5/24 No Trang Long Street, Ward 7, "
    },
    {
      "roomGroup": {
        "totalPrice": "977731.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "215709409",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "215709409",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "16841",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "944336",
      "cover": "http://i.travelapi.com/hotels/26000000/25150000/25144500/25144414/939db3af_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Hong Ha Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Hong Ha Hotel in Ho Chi Minh City, you'll be a 2-minute walk from Xa Loi Pagoda and 10 minutes by foot from The Most Holy Redeemer Saigon.  This hotel …",
      "longitude": "106.68582",
      "latitude": "10.77689",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "27B Nguyen Thong street, "
    },
    {
      "roomGroup": {
        "totalPrice": "977731.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Room, No Windows",
            "roomCode": "216313789",
            "boardName": "",
            "specialOffer": "Tonight only: save 40%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Room, No Windows",
            "roomCode": "216313789",
            "boardName": "",
            "specialOffer": "Tonight only: save 40%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "16841",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1021263",
      "cover": "http://i.travelapi.com/hotels/28000000/27210000/27207900/27207831/4237fd72_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Urban Saigon Homestay",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Urban Saigon Homestay in Ho Chi Minh City, you'll be within a 15-minute walk of Dong Khoi Shopping Street and Diamond Plaza.  This guesthouse is 0.6 …",
      "longitude": "106.69944",
      "latitude": "10.78577",
      "promotion": "Tonight only: save 40%",
      "supplierCode": "s007",
      "hotelAddress": "Hem 18bis Nguyen Thi Minh Khai St, Dis 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "979444.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room (with View)",
            "roomCode": "201234660",
            "boardName": "Free Breakfast",
            "specialOffer": "Member’s price: 60%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room (with View)",
            "roomCode": "201234660",
            "boardName": "Free Breakfast",
            "specialOffer": "Member’s price: 60%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "168CD",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "542603",
      "cover": "http://i.travelapi.com/hotels/13000000/12030000/12022100/12022035/f27f4224_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Rosabella Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Rosabella Hotel places you in the heart of Ho Chi Minh City, steps from Bui Vien Walking Street and Pham Ngu Lao Backpacker Area.  This hotel is 0.5 mi …",
      "longitude": "106.69176",
      "latitude": "10.76641",
      "promotion": "Member’s price: 60%",
      "supplierCode": "s007",
      "hotelAddress": "196 Bui Vien Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "982382.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room, City View",
            "roomCode": "200948422",
            "boardName": "Free Breakfast",
            "specialOffer": "Book now and save!",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room, City View",
            "roomCode": "200948422",
            "boardName": "Free Breakfast",
            "specialOffer": "Book now and save!",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "169BD",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "500447",
      "cover": "http://i.travelapi.com/hotels/10000000/9630000/9625300/9625249/45d7fb57_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Thanh Truong Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Thanh Truong Hotel in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Temple of Mariamman and 3 minutes by foot from Ben Thanh …",
      "longitude": "106.69631",
      "latitude": "10.77171",
      "promotion": "Book now and save!",
      "supplierCode": "s007",
      "hotelAddress": "19-21A Truong Dinh Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "988502.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "216317724",
            "boardName": "",
            "specialOffer": "Flash sale: save 30%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "216317724",
            "boardName": "",
            "specialOffer": "Flash sale: save 30%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "16BB1",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1019845",
      "cover": "http://i.travelapi.com/hotels/29000000/28950000/28942100/28942027/a581782a_t.jpg",
      "rate": "3.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Kadupul Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City (Go Vap), Kadupul Hotel is convenient to Gia Dinh Park and Parkson CT Plaza.  This hotel is within close proximity of Hoang Van Thu Park …",
      "longitude": "106.68368",
      "latitude": "10.82045",
      "promotion": "Flash sale: save 30%",
      "supplierCode": "s007",
      "hotelAddress": "212-214 Nguyen Thai Son, "
    },
    {
      "roomGroup": {
        "totalPrice": "995601.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "202132520",
            "boardName": "Free Breakfast",
            "specialOffer": "Save53%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "202132520",
            "boardName": "Free Breakfast",
            "specialOffer": "Save53%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "16DF5",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "732629",
      "cover": "http://i.travelapi.com/hotels/20000000/19650000/19641300/19641289/7c211483_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Hoan Thai Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Hoan Thai Hotel in Ho Chi Minh City (Bui Thi Xuan), you'll be within a 10-minute walk of September 23 Park and Pham Ngu Lao Backpacker Area.  This …",
      "longitude": "106.68855",
      "latitude": "10.77029",
      "promotion": "Save53%",
      "supplierCode": "s007",
      "hotelAddress": "82 Ton That Tung, Quan 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "996091.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "201725453",
            "boardName": "",
            "specialOffer": "",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "201725453",
            "boardName": "",
            "specialOffer": "",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "16E1D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "637127",
      "cover": "http://i.travelapi.com/hotels/17000000/16430000/16422800/16422760/bcddd7d7_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "K Central Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at K Central Hotel in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Benthanh Street Food Market and 3 minutes by foot from Ben Thanh …",
      "longitude": "106.69775",
      "latitude": "10.77338",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "160 Le Thanh Ton, "
    },
    {
      "roomGroup": {
        "totalPrice": "996091.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room, 1 Double Bed, Refrigerator",
            "roomCode": "219320164",
            "boardName": "",
            "specialOffer": "Save 20%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room, 1 Double Bed, Refrigerator",
            "roomCode": "219320164",
            "boardName": "",
            "specialOffer": "Save 20%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "16E1D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1011704",
      "cover": "http://i.travelapi.com/hotels/28000000/27420000/27415500/27415423/b6f62544_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Watage",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Watage in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be within a 10-minute walk of Ben Thanh Market and Bui Vien Walking Street.  This …",
      "longitude": "106.6948",
      "latitude": "10.77221",
      "promotion": "Save 20%",
      "supplierCode": "s007",
      "hotelAddress": "253 Ly Tu Trong street, District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "999518.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "215700717",
            "boardName": "Free Breakfast",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "215700717",
            "boardName": "Free Breakfast",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "16F35",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "833399",
      "cover": "http://i.travelapi.com/hotels/23000000/22640000/22630800/22630708/c21173f9_t.jpg",
      "rate": "1.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Ngoc Phan Guest House",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Ngoc Phan Guest House in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Pham Ngu Lao Backpacker Area and Bui Vien Walking Street.  …",
      "longitude": "106.69375",
      "latitude": "10.76686",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "35/12 Bui Vien, "
    },
    {
      "roomGroup": {
        "totalPrice": "1026446.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Studio, Balcony",
            "roomCode": "216913791",
            "boardName": "",
            "specialOffer": "Save 10%",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Studio, Balcony",
            "roomCode": "216913791",
            "boardName": "",
            "specialOffer": "Save 10%",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "177CD",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1000487",
      "cover": "http://i.travelapi.com/hotels/28000000/27170000/27169900/27169877/5555e9b6_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Melody Apartment",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Melody Apartment in Ho Chi Minh City (Phu My Hung), you'll be a 5-minute drive from SC VivoCity and 6 minutes from FV Hospital.  This aparthotel is …",
      "longitude": "106.70691",
      "latitude": "10.73337",
      "promotion": "Save 10%",
      "supplierCode": "s007",
      "hotelAddress": "46 Hung Gia 2, "
    },
    {
      "roomGroup": {
        "totalPrice": "1026446.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "202439571",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "202439571",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "177CD",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "812521",
      "cover": "http://i.travelapi.com/hotels/23000000/22190000/22185100/22185032/77a51376_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Sai Gon Park Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Sai Gon Park Hotel in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Zen Plaza and 2 minutes by foot from September 23 Park.  This …",
      "longitude": "106.69225",
      "latitude": "10.77017",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "27 Nguyen Van Trang Ben Thanh Ward, "
    },
    {
      "roomGroup": {
        "totalPrice": "1027180.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Twin Room (With Window)",
            "roomCode": "200459210",
            "boardName": "",
            "specialOffer": "Private sale: save 20%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Twin Room (With Window)",
            "roomCode": "200459210",
            "boardName": "",
            "specialOffer": "Private sale: save 20%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "17809",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "446333",
      "cover": "http://i.travelapi.com/hotels/8000000/7090000/7081000/7080984/c57e938a_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Anh Duy Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Anh Duy Hotel places you in the heart of Ho Chi Minh City, steps from Saigon River and 3 minutes by foot from Riverside.  This hotel is 0.3 mi (0.4 km) …",
      "longitude": "106.70244",
      "latitude": "10.76936",
      "promotion": "Private sale: save 20%",
      "supplierCode": "s007",
      "hotelAddress": "103 Nguyen Cong Tru St, District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "1031832.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "200149372",
            "boardName": "Continental Breakfast",
            "specialOffer": "",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "200149372",
            "boardName": "Continental Breakfast",
            "specialOffer": "",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "17985",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "403238",
      "cover": "http://i.travelapi.com/hotels/5000000/4940000/4936400/4936355/08be0254_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Nam Long Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Nam Long Hotel places you in the heart of Ho Chi Minh City, steps from Pham Ngu Lao Backpacker Area and Bui Vien Walking Street.  This hotel is 0.5 mi (0.8 …",
      "longitude": "106.69241",
      "latitude": "10.76827",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "283/3 Pham Ngu Lao Str, "
    },
    {
      "roomGroup": {
        "totalPrice": "1032076.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Apartment",
            "roomCode": "201912397",
            "boardName": "",
            "specialOffer": "",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Apartment",
            "roomCode": "201912397",
            "boardName": "",
            "specialOffer": "",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "17999",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "682464",
      "cover": "http://i.travelapi.com/hotels/18000000/17950000/17940600/17940556/d20055b7_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "An Nhien Hotel Apartment",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at An Nhien Hotel Apartment, you'll be centrally located in Ho Chi Minh City, within a 10-minute drive of Van Thanh Tourist Park and Jade Emperor Pagoda. …",
      "longitude": "106.7181",
      "latitude": "10.80623",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "168/67 D2 Street, Ward 25, "
    },
    {
      "roomGroup": {
        "totalPrice": "1041134.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "202052618",
            "boardName": "Free Breakfast",
            "specialOffer": "",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "202052618",
            "boardName": "Free Breakfast",
            "specialOffer": "",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "17C7D",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "713007",
      "cover": "http://i.travelapi.com/hotels/20000000/19140000/19132000/19131901/b1d30880_t.jpg",
      "rate": "1.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Saigoneer Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Saigoneer Hotel in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Pham Ngu Lao Backpacker Area and 4 minutes by foot from Bui Vien …",
      "longitude": "106.69124",
      "latitude": "10.76782",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "283/2 Pham Ngu Lao, Quan 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "1050436.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double with window",
            "roomCode": "201404107",
            "boardName": "Free Breakfast",
            "specialOffer": "Last minute deal: save 60%",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double with window",
            "roomCode": "201404107",
            "boardName": "Free Breakfast",
            "specialOffer": "Last minute deal: save 60%",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "17F75",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "568435",
      "cover": "http://i.travelapi.com/hotels/14000000/13340000/13336000/13335963/086c7d85_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Quy Hung Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Quy Hung Hotel, you'll be centrally located in Ho Chi Minh City, just a 4-minute walk from Museum of Fine Arts and 5 minutes by foot from Ben Thanh …",
      "longitude": "106.69773",
      "latitude": "10.76981",
      "promotion": "Last minute deal: save 60%",
      "supplierCode": "s007",
      "hotelAddress": "20 Dang Thi Nhu, Nguyen Thai Binh Ward, "
    },
    {
      "roomGroup": {
        "totalPrice": "1052884.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Saigon Image Superior",
            "roomCode": "211502431",
            "boardName": "Free Breakfast",
            "specialOffer": "Member’s price: 55%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Saigon Image Superior",
            "roomCode": "211502431",
            "boardName": "Free Breakfast",
            "specialOffer": "Member’s price: 55%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1803D",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "419741",
      "cover": "http://i.travelapi.com/hotels/6000000/5440000/5434900/5434810/cb126139_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Saigon Charm Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Saigon Charm Hotel in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be minutes from Benthanh Street Food Market and Temple of Mariamman.  This …",
      "longitude": "106.69659",
      "latitude": "10.77355",
      "promotion": "Member’s price: 55%",
      "supplierCode": "s007",
      "hotelAddress": "153 Ly Tu Trong, Ben Thanh Ward, "
    },
    {
      "roomGroup": {
        "totalPrice": "1055822.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "202116031",
            "boardName": "",
            "specialOffer": "Flash sale: save 30%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "202116031",
            "boardName": "",
            "specialOffer": "Flash sale: save 30%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1812D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "730806",
      "cover": "http://i.travelapi.com/hotels/20000000/19550000/19540700/19540700/4ed344f7_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Vivian Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Vivian Hotel in Ho Chi Minh City, you'll be a 3-minute walk from Vietnam People's Air Force Museum and 14 minutes by foot from Parkson CT Plaza.  This …",
      "longitude": "106.66159",
      "latitude": "10.8072",
      "promotion": "Flash sale: save 30%",
      "supplierCode": "s007",
      "hotelAddress": "94-96 Thang Long, Phuong 4, "
    },
    {
      "roomGroup": {
        "totalPrice": "1059004.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Studio, No View",
            "roomCode": "210012456",
            "boardName": "",
            "specialOffer": "",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Studio, No View",
            "roomCode": "210012456",
            "boardName": "",
            "specialOffer": "",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "18231",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1030285",
      "cover": "http://i.travelapi.com/hotels/28000000/27500000/27494300/27494234/02c79c98_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Paragon Saigon Serviced Apartment",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Paragon Saigon Serviced Apartment in Ho Chi Minh City (Hang Xanh), you'll be convenient to Van Thanh Tourist Park and Vincom Mega Mall.  This …",
      "longitude": "106.72107",
      "latitude": "10.80254",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "178/33B duong D1, P.25, Q. Binh Thanh, "
    },
    {
      "roomGroup": {
        "totalPrice": "1060228.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "201669320",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Save 54%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "201669320",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Save 54%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "18295",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "447424",
      "cover": "http://i.travelapi.com/hotels/8000000/7250000/7240600/7240563/1a7c5a3b_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Lien Thanh Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Lien Thanh Hotel in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Temple of Mariamman and 5 minutes by foot from Benthanh Street …",
      "longitude": "106.69508",
      "latitude": "10.77216",
      "promotion": "Save 54%",
      "supplierCode": "s007",
      "hotelAddress": "39 Le Anh Xuan, District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "1065124.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "One Bedroom Apartment",
            "roomCode": "200781239",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "One Bedroom Apartment",
            "roomCode": "200781239",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "18425",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "474323",
      "cover": "http://i.travelapi.com/hotels/10000000/9050000/9045700/9045615/84b2b960_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "HAD Apartment - Nguyen Dinh Chinh",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at HAD Apartment - Nguyen Dinh Chinh in Ho Chi Minh City (Phu Nhuan), you'll be within a 10-minute drive of Hoang Van Thu Park and Southern Vietnam Women …",
      "longitude": "106.67779",
      "latitude": "10.7949",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "133C Nguyen Dinh Chinh, "
    },
    {
      "roomGroup": {
        "totalPrice": "1068062.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "City Triple Room",
            "roomCode": "201994370",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "City Triple Room",
            "roomCode": "201994370",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "18515",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "646287",
      "cover": "http://i.travelapi.com/hotels/17000000/16740000/16730200/16730110/cf0c7c1f_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Quang Guest House",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Quang Guest House in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Pham Ngu Lao Backpacker Area and Bui Vien Walking Street.  …",
      "longitude": "106.69441",
      "latitude": "10.76776",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "40/7 Bui Vien, "
    },
    {
      "roomGroup": {
        "totalPrice": "1080302.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Luxury Double Room, Shared Bathroom",
            "roomCode": "220202047",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Luxury Double Room, Shared Bathroom",
            "roomCode": "220202047",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "188FD",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "837824",
      "cover": "http://i.travelapi.com/hotels/23000000/22690000/22680400/22680318/b888dd8c_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "My Duc Luxury Apartment I",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at My Duc Luxury Apartment I in Ho Chi Minh City (Hang Xanh), you'll be a 3-minute drive from Van Thanh Tourist Park and 7 minutes from Jade Emperor …",
      "longitude": "106.71113",
      "latitude": "10.79855",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "220 Xo Viet Nghe Tinh, "
    },
    {
      "roomGroup": {
        "totalPrice": "1086422.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Bed",
            "roomCode": "200357715",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Bed",
            "roomCode": "200357715",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "18AF1",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "441693",
      "cover": "http://i.travelapi.com/hotels/7000000/6640000/6632600/6632519/d2c3f849_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Boss 3 Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Boss 3 Hotel places you in the heart of Ho Chi Minh City, steps from Museum of Fine Arts and 4 minutes by foot from Ben Thanh Market.  This hotel is 0.2 mi …",
      "longitude": "106.69979",
      "latitude": "10.76968",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "14 Pho Duc Chinh, District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "1086422.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double Room",
            "roomCode": "216617421",
            "boardName": "",
            "specialOffer": "",
            "availability": "8",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double Room",
            "roomCode": "216617421",
            "boardName": "",
            "specialOffer": "",
            "availability": "8",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "18AF1",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1006711",
      "cover": "http://i.travelapi.com/hotels/28000000/27800000/27791900/27791804/bbf0083d_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "RedDoorz Plus near SECC D7",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at RedDoorz Plus near SECC D7 in Ho Chi Minh City (Phu My Hung), you'll be convenient to SC VivoCity and FV Hospital.  This apartment is within close …",
      "longitude": "106.70885",
      "latitude": "10.73243",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "05-07 Phan Kiem Ich, "
    },
    {
      "roomGroup": {
        "totalPrice": "1097928.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room Single Use",
            "roomCode": "202190823",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "15",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room Single Use",
            "roomCode": "202190823",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "15",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "18E9D",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "430295",
      "cover": "http://i.travelapi.com/hotels/7000000/6010000/6004400/6004314/0771ddcf_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Rainbow Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, Rainbow Hotel is within a 5-minute drive of An Dong Market and Cho Quan Church.  This hotel is 1 mi (1.6 km) from Thong Nhat Stadium and …",
      "longitude": "106.67188",
      "latitude": "10.75593",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "41-43 Nguyen Duy Duong Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "1101110.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "218703718",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 10%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "218703718",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 10%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "18FA1",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "874640",
      "cover": "http://i.travelapi.com/hotels/24000000/23340000/23334000/23333990/c6220fb7_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "City Backpackers Hostel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at City Backpackers Hostel in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Zen Plaza and 4 minutes by foot from September 23 Park.  …",
      "longitude": "106.69306",
      "latitude": "10.77071",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "7/1 Nguyen Trai street, District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "1107230.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "VIP Room, Balcony",
            "roomCode": "215402156",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "VIP Room, Balcony",
            "roomCode": "215402156",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "19195",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "859526",
      "cover": "http://i.travelapi.com/hotels/24000000/23120000/23116400/23116322/fe839cbe_t.jpg",
      "rate": "1.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Thadico 2 Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Thadico 2 Hotel in Ho Chi Minh City (Thu Thiem), you'll be within a 10-minute drive of Vincom Mega Mall and Van Thanh Tourist Park.  This hotel is 3.5 …",
      "longitude": "106.73081",
      "latitude": "10.79791",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "35/7 Duong 19, Tran Nao, "
    },
    {
      "roomGroup": {
        "totalPrice": "1108209.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "202025229",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 10%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "202025229",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 10%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "191E5",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "705041",
      "cover": "http://i.travelapi.com/hotels/19000000/18830000/18821900/18821826/6fe4feb1_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Torino Hotel Boutique",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City (Phu My Hung), Torino Hotel Boutique is within a 5-minute drive of FV Hospital and The Cresent Mall.  This guesthouse is 0.8 mi (1.2 km) …",
      "longitude": "106.70924",
      "latitude": "10.73381",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "No. 25 Duong So 2, Hung Gia 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "1108209.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "221723819",
            "boardName": "",
            "specialOffer": "Tonight only: save 28%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "221723819",
            "boardName": "",
            "specialOffer": "Tonight only: save 28%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "191E5",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1026846",
      "cover": "http://i.travelapi.com/hotels/30000000/29150000/29145000/29144991/a1412814_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Calmette Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, Calmette Hotel is minutes from Museum of Fine Arts and Ben Thanh Market.  This hotel is within close proximity of Temple of Mariamman …",
      "longitude": "106.69815",
      "latitude": "10.76905",
      "promotion": "Tonight only: save 28%",
      "supplierCode": "s007",
      "hotelAddress": "151 Calmette street,, "
    },
    {
      "roomGroup": {
        "totalPrice": "1108209.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "216002535",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "216002535",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "191E5",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "867247",
      "cover": "http://i.travelapi.com/hotels/24000000/23200000/23198400/23198330/c570947f_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Song Anh Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Song Anh Hotel in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Zen Plaza and 3 minutes by foot from September 23 Park.  This …",
      "longitude": "106.69237",
      "latitude": "10.77062",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "47A Nguyen Trai street, "
    },
    {
      "roomGroup": {
        "totalPrice": "1114819.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Private Room",
            "roomCode": "202095815",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Private Room",
            "roomCode": "202095815",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "19401",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "724001",
      "cover": "http://i.travelapi.com/hotels/20000000/19410000/19409900/19409896/729f6ad9_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Supe Homestay - Hostel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Supe Homestay - Hostel in Ho Chi Minh City, you'll be within a 10-minute walk of Pham Ngu Lao Backpacker Area and Bui Vien Walking Street.  This …",
      "longitude": "106.69318",
      "latitude": "10.7633",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "53/2 Nguyen Khac Nhu, Phuong Co Giang, "
    },
    {
      "roomGroup": {
        "totalPrice": "1114819.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Shared Dormitory, Non Smoking",
            "roomCode": "217216316",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 40%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Shared Dormitory, Non Smoking",
            "roomCode": "217216316",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 40%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "19401",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "1020149",
      "cover": "http://i.travelapi.com/hotels/28000000/27930000/27928300/27928282/6b4b55c9_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Scenic Valley Apartment & Hostel -SABINA",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Scenic Valley Apartment & Hostel -SABINA in Ho Chi Minh City (Phu My Hung), you'll be minutes from The Cresent Mall and FV Hospital.  This hostel is …",
      "longitude": "106.71753",
      "latitude": "10.73001",
      "promotion": "Private sale: save 40%",
      "supplierCode": "s007",
      "hotelAddress": "808 Nguyen Van Linh, Scenic valley, "
    },
    {
      "roomGroup": {
        "totalPrice": "1115308.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "200313515",
            "boardName": "Free Breakfast",
            "specialOffer": "Special deal: save 20%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "200313515",
            "boardName": "Free Breakfast",
            "specialOffer": "Special deal: save 20%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "19429",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "435545",
      "cover": "http://i.travelapi.com/hotels/7000000/6290000/6282300/6282300/c6aa51b7_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Gia Huy Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Gia Huy Hotel places you in the heart of Ho Chi Minh City, steps from Temple of Mariamman and 3 minutes by foot from Ben Thanh Market.  This hotel is 0.3 …",
      "longitude": "106.6966",
      "latitude": "10.77162",
      "promotion": "Special deal: save 20%",
      "supplierCode": "s007",
      "hotelAddress": "26 Nguyen An Ninh, "
    },
    {
      "roomGroup": {
        "totalPrice": "1119225.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Junior Studio, 1 Bedroom, Accessible, City View",
            "roomCode": "216612150",
            "boardName": "",
            "specialOffer": "Member’s price: 15%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Junior Studio, 1 Bedroom, Accessible, City View",
            "roomCode": "216612150",
            "boardName": "",
            "specialOffer": "Member’s price: 15%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "19569",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "970879",
      "cover": "http://i.travelapi.com/hotels/27000000/26950000/26949900/26949829/ecbc4f71_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Saigon Q Apartment",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Saigon Q Apartment in Ho Chi Minh City, you'll be within a 10-minute walk of Pham Ngu Lao Backpacker Area and Bui Vien Walking Street.  This apartment …",
      "longitude": "106.69557",
      "latitude": "10.76597",
      "promotion": "Member’s price: 15%",
      "supplierCode": "s007",
      "hotelAddress": "135/44 Tran Hung Dao, "
    },
    {
      "roomGroup": {
        "totalPrice": "1122897.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Comfort Shared Dormitory, Men only, Private Pool, City View",
            "roomCode": "219316144",
            "boardName": "",
            "specialOffer": "Flash sale: save 21%",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Comfort Shared Dormitory, Men only, Private Pool, City View",
            "roomCode": "219316144",
            "boardName": "",
            "specialOffer": "Flash sale: save 21%",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "19695",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "963321",
      "cover": "http://i.travelapi.com/hotels/27000000/26720000/26712600/26712551/1e956263_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Travelaholic's Homestay",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Travelaholic's Homestay in Ho Chi Minh City (Hang Xanh), you'll be within a 10-minute drive of Van Thanh Tourist Park and Vincom Mega Mall.  This …",
      "longitude": "106.71871",
      "latitude": "10.79541",
      "promotion": "Flash sale: save 21%",
      "supplierCode": "s007",
      "hotelAddress": "208 Nguyen Huu Canh, "
    },
    {
      "roomGroup": {
        "totalPrice": "1124366.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Twin Room",
            "roomCode": "202052627",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Twin Room",
            "roomCode": "202052627",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1970D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "712575",
      "cover": "http://i.travelapi.com/hotels/20000000/19130000/19120300/19120242/54b8b186_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Ace Home Viet Nam",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Ace Home Viet Nam in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Pham Ngu Lao Backpacker Area and Bui Vien Walking Street.  …",
      "longitude": "106.68968",
      "latitude": "10.76633",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "180 Cong Quynh Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "1127304.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "200467761",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Tonight only: save 45%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "200467761",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Tonight only: save 45%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "197FD",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "446948",
      "cover": "http://i.travelapi.com/hotels/8000000/7180000/7170800/7170713/b4743f99_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Happy Life Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, Happy Life Hotel is a 4-minute drive from Phu My Bridge and 6 minutes from FV Hospital.  This hotel is 1.4 mi (2.3 km) from Saigon …",
      "longitude": "106.73008",
      "latitude": "10.73758",
      "promotion": "Tonight only: save 45%",
      "supplierCode": "s007",
      "hotelAddress": "542 - 544 Huynh Tan Phat Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "1132444.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Shared Dormitory, Mixed Dorm",
            "roomCode": "201978430",
            "boardName": "",
            "specialOffer": "Private sale: save 3%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Shared Dormitory, Mixed Dorm",
            "roomCode": "201978430",
            "boardName": "",
            "specialOffer": "Private sale: save 3%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "199A1",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "694209",
      "cover": "http://i.travelapi.com/hotels/19000000/18410000/18407400/18407382/94340490_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Chy Chy Saigon Hostel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Chy Chy Saigon Hostel in Ho Chi Minh City, you'll be a 5-minute walk from Pham Ngu Lao Backpacker Area and 6 minutes by foot from Bui Vien Walking …",
      "longitude": "106.69544",
      "latitude": "10.76546",
      "promotion": "Private sale: save 3%",
      "supplierCode": "s007",
      "hotelAddress": "48 Co Bac Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "1137096.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Comfort Double Room",
            "roomCode": "202122390",
            "boardName": "Free Breakfast",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Comfort Double Room",
            "roomCode": "202122390",
            "boardName": "Free Breakfast",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "19B1D",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "724761",
      "cover": "http://i.travelapi.com/hotels/20000000/19430000/19428800/19428755/ea1bd1e5_t.jpg",
      "rate": "1.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "BohoLand Hostel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at BohoLand Hostel  places you in the heart of Ho Chi Minh City, steps from September 23 Park and 3 minutes by foot from Zen Plaza.  This hostel is 0.6 mi …",
      "longitude": "106.69143",
      "latitude": "10.76949",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "95/14 Nguyen Trai Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "1140523.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "216613089",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "216613089",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": false,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "19C35",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "978671",
      "cover": "http://i.travelapi.com/hotels/28000000/27040000/27039900/27039858/5031db72_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Thien Truong Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Thien Truong Hotel in Ho Chi Minh City, you'll be within a 15-minute walk of The Most Holy Redeemer Saigon and Ear Nose Throat Hospital.  This hotel …",
      "longitude": "106.67917",
      "latitude": "10.77991",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "28 Rach Bung Binh, "
    },
    {
      "roomGroup": {
        "totalPrice": "1140523.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "200825882",
            "boardName": "Full Breakfast",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "200825882",
            "boardName": "Full Breakfast",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "19C35",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "480290",
      "cover": "http://i.travelapi.com/hotels/10000000/9420000/9412700/9412641/9412641_48_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Saigon's Book Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />When you stay at Saigon's Book Hotel in Ho Chi Minh City, you'll be near the airport, within a 10-minute walk of Vietnam People's Air Force Museum and Parkson CT …",
      "longitude": "106.66452",
      "latitude": "10.80725",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "15A Truong Son St, Ward 4, Tan Binh Dist, "
    },
    {
      "roomGroup": {
        "totalPrice": "1140523.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Studio Apartment",
            "roomCode": "202118389",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Studio Apartment",
            "roomCode": "202118389",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "19C35",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "724384",
      "cover": "http://i.travelapi.com/hotels/20000000/19420000/19416500/19416409/e6927625_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Supe Homestay Nguyen Thi Minh Khai",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Supe Homestay Nguyen Thi Minh Khai in Ho Chi Minh City, you'll be within a 15-minute walk of Dong Khoi Shopping Street and Diamond Plaza.  This …",
      "longitude": "106.69973",
      "latitude": "10.78553",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "12/4B Nguyen Thi Minh Khai, P Da Kao, "
    },
    {
      "roomGroup": {
        "totalPrice": "1140523.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double Room",
            "roomCode": "216618237",
            "boardName": "",
            "specialOffer": "",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double Room",
            "roomCode": "216618237",
            "boardName": "",
            "specialOffer": "",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "19C35",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1019809",
      "cover": "http://i.travelapi.com/hotels/30000000/29080000/29070200/29070174/3cf4c38c_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "RedDoorz near SC Vivocity Mall 2",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at RedDoorz near SC Vivocity Mall 2 in Ho Chi Minh City (Phu My Hung), you'll be convenient to SC VivoCity and FV Hospital.  This hotel is within close …",
      "longitude": "106.7074",
      "latitude": "10.73387",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "R4-53 Hung Gia 5, Phu My Hung,, "
    },
    {
      "roomGroup": {
        "totalPrice": "1140523.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Family Room",
            "roomCode": "216015937",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Family Room",
            "roomCode": "216015937",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "19C35",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1006774",
      "cover": "http://i.travelapi.com/hotels/28000000/27740000/27730700/27730678/56fe582c_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Green Ruby Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Green Ruby Hotel in Ho Chi Minh City, you'll be minutes from Parkson CT Plaza and close to Vietnam People's Air Force Museum.  This hotel is within …",
      "longitude": "106.66654",
      "latitude": "10.81092",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "25/15 Cuu Long, Ward 2, Tan Binh, "
    },
    {
      "roomGroup": {
        "totalPrice": "1149825.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Twin Room, 2 Twin Beds, City View",
            "roomCode": "201665208",
            "boardName": "Free Breakfast",
            "specialOffer": "",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Twin Room, 2 Twin Beds, City View",
            "roomCode": "201665208",
            "boardName": "Free Breakfast",
            "specialOffer": "",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "19F2D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "623748",
      "cover": "http://i.travelapi.com/hotels/17000000/16050000/16049700/16049695/efc4c165_t.jpg",
      "rate": "1.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Kim Khoi hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Kim Khoi hotel in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Pham Ngu Lao Backpacker Area and Bui Vien Walking Street.  This …",
      "longitude": "106.69397",
      "latitude": "10.76879",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "181 Pham Ngu Lao, "
    },
    {
      "roomGroup": {
        "totalPrice": "1164024.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Scandinavian Double",
            "roomCode": "201389864",
            "boardName": "Full Breakfast",
            "specialOffer": "Member’s price: 25%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Scandinavian Double",
            "roomCode": "201389864",
            "boardName": "Full Breakfast",
            "specialOffer": "Member’s price: 25%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1A3B5",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "441310",
      "cover": "http://i.travelapi.com/hotels/7000000/6570000/6564600/6564595/3fd87565_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "LeBlanc Saigon",
      "hotelDescription": "<p><b>Property Location</b> <br />You'll be centrally located in Ho Chi Minh City with a stay at LeBlanc Saigon, within a 15-minute walk of Tao Dan Park and War Remnants Museum.  This hotel is 0.9 mi …",
      "longitude": "106.68519",
      "latitude": "10.77334",
      "promotion": "Member’s price: 25%",
      "supplierCode": "s007",
      "hotelAddress": "414 Nguyen Dinh Chieu Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "1165492.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room, 1 Queen Bed, No Windows",
            "roomCode": "213902795",
            "boardName": "Free Breakfast",
            "specialOffer": "Member’s price: 35%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room, 1 Queen Bed, No Windows",
            "roomCode": "213902795",
            "boardName": "Free Breakfast",
            "specialOffer": "Member’s price: 35%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1A42D",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "371456",
      "cover": "http://i.travelapi.com/hotels/5000000/4220000/4218700/4218697/0ed5551e_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Good Vibes Central Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at  Shambala saigon hotel places you in the heart of Ho Chi Minh City, steps from Temple of Mariamman and 4 minutes by foot from Benthanh Street Food Market.  …",
      "longitude": "106.69543",
      "latitude": "10.7717",
      "promotion": "Member’s price: 35%",
      "supplierCode": "s007",
      "hotelAddress": "277 Le Thanh Ton, Ben Thanh Ward, Dist1, "
    },
    {
      "roomGroup": {
        "totalPrice": "1165982.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "210005502",
            "boardName": "",
            "specialOffer": "Flash sale: save 20%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "210005502",
            "boardName": "",
            "specialOffer": "Flash sale: save 20%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1A455",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "922625",
      "cover": "http://i.travelapi.com/hotels/25000000/24410000/24401600/24401558/cdf6b1bb_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "HoLo Garcerie Saigon Serviced HomeStay",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, HoLo Garcerie Saigon Serviced HomeStay is minutes from Southern Vietnam Women Museum and War Remnants Museum.  This aparthotel is within …",
      "longitude": "106.69162",
      "latitude": "10.78661",
      "promotion": "Flash sale: save 20%",
      "supplierCode": "s007",
      "hotelAddress": "80-82 Pham Ngoc Thach, "
    },
    {
      "roomGroup": {
        "totalPrice": "1166961.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "200372617",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Private sale: save 55%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "200372617",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Private sale: save 55%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1A4A5",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "441644",
      "cover": "http://i.travelapi.com/hotels/7000000/6650000/6641300/6641263/7923c754_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "A25 Hotel - 13 Bui Thi Xuan",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at A25 Hotel - 13 Bui Thi Xuan places you in the heart of Ho Chi Minh City, within a 10-minute walk of Tao Dan Park and Zen Plaza.  This hotel is 0.4 mi (0.7 …",
      "longitude": "106.69039",
      "latitude": "10.77191",
      "promotion": "Private sale: save 55%",
      "supplierCode": "s007",
      "hotelAddress": "13 Bui Thi Xuan, Ben Thanh Ward, "
    },
    {
      "roomGroup": {
        "totalPrice": "1176998.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double Room",
            "roomCode": "219316385",
            "boardName": "Free Breakfast",
            "specialOffer": "Save 35%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double Room",
            "roomCode": "219316385",
            "boardName": "Free Breakfast",
            "specialOffer": "Save 35%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1A7D9",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "948947",
      "cover": "http://i.travelapi.com/hotels/26000000/25740000/25738700/25738648/c1ddcf69_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Gu Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Gu Hotel in Ho Chi Minh City, you'll be within a 5-minute walk of Pham Ngu Lao Backpacker Area and Bui Vien Walking Street.  This hotel is 0.2 mi (0.4 …",
      "longitude": "106.69743",
      "latitude": "10.76934",
      "promotion": "Save 35%",
      "supplierCode": "s007",
      "hotelAddress": "21 Dang Thi Nhu street,, "
    },
    {
      "roomGroup": {
        "totalPrice": "1177243.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "200666958",
            "boardName": "",
            "specialOffer": "",
            "availability": "6",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "200666958",
            "boardName": "",
            "specialOffer": "",
            "availability": "6",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1A7ED",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "456015",
      "cover": "http://i.travelapi.com/hotels/9000000/8070000/8069300/8069259/e66f8676_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Song Anh Hotel 1",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Song Anh Hotel 1 places you in the heart of Ho Chi Minh City, steps from Temple of Mariamman and 5 minutes by foot from Zen Plaza.  This hotel is 0.4 mi …",
      "longitude": "106.69492",
      "latitude": "10.7714",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "191 Le Thanh Ton, "
    },
    {
      "roomGroup": {
        "totalPrice": "1189238.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "201785323",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "201785323",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1ABC1",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "651148",
      "cover": "http://i.travelapi.com/hotels/18000000/17050000/17040400/17040390/6c7725b0_t.jpg",
      "rate": "2.0",
      "destinationName": "Thu Dau Mot",
      "hotelName": "New Hotel & Apartment",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at New Hotel & Apartment in Thu Dau Mot, you'll be 6.9 mi (11 km) from Lac Canh Dai Nam Van Hien Theme Park and 7.6 mi (12.2 km) from Dai Nam Open Zoo.  …",
      "longitude": "106.67583",
      "latitude": "10.96691",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "86 Tran Binh Trong, "
    },
    {
      "roomGroup": {
        "totalPrice": "1189238.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Studio",
            "roomCode": "217215829",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 10%",
            "availability": "6",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Studio",
            "roomCode": "217215829",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 10%",
            "availability": "6",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1ABC1",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "946248",
      "cover": "http://i.travelapi.com/hotels/26000000/25150000/25144300/25144294/2843fe22_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Tan Son Nhat Airport Apartment",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Tan Son Nhat Airport Apartment in Ho Chi Minh City, you'll be within a 15-minute walk of Parkson CT Plaza and Hoang Van Thu Park.  This aparthotel is …",
      "longitude": "106.66493",
      "latitude": "10.80853",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "21/24 Truong Son, "
    },
    {
      "roomGroup": {
        "totalPrice": "1202457.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double Room (Window)",
            "roomCode": "201797288",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double Room (Window)",
            "roomCode": "201797288",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1AFF9",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "653329",
      "cover": "http://i.travelapi.com/hotels/18000000/17100000/17096200/17096175/4d5bee4d_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Meraki Boutique Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Meraki Boutique Hotel in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Bui Vien Walking Street and Pham Ngu Lao Backpacker Area.  …",
      "longitude": "106.692",
      "latitude": "10.76662",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "178 Bui Vien, Pham Ngu Lao Ward, "
    },
    {
      "roomGroup": {
        "totalPrice": "1203436.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room, No Windows",
            "roomCode": "501145",
            "boardName": "",
            "specialOffer": "Book now and save!",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room, No Windows",
            "roomCode": "501145",
            "boardName": "",
            "specialOffer": "Book now and save!",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1B049",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "347192",
      "cover": "http://i.travelapi.com/hotels/4000000/3620000/3613800/3613777/28476dde_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "La Felix Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at La Felix Hotel places you in the heart of Ho Chi Minh City, steps from Pham Ngu Lao Backpacker Area and 4 minutes by foot from Bui Vien Walking Street.  …",
      "longitude": "106.69141",
      "latitude": "10.76785",
      "promotion": "Book now and save!",
      "supplierCode": "s007",
      "hotelAddress": "287-289 Pham Ngu Lao, "
    },
    {
      "roomGroup": {
        "totalPrice": "1203926.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Block B",
            "roomCode": "200073638",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Seasonal deal: save 10%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Block B",
            "roomCode": "200073638",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Seasonal deal: save 10%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1B071",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "379897",
      "cover": "http://i.travelapi.com/hotels/5000000/4430000/4425200/4425148/992b6e99_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Dong Kinh Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />When you stay at Dong Kinh Hotel in Ho Chi Minh City, you'll be in a shopping district, within a 15-minute walk of An Dong Market and Cho Quan Church.  This spa …",
      "longitude": "106.67415",
      "latitude": "10.75192",
      "promotion": "Seasonal deal: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "102/4 - 106 - 108 Tran Tuan Khai Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "1222286.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Apartment, 1 Bedroom",
            "roomCode": "202433301",
            "boardName": "",
            "specialOffer": "Tonight only: save 10%",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Apartment, 1 Bedroom",
            "roomCode": "202433301",
            "boardName": "",
            "specialOffer": "Tonight only: save 10%",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1B64D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "811113",
      "cover": "http://i.travelapi.com/hotels/23000000/22160000/22155300/22155299/cf4ab745_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Smiley Apartment 15",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Smiley Apartment 15 in Ho Chi Minh City (Little Japan), you'll be steps from Saigon River and Riverside.  This apartment is 0.3 mi (0.5 km) from Dong …",
      "longitude": "106.70526",
      "latitude": "10.77931",
      "promotion": "Tonight only: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "8A/G10 Thai Van Lung, p. Ben Nghe, Q.1, "
    },
    {
      "roomGroup": {
        "totalPrice": "1222286.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Room",
            "roomCode": "218122091",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "7",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Room",
            "roomCode": "218122091",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "7",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1B64D",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "1034031",
      "cover": "http://i.travelapi.com/hotels/29000000/28870000/28861400/28861389/60cf8e17_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "AHA Residence Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City (Hang Xanh), AHA Residence Hotel is convenient to Van Thanh Tourist Park and Jade Emperor Pagoda.  This hotel is within close proximity …",
      "longitude": "106.70681",
      "latitude": "10.79931",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "284 Dien Bien Phu, Ward 17, "
    },
    {
      "roomGroup": {
        "totalPrice": "1222286.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "217216064",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "217216064",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1B64D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1008219",
      "cover": "http://i.travelapi.com/hotels/28000000/27740000/27732500/27732447/de390518_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "GIC Apartment and Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, GIC Apartment and Hotel is minutes from Parkson CT Plaza and close to Gia Dinh Park.  This family-friendly hotel is within close …",
      "longitude": "106.66668",
      "latitude": "10.81277",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "2/11 Hong Ha, Ward 2, Tan Binh, "
    },
    {
      "roomGroup": {
        "totalPrice": "1222286.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room, No Windows",
            "roomCode": "210014747",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room, No Windows",
            "roomCode": "210014747",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1B64D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1018655",
      "cover": "http://i.travelapi.com/hotels/28000000/27770000/27768000/27767942/3f248862_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Koreana Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Koreana Hotel in Ho Chi Minh City, you'll be minutes from Vietnam People's Air Force Museum and close to Hoang Van Thu Park.  This hotel is within …",
      "longitude": "106.66094",
      "latitude": "10.80073",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "05 Cong Hoa street, "
    },
    {
      "roomGroup": {
        "totalPrice": "1225468.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "202213287",
            "boardName": "Free Breakfast",
            "specialOffer": "Last minute deal: save 40%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "202213287",
            "boardName": "Free Breakfast",
            "specialOffer": "Last minute deal: save 40%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1B751",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "757989",
      "cover": "http://i.travelapi.com/hotels/21000000/20150000/20145900/20145897/481ca1e9_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "An Tam Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at An Tam Hotel in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Ben Thanh Market and 3 minutes by foot from Temple of Mariamman.  …",
      "longitude": "106.69702",
      "latitude": "10.77195",
      "promotion": "Last minute deal: save 40%",
      "supplierCode": "s007",
      "hotelAddress": "22 Nguyen An Ninh, "
    },
    {
      "roomGroup": {
        "totalPrice": "1231344.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Twin Room",
            "roomCode": "215400733",
            "boardName": "",
            "specialOffer": "Member’s price: 20%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Twin Room",
            "roomCode": "215400733",
            "boardName": "",
            "specialOffer": "Member’s price: 20%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1B931",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "842869",
      "cover": "http://i.travelapi.com/hotels/23000000/22780000/22775500/22775406/36eda28a_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Kiera Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Kiera Hotel places you in the heart of Ho Chi Minh City, within a 5-minute walk of Pham Ngu Lao Backpacker Area and Bui Vien Walking Street.  This hotel is …",
      "longitude": "106.69515",
      "latitude": "10.76478",
      "promotion": "Member’s price: 20%",
      "supplierCode": "s007",
      "hotelAddress": "120 De Tham, "
    },
    {
      "roomGroup": {
        "totalPrice": "1233057.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "215705889",
            "boardName": "Free Breakfast",
            "specialOffer": "Book early and save 25%",
            "availability": "8",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "215705889",
            "boardName": "Free Breakfast",
            "specialOffer": "Book early and save 25%",
            "availability": "8",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1B9BD",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "908577",
      "cover": "http://i.travelapi.com/hotels/25000000/24130000/24127300/24127217/4e4c09ee_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "TRIIP Palago",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at TRIIP Palago in Ho Chi Minh City (Hang Xanh), you'll be within a 10-minute drive of Van Thanh Tourist Park and Vietnam National Museum of History.  …",
      "longitude": "106.70757",
      "latitude": "10.79276",
      "promotion": "Book early and save 25%",
      "supplierCode": "s007",
      "hotelAddress": "625/8 Xo Viet Nghe Tinh, "
    },
    {
      "roomGroup": {
        "totalPrice": "1249214.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room",
            "roomCode": "201985028",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 25%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room",
            "roomCode": "201985028",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 25%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1BEE5",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "697431",
      "cover": "http://i.travelapi.com/hotels/19000000/18540000/18534200/18534142/b5d96823_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Vnpearl 94 Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Vnpearl 94 Hotel in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Bui Vien Walking Street and Pham Ngu Lao Backpacker Area.  This …",
      "longitude": "106.6931",
      "latitude": "10.76706",
      "promotion": "Private sale: save 25%",
      "supplierCode": "s007",
      "hotelAddress": "94 Bui Vien Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "1265371.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Apartment, 1 Bedroom",
            "roomCode": "217808641",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Apartment, 1 Bedroom",
            "roomCode": "217808641",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1C40D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "900230",
      "cover": "http://i.travelapi.com/hotels/24000000/23990000/23981100/23981069/b22e43db_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Smiley Apartment 16",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, this apartment is minutes from Jade Emperor Pagoda and close to Diamond Plaza.  This apartment is within close proximity of Vietnam …",
      "longitude": "106.6976",
      "latitude": "10.78755",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "100/4 Nguyen Dinh Chieu Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "1267329.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "200340655",
            "boardName": "Full Breakfast",
            "specialOffer": "Save 50%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "200340655",
            "boardName": "Full Breakfast",
            "specialOffer": "Save 50%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1C4AD",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "438482",
      "cover": "http://i.travelapi.com/hotels/7000000/6460000/6451700/6451668/f1867f62_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Lexington Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Lexington Hotel places you in the heart of Ho Chi Minh City, steps from Benthanh Street Food Market and 4 minutes by foot from Temple of Mariamman.  This …",
      "longitude": "106.69694",
      "latitude": "10.77418",
      "promotion": "Save 50%",
      "supplierCode": "s007",
      "hotelAddress": "34A Thu Khoa Huan St, Ben Thanh Ward, "
    },
    {
      "roomGroup": {
        "totalPrice": "1267329.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double Room",
            "roomCode": "201423033",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double Room",
            "roomCode": "201423033",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1C4AD",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "571448",
      "cover": "http://i.travelapi.com/hotels/14000000/13460000/13456200/13456155/3b86f43d_t.jpg",
      "rate": "1.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "A in Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at A in Hotel places you in the heart of Ho Chi Minh City, steps from Pham Ngu Lao Backpacker Area and Bui Vien Walking Street.  This hotel is 0.4 mi (0.7 km) …",
      "longitude": "106.69457",
      "latitude": "10.76805",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "28/10 Bui Vien, District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "1272960.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room City View, Share Bathroom (D1)",
            "roomCode": "202399454",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room City View, Share Bathroom (D1)",
            "roomCode": "202399454",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1C679",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "802072",
      "cover": "http://i.travelapi.com/hotels/22000000/21740000/21734600/21734530/311b9bad_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "My Duc Deluxe Apartment",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at My Duc Deluxe Apartment in Ho Chi Minh City (Hang Xanh), you'll be a 4-minute drive from Van Thanh Tourist Park and 7 minutes from Jade Emperor …",
      "longitude": "106.71142",
      "latitude": "10.79845",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "220 Xo Viet Nghe Tinh St, Ward 21, "
    },
    {
      "roomGroup": {
        "totalPrice": "1276142.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room, No Windows",
            "roomCode": "221402147",
            "boardName": "Free Breakfast",
            "specialOffer": "Save 10%",
            "availability": "14",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room, No Windows",
            "roomCode": "221402147",
            "boardName": "Free Breakfast",
            "specialOffer": "Save 10%",
            "availability": "14",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1C77D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "835705",
      "cover": "http://i.travelapi.com/hotels/23000000/22670000/22660900/22660841/1b4fc9b5_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Le Saigon Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, Le Saigon Hotel is connected to the convention center, within a 15-minute walk of Parkson CT Plaza and Hoang Van Thu Park.  This hotel …",
      "longitude": "106.66546",
      "latitude": "10.80935",
      "promotion": "Save 10%",
      "supplierCode": "s007",
      "hotelAddress": "17 Dong Da street, Tan Binh Dist., "
    },
    {
      "roomGroup": {
        "totalPrice": "1282017.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "201704398",
            "boardName": "",
            "specialOffer": "Member’s price: 60%",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "201704398",
            "boardName": "",
            "specialOffer": "Member’s price: 60%",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1C95D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "630935",
      "cover": "http://i.travelapi.com/hotels/17000000/16310000/16303000/16302937/dad027f1_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "New Sun Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at New Sun Hotel in Ho Chi Minh City (Phu Nhuan), you'll be within a 10-minute drive of Jade Emperor Pagoda and Ear Nose Throat Hospital.  This hotel is …",
      "longitude": "106.68961",
      "latitude": "10.7967",
      "promotion": "Member’s price: 60%",
      "supplierCode": "s007",
      "hotelAddress": "77B-C Hoa Hong Street, Ward 2, "
    },
    {
      "roomGroup": {
        "totalPrice": "1285689.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "200765138",
            "boardName": "",
            "specialOffer": "",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "200765138",
            "boardName": "",
            "specialOffer": "",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1CA89",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "471860",
      "cover": "http://i.travelapi.com/hotels/9000000/8980000/8977600/8977528/887edcdc_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Xavier Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Xavier Hotel in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Temple of Mariamman and 3 minutes by foot from Ben Thanh Market.  …",
      "longitude": "106.6963",
      "latitude": "10.77177",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "25 Truong Dinh Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "1290830.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "219306442",
            "boardName": "",
            "specialOffer": "Private sale: save 45%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "219306442",
            "boardName": "",
            "specialOffer": "Private sale: save 45%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1CC2D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "870614",
      "cover": "http://i.travelapi.com/hotels/24000000/23260000/23255000/23254947/3186a0b3_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "TRIIP Cupid",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at TRIIP Cupid in Ho Chi Minh City (Bui Thi Xuan), you'll be steps from Pham Ngu Lao Backpacker Area and 5 minutes by foot from Bui Vien Walking Street.  …",
      "longitude": "106.6883",
      "latitude": "10.76768",
      "promotion": "Private sale: save 45%",
      "supplierCode": "s007",
      "hotelAddress": "2 bis Nam Quoc Cang, "
    },
    {
      "roomGroup": {
        "totalPrice": "1292544.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "200104632",
            "boardName": "Breakfast Buffet",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "200104632",
            "boardName": "Breakfast Buffet",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1CCB9",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "391392",
      "cover": "http://i.travelapi.com/hotels/5000000/4620000/4617900/4617879/9f6ca6f6_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Phuoc Loc Tho 1 Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, Phuoc Loc Tho 1 Hotel is in the business district, within a 15-minute walk of An Dong Market and Cho Quan Church.  This hotel is 1 mi …",
      "longitude": "106.6737",
      "latitude": "10.75804",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "170-174 Su Van Hanh Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "1303315.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "200742585",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "200742585",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1D029",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "456024",
      "cover": "http://i.travelapi.com/hotels/9000000/8080000/8070700/8070695/51f52dda_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "New Pearl Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at New Pearl Hotel in Ho Chi Minh City, you'll be a 4-minute walk from Bui Vien Walking Street and 5 minutes by foot from Pham Ngu Lao Backpacker Area.  …",
      "longitude": "106.69505",
      "latitude": "10.76469",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "266 De Tham St., District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "1303315.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room, 2 Twin Beds",
            "roomCode": "200762969",
            "boardName": "Full Breakfast",
            "specialOffer": "",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room, 2 Twin Beds",
            "roomCode": "200762969",
            "boardName": "Full Breakfast",
            "specialOffer": "",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1D029",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "471531",
      "cover": "http://i.travelapi.com/hotels/9000000/8970000/8962700/8962623/5fc74368_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "TRIIP Mismo",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at TRIIP Mismo in Ho Chi Minh City (Go Vap), you'll be 11 minutes by car from Gia Dinh Park.  This spa hotel is 3.5 mi (5.7 km) from Parkson CT Plaza and …",
      "longitude": "106.6784",
      "latitude": "10.84707",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "531 Nguyen Oanh Street, Ward 17, "
    },
    {
      "roomGroup": {
        "totalPrice": "1303315.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Dream VIP",
            "roomCode": "201892225",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Dream VIP",
            "roomCode": "201892225",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": false,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1D029",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "676994",
      "cover": "http://i.travelapi.com/hotels/18000000/17780000/17775600/17775510/e3706fdf_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Bonita THT Hotel - Adults Only",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Bonita THT Hotel - Adults Only in Ho Chi Minh City, you'll be within a 15-minute drive of Hoang Van Thu Park and Ho Chi Minh City International …",
      "longitude": "106.62988",
      "latitude": "10.82304",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "185, To Hien Thanh, Ward 13, Dist. 10, "
    },
    {
      "roomGroup": {
        "totalPrice": "1303315.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Studio",
            "roomCode": "220215882",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Studio",
            "roomCode": "220215882",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1D029",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "954169",
      "cover": "http://i.travelapi.com/hotels/27000000/26380000/26371600/26371591/2c47670e_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Andinh Apartment",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at this apartment in Ho Chi Minh City (Bach Dang Riverside), you'll be within a 10-minute walk of Bui Vien Walking Street and Pham Ngu Lao Backpacker …",
      "longitude": "106.69944",
      "latitude": "10.76232",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "155 Ben Van Don, Ward 6, District 4, "
    },
    {
      "roomGroup": {
        "totalPrice": "1303315.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Luxury Studio Suite",
            "roomCode": "216314704",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Luxury Studio Suite",
            "roomCode": "216314704",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": false,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1D029",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1031670",
      "cover": "http://i.travelapi.com/hotels/28000000/27510000/27508500/27508459/70b1e373_t.jpg",
      "rate": "3.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Ju Style Apartment",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Ju Style Apartment places you in the heart of Ho Chi Minh City, within a 10-minute walk of Golden Dragon Water Puppet Theatre and Tao Dan Park.  This …",
      "longitude": "106.68803",
      "latitude": "10.7739",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "169 Vo Van Tan, ward 5, district 3, "
    },
    {
      "roomGroup": {
        "totalPrice": "1307721.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room (No Window)",
            "roomCode": "201620836",
            "boardName": "Free Breakfast",
            "specialOffer": "Last minute deal: save 54%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room (No Window)",
            "roomCode": "201620836",
            "boardName": "Free Breakfast",
            "specialOffer": "Last minute deal: save 54%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1D191",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "616483",
      "cover": "http://i.travelapi.com/hotels/16000000/15830000/15820600/15820564/607e6a65_t.jpg",
      "rate": "3.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Ambassador Hotel Saigon",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Ambassador Hotel Saigon in Ho Chi Minh City (Bui Thi Xuan), you'll be within a 10-minute walk of Zen Plaza and September 23 Park.  This hotel is 0.5 …",
      "longitude": "106.68963",
      "latitude": "10.77127",
      "promotion": "Last minute deal: save 54%",
      "supplierCode": "s007",
      "hotelAddress": "84A  Bui Thi Xuan, District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "1326816.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Room, No Windows",
            "roomCode": "200197226",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Save 68%",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Room, No Windows",
            "roomCode": "200197226",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Save 68%",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1D7A9",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "415374",
      "cover": "http://i.travelapi.com/hotels/6000000/5310000/5306700/5306688/950c61d5_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Attica Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Attica Hotel places you in the heart of Ho Chi Minh City, steps from Bui Vien Walking Street and Pham Ngu Lao Backpacker Area.  This hotel is 0.5 mi (0.8 …",
      "longitude": "106.69186",
      "latitude": "10.76645",
      "promotion": "Save 68%",
      "supplierCode": "s007",
      "hotelAddress": "82 Bui Vien Street, Pham Ngu Lao Ward, "
    },
    {
      "roomGroup": {
        "totalPrice": "1328774.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room, Mezzanine",
            "roomCode": "215406803",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room, Mezzanine",
            "roomCode": "215406803",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1D849",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "912696",
      "cover": "http://i.travelapi.com/hotels/25000000/24210000/24206500/24206422/198ba77a_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "The Moon Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at The Moon Hotel in Ho Chi Minh City (Binh Tan), you'll be 4.7 mi (7.6 km) from Quang Trung Software City and 5.2 mi (8.3 km) from Ho Chi Minh City …",
      "longitude": "106.59521",
      "latitude": "10.81063",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "221, Street 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "1332201.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Twin Room",
            "roomCode": "200813049",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Tonight only: save 48%",
            "availability": "6",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Twin Room",
            "roomCode": "200813049",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Tonight only: save 48%",
            "availability": "6",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1D961",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "478378",
      "cover": "http://i.travelapi.com/hotels/10000000/9320000/9315700/9315634/9315634_34_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Ky Hoa Hotel Saigon",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Ky Hoa Hotel Saigon in Ho Chi Minh City, you'll be a 4-minute walk from Quoc Tu Pagoda and 7 minutes by foot from Museum of Traditional Vietnamese …",
      "longitude": "106.67503",
      "latitude": "10.77211",
      "promotion": "Tonight only: save 48%",
      "supplierCode": "s007",
      "hotelAddress": "238 Ba Thang Hai Str, "
    },
    {
      "roomGroup": {
        "totalPrice": "1341993.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Studio, 1 Bedroom",
            "roomCode": "216016082",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Studio, 1 Bedroom",
            "roomCode": "216016082",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1DC81",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1006734",
      "cover": "http://i.travelapi.com/hotels/28000000/27740000/27735900/27735821/60833750_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Spacious and Modern II",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, Spacious and Modern II is minutes from Parkson CT Plaza and close to Vietnam People's Air Force Museum.  This aparthotel is within close …",
      "longitude": "106.66585",
      "latitude": "10.8101",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "50/17 Truong Son, Ward 2, "
    },
    {
      "roomGroup": {
        "totalPrice": "1343462.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Triple Room",
            "roomCode": "220804258",
            "boardName": "Free Breakfast",
            "specialOffer": "Last minute deal: save 47%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Triple Room",
            "roomCode": "220804258",
            "boardName": "Free Breakfast",
            "specialOffer": "Last minute deal: save 47%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": false,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1DCF9",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "856546",
      "cover": "http://i.travelapi.com/hotels/24000000/23070000/23067000/23066907/2aefb531_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Lamo Boutique Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, Lamo Boutique Hotel is a 4-minute walk from Riverside and 14 minutes by foot from Saigon Square.  This hotel is 0.8 mi (1.3 km) from …",
      "longitude": "106.70472",
      "latitude": "10.76539",
      "promotion": "Last minute deal: save 47%",
      "supplierCode": "s007",
      "hotelAddress": "46 Nguyen Truong To, "
    },
    {
      "roomGroup": {
        "totalPrice": "1351051.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double or Twin Room",
            "roomCode": "201402237",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Save 68%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double or Twin Room",
            "roomCode": "201402237",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Save 68%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1DF65",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "568066",
      "cover": "http://i.travelapi.com/hotels/14000000/13320000/13312300/13312282/60245d01_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "ACE Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City (Downtown Ho Chi Minh City), ACE Hotel is within a 10-minute drive of War Remnants Museum and Museum of Fine Arts.  This hotel is 1 mi …",
      "longitude": "106.69053",
      "latitude": "10.76937",
      "promotion": "Save 68%",
      "supplierCode": "s007",
      "hotelAddress": "139H Nguyen Trai Street, District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "1357660.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Studio",
            "roomCode": "202113556",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Studio",
            "roomCode": "202113556",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1E181",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "729107",
      "cover": "http://i.travelapi.com/hotels/20000000/19530000/19527400/19527308/9ed952b1_t.jpg",
      "rate": "1.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Jen & Friends House",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Jen & Friends House places you in the heart of Ho Chi Minh City, within a 15-minute walk of Quoc Tu Pagoda and Museum of Traditional Vietnamese Medicine.  …",
      "longitude": "106.67466",
      "latitude": "10.76941",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "724/25 Bis Dien Bien Phu, "
    },
    {
      "roomGroup": {
        "totalPrice": "1369411.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Comfort Studio, 1 Queen Bed, Tower",
            "roomCode": "221409885",
            "boardName": "",
            "specialOffer": "Last minute deal: save 34%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Comfort Studio, 1 Queen Bed, Tower",
            "roomCode": "221409885",
            "boardName": "",
            "specialOffer": "Last minute deal: save 34%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1E541",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "901514",
      "cover": "http://i.travelapi.com/hotels/25000000/24020000/24010500/24010472/edc536a8_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "River Gate Apartment Saigon HCMC",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at River Gate Apartment Saigon HCMC places you in the heart of Ho Chi Minh City, within a 10-minute walk of Bui Vien Walking Street and Pham Ngu Lao …",
      "longitude": "106.69868",
      "latitude": "10.76301",
      "promotion": "Last minute deal: save 34%",
      "supplierCode": "s007",
      "hotelAddress": "155 Ben Van Don Ward 6, District 04, "
    },
    {
      "roomGroup": {
        "totalPrice": "1374796.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "220525474",
            "boardName": "Free Breakfast",
            "specialOffer": "Member’s price: 65%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "220525474",
            "boardName": "Free Breakfast",
            "specialOffer": "Member’s price: 65%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1E6F9",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1035409",
      "cover": "http://i.travelapi.com/hotels/30000000/29310000/29308800/29308777/3c421fc8_t.jpg",
      "rate": "3.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Blessing Palace Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Blessing Palace Hotel in Ho Chi Minh City (Little Japan), you'll be steps from Saigon River.  This hotel is within close proximity of Opera House and …",
      "longitude": "106.70437",
      "latitude": "10.77819",
      "promotion": "Member’s price: 65%",
      "supplierCode": "s007",
      "hotelAddress": "18 Cao Ba Quat, District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "1375776.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Room",
            "roomCode": "200360528",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Save 50%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Room",
            "roomCode": "200360528",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Save 50%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1E749",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "441887",
      "cover": "http://i.travelapi.com/hotels/7000000/6660000/6657800/6657734/0b0b69d8_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Asian Ruby Boutique Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Asian Ruby Boutique Hotel in Ho Chi Minh City (Bui Thi Xuan), you'll be within a 10-minute walk of Tao Dan Park and Zen Plaza.  This romantic hotel is …",
      "longitude": "106.69061",
      "latitude": "10.77212",
      "promotion": "Save 50%",
      "supplierCode": "s007",
      "hotelAddress": "20 BIS Bui Thi Xuan, District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "1385078.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Apartment, 1 Bedroom",
            "roomCode": "217824229",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "7",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Apartment, 1 Bedroom",
            "roomCode": "217824229",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "7",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1EA41",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1033892",
      "cover": "http://i.travelapi.com/hotels/30000000/29310000/29301700/29301661/1176a09e_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Crown Apartment",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Crown Apartment in Ho Chi Minh City, you'll be minutes from Parkson CT Plaza and close to Gia Dinh Park.  This apartment is within close proximity of …",
      "longitude": "106.66671",
      "latitude": "10.811",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "25/18 Cuu Long, Ward 2, Tan Binh, "
    },
    {
      "roomGroup": {
        "totalPrice": "1393156.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room, Park View",
            "roomCode": "200695389",
            "boardName": "Full Breakfast",
            "specialOffer": "Private sale: save 55%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room, Park View",
            "roomCode": "200695389",
            "boardName": "Full Breakfast",
            "specialOffer": "Private sale: save 55%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1ECD5",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "451310",
      "cover": "http://i.travelapi.com/hotels/8000000/7690000/7685600/7685549/504c28c0_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Gia Vien Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />Gia Vien Hotel is centrally located in Ho Chi Minh City, a 4-minute walk from September 23 Park and 9 minutes by foot from Ben Thanh Market.  This hotel is 0.5 mi …",
      "longitude": "106.69403",
      "latitude": "10.76882",
      "promotion": "Private sale: save 55%",
      "supplierCode": "s007",
      "hotelAddress": "175/4-6 Pham Ngu Lao Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "1394136.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Room",
            "roomCode": "218405447",
            "boardName": "",
            "specialOffer": "Save 30%",
            "availability": "10",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Room",
            "roomCode": "218405447",
            "boardName": "",
            "specialOffer": "Save 30%",
            "availability": "10",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1ED25",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "888181",
      "cover": "http://i.travelapi.com/hotels/24000000/23600000/23596300/23596282/8e8a7b94_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "La Cigale Residence",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City (Phu My Hung), La Cigale Residence is within a 5-minute drive of FV Hospital and The Cresent Mall.  This hotel is 0.8 mi (1.2 km) from SC …",
      "longitude": "106.70979",
      "latitude": "10.73338",
      "promotion": "Save 30%",
      "supplierCode": "s007",
      "hotelAddress": "37-39 Khu pho Hung Gia 1, Phu My Hung, "
    },
    {
      "roomGroup": {
        "totalPrice": "1396094.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room, No Windows",
            "roomCode": "200360798",
            "boardName": "Full Breakfast",
            "specialOffer": "Private sale: save 32%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room, No Windows",
            "roomCode": "200360798",
            "boardName": "Full Breakfast",
            "specialOffer": "Private sale: save 32%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1EDC5",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "358615",
      "cover": "http://i.travelapi.com/hotels/4000000/3890000/3884200/3884184/d5a9082b_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Hoang Ngan Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Hoang Ngan Hotel places you in the heart of Ho Chi Minh City, within a 10-minute walk of Tao Dan Park and Zen Plaza.  This hotel is 0.5 mi (0.7 km) from …",
      "longitude": "106.69051",
      "latitude": "10.77196",
      "promotion": "Private sale: save 32%",
      "supplierCode": "s007",
      "hotelAddress": "29 - 31 Bui Thi Xuan St, "
    },
    {
      "roomGroup": {
        "totalPrice": "1401235.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room, Smoking, City View",
            "roomCode": "216304113",
            "boardName": "",
            "specialOffer": "Book now and save!",
            "availability": "6",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room, Smoking, City View",
            "roomCode": "216304113",
            "boardName": "",
            "specialOffer": "Book now and save!",
            "availability": "6",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1EF69",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "890344",
      "cover": "http://i.travelapi.com/hotels/24000000/23660000/23654100/23654077/7c97c89e_t.jpg",
      "rate": "3.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Fide Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Fide Hotel in Ho Chi Minh City (Phu My Hung), you'll be within a 5-minute drive of The Cresent Mall and SC VivoCity.  This hotel is 1.3 mi (2.1 km) …",
      "longitude": "106.7054",
      "latitude": "10.72729",
      "promotion": "Book now and save!",
      "supplierCode": "s007",
      "hotelAddress": "474 Pham Thai Buong Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "1402214.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "202091963",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 10%",
            "availability": "20",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "202091963",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 10%",
            "availability": "20",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1EFB9",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "721791",
      "cover": "http://i.travelapi.com/hotels/20000000/19370000/19362000/19361937/41bd5238_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "A25 Hotel - 20 Bui Thi Xuan",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at A25 Hotel - 20 Bui Thi Xuan in Ho Chi Minh City (Bui Thi Xuan), you'll be within a 10-minute walk of Tao Dan Park and Zen Plaza.  This hotel is 0.5 mi …",
      "longitude": "106.69066",
      "latitude": "10.77231",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "20 Bui Thi Xuan, District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "1412496.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double Room, No Windows",
            "roomCode": "200718498",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Save 39%",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double Room, No Windows",
            "roomCode": "200718498",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Save 39%",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1F301",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "400036",
      "cover": "http://i.travelapi.com/hotels/5000000/4860000/4854800/4854797/2449751f_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "The White 1 Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at The White 1 Hotel places you in the heart of Ho Chi Minh City, steps from Benthanh Street Food Market and 3 minutes by foot from Ben Thanh Market.  This …",
      "longitude": "106.69824",
      "latitude": "10.77353",
      "promotion": "Save 39%",
      "supplierCode": "s007",
      "hotelAddress": "255-257 Le Thanh Ton St, Ben Thanh Ward, "
    },
    {
      "roomGroup": {
        "totalPrice": "1418126.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Twin Room, 1 Bedroom",
            "roomCode": "201806474",
            "boardName": "",
            "specialOffer": "Tonight only: save 12%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Twin Room, 1 Bedroom",
            "roomCode": "201806474",
            "boardName": "",
            "specialOffer": "Tonight only: save 12%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1F4CD",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "629320",
      "cover": "http://i.travelapi.com/hotels/17000000/16250000/16245800/16245757/697ab3c1_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Camila Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Camila Hotel in Ho Chi Minh City, you'll be 0.5 mi (0.9 km) from Parkson CT Plaza and 4.2 mi (6.8 km) from War Remnants Museum.  This hotel is 4.9 mi …",
      "longitude": "106.66481",
      "latitude": "10.80632",
      "promotion": "Tonight only: save 12%",
      "supplierCode": "s007",
      "hotelAddress": "No. 3 Song Da Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "1419105.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Suite",
            "roomCode": "202216620",
            "boardName": "",
            "specialOffer": "Tonight only: save 25%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Suite",
            "roomCode": "202216620",
            "boardName": "",
            "specialOffer": "Tonight only: save 25%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1F51D",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "760838",
      "cover": "http://i.travelapi.com/hotels/21000000/20210000/20204500/20204475/94102d1e_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Emerald Serviced Apartments",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Emerald Serviced Apartments in Ho Chi Minh City (Phu My Hung), you'll be within a 5-minute drive of The Cresent Mall and SC VivoCity.  This hotel is …",
      "longitude": "106.70559",
      "latitude": "10.72729",
      "promotion": "Tonight only: save 25%",
      "supplierCode": "s007",
      "hotelAddress": "159-161 Pham Thai Buong St, "
    },
    {
      "roomGroup": {
        "totalPrice": "1444809.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Studio",
            "roomCode": "220809520",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Studio",
            "roomCode": "220809520",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1FD51",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "896222",
      "cover": "http://i.travelapi.com/hotels/24000000/23920000/23912600/23912532/d0a75d52_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "River View Apartment & Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at River View Apartment & Hotel places you in the heart of Ho Chi Minh City, steps from Saigon River and Riverside.  This hotel is 0.2 mi (0.4 km) from Dong …",
      "longitude": "106.70559",
      "latitude": "10.78087",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "15a/47 Le Thanh Ton street, "
    },
    {
      "roomGroup": {
        "totalPrice": "1445054.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "200024727",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Private sale: save 10%",
            "availability": "17",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "200024727",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Private sale: save 10%",
            "availability": "17",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1FD65",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "312094",
      "cover": "http://i.travelapi.com/hotels/3000000/2470000/2464200/2464137/c43ec440_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Arc En Ciel Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Arc En Ciel Hotel in Ho Chi Minh City (Chinatown), you'll be within a 10-minute drive of Thong Nhat Stadium and Binh Tay Market.  This hotel is 1.2 mi …",
      "longitude": "106.66441",
      "latitude": "10.7522",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "52-56 Tan Da Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "1448481.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double or Twin Room",
            "roomCode": "200814821",
            "boardName": "",
            "specialOffer": "Private sale: save 20%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double or Twin Room",
            "roomCode": "200814821",
            "boardName": "",
            "specialOffer": "Private sale: save 20%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1FE7D",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "478415",
      "cover": "http://i.travelapi.com/hotels/10000000/9320000/9317100/9317029/6ea2d646_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Vilion Central Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />Vilion Central Hotel is centrally located in Ho Chi Minh City, a 5-minute walk from Ben Thanh Market and 10 minutes by foot from Saigon Square.  This hotel is 0.8 mi …",
      "longitude": "106.69525",
      "latitude": "10.77175",
      "promotion": "Private sale: save 20%",
      "supplierCode": "s007",
      "hotelAddress": "41-43 Le Anh Xuan Str., "
    },
    {
      "roomGroup": {
        "totalPrice": "1457539.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "200281486",
            "boardName": "",
            "specialOffer": "Private sale: save 5%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "200281486",
            "boardName": "",
            "specialOffer": "Private sale: save 5%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "20161",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "430616",
      "cover": "http://i.travelapi.com/hotels/6000000/5920000/5914400/5914348/0597c34a_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Ruby Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Ruby Hotel places you in the heart of Ho Chi Minh City, steps from Benthanh Street Food Market and Taka Plaza.  This hotel is 0.2 mi (0.4 km) from Temple …",
      "longitude": "106.69854",
      "latitude": "10.77369",
      "promotion": "Private sale: save 5%",
      "supplierCode": "s007",
      "hotelAddress": "185 Le Thanh Ton Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "1464638.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room B",
            "roomCode": "215718032",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room B",
            "roomCode": "215718032",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "203A5",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1030785",
      "cover": "http://i.travelapi.com/hotels/30000000/29110000/29105300/29105258/6a2c0a5f_t.jpg",
      "rate": "3.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Laguna Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Laguna Hotel in Ho Chi Minh City (Phu My Hung), you'll be minutes from SC VivoCity and close to FV Hospital.  This hotel is within close proximity of …",
      "longitude": "106.70737",
      "latitude": "10.73241",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "R3-84 Hung Gia 4, "
    },
    {
      "roomGroup": {
        "totalPrice": "1465617.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "202319013",
            "boardName": "Free Breakfast",
            "specialOffer": "Member’s price: 20%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "202319013",
            "boardName": "Free Breakfast",
            "specialOffer": "Member’s price: 20%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "203F5",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "788863",
      "cover": "http://i.travelapi.com/hotels/22000000/21340000/21338700/21338658/414b6986_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "TRIIP Le Han Dai Nam",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at TRIIP Le Han Dai Nam in Ho Chi Minh City (Bui Thi Xuan), you'll be a 5-minute walk from Pham Ngu Lao Backpacker Area and 7 minutes by foot from …",
      "longitude": "106.68774",
      "latitude": "10.7693",
      "promotion": "Member’s price: 20%",
      "supplierCode": "s007",
      "hotelAddress": "142 Bui Thi Xuan, "
    },
    {
      "roomGroup": {
        "totalPrice": "1466841.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Apartment",
            "roomCode": "202122398",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Apartment",
            "roomCode": "202122398",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "20459",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "724381",
      "cover": "http://i.travelapi.com/hotels/20000000/19420000/19416500/19416444/42970979_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Supe Homestay Nguyen Van Trang",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Supe Homestay Nguyen Van Trang in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Zen Plaza and September 23 Park.  This apartment …",
      "longitude": "106.69241",
      "latitude": "10.77007",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "8/3 Nguyen Van Trang, P Ben Thanh, Q1, "
    },
    {
      "roomGroup": {
        "totalPrice": "1466841.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double Room",
            "roomCode": "202480935",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double Room",
            "roomCode": "202480935",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "20459",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "827529",
      "cover": "http://i.travelapi.com/hotels/23000000/22510000/22507000/22506960/39baa8e9_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Mai Villa Hotel Airport",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Mai Villa Hotel Airport in Ho Chi Minh City, you'll be near the airport and minutes from Gia Dinh Park, and close to Parkson CT Plaza.  This hotel is …",
      "longitude": "106.67189",
      "latitude": "10.81317",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "54/34 Bach Dang, Ward 2, "
    },
    {
      "roomGroup": {
        "totalPrice": "1470758.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room Single Use, 1 Double Bed, Non Smoking",
            "roomCode": "200725431",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Save 5%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room Single Use, 1 Double Bed, Non Smoking",
            "roomCode": "200725431",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Save 5%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "20599",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "463260",
      "cover": "http://i.travelapi.com/hotels/9000000/8490000/8484800/8484711/07b3b9b4_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Saga Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />Saga Hotel is centrally located in Ho Chi Minh City, a 3-minute walk from Opera House and 10 minutes by foot from Saigon Notre-Dame Basilica.  This hotel is 1.1 mi …",
      "longitude": "106.70453",
      "latitude": "10.77697",
      "promotion": "Save 5%",
      "supplierCode": "s007",
      "hotelAddress": "40-42 Hai Ba Trung Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "1480060.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "200021859",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Private sale: save 10%",
            "availability": "19",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "200021859",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Private sale: save 10%",
            "availability": "19",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "20891",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "364556",
      "cover": "http://i.travelapi.com/hotels/4000000/4000000/3999000/3998913/722838a3_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Bat Dat Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, Bat Dat Hotel is in the historical district, within a 10-minute drive of Thong Nhat Stadium and Binh Tay Market.  This hotel is 1.2 mi …",
      "longitude": "106.66481",
      "latitude": "10.7523",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "238-244 Tran Hung Dao Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "1482998.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "201504311",
            "boardName": "Free Breakfast",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "201504311",
            "boardName": "Free Breakfast",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "20981",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "590377",
      "cover": "http://i.travelapi.com/hotels/16000000/15070000/15065900/15065878/6da01145_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Charner Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Charner Hotel in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Benthanh Street Food Market and 4 minutes by foot from Temple of …",
      "longitude": "106.69728",
      "latitude": "10.77372",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "29 Thu Khoa Huan Street, Ben Thanh Ward, "
    },
    {
      "roomGroup": {
        "totalPrice": "1485446.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room, No Windows",
            "roomCode": "200189347",
            "boardName": "",
            "specialOffer": "Last minute deal: save 35%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room, No Windows",
            "roomCode": "200189347",
            "boardName": "",
            "specialOffer": "Last minute deal: save 35%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "20A49",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "413384",
      "cover": "http://i.travelapi.com/hotels/6000000/5240000/5239000/5238946/5965b220_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Vuong Tai Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Vuong Tai Hotel in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be within a 5-minute walk of Ben Thanh Market and Taka Plaza.  This hotel is …",
      "longitude": "106.69914",
      "latitude": "10.77337",
      "promotion": "Last minute deal: save 35%",
      "supplierCode": "s007",
      "hotelAddress": "20 Luu Van Lang Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "1487404.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Suite",
            "roomCode": "216308267",
            "boardName": "",
            "specialOffer": "",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Suite",
            "roomCode": "216308267",
            "boardName": "",
            "specialOffer": "",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "20AE9",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "932073",
      "cover": "http://i.travelapi.com/hotels/25000000/24940000/24937700/24937640/705e250e_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "D3 Luxury Como Service Apartment NearD1",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at D3 Luxury Como Service Apartment NearD1 in Ho Chi Minh City, you'll be within a 15-minute walk of Ear Nose Throat Hospital and Southern Vietnam Women …",
      "longitude": "106.68654",
      "latitude": "10.78995",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "77 Huynh Tinh Cua Quan 3, "
    },
    {
      "roomGroup": {
        "totalPrice": "1489118.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Twin Room",
            "roomCode": "200830894",
            "boardName": "Free Breakfast",
            "specialOffer": "Save 43%",
            "availability": "7",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Twin Room",
            "roomCode": "200830894",
            "boardName": "Free Breakfast",
            "specialOffer": "Save 43%",
            "availability": "7",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "20B75",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "477519",
      "cover": "http://i.travelapi.com/hotels/7000000/6520000/6516300/6516295/65aae176_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Rang Dong Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Rang Dong Hotel, you'll be centrally located in Ho Chi Minh City, just a 4-minute walk from Zen Plaza and 6 minutes by foot from Tao Dan Park.  This …",
      "longitude": "106.69201",
      "latitude": "10.7722",
      "promotion": "Save 43%",
      "supplierCode": "s007",
      "hotelAddress": "81-83 Cach Mang Thang Tam 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "1494504.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "201908897",
            "boardName": "",
            "specialOffer": "Tonight only: save 35%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "201908897",
            "boardName": "",
            "specialOffer": "Tonight only: save 35%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "20D2D",
        "contractName": ""
      },
      "destinationCode": "AIR",
      "hotelId": "680138",
      "cover": "http://i.travelapi.com/hotels/18000000/17900000/17894500/17894410/ad8cc3c4_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "The Seventh Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at The Seventh Hotel in Ho Chi Minh City (Phu My Hung), you'll be a 5-minute drive from SC VivoCity and 5 minutes from FV Hospital.  This hotel is 1.1 mi …",
      "longitude": "106.70736",
      "latitude": "10.73282",
      "promotion": "Tonight only: save 35%",
      "supplierCode": "s007",
      "hotelAddress": "75-77 Phan Khiem Ich, Hung Gia 4, "
    },
    {
      "roomGroup": {
        "totalPrice": "1505764.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Apartment, 1 Bedroom",
            "roomCode": "202151890",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Apartment, 1 Bedroom",
            "roomCode": "202151890",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "210C5",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "741490",
      "cover": "http://i.travelapi.com/hotels/20000000/19800000/19792500/19792420/7ff8dead_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Merin City Suites",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, Merin City Suites is a 1-minute drive from Cho Quan Church and 5 minutes from Saigon Culinary Arts Centre.  This apartment is 1 mi (1.6 …",
      "longitude": "106.68282",
      "latitude": "10.75577",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "472 - 474 Tran Hung Dao A, Ward 2, "
    },
    {
      "roomGroup": {
        "totalPrice": "1505764.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "201525133",
            "boardName": "Free Breakfast",
            "specialOffer": "",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "201525133",
            "boardName": "Free Breakfast",
            "specialOffer": "",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "210C5",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "595015",
      "cover": "http://i.travelapi.com/hotels/16000000/15230000/15224900/15224857/db3fd6d2_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "A25 Hotel Ly Tu Trong",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at A25 Hotel Ly Tu Trong in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be within a 5-minute walk of Zen Plaza and Temple of Mariamman.  This …",
      "longitude": "106.69382",
      "latitude": "10.77168",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "307-309 Ly Tu Trong, Ben Nghe Ward, "
    },
    {
      "roomGroup": {
        "totalPrice": "1514822.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Studio, 1 Double Bed",
            "roomCode": "201627662",
            "boardName": "",
            "specialOffer": "Save 32%",
            "availability": "7",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Studio, 1 Double Bed",
            "roomCode": "201627662",
            "boardName": "",
            "specialOffer": "Save 32%",
            "availability": "7",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "213A9",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "617492",
      "cover": "http://i.travelapi.com/hotels/16000000/15860000/15859900/15859872/c20e0133_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Queen Central Apartment-Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Queen Central Apartment-Hotel in Ho Chi Minh City (Dong Khoi), you'll be steps from Saigon River and Dong Khoi Shopping Street.  This aparthotel is …",
      "longitude": "106.70411",
      "latitude": "10.77964",
      "promotion": "Save 32%",
      "supplierCode": "s007",
      "hotelAddress": "10 Thai Van Lung, "
    },
    {
      "roomGroup": {
        "totalPrice": "1526817.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "200981533",
            "boardName": "Free Breakfast",
            "specialOffer": "Member’s price: 40%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "200981533",
            "boardName": "Free Breakfast",
            "specialOffer": "Member’s price: 40%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "2177D",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "503491",
      "cover": "http://i.travelapi.com/hotels/10000000/9630000/9625300/9625262/c1581d87_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Thanh Long Tan Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Thanh Long Tan Hotel in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Temple of Mariamman and 3 minutes by foot from Ben Thanh …",
      "longitude": "106.69618",
      "latitude": "10.77177",
      "promotion": "Member’s price: 40%",
      "supplierCode": "s007",
      "hotelAddress": "23 Truong Dinh Street, Ben Thanh Ward, "
    },
    {
      "roomGroup": {
        "totalPrice": "1528531.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room, 1 Double or 2 Twin Beds, No Windows",
            "roomCode": "200143042",
            "boardName": "Continental Breakfast",
            "specialOffer": "",
            "availability": "6",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room, 1 Double or 2 Twin Beds, No Windows",
            "roomCode": "200143042",
            "boardName": "Continental Breakfast",
            "specialOffer": "",
            "availability": "6",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "21809",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "401759",
      "cover": "http://i.travelapi.com/hotels/5000000/4900000/4894400/4894314/77b0ea68_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Duna Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Duna Hotel places you in the heart of Ho Chi Minh City, steps from Pham Ngu Lao Backpacker Area and Bui Vien Walking Street.  This hotel is 0.3 mi (0.5 km) …",
      "longitude": "106.69449",
      "latitude": "10.76913",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "167 Pham Ngu Lao Str., Dist. 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "1537099.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room, 1 Double or 2 Twin Beds",
            "roomCode": "200132478",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room, 1 Double or 2 Twin Beds",
            "roomCode": "200132478",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "21AC5",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "386670",
      "cover": "http://i.travelapi.com/hotels/5000000/4530000/4522600/4522572/4522572_65_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "White Lion Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at White Lion Hotel places you in the heart of Ho Chi Minh City, within a 15-minute walk of Pham Ngu Lao Backpacker Area and Bui Vien Walking Street.  This …",
      "longitude": "106.68345",
      "latitude": "10.76886",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "15 C Cao Thang, Ward 2, Dist 3, "
    },
    {
      "roomGroup": {
        "totalPrice": "1539302.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double or Twin Room",
            "roomCode": "200943903",
            "boardName": "Free Breakfast",
            "specialOffer": "Save 50%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double or Twin Room",
            "roomCode": "200943903",
            "boardName": "Free Breakfast",
            "specialOffer": "Save 50%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "21B79",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "505457",
      "cover": "http://i.travelapi.com/hotels/11000000/10260000/10258100/10258026/a621eca7_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Hoang Dung Hotel – Hong Vina",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Hoang Dung Hotel – Hong Vina places you in the heart of Ho Chi Minh City, steps from Zen Plaza and 4 minutes by foot from September 23 Park.  This hotel is …",
      "longitude": "106.69152",
      "latitude": "10.77008",
      "promotion": "Save 50%",
      "supplierCode": "s007",
      "hotelAddress": "86 Nguyen Trai, Ben Thanh Ward, "
    },
    {
      "roomGroup": {
        "totalPrice": "1543708.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Room, Balcony, Corner",
            "roomCode": "221724636",
            "boardName": "Free Breakfast",
            "specialOffer": "Special deal: save 20%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Room, Balcony, Corner",
            "roomCode": "221724636",
            "boardName": "Free Breakfast",
            "specialOffer": "Special deal: save 20%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "21CE1",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1034709",
      "cover": "http://i.travelapi.com/hotels/30000000/29450000/29448000/29447944/5aee1cac_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Hoang Long Boutique Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Hoang Long Boutique Hotel in Ho Chi Minh City, you'll be near the airport and close to Ho Chi Minh City International Exhibition and Convention Centre …",
      "longitude": "106.66012",
      "latitude": "10.79728",
      "promotion": "Special deal: save 20%",
      "supplierCode": "s007",
      "hotelAddress": "1/16 Hoang Viet Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "1547870.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Studio Suite (with Window)",
            "roomCode": "202408775",
            "boardName": "",
            "specialOffer": "Save 5%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Studio Suite (with Window)",
            "roomCode": "202408775",
            "boardName": "",
            "specialOffer": "Save 5%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "21E35",
        "contractName": ""
      },
      "destinationCode": "TSN",
      "hotelId": "808115",
      "cover": "http://i.travelapi.com/hotels/22000000/21970000/21963600/21963553/44d65c5b_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "SECC Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at SECC Hotel in Ho Chi Minh City, you'll be 4 mi (6.4 km) from Riverside and 4.3 mi (6.9 km) from Ben Thanh Market.  This aparthotel is 4.4 mi (7.1 km) …",
      "longitude": "106.70867",
      "latitude": "10.73332",
      "promotion": "Save 5%",
      "supplierCode": "s007",
      "hotelAddress": "R4-76 Hung Gia 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "1551297.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room (No Window)",
            "roomCode": "200749802",
            "boardName": "Full Breakfast",
            "specialOffer": "Member’s price: 20%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room (No Window)",
            "roomCode": "200749802",
            "boardName": "Full Breakfast",
            "specialOffer": "Member’s price: 20%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "21F4D",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "468183",
      "cover": "http://i.travelapi.com/hotels/9000000/8710000/8702200/8702130/aea06fde_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Saigon Europe Hotel & Spa",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Saigon Europe Hotel & Spa places you in the heart of Ho Chi Minh City, steps from Pham Ngu Lao Backpacker Area and Bui Vien Walking Street.  This hotel is …",
      "longitude": "106.69461",
      "latitude": "10.76713",
      "promotion": "Member’s price: 20%",
      "supplierCode": "s007",
      "hotelAddress": "207 De Tham Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "1564761.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double or Twin Room, 1 Double or 2 Twin Beds, No Windows",
            "roomCode": "200156807",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Save 35%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double or Twin Room, 1 Double or 2 Twin Beds, No Windows",
            "roomCode": "200156807",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Save 35%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "22399",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "404910",
      "cover": "http://i.travelapi.com/hotels/6000000/5010000/5000100/5000001/dad7eadf_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Queen Ann Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Queen Ann Hotel places you in the heart of Ho Chi Minh City, within a 10-minute walk of Zen Plaza and September 23 Park.  This hotel is 0.5 mi (0.7 km) …",
      "longitude": "106.68964",
      "latitude": "10.7711",
      "promotion": "Save 35%",
      "supplierCode": "s007",
      "hotelAddress": "86-88 Bui Thi Xuan Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "1568678.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Room",
            "roomCode": "201700531",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Room",
            "roomCode": "201700531",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "224D9",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "630412",
      "cover": "http://i.travelapi.com/hotels/17000000/16250000/16246000/16245963/c5ff7fc2_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Hoang Ngoc My Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Hoang Ngoc My Hotel in Ho Chi Minh City, you'll be a 5-minute walk from An Dong Market and 14 minutes by foot from Cho Quan Church.  This hotel is 1 …",
      "longitude": "106.67338",
      "latitude": "10.75742",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "11A-13 An Duong Vuong, "
    },
    {
      "roomGroup": {
        "totalPrice": "1574308.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "200459192",
            "boardName": "",
            "specialOffer": "Save 30%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "200459192",
            "boardName": "",
            "specialOffer": "Save 30%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "226A5",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "446275",
      "cover": "http://i.travelapi.com/hotels/8000000/7090000/7081000/7080968/65701a9a_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Saigon Pink 2 Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Saigon Pink 2 Hotel places you in the heart of Ho Chi Minh City, steps from Temple of Mariamman and 2 minutes by foot from Ben Thanh Market.  This hotel is …",
      "longitude": "106.69696",
      "latitude": "10.7718",
      "promotion": "Save 30%",
      "supplierCode": "s007",
      "hotelAddress": "32 Nguyen An Ninh St, District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "1575288.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Luxury Double Room, Balcony",
            "roomCode": "202234051",
            "boardName": "",
            "specialOffer": "",
            "availability": "8",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Luxury Double Room, Balcony",
            "roomCode": "202234051",
            "boardName": "",
            "specialOffer": "",
            "availability": "8",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "226F5",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "764873",
      "cover": "http://i.travelapi.com/hotels/21000000/20310000/20300600/20300573/04ffa4a7_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Doha Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Doha Hotel in Ho Chi Minh City, you'll be in a shopping district, just a 5-minute walk from Parkson CT Plaza and 14 minutes by foot from Gia Dinh …",
      "longitude": "106.66662",
      "latitude": "10.81255",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "2/17 Hong Ha - Phuong 2 - Quan Tan Binh, "
    },
    {
      "roomGroup": {
        "totalPrice": "1580918.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Room",
            "roomCode": "202003239",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Room",
            "roomCode": "202003239",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "228C1",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "700857",
      "cover": "http://i.travelapi.com/hotels/19000000/18660000/18654000/18653969/13cfb1f1_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Bao Minh Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Bao Minh Hotel in Ho Chi Minh City, you'll be a 4-minute walk from Parkson CT Plaza and 13 minutes by foot from Gia Dinh Park.  This hotel is 1 mi …",
      "longitude": "106.66745",
      "latitude": "10.81489",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "B12 Bach Dang, "
    },
    {
      "roomGroup": {
        "totalPrice": "1584100.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room (No Window)",
            "roomCode": "200130773",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Tonight only: save 40%",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room (No Window)",
            "roomCode": "200130773",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Tonight only: save 40%",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "229C5",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "398427",
      "cover": "http://i.travelapi.com/hotels/5000000/4800000/4799200/4799145/b023c5ad_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Thien Xuan Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Thien Xuan Hotel places you in the heart of Ho Chi Minh City, steps from Taka Plaza and 3 minutes by foot from Benthanh Street Food Market.  This hotel is …",
      "longitude": "106.69866",
      "latitude": "10.7738",
      "promotion": "Tonight only: save 40%",
      "supplierCode": "s007",
      "hotelAddress": "108 - 110 Le Thanh Ton, Ben Thanh Ward, "
    },
    {
      "roomGroup": {
        "totalPrice": "1588996.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room, 1 Queen Bed",
            "roomCode": "220532413",
            "boardName": "",
            "specialOffer": "Member’s price: 35%",
            "availability": "6",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room, 1 Queen Bed",
            "roomCode": "220532413",
            "boardName": "",
            "specialOffer": "Member’s price: 35%",
            "availability": "6",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "22B55",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "594376",
      "cover": "http://i.travelapi.com/hotels/16000000/15210000/15200800/15200703/680aa7b7_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Alden Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Alden Hotel  places you in the heart of Ho Chi Minh City, within a 5-minute walk of Temple of Mariamman and Zen Plaza.  This hotel is 0.3 mi (0.5 km) from …",
      "longitude": "106.69396",
      "latitude": "10.77178",
      "promotion": "Member’s price: 35%",
      "supplierCode": "s007",
      "hotelAddress": "260 Ly Tu Trong, Ben Thanh Ward, "
    },
    {
      "roomGroup": {
        "totalPrice": "1624492.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double or Twin Room",
            "roomCode": "202360096",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 10%",
            "availability": "15",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double or Twin Room",
            "roomCode": "202360096",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 10%",
            "availability": "15",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "236A9",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "797777",
      "cover": "http://i.travelapi.com/hotels/22000000/21540000/21539900/21539846/8e8b824c_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "A25 Hotel Le Thi Rieng",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at A25 Hotel Le Thi Rieng in Ho Chi Minh City (Bui Thi Xuan), you'll be within a 10-minute walk of Pham Ngu Lao Backpacker Area and Zen Plaza.  This …",
      "longitude": "106.68913",
      "latitude": "10.77032",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "145 Le Thi Rieng, Ben Thanh Ward, "
    },
    {
      "roomGroup": {
        "totalPrice": "1629633.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Room, No Windows",
            "roomCode": "201419548",
            "boardName": "Breakfast Buffet",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Room, No Windows",
            "roomCode": "201419548",
            "boardName": "Breakfast Buffet",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "2384D",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "571006",
      "cover": "http://i.travelapi.com/hotels/14000000/13440000/13434600/13434581/5c2bbada_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Halo Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Halo Hotel in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Benthanh Street Food Market and 3 minutes by foot from Ben Thanh …",
      "longitude": "106.69787",
      "latitude": "10.77332",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "23 Thu Khoa Huan Street, Ben Thanh Ward, "
    },
    {
      "roomGroup": {
        "totalPrice": "1629633.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "202292466",
            "boardName": "",
            "specialOffer": "",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "202292466",
            "boardName": "",
            "specialOffer": "",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": false,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "2384D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "778321",
      "cover": "http://i.travelapi.com/hotels/22000000/21050000/21049200/21049146/5a4258ac_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "City Point Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at City Point Hotel in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Bui Vien Walking Street and Pham Ngu Lao Backpacker Area.  This …",
      "longitude": "106.6949",
      "latitude": "10.76787",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "18 Bui Vien, Pham Ngu Lao Ward, "
    },
    {
      "roomGroup": {
        "totalPrice": "1629633.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Exclusive Studio",
            "roomCode": "216911745",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Exclusive Studio",
            "roomCode": "216911745",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "2384D",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "968023",
      "cover": "http://i.travelapi.com/hotels/27000000/26830000/26829500/26829464/f1c8fbe8_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "SkyDragon Place",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at this apartment in Ho Chi Minh City (Bach Dang Riverside), you'll be within a 15-minute walk of Riverside and Nha Rong Wharf.  This apartment is 0.8 mi …",
      "longitude": "106.69829",
      "latitude": "10.76273",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "151 Ben Van Don Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "1629633.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Studio",
            "roomCode": "217813958",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Studio",
            "roomCode": "217813958",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "2384D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "953488",
      "cover": "http://i.travelapi.com/hotels/26000000/25840000/25835500/25835460/fc5b5740_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Minimalist Apartment Rivergate",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Minimalist Apartment Rivergate in Ho Chi Minh City (Bach Dang Riverside), you'll be within a 15-minute walk of Riverside and Bui Vien Walking Street.  …",
      "longitude": "106.6994",
      "latitude": "10.76187",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "Rivergate Resident, "
    },
    {
      "roomGroup": {
        "totalPrice": "1629633.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Room",
            "roomCode": "221120556",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Room",
            "roomCode": "221120556",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "2384D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1014486",
      "cover": "http://i.travelapi.com/hotels/28000000/27480000/27474500/27474460/f9f50f6d_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Holland Guest House",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, Holland Guest House is minutes from Saigon Culinary Arts Centre and close to Bui Vien Walking Street.  This guesthouse is within close …",
      "longitude": "106.68926",
      "latitude": "10.76023",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "345/36 Tran Hung Dao, District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "1629633.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Comfort Studio Suite, 1 Queen Bed, Pool Access, City View",
            "roomCode": "218411288",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Comfort Studio Suite, 1 Queen Bed, Pool Access, City View",
            "roomCode": "218411288",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": false,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "2384D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "930038",
      "cover": "http://i.travelapi.com/hotels/25000000/24920000/24913600/24913581/334ee19b_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Macy Studio Apartment",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Macy Studio Apartment in Ho Chi Minh City (Bach Dang Riverside), you'll be within a 15-minute walk of Riverside and Bui Vien Walking Street.  This …",
      "longitude": "106.699",
      "latitude": "10.76219",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "151 Ben Van Don Dist.4, "
    },
    {
      "roomGroup": {
        "totalPrice": "1637712.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "201159028",
            "boardName": "Free Breakfast",
            "specialOffer": "Save 24%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "201159028",
            "boardName": "Free Breakfast",
            "specialOffer": "Save 24%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "23AE1",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "532527",
      "cover": "http://i.travelapi.com/hotels/12000000/11570000/11569800/11569748/ca20b85d_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Beautiful Saigon 3 Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Beautiful Saigon 3 Hotel in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Pham Ngu Lao Backpacker Area and Bui Vien Walking …",
      "longitude": "106.69415",
      "latitude": "10.76816",
      "promotion": "Save 24%",
      "supplierCode": "s007",
      "hotelAddress": "40/27 Bui Vien street, District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "1642118.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "First Category",
            "roomCode": "200845133",
            "boardName": "Breakfast Buffet",
            "specialOffer": "",
            "availability": "20",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "First Category",
            "roomCode": "200845133",
            "boardName": "Breakfast Buffet",
            "specialOffer": "",
            "availability": "20",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "23C49",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "483007",
      "cover": "http://i.travelapi.com/hotels/10000000/9560000/9557100/9557009/b9ca7295_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Les Hameaux de l'Orient",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Les Hameaux de l'Orient in Ho Chi Minh City, you'll be in the historical district, and 26.1 mi (42.1 km) from Ho Chi Minh City International …",
      "longitude": "106.43522",
      "latitude": "11.06232",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "Rang Hamlet, "
    },
    {
      "roomGroup": {
        "totalPrice": "1658030.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "201405085",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Save 15%",
            "availability": "8",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "201405085",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Save 15%",
            "availability": "8",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "2415D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "568592",
      "cover": "http://i.travelapi.com/hotels/14000000/13340000/13336000/13335922/13335922_29_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Queen Central Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Queen Central Hotel in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Temple of Mariamman and 2 minutes by foot from Ben Thanh …",
      "longitude": "106.69695",
      "latitude": "10.77181",
      "promotion": "Save 15%",
      "supplierCode": "s007",
      "hotelAddress": "38-40 Nguyen An Ninh st, Dist 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "1659009.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Fun Room, No Window",
            "roomCode": "201625180",
            "boardName": "Free Breakfast",
            "specialOffer": "Tonight only: save 30%",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Fun Room, No Window",
            "roomCode": "201625180",
            "boardName": "Free Breakfast",
            "specialOffer": "Tonight only: save 30%",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "241AD",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "617204",
      "cover": "http://i.travelapi.com/hotels/16000000/15820000/15811800/15811742/43f36351_t.jpg",
      "rate": "3.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "zoolut Stay 271",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at zoolut Stay 271 in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Temple of Mariamman and 4 minutes by foot from Benthanh Street …",
      "longitude": "106.69567",
      "latitude": "10.77189",
      "promotion": "Tonight only: save 30%",
      "supplierCode": "s007",
      "hotelAddress": "271 Le Thanh Ton, "
    },
    {
      "roomGroup": {
        "totalPrice": "1665619.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Basic Double or Twin Room, 1 Bedroom, Non Smoking",
            "roomCode": "202398680",
            "boardName": "",
            "specialOffer": "",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Basic Double or Twin Room, 1 Bedroom, Non Smoking",
            "roomCode": "202398680",
            "boardName": "",
            "specialOffer": "",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "243C9",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "582255",
      "cover": "http://i.travelapi.com/hotels/15000000/14920000/14912200/14912137/562ef135_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Kelly Apartment Thao Dien",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Kelly Apartment Thao Dien in Ho Chi Minh City (Thao Dien), you'll be within a 15-minute drive of Vincom Mega Mall and Van Thanh Tourist Park.  This …",
      "longitude": "106.73002",
      "latitude": "10.80634",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "No 12, Street 43, "
    },
    {
      "roomGroup": {
        "totalPrice": "1665619.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "220503934",
            "boardName": "Free Breakfast",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "220503934",
            "boardName": "Free Breakfast",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": false,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "243C9",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "854352",
      "cover": "http://i.travelapi.com/hotels/24000000/23050000/23043900/23043850/2bcc7f5b_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Nak Won Hung Vuong 1 Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City (Phu My Hung), Nak Won Hung Vuong 1 Hotel is within a 5-minute drive of SC VivoCity and The Cresent Mall.  This hotel is 1.2 mi (1.9 km) …",
      "longitude": "106.70732",
      "latitude": "10.72961",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "R4-56,57 Hung Phuoc 4, "
    },
    {
      "roomGroup": {
        "totalPrice": "1668067.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double Room",
            "roomCode": "201501735",
            "boardName": "Breakfast for 2",
            "specialOffer": "Private sale: save 20%",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double Room",
            "roomCode": "201501735",
            "boardName": "Breakfast for 2",
            "specialOffer": "Private sale: save 20%",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "24491",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "589980",
      "cover": "http://i.travelapi.com/hotels/16000000/15060000/15059200/15059106/cec0c9e1_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Golden Star Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Golden Star Hotel in Ho Chi Minh City (Dong Khoi), you'll be steps from Dong Khoi Shopping Street and Saigon River.  This hotel is 0.1 mi (0.1 km) …",
      "longitude": "106.70301",
      "latitude": "10.77857",
      "promotion": "Private sale: save 20%",
      "supplierCode": "s007",
      "hotelAddress": "60 Le Thanh Ton, Ben Nghe Ward, "
    },
    {
      "roomGroup": {
        "totalPrice": "1675656.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "200238635",
            "boardName": "",
            "specialOffer": "",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "200238635",
            "boardName": "",
            "specialOffer": "",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "246FD",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "424137",
      "cover": "http://i.travelapi.com/hotels/6000000/5610000/5607200/5607189/3983f488_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Faifoo Boutique Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, Faifoo Boutique Hotel is connected to a shopping center, within a 10-minute drive of Jade Emperor Pagoda and Van Thanh Tourist Park.  …",
      "longitude": "106.697",
      "latitude": "10.80638",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "97/3 Le Quang Dinh St., Ward 14, "
    },
    {
      "roomGroup": {
        "totalPrice": "1686427.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double Room",
            "roomCode": "218709719",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double Room",
            "roomCode": "218709719",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "24A6D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "911643",
      "cover": "http://i.travelapi.com/hotels/25000000/24180000/24178400/24178368/6a72221b_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Paiza Residences & Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Paiza Residences & Hotel in Ho Chi Minh City, you'll be 1.3 mi (2.1 km) from Saigon Exhibition and Convention Center and 5.9 mi (9.5 km) from Museum …",
      "longitude": "106.7326",
      "latitude": "10.7205",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "Nha So 2, Duong So 20, "
    },
    {
      "roomGroup": {
        "totalPrice": "1704052.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "VIP Room",
            "roomCode": "220523694",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "15",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "VIP Room",
            "roomCode": "220523694",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "15",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "2500D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1025144",
      "cover": "http://i.travelapi.com/hotels/29000000/28880000/28876800/28876723/eb104cd9_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Moc Lan 4 Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City (Phu Nhuan), Moc Lan 4 Hotel is convenient to Jade Emperor Pagoda and Ear Nose Throat Hospital.  This hotel is within close proximity of …",
      "longitude": "106.68846",
      "latitude": "10.79675",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "64/8 Cu Lao Street, Ward 2, "
    },
    {
      "roomGroup": {
        "totalPrice": "1724371.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double Room (5B/4B/3B/2B)",
            "roomCode": "202118659",
            "boardName": "",
            "specialOffer": "",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double Room (5B/4B/3B/2B)",
            "roomCode": "202118659",
            "boardName": "",
            "specialOffer": "",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "25689",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "726983",
      "cover": "http://i.travelapi.com/hotels/20000000/19490000/19489200/19489178/63d46c8a_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "The Nguyens Café DCT",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, The Nguyens Café DCT is within a 15-minute walk of Southern Vietnam Women Museum and Jade Emperor Pagoda.  This hotel is 0.8 mi (1.3 km) …",
      "longitude": "106.69107",
      "latitude": "10.78923",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "64 Dinh Cong Trang, "
    },
    {
      "roomGroup": {
        "totalPrice": "1724371.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Design Apartment, 1 Bedroom, Pool View",
            "roomCode": "221113772",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Design Apartment, 1 Bedroom, Pool View",
            "roomCode": "221113772",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "25689",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "804111",
      "cover": "http://i.travelapi.com/hotels/22000000/21880000/21876800/21876744/649bb8e8_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Nancy Apartment",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City (Hang Xanh), Nancy Apartment  is within a 15-minute drive of Riverside and Opera House.  This apartment is 2.8 mi (4.5 km) from Saigon …",
      "longitude": "106.71912",
      "latitude": "10.79569",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "208 Nguyen Huu Canh, "
    },
    {
      "roomGroup": {
        "totalPrice": "1743955.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "201781686",
            "boardName": "Free Breakfast",
            "specialOffer": "",
            "availability": "7",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Double Room",
            "roomCode": "201781686",
            "boardName": "Free Breakfast",
            "specialOffer": "",
            "availability": "7",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "25CC9",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "650660",
      "cover": "http://i.travelapi.com/hotels/18000000/17050000/17040200/17040151/c52eefb8_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Modern Saigon Hotel 2",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, Modern Saigon Hotel 2 is within a 15-minute drive of Ho Chi Minh City International Exhibition and Convention Centre and Vinh Nghiem …",
      "longitude": "106.66023",
      "latitude": "10.80288",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "20 Ba Vi Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "1781409.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double Room, 1 Double Bed, Smoking",
            "roomCode": "219318049",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double Room, 1 Double Bed, Smoking",
            "roomCode": "219318049",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "268BD",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "971703",
      "cover": "http://i.travelapi.com/hotels/27000000/26980000/26970100/26970040/59770e3d_t.jpg",
      "rate": "3.0",
      "destinationName": "Thuan An",
      "hotelName": "Phuong Nam Resort",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Phuong Nam Resort in Thuan An, you'll be 7.1 mi (11.5 km) from Van Thanh Tourist Park and 7.6 mi (12.3 km) from Gia Dinh Park.  This hotel is 7.8 mi …",
      "longitude": "106.70354",
      "latitude": "10.87463",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "15/12, "
    },
    {
      "roomGroup": {
        "totalPrice": "1792425.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Apartment, 1 Bedroom, Smoking",
            "roomCode": "201996227",
            "boardName": "",
            "specialOffer": "Save 55%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Apartment, 1 Bedroom, Smoking",
            "roomCode": "201996227",
            "boardName": "",
            "specialOffer": "Save 55%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "26C41",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "699868",
      "cover": "http://i.travelapi.com/hotels/19000000/18630000/18620500/18620413/4e54b075_t.jpg",
      "rate": "3.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Diamond Luxury Ben Thanh",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Diamond Luxury Ben Thanh in Ho Chi Minh City, you'll be within a 5-minute walk of Pham Ngu Lao Backpacker Area and Bui Vien Walking Street.  This …",
      "longitude": "106.69672",
      "latitude": "10.76814",
      "promotion": "Save 55%",
      "supplierCode": "s007",
      "hotelAddress": "100/6 Le Thi Hong Gam, "
    },
    {
      "roomGroup": {
        "totalPrice": "1805644.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Signature Apartment, 1 Bedroom",
            "roomCode": "211802104",
            "boardName": "",
            "specialOffer": "Save 50%",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Signature Apartment, 1 Bedroom",
            "roomCode": "211802104",
            "boardName": "",
            "specialOffer": "Save 50%",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "27079",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "403872",
      "cover": "http://i.travelapi.com/hotels/5000000/4960000/4951600/4951595/cdbbf800_t.jpg",
      "rate": "4.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Saigon View Residences",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Saigon View Residences in Ho Chi Minh City (Hang Xanh), you'll be within a 10-minute drive of Van Thanh Tourist Park and Vietnam National Museum of …",
      "longitude": "106.7066",
      "latitude": "10.79593",
      "promotion": "Save 50%",
      "supplierCode": "s007",
      "hotelAddress": "117 Nguyen Cuu Van Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "1805644.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Queen Studio",
            "roomCode": "202193121",
            "boardName": "",
            "specialOffer": "Book now and save!",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Queen Studio",
            "roomCode": "202193121",
            "boardName": "",
            "specialOffer": "Book now and save!",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "27079",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "750700",
      "cover": "http://i.travelapi.com/hotels/21000000/20020000/20013700/20013673/b0e26a52_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Byla Studio",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, Byla Studio is a 4-minute drive from Jade Emperor Pagoda and 5 minutes from Southern Vietnam Women Museum.  This aparthotel is 1 mi (1.6 …",
      "longitude": "106.69216",
      "latitude": "10.79171",
      "promotion": "Book now and save!",
      "supplierCode": "s007",
      "hotelAddress": "128 Nguyen Phi Khanh, District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "1810540.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Twin Room",
            "roomCode": "202155821",
            "boardName": "Free Breakfast",
            "specialOffer": "Book now and save!",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Twin Room",
            "roomCode": "202155821",
            "boardName": "Free Breakfast",
            "specialOffer": "Book now and save!",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "27209",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "742386",
      "cover": "http://i.travelapi.com/hotels/20000000/19820000/19816100/19816028/744205d1_t.jpg",
      "rate": "3.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Minh Tam Hotel & Spa 3/2",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Minh Tam Hotel & Spa 3/2 in Ho Chi Minh City, you'll be within a 10-minute walk of Quoc Tu Pagoda and Museum of Traditional Vietnamese Medicine.  This …",
      "longitude": "106.6782",
      "latitude": "10.77412",
      "promotion": "Book now and save!",
      "supplierCode": "s007",
      "hotelAddress": "206 Ba Thang Hai Street, District 10, "
    },
    {
      "roomGroup": {
        "totalPrice": "1841630.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Executive Suite",
            "roomCode": "202073865",
            "boardName": "",
            "specialOffer": "Tonight only: save 15%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Executive Suite",
            "roomCode": "202073865",
            "boardName": "",
            "specialOffer": "Tonight only: save 15%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "27BF5",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "718419",
      "cover": "http://i.travelapi.com/hotels/20000000/19270000/19267300/19267299/5e2bb215_t.jpg",
      "rate": "3.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Diamond Suite Central",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Diamond Suite Central in Ho Chi Minh City, you'll be a 4-minute walk from Museum of Fine Arts and 5 minutes by foot from Pham Ngu Lao Backpacker Area. …",
      "longitude": "106.69777",
      "latitude": "10.76962",
      "promotion": "Tonight only: save 15%",
      "supplierCode": "s007",
      "hotelAddress": "199 Calmette Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "1850443.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Gold Green View Room",
            "roomCode": "214516844",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 10%",
            "availability": "9",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Gold Green View Room",
            "roomCode": "214516844",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 10%",
            "availability": "9",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "27EC5",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1033965",
      "cover": "http://i.travelapi.com/hotels/30000000/29290000/29285200/29285173/417542f8_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Aiden Saigon Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Aiden Saigon Hotel in Ho Chi Minh City, you'll be convenient to Binh Tay Market and Dam Sen Park.  This hotel is within close proximity of Dam Sen …",
      "longitude": "106.62906",
      "latitude": "10.74202",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "28-30-32-34 Duong So 26, Phuong 11, "
    },
    {
      "roomGroup": {
        "totalPrice": "1873944.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "202128272",
            "boardName": "Free Breakfast",
            "specialOffer": "Save 50%",
            "availability": "15",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "202128272",
            "boardName": "Free Breakfast",
            "specialOffer": "Save 50%",
            "availability": "15",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "28645",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "733155",
      "cover": "http://i.travelapi.com/hotels/20000000/19660000/19655900/19655857/8d73bc22_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "A25 Nguyen Trai",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at A25 Nguyen Trai in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Zen Plaza and 4 minutes by foot from September 23 Park.  This …",
      "longitude": "106.69319",
      "latitude": "10.77083",
      "promotion": "Save 50%",
      "supplierCode": "s007",
      "hotelAddress": "180-184 Nguyen Trai St., Ben Thanh Ward, "
    },
    {
      "roomGroup": {
        "totalPrice": "1873944.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Studio",
            "roomCode": "218121502",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Studio",
            "roomCode": "218121502",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "28645",
        "contractName": ""
      },
      "destinationCode": "TA ",
      "hotelId": "967019",
      "cover": "http://i.travelapi.com/hotels/27000000/26820000/26811800/26811738/ceec4ee6_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Spacious Saigon",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Spacious Saigon in Ho Chi Minh City (Bach Dang Riverside), you'll be a 4-minute drive from Pham Ngu Lao Backpacker Area and 5 minutes from Riverside.  …",
      "longitude": "106.6987",
      "latitude": "10.76281",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "151 Ben Van Don District 4, "
    },
    {
      "roomGroup": {
        "totalPrice": "1900872.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Studio",
            "roomCode": "215704041",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Studio",
            "roomCode": "215704041",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "28EDD",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "868977",
      "cover": "http://i.travelapi.com/hotels/24000000/23240000/23235400/23235382/0770e8b8_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Apartment River View Near City Center",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at this apartment in Ho Chi Minh City (Bach Dang Riverside), you'll be within a 15-minute walk of Riverside and Nha Rong Wharf.  This apartment is 0.8 mi …",
      "longitude": "106.69849",
      "latitude": "10.76289",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "151-155 Ben Van Don, "
    },
    {
      "roomGroup": {
        "totalPrice": "1953014.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Executive Triple Room (With Window)",
            "roomCode": "202273488",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 55%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Executive Triple Room (With Window)",
            "roomCode": "202273488",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 55%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "29F81",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "655087",
      "cover": "http://i.travelapi.com/hotels/18000000/17230000/17224500/17224466/17479133_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Polygon Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Polygon Hotel places you in the heart of Ho Chi Minh City, steps from Benthanh Street Food Market and 3 minutes by foot from Temple of Mariamman.  This …",
      "longitude": "106.697",
      "latitude": "10.77389",
      "promotion": "Private sale: save 55%",
      "supplierCode": "s007",
      "hotelAddress": "120 Ly Tu Trong Street, Ben Thanh Ward, "
    },
    {
      "roomGroup": {
        "totalPrice": "1955707.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "1 Bedroom Apartment",
            "roomCode": "218108117",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "1 Bedroom Apartment",
            "roomCode": "218108117",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": false,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "2A05D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "904168",
      "cover": "http://i.travelapi.com/hotels/25000000/24070000/24061900/24061884/a2080feb_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Fuji Landmark",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Fuji Landmark in Ho Chi Minh City, you'll be within a 5-minute walk of War Remnants Museum and Golden Dragon Water Puppet Theatre.  This aparthotel is …",
      "longitude": "106.69216",
      "latitude": "10.77852",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "17 Vo Van Tan, "
    },
    {
      "roomGroup": {
        "totalPrice": "1955707.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room, 1 Queen Bed",
            "roomCode": "200118078",
            "boardName": "Continental Breakfast",
            "specialOffer": "Private sale: save 10%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room, 1 Queen Bed",
            "roomCode": "200118078",
            "boardName": "Continental Breakfast",
            "specialOffer": "Private sale: save 10%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "2A05D",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "395118",
      "cover": "http://i.travelapi.com/hotels/5000000/4700000/4696200/4696164/6775235b_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Bizu Boutique Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Bizu Boutique Hotel in Ho Chi Minh City (Phu My Hung), you'll be within a 5-minute drive of FV Hospital and The Cresent Mall.  This hotel is 0.6 mi (1 …",
      "longitude": "106.70957",
      "latitude": "10.732",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "15 - 17 Cao Trieu Phat, Hung Phuoc 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "1955707.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "1 Bedroom Apartment",
            "roomCode": "218416080",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "1 Bedroom Apartment",
            "roomCode": "218416080",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "2A05D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "970798",
      "cover": "http://i.travelapi.com/hotels/27000000/26950000/26947100/26947059/fc382237_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Halen Cozy Apartments",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at this apartment in Ho Chi Minh City (Hang Xanh), you'll be within a 10-minute drive of Van Thanh Tourist Park and Vincom Mega Mall.  This apartment is …",
      "longitude": "106.71928",
      "latitude": "10.79553",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "208 nguyen huu canh, "
    },
    {
      "roomGroup": {
        "totalPrice": "1956441.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room (No Window)",
            "roomCode": "200230703",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Private sale: save 35%",
            "availability": "15",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room (No Window)",
            "roomCode": "200230703",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Private sale: save 35%",
            "availability": "15",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "2A099",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "403819",
      "cover": "http://i.travelapi.com/hotels/5000000/4960000/4950900/4950803/cb07754f_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Ha Hien Signature Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Ha Hien Signature Hotel places you in the heart of Ho Chi Minh City, steps from Benthanh Street Food Market and 3 minutes by foot from Temple of Mariamman. …",
      "longitude": "106.69681",
      "latitude": "10.77376",
      "promotion": "Private sale: save 35%",
      "supplierCode": "s007",
      "hotelAddress": "145-147 Ly Tu Trong Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "1961827.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Studio Suite, 1 Queen Bed, Pool Access, City View",
            "roomCode": "217814089",
            "boardName": "",
            "specialOffer": "Save 30%",
            "availability": "10",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Studio Suite, 1 Queen Bed, Pool Access, City View",
            "roomCode": "217814089",
            "boardName": "",
            "specialOffer": "Save 30%",
            "availability": "10",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "2A251",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "909758",
      "cover": "http://i.travelapi.com/hotels/25000000/24160000/24155500/24155476/e6b65078_t.jpg",
      "rate": "3.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Rivergate Apartment",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Rivergate Apartment places you in the heart of Ho Chi Minh City, within a 15-minute walk of Riverside and Nha Rong Wharf.  This apartment is 0.8 mi (1.3 …",
      "longitude": "106.69853",
      "latitude": "10.76284",
      "promotion": "Save 30%",
      "supplierCode": "s007",
      "hotelAddress": "151 Ben Van Don Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "1984348.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Twin Room",
            "roomCode": "201394253",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 50%",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Twin Room",
            "roomCode": "201394253",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 50%",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "2A981",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "566564",
      "cover": "http://i.travelapi.com/hotels/14000000/13250000/13242800/13242777/3742b3b9_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Lavender Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Lavender Hotel in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Temple of Mariamman and 5 minutes by foot from Benthanh Street …",
      "longitude": "106.69507",
      "latitude": "10.77206",
      "promotion": "Private sale: save 50%",
      "supplierCode": "s007",
      "hotelAddress": "47-49-51 Le Anh Xuan Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "1991692.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double Room",
            "roomCode": "200352761",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Save 50%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double Room",
            "roomCode": "200352761",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Save 50%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "2ABD9",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "441030",
      "cover": "http://i.travelapi.com/hotels/7000000/6610000/6601000/6600986/6600986_69_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Rosa Hotel & Spa",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Rosa Hotel & Spa places you in the heart of Ho Chi Minh City, steps from Benthanh Street Food Market and 4 minutes by foot from Temple of Mariamman.  This …",
      "longitude": "106.69663",
      "latitude": "10.77443",
      "promotion": "Save 50%",
      "supplierCode": "s007",
      "hotelAddress": "55 Thu Khoa Huan Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "1991692.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Apartment, 1 Bedroom",
            "roomCode": "202417667",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Apartment, 1 Bedroom",
            "roomCode": "202417667",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "2ABD9",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "807833",
      "cover": "http://i.travelapi.com/hotels/22000000/21970000/21960600/21960598/24c8ecbe_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Queen Central Hotel Apartment",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, Queen Central Hotel Apartment is in a shopping district, within a 15-minute walk of Jade Emperor Pagoda and Southern Vietnam Women …",
      "longitude": "106.69201",
      "latitude": "10.78996",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "37/4 Dinh Cong Trang, "
    },
    {
      "roomGroup": {
        "totalPrice": "1992672.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Studio",
            "roomCode": "218415793",
            "boardName": "",
            "specialOffer": "Save 29%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Studio",
            "roomCode": "218415793",
            "boardName": "",
            "specialOffer": "Save 29%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "2AC29",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "958482",
      "cover": "http://i.travelapi.com/hotels/27000000/26590000/26588600/26588546/2cd021fa_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "The Sargon",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at The Sargon places you in the heart of Ho Chi Minh City, within a 15-minute walk of Pham Ngu Lao Backpacker Area and September 23 Park.  This aparthotel is …",
      "longitude": "106.68561",
      "latitude": "10.77028",
      "promotion": "Save 29%",
      "supplierCode": "s007",
      "hotelAddress": "2/42 Cao Thang, "
    },
    {
      "roomGroup": {
        "totalPrice": "2000505.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "509533",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Private sale: save 40%",
            "availability": "6",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "509533",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Private sale: save 40%",
            "availability": "6",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "2AEA9",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "351497",
      "cover": "http://i.travelapi.com/hotels/4000000/3660000/3651500/3651437/a175adf0_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Blue Diamond Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Blue Diamond Hotel places you in the heart of Ho Chi Minh City, steps from Benthanh Street Food Market and 4 minutes by foot from Temple of Mariamman.  …",
      "longitude": "106.69685",
      "latitude": "10.77429",
      "promotion": "Private sale: save 40%",
      "supplierCode": "s007",
      "hotelAddress": "48-50 Thu Khoa Huan Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "2016907.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room, 1 Double Bed",
            "roomCode": "200141832",
            "boardName": "Continental Breakfast",
            "specialOffer": "Private sale: save 42%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room, 1 Double Bed",
            "roomCode": "200141832",
            "boardName": "Continental Breakfast",
            "specialOffer": "Private sale: save 42%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "2B3E5",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "401460",
      "cover": "http://i.travelapi.com/hotels/5000000/4890000/4885500/4885457/90076cb4_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Little Saigon Boutique Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Little Saigon Boutique Hotel places you in the heart of Ho Chi Minh City, steps from Ben Thanh Market and 3 minutes by foot from Benthanh Street Food …",
      "longitude": "106.69871",
      "latitude": "10.77246",
      "promotion": "Private sale: save 42%",
      "supplierCode": "s007",
      "hotelAddress": "36 Bis/2 Le Loi Boulevard, "
    },
    {
      "roomGroup": {
        "totalPrice": "2027923.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Premium Deluxe",
            "roomCode": "200702834",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Private sale: save 5%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Premium Deluxe",
            "roomCode": "200702834",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Private sale: save 5%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "2B769",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "459218",
      "cover": "http://i.travelapi.com/hotels/9000000/8260000/8256600/8256537/00ea6f52_t.jpg",
      "rate": "3.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Cosmopolitan Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Cosmopolitan Hotel in Ho Chi Minh City, you'll be within a 10-minute walk of Southern Vietnam Women Museum and Ear Nose Throat Hospital.  This hotel …",
      "longitude": "106.68716",
      "latitude": "10.78666",
      "promotion": "Private sale: save 5%",
      "supplierCode": "s007",
      "hotelAddress": "191 Nam Ky Khoi Nghia, "
    },
    {
      "roomGroup": {
        "totalPrice": "2032084.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "201165529",
            "boardName": "Free Breakfast",
            "specialOffer": "Flash sale: save 30%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "201165529",
            "boardName": "Free Breakfast",
            "specialOffer": "Flash sale: save 30%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "2B8BD",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "533432",
      "cover": "http://i.travelapi.com/hotels/12000000/11610000/11605800/11605755/97befb72_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Hong Hac Boutique Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Hong Hac Boutique Hotel in Ho Chi Minh City, you'll be within a 5-minute walk of Golden Dragon Water Puppet Theatre and Tao Dan Park.  This hotel is …",
      "longitude": "106.69147",
      "latitude": "10.77611",
      "promotion": "Flash sale: save 30%",
      "supplierCode": "s007",
      "hotelAddress": "6 Truong Dinh Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "2043345.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Palm Suite Rooftop",
            "roomCode": "202406468",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Palm Suite Rooftop",
            "roomCode": "202406468",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": false,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "2BC55",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "806831",
      "cover": "http://i.travelapi.com/hotels/22000000/21950000/21947300/21947297/d0b70d9c_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "The Palm Suites",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at The Palm Suites in Ho Chi Minh City (Phu My Hung), you'll be a 5-minute drive from Saigon Paragon Mall and 5 minutes from Saigon Exhibition and …",
      "longitude": "106.73146",
      "latitude": "10.7199",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "444 Tan Phu, C31 Nam Thong 3, "
    },
    {
      "roomGroup": {
        "totalPrice": "2049220.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "200253031",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Member’s price: 20%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "200253031",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Member’s price: 20%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "2BE35",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "426821",
      "cover": "http://i.travelapi.com/hotels/6000000/5780000/5774000/5773986/cc932fc9_t.jpg",
      "rate": "0.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Sunflower Saigon Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Sunflower Saigon Hotel places you in the heart of Ho Chi Minh City, steps from Temple of Mariamman and 3 minutes by foot from Benthanh Street Food Market.  …",
      "longitude": "106.69553",
      "latitude": "10.77288",
      "promotion": "Member’s price: 20%",
      "supplierCode": "s007",
      "hotelAddress": "189 - 191 Ly Tu Trong St., "
    },
    {
      "roomGroup": {
        "totalPrice": "2049955.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Comfort Double Room",
            "roomCode": "216916670",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 10%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Comfort Double Room",
            "roomCode": "216916670",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 10%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "2BE71",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1009264",
      "cover": "http://i.travelapi.com/hotels/29000000/28780000/28774400/28774354/3cd4a31f_t.jpg",
      "rate": "3.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "APA Saigon",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at APA Saigon in Ho Chi Minh City, you'll be convenient to War Remnants Museum and Opera House.  This aparthotel is within close proximity of Ben Thanh …",
      "longitude": "106.69",
      "latitude": "10.79127",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "15/1 Ba Le Chan, Tan Dinh, District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "2055096.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "TeeUP Home Studio (Free Swimming Pool & Gym)",
            "roomCode": "202424630",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "TeeUP Home Studio (Free Swimming Pool & Gym)",
            "roomCode": "202424630",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "2C015",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "807673",
      "cover": "http://i.travelapi.com/hotels/22000000/21960000/21959600/21959518/82b8c7b9_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "TeeUP Home",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City (Bach Dang Riverside), TeeUP Home is within a 15-minute walk of Riverside and Bui Vien Walking Street.  This aparthotel is 0.8 mi (1.2 …",
      "longitude": "106.69873",
      "latitude": "10.76248",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "151-155 Ben Van Don street,  district 4, "
    },
    {
      "roomGroup": {
        "totalPrice": "2067825.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "202292656",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "202292656",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "2C425",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "778481",
      "cover": "http://i.travelapi.com/hotels/22000000/21060000/21054100/21054094/964cd69b_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Matsunoi Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Matsunoi Hotel in Ho Chi Minh City (Little Japan), you'll be steps from Riverside and Saigon River.  This hotel is 0.1 mi (0.1 km) from Dong Khoi …",
      "longitude": "106.70521",
      "latitude": "10.77716",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "24/22 Dong Du, Ben Nghe Ward, District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "2073211.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Family Room",
            "roomCode": "201489413",
            "boardName": "Free Breakfast",
            "specialOffer": "Save 50%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Family Room",
            "roomCode": "201489413",
            "boardName": "Free Breakfast",
            "specialOffer": "Save 50%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "2C5DD",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "583043",
      "cover": "http://i.travelapi.com/hotels/14000000/13460000/13456200/13456192/a0e256a5_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Phung Hoang ParkView",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Phung Hoang ParkView in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Pham Ngu Lao Backpacker Area and 3 minutes by foot from Bui …",
      "longitude": "106.69278",
      "latitude": "10.76845",
      "promotion": "Save 50%",
      "supplierCode": "s007",
      "hotelAddress": "217 Pham Ngu Lao, "
    },
    {
      "roomGroup": {
        "totalPrice": "2082513.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room",
            "roomCode": "202257724",
            "boardName": "Free Breakfast",
            "specialOffer": "",
            "availability": "8",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Double Room",
            "roomCode": "202257724",
            "boardName": "Free Breakfast",
            "specialOffer": "",
            "availability": "8",
            "boardCode": ""
          }
        ],
        "nonRefundable": false,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "2C8D5",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "768518",
      "cover": "http://i.travelapi.com/hotels/21000000/20450000/20449800/20449745/aed19955_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Twins Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Twins Hotel in Ho Chi Minh City (Phu My Hung), you'll be within a 5-minute drive of SC VivoCity and The Cresent Mall.  This hotel is 1.1 mi (1.8 km) …",
      "longitude": "106.70753",
      "latitude": "10.73056",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "26-28 Hung Phuoc 3, "
    },
    {
      "roomGroup": {
        "totalPrice": "2082513.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Apartment, 1 Bedroom, Accessible, Pool View",
            "roomCode": "221117582",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Apartment, 1 Bedroom, Accessible, Pool View",
            "roomCode": "221117582",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "2C8D5",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "768863",
      "cover": "http://i.travelapi.com/hotels/21000000/20410000/20409800/20409791/7e75035d_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Smiley Apartment 14",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Smiley Apartment 14 in Ho Chi Minh City (Hang Xanh), you'll be within a 10-minute drive of Van Thanh Tourist Park and Vincom Mega Mall.  This …",
      "longitude": "106.72118",
      "latitude": "10.79357",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "208 Nguyen Huu Canh, Binh Thanh District, "
    },
    {
      "roomGroup": {
        "totalPrice": "2108707.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Apartment, 1 Bedroom, Balcony, River View",
            "roomCode": "202173491",
            "boardName": "",
            "specialOffer": "Flash sale: save 30%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Apartment, 1 Bedroom, Balcony, River View",
            "roomCode": "202173491",
            "boardName": "",
            "specialOffer": "Flash sale: save 30%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "2D131",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "745081",
      "cover": "http://i.travelapi.com/hotels/20000000/19870000/19869800/19869730/71769c68_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Lily’s Apartments - Icon 56",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Lily’s Apartments - Icon 56 , you'll be centrally located in Ho Chi Minh City, a 7-minute walk from Nha Rong Wharf and 11 minutes by foot from Bitexco …",
      "longitude": "106.70263",
      "latitude": "10.76638",
      "promotion": "Flash sale: save 30%",
      "supplierCode": "s007",
      "hotelAddress": "56 Ben Van Don, Quan 4, "
    },
    {
      "roomGroup": {
        "totalPrice": "2111889.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double or Twin Room",
            "roomCode": "216017807",
            "boardName": "Free Breakfast",
            "specialOffer": "Flash sale: save 30%",
            "availability": "9",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Double or Twin Room",
            "roomCode": "216017807",
            "boardName": "Free Breakfast",
            "specialOffer": "Flash sale: save 30%",
            "availability": "9",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "2D235",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1021883",
      "cover": "http://i.travelapi.com/hotels/30000000/29010000/29005400/29005339/e9adfe03_t.jpg",
      "rate": "3.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Lotus Central Hotel Saigon",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Lotus Central Hotel Saigon in Ho Chi Minh City, you'll be minutes from Museum of Fine Arts and Ben Thanh Market.  This hotel is within close proximity …",
      "longitude": "106.69779",
      "latitude": "10.76911",
      "promotion": "Flash sale: save 30%",
      "supplierCode": "s007",
      "hotelAddress": "102-104-106 Le Thi Hong Gam, District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "2122416.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Room",
            "roomCode": "200230319",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Room",
            "roomCode": "200230319",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "2D591",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "327235",
      "cover": "http://i.travelapi.com/hotels/1000000/10000/3100/3013/0dddeaa8_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Saigon Star Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Saigon Star Hotel places you in the heart of Ho Chi Minh City, steps from Golden Dragon Water Puppet Theatre and 4 minutes by foot from Tao Dan Park.  This …",
      "longitude": "106.69076",
      "latitude": "10.77504",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "204 Nguyen Thi Minh Khai St, Dist 3, "
    },
    {
      "roomGroup": {
        "totalPrice": "2124129.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Apartment, 1 Bedroom",
            "roomCode": "216914401",
            "boardName": "",
            "specialOffer": "Member’s price: 15%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Apartment, 1 Bedroom",
            "roomCode": "216914401",
            "boardName": "",
            "specialOffer": "Member’s price: 15%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "2D61D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "916430",
      "cover": "http://i.travelapi.com/hotels/25000000/24300000/24296100/24296097/afb0312a_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "River Gate Luxury Apartment",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at River Gate Luxury Apartment in Ho Chi Minh City (Bach Dang Riverside), you'll be within a 15-minute walk of Riverside and Nha Rong Wharf.  This …",
      "longitude": "106.69853",
      "latitude": "10.76284",
      "promotion": "Member’s price: 15%",
      "supplierCode": "s007",
      "hotelAddress": "151 Ben Van Don, "
    },
    {
      "roomGroup": {
        "totalPrice": "2127556.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Studio",
            "roomCode": "202408493",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Studio",
            "roomCode": "202408493",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "2D735",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "805936",
      "cover": "http://i.travelapi.com/hotels/22000000/21920000/21916900/21916884/34597915_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Aurora Serviced Apartments - Adults Only",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Aurora Serviced Apartments - Adults Only, you'll be centrally located in Ho Chi Minh City, just a 4-minute walk from Golden Dragon Water Puppet …",
      "longitude": "106.69003",
      "latitude": "10.77604",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "103 Vo Van Tan, Ward 6, District 3, "
    },
    {
      "roomGroup": {
        "totalPrice": "2133676.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Studio",
            "roomCode": "202403108",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Studio",
            "roomCode": "202403108",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "2D929",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "806204",
      "cover": "http://i.travelapi.com/hotels/22000000/21940000/21930400/21930303/9a2851e6_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "The Manor Luxury 1BR Apartment Center",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at The Manor Luxury 1BR Apartment Center in Ho Chi Minh City (Hang Xanh), you'll be within a 10-minute drive of Riverside and Saigon River.  This …",
      "longitude": "106.71791",
      "latitude": "10.79378",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "91 Nguyen Huu Canh, "
    },
    {
      "roomGroup": {
        "totalPrice": "2144448.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Twin Room",
            "roomCode": "220823025",
            "boardName": "Free Breakfast",
            "specialOffer": "Save 30%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Twin Room",
            "roomCode": "220823025",
            "boardName": "Free Breakfast",
            "specialOffer": "Save 30%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "2DC99",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1013987",
      "cover": "http://i.travelapi.com/hotels/29000000/28780000/28774600/28774587/9903eb15_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Au Lac Center Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Au Lac Center Hotel in Ho Chi Minh City, you'll be minutes from Diamond Plaza and Independence Palace.  This hotel is within close proximity of Saigon …",
      "longitude": "106.69591",
      "latitude": "10.78088",
      "promotion": "Save 30%",
      "supplierCode": "s007",
      "hotelAddress": "90 Nguyen Thi Minh Khai,, "
    },
    {
      "roomGroup": {
        "totalPrice": "2155464.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Suite",
            "roomCode": "221409849",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Suite",
            "roomCode": "221409849",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "2E01D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "871870",
      "cover": "http://i.travelapi.com/hotels/24000000/23290000/23281700/23281619/3a1ddfe3_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Comma House",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City (Phu My Hung), Comma House is within a 5-minute drive of FV Hospital and The Cresent Mall.  This hotel is 0.6 mi (1 km) from SC VivoCity …",
      "longitude": "106.70942",
      "latitude": "10.73189",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "37 Cao Trieu Phat Road, Tan Phong Ward, "
    },
    {
      "roomGroup": {
        "totalPrice": "2186064.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Family Room, City View",
            "roomCode": "211802908",
            "boardName": "",
            "specialOffer": "Member’s price: 20%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Family Room, City View",
            "roomCode": "211802908",
            "boardName": "",
            "specialOffer": "Member’s price: 20%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "2E9E1",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "423199",
      "cover": "http://i.travelapi.com/hotels/6000000/5570000/5561500/5561456/a479a66c_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "A&EM Hotel 150 Le Thanh Ton",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at A&EM Hotel 150 Le Thanh Ton places you in the heart of Ho Chi Minh City, steps from Benthanh Street Food Market and 2 minutes by foot from Ben Thanh …",
      "longitude": "106.69718",
      "latitude": "10.77284",
      "promotion": "Member’s price: 20%",
      "supplierCode": "s007",
      "hotelAddress": "150 Le Thanh Ton Street, Ben Nghe Ward, "
    },
    {
      "roomGroup": {
        "totalPrice": "2189491.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room, 1 Queen Bed",
            "roomCode": "221405944",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room, 1 Queen Bed",
            "roomCode": "221405944",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "2EAF9",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "831970",
      "cover": "http://i.travelapi.com/hotels/23000000/22610000/22608900/22608832/d3cd65b1_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "La Regatta Boutique Residences",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at La Regatta Boutique Residences in Ho Chi Minh City, you'll be within a 15-minute walk of Xa Loi Pagoda and Golden Dragon Water Puppet Theatre.  This …",
      "longitude": "106.68607",
      "latitude": "10.77379",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "225/4 Nguyen Dinh Chieu Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "2217888.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Triple Room",
            "roomCode": "200322335",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Member’s price: 65%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Triple Room",
            "roomCode": "200322335",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Member’s price: 65%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "2F409",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "437051",
      "cover": "http://i.travelapi.com/hotels/7000000/6360000/6356800/6356752/634353b9_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "King Star Hotel Thai Van Lung",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at King Star Hotel Thai Van Lung places you in the heart of Ho Chi Minh City, steps from Saigon River and Riverside.  This hotel is 0.2 mi (0.4 km) from Dong …",
      "longitude": "106.7048",
      "latitude": "10.77902",
      "promotion": "Member’s price: 65%",
      "supplierCode": "s007",
      "hotelAddress": "8A/4D2 Thai Van Lung, "
    },
    {
      "roomGroup": {
        "totalPrice": "2263420.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Apartment, 1 Bedroom",
            "roomCode": "215413957",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Apartment, 1 Bedroom",
            "roomCode": "215413957",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "30291",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "921859",
      "cover": "http://i.travelapi.com/hotels/25000000/24400000/24390700/24390614/d312fa88_t.jpg",
      "rate": "3.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Luxury Apartment in Vinhomes",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Luxury Apartment in Vinhomes in Ho Chi Minh City (Hang Xanh), you'll be within a 10-minute drive of Van Thanh Tourist Park and Vincom Mega Mall.  This …",
      "longitude": "106.7203",
      "latitude": "10.79443",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "208 nguyen huu canh street, ward 22, "
    },
    {
      "roomGroup": {
        "totalPrice": "2288635.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room, 1 Double or 2 Twin Beds",
            "roomCode": "499957",
            "boardName": "Breakfast Buffet",
            "specialOffer": "",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room, 1 Double or 2 Twin Beds",
            "roomCode": "499957",
            "boardName": "Breakfast Buffet",
            "specialOffer": "",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "30A9D",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "347067",
      "cover": "http://i.travelapi.com/hotels/4000000/3610000/3603600/3603545/5a93730b_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Hoang Phu Gia",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Hoang Phu Gia places you in the heart of Ho Chi Minh City, within a 10-minute walk of Tao Dan Park and Zen Plaza.  This family-friendly hotel is 0.5 mi …",
      "longitude": "106.69057",
      "latitude": "10.77204",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "19C - 19F Bui Thi Xuan Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "2299896.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Apartment, 1 Bedroom, Balcony, Tower",
            "roomCode": "202120671",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Apartment, 1 Bedroom, Balcony, Tower",
            "roomCode": "202120671",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "30E35",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "731437",
      "cover": "http://i.travelapi.com/hotels/20000000/19570000/19565400/19565309/775ad1cc_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Landmark Inn",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at this apartment in Ho Chi Minh City (Hang Xanh), you'll be within a 10-minute drive of Van Thanh Tourist Park and Vincom Mega Mall.  This apartment is …",
      "longitude": "106.72045",
      "latitude": "10.79452",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "208 Nguyen Huu Canh,Binh Thanh District, "
    },
    {
      "roomGroup": {
        "totalPrice": "2341512.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Suite, 1 Double or 2 Twin Beds",
            "roomCode": "514891",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Save 28%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Suite, 1 Double or 2 Twin Beds",
            "roomCode": "514891",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Save 28%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "31B7D",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "353153",
      "cover": "http://i.travelapi.com/hotels/4000000/3790000/3780600/3780594/d33cb6fa_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "A&EM Corp - The Petit Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at A&EM Corp - The Petit Hotel places you in the heart of Ho Chi Minh City, steps from Temple of Mariamman and Benthanh Street Food Market.  This hotel is 0.3 …",
      "longitude": "106.69606",
      "latitude": "10.77329",
      "promotion": "Save 28%",
      "supplierCode": "s007",
      "hotelAddress": "179 Ly Tu Trong Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "2347632.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Junior Deluxe (City View)",
            "roomCode": "201402242",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Private sale: save 42%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Junior Deluxe (City View)",
            "roomCode": "201402242",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Private sale: save 42%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "31D71",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "568067",
      "cover": "http://i.travelapi.com/hotels/14000000/13300000/13294000/13293919/88a25851_t.jpg",
      "rate": "3.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Le Duy Grand Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Le Duy Grand Hotel in Ho Chi Minh City, you'll be within a 10-minute walk of Xa Loi Pagoda and Golden Dragon Water Puppet Theatre.  This hotel is 0.6 …",
      "longitude": "106.68714",
      "latitude": "10.77405",
      "promotion": "Private sale: save 42%",
      "supplierCode": "s007",
      "hotelAddress": "82-84 Cach Mang Thang 8 St, Ward 6, "
    },
    {
      "roomGroup": {
        "totalPrice": "2366971.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Premium Deluxe Room",
            "roomCode": "201978171",
            "boardName": "Free Breakfast",
            "specialOffer": "",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Premium Deluxe Room",
            "roomCode": "201978171",
            "boardName": "Free Breakfast",
            "specialOffer": "",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "3239D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "694939",
      "cover": "http://i.travelapi.com/hotels/19000000/18440000/18437000/18436985/a0f7c660_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "An Bình Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, An Bình Hotel is within a 10-minute drive of Phu My Bridge and FV Hospital.  This hotel is 1.8 mi (3 km) from Saigon Paragon Mall and …",
      "longitude": "106.73095",
      "latitude": "10.74348",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "No. 41 Tran Trong Cung Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "2382148.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Executive Room",
            "roomCode": "210004788",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Executive Room",
            "roomCode": "210004788",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "32875",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "912496",
      "cover": "http://i.travelapi.com/hotels/25000000/24210000/24203800/24203716/e60000d6_t.jpg",
      "rate": "3.5",
      "destinationName": "Thu Dau Mot",
      "hotelName": "Bcons Hotel Binh Duong",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Bcons Hotel Binh Duong in Thu Dau Mot, you'll be 5.1 mi (8.2 km) from Lac Canh Dai Nam Van Hien Theme Park and 5.8 mi (9.3 km) from Dai Nam Open Zoo.  …",
      "longitude": "106.6501",
      "latitude": "10.97977",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "50 Bach Dang, "
    },
    {
      "roomGroup": {
        "totalPrice": "2382148.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Apartment, 1 King Bed, Accessible, Bathtub",
            "roomCode": "217220961",
            "boardName": "",
            "specialOffer": "Seasonal deal: save 10%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Apartment, 1 King Bed, Accessible, Bathtub",
            "roomCode": "217220961",
            "boardName": "",
            "specialOffer": "Seasonal deal: save 10%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "32875",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "897511",
      "cover": "http://i.travelapi.com/hotels/24000000/23940000/23932300/23932253/297d98d1_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Brilliant HCMC Service Apartments",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Brilliant HCMC Service Apartments, you'll be centrally located in Ho Chi Minh City, within a 10-minute drive of Van Thanh Tourist Park and Vincom Mega …",
      "longitude": "106.71989",
      "latitude": "10.79449",
      "promotion": "Seasonal deal: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "208 Nguyen Huu Canh, "
    },
    {
      "roomGroup": {
        "totalPrice": "2386800.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Premier Room, 1 Double or 2 Twin Beds, Balcony",
            "roomCode": "200025225",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Book now and save!",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Premier Room, 1 Double or 2 Twin Beds, Balcony",
            "roomCode": "200025225",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Book now and save!",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "329F1",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "268942",
      "cover": "http://i.travelapi.com/hotels/3000000/2620000/2617800/2617742/e5365b6b_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Liberty 2 Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Liberty 2 Hotel places you in the heart of Ho Chi Minh City, steps from Saigon River and 4 minutes by foot from Museum of Fine Arts.  This hotel is 0.2 mi …",
      "longitude": "106.70053",
      "latitude": "10.77087",
      "promotion": "Book now and save!",
      "supplierCode": "s007",
      "hotelAddress": "129-133 Ham Nghi Str, District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "2395368.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Studio Suite",
            "roomCode": "216610798",
            "boardName": "",
            "specialOffer": "Save 30%",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Studio Suite",
            "roomCode": "216610798",
            "boardName": "",
            "specialOffer": "Save 30%",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "32CAD",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "956265",
      "cover": "http://i.travelapi.com/hotels/27000000/26540000/26533400/26533312/34989958_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "NTA Serviced Apartment",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at NTA Serviced Apartment, you'll be centrally located in Ho Chi Minh City, a 10-minute walk from Jade Emperor Pagoda and 15 minutes by foot from War …",
      "longitude": "106.69451",
      "latitude": "10.78709",
      "promotion": "Save 30%",
      "supplierCode": "s007",
      "hotelAddress": "171 - 173 Dien Bien Phu, Dakao Ward,, "
    },
    {
      "roomGroup": {
        "totalPrice": "2413238.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Room",
            "roomCode": "200731003",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 25%",
            "availability": "7",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Room",
            "roomCode": "200731003",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 25%",
            "availability": "7",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "33261",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "463828",
      "cover": "http://i.travelapi.com/hotels/9000000/8460000/8451500/8451420/86fa4cfb_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Sonnet Saigon Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Sonnet Saigon Hotel in Ho Chi Minh City, you'll be within a 5-minute walk of Golden Dragon Water Puppet Theatre and Tao Dan Park.  This hotel is 0.6 …",
      "longitude": "106.69144",
      "latitude": "10.77615",
      "promotion": "Private sale: save 25%",
      "supplierCode": "s007",
      "hotelAddress": "14 Truong Dinh Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "2439432.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Room",
            "roomCode": "511760",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Save 5%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Room",
            "roomCode": "511760",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Save 5%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "33ABD",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "327236",
      "cover": "http://i.travelapi.com/hotels/3000000/2930000/2921900/2921869/b1627b89_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Le Duy Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Le Duy Hotel places you in the heart of Ho Chi Minh City, steps from Pham Ngu Lao Backpacker Area and 4 minutes by foot from Zen Plaza.  This hotel is 0.4 …",
      "longitude": "106.69394",
      "latitude": "10.77054",
      "promotion": "Save 5%",
      "supplierCode": "s007",
      "hotelAddress": "18-20 Nguyen Thi Nghia Street, Dist 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "2444572.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Executive Twin Room, 2 Twin Beds",
            "roomCode": "200230547",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Save 25%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Executive Twin Room, 2 Twin Beds",
            "roomCode": "200230547",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Save 25%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "33C61",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "422720",
      "cover": "http://i.travelapi.com/hotels/6000000/5550000/5542300/5542212/ad79ce13_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Golden Crown Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Golden Crown Hotel in Ho Chi Minh City (Phu Nhuan), you'll be a 3-minute drive from Hoang Van Thu Park and 7 minutes from Parkson CT Plaza.  This …",
      "longitude": "106.67262",
      "latitude": "10.79687",
      "promotion": "Save 25%",
      "supplierCode": "s007",
      "hotelAddress": "50A Truong Quoc Dung St, Ward 10, "
    },
    {
      "roomGroup": {
        "totalPrice": "2450937.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Twin Room",
            "roomCode": "211503307",
            "boardName": "Free Breakfast",
            "specialOffer": "Save 35%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Twin Room",
            "roomCode": "211503307",
            "boardName": "Free Breakfast",
            "specialOffer": "Save 35%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "33E69",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "355705",
      "cover": "http://i.travelapi.com/hotels/4000000/3830000/3823500/3823491/79001db9_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Avanti Boutique",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Avanti Boutique in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be minutes from Temple of Mariamman and Benthanh Street Food Market.  This …",
      "longitude": "106.69676",
      "latitude": "10.77277",
      "promotion": "Save 35%",
      "supplierCode": "s007",
      "hotelAddress": "208-210 Le Thanh Ton Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "2500387.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Private Suite in Social Club 1",
            "roomCode": "201935589",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Private Suite in Social Club 1",
            "roomCode": "201935589",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "34E31",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "687605",
      "cover": "http://i.travelapi.com/hotels/19000000/18150000/18143600/18143522/4c3fb856_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "The Common Room Project - Hostel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at The Common Room Project - Hostel in Ho Chi Minh City, you'll be a 3-minute walk from Cho Quan Church and 15 minutes by foot from Saigon Culinary Arts …",
      "longitude": "106.67973",
      "latitude": "10.75821",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "80/8 Nguyen Trai Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "2525112.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room, 2 Twin Beds",
            "roomCode": "471790",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Private sale: save 33%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room, 2 Twin Beds",
            "roomCode": "471790",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Private sale: save 33%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "35615",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "340328",
      "cover": "http://i.travelapi.com/hotels/4000000/3410000/3402100/3402009/68669d31_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Riverside Hotel Saigon",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Riverside Hotel Saigon places you in the heart of Ho Chi Minh City, steps from Riverside and Saigon River.  This hotel is 0.1 mi (0.1 km) from Dong Khoi …",
      "longitude": "106.70649",
      "latitude": "10.77375",
      "promotion": "Private sale: save 33%",
      "supplierCode": "s007",
      "hotelAddress": "18-19-20 Ton Duc Thang Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "2538331.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "2 Bedrooms Apartment",
            "roomCode": "221116990",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "2 Bedrooms Apartment",
            "roomCode": "221116990",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "35A4D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "954685",
      "cover": "http://i.travelapi.com/hotels/27000000/26460000/26452300/26452289/0972c99a_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Thu and An Cozy Condo Central Park",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Thu and An Cozy Condo Central Park in Ho Chi Minh City (Hang Xanh), you'll be a 1-minute drive from Van Thanh Tourist Park and 9 minutes from Saigon …",
      "longitude": "106.71547",
      "latitude": "10.79784",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "Ward 22, "
    },
    {
      "roomGroup": {
        "totalPrice": "2558649.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room, 1 Double Bed, No Windows",
            "roomCode": "200151567",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Book early and save 25%",
            "availability": "8",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room, 1 Double Bed, No Windows",
            "roomCode": "200151567",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Book early and save 25%",
            "availability": "8",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "360C9",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "403796",
      "cover": "http://i.travelapi.com/hotels/5000000/4960000/4950500/4950454/5dbe2fd4_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Signature Saigon Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Signature Saigon Hotel places you in the heart of Ho Chi Minh City, steps from Museum of Fine Arts and 6 minutes by foot from Ben Thanh Market.  This hotel …",
      "longitude": "106.69938",
      "latitude": "10.7689",
      "promotion": "Book early and save 25%",
      "supplierCode": "s007",
      "hotelAddress": "65-67-69 Nguyen Thai Binh St., "
    },
    {
      "roomGroup": {
        "totalPrice": "2581416.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Apartment, 1 Bedroom, Smoking, Kitchen",
            "roomCode": "218719156",
            "boardName": "All-Inclusive",
            "specialOffer": "Seasonal deal: save 30%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Apartment, 1 Bedroom, Smoking, Kitchen",
            "roomCode": "218719156",
            "boardName": "All-Inclusive",
            "specialOffer": "Seasonal deal: save 30%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "3680D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1001351",
      "cover": "http://i.travelapi.com/hotels/28000000/27170000/27170000/27169956/170033c4_t.jpg",
      "rate": "3.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Luxury Apartmentel Saigon Pearl",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Luxury Apartmentel Saigon Pearl in Ho Chi Minh City (Hang Xanh), you'll be within a 10-minute drive of Van Thanh Tourist Park and Ton Duc Thang …",
      "longitude": "106.7179",
      "latitude": "10.79012",
      "promotion": "Seasonal deal: save 30%",
      "supplierCode": "s007",
      "hotelAddress": "92 Nguyen Huu Canh, Binh Thanh District, "
    },
    {
      "roomGroup": {
        "totalPrice": "2586067.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Studio",
            "roomCode": "219602304",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "12",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Studio",
            "roomCode": "219602304",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "12",
            "boardCode": ""
          }
        ],
        "nonRefundable": false,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "36989",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "842648",
      "cover": "http://i.travelapi.com/hotels/23000000/22780000/22773300/22773247/74f25f83_t.jpg",
      "rate": "3.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Sunny Officetel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Sunny Officetel in Ho Chi Minh City (Bach Dang Riverside), you'll be a 3-minute walk from Riverside and 6 minutes by foot from Nha Rong Wharf.  This …",
      "longitude": "106.70317",
      "latitude": "10.76679",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "Ben Van Don, "
    },
    {
      "roomGroup": {
        "totalPrice": "2596348.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Twin Room",
            "roomCode": "201774168",
            "boardName": "",
            "specialOffer": "Tonight only: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Twin Room",
            "roomCode": "201774168",
            "boardName": "",
            "specialOffer": "Tonight only: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "36CD1",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "647966",
      "cover": "http://i.travelapi.com/hotels/17000000/16780000/16774600/16774571/54eb5ad0_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Pastel Inn Saigon",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Pastel Inn Saigon in Ho Chi Minh City (Dong Khoi), you'll be steps from Dong Khoi Shopping Street and 3 minutes by foot from Notre Dame Square.  This …",
      "longitude": "106.6983",
      "latitude": "10.77798",
      "promotion": "Tonight only: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "99 Pasteur Street, Ben Nghe, District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "2607364.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Apartment, 2 Bedrooms",
            "roomCode": "218708237",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Apartment, 2 Bedrooms",
            "roomCode": "218708237",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "37055",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "894140",
      "cover": "http://i.travelapi.com/hotels/24000000/23790000/23782300/23782213/110075d9_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Urban House Saigon Vinhome Central",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Urban House Saigon Vinhome Central, you'll be centrally located in Ho Chi Minh City, within a 10-minute drive of Van Thanh Tourist Park and Vincom …",
      "longitude": "106.72031",
      "latitude": "10.79392",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "208 Nguyen Huu Canh Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "2613974.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Twin Room",
            "roomCode": "201684211",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 13%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Twin Room",
            "roomCode": "201684211",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 13%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "37271",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "627466",
      "cover": "http://i.travelapi.com/hotels/17000000/16160000/16156200/16156128/fee22da6_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Cititel Central Saigon Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />Cititel Central Saigon Hotel is centrally located in Ho Chi Minh City, a 4-minute walk from Benthanh Street Food Market and 6 minutes by foot from Ben Thanh Market.  …",
      "longitude": "106.69491",
      "latitude": "10.77225",
      "promotion": "Private sale: save 13%",
      "supplierCode": "s007",
      "hotelAddress": "247-249 Ly Tu Trong, District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "2616667.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Executive Twin Room, City View",
            "roomCode": "211804234",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Save 55%",
            "availability": "9",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Executive Twin Room, City View",
            "roomCode": "211804234",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Save 55%",
            "availability": "9",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "3734D",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "359199",
      "cover": "http://i.travelapi.com/hotels/4000000/3900000/3895200/3895114/2fa88e83_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "The White Hotel 8A Thai Van Lung",
      "hotelDescription": "<p><b>Property Location</b> <br />You'll be centrally located in Ho Chi Minh City with a stay at A&EM Hotel 8A Thai Van Lung, and 1 minutes by foot from Saigon River.  This hotel is within close …",
      "longitude": "106.70466",
      "latitude": "10.7792",
      "promotion": "Save 55%",
      "supplierCode": "s007",
      "hotelAddress": "8A/1D2 Thai Van Lung St., "
    },
    {
      "roomGroup": {
        "totalPrice": "2617401.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "403425",
            "boardName": "Breakfast Buffet",
            "specialOffer": "",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Double Room",
            "roomCode": "403425",
            "boardName": "Breakfast Buffet",
            "specialOffer": "",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "37389",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "324133",
      "cover": "http://i.travelapi.com/hotels/3000000/2840000/2835200/2835112/7fd7d5d6_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Sophia Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Sophia Hotel places you in the heart of Ho Chi Minh City, steps from Saigon River and Dong Khoi Shopping Street.  This hotel is 0.2 mi (0.4 km) from Vincom …",
      "longitude": "106.70346",
      "latitude": "10.78023",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "36-38 Thai Van Lung, Ben Nghe Ward, "
    },
    {
      "roomGroup": {
        "totalPrice": "2625480.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Family Room, 2 Queen Beds",
            "roomCode": "215414961",
            "boardName": "",
            "specialOffer": "",
            "availability": "10",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Family Room, 2 Queen Beds",
            "roomCode": "215414961",
            "boardName": "",
            "specialOffer": "",
            "availability": "10",
            "boardCode": ""
          }
        ],
        "nonRefundable": false,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "3761D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "862664",
      "cover": "http://i.travelapi.com/hotels/24000000/23140000/23135200/23135192/557ff7ca_t.jpg",
      "rate": "3.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "City view 2br in Masteri Thao Dien",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at City view 2br in Masteri Thao Dien in Ho Chi Minh City (Thao Dien), you'll be a 1-minute drive from Vincom Mega Mall and 9 minutes from Van Thanh …",
      "longitude": "106.74014",
      "latitude": "10.80185",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "159 Xa Lo Ha Noi, "
    },
    {
      "roomGroup": {
        "totalPrice": "2640412.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Twin Room",
            "roomCode": "201936623",
            "boardName": "Breakfast Buffet",
            "specialOffer": "",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Twin Room",
            "roomCode": "201936623",
            "boardName": "Breakfast Buffet",
            "specialOffer": "",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "37AE1",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "397077",
      "cover": "http://i.travelapi.com/hotels/5000000/4760000/4756800/4756766/ce9b1f72_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Asian Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Asian Hotel places you in the heart of Ho Chi Minh City, steps from Dong Khoi Shopping Street and Parkson Plaza.  This hotel is 0.1 mi (0.2 km) from Opera …",
      "longitude": "106.70196",
      "latitude": "10.77709",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "146-148-150 Dong Khoi Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "2652408.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Extra Large Room Bui Vien",
            "roomCode": "219914831",
            "boardName": "Full Breakfast",
            "specialOffer": "Private sale: save 30%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Extra Large Room Bui Vien",
            "roomCode": "219914831",
            "boardName": "Full Breakfast",
            "specialOffer": "Private sale: save 30%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "37EB5",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "651279",
      "cover": "http://i.travelapi.com/hotels/18000000/17060000/17054000/17053969/3c4b3fd6_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "C Central Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at C Central Hotel places you in the heart of Ho Chi Minh City, steps from Bui Vien Walking Street and Pham Ngu Lao Backpacker Area.  This hotel is 0.5 mi …",
      "longitude": "106.69407",
      "latitude": "10.76761",
      "promotion": "Private sale: save 30%",
      "supplierCode": "s007",
      "hotelAddress": "216 De Tham, Pham Ngu Lao, "
    },
    {
      "roomGroup": {
        "totalPrice": "2659507.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "VIP Room",
            "roomCode": "200804924",
            "boardName": "",
            "specialOffer": "Save 20%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "VIP Room",
            "roomCode": "200804924",
            "boardName": "",
            "specialOffer": "Save 20%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "380F9",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "477181",
      "cover": "http://i.travelapi.com/hotels/10000000/9250000/9244200/9244133/2470e1b6_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Crown Diamond Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Crown Diamond Hotel in Ho Chi Minh City (Phu My Hung), you'll be within a 5-minute drive of The Cresent Mall and SC VivoCity.  This hotel is 1 mi (1.7 …",
      "longitude": "106.70741",
      "latitude": "10.73151",
      "promotion": "Save 20%",
      "supplierCode": "s007",
      "hotelAddress": "21 - 23 Noi khu Hung Phuoc 2 St., "
    },
    {
      "roomGroup": {
        "totalPrice": "2716300.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Apartment, 2 Bedrooms, Pool Access, River View",
            "roomCode": "216312330",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Apartment, 2 Bedrooms, Pool Access, River View",
            "roomCode": "216312330",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "39319",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "956165",
      "cover": "http://i.travelapi.com/hotels/27000000/26540000/26532400/26532360/0d40a714_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Riverview Lux Apartment",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Riverview Lux Apartment in Ho Chi Minh City (Hang Xanh), you'll be within a 10-minute drive of Van Thanh Tourist Park and Vincom Mega Mall.  This …",
      "longitude": "106.71928",
      "latitude": "10.79553",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "208 Nguyen Huu Canh, Binh Thanh, "
    },
    {
      "roomGroup": {
        "totalPrice": "2734905.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Room",
            "roomCode": "200855815",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Save 35%",
            "availability": "8",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Room",
            "roomCode": "200855815",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Save 35%",
            "availability": "8",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "39909",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "484725",
      "cover": "http://i.travelapi.com/hotels/10000000/9640000/9634500/9634472/2f082cfa_t.jpg",
      "rate": "3.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Athena Boutique Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />When you stay at Athena Boutique Hotel in Ho Chi Minh City, you'll be in the business district, within a 15-minute walk of Ho Chi Minh City National University and …",
      "longitude": "106.66526",
      "latitude": "10.77769",
      "promotion": "Save 35%",
      "supplierCode": "s007",
      "hotelAddress": "280 To Hien Thanh, "
    },
    {
      "roomGroup": {
        "totalPrice": "2786313.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Apartment",
            "roomCode": "217201628",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Apartment",
            "roomCode": "217201628",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "3A971",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "854589",
      "cover": "http://i.travelapi.com/hotels/24000000/23050000/23047800/23047716/34b58b9d_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Mia Apartment 2 The Tresor",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Mia Apartment 2 The Tresor in Ho Chi Minh City (Bach Dang Riverside), you'll be a 4-minute walk from Riverside and 7 minutes by foot from Nha Rong …",
      "longitude": "106.70269",
      "latitude": "10.76632",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "39 Ben Van Don, "
    },
    {
      "roomGroup": {
        "totalPrice": "2799043.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Suite",
            "roomCode": "201155205",
            "boardName": "Full Breakfast",
            "specialOffer": "Save 50%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Suite",
            "roomCode": "201155205",
            "boardName": "Full Breakfast",
            "specialOffer": "Save 50%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "3AD81",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "531610",
      "cover": "http://i.travelapi.com/hotels/12000000/11540000/11539900/11539845/71f5a4cf_t.jpg",
      "rate": "3.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "LIEFHOTEL SAIGON",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at LIEFHOTEL SAIGON in Ho Chi Minh City (Hang Xanh), you'll be within a 10-minute drive of Van Thanh Tourist Park and Vietnam National Museum of History. …",
      "longitude": "106.70739",
      "latitude": "10.7957",
      "promotion": "Save 50%",
      "supplierCode": "s007",
      "hotelAddress": "30/57 Nguyen Cuu Van, "
    },
    {
      "roomGroup": {
        "totalPrice": "2807121.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Block B 8.21",
            "roomCode": "221408921",
            "boardName": "",
            "specialOffer": "Private sale: save 5%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Block B 8.21",
            "roomCode": "221408921",
            "boardName": "",
            "specialOffer": "Private sale: save 5%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "3B015",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "893769",
      "cover": "http://i.travelapi.com/hotels/24000000/23720000/23711600/23711562/8b5b65c6_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "River Gate Apartment",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City (Bach Dang Riverside), River Gate Apartment is within a 15-minute walk of Riverside and Nha Rong Wharf.  This beach condo is 0.8 mi (1.3 …",
      "longitude": "106.69853",
      "latitude": "10.76284",
      "promotion": "Private sale: save 5%",
      "supplierCode": "s007",
      "hotelAddress": "151 Ben Van Ðon, "
    },
    {
      "roomGroup": {
        "totalPrice": "2832336.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room, 1 Double or 2 Twin Beds",
            "roomCode": "200189285",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Book now and save!",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room, 1 Double or 2 Twin Beds",
            "roomCode": "200189285",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Book now and save!",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "3B821",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "413318",
      "cover": "http://i.travelapi.com/hotels/6000000/5240000/5238300/5238222/686d3c12_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Huong Sen Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Huong Sen Hotel places you in the heart of Ho Chi Minh City, steps from Saigon River and Dong Khoi Shopping Street.  This spa hotel is 0.1 mi (0.1 km) from …",
      "longitude": "106.70402",
      "latitude": "10.77516",
      "promotion": "Book now and save!",
      "supplierCode": "s007",
      "hotelAddress": "66-70 Dong Khoi, Dist 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "2874686.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Luxury Apartment, 2 Bedrooms, Pool Access, City View",
            "roomCode": "202287237",
            "boardName": "",
            "specialOffer": "Book now and save!",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Luxury Apartment, 2 Bedrooms, Pool Access, City View",
            "roomCode": "202287237",
            "boardName": "",
            "specialOffer": "Book now and save!",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "3C5A5",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "777346",
      "cover": "http://i.travelapi.com/hotels/21000000/20950000/20943200/20943171/2c44ab07_t.jpg",
      "rate": "3.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Mia Apartment 1 - ICON 56",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Mia Apartment 1 - ICON 56 in Ho Chi Minh City (Bach Dang Riverside), you'll be within a 15-minute walk of Nha Rong Wharf and Saigon Skydeck.  This …",
      "longitude": "106.70263",
      "latitude": "10.7663",
      "promotion": "Book now and save!",
      "supplierCode": "s007",
      "hotelAddress": "56 Ben Van Don, Ward 12, District 4, "
    },
    {
      "roomGroup": {
        "totalPrice": "2919729.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard One-Bedroom Apartment with Balcony",
            "roomCode": "220226002",
            "boardName": "",
            "specialOffer": "Private sale: save 25%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard One-Bedroom Apartment with Balcony",
            "roomCode": "220226002",
            "boardName": "",
            "specialOffer": "Private sale: save 25%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "3D405",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "727415",
      "cover": "http://i.travelapi.com/hotels/20000000/19510000/19503200/19503171/524c542a_t.jpg",
      "rate": "4.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Hoasun Boutique Apartment - Vinhomes Central Park",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Hoasun Boutique Apartment - Vinhomes Central Park in Ho Chi Minh City (Hang Xanh), you'll be convenient to Van Thanh Tourist Park and Vietnam National …",
      "longitude": "106.71787",
      "latitude": "10.79022",
      "promotion": "Private sale: save 25%",
      "supplierCode": "s007",
      "hotelAddress": "Unit 20.07, Park 6A Building, "
    },
    {
      "roomGroup": {
        "totalPrice": "2920464.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Apartment, 2 Bedrooms, River View",
            "roomCode": "220805955",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Apartment, 2 Bedrooms, River View",
            "roomCode": "220805955",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "3D441",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "875192",
      "cover": "http://i.travelapi.com/hotels/24000000/23350000/23340100/23340035/67595174_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Cherry Vinhomes Central Park",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Cherry Vinhomes Central Park in Ho Chi Minh City (Hang Xanh), you'll be within a 10-minute drive of Van Thanh Tourist Park and Vincom Mega Mall.  This …",
      "longitude": "106.71944",
      "latitude": "10.79482",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "208 Nguyen Huu Canh Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "2932948.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Apartment, 1 Bedroom, City View",
            "roomCode": "221723135",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Apartment, 1 Bedroom, City View",
            "roomCode": "221723135",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "3D83D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1026986",
      "cover": "http://i.travelapi.com/hotels/28000000/27960000/27956500/27956417/717be36c_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "The Dragons Host Parkside",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at The Dragons Host Parkside in Ho Chi Minh City, you'll be minutes from War Remnants Museum and Independence Palace.  This aparthotel is within close …",
      "longitude": "106.69466",
      "latitude": "10.77998",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "166 Nam Ky Khoi Nghia street,, "
    },
    {
      "roomGroup": {
        "totalPrice": "2938089.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Apartment, 2 Bedrooms, River View",
            "roomCode": "221709402",
            "boardName": "",
            "specialOffer": "Member’s price: 20%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Apartment, 2 Bedrooms, River View",
            "roomCode": "221709402",
            "boardName": "",
            "specialOffer": "Member’s price: 20%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "3D9E1",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "819615",
      "cover": "http://i.travelapi.com/hotels/23000000/22360000/22354800/22354765/c1ef19c7_t.jpg",
      "rate": "4.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Saigon Sirius",
      "hotelDescription": "<p><b>Property Location</b> <br />Centrally located in Ho Chi Minh City, Saigon Sirius is within a 15-minute walk of Riverside and Nha Rong Wharf.  This 4-star apartment is 1.1 mi (1.7 km) from Bui …",
      "longitude": "106.69854",
      "latitude": "10.76269",
      "promotion": "Member’s price: 20%",
      "supplierCode": "s007",
      "hotelAddress": "151 ben van don, "
    },
    {
      "roomGroup": {
        "totalPrice": "2941027.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Luxury Apartment, 2 Bedrooms",
            "roomCode": "221102020",
            "boardName": "",
            "specialOffer": "",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Luxury Apartment, 2 Bedrooms",
            "roomCode": "221102020",
            "boardName": "",
            "specialOffer": "",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "3DAD1",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "836603",
      "cover": "http://i.travelapi.com/hotels/23000000/22680000/22679300/22679256/d48d50b7_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Lucyhome Masteri Thao Dien Apartment",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Lucyhome Masteri Thao Dien Apartment in Ho Chi Minh City (Thao Dien), you'll be a 2-minute drive from Vincom Mega Mall and 9 minutes from Van Thanh …",
      "longitude": "106.7412",
      "latitude": "10.80209",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "159 Xa Lo Ha Noi, District 2, "
    },
    {
      "roomGroup": {
        "totalPrice": "2965996.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Premier Deluxe King Room",
            "roomCode": "201672128",
            "boardName": "Free Breakfast",
            "specialOffer": "Save30%",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Premier Deluxe King Room",
            "roomCode": "201672128",
            "boardName": "Free Breakfast",
            "specialOffer": "Save30%",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "3E2C9",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "626614",
      "cover": "http://i.travelapi.com/hotels/17000000/16090000/16083500/16083475/1c9341ea_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "LaLuna Saigon",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at LaLuna Saigon places you in the heart of Ho Chi Minh City, steps from Pham Ngu Lao Backpacker Area and September 23 Park.  This hotel is 0.3 mi (0.5 km) …",
      "longitude": "106.69283",
      "latitude": "10.76963",
      "promotion": "Save30%",
      "supplierCode": "s007",
      "hotelAddress": "8/2 Nguyen Van Trang Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "2987784.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Luxury Apartment, 1 Bedroom",
            "roomCode": "219904677",
            "boardName": "",
            "specialOffer": "Member’s price: 45%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Luxury Apartment, 1 Bedroom",
            "roomCode": "219904677",
            "boardName": "",
            "specialOffer": "Member’s price: 45%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "3E9BD",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "852814",
      "cover": "http://i.travelapi.com/hotels/24000000/23010000/23007300/23007206/0782c694_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Christine’s Saigon Apartment",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Christine’s Saigon Apartment , you'll be centrally located in Ho Chi Minh City, within a 10-minute drive of Van Thanh Tourist Park and Vincom Mega …",
      "longitude": "106.71957",
      "latitude": "10.79552",
      "promotion": "Member’s price: 45%",
      "supplierCode": "s007",
      "hotelAddress": "208 Nguyen Huu Canh, Ward 22, "
    },
    {
      "roomGroup": {
        "totalPrice": "2988518.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Apartment",
            "roomCode": "202462529",
            "boardName": "",
            "specialOffer": "Save 50%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Apartment",
            "roomCode": "202462529",
            "boardName": "",
            "specialOffer": "Save 50%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "3E9F9",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "821350",
      "cover": "http://i.travelapi.com/hotels/23000000/22410000/22409900/22409827/809cd69a_t.jpg",
      "rate": "3.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Aurora Apartment by Glenwood",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Aurora Apartment by Glenwood, you'll be centrally located in Ho Chi Minh City, within a 10-minute drive of Van Thanh Tourist Park and Saigon River.  …",
      "longitude": "106.71891",
      "latitude": "10.79066",
      "promotion": "Save 50%",
      "supplierCode": "s007",
      "hotelAddress": "92 NGUYEN HUU CANH, "
    },
    {
      "roomGroup": {
        "totalPrice": "3062692.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Apartment, 1 Bedroom",
            "roomCode": "200504212",
            "boardName": "Full Breakfast",
            "specialOffer": "Special deal: save 30%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Apartment, 1 Bedroom",
            "roomCode": "200504212",
            "boardName": "Full Breakfast",
            "specialOffer": "Special deal: save 30%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "401A5",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "448258",
      "cover": "http://i.travelapi.com/hotels/8000000/7340000/7330200/7330195/fc30c16b_t.jpg",
      "rate": "3.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "EMM Hotel Saigon",
      "hotelDescription": "<p><b>Property Location</b> <br />When you stay at EMM Hotel Saigon in Ho Chi Minh City, you'll be in the historical district, within a 15-minute walk of Southern Vietnam Women Museum and War …",
      "longitude": "106.69086",
      "latitude": "10.78497",
      "promotion": "Special deal: save 30%",
      "supplierCode": "s007",
      "hotelAddress": "157 Pasteur Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "3078115.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Apartment, 1 Bedroom, Balcony",
            "roomCode": "202214738",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Apartment, 1 Bedroom, Balcony",
            "roomCode": "202214738",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "40691",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "570198",
      "cover": "http://i.travelapi.com/hotels/14000000/13390000/13381600/13381538/13381538_3_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Kelly Serviced Apartment",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Kelly Serviced Apartment in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Pham Ngu Lao Backpacker Area and 5 minutes by foot from …",
      "longitude": "106.69323",
      "latitude": "10.76618",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "100/2A2 Tran Hung Dao Str, "
    },
    {
      "roomGroup": {
        "totalPrice": "3123158.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Apartment, 1 Bedroom",
            "roomCode": "215713873",
            "boardName": "",
            "specialOffer": "",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Apartment, 1 Bedroom",
            "roomCode": "215713873",
            "boardName": "",
            "specialOffer": "",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "414F1",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1001576",
      "cover": "http://i.travelapi.com/hotels/28000000/27190000/27186800/27186726/dc3e1131_t.jpg",
      "rate": "3.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Sammi Hotel & Apartment 2",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Sammi Hotel & Apartment 2, you'll be centrally located in Ho Chi Minh City, just a 3-minute walk from Riverside and 7 minutes by foot from Nha Rong …",
      "longitude": "106.70296",
      "latitude": "10.76642",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "39 Ben Van Don, Ward 12, District 4, "
    },
    {
      "roomGroup": {
        "totalPrice": "3125606.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Apartment, 1 Bedroom",
            "roomCode": "200053185",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Member’s price: 55%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Apartment, 1 Bedroom",
            "roomCode": "200053185",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Member’s price: 55%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "415B9",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "352379",
      "cover": "http://i.travelapi.com/hotels/2000000/1460000/1456200/1456192/57efba4f_t.jpg",
      "rate": "4.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Saigon Domaine Luxury Residences",
      "hotelDescription": "<p><b>Property Location</b> <br />When you stay at Saigon Domaine Luxury Residences in Ho Chi Minh City, you'll be on the riverwalk and 15 minutes by car from Van Thanh Tourist Park.  This 4.5-star …",
      "longitude": "106.73088",
      "latitude": "10.82267",
      "promotion": "Member’s price: 55%",
      "supplierCode": "s007",
      "hotelAddress": "1057 Binh Quoi Street, Ward 28, "
    },
    {
      "roomGroup": {
        "totalPrice": "3209817.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Studio",
            "roomCode": "201765294",
            "boardName": "",
            "specialOffer": "Save 20%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Studio",
            "roomCode": "201765294",
            "boardName": "",
            "specialOffer": "Save 20%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "43099",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "643326",
      "cover": "http://i.travelapi.com/hotels/17000000/16580000/16570600/16570507/940fc812_t.jpg",
      "rate": "3.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Oakwood Apartments Ho Chi Minh City",
      "hotelDescription": "<p><b>Property Location</b> <br />When you stay at Oakwood Apartments Ho Chi Minh City in Ho Chi Minh City, you'll be in the historical district, within a 15-minute walk of Xa Loi Pagoda and Pham Ngu …",
      "longitude": "106.68185",
      "latitude": "10.77252",
      "promotion": "Save 20%",
      "supplierCode": "s007",
      "hotelAddress": "18, Street No. 3, Cu Xa Do Thanh, "
    },
    {
      "roomGroup": {
        "totalPrice": "3259022.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "2 Bedrooms Apartment",
            "roomCode": "202401761",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "2 Bedrooms Apartment",
            "roomCode": "202401761",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "4404D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "805938",
      "cover": "http://i.travelapi.com/hotels/22000000/21920000/21917900/21917834/427562dc_t.jpg",
      "rate": "3.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Vinhomes Central Park Saigon",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at this aparthotel in Ho Chi Minh City (Hang Xanh), you'll be within a 10-minute drive of Van Thanh Tourist Park and Vincom Mega Mall.  This …",
      "longitude": "106.71846",
      "latitude": "10.79535",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "208 Nguyen Huu Canh, "
    },
    {
      "roomGroup": {
        "totalPrice": "3259022.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "2 Bedrooms",
            "roomCode": "217217754",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "2 Bedrooms",
            "roomCode": "217217754",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "4404D",
        "contractName": ""
      },
      "destinationCode": "TSN",
      "hotelId": "1020944",
      "cover": "http://i.travelapi.com/hotels/30000000/29080000/29070800/29070743/9e008c48_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "MH Warm House",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, MH Warm House is minutes from Jade Emperor Pagoda and close to Diamond Plaza.  This guesthouse is within close proximity of Vietnam …",
      "longitude": "106.69782",
      "latitude": "10.78729",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "100/2 Nguyen Ðinh Chieu street, "
    },
    {
      "roomGroup": {
        "totalPrice": "3288888.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Junior Suite",
            "roomCode": "200757711",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Save 25%",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Junior Suite",
            "roomCode": "200757711",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Save 25%",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "449D5",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "470097",
      "cover": "http://i.travelapi.com/hotels/9000000/8790000/8782500/8782432/398f7b64_t.jpg",
      "rate": "4.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Charm Suite Saigon",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Charm Suite Saigon in Ho Chi Minh City (Hang Xanh), you'll be within a 10-minute drive of Van Thanh Tourist Park and Jade Emperor Pagoda.  This 4-star …",
      "longitude": "106.72361",
      "latitude": "10.79991",
      "promotion": "Save 25%",
      "supplierCode": "s007",
      "hotelAddress": "330A/330B Ung Van Khiem Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "3330748.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Design Apartment, 1 Bedroom, Microwave, City View",
            "roomCode": "221717900",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Design Apartment, 1 Bedroom, Microwave, City View",
            "roomCode": "221717900",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": false,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "45731",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "836543",
      "cover": "http://i.travelapi.com/hotels/23000000/22680000/22677600/22677596/70a96f66_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "High-floor River-view Apartment",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at this apartment in Ho Chi Minh City (Hang Xanh), you'll be within a 10-minute drive of Van Thanh Tourist Park and Vincom Mega Mall.  This apartment is …",
      "longitude": "106.71935",
      "latitude": "10.79535",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "208 Nguyen Huu Canh, "
    },
    {
      "roomGroup": {
        "totalPrice": "3362572.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Family Suite, 2 Double Beds",
            "roomCode": "200124368",
            "boardName": "",
            "specialOffer": "Private sale: save 35%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Family Suite, 2 Double Beds",
            "roomCode": "200124368",
            "boardName": "",
            "specialOffer": "Private sale: save 35%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "46159",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "396541",
      "cover": "http://i.travelapi.com/hotels/5000000/4740000/4736100/4736094/edec2f55_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Cap Town Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Cap Town Hotel places you in the heart of Ho Chi Minh City, steps from Temple of Mariamman and 5 minutes by foot from Benthanh Street Food Market.  This …",
      "longitude": "106.69513",
      "latitude": "10.77199",
      "promotion": "Private sale: save 35%",
      "supplierCode": "s007",
      "hotelAddress": "28 - 30 Le Anh Xuan Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "3373099.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Luxury Apartment, 2 Bedrooms, Non Smoking, Executive Level",
            "roomCode": "221117421",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Luxury Apartment, 2 Bedrooms, Non Smoking, Executive Level",
            "roomCode": "221117421",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "464B5",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "971600",
      "cover": "http://i.travelapi.com/hotels/27000000/26970000/26960800/26960789/54c73475_t.jpg",
      "rate": "3.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Kathy Apartment Vinhomes",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City (Hang Xanh), Kathy Apartment Vinhomes is within a 15-minute drive of Riverside and Opera House.  This apartment is 2.8 mi (4.5 km) from …",
      "longitude": "106.71928",
      "latitude": "10.79553",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "208 Nguyen Huu Canh, "
    },
    {
      "roomGroup": {
        "totalPrice": "3458289.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "One Bedroom Apartment",
            "roomCode": "202254573",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "6",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "One Bedroom Apartment",
            "roomCode": "202254573",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "6",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "47FE5",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "766721",
      "cover": "http://i.travelapi.com/hotels/21000000/20390000/20383700/20383640/08db1fb1_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Saigon City Residence",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Saigon City Residence in Ho Chi Minh City (Little Japan), you'll be steps from Saigon River and Riverside.  This aparthotel is 0.2 mi (0.4 km) from …",
      "longitude": "106.70489",
      "latitude": "10.77922",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "8a/3d2 Thai Van Lung, District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "3537604.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Premium Deluxe",
            "roomCode": "200008729",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Save 13%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Premium Deluxe",
            "roomCode": "200008729",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Save 13%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "49935",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "359486",
      "cover": "http://i.travelapi.com/hotels/4000000/3910000/3903300/3903232/348687b4_t.jpg",
      "rate": "4.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "A&Em Corner Sai Gon Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at A&Em Corner Sai Gon Hotel places you in the heart of Ho Chi Minh City, steps from Benthanh Street Food Market and 4 minutes by foot from Temple of …",
      "longitude": "106.69685",
      "latitude": "10.77425",
      "promotion": "Save 13%",
      "supplierCode": "s007",
      "hotelAddress": "39-39A-41 Thu Khoa Huan Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "3604190.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Twin No Breakfast with Free Minibar",
            "roomCode": "201590893",
            "boardName": "",
            "specialOffer": "Save 40%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Twin No Breakfast with Free Minibar",
            "roomCode": "201590893",
            "boardName": "",
            "specialOffer": "Save 40%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "4AE75",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "571426",
      "cover": "http://i.travelapi.com/hotels/14000000/13460000/13457300/13457246/e4bd40d1_t.jpg",
      "rate": "4.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Bay Hotel Ho Chi Minh",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Bay Hotel Ho Chi Minh in Ho Chi Minh City (Little Japan), you'll be steps from Riverside and Saigon River.  This 4-star hotel is 0.3 mi (0.5 km) from …",
      "longitude": "106.70691",
      "latitude": "10.78052",
      "promotion": "Save 40%",
      "supplierCode": "s007",
      "hotelAddress": "7 Ngo Van Nam Street, District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "3621081.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "203 Serviced Room",
            "roomCode": "202108951",
            "boardName": "",
            "specialOffer": "",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "203 Serviced Room",
            "roomCode": "202108951",
            "boardName": "",
            "specialOffer": "",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "4B3D9",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "726725",
      "cover": "http://i.travelapi.com/hotels/20000000/19480000/19473700/19473675/40bef4f4_t.jpg",
      "rate": "2.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Smiley Apartment 11",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Smiley Apartment 11 in Ho Chi Minh City (Bui Thi Xuan), you'll be within a 10-minute walk of Zen Plaza and September 23 Park.  This apartment is 0.5 …",
      "longitude": "106.68978",
      "latitude": "10.77123",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "45 Bui Thi Xuan Street, District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "3633811.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Apartment, 2 Bedrooms",
            "roomCode": "217217728",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Apartment, 2 Bedrooms",
            "roomCode": "217217728",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "4B7E9",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "1021465",
      "cover": "http://i.travelapi.com/hotels/30000000/29110000/29107600/29107587/06ae7407_t.jpg",
      "rate": "3.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Nomad Homes Vinhomes Golden River",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Nomad Homes Vinhomes Golden River in Ho Chi Minh City, you'll be just steps from Riverside and Saigon River.  This apartment is within close proximity …",
      "longitude": "106.70694",
      "latitude": "10.78216",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "2 Ton Duc Thang, Ben Nghe Ward, "
    },
    {
      "roomGroup": {
        "totalPrice": "3674937.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Luxury Apartment",
            "roomCode": "217822525",
            "boardName": "",
            "specialOffer": "Tonight only: save 49%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Luxury Apartment",
            "roomCode": "217822525",
            "boardName": "",
            "specialOffer": "Tonight only: save 49%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "4C509",
        "contractName": ""
      },
      "destinationCode": "TSN",
      "hotelId": "1022115",
      "cover": "http://i.travelapi.com/hotels/29000000/28950000/28948400/28948386/4aff7379_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "La Casa We Stay",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at La Casa We Stay in Ho Chi Minh City, you'll be convenient to Saigon Paragon Mall and Starlight Bridge.  This apartment is within close proximity of …",
      "longitude": "106.74115",
      "latitude": "10.71405",
      "promotion": "Tonight only: save 49%",
      "supplierCode": "s007",
      "hotelAddress": "89 Hoang Quoc Viet, Phu My, District 7, "
    },
    {
      "roomGroup": {
        "totalPrice": "3796358.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Premium Double Room",
            "roomCode": "200087622",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Private sale: save 10%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Premium Double Room",
            "roomCode": "200087622",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Private sale: save 10%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "4EBC9",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "386554",
      "cover": "http://i.travelapi.com/hotels/5000000/4530000/4521100/4521002/4d9b431a_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Sunflower Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Sunflower Hotel places you in the heart of Ho Chi Minh City, steps from Saigon River and Riverside.  This hotel is 0.2 mi (0.4 km) from Dong Khoi Shopping …",
      "longitude": "106.70491",
      "latitude": "10.779",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "11B Thai Van Lung, "
    },
    {
      "roomGroup": {
        "totalPrice": "3872980.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Studio (Park or City View)",
            "roomCode": "216009594",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 46%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Studio (Park or City View)",
            "roomCode": "216009594",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 46%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "5043D",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "944355",
      "cover": "http://i.travelapi.com/hotels/26000000/25150000/25144100/25144090/551fff30_t.jpg",
      "rate": "3.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Cicilia Saigon Hotel & Spa",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City (Downtown Ho Chi Minh City), Cicilia Saigon Hotel & Spa is within a 15-minute walk of Ben Thanh Market and Museum of Fine Arts.  This spa …",
      "longitude": "106.6928",
      "latitude": "10.77197",
      "promotion": "Private sale: save 46%",
      "supplierCode": "s007",
      "hotelAddress": "12D Cach Mang Thang 8, District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "3879345.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Family Apartment, 1 Queen Bed, Non Smoking",
            "roomCode": "219918906",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Family Apartment, 1 Queen Bed, Non Smoking",
            "roomCode": "219918906",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": false,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "50645",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1024251",
      "cover": "http://i.travelapi.com/hotels/28000000/27170000/27164800/27164795/23be1a25_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Annie Apartment Vinhome Central Park",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City (Hang Xanh), Annie Apartment Vinhome Central Park is convenient to Van Thanh Tourist Park and Vietnam National Museum of History.  This …",
      "longitude": "106.7193",
      "latitude": "10.79492",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "Phong 32.04, Park 2, 208 Nguyen Huu Canh, "
    },
    {
      "roomGroup": {
        "totalPrice": "3888648.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Apartment, 1 Bedroom, Kitchen, City View",
            "roomCode": "201982046",
            "boardName": "Free Breakfast",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Apartment, 1 Bedroom, Kitchen, City View",
            "roomCode": "201982046",
            "boardName": "Free Breakfast",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "5093D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "690542",
      "cover": "http://i.travelapi.com/hotels/19000000/18260000/18251300/18251251/a2ecc704_t.jpg",
      "rate": "3.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Garden View Court Serviced Apartments",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Garden View Court Serviced Apartments in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be within a 5-minute walk of Benthanh Street Food Market …",
      "longitude": "106.69666",
      "latitude": "10.77502",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "101 Nguyen Du Str., Ben Thanh, Dist. 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "3918268.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Apartment, 1 Bedroom",
            "roomCode": "215412138",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Apartment, 1 Bedroom",
            "roomCode": "215412138",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "512B1",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "970600",
      "cover": "http://i.travelapi.com/hotels/27000000/26940000/26936300/26936227/4233ae82_t.jpg",
      "rate": "3.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Vinhome Golden River Apartment - M'Homme",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at this apartment in Ho Chi Minh City (Bach Dang Riverside), you'll be steps from Riverside and 13 minutes by foot from Opera House.  This apartment is …",
      "longitude": "106.70703",
      "latitude": "10.78193",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "2 Ton Duc Thang Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "4006886.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "200217082",
            "boardName": "",
            "specialOffer": "",
            "availability": "2147483647",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Standard Room",
            "roomCode": "200217082",
            "boardName": "",
            "specialOffer": "",
            "availability": "2147483647",
            "boardCode": ""
          }
        ],
        "nonRefundable": false,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "52EF9",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "414469",
      "cover": "http://i.travelapi.com/hotels/6000000/5270000/5264500/5264425/5bd87d8c_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "ibis Saigon South",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at ibis Saigon South in Ho Chi Minh City (Phu My Hung), you'll be steps from Saigon Exhibition and Convention Center and Saigon Paragon Mall.  This hotel …",
      "longitude": "106.72211",
      "latitude": "10.73029",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "73 Hoang Van Thai Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "4055846.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Family Room",
            "roomCode": "201541418",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Save 55%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Family Room",
            "roomCode": "201541418",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Save 55%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "53E99",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "597896",
      "cover": "http://i.travelapi.com/hotels/16000000/15360000/15351700/15351621/e233d200_t.jpg",
      "rate": "3.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Sunrise Central Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Sunrise Central Hotel in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Benthanh Street Food Market and 3 minutes by foot from …",
      "longitude": "106.69657",
      "latitude": "10.77359",
      "promotion": "Save 55%",
      "supplierCode": "s007",
      "hotelAddress": "135-137 Ly Tu Trong Str, Ben Thanh Ward, "
    },
    {
      "roomGroup": {
        "totalPrice": "4061966.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Apartment, 1 Bedroom",
            "roomCode": "201748598",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 8%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Apartment, 1 Bedroom",
            "roomCode": "201748598",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 8%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "5408D",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "643402",
      "cover": "http://i.travelapi.com/hotels/17000000/16580000/16570300/16570261/d2ac902c_t.jpg",
      "rate": "3.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Saigon Court Serviced Apartment",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Saigon Court Serviced Apartment in Ho Chi Minh City, you'll be within a 10-minute walk of Xa Loi Pagoda and Golden Dragon Water Puppet Theatre.  This …",
      "longitude": "106.68809",
      "latitude": "10.77635",
      "promotion": "Private sale: save 8%",
      "supplierCode": "s007",
      "hotelAddress": "149 Nguyen Dinh Chieu Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "4073472.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Apartment, 2 Bedrooms",
            "roomCode": "219317009",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Apartment, 2 Bedrooms",
            "roomCode": "219317009",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "54439",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "969576",
      "cover": "http://i.travelapi.com/hotels/27000000/26920000/26911800/26911733/79ad59d7_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "The Manner Luxury Apartment",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at The Manner Luxury Apartment in Ho Chi Minh City (Bach Dang Riverside), you'll be a 4-minute walk from Riverside and 7 minutes by foot from Nha Rong …",
      "longitude": "106.70278",
      "latitude": "10.76588",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "56 Ben Van Don W.12 D.4, "
    },
    {
      "roomGroup": {
        "totalPrice": "4267843.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Family Triple Room, 3 Bedrooms",
            "roomCode": "221715809",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Family Triple Room, 3 Bedrooms",
            "roomCode": "221715809",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "58241",
        "contractName": ""
      },
      "destinationCode": "TSN",
      "hotelId": "952865",
      "cover": "http://i.travelapi.com/hotels/26000000/25830000/25823400/25823346/d0bf7130_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "A&L Luxury Apartment Skyscraper Campus Vinhomes",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at A&L Luxury Apartment Skyscraper Campus Vinhomes in Ho Chi Minh City (Hang Xanh), you'll be within a 10-minute drive of Van Thanh Tourist Park and …",
      "longitude": "106.71928",
      "latitude": "10.79553",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "208 nguyen huu canh, "
    },
    {
      "roomGroup": {
        "totalPrice": "4299912.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Apartment, 1 Bedroom (Landmark Plus)",
            "roomCode": "219314334",
            "boardName": "Free Breakfast",
            "specialOffer": "",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Apartment, 1 Bedroom (Landmark Plus)",
            "roomCode": "219314334",
            "boardName": "Free Breakfast",
            "specialOffer": "",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "58C7D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "937226",
      "cover": "http://i.travelapi.com/hotels/26000000/25030000/25025900/25025900/026e1fea_t.jpg",
      "rate": "3.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Vinhomes Central Park",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Vinhomes Central Park in Ho Chi Minh City (Hang Xanh), you'll be within a 10-minute drive of Van Thanh Tourist Park and Vincom Mega Mall.  This …",
      "longitude": "106.7207",
      "latitude": "10.79438",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "202 Nguyen Huu Canh, Ward 22, "
    },
    {
      "roomGroup": {
        "totalPrice": "4397097.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Luxury Apartment, 2 Bedrooms, City View",
            "roomCode": "216310215",
            "boardName": "",
            "specialOffer": "Save 15%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Luxury Apartment, 2 Bedrooms, City View",
            "roomCode": "216310215",
            "boardName": "",
            "specialOffer": "Save 15%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "5AB81",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "948943",
      "cover": "http://i.travelapi.com/hotels/26000000/25740000/25739000/25738985/84df53d0_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "The Moment",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City (Bach Dang Riverside), The Moment is within a 10-minute drive of Riverside and Museum of Fine Arts.  This apartment is 1.2 mi (1.9 km) …",
      "longitude": "106.6989",
      "latitude": "10.76277",
      "promotion": "Save 15%",
      "supplierCode": "s007",
      "hotelAddress": "151 Ben Van Don, Ward 6, Ditsrict 4, "
    },
    {
      "roomGroup": {
        "totalPrice": "4399790.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Apartment, 1 Bedroom",
            "roomCode": "220807594",
            "boardName": "",
            "specialOffer": "Seasonal deal: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Apartment, 1 Bedroom",
            "roomCode": "220807594",
            "boardName": "",
            "specialOffer": "Seasonal deal: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "5AC5D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "859608",
      "cover": "http://i.travelapi.com/hotels/24000000/23120000/23111800/23111767/22321496_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Luxury Ben Thanh TAA Apartments",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Luxury Ben Thanh TAA Apartments in Ho Chi Minh City, you'll be within a 5-minute walk of Pham Ngu Lao Backpacker Area and Bui Vien Walking Street.  …",
      "longitude": "106.69706",
      "latitude": "10.76891",
      "promotion": "Seasonal deal: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "45 Dang Thi Nhu, "
    },
    {
      "roomGroup": {
        "totalPrice": "4598323.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Junior Suite",
            "roomCode": "200727773",
            "boardName": "Breakfast Buffet",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Junior Suite",
            "roomCode": "200727773",
            "boardName": "Breakfast Buffet",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "5EBB9",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "461187",
      "cover": "http://i.travelapi.com/hotels/9000000/8350000/8349000/8349000/c51da774_t.jpg",
      "rate": "3.5",
      "destinationName": "Thu Dau Mot",
      "hotelName": "Becamex Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Becamex Hotel, you'll be centrally located in Thu Dau Mot, 5.9 mi (9.6 km) from Lac Canh Dai Nam Van Hien Theme Park and 6.7 mi (10.7 km) from Dai Nam …",
      "longitude": "106.67012",
      "latitude": "10.97492",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "230 Binh Duong Boulevard, "
    },
    {
      "roomGroup": {
        "totalPrice": "4602240.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Suite, 1 King Bed",
            "roomCode": "200299030",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Private sale: save 45%",
            "availability": "10",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Suite, 1 King Bed",
            "roomCode": "200299030",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Private sale: save 45%",
            "availability": "10",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "5ECF9",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "432832",
      "cover": "http://i.travelapi.com/hotels/7000000/6130000/6128900/6128890/00ba481e_t.jpg",
      "rate": "4.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Tan Son Nhat Saigon Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City (Phu Nhuan), Tan Son Nhat Saigon Hotel is within a 10-minute drive of Vinh Nghiem Pagoda and Saigon Superbowl.  This 4.5-star hotel is …",
      "longitude": "106.67074",
      "latitude": "10.79994",
      "promotion": "Private sale: save 45%",
      "supplierCode": "s007",
      "hotelAddress": "202 Hoang Van Thu Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "4671273.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Classic Room",
            "roomCode": "221419811",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "10",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Classic Room",
            "roomCode": "221419811",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "10",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "60301",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "1014990",
      "cover": "http://i.travelapi.com/hotels/28000000/27370000/27360500/27360486/811f4ae8_t.jpg",
      "rate": "4.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Citadines Regency Saigon",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Citadines Regency Saigon in Ho Chi Minh City, you'll be near the airport and minutes from Diamond Plaza and War Remnants Museum.  This 4.5-star …",
      "longitude": "106.69444",
      "latitude": "10.78423",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "20-23 Pham Ngoc Thach, "
    },
    {
      "roomGroup": {
        "totalPrice": "4681065.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Executive 1-bedroom",
            "roomCode": "201548213",
            "boardName": "",
            "specialOffer": "Save 23%",
            "availability": "11",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Executive 1-bedroom",
            "roomCode": "201548213",
            "boardName": "",
            "specialOffer": "Save 23%",
            "availability": "11",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "60621",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "596879",
      "cover": "http://i.travelapi.com/hotels/16000000/15260000/15253600/15253503/25a6e98e_t.jpg",
      "rate": "4.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "SILA Urban Living",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at SILA Urban Living places you in the heart of Ho Chi Minh City, a 2-minute drive from War Remnants Museum and 8 minutes from Saigon Square.  This 4-star …",
      "longitude": "106.69038",
      "latitude": "10.781",
      "promotion": "Save 23%",
      "supplierCode": "s007",
      "hotelAddress": "21 Ngo Thoi Nhiem Street, District 3, "
    },
    {
      "roomGroup": {
        "totalPrice": "4733942.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Room, 1 Bedroom",
            "roomCode": "219307138",
            "boardName": "",
            "specialOffer": "",
            "availability": "35",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Room, 1 Bedroom",
            "roomCode": "219307138",
            "boardName": "",
            "specialOffer": "",
            "availability": "35",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "61701",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "850813",
      "cover": "http://i.travelapi.com/hotels/23000000/22960000/22955200/22955129/5a445239_t.jpg",
      "rate": "4.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Oakwood Residence Saigon",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, Oakwood Residence Saigon is connected to a shopping center, within a 15-minute drive of SC VivoCity and The Cresent Mall.  This 4-star …",
      "longitude": "106.70401",
      "latitude": "10.73007",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "1056A Nguyen Van Linh, Tan Phong Ward, "
    },
    {
      "roomGroup": {
        "totalPrice": "4837248.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Apartment, 3 Bedrooms",
            "roomCode": "215117672",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Apartment, 3 Bedrooms",
            "roomCode": "215117672",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "637F9",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1035560",
      "cover": "http://i.travelapi.com/hotels/30000000/29310000/29302900/29302893/1a7408c1_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Saigon Apartment The Gold View",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City, Saigon Apartment The Gold View is in the business district and convenient to Saigon Culinary Arts Centre and Bui Vien Walking Street.  …",
      "longitude": "106.69187",
      "latitude": "10.75615",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "346 Ben Van Don Street,, "
    },
    {
      "roomGroup": {
        "totalPrice": "4888656.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Luxury Apartment, 2 Bedrooms, Non Smoking, City View",
            "roomCode": "215410332",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Luxury Apartment, 2 Bedrooms, Non Smoking, City View",
            "roomCode": "215410332",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "64861",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "918804",
      "cover": "http://i.travelapi.com/hotels/25000000/24330000/24327900/24327835/253f08e2_t.jpg",
      "rate": "3.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Luxury Apartment In Ben Thanh Tower",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Luxury Apartment In Ben Thanh Tower in Ho Chi Minh City, you'll be within a 5-minute walk of Museum of Fine Arts and Pham Ngu Lao Backpacker Area.  …",
      "longitude": "106.69765",
      "latitude": "10.76909",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "Le Thi Hong Gam, "
    },
    {
      "roomGroup": {
        "totalPrice": "4990248.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "One Bedroom Deluxe Apartment",
            "roomCode": "200259849",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "One Bedroom Deluxe Apartment",
            "roomCode": "200259849",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "668CD",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "427739",
      "cover": "http://i.travelapi.com/hotels/6000000/5840000/5833600/5833509/762240d7_t.jpg",
      "rate": "4.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Capri by Fraser, Ho Chi Minh City",
      "hotelDescription": "<p><b>Property Location</b> <br />Located in Ho Chi Minh City (Phu My Hung), Capri by Fraser, Ho Chi Minh City is minutes from Saigon Exhibition and Convention Center and close to The Cresent Mall.  …",
      "longitude": "106.72367",
      "latitude": "10.73044",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "No.2, Street C, Tan Phu Ward, District 7, "
    },
    {
      "roomGroup": {
        "totalPrice": "5328806.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Apartment, 2 Bedrooms",
            "roomCode": "220221455",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Apartment, 2 Bedrooms",
            "roomCode": "220221455",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "6D4D9",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "953526",
      "cover": "http://i.travelapi.com/hotels/26000000/25840000/25836500/25836459/cbdef18b_t.jpg",
      "rate": "3.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Ben Thanh Tower",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Ben Thanh Tower in Ho Chi Minh City, you'll be within a 5-minute walk of Pham Ngu Lao Backpacker Area and Bui Vien Walking Street.  This apartment is …",
      "longitude": "106.6972",
      "latitude": "10.76879",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "136 Le Thi Hong Gam Street District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "5431867.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Family Apartment, 2 Bedrooms, Kitchen, City View",
            "roomCode": "219904850",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Family Apartment, 2 Bedrooms, Kitchen, City View",
            "roomCode": "219904850",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": false,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "6F5BD",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "863127",
      "cover": "http://i.travelapi.com/hotels/24000000/23150000/23143200/23143175/d5b6259e_t.jpg",
      "rate": "3.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "The Manner Icon 56 Rooftop Pool",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at The Manner Icon 56 Rooftop Pool  in Ho Chi Minh City (Bach Dang Riverside), you'll be a 4-minute walk from Riverside and 7 minutes by foot from Nha …",
      "longitude": "106.70291",
      "latitude": "10.76605",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "56 Ben Van Don, "
    },
    {
      "roomGroup": {
        "totalPrice": "6219388.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Grand Apartment, 3 Bedrooms",
            "roomCode": "215407753",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Grand Apartment, 3 Bedrooms",
            "roomCode": "215407753",
            "boardName": "",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "7F111",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "922487",
      "cover": "http://i.travelapi.com/hotels/25000000/24410000/24401400/24401350/67e1f968_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Saigon Bella Bello",
      "hotelDescription": "<p><b>Property Location</b> <br />Saigon Bella Bello is centrally located in Ho Chi Minh City, a 4-minute walk from Rainbow Bridge and 7 minutes by foot from Cho Xom Chieu.  This aparthotel is 1 mi …",
      "longitude": "106.70278",
      "latitude": "10.76588",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "56 Ben Van Don street, "
    },
    {
      "roomGroup": {
        "totalPrice": "6556723.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Apartment, 3 Bedrooms (Block A)",
            "roomCode": "220510365",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Apartment, 3 Bedrooms (Block A)",
            "roomCode": "220510365",
            "boardName": "",
            "specialOffer": "Private sale: save 10%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "85CB9",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "899098",
      "cover": "http://i.travelapi.com/hotels/24000000/23950000/23946000/23945953/f3558ec5_t.jpg",
      "rate": "3.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "3BRs Luxury Apartment Cityview",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at 3BRs Luxury Apartment Cityview in Ho Chi Minh City, you'll be within a 10-minute drive of Nha Rong Wharf and Riverside.  This apartment is 1.5 mi (2.4 …",
      "longitude": "106.69121",
      "latitude": "10.7566",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "346 Ben Van Don Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "6790017.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Twin Room",
            "roomCode": "218102615",
            "boardName": "Free Breakfast",
            "specialOffer": "",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Twin Room",
            "roomCode": "218102615",
            "boardName": "Free Breakfast",
            "specialOffer": "",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "8A72D",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "857108",
      "cover": "http://i.travelapi.com/hotels/24000000/23080000/23077800/23077788/fd63b8f5_t.jpg",
      "rate": "2.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Spotlight Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Spotlight Hotel in Ho Chi Minh City (Downtown Ho Chi Minh City), you'll be steps from Pham Ngu Lao Backpacker Area and Bui Vien Walking Street.  This …",
      "longitude": "106.68969",
      "latitude": "10.76638",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "184 Cong Quynh,District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "6990753.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Club Deluxe King Or Twin",
            "roomCode": "201834530",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Save 35%",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Club Deluxe King Or Twin",
            "roomCode": "201834530",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Save 35%",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "8E73D",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "272293",
      "cover": "http://i.travelapi.com/hotels/1000000/10000/6900/6879/316dfb4c_t.jpg",
      "rate": "5.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Eastin Grand Hotel Saigon",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Eastin Grand Hotel Saigon places you in the heart of Ho Chi Minh City, convenient to Vinh Nghiem Pagoda and Jade Emperor Pagoda.  This 5-star hotel is …",
      "longitude": "106.67312",
      "latitude": "10.79648",
      "promotion": "Save 35%",
      "supplierCode": "s007",
      "hotelAddress": "253 Nguyen Van Troi Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "7966526.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Executive Double Room, 1 Queen Bed",
            "roomCode": "201462552",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Member’s price: 60%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Executive Double Room, 1 Queen Bed",
            "roomCode": "201462552",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Member’s price: 60%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "A1EA5",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "565589",
      "cover": "http://i.travelapi.com/hotels/14000000/13200000/13194600/13194594/0205668d_t.jpg",
      "rate": "3.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Asian Ruby Center Point Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Asian Ruby Center Point Hotel places you in the heart of Ho Chi Minh City, steps from Saigon River and Dong Khoi Shopping Street.  This luxury hotel is 0.1 …",
      "longitude": "106.70479",
      "latitude": "10.77539",
      "promotion": "Member’s price: 60%",
      "supplierCode": "s007",
      "hotelAddress": "46 - 48 Mac Thi Buoi, "
    },
    {
      "roomGroup": {
        "totalPrice": "8086968.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Suite",
            "roomCode": "202254283",
            "boardName": "",
            "specialOffer": "",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Suite",
            "roomCode": "202254283",
            "boardName": "",
            "specialOffer": "",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "A4515",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "757875",
      "cover": "http://i.travelapi.com/hotels/20000000/19320000/19316300/19316222/8140b46c_t.jpg",
      "rate": "4.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Sherwood Suites",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Sherwood Suites, you'll be centrally located in Ho Chi Minh City, just a 4-minute walk from War Remnants Museum and 8 minutes by foot from Southern …",
      "longitude": "106.69229",
      "latitude": "10.78208",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "192 Nam Ky Khoi Nghia, District 3, "
    },
    {
      "roomGroup": {
        "totalPrice": "8159184.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Club Double or Twin Room",
            "roomCode": "322863",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Flash sale: save 60%",
            "availability": "10",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Club Double or Twin Room",
            "roomCode": "322863",
            "boardName": "Breakfast Buffet",
            "specialOffer": "Flash sale: save 60%",
            "availability": "10",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "A5C21",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "192235",
      "cover": "http://i.travelapi.com/hotels/1000000/200000/197900/197856/62df329d_t.jpg",
      "rate": "4.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Hotel Equatorial Ho Chi Minh City",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Hotel Equatorial Ho Chi Minh City places you in the heart of Ho Chi Minh City, within a 15-minute walk of Cho Quan Church and An Dong Market.  This …",
      "longitude": "106.67884",
      "latitude": "10.76317",
      "promotion": "Flash sale: save 60%",
      "supplierCode": "s007",
      "hotelAddress": "242 Tran Binh Trong St, District 5, "
    },
    {
      "roomGroup": {
        "totalPrice": "8685993.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Premier Suite, 1 King Bed",
            "roomCode": "216917174",
            "boardName": "Free Breakfast",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Premier Suite, 1 King Bed",
            "roomCode": "216917174",
            "boardName": "Free Breakfast",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "B0441",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "1002661",
      "cover": "http://i.travelapi.com/hotels/28000000/27190000/27184600/27184524/ffe48618_t.jpg",
      "rate": "3.5",
      "destinationName": "Thu Dau Mot",
      "hotelName": "Becamex Hotel - New City",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Becamex Hotel - New City in Thu Dau Mot, you'll be 11.5 mi (18.5 km) from Royal Island Golf and 21.3 mi (34.2 km) from Suoi Tien Amusement Park.  This …",
      "longitude": "106.68412",
      "latitude": "11.0565",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "B2, Hung Vuong Street, Hoa Phu Ward,, "
    },
    {
      "roomGroup": {
        "totalPrice": "8965310.400",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Colonial Deluxe City or Pool View (Breakfast included)",
            "roomCode": "200037082",
            "boardName": "Free Breakfast",
            "specialOffer": "Save 37%",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Colonial Deluxe City or Pool View (Breakfast included)",
            "roomCode": "200037082",
            "boardName": "Free Breakfast",
            "specialOffer": "Save 37%",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "B5D65",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "189902",
      "cover": "http://i.travelapi.com/hotels/1000000/490000/481700/481665/4cda3937_t.jpg",
      "rate": "4.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Hotel Majestic Saigon",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Hotel Majestic Saigon places you in the heart of Ho Chi Minh City, steps from Riverside and Saigon River.  This 4.5-star hotel is 0.1 mi (0.1 km) from Dong …",
      "longitude": "106.70642",
      "latitude": "10.77296",
      "promotion": "Save 37%",
      "supplierCode": "s007",
      "hotelAddress": "01 Dong Khoi Street District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "9238507.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Residence Club King Room",
            "roomCode": "201921667",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 10%",
            "availability": "6",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Residence Club King Room",
            "roomCode": "201921667",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 10%",
            "availability": "6",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "BB495",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "113617",
      "cover": "http://i.travelapi.com/hotels/1000000/20000/18200/18170/18170_159_t.jpg",
      "rate": "5.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "New World Saigon Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />New World Saigon Hotel is in the heart of Ho Chi Minh City, within a 5-minute walk of Bui Vien Walking Street and Zen Plaza.  This 5-star hotel is 0.5 mi (0.8 km) …",
      "longitude": "106.69405",
      "latitude": "10.7704",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "76 Le Lai Street, District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "9288201.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Bach Suite",
            "roomCode": "218102526",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 10%",
            "availability": "3",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Bach Suite",
            "roomCode": "218102526",
            "boardName": "Free Breakfast",
            "specialOffer": "Private sale: save 10%",
            "availability": "3",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "BC471",
        "contractName": ""
      },
      "destinationCode": "",
      "hotelId": "856069",
      "cover": "http://i.travelapi.com/hotels/24000000/23070000/23061600/23061538/422f9601_t.jpg",
      "rate": "3.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Bach Suites Saigon",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Bach Suites Saigon in Ho Chi Minh City, you'll be within a 10-minute walk of Dong Khoi Shopping Street and Diamond Plaza.  This aparthotel is 0.5 mi …",
      "longitude": "106.69656",
      "latitude": "10.78251",
      "promotion": "Private sale: save 10%",
      "supplierCode": "s007",
      "hotelAddress": "10A Pham Ngoc Thach, District 3, "
    },
    {
      "roomGroup": {
        "totalPrice": "11463984.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Room",
            "roomCode": "200258769",
            "boardName": "Breakfast Buffet",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Room",
            "roomCode": "200258769",
            "boardName": "Breakfast Buffet",
            "specialOffer": "",
            "availability": "2",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "E7AD1",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "427714",
      "cover": "http://i.travelapi.com/hotels/6000000/5830000/5823200/5823124/d10cdb4b_t.jpg",
      "rate": "3.5",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "White Lotus Hotel",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at White Lotus Hotel places you in the heart of Ho Chi Minh City, steps from Saigon River and Dong Khoi Shopping Street.  This hotel is 0.1 mi (0.1 km) from …",
      "longitude": "106.70507",
      "latitude": "10.7778",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "6A, Thi Sach Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "11712211.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Room, City View",
            "roomCode": "200749775",
            "boardName": "",
            "specialOffer": "",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Room, City View",
            "roomCode": "200749775",
            "boardName": "",
            "specialOffer": "",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "ECA09",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "161414",
      "cover": "http://i.travelapi.com/hotels/1000000/210000/200900/200817/305e63ba_t.jpg",
      "rate": "5.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Renaissance Riverside Hotel Saigon",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Renaissance Riverside Hotel Saigon places you in the heart of Ho Chi Minh City, steps from Riverside and Saigon River.  This 5-star hotel is 0.1 mi (0.1 …",
      "longitude": "106.70653",
      "latitude": "10.77472",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "8-15 Ton Duc Thang St, District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "11867659.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Classic Room",
            "roomCode": "201043963",
            "boardName": "",
            "specialOffer": "",
            "availability": "97",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Classic Room",
            "roomCode": "201043963",
            "boardName": "",
            "specialOffer": "",
            "availability": "97",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "EFBA5",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "515609",
      "cover": "http://i.travelapi.com/hotels/11000000/10480000/10470200/10470130/ddaaad7c_t.jpg",
      "rate": "5.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Le Meridien Saigon",
      "hotelDescription": "<p><b>Property Location</b> <br />With a stay at Le Meridien Saigon, you'll be centrally located in Ho Chi Minh City, steps from Riverside and within a 5-minute walk of Ton Duc Thang Museum.  This …",
      "longitude": "106.70762",
      "latitude": "10.77967",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "3C Ton Duc Thang Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "12327883.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "262267",
            "boardName": "",
            "specialOffer": "",
            "availability": "2147483647",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Superior Room",
            "roomCode": "262267",
            "boardName": "",
            "specialOffer": "",
            "availability": "2147483647",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "F8E85",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "184237",
      "cover": "http://i.travelapi.com/hotels/1000000/210000/200900/200805/795a9fd3_t.jpg",
      "rate": "5.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Sofitel Saigon Plaza",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Sofitel Saigon Plaza places you in the heart of Ho Chi Minh City, within a 10-minute walk of Vietnam National Museum of History and Dong Khoi Shopping …",
      "longitude": "106.70231",
      "latitude": "10.78436",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "17 Le Duan Boulevard, "
    },
    {
      "roomGroup": {
        "totalPrice": "12767544.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Twin, City or River View",
            "roomCode": "200809679",
            "boardName": "",
            "specialOffer": "",
            "availability": "6",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Twin, City or River View",
            "roomCode": "200809679",
            "boardName": "",
            "specialOffer": "",
            "availability": "6",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "101AD5",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "477790",
      "cover": "http://i.travelapi.com/hotels/10000000/9290000/9287600/9287591/b692bdba_t.jpg",
      "rate": "5.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "The Reverie Saigon",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at The Reverie Saigon places you in the heart of Ho Chi Minh City, steps from Riverside and Saigon River.  This 5-star hotel is 0.1 mi (0.1 km) from Dong Khoi …",
      "longitude": "106.7046",
      "latitude": "10.77339",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "22 - 36 Nguyen Hue Boulevard, "
    },
    {
      "roomGroup": {
        "totalPrice": "13723732.800",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Grand Executive Suite King",
            "roomCode": "210303095",
            "boardName": "Free Breakfast",
            "specialOffer": "Special deal: save 25%",
            "availability": "4",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Grand Executive Suite King",
            "roomCode": "210303095",
            "boardName": "Free Breakfast",
            "specialOffer": "Special deal: save 25%",
            "availability": "4",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "114BFD",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "279302",
      "cover": "http://i.travelapi.com/hotels/1000000/490000/481700/481662/78c467d8_t.jpg",
      "rate": "5.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Grand Hotel Saigon",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Grand Hotel Saigon places you in the heart of Ho Chi Minh City, steps from Riverside and Saigon River.  This 5-star hotel is 0.1 mi (0.1 km) from Dong Khoi …",
      "longitude": "106.70561",
      "latitude": "10.77368",
      "promotion": "Special deal: save 25%",
      "supplierCode": "s007",
      "hotelAddress": "8 Dong Khoi Street, District 1, "
    },
    {
      "roomGroup": {
        "totalPrice": "14369025.600",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Room, 1 King Bed, Pool View",
            "roomCode": "218428746",
            "boardName": "",
            "specialOffer": "",
            "availability": "5",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Room, 1 King Bed, Pool View",
            "roomCode": "218428746",
            "boardName": "",
            "specialOffer": "",
            "availability": "5",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "1219ED",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "208411",
      "cover": "http://i.travelapi.com/hotels/1000000/920000/910900/910861/910861_378_t.jpg",
      "rate": "5.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Sheraton Saigon Hotel & Towers",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Sheraton Saigon Hotel & Towers places you in the heart of Ho Chi Minh City, steps from Saigon River and Dong Khoi Shopping Street.  This 5-star hotel is …",
      "longitude": "106.7036",
      "latitude": "10.77559",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "88 Dong Khoi Street, "
    },
    {
      "roomGroup": {
        "totalPrice": "14555563.200",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Room, 1 King Bed",
            "roomCode": "200174728",
            "boardName": "",
            "specialOffer": "",
            "availability": "47",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Room, 1 King Bed",
            "roomCode": "200174728",
            "boardName": "",
            "specialOffer": "",
            "availability": "47",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "125575",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "239953",
      "cover": "http://i.travelapi.com/hotels/2000000/1210000/1202400/1202309/ad51baba_t.jpg",
      "rate": "5.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Park Hyatt Saigon",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Park Hyatt Saigon places you in the heart of Ho Chi Minh City, steps from Saigon River and Dong Khoi Shopping Street.  This 5-star hotel is 0.2 mi (0.3 km) …",
      "longitude": "106.70365",
      "latitude": "10.77737",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "2 Lam Son Square, "
    },
    {
      "roomGroup": {
        "totalPrice": "18946296.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Premium Room",
            "roomCode": "202069691",
            "boardName": "",
            "specialOffer": "",
            "availability": "2147483647",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Premium Room",
            "roomCode": "202069691",
            "boardName": "",
            "specialOffer": "",
            "availability": "2147483647",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "17CEB5",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "324403",
      "cover": "http://i.travelapi.com/hotels/3000000/2850000/2841700/2841656/fa637178_t.jpg",
      "rate": "5.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "InterContinental Saigon",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at InterContinental Saigon places you in the heart of Ho Chi Minh City, steps from Dong Khoi Shopping Street and 3 minutes by foot from Saigon Central Post …",
      "longitude": "106.7004",
      "latitude": "10.78087",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "Corner of Hai Ba Trung St & Le Duan Blvd, "
    },
    {
      "roomGroup": {
        "totalPrice": "19772496.000",
        "currencyCode": "VND",
        "packageRate": "N",
        "incomingOffice": "",
        "rooms": [
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Room (Sky Executive)",
            "roomCode": "201202034",
            "boardName": "Breakfast Buffet",
            "specialOffer": "",
            "availability": "2147483647",
            "boardCode": ""
          },
          {
            "characteristic": "",
            "shrui": "",
            "roomName": "Deluxe Room (Sky Executive)",
            "roomCode": "201202034",
            "boardName": "Breakfast Buffet",
            "specialOffer": "",
            "availability": "2147483647",
            "boardCode": ""
          }
        ],
        "nonRefundable": true,
        "roomAmenity": null,
        "promotion": "",
        "supplierCode": "s007",
        "privateCode": "18D661",
        "contractName": ""
      },
      "destinationCode": "SGN",
      "hotelId": "532715",
      "cover": "http://i.travelapi.com/hotels/12000000/11470000/11463300/11463205/e9cc6ce5_t.jpg",
      "rate": "5.0",
      "destinationName": "Ho Chi Minh City",
      "hotelName": "Hotel Des Arts Saigon Mgallery Collection",
      "hotelDescription": "<p><b>Property Location</b> <br />A stay at Hotel Des Arts Saigon Mgallery Collection places you in the heart of Ho Chi Minh City, within a 10-minute walk of Dong Khoi Shopping Street and Diamond …",
      "longitude": "106.69746",
      "latitude": "10.78221",
      "promotion": "",
      "supplierCode": "s007",
      "hotelAddress": "76 78 Nguyen Thi Minh Khai St, "
    }
  ]

        
        }
        }
        }
            
</script>