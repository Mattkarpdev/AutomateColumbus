<template>
  <div>
    <div class="flex bg-blue-n">
      <div class="flex flex-row px-8 pt-4 font-bold">
        <div>
          <img
            class="h-20 object-contain p-0"
            src="src/assets/LogoAC.png"
            alt=""
          />
        </div>
        <!-- <div class="p-2 text-4xl text-white">
          Automate
          <div class="text-black p-2 text-3xl">Automate</div>
        </div>
        <div class="p-2 text-3xl text-white">Columbus</div> -->
      </div>
      <nav class="flex">
        <ul
          class="text-yellow flex snap-y items-center font-title text-2xl text-white/90"
        >
          <li><a class="p-3" href="#news">News</a></li>
          <li><a class="p-3" href="#guide">Guides</a></li>

          <li>
            <a class="p-3" href="#installationCalculator">Cost Estimator</a>
          </li>
        </ul>
      </nav>
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
