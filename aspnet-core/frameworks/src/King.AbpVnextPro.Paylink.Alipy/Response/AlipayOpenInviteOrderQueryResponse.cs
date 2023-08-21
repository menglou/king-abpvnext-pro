﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenInviteOrderQueryResponse.
    /// </summary>
    public class AlipayOpenInviteOrderQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商家支付宝账号对应的ID，2088开头
        /// </summary>
        [JsonPropertyName("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 产品签约状态对象
        /// </summary>
        [JsonPropertyName("sign_status_list")]
        public List<ProductInviteStatusInfo> SignStatusList { get; set; }
    }
}
