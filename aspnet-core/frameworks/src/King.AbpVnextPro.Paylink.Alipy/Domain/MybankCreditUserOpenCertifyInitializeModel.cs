﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// MybankCreditUserOpenCertifyInitializeModel Data Structure.
    /// </summary>
    public class MybankCreditUserOpenCertifyInitializeModel : AlipayObject
    {
        /// <summary>
        /// 认证场景码。入参支持的认证场景码和商户签约的认证场景相关，取值如下: FACE：多因子人脸认证 CERT_PHOTO：多因子证照认证 CERT_PHOTO_FACE ：多因子证照和人脸认证 SMART_FACE：多因子快捷认证
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 自定义人脸比对图片的base64编码格式的string字符串
        /// </summary>
        [JsonPropertyName("face_contrast_picture")]
        public string FaceContrastPicture { get; set; }

        /// <summary>
        /// 需要验证的身份信息参数，格式为json，字段详细说明如下： identity_type：身份信息参数类型，必填，必须传入CERT_INFO cert_type：证件类型，必填，当前支持身份证，必须传入IDENTITY_CARD cert_name：真实姓名，必填，填写需要验证的真实姓名 cert_no：证件号码，必填，填写需要验证的证件号码
        /// </summary>
        [JsonPropertyName("identity_param")]
        public string IdentityParam { get; set; }

        /// <summary>
        /// 商户个性化配置，格式为json，详细支持的字段说明为： return_url：需要回跳的目标地址，必填，一般指定为商户业务页面。linked_merchant_app_id:商户的appid
        /// </summary>
        [JsonPropertyName("merchant_config")]
        public string MerchantConfig { get; set; }

        /// <summary>
        /// 商户请求的唯一标识，商户要保证其唯一性，值为32位长度的字母数字组合。建议：前面几位字符是商户自定义的简称，中间可以使用一段时间，后段可以使用一个随机或递增序列
        /// </summary>
        [JsonPropertyName("outer_order_no")]
        public string OuterOrderNo { get; set; }
    }
}
