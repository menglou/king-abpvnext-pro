﻿using King.AbpVnextPro.Paylink.Alipy;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void AddAlipay(this IServiceCollection services)
        {
            services.AddHttpClient(nameof(AlipayClient));
            services.AddHttpClient(nameof(AlipayMobilePublicMultiMediaClient));

            services.AddSingleton<AlipayPublicKeyManager>();
            services.AddSingleton<IAlipayClient, AlipayClient>();
            services.AddSingleton<IAlipayMobilePublicMultiMediaClient, AlipayMobilePublicMultiMediaClient>();
            services.AddSingleton<IAlipayNotifyClient, AlipayNotifyClient>();
        }
    }
}
