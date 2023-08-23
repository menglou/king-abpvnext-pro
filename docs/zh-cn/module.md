## 基础管理模块
+ 把abp vnext自带 账户模块，权限模块，identity模块，setting模块，feature模块，租户模块,四三方登录封装到基础管理
+ <font size="5" style="font-weight:bold">IdentityServer4 版本</font>
  - <font size="4" style="font-weight:bold">安装</font>

    - Kings.AbpVnextPro.IdentityServer.Application
  
    - Kings.AbpVnextPro.IdentityServer.Application.Contracts
 
    - Kings.AbpVnextPro.IdentityServer.Domain
   
    - Kings.AbpVnextPro.IdentityServer.Domain.Shared

    - Kings.AbpVnextPro.IdentityServer.EntityFrameworkCore
 
    - Kings.AbpVnextPro.IdentityServer.HttpApi

    - Kings.AbpVnextPro.IdentityServer.HttpApi.Client
  
  - <font size="4" style="font-weight:bold">模块依赖配置</font>
    - 添加 DependsOn(typeof(IdentityServerXxxModule)) 特性到对应模块
  
    - 在EntityFrameworkCore层添加数据库配置在AbpVnextProDbContext.cs的OnModelCreating()方法中添加builder.Configurexxx()(如果模块中不涉及到表可以不用配置)
  
+ <font size="5" style="font-weight:bold">Openiddict 版本</font>
  - <font size="4" style="font-weight:bold">安装</font>

    - Kings.AbpVnextPro.Openiddict.Application
  
    - Kings.AbpVnextPro.Openiddict.Application.Contracts
 
    - Kings.AbpVnextPro.Openiddict.Domain
   
    - Kings.AbpVnextPro.Openiddict.Domain.Shared

    - Kings.AbpVnextPro.Openiddict.EntityFrameworkCore
 
    - Kings.AbpVnextPro.Openiddict.HttpApi

    - Kings.AbpVnextPro.Openiddict.HttpApi.Client
  
  - <font size="4" style="font-weight:bold">模块依赖配置</font>
    - 添加 DependsOn(typeof(OpeniddictXxxModule)) 特性到对应模块
  
    - 在EntityFrameworkCore层添加数据库配置在AbpVnextProDbContext.cs的OnModelCreating()方法中添加builder.Configurexxx()(如果模块中不涉及到表可以不用配置)

## 字典管理模块
+ 文件上传是很多系统都会涉及到的一个基础功能，在ABP的模块化思路下，做成了一个通用的模块，本模块使用abp 自带的blob 存储
  - <font size="4" style="font-weight:bold">安装</font>

    - Kings.AbpVnextPro.Dictionary.Application
  
    - Kings.AbpVnextPro.Dictionary.Application.Contracts
 
    - Kings.AbpVnextPro.Dictionary.Domain
   
    - Kings.AbpVnextPro.Dictionary.Domain.Shared

    - Kings.AbpVnextPro.Dictionary.EntityFrameworkCore
 
    - Kings.AbpVnextPro.Dictionary.HttpApi

    - Kings.AbpVnextPro.Dictionary.HttpApi.Client
  
  - <font size="4" style="font-weight:bold">模块依赖配置</font>
    - 添加 DependsOn(typeof(DictionaryXxxModule)) 特性到对应模块
  
    - 在EntityFrameworkCore层添加数据库配置在AbpVnextProDbContext.cs的OnModelCreating()方法中添加builder.ConfigureDictionary()

## 文件管理模块
+ 文件上传是很多系统都会涉及到的一个基础功能，在ABP的模块化思路下，做成了一个通用的模块，本模块使用abp 自带的blob 存储
  - <font size="4" style="font-weight:bold">安装</font>

    - Kings.AbpVnextPro.File.Application
  
    - Kings.AbpVnextPro.File.Application.Contracts
 
    - Kings.AbpVnextPro.File.Domain
   
    - Kings.AbpVnextPro.File.Domain.Shared

    - Kings.AbpVnextPro.File.EntityFrameworkCore
 
    - Kings.AbpVnextPro.File.HttpApi

    - Kings.AbpVnextPro.DictFileionary.HttpApi.Client
  
  - <font size="4" style="font-weight:bold">模块依赖配置</font>
    - 添加 DependsOn(typeof(FileXxxModule)) 特性到对应模块
  
    - 在EntityFrameworkCore层添加数据库配置在AbpVnextProDbContext.cs的OnModelCreating()方法中添加builder.ConfigureFile()


## 职能机构模块
+ 本模块中的职能机构主要就两个元素部门和岗位，很多系统中都会设计到部门和岗位的管理
  - <font size="4" style="font-weight:bold">安装</font>

    - Kings.AbpVnextPro.Institution.Application
  
    - Kings.AbpVnextPro.Institution.Application.Contracts
 
    - Kings.AbpVnextPro.Institution.Domain
   
    - Kings.AbpVnextPro.Institution.Domain.Shared

    - Kings.AbpVnextPro.Institution.EntityFrameworkCore
 
    - Kings.AbpVnextPro.Institution.HttpApi

    - Kings.AbpVnextPro.Institution.HttpApi.Client
  
  - <font size="4" style="font-weight:bold">模块依赖配置</font>
    - 添加 DependsOn(typeof(InstitutionXxxModule)) 特性到对应模块
  
    - 在EntityFrameworkCore层添加数据库配置在AbpVnextProDbContext.cs的OnModelCreating()方法中添加builder.ConfigureInstitution()
  
## 支付中心模块
> 本模块中需要配合[基础内容](/zh-cn/basiccontent.md)中的配置中心一起使用，配置中心用来配置支付接口一些配置信息
+ 本模块中与[基础内容](/zh-cn/basiccontent.md)的微信和支付宝支付不同的是，本模块在此基础上完成了所有的支付接口和回调接口，用户安装此模块后就可以直接使用，且如果不符合自己业务逻辑可以进行重写
  - <font size="4" style="font-weight:bold">安装</font>

    - Kings.AbpVnextPro.PayCenter.Application
  
    - Kings.AbpVnextPro.PayCenter.Application.Contracts
 
    - Kings.AbpVnextPro.PayCenter.Domain
   
    - Kings.AbpVnextPro.PayCenter.Domain.Shared

    - Kings.AbpVnextPro.PayCenter.EntityFrameworkCore
 
    - Kings.AbpVnextPro.PayCenter.HttpApi

    - Kings.AbpVnextPro.PayCenter.HttpApi.Client
  
  - <font size="4" style="font-weight:bold">模块依赖配置</font>
    - 添加 DependsOn(typeof(PayCenterXxxModule)) 特性到对应模块
  
    - 在EntityFrameworkCore层添加数据库配置在AbpVnextProDbContext.cs的OnModelCreating()方法中添加builder.Configurexxx()(如果模块中不涉及到表可以不用配置)

## 计划任务模块
> 本模块中设计报警通知功能，有站内信通知，需要站内信通知 则需要一起安装 通知中心模块配合使用。否则站内信无法使用
+ 计划任务是很多系统都会使用到的一个功能，本模块根据Quartz.net封装了一个通用的模块，配合前端页面让计划任务可视化，配合corn 表达式完成各种复杂的执行计划
  - <font size="4" style="font-weight:bold">安装</font>

    - Kings.AbpVnextPro.ScheduleTask.Application
  
    - Kings.AbpVnextPro.ScheduleTask.Application.Contracts
 
    - Kings.AbpVnextPro.ScheduleTask.Domain
   
    - Kings.AbpVnextPro.ScheduleTask.Domain.Shared

    - Kings.AbpVnextPro.ScheduleTask.EntityFrameworkCore
 
    - Kings.AbpVnextPro.ScheduleTask.HttpApi

    - Kings.AbpVnextPro.ScheduleTask.HttpApi.Client
  
  - <font size="4" style="font-weight:bold">模块依赖配置</font>
    - 添加 DependsOn(typeof(ScheduleTaskXxxModule)) 特性到对应模块
  
    - 在EntityFrameworkCore层添加数据库配置在AbpVnextProDbContext.cs的OnModelCreating()方法中添加builder.ConfigureScheduleTask()

## 通知中心模块
 + 集成 Abp Vnext SignalR,实现类似站内信模块
   - 发送消息会在前端右上角，根据不同消息等级有不同的窗体提示。
   <img src="/_media/notciesigla.png" />
   - 在右上角灯泡按钮可以看到接受的消息(消息一般是针对用户发送的，通知是一些广播类的消息如公告)
   
    <table  align="center">
        <tr>
            <td>
                <center>
                <font >消息</font>
                <br/>
                <img src="/_media/noticenotice.png"  />
                </center>
            </td>
            <td>
                <center>
            <font >通知</font>
            <br/>
                    <img src="/_media/noticecommon.png" />
                </center>
            </td>
        </tr>
    </table>
    
    - <font size="4" style="font-weight:bold">安装</font>

      - Kings.AbpVnextPro.Notice.Application
  
      - Kings.AbpVnextPro.Notice.Application.Contracts
 
      - Kings.AbpVnextPro.Notice.Domain
   
      - Kings.AbpVnextPro.Notice.Domain.Shared

      - Kings.AbpVnextPro.Notice.EntityFrameworkCore
 
      - Kings.AbpVnextPro.Notice.HttpApi

      - Kings.AbpVnextPro.Notice.HttpApi.Client
  
    - <font size="4" style="font-weight:bold">模块依赖配置</font>
      - 添加 DependsOn(typeof(InstitutionXxxModule)) 特性到对应模块
  
      - 在EntityFrameworkCore层添加数据库配置在AbpVnextProDbContext.cs的OnModelCreating()方法中添加builder.ConfigureNotice()

      - 前端 配置 SinglaR 地址(VUE_APP_SOCKET_API)
      ~~~sh
        # just a flag
        ENV = 'development'
        #socket API
        VUE_APP_SOCKET_API = '/signalr-hubs/notification'
      ~~~

## 工作流模块

**持续开发中。。。。。。**