using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Settings;

namespace King.AbpVnextPro.Paylink.Alipy
{
    public class GetAlipaySettingService: IGetAlipaySettingService
    {
        private readonly ISettingProvider _settingProvider;

        public GetAlipaySettingService(ISettingProvider settingProvider)
        {
            _settingProvider = settingProvider;
        }
        public virtual async Task<AlipayOptions> GetAlipaySettingAsync()
        {
            AlipayOptions alipayOptions = new AlipayOptions();
            alipayOptions.AppId = await _settingProvider.GetOrNullAsync("PayCenter.Alipay.AppId");
            alipayOptions.AlipayPublicKey = await _settingProvider.GetOrNullAsync("PayCenter.Alipay.AlipayPublicKey");
            alipayOptions.AppPrivateKey = await _settingProvider.GetOrNullAsync("PayCenter.Alipay.AppPrivateKey");
            alipayOptions.ServerUrl = await _settingProvider.GetOrNullAsync("PayCenter.Alipay.ServerUrl");
            alipayOptions.Version = await _settingProvider.GetOrNullAsync("PayCenter.Alipay.Version");
            alipayOptions.SignType = await _settingProvider.GetOrNullAsync("PayCenter.Alipay.SignType");
            alipayOptions.EncryptKey = await _settingProvider.GetOrNullAsync("PayCenter.Alipay.EncryptKey");
            alipayOptions.AppPublicCert = await _settingProvider.GetOrNullAsync("PayCenter.Alipay.AppPublicCert");
            alipayOptions.AlipayPublicCert = await _settingProvider.GetOrNullAsync("PayCenter.Alipay.AlipayPublicCert");
            alipayOptions.AlipayRootCert = await _settingProvider.GetOrNullAsync("PayCenter.Alipay.AlipayRootCert");
       
            return alipayOptions;
        }
    }
}
