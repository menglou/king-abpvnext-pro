using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiMarketingDataCustomreportDetailQueryModel Data Structure.
    /// </summary>
    public class KoubeiMarketingDataCustomreportDetailQueryModel : AlipayObject
    {
        /// <summary>
        /// 自定义报表的规则KEY
        /// </summary>
        [JsonPropertyName("condition_key")]
        public string ConditionKey { get; set; }
    }
}
