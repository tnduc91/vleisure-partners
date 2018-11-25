<template>
  <!--filter sidebar -->
  <div>
    <div class="mobile-list-controls fl-wrap">
      <div class="mlc show-list-wrap-search fl-wrap"><i class="fal fa-filter"></i> Filter</div>
    </div>
    <div class="fl-wrap filter-sidebar_item fixed-bar">
      <div class="filter-sidebar fl-wrap lws_mobile">
        <!--col-list-search-input-item -->
        <div class="col-list-search-input-item in-loc-dec fl-wrap not-vis-arrow">
          <label>City/Category</label>
          <div class="listsearch-input-item">
            <select data-placeholder="City" class="chosen-select">
              <option>All Cities</option>
              <option>New York</option>
              <option>London</option>
              <option>Paris</option>
              <option>Kiev</option>
              <option>Moscow</option>
              <option>Dubai</option>
              <option>Rome</option>
              <option>Beijing</option>
            </select>
          </div>
        </div>
        <!--col-list-search-input-item end-->
        <!--col-list-search-input-item -->
        <div class="col-list-search-input-item fl-wrap location autocomplete-container">
          <label>Destination</label>
          <span class="header-search-input-item-icon"><i class="fal fa-map-marker-alt"></i></span>
          <input type="text" placeholder="Destination or Hotel Name" class="autocomplete-input" id="autocompleteid3"
                 value="" />
          <a href="#"><i class="fal fa-dot-circle"></i></a>
        </div>
        <!--col-list-search-input-item end-->
        <!--col-list-search-input-item -->
        <div class="col-list-search-input-item in-loc-dec date-container  fl-wrap">
          <label>Date In-Out </label>
          <span class="header-search-input-item-icon"><i class="fal fa-calendar-check"></i></span>
          <input type="text" placeholder="When" name="dates" value="" />
        </div>
        <!--col-list-search-input-item end-->
        <!--col-list-search-input-item -->
        <div class="col-list-search-input-item fl-wrap">
          <div class="quantity-item">
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
          </div>
        </div>
        <!--col-list-search-input-item end-->
        <!--col-list-search-input-item -->
        <div class="col-list-search-input-item fl-wrap">
          <div class="range-slider-title">Price range</div>
          <div class="range-slider-wrap fl-wrap">
            <input class="range-slider" data-from="300" data-to="1200" data-step="50" data-min="50" data-max="2000"
                   data-prefix="$">
          </div>
        </div>
        <!--col-list-search-input-item end-->
        <!--col-list-search-input-item -->
        <div class="col-list-search-input-item fl-wrap">
          <label>Star Rating</label>
          <div class="search-opt-container fl-wrap">
            <!-- Checkboxes -->
            <ul class="fl-wrap filter-tags">
              <li class="five-star-rating">
                <input id="check-aa2" type="checkbox" name="check" checked>
                <label for="check-aa2">
                  <span class="listing-rating card-popup-rainingvis" data-starrating2="5">
                    <span>
                      5
                      Stars
                    </span>
                  </span>
                </label>
              </li>
              <li class="four-star-rating">
                <input id="check-aa3" type="checkbox" name="check">
                <label for="check-aa3">
                  <span class="listing-rating card-popup-rainingvis" data-starrating2="5">
                    <span>
                      4
                      Star
                    </span>
                  </span>
                </label>
              </li>
              <li class="three-star-rating">
                <input id="check-aa4" type="checkbox" name="check">
                <label for="check-aa4">
                  <span class="listing-rating card-popup-rainingvis" data-starrating2="5">
                    <span>
                      3
                      Star
                    </span>
                  </span>
                </label>
              </li>
            </ul>
            <!-- Checkboxes end -->
          </div>
        </div>
        <!--col-list-search-input-item end-->
        <!--col-list-search-input-item -->
        <div class="col-list-search-input-item fl-wrap">
          <label>Facility</label>
          <div class="search-opt-container fl-wrap">
            <!-- Checkboxes -->
            <ul class="fl-wrap filter-tags half-tags">
              <li>
                <input id="check-aaa5" type="checkbox" name="check" checked>
                <label for="check-aaa5">Free WiFi</label>
              </li>
              <li>
                <input id="check-bb5" type="checkbox" name="check">
                <label for="check-bb5">Parking</label>
              </li>
              <li>
                <input id="check-dd5" type="checkbox" name="check">
                <label for="check-dd5">Fitness Center</label>
              </li>
            </ul>
            <!-- Checkboxes end -->
            <!-- Checkboxes -->
            <ul class="fl-wrap filter-tags half-tags">
              <li>
                <input id="check-ff5" type="checkbox" name="check">
                <label for="check-ff5">Airport Shuttle</label>
              </li>
              <li>
                <input id="check-cc5" type="checkbox" name="check" checked>
                <label for="check-cc5">Non-smoking Rooms</label>
              </li>
              <li>
                <input id="check-c4" type="checkbox" name="check" checked>
                <label for="check-c4">Air Conditioning</label>
              </li>
            </ul>
            <!-- Checkboxes end -->
          </div>
        </div>
        <!--col-list-search-input-item end-->
        <!--col-list-search-input-item  -->
        <div class="col-list-search-input-item fl-wrap">
          <button class="header-search-button" onclick="window.location.href='listing.html'">Search <i class="far fa-search"></i></button>
        </div>
        <!--col-list-search-input-item end-->
      </div>
    </div>
     
  </div>

  <!--filter sidebar end-->
</template>



<script lang="ts">
    import { Component, Prop, Vue, Watch } from "vue-property-decorator";

    @Component
    export default class FilterHotel extends Vue {
        constructor() {
            super();
        }
    
        let countries = ['Afghanistan', 'Åland Islands', 'Albania', 'Algeria', 'American Samoa', 'AndorrA', 'Angola', 'Anguilla', 'Antarctica', 'Antigua and Barbuda', 'Argentina', 'Armenia', 'Aruba', 'Australia', 'Austria', 'Azerbaijan', 'Bahamas', 'Bahrain', 'Bangladesh', 'Barbados', 'Belarus', 'Belgium', 'Belize', 'Benin', 'Bermuda', 'Bhutan', 'Bolivia', 'Bosnia and Herzegovina', 'Botswana', 'Bouvet Island', 'Brazil', 'British Indian Ocean Territory', 'Brunei Darussalam', 'Bulgaria', 'Burkina Faso', 'Burundi', 'Cambodia', 'Cameroon', 'Canada', 'Cape Verde', 'Cayman Islands', 'Central African Republic', 'Chad', 'Chile', 'China', 'Christmas Island', 'Cocos (Keeling) Islands', 'Colombia', 'Comoros', 'Congo', 'Congo, The Democratic Republic of the', 'Cook Islands', 'Costa Rica', 'Cote D\'Ivoire', 'Croatia', 'Cuba', 'Cyprus', 'Czech Republic', 'Denmark', 'Djibouti', 'Dominica', 'Dominican Republic', 'Ecuador', 'Egypt', 'El Salvador', 'Equatorial Guinea', 'Eritrea', 'Estonia', 'Ethiopia', 'Falkland Islands (Malvinas)', 'Faroe Islands', 'Fiji', 'Finland', 'France', 'French Guiana', 'French Polynesia', 'French Southern Territories', 'Gabon', 'Gambia', 'Georgia', 'Germany', 'Ghana', 'Gibraltar', 'Greece', 'Greenland', 'Grenada', 'Guadeloupe', 'Guam', 'Guatemala', 'Guernsey', 'Guinea', 'Guinea-Bissau', 'Guyana', 'Haiti', 'Heard Island and Mcdonald Islands', 'Holy See (Vatican City State)', 'Honduras', 'Hong Kong', 'Hungary', 'Iceland', 'India']
      
          query: '',
          countries: countries;
          selectedCountry: null;
          options: {};
        
  
        onCountryInputChange (query) {
          if (query.trim().length === 0) {
            return null
          }
          // return the matching countries as an array
          return this.countries.filter((country) => {
            return country.toLowerCase().includes(query.toLowerCase())
          })
        },
        onCountrySelected (item) {
          this.selectedCountry = item
        },
        onSearchItemSelected (item) {
          this.selectedSearchItem = item
        }
     
    }
</script>