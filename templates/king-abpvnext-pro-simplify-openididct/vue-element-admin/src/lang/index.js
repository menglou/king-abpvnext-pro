import Vue from 'vue'
import VueI18n from 'vue-i18n'
import Cookies from 'js-cookie'
import elementEnLocale from 'element-ui/lib/locale/lang/en' // element-ui lang
import elementZhLocale from 'element-ui/lib/locale/lang/zh-CN' // element-ui lang
import vxezhCN from 'vxe-table/lib/locale/lang/zh-CN'
import vxeenUS from 'vxe-table/lib/locale/lang/en-US'
import AbpEnLocale from './en'
import AbpZhLocale from './zh-Hans'

Vue.use(VueI18n)

const messages = {
  en: {
    ...elementEnLocale,
    ...vxeenUS,
    ...AbpEnLocale
  },
  'zh-Hans': {
    ...elementZhLocale,
    ...vxezhCN,
    ...AbpZhLocale
  }
}

export function getLanguage() {
  const chooseLanguage = Cookies.get('language')
  if (chooseLanguage) return chooseLanguage

  // if has not choose language
  const language = (
    navigator.language || navigator.browserLanguage
  ).toLowerCase()
  const locales = Object.keys(messages)
  for (const locale of locales) {
    if (language.indexOf(locale) > -1) {
      return locale
    }
  }
  return 'zh-Hans'
}
export function setLocale(language, values) {
  i18n.mergeLocaleMessage(language, values)
  i18n.locale = language
}
const i18n = new VueI18n({
  // set locale
  // options: en | zh | es
  locale: getLanguage(),
  // set locale messages
  messages
})

export default i18n
