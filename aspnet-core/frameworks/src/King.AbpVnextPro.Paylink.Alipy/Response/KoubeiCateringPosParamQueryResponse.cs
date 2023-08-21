using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiCateringPosParamQueryResponse.
    /// </summary>
    public class KoubeiCateringPosParamQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 门店参数model
        /// </summary>
        [JsonPropertyName("param_model")]
        public ParamModel ParamModel { get; set; }
    }
}
