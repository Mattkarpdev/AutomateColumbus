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
            <button @click=getUserInputById type="submit"> Calculate Cost</button>
        </div>
    </form>

    <div>

        {{ quote.cost }}

        <form @submit.prevent="putUserInfo">
            <div>
                <label>Name: </label>
                <input type="text" placeholder="Name" v-model="name" />
            </div>
            <div>
                <label>Email: </label>
                <input type="text" placeholder="Email" v-model="email" />
            </div>
            <div>
                <label>Phone Number: </label>
                <input type="text" placeholder="Phone Number" v-model="phoneNumber" />
            </div>
            <div>
                <button type="submit"> submit contact info </button>
            </div>
        </form>

    </div>
</template>

<script>

const showCalculator = ref(true)
const showQuote = ref(false)
const quoteCost = ref(1)
import axios from 'axios';
export default {
    data() {
        return {
            userInput:
            {
                input_id: 1,
                date: "2023-08-23T21:32:12.399Z",
                email: "string",
                phoneNumber: "string",
                name: "string",
                num_windows: 0,
                num_doors: 0,
                video_doorbell: 0,
                cost: 1
            },
            inputResponse: [],
            quote: [],
        }

    },
    methods: {
        async postUserInput() {
            await axios.post('https://localhost:7287/api/UserInputs',
                {
                    num_windows: this.windows,
                    num_doors: this.doors,
                    video_doorbell: this.doorbells,
                    date: this.date,
                    cost: this.cost
                }
            ).then
                (response => this.inputResponse = response.data
                )

        },
        async getUserInputById() {
            await axios.get('https://localhost:7287/api/UserInputs/' + this.inputResponse.input_id)
                .then(response => this.quote = response.data
                )
        },
        async putUserInfo() {
            await axios.post('https://localhost:7287/api/QuoteInput/',
                {
                    input_id: this.quote.input_id,
                    name: this.name,
                    email: this.email,
                    phoneNumber: this.phoneNumber
                }

            ).then
            (response => this.quote = response.data
                )
        }

    },
    computed: {


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