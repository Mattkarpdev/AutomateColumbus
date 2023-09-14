<script setup>
import { RouterLink, RouterView } from 'vue-router'

</script>

<template>
  
  <header>
    <img alt="Vue logo" class="logo" src="https://cdn.pixabay.com/photo/2017/09/20/16/59/smart-home-2769239_1280.jpg" width="600" height="400" />

    <div class="wrapper">
      
      <h1 class="black">Automate Columbus</h1>
    <div></div>
      <nav>
        <RouterLink to="/">Home</RouterLink>
        <RouterLink to="/guides">Guides</RouterLink>
        <RouterLink to="/calculator">Calculator</RouterLink>
      </nav>
    </div>
  </header>

  <RouterView />

</template>

<style scoped>

header {
  line-height: 1.5;
  max-height: 100vh;
  background-color: rgb(207, 240, 252);
  align-content: center;
}

.logo {
  display: block;
  margin: 0 auto 2rem;
  
}

nav {
  width: 100%;
  font-size: 12px;
  text-align: center;
  margin-top: 2rem;
}

nav a.router-link-exact-active {
  color: var(--color-text);
}

nav a.router-link-exact-active:hover {
  background-color: transparent;
}

nav a {
  display: inline-block;
  padding: 0 1rem;
  border-left: 1px solid var(--color-border);
}

nav a:first-of-type {
  border: 0;
}

@media (min-width: 1024px) {
  header {
    display: grid;
    grid-area: auto;
    place-items: center;
    padding-right: calc(var(--section-gap) / 2);
  }

  .logo {
    margin: 0 2rem 0 0;
    
  }

  header .wrapper {
    display: flex;
    place-items: flex-start;
    flex-wrap: wrap;
  }

  nav {
    text-align: left;
    margin-left: -1rem;
    font-size: 1rem;

    padding: 1rem 0;
    margin-top: 1rem;
  }
}
</style>
