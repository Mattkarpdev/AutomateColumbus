<script setup>
import { computed, ref } from "vue";
import { RouterLink, RouterView } from "vue-router";
import DoorbellGuide from "../components/guides/DoorbellGuide.vue";
import routerGuide from "../components/GuideComponent.vue";
import LockGuide from "../components/guides/LockGuide.vue";

import { marked } from "marked";
import VueMarkdown from "vue-markdown-render";
import plop from "../components/guides/plop.md";

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
    <div v-html="installationHtml"></div>
    <VueMarkdown :source="plop" />
  </body>
</template>
<script>
const installationHtml = marked(plop);

export default {
  computed: {},
};
</script>
<style scoped></style>
