<template>
  <div id="news" class="d-flex justify-content-center p-5">
    <h2>News</h2>
    <div class="p-2">
      <div class="card" style="width: 18rem">
        <img
          src="https://www.the-sun.com/wp-content/uploads/sites/6/2022/09/LG-RING-DOORBELL-COMP.jpg?w=1280&quality=44"
          class="card-img-top"
          alt="..."
        />
        <div class="card-body">
          <h5 class="card-title">Video Doorbell</h5>
          <p class="card-text">
            Video doorbells have bad picture, amazon needs to make them better.
          </p>
          <RouterLink
            to="../src/components/guides/DoorbellGuide.vue"
            class="btn btn-primary"
            >Go somewhere
          </RouterLink>
        </div>
      </div>
    </div>
    <div class="p-2">
      <div class="card" style="width: 18rem">
        <img
          src="https://cdn.idealo.com/folder/Product/201534/5/201534593/s3_produktbild_max/ring-alarm-kit-2nd-gen.jpg"
          class="card-img-top"
          alt="..."
        />
        <div class="card-body">
          <h5 class="card-title">Card title</h5>
          <p class="card-text">
            Some quick example text to build on the card title and make up the
            bulk of the card's content.
          </p>
          <a href="#" class="btn btn-primary">Go somewhere</a>
        </div>
      </div>
    </div>
    <div class="p-2" id="guide">
      <div class="card" style="width: 18rem">
        <img
          src="https://u-tec.com/cdn/shop/t/57/assets/sence-banner.png?v=175755877485102375081689760851"
          class="card-img-top"
          alt="..."
        />
        <div class="card-body">
          <h5 class="card-title">Card title</h5>
          <p class="card-text">
            Some quick example text to build on the card title and make up the
            bulk of the card's content.
          </p>
          <a href="#" class="btn btn-primary">Go somewhere</a>
        </div>
      </div>
    </div>
  </div>
</template>
