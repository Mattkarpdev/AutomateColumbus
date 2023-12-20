<script setup>
import { ref } from "vue";
import CalculatorComponent from "../components/CalculatorComponent.vue";
import GuidesComponent from "../components/GuideComponent.vue";
import NewsComponent from "../components/NewsComponent.vue";

import { RouterLink } from "vue-router";
import NavBarComponent from "../components/NavBarComponent.vue";
import ContactComponent from "../components/ContactComponent.vue";
</script>

<template>
  <div id="home">
    <body>
      <div
        class="bg-local bg-center"
        style="background-image: url(src/assets/Frame13.png)"
      >
        <header>
          <NavBarComponent />
        </header>
        <main class="">
          <section class="p-10">
            <div class="flex justify-center self-center">
              <div class="flex h-[508px] w-[1207px] gap-[45px]">
                <img
                  class="w-[616px] rounded-[25px]"
                  src="src/assets/DreamShaper_v7_Home_Automation_0.jpg"
                />
                <div class="flex self-center" style="opacity: 0.9">
                  <h5
                    class="p-4 text-center font-main text-4xl text-black"
                    style="color: rgb(7, 6, 7)"
                  >
                    Automate Columbus is a hub for home automation insite
                    through comprehensive installation guides and the latest
                    news on smart technology. We also offer community support as
                    well as installation services to the Columbus and Dayton
                    Ohio areas.
                  </h5>
                </div>
              </div>
            </div>
          </section>
          <div>
            <h2></h2>
            <NewsComponent />
          </div>
          <div>
            <h2></h2>
            <GuidesComponent />
          </div>

          <div class="d-flex justify-content-center p-5">
            <h2></h2>
            <CalculatorComponent />
          </div>

          <div id="contactComponent" class="d-flex justify-content-center pt-5">
            <h2></h2>
            <ContactComponent />
          </div>
        </main>
      </div>
    </body>
  </div>
</template>

<style></style>
