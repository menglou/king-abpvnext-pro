using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AntMerchantExpandAssetreverseAssignQueryModel Data Structure.
    /// </summary>
    public class AntMerchantExpandAssetreverseAssignQueryModel : AlipayObject
    {
        /// <summary>
        /// 每次拉取最大记录数量，可选值为[1,200] ;
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }
    }
}
