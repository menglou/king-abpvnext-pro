## 基础方法

+ 扩展方法
  
<img src="_media/extendmethod.png"  />

+ 通用方法
   - 阿里云发短信
  
   - 发邮件
  
   - 微信小程序登录获取openid，获取手机号等
  

  <img src="_media/commonmethod.png"  />

---

## 配置中心

>配置系统是在启动时配置应用程序很好的方式. 除了配置之外, ABP 提供了另外一种设置和获取应用程序设置的方式. 设置存储在动态数据源(通常是数据库)中的键值对. 设置系统预构建了用户,租户,全局和默认设置方法并且可以进行扩展,本系统使用[EasyAbp](https://github.com/EasyAbp/Abp.SettingUi)作为基础在各个模块中配置相应的参数
>
>参考[AbpVnext官方文档中的设置管理](https://docs.abp.io/zh-Hans/abp/latest/Settings)

##### 概览

<img  src="_media/settting.png"  align=center style="height:300px" />

##### 配置步骤

>和官方 Setting 模块区别，值添加了 2 个属性，一个分组，一个组件类型

+ xxx.xxx.Doamin 层的Settings 文件夹下面配置相应的参数

  <table  align="center">
    <tr>
      <td>
        <center>
              <img src="_media/setttingdefine.png" />
        </center>
      </td>
      <td>
        <center>
          <img src="_media/settingdefinestatic.png"  />
        </center>
      </td>
    </tr>
  </table>

  - SettingDefinition 类具有以下属性:

  - Name: 应用程序中设置的唯一名称. 是具有约束的唯一属性, 在应用程序获取/设置此设置的值 (设置名称定义为常量而不是魔法字符串是个好主意).

  - DefaultValue: 设置的默认值.

  - DisplayName: 本地化的字符串,用于在 UI 上显示名称.

  - Description: 本地化的字符串,用于在 UI 上显示描述.

  - 上面添加了 2 个属性，为了适配 vue 前端，一个设置 Setting 属于哪个分组，一个是根据 Setting 的类型指定对应的前端组件，比如字符串就是,Input 组件。

  - 支持以下组件：Text，CheckBox，Number

---

+ xxx.xxx.Doamin.Shared Localization 文件夹下面配置相应本地化
   
   <img  src="_media/settinglocalization.png"  align=center  />

+ 读取设置值
   - ISettingProvider
   - ISettingProvider 用于获取指定设置的值或所有设置的值. 示例用法:
  <div >
   <pre style="background-color:#282c34;border-radius:6px;color:#fff;color:#fff">
    public class MyService
      {
          private readonly ISettingProvider _settingProvider;
          Inject ISettingProvider in the constructor
          public MyService(ISettingProvider settingProvider)
          {
              _settingProvider = settingProvider;
          }
          public async Task FooAsync()
          {
              //Get a value as string.
              string userName = await _settingProvider.GetOrNullAsync("Smtp.UserName");
              //Get a bool value and fallback to the default value (false) if not set.
              bool enableSsl = await _settingProvider.GetAsync<bool>("Smtp.EnableSsl");
              //Get a bool value and fallback to the provided default value (true) if not set.
              bool enableSsl = await _settingProvider.GetAsync<bool>("Smtp.EnableSsl", defaultValue: true);
              //Get a bool value with the IsTrueAsync shortcut extension method
              bool enableSsl = await _settingProvider.IsTrueAsync("Smtp.EnableSsl");
              //Get an int value or the default value (0) if not set
              int port = (await _settingProvider.GetAsync<int>("Smtp.Port"));
              //Get an int value or null if not provided
              int? port = (await _settingProvider.GetOrNullAsync("Smtp.Port"))?.To<int>();
          }
      }
   </pre>
  </div>
---

## ElasticSearch

+ 安装

  - 添加以下 NuGet 包到你的项目
   
  - Kings.AbpVnextPro.ElasticSearch
   
  - 添加 [DependsOn(typeof(AbpVnextProElasticSearchModule))] 到你的项目模块类.

  - 通过appsetting.json 去配置相应的参数

<div >
  <pre style="background-color:#282c34;border-radius:6px;color:#fff;color:#fff">
    
    "ElasticSearch": {
     "Host": "http://localhost:1200",
     "UserName": "admin",
     "Password": "1q2w3E*"
    }
  </pre>
</div>  

---



## 支付宝支付

+ 安装

  - 添加以下 NuGet 包到你的项目
   
  - Kings.AbpVnextPro.Paylink.Alipy

  - Kings.AbpVnextPro.Paylink.Security
   
  - 添加 [DependsOn(typeof(AbpVnextProPaylinkAlipayModule))] 到你的项目模块类(如果不是abp vnext 的项目则不需要这个步骤)
   
  - 通过appsetting.json 去配置相应的参数
   
<div >
  <pre style="background-color:#282c34;border-radius:6px;color:#fff;color:#fff">

   支付宝
   更多配置，请查看AlipayOptions类
  "Alipay": {
     注意: 
     若涉及资金类支出接口(如转账、红包等)接入，必须使用“公钥证书”方式。不涉及到资金类接口，也可以使用“普通公钥”方式进行加签。
     本示例默认的加签方式为“公钥证书”方式，并调用 CertificateExecuteAsync 方法 执行API。
     若使用“普通公钥”方式，除了遵守下方注释的规则外，调用 CertificateExecuteAsync 也需改成 ExecuteAsync。
     支付宝后台密钥/证书官方配置教程：https://opendocs.alipay.com/open/291/105971
     密钥格式：请选择 PKCS1(非JAVA适用)，切记 切记 切记

     应用Id
     为支付宝开放平台-APPID
    "AppId": "",

     支付宝公钥 RSA公钥
     为支付宝开放平台-支付宝公钥
     “公钥证书”方式时，留空
     “普通公钥”方式时，必填
    "AlipayPublicKey": "",

     应用私钥 RSA私钥
     为“支付宝开放平台开发助手”所生成的应用私钥
    "AppPrivateKey": "",

     服务网关地址
     默认为正式环境地址
    "ServerUrl": "https://openapi.alipay.com/gateway.do",

     签名类型
     支持：RSA2(SHA256WithRSA)、RSA1(SHA1WithRSA)
     默认为RSA2
    "SignType": "RSA2",

     应用公钥证书
     可为证书文件路径 / 证书文件的base64字符串
     “公钥证书”方式时，必填
     “普通公钥”方式时，留空
    "AppPublicCert": "",

     支付宝公钥证书
     可为证书文件路径 / 证书文件的base64字符串
     “公钥证书”方式时，必填
     “普通公钥”方式时，留空
    "AlipayPublicCert": "",

     支付宝根证书
     可为证书文件路径 / 证书文件的base64字符串
     “公钥证书”方式时，必填
     “普通公钥”方式时，留空
    "AlipayRootCert": ""
  }

   </pre>
 </div>
--- 
   
## 微信支付

+ 安装

  - 添加以下 NuGet 包到你的项目
   
  - Kings.AbpVnextPro.Paylink.Wechat

  - Kings.AbpVnextPro.Paylink.Security
   
  - 添加 [DependsOn(typeof(AbpVnextProPaylinkWeChatModule))] 到你的项目模块类(如果不是abp vnext 的项目则不需要这个步骤)
   
  - 通过appsetting.json 去配置相应的参数
   
<div >
  <pre style="background-color:#282c34;border-radius:6px;color:#fff;color:#fff">

   微信支付
   更多配置，请查看WeChatPayOptions类
  "WeChatPay": {
     应用号
     如：微信公众平台AppId、微信开放平台AppId、微信小程序AppId、企业微信CorpId等
    "AppId": "wx9d353c6f2ee51f1c",

     商户号
     为微信支付商户平台的商户号
    "MchId": "1645265532",

     商户API密钥
     为微信支付商户平台的API密钥，请注意不是APIv3密钥
    "APIKey": "",

     商户APIv3密钥
     为微信支付商户平台的APIv3密钥，请注意不是API密钥，v3接口必填
    "APIv3Key": "A0yMMa7mo7khMPV7vX22SpGwrHm093im",

     商户API证书
     使用V2退款、付款等接口时必填
     使用V3接口时必填
     可为证书文件路径 / 证书文件的base64字符串
    "Certificate": "E:\\test\\src\\LZ.DMS.HttpApi.Host\\wwwroot\\wechatcertificate\\apiclient_cert.p12",

     商户API私钥
     当配置了P12格式证书时，已包含私钥，不必再单独配置API私钥。
     PEM格式证书，需要单独配置。
    "APIPrivateKey": "",

     RSA公钥
     目前仅调用"企业付款到银行卡API [V2]"时使用，执行本示例中的"获取RSA加密公钥API [V2]"即可获取。
    "RsaPublicKey": ""
  }

 </pre>
</div>


