using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayCommerceTransportVehicleownerCampaignQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportVehicleownerCampaignQueryModel : AlipayObject
    {
        /// <summary>
        /// 活动id的列表
        /// </summary>
        [JsonPropertyName("activity_id")]
        public List<string> ActivityId { get; set; }
    }
}
