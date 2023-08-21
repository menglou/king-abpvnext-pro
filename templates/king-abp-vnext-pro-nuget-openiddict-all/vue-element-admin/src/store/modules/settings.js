import variables from '@/styles/element-variables.scss'
import defaultSettings from '@/settings'

const { theme, sideTheme, showSettings, topNav, tagsView, fixedHeader, sidebarLogo, supportPinyinSearch } = defaultSettings

const storageSetting = JSON.parse(localStorage.getItem('layout-setting')) || ''

const state = {
  theme: storageSetting.theme || theme,
  sideTheme: storageSetting.sideTheme || sideTheme, //侧边主题样式
  showSettings,
  topNav: storageSetting.topNav === undefined ? topNav : storageSetting.topNav,
  tagsView: storageSetting.tagsView === undefined ? tagsView : storageSetting.tagsView,
  fixedHeader: storageSetting.fixedHeader === undefined ? fixedHeader : storageSetting.fixedHeader,
  sidebarLogo: storageSetting.sidebarLogo === undefined ? sidebarLogo : storageSetting.sidebarLogo,
  supportPinyinSearch
}

const mutations = {
  CHANGE_SETTING: (state, { key, value }) => {
    // eslint-disable-next-line no-prototype-builtins
    if (state.hasOwnProperty(key)) {
      state[key] = value
    }
  }
}

const actions = {
  changeSetting({ commit }, data) {
    commit('CHANGE_SETTING', data)
  }
}

export default {
  namespaced: true,
  state,
  mutations,
  actions
}

