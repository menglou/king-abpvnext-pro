using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayInsSceneApplicationCancelModel Data Structure.
    /// </summary>
    public class AlipayInsSceneApplicationCancelModel : AlipayObject
    {
        /// <summary>
        /// 投保订单号
        /// </summary>
        [JsonPropertyName("application_no")]
        public string ApplicationNo { get; set; }
    }
}
