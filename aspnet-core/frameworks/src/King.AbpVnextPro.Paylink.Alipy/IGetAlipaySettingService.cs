using System;
using System.Collections.Generic;
using System.Text;

namespace King.AbpVnextPro.Paylink.Alipy
{
    public interface IGetAlipaySettingService
    {
        Task<AlipayOptions> GetAlipaySettingAsync();
    }
}
