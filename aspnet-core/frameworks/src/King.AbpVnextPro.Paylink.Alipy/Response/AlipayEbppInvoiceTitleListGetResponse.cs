using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEbppInvoiceTitleListGetResponse.
    /// </summary>
    public class AlipayEbppInvoiceTitleListGetResponse : AlipayResponse
    {
        /// <summary>
        /// 抬头列表
        /// </summary>
        [JsonPropertyName("title_list")]
        public List<InvoiceTitleModel> TitleList { get; set; }
    }
}
