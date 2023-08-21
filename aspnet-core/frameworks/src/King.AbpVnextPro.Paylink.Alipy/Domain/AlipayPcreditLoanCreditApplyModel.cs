﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayPcreditLoanCreditApplyModel Data Structure.
    /// </summary>
    public class AlipayPcreditLoanCreditApplyModel : AlipayObject
    {
        /// <summary>
        /// 授权授信状态，取值范围{"unAuthorized", "authorized"}, authorized-已授权, unAuthorized-未授权
        /// </summary>
        [JsonPropertyName("authorized_status")]
        public string AuthorizedStatus { get; set; }

        /// <summary>
        /// 授信申请回跳地址，商户端提供的地址
        /// </summary>
        [JsonPropertyName("back_url")]
        public string BackUrl { get; set; }

        /// <summary>
        /// 授信申请业务标准外部订单号，代表商户端自己订单号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 代表了一次请求，作为业务幂等性控制
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
