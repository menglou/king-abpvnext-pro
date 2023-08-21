﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayEcoEduKtBillingQueryModel Data Structure.
    /// </summary>
    public class AlipayEcoEduKtBillingQueryModel : AlipayObject
    {
        /// <summary>
        /// Isv pid
        /// </summary>
        [JsonPropertyName("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// ISV调用发送账单接口，返回给商户的order_no
        /// </summary>
        [JsonPropertyName("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 学校支付宝pid，直付通填写smid
        /// </summary>
        [JsonPropertyName("school_pid")]
        public string SchoolPid { get; set; }
    }
}
