using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayDataRiskRtopobtsregQueryModel Data Structure.
    /// </summary>
    public class AlipayDataRiskRtopobtsregQueryModel : AlipayObject
    {
        /// <summary>
        /// rowkeys+不需要唯一+鹰眼项目，通过open api接口查询舆情
        /// </summary>
        [JsonPropertyName("rowkeys")]
        public string Rowkeys { get; set; }
    }
}
