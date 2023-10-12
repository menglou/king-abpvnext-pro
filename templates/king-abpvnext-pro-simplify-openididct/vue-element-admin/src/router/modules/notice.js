import Layout from '@/layout'

const notcieRouter = {
  path: '/notices',
  component: Layout,
  redirect: '/notices/notice',
  alwaysShow: false,
  name: 'Notcie',
  meta: {
    title: 'Notices.title',
    icon: 'el-icon-bell',
    policy: '',
    isOnly: true
  },
  children: [
    {
      path: 'notcie',
      component: () => import('@/views/notices/index'),
      name: 'Notcie',
      meta: {
        title: 'Notices.title',
        policy: 'NoticeCenter.Notice',
        icon: 'el-icon-bell'
      }
    }
  ]
}

export default notcieRouter
