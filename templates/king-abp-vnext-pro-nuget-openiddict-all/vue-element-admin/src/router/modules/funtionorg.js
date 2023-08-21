/** When your routing table is too long, you can split it into small modules **/

import Layout from '@/layout'

const funtionorgRouter = {
  path: '/funtionorg',
  component: Layout,
  redirect: 'noRedirect',
  alwaysShow: true,
  name: 'FuntionOrg',
  meta: {
    title: 'FuntionOrg.title',
    icon: 'el-icon-office-building',
    policy: ''
  },
  children: [
    {
      path: 'departmentunit',
      component: () => import('@/views/funtionorg/department/index'),
      name: 'DepartmentUnit',
      meta: { title: 'FuntionOrg.DepartMent.title', policy: 'Institution.DepartmentUnit', icon: 'tree' }
    },
    {
      path: 'poster',
      component: () => import('@/views/funtionorg/poster/index'),
      name: 'Poster',
      meta: { title: 'FuntionOrg.Poster.title', policy: 'Institution.Poster', icon: 'poster' }
    }
  ]
}
export default funtionorgRouter
