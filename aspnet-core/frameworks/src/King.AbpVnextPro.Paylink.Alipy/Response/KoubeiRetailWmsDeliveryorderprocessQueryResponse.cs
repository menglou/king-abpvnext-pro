using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiRetailWmsDeliveryorderprocessQueryResponse.
    /// </summary>
    public class KoubeiRetailWmsDeliveryorderprocessQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 物流单据状态列表
        /// </summary>
        [JsonPropertyName("delivery_order_process_vo_list")]
        public List<DeliveryOrderProcessVO> DeliveryOrderProcessVoList { get; set; }
    }
}
