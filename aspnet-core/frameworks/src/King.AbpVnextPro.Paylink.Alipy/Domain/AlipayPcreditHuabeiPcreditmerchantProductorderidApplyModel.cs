using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiPcreditmerchantProductorderidApplyModel Data Structure.
    /// </summary>
    public class AlipayPcreditHuabeiPcreditmerchantProductorderidApplyModel : AlipayObject
    {
        /// <summary>
        /// 商户id
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }
    }
}
