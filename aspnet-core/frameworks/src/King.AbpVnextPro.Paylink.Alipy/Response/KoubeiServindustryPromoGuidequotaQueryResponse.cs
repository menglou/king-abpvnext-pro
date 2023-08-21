using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiServindustryPromoGuidequotaQueryResponse.
    /// </summary>
    public class KoubeiServindustryPromoGuidequotaQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 权限份额
        /// </summary>
        [JsonPropertyName("auth_quota")]
        public List<IgAuthQuota> AuthQuota { get; set; }
    }
}
