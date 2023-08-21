﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEcoMycarParkingBusinessModifyResponse.
    /// </summary>
    public class AlipayEcoMycarParkingBusinessModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 接口调用结果:0成功，1失败
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }
    }
}
