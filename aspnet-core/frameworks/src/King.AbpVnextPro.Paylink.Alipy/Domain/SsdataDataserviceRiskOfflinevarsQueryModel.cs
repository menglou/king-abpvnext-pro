using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// SsdataDataserviceRiskOfflinevarsQueryModel Data Structure.
    /// </summary>
    public class SsdataDataserviceRiskOfflinevarsQueryModel : AlipayObject
    {
        /// <summary>
        /// 查询离线变量的主键
        /// </summary>
        [JsonPropertyName("rowkeys")]
        public string Rowkeys { get; set; }
    }
}
