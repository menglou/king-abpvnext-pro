<template>
  <div class="app-container">
    <div class="updownview">
      <div class="up">
        <slot name="up" />
      </div>
      <div class="down">
        <slot name="down" />
      </div>
    </div>
  </div>
</template>

<script>
const throttle = (fn, time) => {
  let timer = null;
  return (...args) => {
    if (!timer) {
      timer = setTimeout(() => {
        timer = null;
        fn.apply(this, args);
      }, time);
    }
  };
};
import { mapState } from "vuex";
export default {
  name: "Updowspanel",
  data() {
    return {
      downkey: new Date().getTime(),
      fn: throttle(this.getAutoHeight, 400),
    };
  },
  computed: {
    ...mapState({
      needTagsView: (state) => state.settings.tagsView,
    }),
  },
  props: {
    ispager: {
      Type: Boolean,
      Default: true,
    },
    isvxetoolbar: {
      Type: Boolean,
      Default: true,
    },
  },
  // 监听是否有 tag-view
  watch: {
    needTagsView(newVal, oldVal) {
      if (newVal) {
        window.addEventListener("resize", this.fn);
      } else {
        window.removeEventListener("resize", this.fn);
      }
      if (document.querySelector(".updownview")) {
        this.fn();
      }
    },
  },
  mounted() {
    this.getAutoHeight();
    window.addEventListener("resize", this.fn);
  },
  activated() {
    window.addEventListener("resize", this.fn);
  },
  deactivated() {
    window.removeEventListener("resize", this.fn);
  },
  methods: {
    getAutoHeight() {
      const elup = document.querySelector(".up"); // 拿到up 的高度
      const eldown = document.querySelector(".down"); // 拿到up 的高度
      let vxetoolbar;
      if (this.isvxetoolbar != false) {
        vxetoolbar = document.querySelector(".vxe-toolbar"); // 拿到vxe-toolbar 的高度
      }

      let vxepager;
      if (this.ispager != false) {
        vxepager = document.querySelector(".vxe-pager"); // 拿到up 的高度
      }
      const pelpar = eldown.parentNode;
      this.$nextTick(() => {
        let height;
        height =
          pelpar.offsetHeight -
          (elup.offsetHeight +
            (this.isvxetoolbar != false ? vxetoolbar.offsetHeight : 0) +
            (this.ispager != false ? vxepager.offsetHeight : 0) +
            22 +
            10);

        this.$emit("setTableHeight", height);
      });
    },
    // 获取样式 我们需要减掉 padding-top， padding-bottom的值
    getStyle(obj, attr) {
      // 兼容IE浏览器
      const result = obj.currentStyle
        ? obj.currentStyle[attr].replace("px", "")
        : document.defaultView
            .getComputedStyle(obj, null)
            [attr].replace("px", "");
      return Number(result);
    },
  },
};
</script>

<style scoped lang="scss">
//没有tag 时候的高度
.updownview {
  //min-height: calc(100vh - 70px);
  //max-height: calc(100vh - 70px);
  height: calc(100vh - 70px);
  width: 100%;
  display: flex;
  flex-direction: column;
  width: 100%;
}

//有 tag 的时候 高度
.hasTagsView {
  .updownview {
    /* 84 = navbar + tags-view = 50 + 34+ top:10 + bottom:10 */
    //min-height: calc(100vh - 104px);
    //max-height: calc(100vh - 104px);
    height: calc(100vh - 104px);
    display: flex;
    flex-direction: column;
    width: 100%;
  }
}
.up {
  width: 100%;
  border-radius: 5px;
  box-shadow: 0 2px 12px 0 rgba(0, 0, 0, 0.1);
  border-radius: 4px;
  border: 1px solid #e6ebf5;
  background-color: #ffffff;
  overflow: hidden;
  color: #303133;
  -webkit-transition: 0.3s;
  transition: 0.3s;
  padding: 15px 20px 15px 20px;
  display: inline-flex;
  align-items: center;
  height: auto;
  margin-bottom: 8px;
  min-height: 80px;
}
.down {
  height: auto;
  border-radius: 5px;
  box-shadow: 0 2px 12px 0 rgba(0, 0, 0, 0.1);
  border-radius: 4px;
  border: 1px solid #e6ebf5;
  background-color: #ffffff;
  color: #303133;
  -webkit-transition: 0.3s;
  transition: 0.3s;
  padding: 11px;
  display: flex;
  flex-direction: column;
  overflow-y: auto;
}
</style>
