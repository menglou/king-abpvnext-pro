using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AntMerchantExpandFrontcategorySecurityQueryResponse.
    /// </summary>
    public class AntMerchantExpandFrontcategorySecurityQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 前台类目列表
        /// </summary>
        [JsonPropertyName("front_category_list")]
        public List<FrontCategoryInfo> FrontCategoryList { get; set; }
    }
}
