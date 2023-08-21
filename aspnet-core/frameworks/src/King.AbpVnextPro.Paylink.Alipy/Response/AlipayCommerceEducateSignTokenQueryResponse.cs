﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceEducateSignTokenQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateSignTokenQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 业务场景类型标识
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 需要将该字段返回给学校
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型（"1","居民身份证"，"X":"学工号"）
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 家长支付宝账户的脱敏信息
        /// </summary>
        [JsonPropertyName("parent_logon_id")]
        public string ParentLogonId { get; set; }

        /// <summary>
        /// 家长id，如是本人开通，当前id与用户id相同
        /// </summary>
        [JsonPropertyName("parent_user_id")]
        public string ParentUserId { get; set; }

        /// <summary>
        /// 学校内标
        /// </summary>
        [JsonPropertyName("school_code")]
        public string SchoolCode { get; set; }

        /// <summary>
        /// 校园一脸通行开通状态。OPEN：开通，CLOSE：关闭
        /// </summary>
        [JsonPropertyName("school_face_pass_status")]
        public string SchoolFacePassStatus { get; set; }

        /// <summary>
        /// 校园一脸通行刷脸支付开通状态。OPEN：开通，CLOSE：关闭
        /// </summary>
        [JsonPropertyName("school_face_payment_status")]
        public string SchoolFacePaymentStatus { get; set; }

        /// <summary>
        /// 学校外标（即学校的统一信用编码）
        /// </summary>
        [JsonPropertyName("school_stdcode")]
        public string SchoolStdcode { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
