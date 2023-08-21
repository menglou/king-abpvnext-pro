using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AntMerchantExpandAssetreverseCompleteSyncResponse.
    /// </summary>
    public class AntMerchantExpandAssetreverseCompleteSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 取消订单或者退货已经完成时，响应参数
        /// </summary>
        [JsonPropertyName("asset_results")]
        public List<AssetResult> AssetResults { get; set; }
    }
}
