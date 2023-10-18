<script setup>
import { ref } from 'vue'
import { RouterLink, RouterView } from 'vue-router'


const message = ref('')
</script>

<template>
    <div class="container">
        <h2>
            <RouterLink to="/guides/DoorbellGuide" class="link-opacity-25-hover"> Ring Alarm Guide
        </RouterLink>
        </h2>
    
    </div>

</template>


<style scoped>

</style>