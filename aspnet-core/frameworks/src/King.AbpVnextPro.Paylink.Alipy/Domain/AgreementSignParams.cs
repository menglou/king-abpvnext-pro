﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AgreementSignParams Data Structure.
    /// </summary>
    public class AgreementSignParams : AlipayObject
    {
        /// <summary>
        /// 商户在芝麻端申请的appId
        /// </summary>
        [JsonPropertyName("buckle_app_id")]
        public string BuckleAppId { get; set; }

        /// <summary>
        /// 商户在芝麻端申请的merchantId
        /// </summary>
        [JsonPropertyName("buckle_merchant_id")]
        public string BuckleMerchantId { get; set; }

        /// <summary>
        /// 商户签约号，代扣协议中标示用户的唯一签约号（确保在商户系统中唯一）。  格式规则：支持大写小写字母和数字，最长32位。  商户系统按需传入，如果同一用户在同一产品码、同一签约场景下，签订了多份代扣协议，那么需要指定并传入该值。
        /// </summary>
        [JsonPropertyName("external_agreement_no")]
        public string ExternalAgreementNo { get; set; }

        /// <summary>
        /// 用户在商户网站的登录账号，用于在签约页面展示，如果为空，则不展示
        /// </summary>
        [JsonPropertyName("external_logon_id")]
        public string ExternalLogonId { get; set; }

        /// <summary>
        /// 个人签约产品码，商户和支付宝签约时确定。
        /// </summary>
        [JsonPropertyName("personal_product_code")]
        public string PersonalProductCode { get; set; }

        /// <summary>
        /// 签约营销参数，此值为json格式；具体的key需与营销约定
        /// </summary>
        [JsonPropertyName("promo_params")]
        public string PromoParams { get; set; }

        /// <summary>
        /// 协议签约场景，商户和支付宝签约时确定。  当传入商户签约号external_agreement_no时，场景不能为默认值DEFAULT|DEFAULT。
        /// </summary>
        [JsonPropertyName("sign_scene")]
        public string SignScene { get; set; }

        /// <summary>
        /// 当前用户签约请求的协议有效周期。  整形数字加上时间单位的协议有效期，从发起签约请求的时间开始算起。  目前支持的时间单位：  1. d：天  2. m：月  如果未传入，默认为长期有效。
        /// </summary>
        [JsonPropertyName("sign_validity_period")]
        public string SignValidityPeriod { get; set; }

        /// <summary>
        /// 签约第三方主体类型。对于三方协议，表示当前用户和哪一类的第三方主体进行签约。  取值范围：  1. PARTNER（平台商户）;  2. MERCHANT（集团商户），集团下子商户可共享用户签约内容;  默认为PARTNER。
        /// </summary>
        [JsonPropertyName("third_party_type")]
        public string ThirdPartyType { get; set; }
    }
}
