<script setup>
import { computed, ref } from "vue";
import { RouterLink, RouterView } from "vue-router";
import DoorbellGuide from "../components/guides/DoorbellGuide.vue";
import routerGuide from "../components/GuideComponent.vue";
import LockGuide from "../components/guides/LockGuide.vue";
import { marked } from "marked";
import markdownit from "markdown-it";

import plop from "../components/guides/plop.md";

const md = markdownit();
const result = md.render(`# Happy`);

const message = ref("");
</script>

<template>
  <body class="bg-transparent">
    <div class="">
      {{ routerGuide.props.routerLock
      }}{{ routerGuide.props.routerVideoDoorbell }}
      <DoorbellGuide />
    </div>
    <div>wiennnnerrrrrrrrrrrrr</div>
    <LockGuide />
  </body>
</template>
<script>
export default {
  computed: {},
};
</script>

<style>
h1 {
  font-size: xx-large;
}
h2 {
  font-size: x-large;
}
h4 {
  font-size: small;
}
</style>
