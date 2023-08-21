﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEbppCommunityRelationshipCreateResponse.
    /// </summary>
    public class AlipayEbppCommunityRelationshipCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 物业和小区的绑定实体ID
        /// </summary>
        [JsonPropertyName("relationship_id")]
        public string RelationshipId { get; set; }
    }
}
