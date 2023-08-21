using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusPredictbuslineSubmitResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusPredictbuslineSubmitResponse : AlipayResponse
    {
        /// <summary>
        /// 预测任务提交返回
        /// </summary>
        [JsonPropertyName("result")]
        public CloudbusSubmitPredictItem Result { get; set; }
    }
}
