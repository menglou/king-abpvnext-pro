using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalCardAuthQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceMedicalCardAuthQueryModel : AlipayObject
    {
        /// <summary>
        /// 机构编码
        /// </summary>
        [JsonPropertyName("ins_code")]
        public string InsCode { get; set; }

        /// <summary>
        /// 持卡人与当前用户的关系
        /// </summary>
        [JsonPropertyName("relation_type")]
        public string RelationType { get; set; }
    }
}
