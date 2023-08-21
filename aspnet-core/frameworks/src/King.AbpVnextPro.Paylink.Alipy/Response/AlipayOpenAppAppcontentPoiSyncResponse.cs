using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenAppAppcontentPoiSyncResponse.
    /// </summary>
    public class AlipayOpenAppAppcontentPoiSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝返回的唯一编码
        /// </summary>
        [JsonPropertyName("alipay_poi_id")]
        public string AlipayPoiId { get; set; }
    }
}
