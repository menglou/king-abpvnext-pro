using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceIotNetflowInfoQueryResponse.
    /// </summary>
    public class AlipayCommerceIotNetflowInfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 流量充值记录信息
        /// </summary>
        [JsonPropertyName("net_flow_device_offer_info_response")]
        public NetFlowDeviceOfferInfoResponse NetFlowDeviceOfferInfoResponse { get; set; }
    }
}
