<template id="list-item">
  <div class="w-3/4 m-auto">
    <div @click="toggleAccordion" class="bg-white border-red-400 dark:bg-gray-800 bg-opacity-95 border-opacity-60 | p-4 border-solid border-2 | grid sm:flex justify-around cursor-pointer | hover:border-gray-900 dark:hover:bg-orange-600 hover:border-transparent | transition-colors duration-500 | ease-in-out transform hover:-translate-y-1 hover:scale-110">
      
      <img class="w-16 h-16 object-cover mb-auto mt-auto" src="../assets/cookie.png" alt="" />
      
      <div class="flex flex-col justify-center text-center">
        <p class="font-bold text-xl">Name</p>
        <p class="rounded-full py-3 px-6 bg-blue-100 select-text">{{cookie.name}}</p>
      </div>

      <div class="flex flex-col justify-center text-center">
        <div class="flex">
          <img class="h-5 w-5" src="../assets/scale.png" alt="" /> 
          <p class="font-bold text-xl">Weight(g)</p>
        </div>
        <p class="rounded-full py-3 px-6 bg-blue-100">{{cookie.weight}}</p>
      </div>

      <div class="flex flex-col justify-center text-center">
        <div class="flex">
          <img class="h-5 w-5" src="../assets/calorie.png" alt="" /> 
          <p class="font-bold text-xl">Calories</p>
        </div>
        <p class="rounded-full py-3 px-6 bg-blue-100">{{cookie.calories}}</p>
      </div>
      
      <div class="border-orange-400 rounded p-4 border-solid border-2 | px-4 py-3 text-sm focus:outline-none | mt-4 sm:mt-0">
        <img class="w-14 h-14 m-auto duration-500" :class="{'transform rotate-180 duration-500': isOpen}" src="../assets/arrow.png" alt="" /> 
        <div v-show="!isOpen" class="text-center">View</div>
        <div v-show="isOpen" class="text-center">Hide</div>
      </div>
            
    </div>
    <div v-show="isOpen" class="border-orange-400 bg-orange-400 border-t-0 dark:bg-gray-800 bg-opacity-95 border-opacity-60 | p-4 border-solid border-2 | transition-colors duration-500">
      
      <p>Calories per 100/g : 50 </p>
      <h1 class="divide-y text-center font-mono text-xl mt-2 mb-8">Ingredients</h1>
      <div  class="flex flex-wrap gap-4 justify-center" >

        <div  v-for="ingredient in cookie.ingredient" v-bind:key="ingredient.id" class="border-white rounded-full h-48 w-48 flex items-center justify-center border-2 flex-col">
          <img class="w-16 h-16 object-cover" src="../assets/cookie.png" alt="" />
          <p class="text-center block select-text"> {{ingredient.name}} </p>
        </div>

      </div>


    </div>
  </div>
</template>

<script>
//import axios from 'axios';

export default {
  name: 'ListItem',
  props: ['cookie'],
  data: function() {
    return {isOpen: false}
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

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
h3 {
  margin: 40px 0 0;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}

.message {
    max-width: 500px;
    margin-left: auto;
    margin-right: auto;
}

.message-header {
    cursor: pointer;
}

.message-body   {
    padding: 0;
    max-height: 10em;
    overflow: hidden;
    transition: 0.3s ease all;
}

.is-closed .message-body {
    max-height: 0;
}

.message-content {
    padding: 20px;
}

</style>
