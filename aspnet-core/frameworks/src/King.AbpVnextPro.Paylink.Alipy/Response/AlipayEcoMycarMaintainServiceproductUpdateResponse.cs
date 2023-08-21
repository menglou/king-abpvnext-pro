using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEcoMycarMaintainServiceproductUpdateResponse.
    /// </summary>
    public class AlipayEcoMycarMaintainServiceproductUpdateResponse : AlipayResponse
    {
        /// <summary>
        /// 车主平台生成的产品编号  新增：必填
        /// </summary>
        [JsonPropertyName("product_id")]
        public long ProductId { get; set; }
    }
}
