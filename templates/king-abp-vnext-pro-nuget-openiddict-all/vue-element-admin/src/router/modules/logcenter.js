/** When your routing table is too long, you can split it into small modules **/

import Layout from '@/layout'

const logcenterRouter = {
  path: '/logcenter',
  component: Layout,
  redirect: 'noRedirect',
  alwaysShow: true,
  name: 'LogCenter',
  meta: {
    title: 'LogCenter.title',
    icon: 'el-icon-reading',
    policy: ''
  },
  children: [
    {
      path: 'auditLogs',
      component: () => import('@/views/logcenter/auditlogging'),
      name: 'AuditLogs',
      meta: { title: 'AbpIdentity["AuditLogsrManager"]', policy: 'LogCenter.AbpAuditLogging.Default', icon: 'audolog' }
    },
    {
      path: 'securitylogs',
      component: () => import('@/views/logcenter/securitylogs'),
      name: 'SecurityLogs',
      meta: { title: 'AbpIdentity["Securitylogs"]', policy: 'LogCenter.SecurityLog.Default', icon: 'loginlog' }
    }
  ]
}
export default logcenterRouter
