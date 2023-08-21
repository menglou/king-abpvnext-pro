import Layout from '@/layout'

const dictionaryRouter = {
  path: '/dictionarys',
  component: Layout,
  redirect: '/dictionarys/dictionary',
  alwaysShow: false,
  name: 'Dictionary',
  meta: {
    title: 'Dictionary.title',
    icon: 'el-icon-coin',
    policy: '',
    isOnly:true
  },
  children: [
    {
      path: 'dictionary',
      component: () => import('@/views/dictionary/index'),
      name: 'Dictionary',
      meta: {
        title: 'Dictionary.title',
        policy: 'Dictionary.Default',
        icon: 'el-icon-s-cooperation'
      }
    }
  ]
}

export default dictionaryRouter
