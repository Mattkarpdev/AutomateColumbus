<!-- <template>
  <div id="news" class="d-flex justify-content-center p-5">
    <h2>News</h2>
    <div class="p-2">
      <div class="card" style="width: 18rem">
        <img
          src="https://www.the-sun.com/wp-content/uploads/sites/6/2022/09/LG-RING-DOORBELL-COMP.jpg?w=1280&quality=44"
          class="card-img-top"
          alt="..."
        />
        <div class="card-body">
          <h5 class="card-title">Video Doorbell</h5>
          <p class="card-text">
            Video doorbells have bad picture, amazon needs to make them better.
          </p>
          <RouterLink
            to="../src/components/guides/DoorbellGuide.vue"
            class="btn btn-primary"
            >Go somewhere
          </RouterLink>
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
    </div>
  </div>
</template> -->

<!-- <script>
methods: {
  cnetRss(rss);
  {
  }
}
</script> -->

<!-- reference https://javascript.plainenglish.io/create-an-rss-reader-with-vue-js-and-javascript-2deb5785556a-->
<!-- <template> -->
<!--<div style="color: #ccc; font-size: 10px; text-align: right; width: 230px">
    powered by
    <a
      href="https://surfing-waves.com"
      rel="noopener"
      target="_blank"
      style="color: #ccc"
      >Surfing Waves</a
    >
  </div> -->

<!-- <div id="news1" v-on="loadXMLDoc()"></div>
</template> -->

<!-- <script>
export default {
  methods: {
    loadXMLDoc() {
      var xmlhttp = new XMLHttpRequest();
      xmlhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
          myFunction(this);
        }
      };
      xmlhttp.open("GET", "https://www.the-ambient.com/rss", true);
      xmlhttp.send();

      function myFunction(xml) {
        var x, i, xmlDoc, txt;
        xmlDoc = xml.responseXML;
        txt = "";
        x = xmlDoc.getElementsByTagName("title");
        i = 2;
        txt = x[i].childNodes[0].nodeValue + "<br>";

        document.getElementById("news1").innerHTML = txt;
      }
    },
  },
};
</script> -->
<!-- <script>
import { promises as fs } from "fs";
import Parser from "rss-parser";

(async function main() {
  const parser = new Parser();

  const feed = await parser.parseURL("https://www.cnet.com/rss/smart-home/");

  let items = [];
  const fileName = `${feed.title
    .replace(/\s+/g, "-")
    .replace(/[/\\?%*:|"<>]/g, "")
    .toLowerCase()}.json`;
  if (existsSync(fileName)) {
    items = require(fileName);
  }
  await Promise.all(
    feed.items.map(async (currentItem) => {
      if (items.filter((item) => item === currentItem).length <= 1) {
        items.push(currentItem);
      }
    }),
  );
  fs.writeFilec(fileName, JSON.stringify(items));
})();
</script> -->
<!-- start sw-rss-feed code -->
<!-- <script type="text/javascript">
rssfeed_url = new Array();
rssfeed_url[0] = "https://www.cnet.com/rss/smart-home/";
rssfeed_frame_width = "230";
rssfeed_frame_height = "260";
rssfeed_url = "on";
rssfeed_scroll_step = "6";
rssfeed_scroll_bar = "off";
rssfeed_target = "_blank";
rssfeed_font_size = "12";
rssfeed_font_face = "";
rssfeed_border = "on";
rssfeed_url = "https://feed.surfing-waves.com/css/style2a.css";
rssfeed_title = "on";
rssfeed_title_name = "";
rssfeed_title_bgcolor = "#3366ff";
rssfeed_title_color = "#fff";
rssfeed_title_bgimage = "";
rssfeed_footer = "off";
rssfeed_footer_name = "rss feed";
rssfeed_footer_bgcolor = "#fff";
rssfeed_footer_color = "#333";
rssfeed_footer_bgimage = "";
rssfeed_item_title_length = "50";
rssfeed_item_title_color = "#666";
rssfeed_item_bgcolor = "#fff";
rssfeed_item_bgimage = "";
rssfeed_item_border_bottom = "on";
rssfeed_item_source_icon = "off";
rssfeed_item_date = "off";
rssfeed_item_description = "on";
rssfeed_item_description_length = "120";
rssfeed_item_description_color = "#666";
rssfeed_item_description_link_color = "#333";
rssfeed_item_description_tag = "off";
rssfeed_no_items = "0";
rssfeed_cache = "f0229c31dd16c2755947926ffc595c93";

type = "text/javascript";
src = "//feed.surfing-waves.com/js/rss-feed.js";
</script> -->
<!-- The link below helps keep this service FREE, and helps other people find the SW widget. Please be cool and keep it! Thanks. -->

<!-- end sw-rss-feed code -->
<!-- <script>
import axios from "axios";
const RSS_URL = `https://www.the-ambient.com/rss`;
export default{

      computed:{get(RSS_URL)
  .then((response) => response.text())
  .then((str) => new window.DOMParser().parseFromString(str, "text/xml"))
  .then((data) => console.log(data));
},
  };
</script> -->
<!-- <template>

</template> -->
<!-- <template>
  <div id="app">
    <form @submit.prevent="getRss">
      <div>
        <label> rss url</label>
        <br />
        <input v-model="rssUrl" />
      </div>
      <input type="submit" />
    </form>
    <div v-for="item of items" :key="item.title">
      <h1>{{ item.title }}</h1>
      <p>{{ item.author }}</p>
      <a :href="item.link">{{ item.link }}</a>
    </div>
  </div>
</template>
<script>
export default {
  name: "App",
  data() {
    return {
      rssUrl: "",
      items: [],
    };
  },
  methods: {
    async getRss() {
      const urlRegex =
        /(http|ftp|https):\/\/[\w-]+(\.[\w-]+)+([\w.,@?^=%&amp;:\/~+#-]*[\w@?^=%&amp;\/~+#-])?/;
      if (!urlRegex.test(this.rssUrl)) {
        return;
      }
      const res = await fetch(`${this.rssUrl}`);
      const { contents } = await res.json();
      const feed = new window.DOMParser().parseFromString(contents, "text/xml");
      const items = feed.querySelectorAll("item");
      this.items = [...items].map((el) => ({
        link: el.querySelector("link").innerHTML,
        title: el.querySelector("title").innerHTML,
        author: el.querySelector("author").innerHTML,
      }));
    },
  },
};
</script> -->

<template>
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
      limit: 5,
      feedUrl2: "https://www.gadgets360.com/rss/smart-home/feeds",
      name2: "",
      limit2: 5,
      feedUrl3: "https://www.the-ambient.com/rss",
      name3: "",
      limit3: 5,
    };
  },
};
</script>
