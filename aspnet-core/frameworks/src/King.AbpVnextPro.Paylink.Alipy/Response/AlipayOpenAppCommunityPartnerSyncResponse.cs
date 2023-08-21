using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenAppCommunityPartnerSyncResponse.
    /// </summary>
    public class AlipayOpenAppCommunityPartnerSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 目标对象数据
        /// </summary>
        [JsonPropertyName("target_list")]
        public List<CommunityPartnerRelationDataSyncDTO> TargetList { get; set; }
    }
}
