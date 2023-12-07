<script setup>
import { computed, onMounted, ref } from "vue";
import MazPhoneNumberInput from "maz-ui/components/MazPhoneNumberInput";
const message = ref("");
</script>

<template>
  <div class="flex justify-center p-4" id="installationCalculator">
    <h2 class="font-title text-3xl">Cost Estimator</h2>
  </div>
  <div class="font-main xl:container xl:mx-auto xl:px-44">
    <div class="container mx-auto flex justify-center px-44">
      <form
        class="flex w-80 flex-col rounded-lg border-2 border-blue-n"
        :class="{ active: showQuote }"
        @submit.prevent="postUserInput"
        v-if="showCalculator"
      >
        <div class="text-xl">
          <div class="flex flex-col p-5">
            <label>Windows: </label>
            <input
              class="rounded-lg text-2xl"
              min="0"
              type="number"
              placeholder="number of windows"
              v-model="windows"
            />
          </div>
          <div class="flex flex-col p-5">
            <label>Doors: </label>
            <input
              class="rounded-lg text-2xl"
              min="0"
              type="number"
              placeholder="number of doors"
              v-model.number="doors"
            />
          </div>
          <div class="flex flex-col p-5">
            <label>Video Doorbell: </label>
            <input
              class="rounded-lg text-2xl"
              type="number"
              min="0"
              placeholder="video doorbell"
              v-model="doorbells"
            />
          </div>
        </div>
        <div class="p-7 pl-5">
          <button
            class="rounded-md border-2 border-blue-n p-1 hover:scale-110"
            @click="showQuote = true"
            type="submit"
          >
            Calculate Cost
          </button>
        </div>
      </form>
    </div>
    <div class="flex p-5 font-main" v-show="showQuote">
      <div class="basis-1/2 p-5">
        <div v-show="apiLimit">{{ apiLimit }}</div>
        <div class="text-2xl">Your security system componets are</div>
        <ul class="p-4 text-xl">
          <li>{{ quote.num_doors + quote.num_windows }} contact sensors</li>
          <li>{{ quote.video_doorbell }} video doorbell</li>
          <li>2 motion sensors</li>
          <li>1 hub</li>
          <li>1 keypad</li>
        </ul>
        <p class="p-4 pt-3 text-2xl">
          Estimated cost of equipment: ${{ quote.cost_equipment }}.00
        </p>
        <p class="p-4 pt-3 text-2xl">
          Estimated cost of install: ${{ quote.cost_install }}.00
        </p>
        <p class="p-2 text-xl">
          Please check out our guides for information on the differnt smart
          ecosystems.
        </p>
      </div>
      <div class="flex basis-1/2 flex-col">
        <p class="p-4 text-lg">
          If you would like to be contacted regarding a home automation
          installation in Central Ohio, please provide your name, phone number
          or email and we will contact you.
        </p>
        <form class="" @submit.prevent="putUserInfo">
          <div class="flex flex-col p-4 pt-3 text-lg">
            <label>Name: </label>
            <input
              type="text"
              class="rounded-md text-xl"
              placeholder="Name"
              v-model="name"
            />
          </div>
          <div class="flex flex-col p-4 pt-3 text-lg">
            <label>Email: </label>
            <input
              class="rounded-md text-xl"
              type="text"
              placeholder="example@email.com"
              v-model="email"
            />
          </div>
          <div class="p-4 pt-3">
            <label class="text-lg">Phone Number: </label>
            <MazPhoneNumberInput
              class=""
              v-model="phoneNumber"
              @update="resultsTel = $event.formatNational"
            />
          </div>

          <div class="flex p-4">
            <button
              class="h-14 basis-1/3 rounded-md border-2 p-1 hover:scale-110"
              type="submit"
              @click="showThankYou = true"
            >
              Submit Contact Info
            </button>
            <div class="basis-2/3 py-1 pl-10" v-show="showThankYou">
              Thank you for submitting contact info, we will reach out to you
              shortly.
            </div>
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
const showThankYou = ref(false);
const quoteCost = ref(1);
const phoneNumber = ref();

import axios from "axios";

export default {
  data() {
    return {
      userInput: {
        input_id: 1,
        date: "2023-08-23T21:32:12.399Z",
        email: "string",
        phone_number: "string",
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
      const resultsTel = ref();
      await axios
        .post("https://localhost:7287/api/QuoteInput/", {
          input_id: this.quote.input_id,
          name: this.name,
          email: this.email,
          phone_number: this.resultsTel,
        })
        .then((response) => (this.quote = response.data));
    },
  },
  computed: {},
};
</script>
<style scoped>
.active {
  border-color: #b0d0eb;
}
</style>
