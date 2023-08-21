﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenAuthOperatorAddResponse.
    /// </summary>
    public class AlipayOpenAuthOperatorAddResponse : AlipayResponse
    {
        /// <summary>
        /// 关联账号列表
        /// </summary>
        [JsonPropertyName("accounts")]
        public List<OperatorAccountVO> Accounts { get; set; }

        /// <summary>
        /// 创建的蚂蚁操作员ID
        /// </summary>
        [JsonPropertyName("operator_id")]
        public string OperatorId { get; set; }
    }
}
