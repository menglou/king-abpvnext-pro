﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiAuthOrderUnfreezeModel Data Structure.
    /// </summary>
    public class AlipayPcreditHuabeiAuthOrderUnfreezeModel : AlipayObject
    {
        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号，即花呗先享协议号
        /// </summary>
        [JsonPropertyName("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 买家在支付宝的用户id
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// true表示需要解约。false或者不填写表示仅解冻。
        /// </summary>
        [JsonPropertyName("need_terminated")]
        public string NeedTerminated { get; set; }

        /// <summary>
        /// 商户业务订单的简单描述，如商品名称等，长度不超过100个字母或50个汉字
        /// </summary>
        [JsonPropertyName("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 商户本次操作的请求流水号，用于标识请求流水的唯一性，不能包含除中文、英文、数字以外的字符，需要保证在商户端不重复。
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户的支付宝用户id。如果该值为空，则默认为商户签约账号对应的支付宝用户ID。
        /// </summary>
        [JsonPropertyName("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 需要解冻的金额，单位为：元（人民币），精确到小数点后两位
        /// </summary>
        [JsonPropertyName("unfreeze_amount")]
        public string UnfreezeAmount { get; set; }
    }
}
