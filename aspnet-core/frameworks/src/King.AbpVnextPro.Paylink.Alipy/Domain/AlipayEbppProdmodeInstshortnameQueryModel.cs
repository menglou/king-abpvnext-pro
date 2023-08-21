using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayEbppProdmodeInstshortnameQueryModel Data Structure.
    /// </summary>
    public class AlipayEbppProdmodeInstshortnameQueryModel : AlipayObject
    {
        /// <summary>
        /// 出账机构中文名称
        /// </summary>
        [JsonPropertyName("chargeinst_cn_name")]
        public string ChargeinstCnName { get; set; }
    }
}
