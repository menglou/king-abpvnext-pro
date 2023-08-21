using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AntMerchantExpandAssetreverseAssignSyncResponse.
    /// </summary>
    public class AntMerchantExpandAssetreverseAssignSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 取消订单或退货指令接收反馈，处理结果
        /// </summary>
        [JsonPropertyName("delivery_results")]
        public List<AssetResult> DeliveryResults { get; set; }
    }
}
