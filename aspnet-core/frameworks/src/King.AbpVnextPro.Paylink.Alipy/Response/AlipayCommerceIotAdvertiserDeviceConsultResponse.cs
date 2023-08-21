using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceIotAdvertiserDeviceConsultResponse.
    /// </summary>
    public class AlipayCommerceIotAdvertiserDeviceConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 设备关联数据
        /// </summary>
        [JsonPropertyName("result")]
        public List<DeviceRelationData> Result { get; set; }
    }
}
