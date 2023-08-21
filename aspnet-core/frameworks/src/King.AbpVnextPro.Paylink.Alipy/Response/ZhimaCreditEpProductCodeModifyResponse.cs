using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// ZhimaCreditEpProductCodeModifyResponse.
    /// </summary>
    public class ZhimaCreditEpProductCodeModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 处理结果：true成功,false失败
        /// </summary>
        [JsonPropertyName("result")]
        public bool Result { get; set; }

        /// <summary>
        /// 更新结果描述
        /// </summary>
        [JsonPropertyName("result_info")]
        public string ResultInfo { get; set; }
    }
}
