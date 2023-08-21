/** When your routing table is too long, you can split it into small modules **/

import Layout from '@/layout'

const identityRouter = {
  path: '/identity',
  component: Layout,
  redirect: 'noRedirect',
  alwaysShow: true,
  name: 'Identity',
  meta: {
    title: 'AbpIdentity["Menu:IdentityManagement"]',
    icon: 'identity',
    policy: ''
  },
  children: [
    {
      path: 'users',
      component: () => import('@/views/identity/user/index'),
      name: 'Users',
      meta: { title: 'AbpIdentity["UserManager"]', policy: 'AbpIdentity.Users', icon: 'peoples' }
    },
    {
      path: 'roles',
      component: () => import('@/views/identity/role/index'),
      name: 'Roles',
      meta: { title: 'AbpIdentity["RolerManager"]', policy: 'AbpIdentity.Roles', icon: 'role' }
    },
    {
      path: 'organizations',
      component: () => import('@/views/identity/organizationunits/index'),
      name: 'Organizations',
      meta: { title: 'AbpIdentity["OrganitaionUnitsrManager"]', policy: 'AbpIdentity.OrganitaionUnits', icon: 'tree' }
    }
  ]
}
export default identityRouter
