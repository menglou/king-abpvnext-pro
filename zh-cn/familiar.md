# 常见问题

> TIP
> 
> 提问之前，请先查阅下面的常见问题。
 
## 首先有任何报错，最简单的方法是把报错信息复制到浏览器里面搜索一下！！！
[google点我](https://www.google.com/)

[百度点我](https://www.baidu.com/)


## 跨域问题 如：为什么发了一个 options 请求? Access-Control-Allow-Origin 报错等?

请参考文档 [跨域问题](/zh-cn/cross-domain)


## 登录页无法打开？或者登录页打开无法登录 报 ClientId 无效
  + <font size="5">IdentityServer4 版本的</font>
  
     - <font size="4">前端(src/store/user.js) 修改 scope 和 client_id，client_secret</font>
  
     <img src="_media/frontnotice.png" />
     
     - <font size="4">如何在数据库查找自己的 scope 和 client_id，client_secret</font>
        - <font size="3">IdentityServerClients表中的 ClientId 字段对应前端的client_id</font>

        - <font size="3">IdentityServerApiScopes表中的 Name字段对应前端的scope</font>
     - <font size="4">如何在项目查找自己的 scope 和 client_id，client_secret</font>
        - <font size="3">xxx.xxx.Domain 项目中 IdentityServer 文件夹下面的类(IdentityServerDataSeedContributor.cs)</font>
        
  + <font size="5">Openiddict 版本的 版本的</font>
     - <font size="4">前端(src/store/user.js) 修改 scope 和 client_id，client_secret</font>
  
     <img src="_media/frontnotice.png" />
     
     - <font size="4">如何在数据库查找自己的 scope 和 client_id，client_secret</font>
        - <font size="3">OpenIddictApplications表中的 ClientId 字段对应前端的client_id</font>

        - <font size="3">OpenIddictApplications表中的 Permissions 字段包含对应前端的scope</font>

     - <font size="4">如何在项目查找自己的 scope 和 client_id，client_secret</font>
        - <font size="3">xxx.xxx.Domain 项目中 OpenIddict 文件夹下面的类(OpenIddictDataSeedContributor.cs)</font>