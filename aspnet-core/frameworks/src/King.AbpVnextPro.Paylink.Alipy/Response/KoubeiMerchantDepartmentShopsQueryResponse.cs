﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiMerchantDepartmentShopsQueryResponse.
    /// </summary>
    public class KoubeiMerchantDepartmentShopsQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 根据部门id查询返回的门店模型列表
        /// </summary>
        [JsonPropertyName("city_shop_models")]
        public List<CityShopModel> CityShopModels { get; set; }

        /// <summary>
        /// 部门id
        /// </summary>
        [JsonPropertyName("dept_id")]
        public string DeptId { get; set; }
    }
}
