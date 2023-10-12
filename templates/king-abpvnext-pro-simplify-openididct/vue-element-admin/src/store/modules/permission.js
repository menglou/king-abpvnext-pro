import { asyncRoutes, constantRoutes } from '@/router'

/**
 * Use meta.policy to determine if the current user has permission
 * @param grantedPolicies
 * @param route
 */
function hasPermission(grantedPolicies, route) {
  if (route.meta && route.meta.policy) {
    const policy = route.meta.policy
    return grantedPolicies[policy]
  } else {
    return true
  }
}

/**
 * Filter asynchronous routing tables by recursion
 * @param routes asyncRoutes
 * @param grantedPolicies
 */
export function filterAsyncRoutes(routes, grantedPolicies) {
  const res = []

  routes.forEach(route => {
    const tmp = { ...route }
    if (hasPermission(grantedPolicies, tmp)) {
      if (tmp.children) {
        tmp.children = filterAsyncRoutes(tmp.children, grantedPolicies)
      }

      if (route.meta && route.meta.policy === '') {
        if (tmp.children.length > 0) {
          res.push(tmp)
        }
      } else {
        res.push(tmp)
      }
    }
  })

  return res
}

const state = {
  routes: [],
  addRoutes: [],
  defaultRoutes: [],
  topbarRouters: [],
  sidebarRouters: []
}

const mutations = {
  SET_ROUTES: (state, routes) => {
    state.addRoutes = routes
    state.routes = constantRoutes.concat(routes)
  },
  //用老保存号所有的路由
  SET_DEFAULT_ROUTES: (state, routes) => {
    state.defaultRoutes = constantRoutes.concat(routes)
  },
  //设置顶部路由
  SET_TOPBAR_ROUTES: (state, routes) => {
    state.topbarRouters = routes
  },
  SET_SIDEBAR_ROUTERS: (state, routes) => {
    state.sidebarRouters = routes
  },
}

const actions = {
  generateRoutes({ commit }, grantedPolicies) {
    return new Promise(resolve => {
      const accessedRoutes = filterAsyncRoutes(asyncRoutes, grantedPolicies)
      commit('SET_ROUTES', accessedRoutes)
      commit('SET_DEFAULT_ROUTES', accessedRoutes)
      commit('SET_TOPBAR_ROUTES', accessedRoutes)
      commit('SET_SIDEBAR_ROUTERS', constantRoutes.concat(accessedRoutes))
      resolve(accessedRoutes)
    })
  }
}

export default {
  namespaced: true,
  state,
  mutations,
  actions
}
