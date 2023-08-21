using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// TradeSettleInfo Data Structure.
    /// </summary>
    public class TradeSettleInfo : AlipayObject
    {
        /// <summary>
        /// 交易结算明细信息
        /// </summary>
        [JsonPropertyName("trade_settle_detail_list")]
        public List<TradeSettleDetail> TradeSettleDetailList { get; set; }
    }
}
