using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;
using Volo.Abp.AspNetCore.SignalR;
using King.AbpVnextPro.Notice.Notifications.Hub;

namespace King.AbpVnextPro.Notice;

[DependsOn(
    typeof(NoticeDomainModule),
    typeof(NoticeApplicationContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpAutoMapperModule),
    typeof(AbpAspNetCoreSignalRModule)
    )]
public class NoticeApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<NoticeApplicationModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<NoticeApplicationModule>(validate: false);
        });

        Configure<AbpSignalROptions>(options =>
        {
            options.Hubs.AddOrUpdate(
               typeof(NotificationHub), //Hub type
               config => //Additional configuration
               {
                   config.ConfigureActions.Add(hubOptions =>
                   {
                       //Additional options
                      // hubOptions.LongPolling.PollTimeout = TimeSpan.FromSeconds(30);
                       hubOptions.Transports = Microsoft.AspNetCore.Http.Connections.HttpTransportType.WebSockets;
                   });
               }
           );
        });
    }
}
