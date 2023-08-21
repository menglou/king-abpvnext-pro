using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AntMerchantExpandAssetinfoCorrectionSyncModel Data Structure.
    /// </summary>
    public class AntMerchantExpandAssetinfoCorrectionSyncModel : AlipayObject
    {
        /// <summary>
        /// 物料信息更正请求
        /// </summary>
        [JsonPropertyName("asset_correction")]
        public AssetInfoCorrectionItem AssetCorrection { get; set; }
    }
}
