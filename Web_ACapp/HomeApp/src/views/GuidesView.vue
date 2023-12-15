<script setup>
import { ref } from "vue";
import { RouterLink, RouterView } from "vue-router";
import DoorbellGuide from "../components/guides/DoorbellGuide.vue";
import routerGuide from "../components/GuideComponent.vue";
import LockGuide from "../components/guides/LockGuide.vue";

const message = ref("");
</script>

<template>
  <body>
    <div class="">
      {{ routerGuide.props.routerLock
      }}{{ routerGuide.props.routerVideoDoorbell }}
      <DoorbellGuide />
      <LockGuide />
    </div>
  </body>
</template>
<script></script>
<style scoped></style>
