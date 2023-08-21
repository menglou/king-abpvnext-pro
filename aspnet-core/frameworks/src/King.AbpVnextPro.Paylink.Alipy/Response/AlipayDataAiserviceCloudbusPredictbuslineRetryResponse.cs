using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusPredictbuslineRetryResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusPredictbuslineRetryResponse : AlipayResponse
    {
        /// <summary>
        /// 预测任务提交返回
        /// </summary>
        [JsonPropertyName("result")]
        public CloudbusRetryPredictItem Result { get; set; }
    }
}
