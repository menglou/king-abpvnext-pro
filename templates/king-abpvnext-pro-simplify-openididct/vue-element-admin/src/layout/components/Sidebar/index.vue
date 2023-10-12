<template>
  <div
    :class="{ 'has-logo': showLogo }"
    :style="{
      backgroundColor:
        settings.sideTheme === 'theme-dark'
          ? variables.menuBackground
          : variables.menuLightBackground,
    }"
  >
    <logo v-if="showLogo" :collapse="isCollapse" />
    <el-scrollbar wrap-class="scrollbar-wrapper" :class="settings.sideTheme">
      <el-menu
        :default-active="activeMenuIndex"
        :collapse="isCollapse"
         :background-color="
          settings.sideTheme === 'theme-dark'
            ? variables.menuBackground
            : variables.menuLightBackground
        "
        :text-color="
          settings.sideTheme === 'theme-dark'
            ? variables.menuColor
            : variables.menuLightColor
        "
        :unique-opened="true"
        :active-text-color="settings.theme"
        :collapse-transition="false"
        mode="vertical"
      >
        <sidebar-item
          v-for="route in sidebarRouters"
          :key="route.path"
          :item="route"
          :base-path="route.path"
        />
      </el-menu>
    </el-scrollbar>
  </div>
</template>

<script>
import { mapGetters,mapState } from "vuex";
import Logo from "./Logo";
import SidebarItem from "./SidebarItem";
import variables from "@/styles/variables.scss";

export default {
  data() {
    return {
      activeMenuIndex: "",
    };
  },
  components: { SidebarItem, Logo },
  watch: {
    sidebarRouters(oldvalue, newvalue) {
      if (this.$store.state.settings.topNav) {
        debugger;
        let visitedViews = this.$store.state.tagsView.visitedViews;
        let visitedpath = null;
        let ishave = false;
        if (visitedViews.length > 0) {
          for (let i of visitedViews) {
            if (i.path.indexOf(oldvalue[0].parentPath) != -1) {
              ishave = true;
              visitedpath = i;
              break;
            }
          }
          if (!ishave) {
            this.activeMenu = oldvalue[0].path;
          } else {
            this.activeMenu = visitedpath.path;
          }
        } else {
          this.activeMenu = oldvalue[0].path;
        }
      }
    },
  },
  computed: {
    ...mapState(["settings"]),
    ...mapGetters(["sidebarRouters", "sidebar"]),
    activeMenu: {
      get() {
        const route = this.$route;
        const { meta, path } = route;
        // if set path, the sidebar will highlight the path you set
        if (meta.activeMenu) {
          this.activeMenuIndex = meta.activeMenu;
          return this.activeMenuIndex;
        }
        this.activeMenuIndex = path;
        return this.activeMenuIndex;
      },
      set(val) {
        if (val.substring(0, 1) == "/") {
          this.activeMenuIndex = val;
          this.$router.push(val).catch((err) => err);
        } else {
          this.activeMenuIndex = "/" + val;
          this.$router.push("/" + val).catch((err) => err);
        }
      },
    },
    showLogo() {
      return this.$store.state.settings.sidebarLogo;
    },
    variables() {
      return variables;
    },
    isCollapse() {
      return !this.sidebar.opened;
    },
  },
};
</script>
