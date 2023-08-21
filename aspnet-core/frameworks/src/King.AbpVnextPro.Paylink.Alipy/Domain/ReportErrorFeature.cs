using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ReportErrorFeature Data Structure.
    /// </summary>
    public class ReportErrorFeature : AlipayObject
    {
        /// <summary>
        /// 桌号
        /// </summary>
        [JsonPropertyName("table_num")]
        public string TableNum { get; set; }
    }
}
