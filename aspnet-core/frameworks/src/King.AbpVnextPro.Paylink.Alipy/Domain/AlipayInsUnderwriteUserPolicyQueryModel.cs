﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayInsUnderwriteUserPolicyQueryModel Data Structure.
    /// </summary>
    public class AlipayInsUnderwriteUserPolicyQueryModel : AlipayObject
    {
        /// <summary>
        /// 页码，必须为大于0的整数， 1表示第一页，2表示第2页，依次类推。不填默认值为1
        /// </summary>
        [JsonPropertyName("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页记录条数，必须为大于0的整数，最大值为20,不填默认值为10
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 查询对应的保险干系人
        /// </summary>
        [JsonPropertyName("person")]
        public InsQueryPerson Person { get; set; }

        /// <summary>
        /// 查询的保单对于的产品列表。查询返回的结果是这几个产品下的保单,格式为:  [产品码1,产品码2,...]
        /// </summary>
        [JsonPropertyName("product_list")]
        public List<string> ProductList { get; set; }

        /// <summary>
        /// 保单状态.INEFFECTIVE:未生效、GUARANTEE:保障中、EXPIRED:已失效、SURRENDERRED:已退保、ALL: 所有保单  不填默认值为ALL(所有保单)
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
