<template>
  <div class="navbar">
    <hamburger
      id="hamburger-container"
      :is-active="sidebar.opened"
      class="hamburger-container"
      @toggleClick="toggleSideBar"
    />

    <breadcrumb
      v-if="!topNav"
      id="breadcrumb-container"
      class="breadcrumb-container"
    />
    <top-nav v-if="topNav" id="topmenu-container" class="topmenu-container" />
    <div class="right-menu">
      <template v-if="device !== 'mobile'">
        <search id="header-search" class="right-menu-item" />

        <error-log class="errLog-container right-menu-item hover-effect" />
        <i
          v-if="showSettings"
          class="el-icon-setting setting-icon"
          @click="showSettingPanel = !showSettingPanel"
        >
          <right-panel
            :show-panel="showSettingPanel"
            @closesettingPanel="closesettingPanel"
          >
            <settings />
          </right-panel>
        </i>
        <screenfull id="screenfull" class="right-menu-item hover-effect" />

        <el-tooltip
          :content="$t('Openiddict[\'Navbar:Size\']')"
          effect="dark"
          placement="bottom"
        >
          <size-select id="size-select" class="right-menu-item hover-effect" />
        </el-tooltip>

        <lang-select class="right-menu-item hover-effect" />
      </template>

      <!-- 通知 -->
      <div v-if="device !== 'mobile'" class="right-menu-item hover-effect">
        <el-popover
          v-model="isShowUserNewsPopover"
          placement="bottom"
          trigger="click"
          width="350"
        >
          <el-badge
            slot="reference"
            :is-dot="true"
            @click.stop="showSettingPanel = !showSettingPanel"
          >
            <i class="el-icon-bell" title="通知" />
          </el-badge>
          <Notice
            v-show="isShowUserNewsPopover"
            :messagelist="messagelist"
            :notificationlist="notificationlist"
          />
        </el-popover>
      </div>

      <el-dropdown
        class="avatar-container right-menu-item hover-effect"
        trigger="click"
      >
        <div class="avatar-wrapper">
          <img :src="avatar" class="user-avatar">
          <i class="el-icon-caret-bottom" />
        </div>
        <el-dropdown-menu slot="dropdown">
          <router-link to="/profile/index">
            <el-dropdown-item>
              {{ $t("Openiddict['Navbar:Profile']") }}
            </el-dropdown-item>
          </router-link>
          <router-link to="/">
            <el-dropdown-item>
              {{ $t("Openiddict['Navbar:Dashboard']") }}
            </el-dropdown-item>
          </router-link>
          <el-dropdown-item divided @click.native="logout">
            <span style="display: block">{{
              $t("Openiddict['Navbar:LogOut']")
            }}</span>
          </el-dropdown-item>
        </el-dropdown-menu>
      </el-dropdown>
    </div>
  </div>
</template>

<script>
import { mapGetters } from 'vuex'
import { mapState } from 'vuex'
import Breadcrumb from '@/components/Breadcrumb'
import TopNav from '@/components/TopNav'
import Hamburger from '@/components/Hamburger'
import ErrorLog from '@/components/ErrorLog'
import Screenfull from '@/components/Screenfull'
import SizeSelect from '@/components/SizeSelect'
import LangSelect from '@/components/LangSelect'
import Search from '@/components/HeaderSearch'
import RightPanel from '@/components/RightPanel'
import Notice from '@/components/Notice'
import Settings from './Settings'
import { getFilePathByName } from '@/utils/abp'
import { getBroadCastnoticelist, getcommonnoticelist } from '@/api/notcie'
export default {
  components: {
    Breadcrumb,
    TopNav,
    Hamburger,
    ErrorLog,
    Screenfull,
    SizeSelect,
    LangSelect,
    Search,
    RightPanel,
    Settings,
    Notice
  },
  computed: {
    ...mapGetters(['sidebar', 'avatar', 'device']),
    ...mapState({
      showSettings: (state) => state.settings.showSettings,
      topNav() {
        return this.$store.state.settings.topNav
      }
    })
  },
  data() {
    return {
      showSettingPanel: false,
      isShowUserNewsPopover: false,
      messagelist: [],
      notificationlist: []
    }
  },
  watch: {
    isShowUserNewsPopover(newval, oldval) {
      if (newval) {
        getBroadCastnoticelist({ Status: 0, Title: '' }).then((res) => {
          this.notificationlist = [...res]
        })
        getcommonnoticelist({ Status: 0, Title: '' }).then((res) => {
          this.messagelist = [...res]
        })
      }
    }
  },
  methods: {
    getFilePathByName,
    toggleSideBar() {
      this.$store.dispatch('app/toggleSideBar')
    },
    async logout() {
      this.$confirm('确定注销并退出系统吗？', '提示', {
        confirmButtonText: '确定',
        cancelButtonText: '取消',
        type: 'warning'
      }).then(async() => {
        await this.$store.dispatch('user/logout')
        this.$router.push(`/login?redirect=${this.$route.fullPath}`)
      })
    },
    closesettingPanel() {
      this.showSettingPanel = !this.showSettingPanel
    }
  }
}
</script>

<style lang="scss" scoped>
.navbar {
  height: 50px;
  overflow: hidden;
  position: relative;
  background: #fff;
  box-shadow: 0 1px 4px rgba(0, 21, 41, 0.08);

  .hamburger-container {
    line-height: 46px;
    height: 100%;
    float: left;
    cursor: pointer;
    transition: background 0.3s;
    -webkit-tap-highlight-color: transparent;

    &:hover {
      background: rgba(0, 0, 0, 0.025);
    }
  }

  .breadcrumb-container {
    float: left;
  }
  .topmenu-container {
    position: absolute;
    left: 50px;
  }

  .errLog-container {
    display: inline-block;
    vertical-align: top;
  }
  .setting-icon {
    display: inline-block;
    padding: 0 8px;
    height: 100%;
    font-size: 22px;
    color: #5a5e66;
    vertical-align: text-bottom;
    line-height: 52px;
    &:hover {
      background: rgba(0, 0, 0, 0.025);
      cursor: pointer;
      transition: background 0.3s;
    }
  }
  .right-menu {
    float: right;
    height: 100%;
    line-height: 50px;

    &:focus {
      outline: none;
    }

    .right-menu-item {
      display: inline-block;
      padding: 0 8px;
      height: 100%;
      font-size: 18px;
      color: #5a5e66;
      vertical-align: text-bottom;

      &.hover-effect {
        cursor: pointer;
        transition: background 0.3s;

        &:hover {
          background: rgba(0, 0, 0, 0.025);
        }
      }
    }

    .avatar-container {
      margin-right: 30px;

      .avatar-wrapper {
        margin-top: 5px;
        position: relative;

        .user-avatar {
          cursor: pointer;
          width: 40px;
          height: 40px;
          border-radius: 10px;
        }

        .el-icon-caret-bottom {
          cursor: pointer;
          position: absolute;
          right: -20px;
          top: 25px;
          font-size: 12px;
        }
      }
    }
  }
  ::v-deep .el-badge__content.is-fixed.is-dot {
    top: 12px !important;
  }
}
</style>
