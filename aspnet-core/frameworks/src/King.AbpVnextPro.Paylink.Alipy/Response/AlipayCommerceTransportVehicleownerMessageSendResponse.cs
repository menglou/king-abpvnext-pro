using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceTransportVehicleownerMessageSendResponse.
    /// </summary>
    public class AlipayCommerceTransportVehicleownerMessageSendResponse : AlipayResponse
    {
        /// <summary>
        /// 批量发送结果
        /// </summary>
        [JsonPropertyName("send_result_list")]
        public List<VehicleMsgSendResultEntity> SendResultList { get; set; }
    }
}
