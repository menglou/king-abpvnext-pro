﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// CredentialsResponseHeader Data Structure.
    /// </summary>
    public class CredentialsResponseHeader : AlipayObject
    {
        /// <summary>
        /// 200=成功，400=请求错误，403=bundle查询不到。 Status code used to indicate an error, or "200" for success.
        /// </summary>
        [JsonPropertyName("status_code")]
        public string StatusCode { get; set; }

        /// <summary>
        /// Not parsed programmatically. Example "Downstream system offline".
        /// </summary>
        [JsonPropertyName("status_message")]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Conveys failure codes from downstream entities or for more granular conveyance of specific error conditions.
        /// </summary>
        [JsonPropertyName("sub_status_code")]
        public string SubStatusCode { get; set; }
    }
}
