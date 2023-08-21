﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiItemCategoryChildrenBatchqueryModel Data Structure.
    /// </summary>
    public class KoubeiItemCategoryChildrenBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 根类目ID. 参数非必传，不传该参数时查询所有的一级类目及递归子类目； 传该参数时，根据入参递归查询子类目信息的列表返回
        /// </summary>
        [JsonPropertyName("root_category_id")]
        public string RootCategoryId { get; set; }
    }
}
