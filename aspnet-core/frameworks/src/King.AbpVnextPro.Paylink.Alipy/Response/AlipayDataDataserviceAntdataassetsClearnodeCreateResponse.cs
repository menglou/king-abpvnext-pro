using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayDataDataserviceAntdataassetsClearnodeCreateResponse.
    /// </summary>
    public class AlipayDataDataserviceAntdataassetsClearnodeCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 清除任务操作是否成功
        /// </summary>
        [JsonPropertyName("result")]
        public bool Result { get; set; }
    }
}
