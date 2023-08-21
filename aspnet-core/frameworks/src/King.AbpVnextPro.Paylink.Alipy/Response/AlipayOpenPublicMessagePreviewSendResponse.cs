using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenPublicMessagePreviewSendResponse.
    /// </summary>
    public class AlipayOpenPublicMessagePreviewSendResponse : AlipayResponse
    {
        /// <summary>
        /// 消息发送错误数据
        /// </summary>
        [JsonPropertyName("error_datas")]
        public List<MsgSendErrorData> ErrorDatas { get; set; }
    }
}
