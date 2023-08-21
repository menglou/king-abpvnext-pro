﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayUserFamilyRelationValidQueryResponse.
    /// </summary>
    public class AlipayUserFamilyRelationValidQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 是否加入过家庭
        /// </summary>
        [JsonPropertyName("has_family")]
        public bool HasFamily { get; set; }

        /// <summary>
        /// 是否加入有效家庭
        /// </summary>
        [JsonPropertyName("has_valid_family")]
        public bool HasValidFamily { get; set; }
    }
}
