<script setup>
import { computed, ref } from "vue";
import { RouterLink, RouterView } from "vue-router";
import DoorbellGuide from "../components/guides/DoorbellGuide.vue";
import routerGuide from "../components/GuideComponent.vue";
import LockGuide from "../components/guides/LockGuide.vue";
import { marked } from "marked";
import markdownit from "markdown-it";
import NavBarGuideComponent from "../components/NavBarGuideComponent.vue";
import GuideComponent from "../components/GuideComponent.vue";

const md = markdownit();
const result = md.render(`# Happy`);

const doorbellProp = ref(routerGuide.props.routerVideoDoorbell);
const lockProp = ref(routerGuide.props.routerLock);
const message = ref("");
</script>

<template>
  <body>
    <div
      class="bg-local bg-center"
      style="background-image: url(src/assets/Frame13.png)"
    >
      <header>
        <NavBarGuideComponent />
      </header>
      <div class="font-main">
        <div class="">
          {{ routerGuide.props.routerLock }},{{
            routerGuide.props.routerVideoDoorbell
          }},
          <DoorbellGuide v-show="doorbellProp" />
        </div>

        <LockGuide v-show="lockProp" />
        <div><GuideComponent />></div>
      </div>
    </div>
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
h3 {
  font-size: large;
  font-weight: 900;
}
strong {
  font-weight: 600;
}
ol li {
  list-style-type: decimal;
  font-weight: 900;
}
ol {
  padding-left: 36px;
}
</style>
