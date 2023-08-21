﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayBossFncAntbudgetApplyResponse.
    /// </summary>
    public class AlipayBossFncAntbudgetApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 申请成功后的记录列表
        /// </summary>
        [JsonPropertyName("result_data")]
        public List<BizActionLogDTO> ResultData { get; set; }

        /// <summary>
        /// 错误具体信息描述
        /// </summary>
        [JsonPropertyName("result_msg")]
        public string ResultMsg { get; set; }
    }
}
