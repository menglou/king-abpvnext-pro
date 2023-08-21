using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMarketingCampaignSubcertQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignSubcertQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 子凭证详细信息
        /// </summary>
        [JsonPropertyName("subcert_list")]
        public List<SubCertDetail> SubcertList { get; set; }

        /// <summary>
        /// 有效子凭证条数
        /// </summary>
        [JsonPropertyName("total_num")]
        public string TotalNum { get; set; }
    }
}
