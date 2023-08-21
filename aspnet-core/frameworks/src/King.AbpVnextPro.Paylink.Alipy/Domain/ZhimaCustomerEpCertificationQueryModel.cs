﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ZhimaCustomerEpCertificationQueryModel Data Structure.
    /// </summary>
    public class ZhimaCustomerEpCertificationQueryModel : AlipayObject
    {
        /// <summary>
        /// 一次认证的唯一标识，通过<a href="https://opendocs.alipay.com/apis/api_8/zhima.customer.ep.certification.initialize">zhima.customer.ep.certification.initialize</a>(企业认证初始化)接口完成芝麻认证初始化后获取。
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }
    }
}
