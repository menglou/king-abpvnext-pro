﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ZhimaCreditEpSceneAgreementUseModel Data Structure.
    /// </summary>
    public class ZhimaCreditEpSceneAgreementUseModel : AlipayObject
    {
        /// <summary>
        /// 特定业务场景传输的扩展参数，以JSON形式传输。具体业务场景需要传入参数请参考<a href="https://docs.open.alipay.com/11270#s3">业务场景传输的扩展参数</a>
        /// </summary>
        [JsonPropertyName("biz_ext_param")]
        public string BizExtParam { get; set; }

        /// <summary>
        /// 业务时间，日期格式为 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 商户请求订单号，必须唯一。用于唯一标识商户的一笔业务请求。
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 条款编码。请参考<a href="https://docs.open.alipay.com/11270#s1">条款编码</a>
        /// </summary>
        [JsonPropertyName("provision_code")]
        public string ProvisionCode { get; set; }

        /// <summary>
        /// 评估订单号。用户完成信用评估的芝麻信用评估订单号，即为<a href="https://opendocs.alipay.com/apis/api_8/zhima.credit.ep.scene.rating.initialize">zhima.credit.ep.scene.rating.initialize</a>接口初始化后返回的 order_no，初始化后还需调用<a href="https://opendocs.alipay.com/apis/api_8/zhima.credit.ep.scene.rating.apply">zhima.credit.ep.scene.rating.apply</a>接口发起信用评估。
        /// </summary>
        [JsonPropertyName("rating_order_no")]
        public string RatingOrderNo { get; set; }
    }
}
