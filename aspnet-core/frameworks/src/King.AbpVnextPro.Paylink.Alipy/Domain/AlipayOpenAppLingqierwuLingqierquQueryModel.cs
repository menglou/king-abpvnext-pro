using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenAppLingqierwuLingqierquQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAppLingqierwuLingqierquQueryModel : AlipayObject
    {
        /// <summary>
        /// 12
        /// </summary>
        [JsonPropertyName("test")]
        public List<string> Test { get; set; }
    }
}
