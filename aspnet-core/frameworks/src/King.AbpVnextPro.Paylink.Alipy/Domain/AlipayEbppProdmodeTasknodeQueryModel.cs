using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayEbppProdmodeTasknodeQueryModel Data Structure.
    /// </summary>
    public class AlipayEbppProdmodeTasknodeQueryModel : AlipayObject
    {
        /// <summary>
        /// 任务编号
        /// </summary>
        [JsonPropertyName("task_id")]
        public string TaskId { get; set; }
    }
}
