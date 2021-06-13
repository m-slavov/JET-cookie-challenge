<template>
<!-- component -->
<div class="min-h-screen bg-transparent flex flex-col sm:py-12 gap-8">
  <section v-if="err_msg != null" class="text-center">
    <p>{{err_msg.data}}</p>
    <p>{{err_msg.status}}</p>
  </section>

  <div v-for="cookie in cookieList" v-bind:key="cookie.id" :class="{ activeclass: isOpen}">
    <Item :cookie="cookie"></Item>
  </div>
</div>
</template>

<script>
import Item from "./Item.vue"
import axios from 'axios'

export default {
  name: 'List',
  components: {
    Item
  },
  data: function() {
    return {err_msg: null, cookieList: null, isOpen: true, cookies: [
      {"id":2,"name":"Chocolate Chip Cookie","weight":16,"calories":78,"ingredient":[{"id":4,"name":"Almond","image":"almond","cookieIngredients":null},{"id":7,"name":"Butter","image":"butter","cookieIngredients":null},{"id":6,"name":"Chocolate","image":"chocolate-bar","cookieIngredients":null},{"id":3,"name":"Egg","image":"egg","cookieIngredients":null},{"id":5,"name":"Sugar","image":"sugar","cookieIngredients":null}]},{"id":1,"name":"Macaron","weight":24,"calories":97,"ingredient":[{"id":1,"name":"Baking soda","image":"baking-soda","cookieIngredients":null},{"id":3,"name":"Egg","image":"egg","cookieIngredients":null},{"id":2,"name":"Salt","image":"salt","cookieIngredients":null}]},{"id":4,"name":"Savoiardi","weight":7.5,"calories":27.5,"ingredient":[{"id":1,"name":"Baking soda","image":"baking-soda","cookieIngredients":null},{"id":3,"name":"Egg","image":"egg","cookieIngredients":null},{"id":8,"name":"Flour","image":"flour","cookieIngredients":null}]},{"id":3,"name":"Scottish Shortbread","weight":8,"calories":40,"ingredient":[{"id":1,"name":"Baking soda","image":"baking-soda","cookieIngredients":null},{"id":7,"name":"Butter","image":"butter","cookieIngredients":null},{"id":8,"name":"Flour","image":"flour","cookieIngredients":null}]},{"id":5,"name":"Zimtsterne","weight":30,"calories":130,"ingredient":[{"id":1,"name":"Baking soda","image":"baking-soda","cookieIngredients":null},{"id":11,"name":"Cinnamon","image":"cinnamon","cookieIngredients":null},{"id":3,"name":"Egg","image":"egg","cookieIngredients":null},{"id":10,"name":"Hazelnut","image":"hazelnut","cookieIngredients":null},{"id":2,"name":"Salt","image":"salt","cookieIngredients":null},{"id":9,"name":"Vanilla","image":"vanilla","cookieIngredients":null}]}
    ]}
  },
  methods: {
    toggleAccordion: function(){
      this.isOpen = !this.isOpen;
    }
  },
  computed: {
    accordionClasses: function(){
      return{
        'is-closed': !this.isOpen,
        'is-primary': this.isOpen,
        'is-dark': !this.isOpen
      };
    }
  },
  mounted(){
    axios
      .get("/api/Cookies")
      .then(response => {console.log(JSON.stringify(response.data)) 
      this.cookieList = response.data})
      .catch(error => {
        console.log(error.response)
        if(!error.response){
          console.log("Check connection.")
        } else if (error.response){
          console.log(error)
          this.err_msg = error.response
          this.erorred = true;
          console.log(this.erorred)
        }
      })

  }
}
</script>