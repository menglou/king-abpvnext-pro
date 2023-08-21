using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayCommerceIotSupplierAssetModifyModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotSupplierAssetModifyModel : AlipayObject
    {
        /// <summary>
        /// 供应商设备信息
        /// </summary>
        [JsonPropertyName("record")]
        public SupplierAssetResponse Record { get; set; }
    }
}
