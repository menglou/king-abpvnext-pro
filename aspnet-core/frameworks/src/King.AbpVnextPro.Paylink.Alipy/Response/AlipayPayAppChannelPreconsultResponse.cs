using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayPayAppChannelPreconsultResponse.
    /// </summary>
    public class AlipayPayAppChannelPreconsultResponse : AlipayResponse
    {
        /// <summary>
        /// 渠道信息列表
        /// </summary>
        [JsonPropertyName("channel_info_list")]
        public List<ChannelItem> ChannelInfoList { get; set; }

        /// <summary>
        /// 咨询上下文id
        /// </summary>
        [JsonPropertyName("pre_consult_id")]
        public string PreConsultId { get; set; }
    }
}
