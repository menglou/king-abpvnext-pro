using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceIotPrintmodelPrintSendResponse.
    /// </summary>
    public class AlipayCommerceIotPrintmodelPrintSendResponse : AlipayResponse
    {
        /// <summary>
        /// 调用任务id
        /// </summary>
        [JsonPropertyName("task_id")]
        public string TaskId { get; set; }
    }
}
