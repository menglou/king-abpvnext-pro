using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiAdvertCommissionChannelCreateResponse.
    /// </summary>
    public class KoubeiAdvertCommissionChannelCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 新增渠道接口，需要记录渠道ID
        /// </summary>
        [JsonPropertyName("channel_response")]
        public List<KbAdvertChannelResponse> ChannelResponse { get; set; }
    }
}
