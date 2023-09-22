<script setup>
import { ref } from 'vue'
import CalculatorComponent from '../components/CalculatorComponent.vue'
import { RouterLink } from 'vue-router';


</script>


<template>
  <body>

    <header id="header" class="p-5">
      <section class="bg-header d-flex justify-content-center  p-5">

        <h1 class=" black">Automate Columbus</h1>
      </section>
      <div class="container">
        <nav class="navbar navbar-expand-lg bg-dark navbar-dark">
          <div class="container">
            <a href="#" class="navbar-brand"></a>
            <ul class="navbar-nav ms-auto">
              <li nav-item><a class="nav-link scrollto active" href="#hero">Home</a></li>
              <li><a class="nav-link scrollto" href="#guide">Guides</a></li>
              <li><a class="nav-link scrollto" href="#installionCalculator">Installation Calculator</a></li>
            </ul>
          </div>
        </nav>

      </div>

    </header>

    <main class="p-5 ">
      <section class="p-5 d-flex justify-content-center">
        <p> Welcome to Automate Columbus, a source of local home automation guidence and service.</p>
      </section>
      <div class="d-flex justify-content-center p-5">
        <div class="card" style="width: 18rem;">
          <img
            src="https://www.the-sun.com/wp-content/uploads/sites/6/2022/09/LG-RING-DOORBELL-COMP.jpg?w=1280&quality=44"
            class="card-img-top" alt="...">
          <div class="card-body">
            <h5 class="card-title">Video Doorbell</h5>
            <p class="card-text">Video doorbells have bad picture, amazon needs to make them better.</p>
            <RouterLink to="../src/components/guides/DoorbellGuide.vue" class="btn btn-primary">Go somewhere
            </RouterLink>
          </div>
        </div>
        <div class="card" style="width: 18rem;">
          <img
            src="https://cdn.idealo.com/folder/Product/201534/5/201534593/s3_produktbild_max/ring-alarm-kit-2nd-gen.jpg"
            class="card-img-top" alt="...">
          <div class="card-body">
            <h5 class="card-title">Card title</h5>
            <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's
              content.</p>
            <a href="#" class="btn btn-primary">Go somewhere</a>
          </div>
        </div>
        <div class="card" style="width: 18rem;">
          <img src="https://u-tec.com/cdn/shop/t/57/assets/sence-banner.png?v=175755877485102375081689760851"
            class="card-img-top" alt="...">
          <div class="card-body">
            <h5 class="card-title">Card title</h5>
            <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's
              content.</p>
            <a href="#" class="btn btn-primary">Go somewhere</a>
          </div>
        </div>
      </div>

      <div class=" d-flex justify-content-center p-5">
        <CalculatorComponent />
      </div>
    </main>

  </body>
</template>

<style>
header {
  background-image: url(src/assets/smartHomeA.jpg);
  background-repeat: no-repeat;
  background-position: center;
  background-size: cover;
  background-attachment: fixed;
  height: 100%;
  opacity: .9;
  
;
}

main {
  background-image: url(src/assets/smartHomeA.jpg);
  background-repeat: no-repeat;
  background-position: center;
  background-size: cover;
  background-attachment: fixed;
  height: 100%;


}
body{
  

  background-image: url(src/assets/smartHomeA.jpg);
  background-repeat: no-repeat;
  background-position: center;
  background-size: cover;
  background-attachment: fixed;
  height: 100%;
 
  
}

 

</style>