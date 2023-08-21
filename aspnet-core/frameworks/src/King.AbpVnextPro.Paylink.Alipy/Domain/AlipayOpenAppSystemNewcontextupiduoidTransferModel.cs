using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenAppSystemNewcontextupiduoidTransferModel Data Structure.
    /// </summary>
    public class AlipayOpenAppSystemNewcontextupiduoidTransferModel : AlipayObject
    {
        /// <summary>
        /// 101
        /// </summary>
        [JsonPropertyName("param_one")]
        public string ParamOne { get; set; }
    }
}
