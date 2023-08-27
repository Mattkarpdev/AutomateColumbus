<script setup>
import { ref } from 'vue'
import QuoteComponent from './QuoteComponent.vue';
const message = ref('')
</script>

<template>
    <form @submit.prevent="postUserInput" v-if="showCalculator">
        <div>
            <label>Windows: </label>
            <input type="number" placeholder="number of windows" v-model="windows" />
        </div>
        <div>
            <label>Doors: </label>
            <input type="number" placeholder="number of doors" v-model="doors" />
        </div>
        <div>
            <label>Video Doorbell: </label>
            <input type="number" placeholder="video doorbell" v-model="doorbells" />
        </div>
        <div>
            <button @click="showQuote = true" type="submit" > Calculate Cost</button>
        </div>
    </form >
    <div v-if="showQuote" > HI </div>
</template>

<script>
const showQuote = ref(false)
const showCalculator = ref(true)


import axios from 'axios';
export default {
    data() {
        return {

            inputId: 0,
            date: "2023-08-23T21:32:12.399Z",
            email: "string",
            phoneNumber: "string",
            name: "string",
            num_windows: 0,
            num_doors: 0,
            video_doorbell: 0,
            cost: 1
        }

    },
    methods: {
        postUserInput() {
            axios.post('https://localhost:7287/api/UserInputs',
                {
                    num_windows: this.windows,
                    num_doors: this.doors,
                    video_doorbell: this.doorbells,
                    date: this.date,
                    cost: this.cost
                }
            ).then(response => { console.log(response) })
        }
    }
};
</script>
<style scoped>
form {
    margin-top: 2rem;
    display: flex;
    position: relative;
    flex-direction: column;
}



i {
    display: flex;
    place-items: center;
    place-content: center;
    width: 32px;
    height: 32px;
    color: var(--color-text);
}

h3 {
    font-size: 1.2rem;
    font-weight: 500;
    margin-bottom: 0.4rem;
    color: var(--color-heading);
}

@media (min-width: 1024px) {
    main {
        margin-top: 2rem;
        display: flex;
        flex-direction: column;
    }


}
</style>