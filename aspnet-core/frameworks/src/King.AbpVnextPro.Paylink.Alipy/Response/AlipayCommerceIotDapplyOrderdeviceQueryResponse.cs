using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceIotDapplyOrderdeviceQueryResponse.
    /// </summary>
    public class AlipayCommerceIotDapplyOrderdeviceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 设备信息列表
        /// </summary>
        [JsonPropertyName("device_infos")]
        public List<DeviceApplyOrderDeviceModel> DeviceInfos { get; set; }
    }
}
