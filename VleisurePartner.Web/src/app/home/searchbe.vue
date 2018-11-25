<template>
  <!--section -->
  <section class="hero-section" data-scrollax-parent="true" id="sec1">
    <div class="hero-parallax">
      <div class="slideshow-container" data-scrollax="properties: { translateY: '200px' }">
        <!-- slideshow-item -->
        <div class="slideshow-item">
          <div class="bg" data-bg="assets/images/bg/1.jpg"></div>
        </div>
        <!--  slideshow-item end  -->
        <!-- slideshow-item -->
        <div class="slideshow-item">
          <div class="bg" data-bg="assets/images/bg/1.jpg"></div>
        </div>
        <!--  slideshow-item end  -->
        <!-- slideshow-item -->
        <div class="slideshow-item">
          <div class="bg" data-bg="assets/images/bg/1.jpg"></div>
        </div>
        <!--  slideshow-item end  -->
      </div>
      <div class="overlay op7"></div>
    </div>
    <div class="hero-section-wrap fl-wrap">
      <div class="container">
        <div class="home-intro">
          <div class="section-title-separator"><span></span></div>
          <h2>EasyBook Hotel Booking System</h2>
          <span class="section-separator"></span>
          <h3>Let's start exploring the world together with EasyBook</h3>
        </div>
        <div class="main-search-input-wrap">
          <div class="main-search-input fl-wrap">
            <div class="main-search-input-item location" id="autocomplete-container">
              <span class="inpt_dec"><i class="fal fa-map-marker"></i></span>
              <input type="text" placeholder="Where are you going?" class="autocomplete-input" id="autocompleteid2"
                     value="" />
              <a href="#"><i class="fal fa-dot-circle"></i></a>
            </div>
            <div class="main-search-input-item main-date-parent main-search-input-item_small">
              <span class="inpt_dec"><i class="fal fa-calendar-check"></i></span> <input type="text" placeholder="When"
                                                                                         name="main-input-search" value="" />
            </div>


            <div class="main-search-input-item input-chosen-select">
              <select data-placeholder="Room" class="input chosen-select no-search-select  main-search-input-item_small qty-dropdown-header fl-wrap main-search-number-room">
                <option data-display="Room">None</option>
                <option>1</option>
                <option>2</option>
                <option>3</option>
                <option>4</option>
                <option>5</option>
              </select>
            </div>

            <button class="main-search-button color2-bg" onclick="window.location.href='listing'">Search <i class="fal fa-search"></i></button>
          </div>
          <div>
            <div>
              <div class="main-search-input-item item-select-label">
                <div class="qty-dropdown-header fl-wrap room-input-search">
                  <i class="fal fa-users"></i>
                  Room 1
                </div>
              </div>
              <div class="main-search-input-item  item-select">
                <select data-placeholder="Popularity" class="input chosen-select no-search-select  main-search-input-item_small qty-dropdown-header fl-wrap main-search-number-room">
                  <option data-display="Adults">None</option>
                  <option>1</option>
                  <option>2</option>
                  <option>3</option>
                </select>
              </div>
              <div class="main-search-input-item item-select">
                <select data-placeholder="Popularity" class="input chosen-select no-search-select  main-search-input-item_small qty-dropdown-header fl-wrap main-search-number-room">
                  <option data-display="Childrens">None</option>
                  <option>Average rating</option>
                  <option>Price: low to high</option>
                  <option>Price: high to low</option>
                </select>
              </div>
              <div class="main-search-input-item item-select">
                <select data-placeholder="Popularity" class="input chosen-select no-search-select  main-search-input-item_small qty-dropdown-header fl-wrap main-search-number-room">
                  <option>Under 1</option>
                  <option>1</option>
                  <option>2</option>
                  <option>3</option>
                  <option>4</option>
                  <option>5</option>
                  <option>6</option>
                  <option>7</option>
                  <option>8</option>
                  <option>9</option>
                  <option>10</option>
                  <option>11</option>
                </select>
              </div>
              <div class="main-search-input-item item-select">
                <select data-placeholder="Popularity" class="input chosen-select no-search-select  main-search-input-item_small qty-dropdown-header fl-wrap main-search-number-room">
                  <option>Under 1</option>
                  <option>1</option>
                  <option>2</option>
                  <option>3</option>
                  <option>4</option>
                  <option>5</option>
                  <option>6</option>
                  <option>7</option>
                  <option>8</option>
                  <option>9</option>
                  <option>10</option>
                  <option>11</option>
                </select>
              </div>
              <div class="main-search-input-item item-select">
                <select data-placeholder="Popularity" class="input chosen-select no-search-select  main-search-input-item_small qty-dropdown-header fl-wrap main-search-number-room">
                  <option>Under 1</option>
                  <option>1</option>
                  <option>2</option>
                  <option>3</option>
                  <option>4</option>
                  <option>5</option>
                  <option>6</option>
                  <option>7</option>
                  <option>8</option>
                  <option>9</option>
                  <option>10</option>
                  <option>11</option>
                </select>
              </div>
            </div>
          </div>

          <div>
            <div>
              <div class="main-search-input-item item-select-label">
                <div class="qty-dropdown-header fl-wrap room-input-search">
                  <i class="fal fa-users"></i>
                  Room 2
                </div>
              </div>
              <div class="main-search-input-item  item-select">
                <select data-placeholder="Popularity" class="input chosen-select no-search-select  main-search-input-item_small qty-dropdown-header fl-wrap main-search-number-room">
                  <option data-display="Adults">None</option>
                  <option>1</option>
                  <option>2</option>
                  <option>3</option>
                  <option>4</option>
                  <option>5</option>
                  <option>6</option>
                </select>
              </div>
              <div class="main-search-input-item item-select">
                <select data-placeholder="Popularity" class="input chosen-select no-search-select  main-search-input-item_small qty-dropdown-header fl-wrap main-search-number-room">
                  <option data-display="Childrens">None</option>
                  <option>1</option>
                  <option>2</option>
                  <option>3</option>
                </select>
              </div>
              <div class="main-search-input-item item-select">
                <select data-placeholder="Popularity" class="input chosen-select no-search-select  main-search-input-item_small qty-dropdown-header fl-wrap main-search-number-room">
                  <option>Under 1</option>
                  <option>1</option>
                  <option>2</option>
                  <option>3</option>
                  <option>4</option>
                  <option>5</option>
                  <option>6</option>
                  <option>7</option>
                  <option>8</option>
                  <option>9</option>
                  <option>10</option>
                  <option>11</option>
                </select>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
    <div class="header-sec-link">
      <div class="container"><a href="#sec1" class="custom-scroll-link color-bg"><i class="fal fa-angle-double-down"></i></a></div>
    </div>

  </section>
  <!-- section end -->
</template>


<script lang="ts">
   import { Component, Prop, Vue, Watch } from "vue-property-decorator";
    @Component 
    export default class SearchBe extends Vue {
        constructor() {
            super();
        }  
    }  

</script>   