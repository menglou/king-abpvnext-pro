﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ZolozIdentificationCustomerEnrollcertifyInitializeModel Data Structure.
    /// </summary>
    public class ZolozIdentificationCustomerEnrollcertifyInitializeModel : AlipayObject
    {
        /// <summary>
        /// 商户请求的唯一标志，该标识作为对账的关键信息，商户要保证其唯一性
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务场景名字
        /// </summary>
        [JsonPropertyName("biz_scene_name")]
        public string BizSceneName { get; set; }

        /// <summary>
        /// 实人信息：证件名字
        /// </summary>
        [JsonPropertyName("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 实人信息：证件号
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 实人信息：证件类型
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 0：匿名注册  1：匿名认证   2：实名认证
        /// </summary>
        [JsonPropertyName("face_type")]
        public long FaceType { get; set; }

        /// <summary>
        /// 人脸引导页是否显示
        /// </summary>
        [JsonPropertyName("has_welcome_page")]
        public bool HasWelcomePage { get; set; }

        /// <summary>
        /// metainfo环境参数
        /// </summary>
        [JsonPropertyName("metainfo")]
        public string Metainfo { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 商户的用户id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
