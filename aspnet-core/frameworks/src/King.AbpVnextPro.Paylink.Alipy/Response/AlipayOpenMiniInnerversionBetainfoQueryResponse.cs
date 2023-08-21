using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerversionBetainfoQueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerversionBetainfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 邀测结果列表
        /// </summary>
        [JsonPropertyName("plugin_beta_item_list")]
        public List<PluginBetaItemInfo> PluginBetaItemList { get; set; }

        /// <summary>
        /// 邀测状态，待确认WAITCHECK/确认CHECKED/拒绝REJECT
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
