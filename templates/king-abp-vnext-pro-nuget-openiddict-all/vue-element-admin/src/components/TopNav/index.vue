<template>
  <el-menu
    :default-active="activeMenu"
    mode="horizontal"
    @select="handleSelect"
  >
    <template v-for="(item, index) in topMenus">
      <el-menu-item
        :style="{ '--theme': theme }"
        :index="item.path"
        :key="index"
        v-if="index < visibleNumber"
      >
        <item
          v-if="item.meta"
          :icon="item.meta && item.meta.icon"
          :title="generateTitle(item.meta.title)"
        />
      </el-menu-item>
    </template>

    <!-- 顶部菜单超出数量折叠 -->
    <el-submenu
      :style="{ '--theme': theme }"
      index="more"
      v-if="topMenus.length > visibleNumber"
    >
      <template slot="title">更多菜单</template>
      <template v-for="(item, index) in topMenus">
        <el-menu-item
          :index="item.path"
          :key="index"
          v-if="index >= visibleNumber"
        >
          <item
            v-if="item.meta"
            :icon="item.meta && item.meta.icon"
            :title="generateTitle(item.meta.title)"
          />
        </el-menu-item>
      </template>
    </el-submenu>
  </el-menu>
</template>

<script>
import { constantRoutes } from "@/router";
import { mapGetters, mapState } from "vuex";
import { generateTitle } from "@/utils/i18n";
import Item from "@/layout/components/Sidebar/Item.vue";
export default {
  data() {
    return {
      // 顶部栏初始数
      visibleNumber: 5,
      // 是否为首次加载
      isFrist: false,
      // 当前激活菜单的 index
      currentIndex: undefined,
      activeMenuindex: "",
    };
  },
  components: {
    Item,
  },
  computed: {
    theme() {
      return this.$store.state.settings.theme;
    },
    ...mapGetters(["topbarRouters"]),
    // 顶部显示菜单 只显示一级菜单，如果一级菜单没有子菜单那么此一级菜单也可以点击
    topMenus() {
      let topMenus = [];

      this.routers.map((menu) => {
        if (menu.hidden !== true) {
          // 兼容顶部栏一级菜单内部跳转
          // if (menu.path === "/") {
          //   topMenus.push(menu.children[0]);
          // } else {
          //   topMenus.push(menu);
          // }
          topMenus.push(menu);
        }
      });
      let x = topMenus;
      debugger;
      return topMenus;
    },
    // 所有的路由信息
    routers() {
      return constantRoutes.concat(this.topbarRouters);
    },
    // 设置子路由
    childrenMenus() {
      var childrenMenus = [];
      this.routers.map((router) => {
        for (var item in router.children) {
          if (router.children[item].parentPath === undefined) {
            if (router.path === "/") {
              router.children[item].path = router.children[item].path;
            } else {
              if (!this.ishttp(router.children[item].path)) {
                router.children[item].path =
                  router.path + "/" + router.children[item].path;
              }
            }
            router.children[item].parentPath = router.path;
          }

          childrenMenus.push(router.children[item]);
        }
      });
      return constantRoutes.concat(childrenMenus);
    },
    // 默认激活的菜单
    activeMenu() {
      //当前的路由
      const path = this.$route.path;
      //获取默认激活的路由
      let activePath = this.defaultRouter();

      if (path.lastIndexOf("/") > 0) {
        const tmpPath = path.substring(1, path.length);
        activePath = "/" + tmpPath.substring(0, tmpPath.indexOf("/"));
      } else if ("/dashboard" == path || "" == path) {
        if (!this.isFrist) {
          this.isFrist = true;
        } else {
          activePath = "/";
        }
      }
      if (this.activeMenuindex != activePath) {
        var routes = this.activeRoutes(activePath);
        if (routes.length === 0) {
          activePath = this.currentIndex || this.defaultRouter();
          console.log("activePath", activePath);
          this.activeRoutes(activePath);
        }
      }
      this.activeMenuindex = activePath;
      return activePath;
    },
  },
  beforeMount() {
    window.addEventListener("resize", this.setVisibleNumber);
  },
  beforeDestroy() {
    window.removeEventListener("resize", this.setVisibleNumber);
  },
  mounted() {
    this.setVisibleNumber();
  },
  methods: {
    generateTitle,
    // 根据宽度计算设置显示栏数
    setVisibleNumber() {
      const width = document.body.getBoundingClientRect().width / 3;
      this.visibleNumber = parseInt(width / 85);
    },
    // 默认激活的路由
    defaultRouter() {
      let router;
      Object.keys(this.routers).some((key) => {
        if (!this.routers[key].hidden) {
          router = this.routers[key].path;
          return true;
        }
      });
      return router;
    },
    // 菜单选择事件
    handleSelect(key, keyPath) {
      this.currentIndex = key;
      if (this.ishttp(key)) {
        // http(s):// 路径新窗口打开
        window.open(key, "_blank");
      } else if (key.indexOf("/redirect") !== -1) {
        // /redirect 路径内部打开
        this.$router
          .push({ path: key.replace("/redirect", "") })
          .catch((err) => {});
      } else {
        // 显示左侧联动菜单
        this.activeRoutes(key);
      }
    },
    // 当前激活的路由
    activeRoutes(key) {
      var routes = [];
      if (this.childrenMenus && this.childrenMenus.length > 0) {
        this.childrenMenus.map((item) => {
          if (
            key == item.parentPath ||
            (key == "/" && "" == item.path)
          ) {
            routes.push(item);
          }
        });
      }
      if (routes.length > 0) {
        this.$store.commit("permission/SET_SIDEBAR_ROUTERS", routes);
      }
      return routes;
    },
    ishttp(url) {
      return url.indexOf("http://") !== -1 || url.indexOf("https://") !== -1;
    },
  },
};
</script>

<style lang="scss">
.topmenu-container.el-menu--horizontal > .el-menu-item {
  float: left;
  height: 50px !important;
  line-height: 50px !important;
  color: #999093 !important;
  padding: 0 5px !important;
  margin: 0 10px !important;
}

.topmenu-container.el-menu--horizontal > .el-menu-item.is-active,
.el-menu--horizontal > .el-submenu.is-active .el-submenu__title {
  border-bottom: 2px solid #{"var(--theme)"} !important;
  color: #303133;
}

/* submenu item */
.topmenu-container.el-menu--horizontal > .el-submenu .el-submenu__title {
  float: left;
  height: 50px !important;
  line-height: 50px !important;
  color: #999093 !important;
  padding: 0 5px !important;
  margin: 0 10px !important;
}
</style>
