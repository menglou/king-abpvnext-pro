using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenAppSystemOldcontextTransferModel Data Structure.
    /// </summary>
    public class AlipayOpenAppSystemOldcontextTransferModel : AlipayObject
    {
        /// <summary>
        /// 10
        /// </summary>
        [JsonPropertyName("param_one")]
        public string ParamOne { get; set; }
    }
}
