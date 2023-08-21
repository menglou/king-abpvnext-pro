using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayAssetPointVoucherprodBenefittemplateModifyResponse.
    /// </summary>
    public class AlipayAssetPointVoucherprodBenefittemplateModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 修改后模版的过期时间
        /// </summary>
        [JsonPropertyName("publish_end_time")]
        public string PublishEndTime { get; set; }
    }
}
