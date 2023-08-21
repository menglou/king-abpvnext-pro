using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceFixTaskCreateResponse.
    /// </summary>
    public class AlipayCommerceFixTaskCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 创建成功工单的唯一标识id。
        /// </summary>
        [JsonPropertyName("task_id")]
        public long TaskId { get; set; }
    }
}
