<template>
  <div id="app" class="select-none">
    <div class="flex bg-orange-400 mb-10 max-h-20">
      <img alt="Vue logo" class="w-12 h-12 | sm:w-20 sm:h-20" src="./assets/takeaway.png">
      <h1 class="font-sans text-center text-3xl text-white flex-1 justify-self-center pt-2 pb-2 | sm:text-4xl | md:text-7xl | md:pb-0 md:pt-0">TAKEAWAYCOOKIES</h1>
    </div>
    <ListComponent/>
  </div>
</template>

<script>
import ListComponent from './components/ListComponent.vue'

export default {
  name: 'App',
  components: {
    ListComponent
  }
}
</script>

<style>
</style>
