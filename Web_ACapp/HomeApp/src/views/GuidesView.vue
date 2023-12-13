<script setup>
import { ref } from "vue";
import { RouterLink, RouterView } from "vue-router";
import DoorbellGuide from "../components/guides/DoorbellGuide.vue";
import routerVideoDoorbell from "../components/GuideComponent.vue";
import LockGuide from "../components/guides/LockGuide.vue";
import routerLock from "../components/GuideComponent.vue";

const message = ref("");
</script>

<template>
  <body>
    <div class="">
      <DoorbellGuide v-show="routerVideoDoorbell == true" />
      <LockGuide v-show="routerLock == true" />
    </div>
  </body>
</template>
<script></script>
<style scoped></style>
