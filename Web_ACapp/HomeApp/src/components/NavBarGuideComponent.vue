<script setup></script>
<template>
  <div>
    <div class="flex justify-between bg-blue-n">
      <div class="flex flex-row px-8 pt-4 font-bold">
        <div>
          <img
            class="h-20 object-contain p-0"
            src="../assets/LogoAC.png"
            alt=""
          />
        </div>
        <!-- <div class="p-2 text-4xl text-white">
          Automate
          <div class="text-black p-2 text-3xl">Automate</div>
        </div>
        <div class="p-2 text-3xl text-white">Columbus</div> -->
      </div>
      <div class="self-center pr-28 font-title text-2xl text-white/90">
        <button class="p-3" @click="$router.push('/')">Home</button>
      </div>
    </div>
  </div>
</template>

<style>
nav {
  position: absolute;
  right: 30px;
  align-self: center;
}
</style>
