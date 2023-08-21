﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// StudyAccountInfo Data Structure.
    /// </summary>
    public class StudyAccountInfo : AlipayObject
    {
        /// <summary>
        /// 校园卡ID
        /// </summary>
        [JsonPropertyName("alipay_card_no")]
        public string AlipayCardNo { get; set; }

        /// <summary>
        /// 校园卡类型
        /// </summary>
        [JsonPropertyName("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 支付宝终身学习账户id
        /// </summary>
        [JsonPropertyName("study_id")]
        public string StudyId { get; set; }
    }
}
