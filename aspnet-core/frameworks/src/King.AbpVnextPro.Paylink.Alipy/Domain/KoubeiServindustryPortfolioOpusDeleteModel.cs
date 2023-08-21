using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiServindustryPortfolioOpusDeleteModel Data Structure.
    /// </summary>
    public class KoubeiServindustryPortfolioOpusDeleteModel : AlipayObject
    {
        /// <summary>
        /// 作品ID列表
        /// </summary>
        [JsonPropertyName("opus_ids")]
        public List<string> OpusIds { get; set; }

        /// <summary>
        /// 操作人信息
        /// </summary>
        [JsonPropertyName("portfolio_operator_info")]
        public PortfolioOperatorInfo PortfolioOperatorInfo { get; set; }
    }
}
