using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayAccountExrateConfigQueryModel Data Structure.
    /// </summary>
    public class AlipayAccountExrateConfigQueryModel : AlipayObject
    {
        /// <summary>
        /// 国际同步到主站的scheduler配置的编码信息,唯一表示一条scheduler配置
        /// </summary>
        [JsonPropertyName("scheduler_code")]
        public string SchedulerCode { get; set; }
    }
}
