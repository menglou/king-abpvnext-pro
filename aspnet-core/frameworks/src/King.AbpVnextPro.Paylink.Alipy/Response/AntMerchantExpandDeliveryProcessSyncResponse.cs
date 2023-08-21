using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AntMerchantExpandDeliveryProcessSyncResponse.
    /// </summary>
    public class AntMerchantExpandDeliveryProcessSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 响应参数
        /// </summary>
        [JsonPropertyName("result")]
        public AssetResult Result { get; set; }
    }
}
