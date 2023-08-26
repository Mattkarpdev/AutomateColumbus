<script setup>
import { ref } from 'vue'
import CalculatorComponent from '../components/CalculatorComponent.vue'

const message = ref('')
</script>

<template>
    <div>
        <CalculatorComponent />
    </div>
    
</template>

<script>
export default {

}
const showQuote = ref(false)
;
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