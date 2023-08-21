using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Settings;

namespace King.AbpVnextPro.PayCenter.PayCenter
{
    public class PayCenterManager : IPayCenterManager
    {
        private readonly IServiceCollection _services;
        private readonly ISettingProvider _settingProvider;

        public PayCenterManager(IServiceCollection services,ISettingProvider  settingProvider) 
        {
            this._services = services;
            this._settingProvider = settingProvider;
        }
    }
}
