﻿using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenAppServiceMiniappnearbypoipageQueryResponse.
    /// </summary>
    public class AlipayOpenAppServiceMiniappnearbypoipageQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 服务poi信息列表
        /// </summary>
        [JsonPropertyName("addresses")]
        public AddressDTO Addresses { get; set; }

        /// <summary>
        /// 当前页数
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [JsonPropertyName("total")]
        public long Total { get; set; }
    }
}
