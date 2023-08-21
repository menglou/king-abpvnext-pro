using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiCateringDishSpecgroupSyncResponse.
    /// </summary>
    public class KoubeiCateringDishSpecgroupSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 12323
        /// </summary>
        [JsonPropertyName("kbdish_spec_group_id")]
        public string KbdishSpecGroupId { get; set; }
    }
}
