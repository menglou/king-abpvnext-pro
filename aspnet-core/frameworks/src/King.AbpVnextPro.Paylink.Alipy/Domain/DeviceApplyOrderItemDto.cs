﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// DeviceApplyOrderItemDto Data Structure.
    /// </summary>
    public class DeviceApplyOrderItemDto : AlipayObject
    {
        /// <summary>
        /// 申请数量，和sn数量保持一致
        /// </summary>
        [JsonPropertyName("apply_amount")]
        public long ApplyAmount { get; set; }

        /// <summary>
        /// 订单计费模式 BILL（计费），NON_BILL（非计费）
        /// </summary>
        [JsonPropertyName("billed")]
        public string Billed { get; set; }

        /// <summary>
        /// itemId
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 设备型号
        /// </summary>
        [JsonPropertyName("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 设备型号
        /// </summary>
        [JsonPropertyName("model_number")]
        public string ModelNumber { get; set; }

        /// <summary>
        /// 销售单价 保留两位小数
        /// </summary>
        [JsonPropertyName("selling_price")]
        public string SellingPrice { get; set; }

        /// <summary>
        /// sn列表
        /// </summary>
        [JsonPropertyName("sn_list")]
        public List<string> SnList { get; set; }

        /// <summary>
        /// 厂商id
        /// </summary>
        [JsonPropertyName("supplier_id")]
        public string SupplierId { get; set; }
    }
}
