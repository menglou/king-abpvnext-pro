import defaultSettings from '@/settings'
import i18n from '@/lang'

const title = defaultSettings.title || '泸州水务'

export default function getPageTitle(key) {
  const hasKey = i18n.te(key)
  if (hasKey) {
    const pageName = i18n.t(key)
    return `${pageName} - ${title}`
  }
  return `${title}`
}
