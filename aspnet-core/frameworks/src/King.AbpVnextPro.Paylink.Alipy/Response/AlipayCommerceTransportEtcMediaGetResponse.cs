using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceTransportEtcMediaGetResponse.
    /// </summary>
    public class AlipayCommerceTransportEtcMediaGetResponse : AlipayResponse
    {
        /// <summary>
        /// 申请单资料列表
        /// </summary>
        [JsonPropertyName("content_list")]
        public List<MediaContentList> ContentList { get; set; }

        /// <summary>
        /// etc申请单id
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部业务申请单id
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
