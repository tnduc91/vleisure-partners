<template>
  <div>
    <Search></Search>
    <!--  section-->
    <section class="grey-blue-bg small-padding" id="sec1">
      <div class="container">

        <div class="row">
          <!--filter sidebar -->
          <div class="col-md-8">
            <listHotel  ></listHotel>
          </div>
          <div class="col-md-4">
            <filterHotel    ></filterHotel>
          </div>
        </div>
      </div>
    </section>
  </div>
</template>

<script>
  import Search from './search.vue'
  import listHotel from './listHotel.vue';
  import filterHotel from './filterHotel.vue'
  export default {
    name: 'home',
    components: {
      Search,
      listHotel,
      filterHotel

    },
     
    methods: {
      
  }
  }
</script>