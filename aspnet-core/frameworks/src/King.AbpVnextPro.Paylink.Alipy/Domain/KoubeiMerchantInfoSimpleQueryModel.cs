﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiMerchantInfoSimpleQueryModel Data Structure.
    /// </summary>
    public class KoubeiMerchantInfoSimpleQueryModel : AlipayObject
    {
        /// <summary>
        /// 服务商、服务商员工、商户、商户员工等口碑角色操作时必填，对应为《koubei.member.data.oauth.query》中的auth_code，默认有效期24小时；isv自身角色操作的时候，无需传该参数
        /// </summary>
        [JsonPropertyName("auth_code")]
        public string AuthCode { get; set; }
    }
}
