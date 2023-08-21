using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenMiniAmpeDevicetypeBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniAmpeDevicetypeBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 设备类型列表
        /// </summary>
        [JsonPropertyName("device_type_list")]
        public List<AmpeDeviceTypeInfo> DeviceTypeList { get; set; }
    }
}
