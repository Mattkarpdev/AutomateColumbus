<script setup>
import { computed, onMounted, ref } from "vue";

const message = ref("");
</script>

<template>
  <div class="flex justify-center p-4" id="installationCalculator">
    <h2 class="font-title text-3xl">Cost Estimator</h2>
  </div>
  <div class="container mx-auto px-44 font-main">
    <div class="flex justify-center">
      <form
        class="flex w-80 flex-col rounded-lg border-2 border-blue-n"
        @submit.prevent="postUserInput"
        v-if="showCalculator"
      >
        <div class="text-xl">
          <div class="flex flex-col p-5">
            <label>Windows: </label>
            <input
              type="number"
              placeholder="number of windows"
              v-model="windows"
            />
          </div>
          <div class="flex flex-col p-5">
            <label>Doors: </label>
            <input
              type="number"
              placeholder="number of doors"
              v-model.number="doors"
            />
          </div>
          <div class="flex flex-col p-5">
            <label>Video Doorbell: </label>
            <input
              type="number"
              placeholder="video doorbell"
              v-model="doorbells"
            />
          </div>
        </div>
        <div class="p-7 pl-5">
          <button
            class="rounded-md border-2"
            @click="showQuote = true"
            type="submit"
          >
            Calculate Cost
          </button>
        </div>
      </form>
    </div>
    <div class="flex p-5 font-main">
      <div v-show="showQuote" class="basis-1/2">
        <div v-show="apiLimit">{{ apiLimit }}</div>
        <div class="text-2xl">
          You are looking for Security system that will contain a hub, key pad,
          2 motion sensors and {{ quote.num_doors + quote.num_windows }} contact
          sensors.
        </div>
        <p>cost of equipment: {{ quote.cost_equipment }}</p>
        <p>cost of install: {{ quote.cost_install }}</p>
      </div>
      <div v-show="showQuote" class="flex basis-1/2 flex-col">
        <form class="" @submit.prevent="putUserInfo">
          <div class="p-5">
            <label>Name: </label>
            <input type="text" placeholder="Name" v-model="name" />
          </div>
          <div class="p-5">
            <label>Email: </label>
            <input type="text" placeholder="Email" v-model="email" />
          </div>
          <div class="p-5">
            <label>Phone Number: </label>
            <input
              type="text"
              placeholder="Phone Number"
              v-model="phoneNumber"
            />
          </div>
          <div>
            <button class="rounded-md border-2" type="submit">
              submit contact info
            </button>
          </div>
        </form>
      </div>
    </div>
  </div>
</template>

<script>
const apiLimit = ref(false);
const showCalculator = ref(true);
const showQuote = ref(false);
const quoteCost = ref(1);

import axios from "axios";
export default {
  data() {
    return {
      userInput: {
        input_id: 1,
        date: "2023-08-23T21:32:12.399Z",
        email: "string",
        phoneNumber: "string",
        name: "string",
        num_windows: 0,
        num_doors: 0,
        video_doorbell: 0,
        cost_install: 1,
        cost_equipment: 1,
      },
      inputResponse: [],
      quote: [],
      doors: 0,
      windows: 0,
      doorbells: 0,
      contactSensorTotal: 0,
    };
  },

  methods: {
    async postUserInput() {
      await axios
        .post("https://localhost:7287/api/UserInputs", {
          num_windows: this.windows,
          num_doors: this.doors,
          video_doorbell: this.doorbells,
          date: new Date(),
          cost_install: this.cost_install,
          cost_equipment: this.cost_equipment,
        })

        .then((response) => (this.inputResponse = response.data));
      await axios
        .get(
          "https://localhost:7287/api/UserInputs/" +
            this.inputResponse.input_id,
        )
        .then((response) => (this.quote = response.data))
        .catch(function (error) {
          if (error.response) {
            // The request was made and the server responded with a status code
            // that falls out of the range of 2xx
            console.log(error.response.data);
            console.log(error.response.status);
            console.log(error.response.headers);
          } else if (error.request) {
            // The request was made but no response was received
            // `error.request` is an instance of XMLHttpRequest in the browser and an instance of
            // http.ClientRequest in node.js
            console.log(error.request);
          } else {
            // Something happened in setting up the request that triggered an Error
            console.log("Error", error.message);
          }
          console.log(error.config);
        });
    },
    async getUserInputById() {
      await axios
        .get(
          "https://localhost:7287/api/UserInputs/" +
            this.inputResponse.input_id,
        )
        .then((response) => (this.quote = response.data));
    },
    async putUserInfo() {
      await axios
        .post("https://localhost:7287/api/QuoteInput/", {
          input_id: this.quote.input_id,
          name: this.name,
          email: this.email,
          phoneNumber: this.phoneNumber,
        })
        .then((response) => (this.quote = response.data));
    },
  },
  computed: {},
};
</script>
<style scoped></style>
