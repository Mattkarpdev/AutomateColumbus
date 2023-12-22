<template>
  <div class="flex flex-row justify-center p-5 px-44 pb-1 pt-14" id="news">
    <div class="pt-3 font-title text-3xl">News</div>
  </div>
  <div>
    <VueRssFeed
      :feedUrl="feedUrl"
      :name="name"
      :limit="limit"
      :feedUrl2="feedUrl2"
      :name2="name2"
      :limit2="limit2"
      :feedUrl3="feedUrl3"
      :name3="name3"
      :limit3="limit3"
    />
  </div>
</template>

<script>
import { ref } from "vue";
import VueRssFeed from "/node_modules/vue-rss-feed/src/VueRssFeed.vue";

export default {
  components: {
    VueRssFeed,
  },
  data() {
    return {
      feedUrl: "https://www.the-ambient.com/rss",
      name: "",
      limit: 1,
      feedUrl2: "https://www.cnet.com/rss/smart-home/",
      name2: "",
      limit2: 1,
      feedUrl3: "https://www.gadgets360.com/rss/smart-home/feeds",
      name3: "",
      limit3: 1,
    };
  },
};
</script>
