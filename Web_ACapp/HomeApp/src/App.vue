<script setup>
import { RouterLink, RouterView } from 'vue-router'

</script>

<template class="container-fluid">
  <body data-aos-easing="ease-in-out" data-aos-duration="1000" data-aos-delay="0">
    
  
  <header>
    <img alt="Vue logo" class="logo" src="https://cdn.pixabay.com/photo/2017/09/20/16/59/smart-home-2769239_1280.jpg"
      width="600" height="400" />

    <div class="wrapper">

      <h1 class="black">Automate Columbus</h1>
      <div></div>
      <nav>
        <RouterLink to="/">Home</RouterLink>
        <RouterLink to="/guides">Guides</RouterLink>
        <RouterLink to="/calculator">Calculator</RouterLink>
      </nav>
    </div>
  </header>
  <div class="container-fluid">
    <RouterView />
  </div>
</body>
</template>

<style scoped></style>
