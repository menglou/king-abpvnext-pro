using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiMerchantKbdeviceDevicesBatchqueryResponse.
    /// </summary>
    public class KoubeiMerchantKbdeviceDevicesBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 门店下设备列表
        /// </summary>
        [JsonPropertyName("device_info_list")]
        public List<DeviceInfo> DeviceInfoList { get; set; }
    }
}
