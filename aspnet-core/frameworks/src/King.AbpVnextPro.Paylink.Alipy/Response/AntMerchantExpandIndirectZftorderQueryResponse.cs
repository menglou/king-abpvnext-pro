using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AntMerchantExpandIndirectZftorderQueryResponse.
    /// </summary>
    public class AntMerchantExpandIndirectZftorderQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 直付通二级商户进件申请单信息
        /// </summary>
        [JsonPropertyName("orders")]
        public List<ZftSubMerchantOrder> Orders { get; set; }
    }
}
