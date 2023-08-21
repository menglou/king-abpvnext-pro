﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ShopOrderModifyResult Data Structure.
    /// </summary>
    public class ShopOrderModifyResult : AlipayObject
    {
        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext_infos")]
        public string ExtInfos { get; set; }

        /// <summary>
        /// SUCCESS: 设置成功  INVALID_PARAMETER: 参数错误  SHOP_NOT_EXIST:店铺不存在  NO_PRIVILEGE:没有权限修改此门店  NO_ORDER_INFO:没有开通过点餐  MODIFY_FAILED:修改失败
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 口碑门店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 外部门店编号；最长32位字符，该编号将作为收单接口的入参， 请开发者自行确保其唯一性。
        /// </summary>
        [JsonPropertyName("store_id")]
        public string StoreId { get; set; }
    }
}
