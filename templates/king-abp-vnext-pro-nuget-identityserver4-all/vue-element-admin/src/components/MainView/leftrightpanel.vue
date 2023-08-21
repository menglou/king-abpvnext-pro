<template>
  <div class="app-container">
    <div class="leftrightview">
      <el-row :gutter="3">
        <el-col :xs="24" :sm="9" :md="7" :lg="6" :xl="5">
          <div class="left">
            <slot name="left" />
          </div>
        </el-col>
        <el-col :xs="24" :sm="15" :md="17" :lg="18" :xl="19">
          <div class="right">
            <div v-show="ishastitle" class="header-line">
              <i class="el-icon-office-building" />
              <label style="font-size: 14px; margin-left: 3px">{{
                title
              }}</label>
            </div>
            <div style="padding: 10px; height: 100%">
              <slot name="right" />
            </div>
            <!-- <div class="header-line"></div> -->
          </div>
        </el-col>
      </el-row>
    </div>
  </div>
</template>

<script>
const throttle = (fn, time) => {
  let timer = null
  return (...args) => {
    if (!timer) {
      timer = setTimeout(() => {
        timer = null
        fn.apply(this, args)
      }, time)
    }
  }
}
import { mapState } from 'vuex'
export default {
  name: 'Leftrightpanel',
  props: {
    title: {
      Type: String,
      Default: ''
    },
    ishastitle: {
      Type: Boolean,
      Default: true
    },
    istab: {
      Type: Boolean,
      Default: false
    },
    activename: {
      Type: String,
      Default: ''
    },
    istoolbar: {
      Type: Boolean,
      Default: true
    }
  },
  data() {
    return {
      changekey: new Date().getTime(),
      fn: throttle(this.getAutoHeight, 400)
    }
  },
  computed: {
    ...mapState({
      needTagsView: (state) => state.settings.tagsView
    })
  },
  // 监听是否有 tag-view
  watch: {
    needTagsView(newVal, oldVal) {
      // if (newVal) {
      //   window.addEventListener("resize", this.fn);
      // } else {
      //   window.removeEventListener("resize", this.fn);
      // }
      if (document.querySelector('.leftrightview')) {
        this.fn()
      }
    }
  },
  mounted() {
    this.getAutoHeight()
    window.addEventListener('resize', this.fn)
    // window.onresize = function () {
    //   setTimeout(function () {
    //     self.getAutoHeight();
    //   }, 400);
    // };
  },
  activated() {
    window.addEventListener('resize', this.fn)
  },
  deactivated() {
    window.removeEventListener('resize', this.fn)
  },
  methods: {
    getAutoHeight() {
      const elleft = document.querySelector('.left') // 拿到left的高度
      const elright = document.querySelector('.right') // 拿到right 的高度

      const elorgheader = document.querySelector('.left-header') // 拿到org header 的高度

      let elrightheader, vxetoobar, vxepager
      if (this.istab) {
        elrightheader = document.querySelector(
          '#' + this.activename + '>.right-header'
        ) // 拿到table header 的高度
        vxetoobar = document.querySelector(
          '#' + this.activename + '>.vxe-toolbar'
        ) // table 工具栏的高度
        vxepager = document.querySelector(
          '#' + this.activename + '>.vxe-pager'
        ) // 分页组件的高度
      } else {
        elrightheader = document.querySelector('.right-header') // 拿到table header 的高度
        vxetoobar = document.querySelector('.vxe-toolbar') // table 工具栏的高度
        vxepager = document.querySelector('.vxe-pager') // 分页组件的高度
      }
      let heightorg
      let heighttables
      this.$nextTick(() => {
        // org的高度计算 // clas 为left 的clientHeight -  查询header的clientHeight - tree的 上下的padding
        // this.heights.heightorg = elleft.offsetHeight - (elorgheader.offsetHeight + 20);
        heightorg = elleft.offsetHeight - elorgheader.offsetHeight - 20

        // this.$parent.setOrgHeight(
        //   elleft.offsetHeight - (elorgheader.offsetHeight + 20)
        // );
        // this.$set()
        // this.$parent.orgheight=elleft.offsetHeight - (elorgheader.offsetHeight + 20);
        // debugger
        this.$emit('setOrgHeight', heightorg)

        // 拿到 class 为 leftrightview 的高度
        const parel = elright.parentNode.parentNode.parentNode

        // table的高度计算

        // clas 为right 的clientHeight -  查询header的clientHeight - left 上下的padding

        // 基本高度=clas 为right 的clientHeight- 查询header的clientHeight+ pading+header.padding+toolbar高度+pageg高度
        // let heighttables =
        //   parel.clientHeight -
        //   (elrightheader.clientHeight +
        //     vxetoobar.clientHeight +
        //     vxepager.clientHeight +
        //     20
        //     );
        // header + rightheader + toolbar+ padding-top+padding-bottom
        // let heighttables =
        //   parel.clientHeight - (33 + 32 + 33 + 27.95 + 10 + 10);
        heighttables =
          parel.offsetHeight -
          (elrightheader.offsetHeight +
            vxetoobar.offsetHeight +
            vxepager.offsetHeight +
            21)

        // let heighttables =
        //   parel.clientHeight -
        //   (elrightheader.clientHeight +
        //     vxetoobar.clientHeight + 20+
        //     vxepager.clientHeight+20);

        if (this.ishastitle) {
          const headerline = document.querySelector('.header-line')
          heighttables = heighttables - headerline.offsetHeight
        }
        if (this.istab == true) {
          const tabs = document.querySelector('.el-tabs__nav')
          heighttables = heighttables - tabs.offsetHeight
        }
        this.$emit('setTableHeight', heighttables)
        debugger
      })
    },
    // 获取样式 我们需要减掉 padding-top， padding-bottom的值
    getStyle(obj, attr) {
      // 兼容IE浏览器
      const result = obj.currentStyle
        ? obj.currentStyle[attr].replace('px', '')
        : document.defaultView
          .getComputedStyle(obj, null)
          [attr].replace('px', '')
      return Number(result)
    }
  }
}
</script>

<style scoped lang="scss">
//没有tag 时候的高度
.leftrightview {
  //min-height: calc(100vh - 70px);
  height: calc(100vh - 70px);
  width: 100%;
  .left {
    height: calc(100vh - 70px);
    border-radius: 5px;
    box-shadow: 0 2px 12px 0 rgba(0, 0, 0, 0.1);
    border-radius: 4px;
    border: 1px solid #e6ebf5;
    background-color: #ffffff;
    color: #303133;
    -webkit-transition: 0.3s;
    transition: 0.3s;
    padding: 0px 10px;
    display: flex;
    flex-direction: column;
    //justify-content: center;
    width: 100%;
  }
  .right {
    height: auto;
    border-radius: 5px;
    box-shadow: 0 2px 12px 0 rgba(0, 0, 0, 0.1);
    border-radius: 4px;
    border: 1px solid #e6ebf5;
    background-color: #ffffff;
    color: #303133;
    -webkit-transition: 0.3s;
    transition: 0.3s;
    //padding: 10px;
    display: flex;
    flex-direction: column;
    justify-content: center;
    width: 100%;
  }
}

//有 tag 的时候 高度
.hasTagsView {
  .leftrightview {
    /* 84 = navbar + tags-view = 50 + 34+ top:10 + bottom:10 */
    //min-height: calc(100vh - 104px);
    height: calc(100vh - 104px);
    width: 100%;
  }
  .left {
    height: calc(100vh - 104px);
    border-radius: 5px;
    box-shadow: 0 2px 12px 0 rgba(0, 0, 0, 0.1);
    border-radius: 4px;
    border: 1px solid #e6ebf5;
    background-color: #ffffff;
    color: #303133;
    -webkit-transition: 0.3s;
    transition: 0.3s;
    padding: 0px 10px;
    display: flex;
    flex-direction: column;
    //justify-content: center;
    width: 100%;
  }
  .right {
    height: auto;
    //height: calc(100vh - 104px);
    border-radius: 5px;
    box-shadow: 0 2px 12px 0 rgba(0, 0, 0, 0.1);
    border-radius: 4px;
    border: 1px solid #e6ebf5;
    background-color: #ffffff;
    color: #303133;
    -webkit-transition: 0.3s;
    transition: 0.3s;
    // padding: 10px;
    display: flex;
    flex-direction: column;
    justify-content: center;
    width: 100%;
  }
}
.header-line {
  height: 32px;
  border-bottom: 1px solid #eee;
  padding-left: 10px;
  display: flex;
  flex-direction: row;
  justify-content: flex-start;
  align-items: center;
}
</style>
