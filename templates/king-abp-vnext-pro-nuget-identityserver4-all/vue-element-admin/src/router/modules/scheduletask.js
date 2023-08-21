import Layout from '@/layout'

const scheduletaskRouter = {
    path: '/scheduletasks',
    component: Layout,
    redirect: '/scheduletasks/scheduletask',
    alwaysShow: false,
    name: 'ScheduleTask',
    meta: {
        title: 'ScheduleTask.title',
        icon: 'el-icon-stopwatch',
        policy: '',
        isOnly: true
    },
    children: [
        {
            path: 'scheduletask',
            component: () => import('@/views/scheduletask/index'),
            name: 'ScheduleTask',
            meta: {
                title: 'ScheduleTask.title',
                policy: 'ScheduleTaskManager.ScheduleTask',
                icon: 'el-icon-stopwatch'
            }
        }
    ]
}

export default scheduletaskRouter
