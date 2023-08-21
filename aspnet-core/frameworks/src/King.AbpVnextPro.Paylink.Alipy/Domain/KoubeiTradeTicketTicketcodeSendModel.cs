﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiTradeTicketTicketcodeSendModel Data Structure.
    /// </summary>
    public class KoubeiTradeTicketTicketcodeSendModel : AlipayObject
    {
        /// <summary>
        /// 需要发送的码列表。其中 code 表示串码码值，num 表示串码的可核销份数。
        /// </summary>
        [JsonPropertyName("isv_ma_list")]
        public List<KbIsvMaCode> IsvMaList { get; set; }

        /// <summary>
        /// 口碑订单号，可通过 <a href="https://opendocs.alipay.com/apis/api_1/koubei.trade.itemorder.buy">koubei.trade.itemorder.buy</a>(口碑商品交易购买接口)获取。
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 请求 id，唯一标识一次请求，由商家自定义。
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 口碑商品发货单号
        /// </summary>
        [JsonPropertyName("send_order_no")]
        public string SendOrderNo { get; set; }

        /// <summary>
        /// 口碑发码通知透传码商，码商需要跟发码通知获取到的参数一致
        /// </summary>
        [JsonPropertyName("send_token")]
        public string SendToken { get; set; }

        /// <summary>
        /// 券过期时间,默认为口碑商品配置失效时间
        /// </summary>
        [JsonPropertyName("valid_end")]
        public string ValidEnd { get; set; }

        /// <summary>
        /// 券生效时间,默认为口碑商品配置生效时间
        /// </summary>
        [JsonPropertyName("valid_start")]
        public string ValidStart { get; set; }
    }
}
