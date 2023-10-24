<script setup>
import { ref } from "vue";
import CalculatorComponent from "../components/CalculatorComponent.vue";
import GuidesComponent from "../components/GuideComponent.vue";
import NewsComponent from "../components/NewsComponent.vue";
import DoorbellGuide from "../router/index.js";
import { RouterLink } from "vue-router";
import NavBarComponent from "../components/NavBarComponent.vue";
</script>

<template>
  <body>
    <div
      class="bg-local bg-center"
      style="background-image: url(src/assets/Frame13.png)"
    >
      <header>
        <NavBarComponent />
      </header>
      <main class="">
        <section class="columns-2 p-4">
          <div
            class="inline-flex h-[528px] w-[1727px] flex-col items-center justify-end gap-2.5 px-[260px]"
          >
            <div
              class="inline-flex h-[508px] w-[1207px] items-start justify-start gap-[45px]"
            >
              <img
                class="w-[616px] self-stretch rounded-[25px]"
                src="src/assets/DreamShaper_v7_Home_Automation_0.jpg"
              />
              <div class="container" style="opacity: 0.9">
                <h5
                  class="text-black h-[508px] w-[546px] p-5 text-center font-main text-4xl"
                  style="color: rgb(7, 6, 7)"
                >
                  Automate Columbus is a hub for home automation insite through
                  comprehensive installation guides and the latest news on smart
                  technology. We also offer community support as well as
                  installation services to the Columbus and Dayton Ohio areas.
                </h5>
              </div>
            </div>
          </div>
        </section>
        <div>
          <h2>News</h2>
          <NewsComponent />
        </div>
        <div>
          <h2>Guides</h2>
          <GuidesComponent />
        </div>

        <div
          id="installationCalculator"
          class="d-flex justify-content-center p-5"
        >
          <h2>Installation Calculator</h2>
          <CalculatorComponent />
        </div>
      </main>
    </div>
  </body>
</template>

<style></style>
