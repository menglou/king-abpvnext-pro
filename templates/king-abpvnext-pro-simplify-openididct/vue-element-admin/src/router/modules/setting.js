import Layout from '@/layout'

const settingRouter = {
  path: '/settings',
  component: Layout,
  redirect: '/settings/setting',
  alwaysShow: false,
  name: 'Setting',
  meta: {
    title: 'Settings.title',
    icon: 'el-icon-coin',
    policy: '',
    isOnly: true
  },
  children: [
    {
      path: 'setting',
      component: () => import('@/views/settings/setting'),
      name: 'Setting',
      meta: {
        title: 'Settings.title',
        policy: 'SettingUi.ShowSettingPage',
        icon: 'el-icon-setting'
      }
    }
  ]
}

export default settingRouter
