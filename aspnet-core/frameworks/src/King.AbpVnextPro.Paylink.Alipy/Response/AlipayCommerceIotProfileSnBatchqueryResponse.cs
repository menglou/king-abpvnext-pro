using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceIotProfileSnBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceIotProfileSnBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// sn列表
        /// </summary>
        [JsonPropertyName("sn_list")]
        public List<ProfileSnDetail> SnList { get; set; }
    }
}
