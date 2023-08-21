using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AntMerchantExpandAssetproduceAssignQueryModel Data Structure.
    /// </summary>
    public class AntMerchantExpandAssetproduceAssignQueryModel : AlipayObject
    {
        /// <summary>
        /// 每次拉取最大记录数量，可选值为[1,200] ;
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }
    }
}
