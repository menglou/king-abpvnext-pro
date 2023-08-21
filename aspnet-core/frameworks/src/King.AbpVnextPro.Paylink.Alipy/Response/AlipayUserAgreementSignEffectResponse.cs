﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayUserAgreementSignEffectResponse.
    /// </summary>
    public class AlipayUserAgreementSignEffectResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝用户协议号, 用户签约成功后的支付宝协议号.
        /// </summary>
        [JsonPropertyName("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 支付宝账号: 脱敏的支付宝账号.
        /// </summary>
        [JsonPropertyName("alipay_logon_id")]
        public string AlipayLogonId { get; set; }

        /// <summary>
        /// 设备Id
        /// </summary>
        [JsonPropertyName("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 商户协议号, 代扣协议中标示用户的唯一签约号(确保在商户系统中唯一).
        /// </summary>
        [JsonPropertyName("external_agreement_no")]
        public string ExternalAgreementNo { get; set; }

        /// <summary>
        /// 商户登录Id
        /// </summary>
        [JsonPropertyName("external_logon_id")]
        public string ExternalLogonId { get; set; }

        /// <summary>
        /// 协议失效时间，格式为yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [JsonPropertyName("invalid_time")]
        public string InvalidTime { get; set; }

        /// <summary>
        /// 协议产品码，商户和支付宝签约时确定，不同业务场景对应不同的签约产品码。
        /// </summary>
        [JsonPropertyName("personal_product_code")]
        public string PersonalProductCode { get; set; }

        /// <summary>
        /// 签约主体类型。  CARD:支付宝账号  CUSTOMER:支付宝用户
        /// </summary>
        [JsonPropertyName("pricipal_type")]
        public string PricipalType { get; set; }

        /// <summary>
        /// 签约主体标识。  当principal_type为CARD 时，该字段为支付宝用户号;  当principal_type为CUSTOMER时，该字段为支付宝用户标识。一个用户可能有多个支付宝账号，即多个支付宝用户号，但只有一个是支付宝用户标识。  一个支付宝账号对应一个支付宝唯一用户号(以2088开头的16位纯数字组成)。
        /// </summary>
        [JsonPropertyName("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 签约协议的场景。
        /// </summary>
        [JsonPropertyName("sign_scene")]
        public string SignScene { get; set; }

        /// <summary>
        /// 协议签约时间，格式为yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [JsonPropertyName("sign_time")]
        public string SignTime { get; set; }

        /// <summary>
        /// 协议当前状态.  1. TEMP：暂存，协议未生效过；  2. NORMAL：正常；  3. STOP：暂停
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 签约第三方主体类型。对于三方协议，表示当前用户和哪一类的第三方主体进行签约。  取值范围：  1. PARTNER（平台商户）;  2. MERCHANT（集团商户），集团下子商户可共享用户签约内容;  默认为PARTNER。
        /// </summary>
        [JsonPropertyName("third_party_type")]
        public string ThirdPartyType { get; set; }

        /// <summary>
        /// 协议生效时间，格式为yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [JsonPropertyName("valid_time")]
        public string ValidTime { get; set; }

        /// <summary>
        /// 用户的芝麻信用 openId，供商户查询用户芝麻信用使用。
        /// </summary>
        [JsonPropertyName("zm_open_id")]
        public string ZmOpenId { get; set; }
    }
}
