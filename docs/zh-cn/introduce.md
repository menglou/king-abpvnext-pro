# 介绍
<font size="4">[KingAbpVnextPro](https://github.com/menglou/menglou.github.io.git)</font>是一个标准的前后台解决方案，它基于<font size="4">[AbpVnext](https://www.abp.io/) 和<font size="4"> [Vue-elemet-Admin](https://github.com/PanJiaChen/vue-element-admin.git) 实现，Vue-elemet-Admin 是一个成熟的前端框架本框架采用的是vue2 版本的，在此基础上又扩展了一些功能，后台AbpVnext框架是一个完全开源的框架，内置丰富的模块，兼容微服务，多租户/Sass,模块化架构，领域驱动设计，本框架在此基础上，提炼了典型的业务模型，做成了一个一个模块，无论用户采用本框架还是AbpVnext进行开发,模块都是可以即插即用的，相信不管你的需求是什么，本项目都能帮助到你

## 安装
##### 先决条件
```sh

1. dotnet core 6.0.0 以上版本
2. nodejs 16+
3. npm
4. sqlserver
5. redis(可选)
6. rabbitmq(可选)

```
##### 创建新项目(脚手架的安装更新与删除)
1. 安装Cli
><font size="5">dotnet tool install -g King.AbpVnextPro.Cli</font>
2. 更新Cli
><font size="5">dotnet tool update -g  King.AbpVnextPro.Cli</font>
3. 卸载Cli
><font size="5">dotnet tool uninstall -g King.AbpVnextPro.Cli</font>

#### 生成项目
  ##### identityserver4 
1. nuget包形式的identityserver4 鉴权方式的版本
2. abp vnext  自带的所有模块，pro 的通知模块,数据字典，文件管理，职能机构，支付中心
><font size="5">king.abp new -t pro.id4.all -c 公司名称 -p 项目名称 -v 版本(默认LastRelease) -o 默认当前控制台执行目录</font>
  ##### openiddict
1. nuget包形式的identityserver4 鉴权方式的版本
2. abp vnext  自带的所有模块，pro 的通知模块,数据字典，文件管理，职能机构，支付中心
><font size="5">king.abp new -t pro.openiddict.all -c 公司名称 -p 项目名称 -v 版本(默认LastRelease) -o 默认当前控制台执行目录</font>
## 功能
#### 功能列表
```sh

1. 用户管理
2. 角色管理
3. 审计日志
4. 登录日志
5. 计划任务
6. 集成事件
7. SinglaR 消息通知(站内信)
8. 多语言
9. 数据字典
10. 文件管理
11. 职能机构
12. 支付中心
13. 工作流
14. ES 日志
15. 配置中心
16. 多租户

```

#### 部分页面展示
![登录页](/_media/login.png)
![配置中心](/_media/settting.png)
![计划任务](/_media/scheduletask.png)
![用户管理](/_media/user.png)

## 目录结构
##### 后端项目结构
```sh

├── Directory.Build.props nuget 版本控制
├── frameworks # 公共模块
│       ├── src #
│           ├── King.AbpVnextPro.CAP # dotnetcore.cap
│           ├── King.AbpVnextPro.Core  # 核心扩展(通用方法，扩展方法，发邮件，发短信，微信小程序登录/获取手机号等)
            ├── King.AbpVnextPro.Core  # ElasticSearch 
│           └── King.AbpVnextPro.Localization # 本地化
            └── King.AbpVnextPro.Paylink.Alipy # 支付宝支付
            └── King.AbpVnextPro.Paylink.Security # 支付加密解密
            └── King.AbpVnextPro.Paylink.WeChat # 微信支付
├── gateways # 网关
│       └── Kings.AbpVnextPro.WebGateway # 基于ocelot网关
├── modules # 模块
        ├── BasicManagement # 基础模块
            ├── IdentityServer # 基于IdentityServe4 进行鉴权的基础模块，主要内容包括(用户,角色，权限，日志，组织建构，扩展第三方登录)
            ├── OpenIdictBasic # 基于OpenIdDIct 进行鉴权的基础模块，主要内容包括(用户,角色，权限，日志，组织建构，扩展第三方登录)
        └── Notification # 通知模块(SignalR)    
│       ├── dictionary # 数据字典模块
│       ├── fileManagement # 基于AbpVnext Bolb 存储的文件服务模块(可扩展，如阿里云存储)
        ├── institution # 职能机构模块(部门，岗位)
        ├── paycenter # 微信支付宝支付模块，配合配置中心配置好参数后可直接调用
        ├── scheduletask # 计划调度任务模块
        ├── workflow # 工作流模块
│       
├── services # 公共静态资源目录
        ├── identityserver # 基于IdentityServe4 的启动模块
    │       ├── src  # 源码
    │           └── King.AbpVnextPro.HttpApi.Host # 项目 host
                └── King.AbpVnextPro.DbMigrator # 迁移控制台程序
    │       
        ├── openiddict # 基于OpenIddict 的启动模块
    │       
    │       ├── src  # 源码
    │           ├── King.AbpVnextPro.HttpApi.Host # 项目 host
    │           └── King.AbpVnextPro.DbMigrator # 迁移控制台程序
    │       
├── shared # 公共Host
│       ├── King.AbpVnextPro.Shared.Hosting.Gateways # 网关host模块
│
├── templates # 公共Host
│       ├── king-abp-vnext-pro-nuget-identityserver4-all # 网关host模块
│           ├── aspnet-core  # 源码
│               ├── src  # 源码
│                  ├── CompanyName.ProjectName.HttpApi.Host # 项目 host
│                   └── CompanyName.ProjectName.DbMigrator # 迁移控制台程序
│          ├── vue-element-admin  # 前端源码

```
##### 前端项目结构
```sh

├── build                      # 构建相关
├── public                     # 静态资源
│   │── favicon.ico            # favicon图标
│   └── index.html             # html模板
├── src                        # 源代码
│   ├── api                    # 所有请求
│   ├── assets                 # 主题 字体等静态资源
│   ├── components             # 全局公用组件
│   ├── directive              # 全局指令
│   ├── filters                # 全局 filter
│   ├── icons                  # 项目所有 svg icons
│   ├── lang                   # 国际化 language
│   ├── layout                 # 全局 layout
│   ├── router                 # 路由
│   ├── store                  # 全局 store管理
│   ├── styles                 # 全局样式
│   ├── utils                  # 全局公用方法
│   ├── vendor                 # 公用vendor
│   ├── views                  # views 所有页面
│   ├── App.vue                # 入口页面
│   ├── main.js                # 入口文件 加载组件 初始化等
│   └── permission.js          # 权限管理
├── .env.xxx                   # 环境变量配置
├── .eslintrc.js               # eslint 配置项
├── .babelrc                   # babel-loader 配置
├── .travis.yml                # 自动化CI配置
├── vue.config.js              # vue-cli 配置
├── postcss.config.js          # postcss 配置
└── package.json               # package.json
```

## Browsers Support
<font size="3">Modern browsers and Internet Explorer 10+.</font>

| <font size="4">IE/Edge</font>        | <font size="4">Firefox</font>         | <font size="4">Chrome</font>          | <font size="4">Safari</font>          |
| ------------------------------------ | ------------------------------------- | ------------------------------------- | ------------------------------------- |
| <font size="4">IE10,IE11,Edge</font> | <font size="4">last 2 versions</font> | <font size="4">last 2 versions</font> | <font size="4">last 2 versions</font> |


## 加入组织

欢迎大家加入群聊 QQ群：[1145603937]() 进行交流,或者扫码加入
<img src="/_media/qq.png"  />

## 生态圈
  ### 1.Vue 生态圈

   1. [Vue Router](https://router.vuejs.org/)是 vue 官方的路由。它能快速的帮助你构建一个单页面或者多页面的项目。
   2. [Vuex](https://vuex.vuejs.org/) 是一个专为 Vue.js 应用程序开发的状态管理模式。它采用集中式存储管理应用的所有组件的状态，并以相应的规则保证状态以一种可预测的方式发生变化。它能解决你很多全局状态或者组件之间通信的问题。
   3. [Vue CLI](https://cli.vuejs.org/) 是官方提供的一个 vue 项目脚手架，本项目也是基于它进行构建的。它帮你封装了大量的 webpack、babel 等其它配置，让你能花更少的精力在搭建环境上，从而能更专注于页面代码的编写。不过所有的脚手架都是针对大部分情况的，所以一些特殊的需求还是需要自己进行配置。建议先阅读一遍它的文档，对一些配置有一些基本的了解。
   4. [Vetur](https://github.com/vuejs/vetur)] 是 VS Code 的插件. 如果你使用 VS Code 来写 vue 的话，这个插件是必不可少的。
   5. [Axios](http://www.axios-js.com/zh-cn/docs/) 是一个基于 promise 的 HTTP 库,可以用在浏览器和 node.js 中。 axios Axios 是一个基于 promise 的 HTTP 库,可以用在浏览器和 node.js 中。
   
  ### 2.AbpVnext 生态圈
   1. [Abp CLI](https://docs.abp.io/en/abp/latest/CLI)是官方提供的一个 abp vnext 项目脚手架，本项目也是基于它进行构建的。它帮你封装了一些常用的基础模块，让你能花更少的精力在基础环境搭建商，从而能更专注于业务逻辑的编写。不过所有的脚手架都是针对大部分情况的，所以一些特殊的需求还是需要自己进行配置。建议先阅读一遍它的文档，对一些配置有一些基本的了解。
   2. [IdentityServer4](https://identityserver4.readthedocs.io/) 是一款包含和实现了 OpenID Connect 和 OAuth 2.0 协议的，适用于 ASP.NET Core 的框架，AbpVnext 6.0.0 以前的版本
   3. [OpenIddict](https://blog.goodsxx.cn/)OpenIddict 是一个开源且通用的框架，用于在任何 ASP.NET Core 2.1（及更高版本）和传统的 ASP.NET 4.6.1（及更高版本）应用程序中构建符合标准的 OAuth 2.0 / OpenID Connect 服务器
   4. [Redis](https://redis.io/)是一个key-value存储系统。和Memcached类似，它支持存储的value类型相对更多，包括string(字符串)、list(链表)、set(集合)、zset(sorted set --有序集合)和hash（哈希类型）            Redis 是一个高性能的key-value数据库,所以一般用来做缓存，用于实现分布式锁和并发控制，热点数据的存储来减少关系数据库的访问压力
   5. [RabbitMQ](https://www.rabbitmq.com/)是一个开源的消息代理的队列服务器，用来通过普通协议在完全不同的应用之间共享数据。其主要功能特点是如流量消峰，应用解耦，异步处理，数据并发处理
   6. [Quartz.net](https://github.com/quartznet/quartznet)是一个Github开源项目，用于创建一个免费商业用途的作业调度框架。主要协助用来处理一些定时任务，通过调度器执行，其丰富的Corn 表达式可以配置各种各样的运行时间

## 捐赠
> Star就是对该项目的最大肯定!
> 如果你觉得这个项目对你有帮助，你可以帮作者买一杯咖啡表示支持!

<table  align="center">
	<tr>
		<td>
			<center>
        <font >微信</font>
      	<br/>
				<img src="/_media/wechat.png"  />
			</center>
		</td>
		<td>
			<center>
        <font >支付宝</font>
        <br/>
				<img src="/_media/alipay.png" />
			</center>
		</td>
	</tr>
</table>

<style>
  td img{
    width:330px !important;
    height: 300px !important;
  }
</style>