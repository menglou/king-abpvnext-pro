﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayUserAntarchiveFaceIdentifyModel Data Structure.
    /// </summary>
    public class AlipayUserAntarchiveFaceIdentifyModel : AlipayObject
    {
        /// <summary>
        /// 比对业务场景，用于计费和限流等功能
        /// </summary>
        [JsonPropertyName("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 证件上的姓名
        /// </summary>
        [JsonPropertyName("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型,取值范围为:  100 居民身份证
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 请求人像，jpg格式，BASE64转换后字符串，大小限制为30K以内
        /// </summary>
        [JsonPropertyName("portrait")]
        public string Portrait { get; set; }

        /// <summary>
        /// 人脸区域坐标，格式为：left,top,right,bottom
        /// </summary>
        [JsonPropertyName("portrait_auth_rect")]
        public string PortraitAuthRect { get; set; }
    }
}
