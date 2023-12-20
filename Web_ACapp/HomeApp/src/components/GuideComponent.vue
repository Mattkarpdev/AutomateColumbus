<script setup>
import { ref } from "vue";
import { RouterLink, RouterView } from "vue-router";

const message = ref("");
</script>

<template>
  <div
    id="guide"
    class="flex flex-col flex-nowrap p-10 xl:container xl:mx-auto xl:px-44"
  >
    <div class="flex justify-center p-4">
      <h2 class="font-title text-3xl">Guides</h2>
    </div>

    <div class="inline-flex items-center justify-center gap-[35px] p-3">
      <div class="text-center font-main text-4xl font-bold">tags:</div>

      <button
        class="rounded-[23px] border p-2 transition ease-in-out hover:scale-110"
        v-bind:style="{
          backgroundColor:
            showSecurity & showGeneral & showCameras & showLights
              ? '#945C50'
              : '',
        }"
        v-on:click="
          (showGeneral = true),
            (showCameras = true),
            (showSecurity = true),
            (showLights = true)
        "
      >
        <div
          class="text-center font-main text-4xl font-semibold text-black"
          v-bind:style="{
            color:
              showSecurity & showGeneral & showCameras & showLights
                ? 'lightgray'
                : '',
          }"
        >
          All Guides
        </div>
      </button>

      <button
        class="rounded-[23px] border p-2 hover:scale-110"
        v-on:click="showCameras = !showCameras"
        v-bind:style="{
          backgroundColor: showCameras ? '' : '#945C50',
        }"
      >
        <div
          class="text-center font-main text-4xl font-semibold text-black"
          v-bind:style="{ color: showCameras ? '' : 'lightgray' }"
        >
          Cameras
        </div>
      </button>

      <button
        class="rounded-[23px] border p-2 hover:scale-110"
        v-on:click="showGeneral = !showGeneral"
        v-bind:style="{
          backgroundColor: showGeneral ? '' : '#945C50',
        }"
      >
        <div
          class="text-center font-main text-4xl font-semibold text-black"
          v-bind:style="{ color: showGeneral ? '' : 'lightgray' }"
        >
          General Info
        </div>
      </button>

      <button
        class="rounded-[23px] border p-2 hover:scale-110"
        v-on:click="showLights = !showLights"
        v-bind:style="{
          backgroundColor: showLights ? '' : '#945C50',
        }"
      >
        <div
          class="text-center font-main text-4xl font-semibold text-black"
          v-bind:style="{ color: showLights ? '' : 'lightgray' }"
        >
          Lights
        </div>
      </button>

      <button
        class="rounded-[23px] border p-2 hover:scale-110"
        v-on:click="showSecurity = !showSecurity"
        v-bind:style="{
          backgroundColor: showSecurity ? '' : '#945C50',
        }"
      >
        <div
          class="text-center font-main text-4xl font-semibold text-black"
          v-bind:style="{ color: showSecurity ? '' : 'lightgray' }"
        >
          Security
        </div>
      </button>
    </div>
    <div
      class="grid grid-flow-col grid-cols-4 grid-rows-4 p-9 font-main text-2xl"
    >
      <button
        @click="
          routerLock = false;
          routerVideoDoorbell = true;
          $router.push('guides');
        "
        v-show="showGeneral & showLights"
        class="p-2"
      >
        Video Doorbell
      </button>

      <div v-show="showCameras & showGeneral & showLights" class="p-2">
        Alarm System
      </div>

      <button
        @click="
          routerVideoDoorbell = false;
          routerLock = true;
          $router.push('guides');
        "
        v-show="showCameras & showGeneral & showLights"
        class="p-2"
      >
        Door Lock
      </button>

      <div v-show="showCameras & showSecurity & showLights" class="p-2">
        Smart Protocol
      </div>
      <div v-show="showCameras & showSecurity & showLights" class="p-2">
        Smart Ecosystems
      </div>
    </div>
  </div>
</template>
<script>
// const props = defineProps({ routerVideoDoorbell: false, routerLock: false });
const routerVideoDoorbell = ref(false);
const routerLock = ref(false);
export default {
  data() {
    return {
      showCameras: true,
      showGeneral: true,
      showLights: true,
      showSecurity: true,
    };
  },
  props: {
    routerLock: routerLock,
    routerVideoDoorbell: routerVideoDoorbell,
  },
  methods: {},
};
</script>

<!-- <div>
        <div class="p-2">
          <div class="card" style="width: 18rem">
            <img
              src="https://www.the-sun.com/wp-content/uploads/sites/6/2022/09/LG-RING-DOORBELL-COMP.jpg?w=1280&quality=44"
              class="card-img-top"
              alt="..."
            />
            <div class="card-body">
              <h5 class="text-3xl font-bold underline">Video Doorbell</h5>
              <p class="card-text">
                Video doorbells have bad picture, amazon needs to make them
                better.
              </p>
              <RouterLink to="/guides/doorbellguide" class="btn btn-primary"
                >Go somewhere
              </RouterLink>
            </div>
          </div>
        </div>
      </div>
      <div class="p-2">
        <div class="card" style="width: 18rem">
          <img
            src="https://cdn.idealo.com/folder/Product/201534/5/201534593/s3_produktbild_max/ring-alarm-kit-2nd-gen.jpg"
            class="card-img-top"
            alt="..."
          />
          <div class="card-body">
            <h5 class="card-title">Card title</h5>
            <p class="card-text">
              Some quick example text to build on the card title and make up the
              bulk of the card's content.
            </p>
            <a href="#" class="btn btn-primary">Go somewhere</a>
          </div>
        </div>
      </div>
      <div class="p-2" id="guide">
        <div class="card" style="width: 18rem">
          <img
            src="https://u-tec.com/cdn/shop/t/57/assets/sence-banner.png?v=175755877485102375081689760851"
            class="card-img-top"
            alt="..."
          />
          <div class="card-body">
            <h5 class="card-title">Card title</h5>
            <p class="card-text">
              Some quick example text to build on the card title and make up the
              bulk of the card's content.
            </p>
            <a href="#" class="btn btn-primary">Go somewhere</a>
          </div>
        </div>
      </div> -->
