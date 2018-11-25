<template>
     <!-- content-->
                <div class="content">
                    <!--  carousel--> 
                    <div class="list-single-carousel-wrap fl-wrap" id="sec1">
                        <div class="fw-carousel fl-wrap full-height lightgallery">
                            <!-- slick-slide-item -->
                            <div class="slick-slide-item">
                                <div class="box-item">
                                    <img  src="images/gal/1.jpg"   alt="">
                                    <a href="images/gal/1.jpg" class="gal-link popup-image"><i class="fa fa-search"  ></i></a>
                                </div>
                            </div>
                            <!-- slick-slide-item end -->
                            <!-- slick-slide-item -->
                            <div class="slick-slide-item">
                                <div class="box-item">
                                    <img  src="images/gal/1.jpg"   alt="">
                                    <a href="images/gal/1.jpg" class="gal-link popup-image"><i class="fa fa-search"  ></i></a>
                                </div>
                            </div>
                            <!-- slick-slide-item end -->
                            <!-- slick-slide-item -->
                            <div class="slick-slide-item">
                                <div class="box-item">
                                    <img  src="images/gal/1.jpg"   alt="">
                                    <a href="images/gal/1.jpg" class="gal-link popup-image"><i class="fa fa-search"  ></i></a>
                                </div>
                            </div>
                            <!-- slick-slide-item end -->
                            <!-- slick-slide-item -->
                            <div class="slick-slide-item">
                                <div class="box-item">
                                    <img  src="images/gal/1.jpg"   alt="">
                                    <a href="images/gal/1.jpg" class="gal-link popup-image"><i class="fa fa-search"  ></i></a>
                                </div>
                            </div>
                            <!-- slick-slide-item end -->
                            <!-- slick-slide-item -->
                            <div class="slick-slide-item">
                                <div class="box-item">
                                    <img  src="images/gal/1.jpg"   alt="">
                                    <a href="images/gal/1.jpg" class="gal-link popup-image"><i class="fa fa-search"  ></i></a>
                                </div>
                            </div>
                            <!-- slick-slide-item end -->
                        </div>
                        <div class="swiper-button-prev sw-btn"><i class="fa fa-long-arrow-left"></i></div>
                        <div class="swiper-button-next sw-btn"><i class="fa fa-long-arrow-right"></i></div>
                    </div>
                    <!--  carousel  end--> 
                    <!--  section  -->
                    <section class="grey-blue-bg small-padding scroll-nav-container" id="sec2">
                        <!--  scroll-nav-wrapper  -->
                        <div class="scroll-nav-wrapper fl-wrap">
                            <div class="hidden-map-container fl-wrap">
                                <input id="pac-input" class="controls fl-wrap controls-mapwn" type="text" placeholder="What Nearby ?   Bar , Gym , Restaurant ">
                                <div class="map-container">
                                    <div id="singleMap" data-latitude="40.7427837" data-longitude="-73.11445617675781"></div>
                                </div>
                            </div>
                            <div class="clearfix"></div>
                            <div class="container">
                                <nav class="scroll-nav scroll-init">
                                    <ul>
                                        <li><a class="act-scrlink" href="#sec1">Top</a></li>
                                        <li><a href="#sec2">Details</a></li>
                                        <li><a href="#sec3">Amenities</a></li>
                                        <li><a href="#sec4">Rooms</a></li>
                                        <li><a href="#sec5">Reviews</a></li>
                                    </ul>
                                </nav>
                                <a href="#" class="show-hidden-map">  <span>On The Map</span> <i class="fal fa-map-marked-alt"></i></a>
                            </div>
                        </div>
                        <!--  scroll-nav-wrapper end  -->                    
                        <!--   container  -->
                        <div class="container">
                            <!--   row  -->
                            <div class="row ">
                                <!--   datails -->
                                <div class="col-md-8">
                                    <div class="list-single-main-container ">
                                        <!-- fixed-scroll-column  -->
                                        <div class="fixed-scroll-column">
                                            <div class="fixed-scroll-column-item fl-wrap">
                                                <div class="showshare sfcs fc-button"><i class="far fa-share-alt"></i><span>Share </span></div>
                                                <div class="share-holder fixed-scroll-column-share-container">
                                                    <div class="share-container  isShare"></div>
                                                </div>
                                                <a class="fc-button custom-scroll-link" href="#sec6"><i class="far fa-comment-alt-check"></i> <span>  Add review </span></a>
                                                <a class="fc-button" href="#"><i class="far fa-heart"></i> <span>Save</span></a>
                                                <a class="fc-button" href="booking-single.html"><i class="far fa-bookmark"></i> <span> Book Now </span></a>
                                            </div>
                                        </div>
                                        <!-- fixed-scroll-column end   -->
                                        <div class="breadcrumbs inline-breadcrumbs fl-wrap">
                                            <a href="#">Home</a><a href="#">Listings</a><a href="#">New York</a><span>Listing Single</span> 
                                        </div>
                                        <!--   list-single-main-item -->
                                        <div class="list-single-main-item fl-wrap list-single-hero-header " id="sec2">
                                            <div class="row">
                                                <div class="col-sm-7">
                                                    <div class="list-single-main-item-title fl-wrap">
                                                        <h3>{{roomAvailRS.name}}</h3>
                                                        <div class="listing-rating card-popup-rainingvis" data-starrating2="5"></div>
                                                        <div class="geodir-category-location fl-wrap"><a href="#"><i class="fas fa-map-marker-alt"></i> {{roomAvailRS.address1}}</a></div>
                                                    </div>
                                                </div>
                                                <div class="col-sm-5">
                                                    <div class="list-single-hero-price fl-wrap">Average Price<span> $ 120</span></div>
                                                </div>
                                            </div>
                                            <span class="fw-separator"></span>
                                            <!--reviews-score-wrap-->   
                                            <div class="reviews-score-wrap fl-wrap">
                                                <div class="review-score-total">
                                                    <span>
                                                    4.5
                                                    <strong>Very Good</strong>
                                                    </span>
                                                    <a href="#" class="color2-bg">Add Review</a>
                                                </div>
                                                <div class="review-score-detail">
                                                    <!-- review-score-detail-list-->
                                                    <div class="review-score-detail-list">
                                                        <!-- rate item-->
                                                        <div class="rate-item fl-wrap">
                                                            <div class="rate-item-title fl-wrap"><span>Cleanliness</span></div>
                                                            <div class="rate-item-bg" data-percent="100%">
                                                                <div class="rate-item-line color-bg"></div>
                                                            </div>
                                                            <div class="rate-item-percent">5.0</div>
                                                        </div>
                                                        <!-- rate item end-->
                                                        <!-- rate item-->
                                                        <div class="rate-item fl-wrap">
                                                            <div class="rate-item-title fl-wrap"><span>Comfort</span></div>
                                                            <div class="rate-item-bg" data-percent="90%">
                                                                <div class="rate-item-line color-bg"></div>
                                                            </div>
                                                            <div class="rate-item-percent">5.0</div>
                                                        </div>
                                                        <!-- rate item end-->                                                        
                                                        <!-- rate item-->
                                                        <div class="rate-item fl-wrap">
                                                            <div class="rate-item-title fl-wrap"><span>Staf</span></div>
                                                            <div class="rate-item-bg" data-percent="80%">
                                                                <div class="rate-item-line color-bg"></div>
                                                            </div>
                                                            <div class="rate-item-percent">4.0</div>
                                                        </div>
                                                        <!-- rate item end-->  
                                                        <!-- rate item-->
                                                        <div class="rate-item fl-wrap">
                                                            <div class="rate-item-title fl-wrap"><span>Facilities</span></div>
                                                            <div class="rate-item-bg" data-percent="90%">
                                                                <div class="rate-item-line color-bg"></div>
                                                            </div>
                                                            <div class="rate-item-percent">4.5</div>
                                                        </div>
                                                        <!-- rate item end--> 
                                                    </div>
                                                    <!-- review-score-detail-list end-->
                                                </div>
                                            </div>
                                            <!-- reviews-score-wrap end -->                                              	
                                        </div>
                                        <!--   list-single-main-item end -->
                                        <!-- list-single-header end -->
                                        <div class="list-single-facts fl-wrap">
                                            <!-- inline-facts -->
                                            <div class="inline-facts-wrap">
                                                <div class="inline-facts">
                                                    <i class="fal fa-bed"></i>
                                                    <div class="milestone-counter">
                                                        <div class="stats animaper">
                                                            45
                                                        </div>
                                                    </div>
                                                    <h6>Hotel Rooms</h6>
                                                </div>
                                            </div>
                                            <!-- inline-facts end -->
                                            <!-- inline-facts  -->
                                            <div class="inline-facts-wrap">
                                                <div class="inline-facts">
                                                    <i class="fal fa-users"></i>
                                                    <div class="milestone-counter">
                                                        <div class="stats animaper">
                                                            2557
                                                        </div>
                                                    </div>
                                                    <h6>Customers Every Year</h6>
                                                </div>
                                            </div>
                                            <!-- inline-facts end -->
                                            <!-- inline-facts -->
                                            <div class="inline-facts-wrap">
                                                <div class="inline-facts">
                                                    <i class="fal fa-taxi"></i>
                                                    <div class="milestone-counter">
                                                        <div class="stats animaper">
                                                            15
                                                        </div>
                                                    </div>
                                                    <h6>Distance to Center</h6>
                                                </div>
                                            </div>
                                            <!-- inline-facts end -->
                                            <!-- inline-facts -->
                                            <div class="inline-facts-wrap">
                                                <div class="inline-facts">
                                                    <i class="fal fa-cocktail"></i>
                                                    <div class="milestone-counter">
                                                        <div class="stats animaper">
                                                            4
                                                        </div>
                                                    </div>
                                                    <h6>Restaurant Inside</h6>
                                                </div>
                                            </div>
                                            <!-- inline-facts end -->                                                                        
                                        </div>
                                        <!--   list-single-main-item -->
                                        <div class="list-single-main-item fl-wrap">
                                            <div class="list-single-main-item-title fl-wrap">
                                                <h3>About Hotel </h3>
                                            </div>
                                            <p>Praesent eros turpis, commodo vel justo at, pulvinar mollis eros. Mauris aliquet eu quam id ornare. Morbi ac quam enim. Cras vitae nulla condimentum, semper dolor non, faucibus dolor. Vivamus adipiscing eros quis orci fringilla, sed pretium lectus viverra. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Donec nec velit non odio aliquam suscipit. Sed non neque faucibus, condimentum lectus at, accumsan enim. Fusce pretium egestas cursus. Etiam consectetur, orci vel rutrum volutpat, odio odio pretium nisiodo tellus libero et urna. Sed commodo ipsum ligula, id volutpat risus vehicula in. Pellentesque non massa eu nibh posuere bibendum non sed enim. Maecenas lobortis nulla sem, vel egestas  . </p>
                                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas in pulvinar neque. Nulla finibus lobortis pulvinar. Donec a consectetur nulla. Nulla posuere sapien vitae lectus suscipit, et pulvinar nisi tincidunt. Aliquam erat volutpat. Curabitur convallis fringilla diam sed aliquam. Sed tempor iaculis massa faucibus feugiat. In fermentum facilisis massa, a consequat .</p>
                                            <a href="https://vimeo.com/70851162" class="btn flat-btn color-bg big-btn float-btn image-popup">Video Presentation <i class="fal fa-play"></i></a>
                                        </div>
                                        <!--   list-single-main-item end -->
                                        <!--   list-single-main-item -->
                                        <div class="list-single-main-item fl-wrap" id="sec3">
                                            <div class="list-single-main-item-title fl-wrap">
                                                <h3>Amenities</h3>
                                            </div>
                                            <div class="listing-features fl-wrap">
                                                <ul>

                                                     <li v-for="add in valueAdds">
                                                        <i v-if="add==='Breakfast Buffet'" class="fal fa-utensils"></i>
                                                        <i v-if="add==='Free Wireless Internet'" class="fal fa-wifi"></i>
                                                        
                                                         {{add}}</li>

                                                    <!-- <li><i class="fal fa-rocket"></i> Elevator in building</li>
                                                    <li><i class="fal fa-wifi"></i> Free Wi Fi</li>
                                                    <li><i class="fal fa-parking"></i> Free Parking</li>
                                                    <li><i class="fal fa-snowflake"></i> Air Conditioned</li>
                                                    <li><i class="fal fa-plane"></i>Airport Shuttle</li>
                                                    <li><i class="fal fa-paw"></i> Pet Friendly</li>
                                                    <li><i class="fal fa-utensils"></i> Restaurant Inside</li>
                                                    <li><i class="fal fa-wheelchair"></i> Wheelchair Friendly</li> -->
                                                </ul>
                                            </div>
                                            <span class="fw-separator"></span>
                                            <div class="list-single-main-item-title no-dec-title fl-wrap">
                                                <h3>Tags</h3>
                                            </div>
                                            <div class="list-single-tags tags-stylwrap">
                                                <a href="#">Hotel</a>
                                                <a href="#">Hostel</a>
                                                <a href="#">Room</a>
                                                <a href="#">Spa</a>
                                                <a href="#">Restourant</a>
                                                <a href="#">Parking</a>                                                                               
                                            </div>
                                        </div>
                                        <!--   list-single-main-item end -->     
                                        <!-- accordion-->
                                        <div class="accordion mar-top">
                                            <a class="toggle act-accordion" href="#">checkInInstructions  <span></span></a>
                                            <div class="accordion-inner visible">
                                                <p v-html="roomAvailRS.checkInInstructions"> </p>
                                            </div>
                                        </div>
                                        <!-- accordion end -->                                                     
                                        <!--   list-single-main-item -->
                                        <div class="list-single-main-item fl-wrap" id="sec4">
                                            <div class="list-single-main-item-title fl-wrap">
                                                <h3>Available Rooms</h3>
                                            </div>
                                            <!--   rooms-container -->
                                            <div class="rooms-container fl-wrap">
                                                <!--  rooms-item -->
                                                <div class="rooms-item fl-wrap" v-for="(roomRate, index) in roomAvailRS.roomRateDetailsList" :key="index" >
                                                    <div class="rooms-media">
                                                        <img src="images/gal/1.jpg" alt="">
                                                        <div class="dynamic-gal more-photos-button" data-dynamicPath="[{'src': 'images/gal/slider/1.jpg'}, {'src': 'images/gal/slider/1.jpg'},{'src': 'images/gal/slider/1.jpg'}]">  View Gallery <span>3 photos</span> <i class="far fa-long-arrow-right"></i></div>
                                                    </div>
                                                    <div class="rooms-details">
                                                        <div class="rooms-details-header fl-wrap">
                                                            <span class="rooms-price" v-if="roomRate.rateInfos&&roomRate.rateInfos.chargeableRateInfo">{{roomRate.rateInfos.chargeableRateInfo.total}} <strong>  {{roomRate.rateInfos.chargeableRateInfo.currencyCode}} </strong></span>
                                                            <h3>Standard Family Room</h3>
                                                        <div v-for="roomRateGroup in roomRate.rateInfos.roomGroup">
                                                            <h5>
                                                                <!-- Number Of Adults: <span>{{roomRateGroup.numberOfAdults}} persons</span>
                                                                Number Of Children: <span>{{roomRateGroup.numberOfChildren}} persons</span> -->
                                                                </h5></div>
                                                        </div>
                                                        <p>    {{roomRate.roomDescription[0]}}</p>
                                                        <div class="facilities-list fl-wrap">
                                                            <ul>
                                                                <!-- roomRateDetailsList[""0""].valueAdds -->
                                                                <li v-for="roomRateAdd in roomRate.valueAdds">
                                                                    
                                                        <i v-if="roomRateAdd.description==='Breakfast Buffet'" class="fal fa-utensils"></i>
                                                        <i v-if="roomRateAdd.description==='Free Wireless Internet'" class="fal fa-wifi"></i>
                                                                   
                                                                    <span>{{roomRateAdd.description}}</span></li>
                                                                <!-- <li><i class="fal fa-bath"></i><span>1 Bathroom</span></li>
                                                                <li><i class="fal fa-snowflake"></i><span>Air conditioner</span></li>
                                                                <li><i class="fal fa-tv"></i><span> Tv Inside</span></li>
                                                                <li><i class="fas fa-concierge-bell"></i><span>Breakfast</span></li> -->
                                                            </ul>
                                                            <a href="rooms/room1.html" class="btn color-bg ajax-link">Details<i class="fas fa-caret-right"></i></a>
                                                        </div>
                                                    </div>
                                                </div>
                                                <!--  rooms-item end -->
                                                <!--  rooms-item -->
                                                <div class="rooms-item fl-wrap">
                                                    <div class="rooms-media">
                                                        <img src="images/gal/1.jpg" alt="">
                                                        <div class="dynamic-gal more-photos-button" data-dynamicPath="[{'src': 'images/gal/slider/1.jpg'}, {'src': 'images/gal/slider/1.jpg'}, {'src': 'images/gal/slider/1.jpg'} ]">View Gallery <span>3 photos</span> <i class="far fa-long-arrow-right"></i></div>
                                                    </div>
                                                    <div class="rooms-details">
                                                        <div class="rooms-details-header fl-wrap">
                                                            <span class="rooms-price">$122 <strong> / person</strong></span>
                                                            <h3>Superior Double Room</h3>
                                                            <h5>Max Guests: <span>4 persons</span></h5>
                                                        </div>
                                                        <p>Morbi varius, nulla sit amet rutrum elementum, est elit finibus tellus, ut tristique elit risus at metus. Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
                                                        <div class="facilities-list fl-wrap">
                                                            <ul>
                                                                <li><i class="fal fa-wifi"></i><span>Free WiFi</span></li>
                                                                <li><i class="fal fa-parking"></i><span>Parking</span></li>
                                                                <li><i class="fal fa-smoking-ban"></i><span>Non-smoking Rooms</span></li>
                                                                <li><i class="fal fa-utensils"></i><span> Restaurant</span></li>
                                                            </ul>
                                                            <a href="rooms/room2.html" class="btn color-bg ajax-link">Details<i class="fas fa-caret-right"></i></a>
                                                        </div>
                                                    </div>
                                                </div>
                                                <!--  rooms-item end -->   
                                                <!--  rooms-item -->
                                                <div class="rooms-item fl-wrap">
                                                    <div class="rooms-media">
                                                        <img src="images/gal/1.jpg" alt="">
                                                        <div class="dynamic-gal more-photos-button" data-dynamicPath="[{'src': 'images/gal/slider/1.jpg'},{'src': 'images/gal/slider/1.jpg'}, {'src': 'images/gal/slider/1.jpg'},{'src': 'images/gal/slider/1.jpg'}]"> View Gallery <span>4 photos</span> <i class="far fa-long-arrow-right"></i> </div>
                                                    </div>
                                                    <div class="rooms-details">
                                                        <div class="rooms-details-header fl-wrap">
                                                            <span class="rooms-price">$310 <strong> / person</strong></span>
                                                            <h3>Deluxe Single Room</h3>
                                                            <h5>Max Guests: <span>2 persons</span></h5>
                                                        </div>
                                                        <p>Morbi varius, nulla sit amet rutrum elementum, est elit finibus tellus, ut tristique elit risus at metus. Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
                                                        <div class="facilities-list fl-wrap">
                                                            <ul>
                                                                <li><i class="fal fa-wifi"></i><span>Free WiFi</span></li>
                                                                <li><i class="fal fa-parking"></i><span>Parking</span></li>
                                                                <li><i class="fal fa-smoking-ban"></i><span>Non-smoking Rooms</span></li>
                                                                <li><i class="fal fa-utensils"></i><span> Restaurant</span></li>
                                                            </ul>
                                                            <a href="rooms/room3.html" class="btn color-bg ajax-link">Details<i class="fas fa-caret-right"></i></a>
                                                        </div>
                                                    </div>
                                                </div>
                                                <!--  rooms-item end -->                                                      
                                            </div>
                                            <!--   rooms-container end -->
                                        </div>
                                        <!-- list-single-main-item end -->
                                        <!-- list-single-main-item -->   
                                        <div class="list-single-main-item fl-wrap" id="sec5">
                                            <div class="list-single-main-item-title fl-wrap">
                                                <h3>Item Reviews -  <span> 2 </span></h3>
                                            </div>
                                            <div class="reviews-comments-wrap">
                                                <!-- reviews-comments-item -->  
                                                <div class="reviews-comments-item">
                                                    <div class="review-comments-avatar">
                                                        <img src="images/avatar/1.jpg" alt=""> 
                                                    </div>
                                                    <div class="reviews-comments-item-text">
                                                        <h4><a href="#">Liza Rose</a></h4>
                                                        <div class="review-score-user">
                                                            <span>4.4</span>
                                                            <strong>Good</strong>
                                                        </div>
                                                        <div class="clearfix"></div>
                                                        <p>" Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium. "</p>
                                                        <div class="reviews-comments-item-date"><span><i class="far fa-calendar-check"></i>12 April 2018</span><a href="#"><i class="fal fa-reply"></i> Reply</a></div>
                                                    </div>
                                                </div>
                                                <!--reviews-comments-item end--> 
                                                <!-- reviews-comments-item -->  
                                                <div class="reviews-comments-item">
                                                    <div class="review-comments-avatar">
                                                        <img src="images/avatar/1.jpg" alt=""> 
                                                    </div>
                                                    <div class="reviews-comments-item-text">
                                                        <h4><a href="#">Adam Koncy</a></h4>
                                                        <div class="review-score-user">
                                                            <span>4.7</span>
                                                            <strong>Very Good</strong>
                                                        </div>
                                                        <div class="clearfix"></div>
                                                        <p>" Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc posuere convallis purus non cursus. Cras metus neque, gravida sodales massa ut. "</p>
                                                        <div class="reviews-comments-item-date"><span><i class="far fa-calendar-check"></i>03 December 2017</span><a href="#"><i class="fal fa-reply"></i> Reply</a></div>
                                                    </div>
                                                </div>
                                                <!--reviews-comments-item end-->                                                                  
                                            </div>
                                        </div>
                                        <!-- list-single-main-item end -->   
                                        <!-- list-single-main-item -->   
                                        <div class="list-single-main-item fl-wrap" id="sec6">
                                            <div class="list-single-main-item-title fl-wrap">
                                                <h3>Add Review</h3>
                                            </div>
                                            <!-- Add Review Box -->
                                            <div id="add-review" class="add-review-box">
                                                <!-- Review Comment -->
                                                <form id="add-comment" class="add-comment  custom-form" name="rangeCalc" >
                                                    <fieldset>
                                                        <div class="review-score-form fl-wrap">
                                                            <div class="review-range-container">
                                                                <!-- review-range-item-->
                                                                <div class="review-range-item">
                                                                    <div class="range-slider-title">Cleanliness</div>
                                                                    <div class="range-slider-wrap ">
                                                                        <input type="text" class="rate-range" data-min="0" data-max="5"  name="rgcl"  data-step="1" value="4">
                                                                    </div>
                                                                </div>
                                                                <!-- review-range-item end --> 
                                                                <!-- review-range-item-->
                                                                <div class="review-range-item">
                                                                    <div class="range-slider-title">Comfort</div>
                                                                    <div class="range-slider-wrap ">
                                                                        <input type="text" class="rate-range" data-min="0" data-max="5"  name="rgcl"  data-step="1"  value="1">
                                                                    </div>
                                                                </div>
                                                                <!-- review-range-item end --> 
                                                                <!-- review-range-item-->
                                                                <div class="review-range-item">
                                                                    <div class="range-slider-title">Staf</div>
                                                                    <div class="range-slider-wrap ">
                                                                        <input type="text" class="rate-range" data-min="0" data-max="5"  name="rgcl"  data-step="1" value="5" >
                                                                    </div>
                                                                </div>
                                                                <!-- review-range-item end --> 
                                                                <!-- review-range-item-->
                                                                <div class="review-range-item">
                                                                    <div class="range-slider-title">Facilities</div>
                                                                    <div class="range-slider-wrap">
                                                                        <input type="text" class="rate-range" data-min="0" data-max="5"  name="rgcl"  data-step="1" value="3">
                                                                    </div>
                                                                </div>
                                                                <!-- review-range-item end -->                                     
                                                            </div>
                                                            <div class="review-total">
                                                                <span><input type="text" name="rg_total" value="" data-form="AVG({rgcl})" value="0"></span>    
                                                                <strong>Your Score</strong>
                                                            </div>
                                                        </div>
                                                        <div class="row">
                                                            <div class="col-md-6">
                                                                <label><i class="fal fa-user"></i></label>
                                                                <input type="text" placeholder="Your Name *" value=""/>
                                                            </div>
                                                            <div class="col-md-6">
                                                                <label><i class="fal fa-envelope"></i>  </label>
                                                                <input type="text" placeholder="Email Address*" value=""/>
                                                            </div>
                                                        </div>
                                                        <textarea cols="40" rows="3" placeholder="Your Review:"></textarea>
                                                    </fieldset>
                                                    <button class="btn  big-btn flat-btn float-btn color2-bg" style="margin-top:30px">Submit Review <i class="fal fa-paper-plane"></i></button>
                                                </form>
                                            </div>
                                            <!-- Add Review Box / End -->
                                        </div>
                                        <!-- list-single-main-item end -->                                    
                                    </div>
                                </div>
                                <!--   datails end  -->
                                <!--   sidebar  -->
                                <div class="col-md-4">
                                    <!--box-widget-wrap -->  
                                    <div class="box-widget-wrap">
                                        <!--box-widget-item -->
                                        <div class="box-widget-item fl-wrap">
                                            <div class="box-widget">
                                                <div class="box-widget-content">
                                                    <div class="box-widget-item-header">
                                                        <h3> Book This Hotel</h3>
                                                    </div>
                                                    <form name="bookFormCalc"   class="book-form custom-form">
                                                        <fieldset>
                                                            <div class="cal-item">
                                                                <div class="listsearch-input-item">
                                                                    <label>Room Type</label>
                                                                    <select data-placeholder="Room Type" name="repopt"   class="chosen-select no-search-select" >
                                                                        <option value="0" selected>Select Room</option>
                                                                        <option value="81">Standard Family Room - 81$</option>
                                                                        <option value="122">Superior Double Room - 122$</option>
                                                                        <option value="310">Deluxe Single Room - 310$</option>
                                                                    </select>
                                                                    <!--data-formula -->
                                                                    <input type="text" name="item_total" class="hid-input"  value=""  data-form="{repopt}">
                                                                </div>
                                                            </div>
                                                            <div class="cal-item">
                                                                <div class="bookdate-container  fl-wrap">
                                                                    <label><i class="fal fa-calendar-check"></i> When </label>
                                                                    <input type="text"    placeholder="Date In-Out" name="bookdates"   value=""/>
                                                                    <div class="bookdate-container-dayscounter"><i class="far fa-question-circle"></i><span>Days : <strong>0</strong></span></div>
                                                                </div>
                                                            </div>
                                                            <div class="cal-item">
                                                                <div class="quantity-item fl-wrap">
                                                                    <label> Adults</label>
                                                                    <div class="quantity">
                                                                        <input type="number"  disabled v-model="roomAvailRS.roomRateDetailsList[0].rateInfos.roomGroup[0].numberOfAdults">
                                                                        <input type="text" name="item_total" class="hid-input" value="0" data-form="{qty3} * {repopt} - {repopt}">
                                                                    </div>
                                                                </div>
                                                                <div class="quantity-item fl-wrap fcit">
                                                                    <label> Children</label>
                                                                    <div class="quantity">
                                                                        <input type="number"  disabled v-model="roomAvailRS.roomRateDetailsList[0].rateInfos.roomGroup[0].numberOfChildren">
                                                                        <select name="sale" class="hid-input">
                                                                            <option value=".7"  selected>sale</option>
                                                                        </select>
                                                                        <input type="text" name="item_total" class="hid-input" value="0" data-form="({repopt} * {sale})*{qty2}">
                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </fieldset>
                                                        <input type="number"  id="totaldays" name="qty5" class="hid-input">
                                                        <div class="total-coast fl-wrap"><strong>Total Cost</strong> <span>$ <input type="text" name="grand_total" value="" data-form="SUM({item_total}) * {qty5}"></span></div>
                                                        <button class="btnaplly color2-bg">Book Now<i class="fal fa-paper-plane"></i></button>
                                                    </form>
                                                </div>
                                            </div>
                                        </div>
                                        <!--box-widget-item end -->                                       
                                        <!--box-widget-item -->
                                        <div class="box-widget-item fl-wrap">
                                            <div class="box-widget counter-widget" data-countDate="09/12/2019">
                                                <div class="banner-wdget fl-wrap">
                                                    <div class="overlay"></div>
                                                    <div class="bg"  data-bg="images/bg/1.jpg"></div>
                                                    <div class="banner-wdget-content fl-wrap">
                                                        <h4>Get a discount <span>20%</span> when ordering a room from three days.</h4>
                                                        <div class="countdown fl-wrap">
                                                            <div class="countdown-item">
                                                                <span class="days rot">00</span>
                                                                <p>days</p>
                                                            </div>
                                                            <div class="countdown-item">
                                                                <span class="hours rot">00</span>
                                                                <p>hours </p>
                                                            </div>
                                                            <div class="countdown-item">
                                                                <span class="minutes rot">00</span>
                                                                <p>minutes </p>
                                                            </div>
                                                            <div class="countdown-item">
                                                                <span class="seconds rot">00</span>
                                                                <p>seconds</p>
                                                            </div>
                                                        </div>
                                                        <a href="#">Book Now</a>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <!--box-widget-item end -->                                       
                                        <!--box-widget-item -->
                                        <div class="box-widget-item fl-wrap">
                                            <div class="box-widget">
                                                <div class="box-widget-content">
                                                    <div class="box-widget-item-header">
                                                        <h3> Contact Information</h3>
                                                    </div>
                                                    <div class="box-widget-list">
                                                        <ul>
                                                            <li><span><i class="fal fa-map-marker"></i> Adress :</span> <a href="#">USA 27TH Brooklyn NY</a></li>
                                                            <li><span><i class="fal fa-phone"></i> Phone :</span> <a href="#">+7(123)987654</a></li>
                                                            <li><span><i class="fal fa-envelope"></i> Mail :</span> <a href="#">AlisaNoory@domain.com</a></li>
                                                            <li><span><i class="fal fa-browser"></i> Website :</span> <a href="#">themeforest.net</a></li>
                                                        </ul>
                                                    </div>
                                                    <div class="list-widget-social">
                                                        <ul>
                                                            <li><a href="#" target="_blank" ><i class="fab fa-facebook-f"></i></a></li>
                                                            <li><a href="#" target="_blank"><i class="fab fa-twitter"></i></a></li>
                                                            <li><a href="#" target="_blank" ><i class="fab fa-vk"></i></a></li>
                                                            <li><a href="#" target="_blank" ><i class="fab fa-instagram"></i></a></li>
                                                        </ul>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <!--box-widget-item end -->                          
                                        <!--box-widget-item -->
                                        <div class="box-widget-item fl-wrap">
                                            <div class="box-widget">
                                                <div class="box-widget-content">
                                                    <div class="box-widget-item-header">
                                                        <h3> Price Range </h3>
                                                    </div>
                                                    <div class="claim-price-wdget fl-wrap">
                                                        <div class="claim-price-wdget-content fl-wrap">
                                                            <div class="pricerange fl-wrap"><span>Price : </span> 81$ - 320$ </div>
                                                            <div class="claim-widget-link fl-wrap"><span>Own or work here?</span><a href="#">Claim Now!</a></div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <!--box-widget-item end -->                             
                                        <!--box-widget-item -->
                                        <div class="box-widget-item fl-wrap">
                                            <div id="weather-widget" class="gradient-bg" data-city="New York" data-country="USA"></div>
                                        </div>
                                        <!--box-widget-item end -->   
                                        <!--box-widget-item end -->   
                                        <!--box-widget-item -->
                                        <div class="box-widget-item fl-wrap">
                                            <div class="box-widget widget-posts">
                                                <div class="box-widget-content">
                                                    <div class="box-widget-item-header">
                                                        <h3>Recommended Attractions</h3>
                                                    </div>
                                                    <!--box-image-widget-->
                                                    <div class="box-image-widget">
                                                        <div class="box-image-widget-media"><img src="images/all/1.jpg" alt="">
                                                            <a href="#" class="color2-bg" target="_blank">Details</a>
                                                        </div>
                                                        <div class="box-image-widget-details">
                                                            <h4>Times Square <span>2.3 km</span></h4>
                                                            <p>It’s impossible to miss the colossal billboards, glitzy lights and massive crowds that make this intersection the city’s beating heart.</p>
                                                        </div>
                                                    </div>
                                                    <!--box-image-widget end -->
                                                    <!--box-image-widget-->
                                                    <div class="box-image-widget">
                                                        <div class="box-image-widget-media"><img src="images/all/1.jpg" alt="">
                                                            <a href="#" class="color2-bg" target="_blank">Details</a>
                                                        </div>
                                                        <div class="box-image-widget-details">
                                                            <h4>Broadway<span>1.7 km</span></h4>
                                                            <p>Tap your feet to catchy ditties, hold back tears or bust your gut laughing at a world renowned Broadway performance.</p>
                                                        </div>
                                                    </div>
                                                    <!--box-image-widget end -->                                                   	
                                                    <!--box-image-widget-->
                                                    <div class="box-image-widget">
                                                        <div class="box-image-widget-media"><img src="images/all/1.jpg" alt="">
                                                            <a href="#" class="color2-bg" target="_blank">Details</a>
                                                        </div>
                                                        <div class="box-image-widget-details">
                                                            <h4>Grand Central Station<span>0.7 km</span></h4>
                                                            <p>With its elegantly designed main concourse, this rail station is much more than just a massive transport hub.</p>
                                                        </div>
                                                    </div>
                                                    <!--box-image-widget end -->                                                         
                                                </div>
                                            </div>
                                        </div>
                                        <!--box-widget-item end -->                           
                                        <!--box-widget-item -->
                                        <div class="box-widget-item fl-wrap">
                                            <div class="box-widget">
                                                <div class="box-widget-content">
                                                    <div class="box-widget-item-header">
                                                        <h3>Hosted By</h3>
                                                    </div>
                                                    <div class="box-widget-author fl-wrap">
                                                        <div class="box-widget-author-title fl-wrap">
                                                            <div class="box-widget-author-title-img">
                                                                <img src="images/avatar/1.jpg" alt=""> 
                                                            </div>
                                                            <a href="user-single.html">Jessie Manrty</a>
                                                            <span>4 Places Hosted</span>
                                                        </div>
                                                        <a href="author-single.html" class="btn flat-btn color-bg   float-btn image-popup">View Profile<i class="fal fa-user-alt"></i></a>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <!--box-widget-item end -->                              
                                        <!--box-widget-item -->
                                        <div class="box-widget-item fl-wrap">
                                            <div class="box-widget">
                                                <div class="box-widget-content">
                                                    <div class="box-widget-item-header">
                                                        <h3>Similar Listings</h3>
                                                    </div>
                                                    <div class="widget-posts fl-wrap">
                                                        <ul>
                                                            <li class="clearfix">
                                                                <a href="#"  class="widget-posts-img"><img src="images/gal/1.jpg" class="respimg" alt=""></a>
                                                                <div class="widget-posts-descr">
                                                                    <a href="#" title="">Park Central</a>
                                                                    <div class="listing-rating card-popup-rainingvis" data-starrating2="5"></div>
                                                                    <div class="geodir-category-location fl-wrap"><a href="#"><i class="fas fa-map-marker-alt"></i> 40 JOURNAL SQUARE PLAZA, NJ, US</a></div>
                                                                    <span class="rooms-price">$80 <strong> /  Awg</strong></span>
                                                                </div>
                                                            </li>
                                                            <li class="clearfix">
                                                                <a href="#"  class="widget-posts-img"><img src="images/gal/1.jpg" class="respimg" alt=""></a>
                                                                <div class="widget-posts-descr">
                                                                    <a href="#" title="">Holiday Home</a>
                                                                    <div class="listing-rating card-popup-rainingvis" data-starrating2="3"></div>
                                                                    <div class="geodir-category-location fl-wrap"><a href="#"><i class="fas fa-map-marker-alt"></i> 75 PRINCE ST, NY, USA</a></div>
                                                                    <span class="rooms-price">$50 <strong> /   Awg</strong></span>
                                                                </div>
                                                            </li>
                                                            <li class="clearfix">
                                                                <a href="#"  class="widget-posts-img"><img src="images/gal/1.jpg" class="respimg" alt=""></a>
                                                                <div class="widget-posts-descr">
                                                                    <a href="#" title="">Moonlight Hotel</a>
                                                                    <div class="listing-rating card-popup-rainingvis" data-starrating2="4"></div>
                                                                    <div class="geodir-category-location fl-wrap"><a href="#"><i class="fas fa-map-marker-alt"></i>  70 BRIGHT ST NEW YORK, USA</a></div>
                                                                    <span class="rooms-price">$105 <strong> /  Awg</strong></span>
                                                                </div>
                                                            </li>
                                                        </ul>
                                                        <a class="widget-posts-link" href="#">See All Listing <i class="fal fa-long-arrow-right"></i> </a>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <!--box-widget-item end -->                              
                                    </div>
                                    <!--box-widget-wrap end -->  
                                </div>
                                <!--   sidebar end  -->
                            </div>
                            <!--   row end  -->
                        </div>
                        <!--   container  end  -->
                    </section>
                    <!--  section  end-->
                </div>
                <!-- content end--> 
  </template>



<script>
export default {
  data() {
    return {
      roomAvailRS: {
        hotelId: "632882",
        name: "Grand Plaza Hanoi Hotel",
        address1: "117 Tran Duy Hung Street, Cau Giay Dist",
        address2: "",
        city: "Hanoi",
        cityCode: "",
        sessionId: "AC110004-758C-6891-6732-FF7161990E23",
        stateProvinceCode: "",
        countryCode: "VN",
        checkInInstructions:
          "<p><b>Know Before You Go</b> <br /><ul>  <li>No pets and no service animals are allowed at this property. </li> </ul></p><p><b>Fees</b> <br /><p>The following fees and deposits are charged by the property at time of service, check-in, or check-out. </p> <ul> <li>Fee for buffet breakfast: VND 550000 for adults and VND 410000 for children (approximately)</li>      <li>Airport shuttle fee: VND 1432000 per vehicle (one way)</li>                         </ul> <p>The above list may not be comprehensive. Fees and deposits may not include tax and are subject to change. </p></p>",
        specialCheckInInstructions:
          "24-hour airport shuttle service is available on request. Contact the property in advance to get details.",
        roomRateDetailsList: [
          {
            token:
              "oUYge2twIY7d5le%2bcAYflIEuO7PRBl%2f91p%2fOIrgwYFg3055rMl%2bEWP8e9xMxalI9",
            roomTypeCode: ["200122977", "200122977"],
            rateCode: ["200665441", "200665441"],
            roomDescription: [
              "Executive Suite, 1 King Bed",
              "Executive Suite, 1 King Bed"
            ],
            rateInfos: {
              priceBreakdown: "true",
              promo: "false",
              rateChange: "false",
              roomGroup: [
                {
                  numberOfAdults: "1",
                  numberOfChildren: "0",
                  rateKey: "d5635003-2a61-47df-823a-5313b1c4d72c-5001-024"
                },
                {
                  numberOfAdults: "3",
                  numberOfChildren: "1",
                  rateKey: "873ebd7e-ffbe-4fa2-adb4-eaba7e2c2b50-5001-024"
                }
              ],
              chargeableRateInfo: {
                currencyCode: "VND",
                total: "18147875.000",
                commission: "1270351.250"
              },
              nonRefundable: "false",
              promoDescription: "",
              currentAllotment: "2",
              cancellationList: null
            },
            valueAdds: [
              {
                id: null,
                description: "Free Wireless Internet"
              },
              {
                id: null,
                description: "Breakfast Buffet"
              }
            ]
          },
          {
            token:
              "HfgT5htac4tfJKk8gfu9oexumnjjOQYtW8N5pimx7pd2KmzWSldebp%2bwt3s0Aye4",
            roomTypeCode: ["200060354", "200060354"],
            rateCode: ["200344568", "200344568"],
            roomDescription: [
              "Suite, 1 King Bed (Parlor)",
              "Suite, 1 King Bed (Parlor)"
            ],
            rateInfos: {
              priceBreakdown: "true",
              promo: "false",
              rateChange: "false",
              roomGroup: [
                {
                  numberOfAdults: "1",
                  numberOfChildren: "0",
                  rateKey: "6b2c1196-3604-4b63-afce-317433fd494c-5001-024"
                },
                {
                  numberOfAdults: "3",
                  numberOfChildren: "1",
                  rateKey: "e3b0da2c-697a-4dff-b6e7-caa03800404a-5001-024"
                }
              ],
              chargeableRateInfo: {
                currencyCode: "VND",
                total: "12606575.000",
                commission: "882460.250"
              },
              nonRefundable: "false",
              promoDescription: "",
              currentAllotment: "5",
              cancellationList: null
            },
            valueAdds: [
              {
                id: null,
                description: "Free Wireless Internet"
              },
              {
                id: null,
                description: "Breakfast Buffet"
              }
            ]
          },
          {
            token:
              "%2f2IQaQ8DUREhd5CjBNmkJMoHxJ6hA7CEWLVDaYGBT2fm2YmtrfT5j4B3qNGryXt%2f",
            roomTypeCode: ["200060353", "200060353"],
            rateCode: ["200344566", "200344566"],
            roomDescription: ["Deluxe Room", "Deluxe Room"],
            rateInfos: {
              priceBreakdown: "true",
              promo: "false",
              rateChange: "false",
              roomGroup: [
                {
                  numberOfAdults: "1",
                  numberOfChildren: "0",
                  rateKey: "0dab4ff8-1a38-434f-a8ac-cfef4db6c376-5001-024"
                },
                {
                  numberOfAdults: "3",
                  numberOfChildren: "1",
                  rateKey: "84086fac-28d9-4adc-8f3b-bda65dbb7b16-5001-024"
                }
              ],
              chargeableRateInfo: {
                currencyCode: "VND",
                total: "8173535.000",
                commission: "572147.450"
              },
              nonRefundable: "false",
              promoDescription: "",
              currentAllotment: "8",
              cancellationList: null
            },
            valueAdds: [
              {
                id: null,
                description: "Free Wireless Internet"
              },
              {
                id: null,
                description: "Breakfast Buffet"
              }
            ]
          },
          {
            token:
              "eYoHMz9VoSNmW2JPEgVAv2EifJSWcu7tFT%2foDs%2fLYgc2FXc%2b%2f%2fJF5o%2fzo3b29S11",
            roomTypeCode: ["200060353", "200060353"],
            rateCode: ["200665036", "200665036"],
            roomDescription: ["Deluxe Room", "Deluxe Room"],
            rateInfos: {
              priceBreakdown: "true",
              promo: "false",
              rateChange: "false",
              roomGroup: [
                {
                  numberOfAdults: "1",
                  numberOfChildren: "0",
                  rateKey: "a10b416a-92a9-4fab-90cb-4440c8050e63-5001-024"
                },
                {
                  numberOfAdults: "3",
                  numberOfChildren: "1",
                  rateKey: "3c7e90ee-d889-4730-be2e-cb2c966d1bb7-5001-024"
                }
              ],
              chargeableRateInfo: {
                currencyCode: "VND",
                total: "7065275.000",
                commission: "494569.250"
              },
              nonRefundable: "false",
              promoDescription: "",
              currentAllotment: "8",
              cancellationList: null
            },
            valueAdds: [
              {
                id: null,
                description: "Free Wireless Internet"
              }
            ]
          }
        ]
      },
      valueAdds : []
    };
  },
  created : function(){
      console.log(this.roomAvailRS)
      this.valueAdds = [];
        for (let i = 0; i < this.roomAvailRS.roomRateDetailsList.length; i++) {
            const rr = this.roomAvailRS.roomRateDetailsList[i];
            for (let j = 0; j < rr.valueAdds.length; j++) {
                const element = rr.valueAdds[j].description;
                if( this.valueAdds.indexOf(element)==-1){
                     this.valueAdds.push(element);
                }
            }
        }
        console.log(this.valueAdds);
    //   roomRateDetailsList[1].valueAdds[""0""].description
  }
};
</script>
