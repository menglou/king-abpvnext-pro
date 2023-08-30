using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;
using King.AbpVnextPro.Core;
using King.AbpVnextPro.ScheduleTask.ScheduleMaster.Manager;
using Quartz.Spi;
using King.AbpVnextPro.ScheduleTask.ScheduleMaster.Job;
using Volo.Abp;
using King.AbpVnextPro.ScheduleTask.Schedules;
using Volo.Abp.Users;
using King.AbpVnextPro.Notice;
using Autofac.Core;
using King.AbpVnextPro.Core.Extensions;

namespace King.AbpVnextPro.ScheduleTask;

[DependsOn(
    typeof(ScheduleTaskDomainModule),
    typeof(ScheduleTaskApplicationContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpAutoMapperModule),
    typeof(AbpVnextProCoreModule),
    typeof(NoticeApplicationModule)
    
    )]
public class ScheduleTaskApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<ScheduleTaskApplicationModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<ScheduleTaskApplicationModule>(validate: false);
        });
        context.Services.AddHttpClient();
        //配置 quartz
        context.Services.AddSingleton<IJobFactory, JobFactory>();
        context.Services.AddSingleton<HttpJob>();
        context.Services.AddSingleton<AssemblyJob>();
        context.Services.AddSingleton<IQuartzManager, QuartzManager>();

    }

    public override Task OnApplicationInitializationAsync(ApplicationInitializationContext context)
    {
        IQuartzManager quartzManager = context.ServiceProvider.GetService<IQuartzManager>();
        IScheduleEntityAppService _scheduleEntityAppService = context.ServiceProvider.GetService<IScheduleEntityAppService>();
        var schedulelist = _scheduleEntityAppService.GetListAllAsync(new GetScheduleTaskListDto() { ScheduleStatus = ScheduleStatus.Running });
        ////程序启动后注册所有定时任务
        foreach (var task in schedulelist.Result)
        {
            quartzManager.AddTaskScheduleAsync(task);
        }
        return base.OnApplicationInitializationAsync(context);
    }

    public override void OnApplicationShutdown(ApplicationShutdownContext context)
    {
        IQuartzManager quartzManager = context.ServiceProvider.GetRequiredService<IQuartzManager>();
        quartzManager.Shutdown(true);
        base.OnApplicationShutdown(context);
    }
}
