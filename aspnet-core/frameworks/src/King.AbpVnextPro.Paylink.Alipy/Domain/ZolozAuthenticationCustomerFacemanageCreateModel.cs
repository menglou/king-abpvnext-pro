﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ZolozAuthenticationCustomerFacemanageCreateModel Data Structure.
    /// </summary>
    public class ZolozAuthenticationCustomerFacemanageCreateModel : AlipayObject
    {
        /// <summary>
        /// 地域编码
        /// </summary>
        [JsonPropertyName("areacode")]
        public string Areacode { get; set; }

        /// <summary>
        /// 人脸产品能力，预热场景，需要传college，k12，scenic，subway，traffic。具体值视具体场景
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 业务量规模
        /// </summary>
        [JsonPropertyName("bizscale")]
        public string Bizscale { get; set; }

        /// <summary>
        /// 商户品牌
        /// </summary>
        [JsonPropertyName("brandcode")]
        public string Brandcode { get; set; }

        /// <summary>
        /// 商户机具唯一编码，关键参数 人脸预热，传logicGroupId
        /// </summary>
        [JsonPropertyName("devicenum")]
        public string Devicenum { get; set; }

        /// <summary>
        /// 拓展参数
        /// </summary>
        [JsonPropertyName("extinfo")]
        public string Extinfo { get; set; }

        /// <summary>
        /// 入库类型 IDCARD:身份证 ALIPAY_USER:支付宝用户id, ALIPAY_TEL:手机号入库 CUSTOMER:自定义 DIRECT_CLIENT_PRE：本地预写入 DIRECT_CLIENT：本地客户端库 ENCLOSED：封闭场景
        /// </summary>
        [JsonPropertyName("facetype")]
        public string Facetype { get; set; }

        /// <summary>
        /// 入库用户信息 人脸预热，alipayUid必填
        /// </summary>
        [JsonPropertyName("faceval")]
        public string Faceval { get; set; }

        /// <summary>
        /// 分组5
        /// </summary>
        [JsonPropertyName("group")]
        public string Group { get; set; }

        /// <summary>
        /// 门店编码
        /// </summary>
        [JsonPropertyName("storecode")]
        public string Storecode { get; set; }

        /// <summary>
        /// 有效期天数，如7天、30天、365天
        /// </summary>
        [JsonPropertyName("validtimes")]
        public string Validtimes { get; set; }
    }
}
