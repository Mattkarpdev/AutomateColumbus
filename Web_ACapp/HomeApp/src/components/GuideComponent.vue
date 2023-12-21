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
          routerEcosystem = false;
          routerProtocol = false;
          routerLock = false;
          routerVideoDoorbell = true;
          routerAlarm = false;
          $router.push('guides');
        "
        v-show="showGeneral & showLights"
        class="p-2"
      >
        Video Doorbell
      </button>

      <button
        @click="
          routerEcosystem = false;
          routerProtocol = false;
          routerAlarm = true;
          routerLock = false;
          routerVideoDoorbell = false;
          $router.push('guides');
        "
        v-show="showCameras & showGeneral & showLights"
        class="p-2"
      >
        Alarm System
      </button>

      <button
        @click="
          routerEcosystem = false;
          routerProtocol = false;
          routerVideoDoorbell = false;
          routerAlarm = false;
          routerLock = true;
          $router.push('guides');
        "
        v-show="showCameras & showGeneral & showLights"
        class="p-2"
      >
        Door Lock
      </button>

      <button
        @click="
          routerEcosystem = false;
          routerProtocol = true;
          routerVideoDoorbell = false;
          routerAlarm = false;
          routerLock = false;
          $router.push('guides');
        "
        v-show="showCameras & showSecurity & showLights"
        class="p-2"
      >
        Smart Protocols
      </button>

      <button
        @click="
          routerEcosystem = true;
          routerProtocol = false;
          routerVideoDoorbell = false;
          routerAlarm = false;
          routerLock = false;
          $router.push('guides');
        "
        v-show="showCameras & showSecurity & showLights"
        class="p-2"
      >
        Smart Ecosystems
      </button>
    </div>
  </div>
</template>
<script>
// const props = defineProps({ routerVideoDoorbell: false, routerLock: false });
const routerVideoDoorbell = ref(false);
const routerLock = ref(false);
const routerAlarm = ref(false);
const routerEcosystem = ref(false);
const routerProtocol = ref(false);
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
    routerAlarm: routerAlarm,
    routerEcosystem: routerEcosystem,
    routerProtocol: routerProtocol,
  },
  methods: {},
};
</script>
