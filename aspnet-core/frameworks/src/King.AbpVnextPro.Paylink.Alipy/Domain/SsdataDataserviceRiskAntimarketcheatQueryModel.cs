﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// SsdataDataserviceRiskAntimarketcheatQueryModel Data Structure.
    /// </summary>
    public class SsdataDataserviceRiskAntimarketcheatQueryModel : AlipayObject
    {
        /// <summary>
        /// 行为发生时的身份证号
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 调用服务的商户id ，如果是第三方服务商，需要将其实际的商户id透传过来，如果是普通商户传入自己的appid即可
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 行为发生时的手机号
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 风险场景码
        /// </summary>
        [JsonPropertyName("risk_code")]
        public string RiskCode { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [JsonPropertyName("sys_version")]
        public string SysVersion { get; set; }
    }
}
