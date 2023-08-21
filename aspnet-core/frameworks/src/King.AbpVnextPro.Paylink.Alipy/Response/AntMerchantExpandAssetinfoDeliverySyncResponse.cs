using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AntMerchantExpandAssetinfoDeliverySyncResponse.
    /// </summary>
    public class AntMerchantExpandAssetinfoDeliverySyncResponse : AlipayResponse
    {
        /// <summary>
        /// 物料信息反馈处理结果
        /// </summary>
        [JsonPropertyName("info_results")]
        public List<AssetResult> InfoResults { get; set; }
    }
}
