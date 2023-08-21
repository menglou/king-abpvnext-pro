using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Settings;

namespace King.AbpVnextPro.Paylink.WeChat
{
    public class GetWeChatSettingService: IGetWeChatSettingService
    {
        private readonly ISettingProvider _settingProvider;

        public GetWeChatSettingService(ISettingProvider settingProvider)
        {
            _settingProvider = settingProvider;
        }
        public virtual async Task<WeChatPayOptions> GetWeChatSettingAsync()
        {
            WeChatPayOptions weChatPayOptions = new WeChatPayOptions();
            weChatPayOptions.AppId = await _settingProvider.GetOrNullAsync("PayCenter.Wechat.AppId");
            weChatPayOptions.AppSecret = await _settingProvider.GetOrNullAsync("PayCenter.Wechat.AppSecret");
            weChatPayOptions.MchId = await _settingProvider.GetOrNullAsync("PayCenter.Wechat.MchId");
            weChatPayOptions.SubAppId = await _settingProvider.GetOrNullAsync("PayCenter.Wechat.SubAppId");
            weChatPayOptions.SubMchId = await _settingProvider.GetOrNullAsync("PayCenter.Wechat.SubMchId");
            weChatPayOptions.Certificate = await _settingProvider.GetOrNullAsync("PayCenter.Wechat.Certificate");
            weChatPayOptions.CertificatePassword = await _settingProvider.GetOrNullAsync("PayCenter.Wechat.CertificatePassword");
            weChatPayOptions.APIPrivateKey = await _settingProvider.GetOrNullAsync("PayCenter.Wechat.APIPrivateKey");
            weChatPayOptions.APIKey = await _settingProvider.GetOrNullAsync("PayCenter.Wechat.APIKey");
            weChatPayOptions.APIv3Key = await _settingProvider.GetOrNullAsync("PayCenter.Wechat.APIv3Key");
            weChatPayOptions.RsaPublicKey = await _settingProvider.GetOrNullAsync("PayCenter.Wechat.RsaPublicKey");
          
            return weChatPayOptions;
        }
    }
}
