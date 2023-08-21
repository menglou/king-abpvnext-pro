using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceIotServicemodelServicelistQueryResponse.
    /// </summary>
    public class AlipayCommerceIotServicemodelServicelistQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 设备服务列表
        /// </summary>
        [JsonPropertyName("list")]
        public List<DeviceServiceVO> List { get; set; }
    }
}
