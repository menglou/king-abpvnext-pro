﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipaySecurityProdSeAppletQueryModel Data Structure.
    /// </summary>
    public class AlipaySecurityProdSeAppletQueryModel : AlipayObject
    {
        /// <summary>
        /// 操作类型，唯一，传递tsm的具体操作，厂测程序提供
        /// </summary>
        [JsonPropertyName("opt_type")]
        public long OptType { get; set; }

        /// <summary>
        /// 基本参数，json数组传递，调用tsm时提供对应的参数，厂测程序提供
        /// </summary>
        [JsonPropertyName("param")]
        public string Param { get; set; }

        /// <summary>
        /// 商户和支付宝交互时，用于代表支付宝分配给商户ID
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// se编号，唯一，用于tsm校验，厂测程序传入
        /// </summary>
        [JsonPropertyName("se_id")]
        public string SeId { get; set; }

        /// <summary>
        /// se版本号，唯一，用于获取applet包对应版本的地址，厂测程序调用时传入
        /// </summary>
        [JsonPropertyName("se_version")]
        public string SeVersion { get; set; }

        /// <summary>
        /// 子操作类型，用于调用tsm，厂测程序提供
        /// </summary>
        [JsonPropertyName("sub_opt_type")]
        public long SubOptType { get; set; }
    }
}
