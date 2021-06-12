<template>
<!-- component -->
<div class="min-h-screen bg-transparent flex flex-col sm:py-12 gap-8">
  <div v-for="cookie in cookies" v-bind:key="cookie.id" :class="{ activeclass: isOpen}">
    <Item :cookie="cookie"></Item>
  </div>
</div>
</template>

<script>
import Item from "./Item.vue"

export default {
  name: 'List',
  components: {
    Item
  },
  data: function() {
    return {info: null, isOpen: true, cookies: [
      {
    "id": 1,
    "name": "Chocolate Chip Cookies",
    "weight": 100,
    "calories": 488,
    "ingredient": [
      {
        "id": 1,
        "name": "Vanilla extract",
        "cookieIngredients": null
      },
      {
        "id": 2,
        "name": "Sugar",
        "cookieIngredients": null
      }
    ]
  },
  {
    "id": 2,
    "name": "Shortbread Cookies",
    "weight": 100,
    "calories": 502,
    "ingredient": [
      {
        "id": 2,
        "name": "Sugar",
        "cookieIngredients": null
      },
      {
        "id": 4,
        "name": "Butter",
        "cookieIngredients": null
      }
    ]
  },
  {
    "id": 3,
    "name": "Macaron Cookies",
    "weight": 100,
    "calories": 404,
    "ingredient": [
      {
        "id": 2,
        "name": "Sugar",
        "cookieIngredients": null
      },
      {
        "id": 3,
        "name": "Dark chocolate",
        "cookieIngredients": null
      },
      {
        "id": 4,
        "name": "Butter",
        "cookieIngredients": null
      }
    ]
  }
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
  }
  /*mounted(){
    axios
      .get("https://localhost:49397/api/Colors")
      .then(response => {console.log(JSON.stringify(response.data)) 
      this.info = response.data})

  }*/
}
</script>