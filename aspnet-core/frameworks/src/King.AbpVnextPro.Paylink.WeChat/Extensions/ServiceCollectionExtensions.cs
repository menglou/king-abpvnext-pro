using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Http;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void AddWeChatPay(this IServiceCollection services)
        {
            services.AddHttpClient(King.AbpVnextPro.Paylink.WeChat.V2.WeChatPayClient.Name);
            services.TryAddEnumerable(ServiceDescriptor.Singleton<IHttpMessageHandlerBuilderFilter, King.AbpVnextPro.Paylink.WeChat.V2.WeChatPayHttpMessageHandlerBuilderFilter>());
            services.AddSingleton<King.AbpVnextPro.Paylink.WeChat.V2.WeChatPayClientCertificateManager>();
            services.AddSingleton<King.AbpVnextPro.Paylink.WeChat.V2.IWeChatPayClient, King.AbpVnextPro.Paylink.WeChat.V2.WeChatPayClient>();
            services.AddSingleton<King.AbpVnextPro.Paylink.WeChat.V2.IWeChatPayNotifyClient, King.AbpVnextPro.Paylink.WeChat.V2.WeChatPayNotifyClient>();

            services.AddHttpClient(King.AbpVnextPro.Paylink.WeChat.V3.WeChatPayClient.Name);
            services.AddSingleton<King.AbpVnextPro.Paylink.WeChat.V3.WeChatPayPlatformCertificateManager>();
            services.AddSingleton<King.AbpVnextPro.Paylink.WeChat.V3.IWeChatPayClient, King.AbpVnextPro.Paylink.WeChat.V3.WeChatPayClient>();
            services.AddSingleton<King.AbpVnextPro.Paylink.WeChat.V3.IWeChatPayNotifyClient, King.AbpVnextPro.Paylink.WeChat.V3.WeChatPayNotifyClient>();
        }
    }
}
