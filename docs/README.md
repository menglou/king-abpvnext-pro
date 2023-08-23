# 连接

1. [文档地址](https://menglou.github.io/)
2. [Gitee 国内用户可访问该地址在线预览](https://zljlm.gitee.io/)
3. [预览地址](https://menglou.github.io/)

# 快速开始

1. 安装Cli
><font size="5">dotnet tool install -g King.AbpVnextPro.Cli</font>
2. 更新Cli
><font size="5">dotnet tool update -g  King.AbpVnextPro.Cli</font>
3. 卸载Cli
><font size="5">dotnet tool uninstall -g King.AbpVnextPro.Cli  --no-cache</font>

# 生成项目

### identityserver4 
1. nuget包形式的identityserver4 鉴权方式的版本
2. abp vnext  自带的所有模块，pro 的通知模块,数据字典，文件管理，职能机构，支付中心,计划任务
><font size="5">king.abp new -t pro.id4.all -c 公司名称 -p 项目名称 -v 版本(默认LastRelease) -o 默认当前控制台执行目录</font>

### openiddict
1. nuget包形式的identityserver4 鉴权方式的版本
2. abp vnext  自带的所有模块，pro 的通知模块,数据字典，文件管理，职能机构，支付中心，计划任务
><font size="5">king.abp new -t pro.openiddict.all -c 公司名称 -p 项目名称 -v 版本(默认LastRelease) -o 默认当前控制台执行目录</font>

# 功能

### 功能列表
<div style="background-color:#282c34;border-radius:6px;color:#fff;padding:8px 0px">
<ul class="condition">
<li>用户管理</li>
<li>角色管理</li>
<li>审计日志</li>
<li>登录日志</li>
<li>计划任务</li>
<li>集成事件</li>
<li>SinglaR 消息通知(站内信)</li>
<li>多语言</li>
<li>数据字典</li>
<li>文件管理</li>
<li>支付中心</li>
<li>工作流</li>
<li>ES 日志</li>
<li>配置中心</li>
<li>多租户</li>
</ul>
</div>

### 部分页面展示
<img src="/_media/login.png"  align=center style="margin-bottom:20px" />

<img src="/_media/settting.png"  align=center style="margin-bottom:20px" />

<img src="/_media/scheduletask.png"  align=center style="margin-bottom:20px" />

<img src="/_media/audlog.png"  align=center style="margin-bottom:20px" />

<img src="/_media/tenant.png"  align=center style="margin-bottom:20px" />

<img src="/_media/department.png"  align=center style="margin-bottom:20px" />

<img src="/_media/user.png"  align=center style="margin-bottom:50px" />



# 如何贡献

非常欢迎你的加入！提一个 Issue 或者提交一个 Pull Request。
##### Pull Request:
1. Fork 代码!
2. 创建自己的分支: git checkout -b feat/xxxx
3. 提交你的修改: git commit -am 'feat(function): add xxxxx'
4. 推送您的分支: git push origin feat/xxxx
5. 提交pull request

# Git 贡献提交规范

1. feat 增加新功能
2. fix 修复问题/BUG
3. style 代码风格相关无影响运行结果的
4. perf 优化/性能提升
5. refactor 重构
6. revert 撤销修改
7. test 测试相关
8. docs 文档/注释
9. chore 依赖更新/脚手架配置修改等


# 加入组织

欢迎大家加入群聊 QQ群：[1145603937]() 进行交流,或者扫码加入

<img src="/_media/qq.png"  align=center />


## 捐赠

> Star就是对该项目的最大肯定!
>
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
  .condition li{
    height:40px
  }
</style>