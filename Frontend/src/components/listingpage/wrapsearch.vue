<template>
    <!--list-wrap-search   -->
          <div class="list-wrap-search lisfw fl-wrap lws_mobile">
            <div class="container">
              <div class="row">
                <!-- col-list-search-input-item -->
                <div class="col-md-4">
                  <div class="col-list-search-input-item in-loc-dec fl-wrap not-vis-arrow">
                    <label>Your Favorite Region</label>
                    <div class="listsearch-input-item">
                      <select data-placeholder="City" class="chosen-select">
                        <option>All Cities</option>
                        <option>Ho Cho Minh</option>
                        <option>Thu Dau Mot</option>
                        <option>Paris</option>
                        <option>Kiev</option>
                        <option>Moscow</option>
                        <option>Dubai</option>
                        <option>Rome</option>
                        <option>Beijing</option>
                      </select>
                    </div>
                  </div>
                </div>
                <!-- col-list-search-input-item end -->
                <!-- col-list-search-input-item -->
                <div class="col-md-5">
                  <div class="col-list-search-input-item fl-wrap location autocomplete-container">
                    <label>YOUR FAVORITE HOTEL</label>
                    <span class="header-search-input-item-icon"><i class="fal fa-map-marker-alt"></i></span>
                    <input type="text" placeholder="Destination or Hotel Name" class="autocomplete-input" id="autocompleteid3"
                      value="" />
                    <a href="#"><i class="fal fa-dot-circle"></i></a>
                  </div>
                </div>
                <!-- col-list-search-input-item end -->
                <!-- col-list-search-input-item -->
                <div class="col-md-3">
                  <div class="col-list-search-input-item in-loc-dec date-container  fl-wrap">
                    <label>Date In-Out </label>
                    <span class="header-search-input-item-icon"><i class="fal fa-calendar-check"></i></span>
                    <input type="text" placeholder="When" name="dates" value="" />
                  </div>
                </div>
                <!-- col-list-search-input-item end -->
              </div>
              <div class="search-opt-wrap fl-wrap">
                <div class="search-opt-wrap-container">
                  <!-- col-list-search-input-item -->
                  <div class="search-input-item midd-input">
                    <div class="col-list-search-input-item fl-wrap">
                        <label>Review Score</label>
                        <div class="search-opt-container fl-wrap">
                            <!-- Checkboxes -->
                            <ul class="fl-wrap filter-tags">
                              <li class="five-star-rating">
                                <input id="check-aa2" type="checkbox" name="check" checked>
                                <label for="check-aa2"><span class="listing-rating card-popup-rainingvis"
                                    data-starrating2="5"><span>5 Stars</span></span></label>
                              </li>
                              <li class="four-star-rating">
                                <input id="check-aa3" type="checkbox" name="check">
                                <label for="check-aa3"><span class="listing-rating card-popup-rainingvis"
                                    data-starrating2="5"><span>4 Star</span></span></label>
                              </li>
                              <li class="three-star-rating">
                                <input id="check-aa4" type="checkbox" name="check">
                                <label for="check-aa4"><span class="listing-rating card-popup-rainingvis"
                                    data-starrating2="5"><span>3 Star</span></span></label>
                              </li>
                            </ul>
                            <!-- Checkboxes end -->
                          </div>

                      <!-- <div class="quantity-item">
                        <label>Rooms</label>
                        <div class="quantity">
                          <input type="number" min="1" max="3" step="1" value="1">
                        </div>
                      </div>
                      <div class="quantity-item">
                        <label>Adults</label>
                        <div class="quantity">
                          <input type="number" min="1" max="5" step="1" value="1">
                        </div>
                      </div>
                      <div class="quantity-item">
                        <label>Children</label>
                        <div class="quantity">
                          <input type="number" min="0" max="3" step="1" value="0">
                        </div>
                      </div> -->
                    </div>
                  </div>
                  <!-- col-list-search-input-item end -->
                   <!-- col-list-search-input-item -->
                   <div class="search-input-item small-input">
                      <div class="col-list-search-input-item fl-wrap">
                          <label>By Promotion</label>
                          <div class="search-opt-container fl-wrap">
                              <!-- Checkboxes -->
                              <ul class="fl-wrap filter-tags">
                                <li class="five-star-rating">
                                  <input id="check-aa2" type="checkbox" name="check" checked>
                                  <label for="check-aa2"><span class="listing-rating card-popup-rainingvis"
                                      data-starrating2="5"><span>Promotion?</span></span></label>
                                </li>
                              </ul>
                              <!-- Checkboxes end -->
                            </div>
                      </div>
                    </div>
                    <!-- col-list-search-input-item end -->
                  <!-- col-list-search-input-item -->
                  <div class="search-input-item midd-input">
                    <div class="range-slider-title">Price range</div>
                    <div class="range-slider-wrap fl-wrap">
                      <input class="range-slider" data-from="300" data-to="1200" data-step="50" data-min="50" data-max="2000"
                        data-prefix="$">
                    </div>
                  </div>
                  <!-- col-list-search-input-item end -->
                  <!-- col-list-search-input-item -->
                  <div class="search-input-item small-input ">
                    <div class="col-list-search-input-item fl-wrap">
                      <button class="header-search-button" onclick="window.location.href='listing.html'">Search <i
                          class="far fa-search"></i></button>
                    </div>
                  </div>
                  <!-- col-list-search-input-item end -->
                </div>
                
              </div>
            </div>
          </div>
          <!--list-wrap-search end -->
</template>
