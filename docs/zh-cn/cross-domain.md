# 跨域问题

### 开发过程
+ 前端
  - 在 dev 开发模式下可以使用 webpack 的 proxy 也很方便，参照 文档 就会使用了，本项目项目使用的就是该方法。但这种方法在生产环境是不能使用的。在生产环境中需要使用 nginx 进行反向代理。不管是 proxy 和 nginx 的原理都是一样的，通过搭建一个中转服务器来转发请求从而规避跨域的问题
 <div >
   <pre style="background-color:#282c34;border-radius:6px;color:#fff;color:#fff">
    //vue.config.js 中配置如下
    module.exports = {
        /**
        * You will need to set publicPath if you plan to deploy your site under a sub path,
        * for example GitHub Pages. If you plan to deploy your site to https://foo.github.io/bar/,
        * then publicPath should be set to "/bar/".
        * In most cases please use '/' !!!
        * Detail: https://cli.vuejs.org/config/#publicpath
        */
        publicPath: '/',
        outputDir: 'dist',
        assetsDir: 'static',
        lintOnSave: process.env.NODE_ENV === 'development',
        productionSourceMap: false,
        devServer: {
            port: port,
            open: true,
            overlay: {
            warnings: false,
            errors: true
            },
            proxy: {  //配置跨域
            '/api': {
                target: process.env.VUE_APP_BASE_API,  //这里后台的地址模拟的;应该填写你们真实的后台接口
                changOrigin: true,  //允许跨域
            }
            }
        },
   </pre>
  </div>

+ 后端 
  - 修改 xxx.xxx.HttpApi.Host 项目中的appsetting.json 的 CorsOrigins，多个跨域以逗号分开
 <div >
   <pre style="background-color:#282c34;border-radius:6px;color:#fff;color:#fff">
    "App": {
        "SelfUrl": "https://localhost:44395",
        "CorsOrigins": "https://*.AbpVnextPro.com,http://localhost:9528,http://localhost:9529",
        "RedirectAllowedUrls": "http://localhost:4200,https://localhost:44391"
     },
   </pre>
  </div>
---

### 正式发布
  
  + 后端
    - IIS (别问为什么不用docker,因为 iis 是 .neter 工作者的信仰，哈哈。。（开个玩笑.net core 都不限制平台了，随便部署）)
      
  + 前端
     - Nginx（docker 都可以，本文只写本项目的部署方式）
  
     - IIS(若前端也部署在iis 建议与后端在同一个站点下，这样既可以起到保护api 不让直接通过swagger 访问，而且解决了跨域问题)
  
     