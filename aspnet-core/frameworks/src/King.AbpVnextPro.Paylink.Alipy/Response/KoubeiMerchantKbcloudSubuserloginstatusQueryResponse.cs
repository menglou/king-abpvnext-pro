﻿using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiMerchantKbcloudSubuserloginstatusQueryResponse.
    /// </summary>
    public class KoubeiMerchantKbcloudSubuserloginstatusQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 口碑云登录的子账号信息；如果未登录则返回null
        /// </summary>
        [JsonPropertyName("user_login_status")]
        public UserLoginStatusDetail UserLoginStatus { get; set; }
    }
}
