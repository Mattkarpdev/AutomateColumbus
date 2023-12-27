<script setup>
import { computed, ref } from "vue";
import { RouterLink, RouterView } from "vue-router";
import DoorbellGuide from "../components/guides/DoorbellGuide.vue";
import routerGuide from "../components/GuideComponent.vue";
import LockGuide from "../components/guides/LockGuide.vue";
import AlarmGuide from "../components/guides/AlarmGuide.vue";
import ProtocolGuide from "../components/guides/ProtocolGuide.vue";
import EcosystemGuide from "../components/guides/EcosystemGuide.vue";
import markdownit from "markdown-it";
import NavBarGuideComponent from "../components/NavBarGuideComponent.vue";
import GuideComponent from "../components/GuideComponent.vue";

import router from "../router";

const md = markdownit();
const result = md.render(`# Happy`);

const doorbellProp = ref(routerGuide.props.routerVideoDoorbell);
const lockProp = ref(routerGuide.props.routerLock);
const alarmProp = ref(routerGuide.props.routerAlarm);
const protocolProp = ref(routerGuide.props.routerProtocol);
const ecosystemProp = ref(routerGuide.props.routerEcosystem);
const message = ref("");
</script>

<template>
  <body
    class="bg-local bg-center"
    style="background-image: url(src/assets/Frame13.png)"
  >
    <header>
      <NavBarGuideComponent />
    </header>
    <main>
      <div :class="mdStyle" class="font-main">
        <div class="">
          <DoorbellGuide v-show="doorbellProp" />
        </div>

        <LockGuide v-show="lockProp" />
        <AlarmGuide v-show="alarmProp" />
        <EcosystemGuide v-show="ecosystemProp" />
        <ProtocolGuide v-show="protocolProp" />
        <div><GuideComponent /></div>
      </div>
    </main>
  </body>
</template>
<script>
export default {
  computed: {},
};
</script>
<style>
h1 {
  font-size: 62px;
  font-weight: bold;
  padding-left: 50px;
  padding-top: 14px;
}
h2 {
  font-size: xx-large;
  font-weight: bold;
  padding-left: 50px;
  padding-top: 50px;
  padding-bottom: 14px;
}
h3 {
  font-size: x-large;
  font-weight: bold;
  padding-left: 50px;
  padding-top: 14px;
  padding-bottom: 14px;
}
h4 {
  font-size: x-large;
  padding-left: 50px;
  padding-left: 50px;
  padding-top: 14px;
  padding-bottom: 14px;
}
h6 {
  font-size: xx-large;
  font-weight: bold;
  padding-left: 50px;
  padding-top: 40px;
}

strong {
  font-weight: 600;
}
ol li {
  list-style-type: decimal;

  font-size: 22px;
  font-weight: bold;
}
ol {
  padding-left: 100px;
}
ul li {
  list-style-type: "- ";
  flex-wrap: wrap;
  font-size: 20px;
  padding-right: 100px;
  padding: 6px;
}
ul {
  padding-left: 120px;
  padding-right: 100px;
}
p {
  font-size: x-large;
  flex-wrap: wrap;
  padding: 16px;
  padding-right: 100px;
  padding-left: 50px;
}
</style>
