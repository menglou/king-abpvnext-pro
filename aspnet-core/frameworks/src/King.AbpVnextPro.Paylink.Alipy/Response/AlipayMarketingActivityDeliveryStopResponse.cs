using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMarketingActivityDeliveryStopResponse.
    /// </summary>
    public class AlipayMarketingActivityDeliveryStopResponse : AlipayResponse
    {
        /// <summary>
        /// 停止失败的投放配置列表
        /// </summary>
        [JsonPropertyName("error_delivery_config_list")]
        public List<ErrorDeliveryConfig> ErrorDeliveryConfigList { get; set; }

        /// <summary>
        /// 停止成功的投放配置列表
        /// </summary>
        [JsonPropertyName("success_delivery_config_list")]
        public List<SuccessDeliveryConfig> SuccessDeliveryConfigList { get; set; }
    }
}
