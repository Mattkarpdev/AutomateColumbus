<script setup>
import { computed, ref } from "vue";
import { RouterLink, RouterView } from "vue-router";

import markdownit from "markdown-it";

const md = markdownit();

const result =
  md.render(`# hi A brief description of what this project does and who it's for

## my name

is iesha Appendix Any additional information goes here.

#### kjsahdkjshdlashdas;ihd'asojdSAOPjdhg/ausSFhIdhf:OJhF/HI?lfg/had;fh/lhf/ljdhF/;k`);
</script>
<template>
  <div v-html="result"></div>
</template>

<script></script>
<style></style>
