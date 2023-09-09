<script setup>
import { ref } from 'vue'
import { RouterLink, RouterView } from 'vue-router'


const message = ref('')
</script>

<template>
    <div class="container">
        <h2>
            <RouterLink to="/guides/ringalarmguide" class="link-opacity-25-hover"> Ring Alarm Guide
        </RouterLink>
        </h2>
     
    </div>
    
</template>


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