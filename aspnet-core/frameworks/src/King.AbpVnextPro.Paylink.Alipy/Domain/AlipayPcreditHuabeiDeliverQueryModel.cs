using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiDeliverQueryModel Data Structure.
    /// </summary>
    public class AlipayPcreditHuabeiDeliverQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务参数
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }
    }
}
