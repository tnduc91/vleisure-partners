import Vue from 'vue'
import VueRouter from 'vue-router'
import App from './App.vue'
import HomePage  from './components/homepage/homepage.vue'
import ListHotel from './components/listingpage/listhotel.vue'
Vue.use(VueRouter)

// The matching uses path-to-regexp, which is the matching engine used
// by express as well, so the same matching rules apply.
// For detailed rules, see https://github.com/pillarjs/path-to-regexp
const router = new VueRouter({
  mode: 'history',
  base: __dirname,
  routes: [
    { path: '/', component : HomePage },
    // params are denoted with a colon ":"
    { path: '/listing' , component: ListHotel },
    // a param can be made optional by adding "?"
    { path: '/optional-params/:foo?' },
    // a param can be followed by a regex pattern in parens
    // this route will only be matched if :id is all numbers
    { path: '/params-with-regex/:id(\\d+)' },
    // asterisk can match anything
    { path: '/asterisk/*' },
    // make part of the path optional by wrapping with parens and add "?"
    { path: '/optional-group/(foo/)?bar' }
  ]
})

new Vue({
  router,
  render: h=>h(App)
}).$mount('#app')