<template>
  <div class="drawer-container">
    <div class="setting-drawer-content">
      <div class="setting-drawer-title">
        <h3 class="drawer-title">主题风格设置</h3>
      </div>
      <div class="setting-drawer-block-checbox">
        <div
          class="setting-drawer-block-checbox-item"
          @click="handleTheme('theme-dark')"
        >
          <img src="@/assets/image/dark.svg" alt="dark">
          <div
            v-if="sideTheme === 'theme-dark'"
            class="setting-drawer-block-checbox-selectIcon"
            style="display: block"
          >
            <i aria-label="图标: check" class="anticon anticon-check">
              <svg
                viewBox="64 64 896 896"
                data-icon="check"
                width="1em"
                height="1em"
                :fill="theme"
                aria-hidden="true"
                focusable="false"
                class=""
              >
                <path
                  d="M912 190h-69.9c-9.8 0-19.1 4.5-25.1 12.2L404.7 724.5 207 474a32 32 0 0 0-25.1-12.2H112c-6.7 0-10.4 7.7-6.3 12.9l273.9 347c12.8 16.2 37.4 16.2 50.3 0l488.4-618.9c4.1-5.1.4-12.8-6.3-12.8z"
                />
              </svg>
            </i>
          </div>
        </div>
        <div
          class="setting-drawer-block-checbox-item"
          @click="handleTheme('theme-light')"
        >
          <img src="@/assets/image/light.svg" alt="light">
          <div
            v-if="sideTheme === 'theme-light'"
            class="setting-drawer-block-checbox-selectIcon"
            style="display: block"
          >
            <i aria-label="图标: check" class="anticon anticon-check">
              <svg
                viewBox="64 64 896 896"
                data-icon="check"
                width="1em"
                height="1em"
                :fill="theme"
                aria-hidden="true"
                focusable="false"
                class=""
              >
                <path
                  d="M912 190h-69.9c-9.8 0-19.1 4.5-25.1 12.2L404.7 724.5 207 474a32 32 0 0 0-25.1-12.2H112c-6.7 0-10.4 7.7-6.3 12.9l273.9 347c12.8 16.2 37.4 16.2 50.3 0l488.4-618.9c4.1-5.1.4-12.8-6.3-12.8z"
                />
              </svg>
            </i>
          </div>
        </div>
      </div>

      <h3 class="drawer-title">{{ $t("Openiddict['Settings:Title']") }}</h3>

      <div class="drawer-item">
        <span>开启 TopNav</span>
        <el-switch v-model="topNav" class="drawer-switch" />
      </div>

      <div class="drawer-item">
        <span>{{ $t("Openiddict['Settings:Theme']") }}</span>
        <theme-picker
          style="float: right; height: 26px; margin: -3px 8px 0 0"
          @change="themeChange"
        />
      </div>

      <div class="drawer-item">
        <span>{{ $t("Openiddict['Settings:TagsView']") }}</span>
        <el-switch v-model="tagsView" class="drawer-switch" />
      </div>

      <div class="drawer-item">
        <span>{{ $t("Openiddict['Settings:FixedHeader']") }}</span>
        <el-switch v-model="fixedHeader" class="drawer-switch" />
      </div>

      <div class="drawer-item">
        <span>{{ $t("Openiddict['Settings:SidebarLogo']") }}</span>
        <el-switch v-model="sidebarLogo" class="drawer-switch" />
      </div>
      <div v-if="lang.indexOf('zh') === 0" class="drawer-item">
        <span>菜单支持拼音搜索</span>
        <el-switch v-model="supportPinyinSearch" class="drawer-switch" />
      </div>
      <el-divider />
      <el-button
        size="small"
        type="primary"
        plain
        icon="el-icon-document-add"
        @click="saveSetting"
      >保存配置</el-button>
      <el-button
        size="small"
        plain
        icon="el-icon-refresh"
        @click="resetSetting"
      >重置配置</el-button>
    </div>
  </div>
</template>

<script>
import ThemePicker from '@/components/ThemePicker'

export default {
  components: { ThemePicker },
  data() {
    return {
      theme: this.$store.state.settings.theme,
      sideTheme: this.$store.state.settings.sideTheme
    }
  },
  computed: {
    isShowJob() {
      return this.$store.getters.language.indexOf('zh') === 0
    },
    topNav: {
      get() {
        return this.$store.state.settings.topNav
      },
      set(val) {
        this.$store.dispatch('settings/changeSetting', {
          key: 'topNav',
          value: val
        })
        if (!val) {
          this.$store.commit(
            'permission/SET_SIDEBAR_ROUTERS',
            this.$store.state.permission.defaultRoutes
          )
        }
      }
    },
    fixedHeader: {
      get() {
        return this.$store.state.settings.fixedHeader
      },
      set(val) {
        this.$store.dispatch('settings/changeSetting', {
          key: 'fixedHeader',
          value: val
        })
      }
    },
    tagsView: {
      get() {
        return this.$store.state.settings.tagsView
      },
      set(val) {
        this.$store.dispatch('settings/changeSetting', {
          key: 'tagsView',
          value: val
        })
      }
    },
    sidebarLogo: {
      get() {
        return this.$store.state.settings.sidebarLogo
      },
      set(val) {
        this.$store.dispatch('settings/changeSetting', {
          key: 'sidebarLogo',
          value: val
        })
      }
    },
    supportPinyinSearch: {
      get() {
        return this.$store.state.settings.supportPinyinSearch
      },
      set(val) {
        this.$store.dispatch('settings/changeSetting', {
          key: 'supportPinyinSearch',
          value: val
        })
      }
    },
    lang() {
      return this.$store.getters.language
    }
  },
  methods: {
    themeChange(val) {
      this.$store.dispatch('settings/changeSetting', {
        key: 'theme',
        value: val
      })
    },
    handleTheme(val) {
      this.$store.dispatch('settings/changeSetting', {
        key: 'sideTheme',
        value: val
      })
      this.sideTheme = val
    },

    // 保存配置好
    saveSetting() {
      // this.$modal.loading("正在保存到本地，请稍后...");
      const loading = this.$loading({
        lock: true,
        text: '正在保存到本地，请稍后...',
        spinner: 'el-icon-loading',
        background: 'rgba(0, 0, 0, 0.7)'
      })
      localStorage.setItem(
        'layout-setting',
        `{
            "topNav":${this.topNav},
            "tagsView":${this.tagsView},
            "fixedHeader":${this.fixedHeader},
            "sidebarLogo":${this.sidebarLogo},
            "sideTheme":"${this.sideTheme}",
            "theme":"${this.theme}"
          }`
      )
      setTimeout(loading.close(), 2000)
    },
    resetSetting() {
      // this.$modal.loading("正在清除设置缓存并刷新，请稍后...");
      localStorage.removeItem('layout-setting')
      setTimeout('window.location.reload()', 1000)
    }
  }
}
</script>

<style lang="scss" scoped>
.setting-drawer-content {
  .setting-drawer-title {
    margin-bottom: 12px;
    color: rgba(0, 0, 0, 0.85);
    font-size: 14px;
    line-height: 22px;
    font-weight: bold;
  }

  .setting-drawer-block-checbox {
    display: flex;
    justify-content: flex-start;
    align-items: center;
    margin-top: 10px;
    margin-bottom: 20px;

    .setting-drawer-block-checbox-item {
      position: relative;
      margin-right: 16px;
      border-radius: 2px;
      cursor: pointer;

      img {
        width: 48px;
        height: 48px;
      }

      .setting-drawer-block-checbox-selectIcon {
        position: absolute;
        top: 0;
        right: 0;
        width: 100%;
        height: 100%;
        padding-top: 15px;
        padding-left: 24px;
        color: #1890ff;
        font-weight: 700;
        font-size: 14px;
      }
    }
  }
}

.drawer-container {
  padding: 24px;
  font-size: 14px;
  line-height: 1.5;
  word-wrap: break-word;

  .drawer-title {
    margin-bottom: 12px;
    color: rgba(0, 0, 0, 0.85);
    font-size: 14px;
    line-height: 22px;
  }

  .drawer-item {
    color: rgba(0, 0, 0, 0.65);
    font-size: 14px;
    padding: 12px 0;
  }

  .drawer-switch {
    float: right;
  }

  .job-link {
    display: block;
    position: absolute;
    width: 100%;
    left: 0;
    bottom: 0;
  }
}
</style>
