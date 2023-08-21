using System;
using System.Collections.Generic;
using System.Text;

namespace King.AbpVnextPro.Paylink.WeChat
{
    public interface IGetWeChatSettingService
    {
        Task<WeChatPayOptions> GetWeChatSettingAsync();
    }
}
